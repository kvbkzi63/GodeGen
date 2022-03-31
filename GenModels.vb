Imports System.Data.OracleClient
Imports System.IO
Imports System.Text
Imports System.Globalization

Public Class GenModels

    Private Shared ModelName As String = ""
    Private Shared _TableName As String = ""
    Private Shared _ViewName As String = ""
    Private Shared genPath As String = ""
    Public Shared QueryColumns As New List(Of String)
    Private Shared _dgv As DataGridView
    Private Shared _System As String = ""

    ''' <summary>
    ''' 產生程式碼
    ''' </summary>
    ''' <param name="dir"></param>
    ''' <param name="tableName"></param>
    ''' <param name="sqlConn" ></param>
    ''' <remarks></remarks>
    Public Shared Sub genCode(ByRef dir As String, ByVal tableName As String, ByVal MdName As String, ByVal dgv As DataGridView, ByRef sqlConn As String)
        _dgv = dgv
        _System = dgv.Rows(0).Cells("SystemName").Value
        For Each r As DataGridViewRow In _dgv.Rows
            If r.Cells("QueryColumn").Value Then
                QueryColumns.Add(r.Cells("ColumnName").Value)
            End If
        Next

        ModelName = MdName
        _TableName = tableName
        genPath = dir
        Dim ds As DataSet = getTable(tableName, sqlConn)
        Dim ColumnsComment = getTableComment(tableName, sqlConn)
        Dim colName(ds.Tables(0).Columns.Count - 1) As String
        Dim colType(ds.Tables(0).Columns.Count - 1) As String
        Dim colComment(ds.Tables(0).Columns.Count - 1) As String
        Dim colLength(ds.Tables(0).Columns.Count - 1) As Integer
        Dim i = 0
        For Each col As DataColumn In ds.Tables(0).Columns
            colName(i) = col.ColumnName
            colType(i) = col.DataType.ToString
            colLength(i) = col.MaxLength
            colComment(i) = ColumnsComment.Tables(0).AsEnumerable.Where(Function(c) c.Item("column_name") = col.ColumnName).Select(Function(x) x.Item("comments").ToString).First
            i += 1
        Next

        Dim pkCol As DataColumn() = ds.Tables(0).PrimaryKey
        Dim pkcolName(pkCol.Count - 1) As String
        Dim usePK As Boolean = False
        If pkCol.Length > 0 Then
            usePK = True
            Dim pkcolType(pkCol.Count - 1) As String
            Dim j = 0
            For Each col As DataColumn In pkCol
                pkcolName(j) = col.ColumnName
                j += 1
            Next
        End If
        Dim content As StringBuilder
        content = getModelFields(False)
        outputFile(content.ToString, "Models", ModelName & "Model", "cs")
    End Sub


    ''' <summary>
    ''' 取得 Table 欄位資料
    ''' </summary>
    ''' <param name="tableName"></param>
    ''' <param name="sqlConns" ></param>
    ''' <remarks></remarks>
    Public Shared Function getTable(ByVal tableName As String, ByRef sqlConns As String) As DataSet
        Try
            Dim ds As DataSet
            Dim sqlConn = New OracleConnection(sqlConns)
            Dim command As OracleCommand = sqlConn.CreateCommand()
            command.CommandText = "select * from " & tableName & " where 1=2"


            Using adapter As OracleDataAdapter = New OracleDataAdapter(command)
                ds = New DataSet(tableName)
                adapter.Fill(ds, tableName)
                adapter.FillSchema(ds, SchemaType.Mapped, tableName)
            End Using

            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' 取得 Table 欄位備註
    ''' </summary>
    ''' <param name="tableName"></param>
    ''' <param name="sqlConns" ></param>
    ''' <remarks></remarks>
    Public Shared Function getTableComment(ByVal tableName As String, ByRef sqlConns As String) As DataSet
        Try
            Dim ds As DataSet
            Dim sqlConn = New OracleConnection(sqlConns)
            Dim command As OracleCommand = sqlConn.CreateCommand()

            Dim Content As New StringBuilder
            Content.AppendLine("select column_name")
            Content.AppendLine("     , comments")
            Content.AppendLine("  from dba_col_comments")
            Content.AppendLine(" where table_name = upper('" & tableName & "')")
            command.CommandText = Content.ToString

            Using adapter As OracleDataAdapter = New OracleDataAdapter(command)
                ds = New DataSet(tableName)
                adapter.Fill(ds, tableName)
                adapter.FillSchema(ds, SchemaType.Mapped, tableName)
            End Using

            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function
    ''' <summary>
    ''' 建立Model & View Model範本
    ''' </summary>
    ''' <param name="colName"></param>
    ''' <param name="colType"></param>
    ''' <param name="colComm"></param>
    ''' <param name="colQuery"></param>
    ''' <returns></returns>
    Private Shared Function getModelFields(ByVal isViewModel As Boolean) As StringBuilder
        Dim content As StringBuilder = New StringBuilder()
        content.AppendLine("using System;")
        content.AppendLine(" ")
        content.AppendLine("namespace " & _System & ".Models")
        content.AppendLine("{")
        content.AppendLine("    public class " & ModelName & "Model")
        content.AppendLine("    {")
        For Each r As DataGridViewRow In _dgv.Rows
            content.AppendLine("        ///長度的部份根據屬性而定")
            content.AppendLine("        [DBColumn()]")
            content.AppendLine("         public ").Append(r.Cells("ModelColumn").Value).Append(" ").Append(r.Cells("ColumnName").Value).Append(" { get; set; }")
            content.AppendLine("")
        Next
        If isViewModel Then
            content.AppendLine("        /// <summary>")
            content.AppendLine("        /// 表單狀態")
            content.AppendLine("        /// </summary>")
            content.AppendLine("        public string FormStatus { get; set; }")
        End If
        content.AppendLine("    }")
        content.AppendLine("}")

        Return content
    End Function

    Private Shared Sub outputFile(ByVal content As String, ByVal folder As String, ByVal fileName As String, ByVal fileExt As String)

        Dim path As String = genPath & "\" & folder & "\" & ModelName.Substring(0, 3)
        Dim dir As New DirectoryInfo(path)
        If dir.Exists = False Then
            dir.Create()
        End If

        Dim fs As New FileStream(path & "\" & fileName & "." & fileExt, FileMode.Create, FileAccess.Write)

        Dim s As New StreamWriter(fs, Encoding.UTF8)
        s.BaseStream.Seek(0, SeekOrigin.End)
        s.WriteLine(content)
        s.Close()

    End Sub
End Class
