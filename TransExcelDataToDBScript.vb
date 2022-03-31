Imports System.Data.OleDb
Imports System.Text
Imports Microsoft.Office.Interop

Public Class TransExcelDataToDBScript

    Private _ExcelFileName As String = ""
    Private _Data As DataSet = Nothing
    Public Property ExcelFileName As String
        Get
            Return _ExcelFileName
        End Get
        Set(value As String)
            _ExcelFileName = value
        End Set
    End Property


#Region "            讀取檔案"

    ''' <summary>
    ''' 讀取檔案，根據檔名決定為Excel或Access資料庫之資料表。
    ''' 回傳 Table Name 為 Basic 的 Dataset
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function LoadFile(ByVal DataPath As String) As DataSet
        ExcelFileName = DataPath
        Dim officeType = Type.GetTypeFromProgID("Excel.Application")

        If officeType Is Nothing Then
            Console.WriteLine("Sorry, Excel must be installed!")
            Console.WriteLine("Press any key to exit")
            Console.ReadLine()
        End If

        Dim xlApp As Excel.Application = Nothing
        Dim workbooks As Excel.Workbooks = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim sheets As Excel.Sheets = Nothing

        Try
            xlApp = New Excel.Application()
            Console.WriteLine($"Trying to open file {ExcelFileName}")
            workbooks = xlApp.Workbooks
            xlWorkBook = workbooks.Open(ExcelFileName)
            Dim dic = New List(Of String)()

            For Each mSheet In xlApp.Sheets

                dic.Add($"{mSheet.Name}")
            Next

            Using myConnection = New OleDbConnection($"Provider=Microsoft.Ace.OLEDB.12.0;Data Source={ExcelFileName};Extended Properties='Excel 12.0 Xml;HDR = YES;'")

                Using dtSet = New DataSet()

                    For Each s In dic
                        Console.WriteLine($" Processing {s} table")
                        Dim myCommand = New OleDbDataAdapter($"select * from [{s}$];", myConnection)
                        myCommand.TableMappings.Add("Table", s)
                        myCommand.Fill(dtSet)
                    Next
                    Return dtSet
                End Using
            End Using
        Catch e As Exception
            Console.WriteLine($"Error importing from Excel : {e.Message}")
            Console.ReadLine()
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
            xlWorkBook.Close()

            xlApp.Quit()
            xlApp = Nothing
            workbooks = Nothing
            xlWorkBook = Nothing
            sheets = Nothing
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Function

#End Region
#Region "      Gen Script"

    Public Function GenDBScript(ByVal ds As DataSet, ByVal connStr As String) As String
        Dim sp As New StringBuilder

        Try
            If ds Is Nothing Then Return ""
            For Each dt As DataTable In ds.Tables
                Dim ds2 As DataSet = GenModels.getTable(dt.TableName, connStr)
                For Each dr As DataRow In dt.Rows
                    sp.AppendLine("INSERT INTO ")
                    sp.Append(connStr.Split(";")(1).Replace("User Id=", "")).Append(".").Append(dt.TableName).Append(" (")
                    For Each c As DataColumn In dt.Columns
                        sp.Append(c.ColumnName).Append(",")
                    Next
                    sp.Remove(sp.Length - 1, 1).Append(")")
                    sp.Append(" Values('")
                    For Each c As DataColumn In dt.Columns
                        If IsDate(dr(c.ColumnName)) Then
                            sp.Remove(sp.Length - 1, 1)
                            sp.Append($"TO_DATE('{CDate(dr(c.ColumnName)).ToString("yyyy-MM-dd HH:mm:ss")}','yyyy-mm-dd hh24:mi:ss'),'")
                        Else
                            If Not ds2.Tables(0).Columns.Contains(c.ColumnName) Then Continue For
                            If ds2.Tables(0).Columns(c.ColumnName).DataType = System.Type.GetType("System.String") AndAlso dr(c.ColumnName).ToString.Length > ds2.Tables(0).Columns(c.ColumnName).MaxLength Then
                                sp.Append(dr(c.ColumnName).ToString.Substring(0, ds2.Tables(0).Columns(c.ColumnName).MaxLength)).Append("','")
                            Else
                                sp.Append(dr(c.ColumnName)).Append("','")
                            End If
                        End If
                    Next
                    sp.Remove(sp.Length - 2, 2).Append(")")
                    sp.AppendLine(";")
                    sp.AppendLine("go")
                Next
            Next
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return sp.ToString
    End Function

#End Region
End Class
