Imports System.Data.OracleClient
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports TfsTool

Public Class CodeGenUI

    Private Sub btn_GenModel_Click(sender As Object, e As EventArgs) Handles btn_GenModel.Click
        If DataGridView1.Rows.Count > 0 Then
            GenModels.genCode(txt_Dir.Text, cbo_Table.SelectedItem, txt_ModelName.Text, DataGridView1, txt_ConnStr.Text)
            MessageBox.Show("檔案產生完畢!!")

        End If
    End Sub

    Public Function getAllTable() As DataSet
        Try
            Dim ds As DataSet


            Dim sqlConn As OracleConnection = New OracleConnection(txt_ConnStr.Text.ToString.TrimStart.TrimEnd)

            Dim command As OracleCommand = sqlConn.CreateCommand()

            command.CommandText = "SELECT table_name FROM user_tables where table_name not like '%_BK' order by table_name"
            Using adapter As OracleDataAdapter = New OracleDataAdapter(command)
                ds = New DataSet("atable")
                adapter.Fill(ds, "atable")
                adapter.FillSchema(ds, SchemaType.Mapped, "atable")
            End Using
            Dim x As New HashSet(Of String)
            For Each row As DataRow In ds.Tables(0).Rows
                If "_" = row.Item(0).ToString.Substring(0, 1) Then
                    Console.WriteLine(row.Item(0).ToString & "  Error Table")
                ElseIf row.Item(0).ToString.Length >= 3 Then
                    cbo_Table.Items.Add(row.Item(0).ToString)
                    Console.WriteLine(row.Item(0).ToString)
                End If
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getAllTable()
        txt_System.Focus()

    End Sub

    Private Sub cbo_Table_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Table.SelectedIndexChanged

        If txt_System.Text = "" Then
            MessageBox.Show("系統別未填")
            Exit Sub
        End If
        Dim dsColumn = GenModels.getTable(cbo_Table.SelectedItem, txt_ConnStr.Text)
        Dim dsComment = GenModels.getTableComment(cbo_Table.SelectedItem, txt_ConnStr.Text)

        DataGridView1.Rows.Clear()
        For Each c As DataColumn In dsColumn.Tables(0).Columns
            Dim cmm As String = dsComment.Tables(0).AsEnumerable.Where(Function(y) y.Item(0).ToString = c.ColumnName).Select(Function(x) x.Item(1)).FirstOrDefault
            DataGridView1.Rows.Add(False, dsColumn.Tables(0).PrimaryKey.Contains(c), txt_System.Text, c.ColumnName, cmm, c.DataType, c.DataType.ToString, 1, Not c.AllowDBNull)
        Next


    End Sub
    Private Sub btn_SelectDataExcel_Click(sender As Object, e As EventArgs) Handles btn_SelectDataExcel.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                txt_ExcelFileName.Text = OpenFileDialog1.FileName
                txt_ExcelFileName.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_TransDataTodb_Click(sender As Object, e As EventArgs) Handles btn_TransDataTodb.Click
        If txt_TransDataConnStr.Text = "" Then Exit Sub
        Try
            Dim Ts As TransExcelDataToDBScript = New TransExcelDataToDBScript()
            Dim ds As DataSet = Ts.LoadFile(txt_ExcelFileName.Text)

            rtb_Script.Text = Ts.GenDBScript(ds, txt_TransDataConnStr.Text)

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

End Class
