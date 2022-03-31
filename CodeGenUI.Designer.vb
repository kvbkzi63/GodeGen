<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CodeGenUI
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_ConnStr = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.QueryColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IsPK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SystemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDisplayName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDataType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.visible = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Required = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Dir = New System.Windows.Forms.TextBox()
        Me.btn_GenModel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_Table = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ModelName = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_System = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ExcelFileName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rtb_Script = New System.Windows.Forms.RichTextBox()
        Me.btn_SelectDataExcel = New System.Windows.Forms.Button()
        Me.txt_TransDataConnStr = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_TransDataTodb = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1194, 666)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1186, 636)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Web基本檔"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbo_Table, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_ModelName, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.239237!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.031746!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.873016!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.936508!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.96825!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1180, 630)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_ConnStr)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(95, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 39)
        Me.Panel2.TabIndex = 13
        '
        'txt_ConnStr
        '
        Me.txt_ConnStr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_ConnStr.Location = New System.Drawing.Point(3, 7)
        Me.txt_ConnStr.Name = "txt_ConnStr"
        Me.txt_ConnStr.Size = New System.Drawing.Size(262, 27)
        Me.txt_ConnStr.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.Location = New System.Drawing.Point(271, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 27)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "取得資料表"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "連線字串"
        '
        'Panel3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel3, 4)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 136)
        Me.Panel3.Name = "Panel3"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel3, 2)
        Me.Panel3.Size = New System.Drawing.Size(1174, 448)
        Me.Panel3.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QueryColumn, Me.IsPK, Me.SystemName, Me.ColumnName, Me.ColumnDisplayName, Me.ModelColumn, Me.ColumnDataType, Me.visible, Me.Required})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1174, 448)
        Me.DataGridView1.TabIndex = 0
        '
        'QueryColumn
        '
        Me.QueryColumn.HeaderText = "查詢條件"
        Me.QueryColumn.Name = "QueryColumn"
        '
        'IsPK
        '
        Me.IsPK.HeaderText = "PK欄位"
        Me.IsPK.Name = "IsPK"
        Me.IsPK.ReadOnly = True
        Me.IsPK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IsPK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SystemName
        '
        Me.SystemName.HeaderText = "系統別"
        Me.SystemName.Name = "SystemName"
        '
        'ColumnName
        '
        Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnName.HeaderText = "欄位名稱(En)"
        Me.ColumnName.Name = "ColumnName"
        Me.ColumnName.ReadOnly = True
        Me.ColumnName.Width = 89
        '
        'ColumnDisplayName
        '
        Me.ColumnDisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnDisplayName.HeaderText = "欄位名稱(DisplayName)"
        Me.ColumnDisplayName.Name = "ColumnDisplayName"
        Me.ColumnDisplayName.Width = 175
        '
        'ModelColumn
        '
        Me.ModelColumn.HeaderText = "欄位型態(Model)"
        Me.ModelColumn.Name = "ModelColumn"
        '
        'ColumnDataType
        '
        Me.ColumnDataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ColumnDataType.HeaderText = "欄位型態(ViewModel)"
        Me.ColumnDataType.Items.AddRange(New Object() {"bool", "System.String", "System.Decimal", "System.DateTime"})
        Me.ColumnDataType.Name = "ColumnDataType"
        Me.ColumnDataType.Width = 145
        '
        'visible
        '
        Me.visible.HeaderText = "顯示與否(編輯畫面)"
        Me.visible.Name = "visible"
        Me.visible.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.visible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Required
        '
        Me.Required.HeaderText = "必填"
        Me.Required.Name = "Required"
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_Dir)
        Me.Panel1.Controls.Add(Me.btn_GenModel)
        Me.Panel1.Location = New System.Drawing.Point(3, 590)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 32)
        Me.Panel1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "檔案路徑"
        '
        'txt_Dir
        '
        Me.txt_Dir.Location = New System.Drawing.Point(92, 4)
        Me.txt_Dir.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Dir.Name = "txt_Dir"
        Me.txt_Dir.Size = New System.Drawing.Size(229, 27)
        Me.txt_Dir.TabIndex = 15
        Me.txt_Dir.Text = "C:\SDCodeGen"
        '
        'btn_GenModel
        '
        Me.btn_GenModel.Location = New System.Drawing.Point(329, 4)
        Me.btn_GenModel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_GenModel.Name = "btn_GenModel"
        Me.btn_GenModel.Size = New System.Drawing.Size(119, 27)
        Me.btn_GenModel.TabIndex = 10
        Me.btn_GenModel.Text = "Gen Code Files"
        Me.btn_GenModel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "系統別"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(4, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Select Table"
        '
        'cbo_Table
        '
        Me.cbo_Table.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbo_Table.FormattingEnabled = True
        Me.cbo_Table.Location = New System.Drawing.Point(96, 102)
        Me.cbo_Table.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo_Table.Name = "cbo_Table"
        Me.cbo_Table.Size = New System.Drawing.Size(382, 24)
        Me.cbo_Table.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(487, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Model Name"
        '
        'txt_ModelName
        '
        Me.txt_ModelName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_ModelName.Location = New System.Drawing.Point(583, 63)
        Me.txt_ModelName.Name = "txt_ModelName"
        Me.txt_ModelName.Size = New System.Drawing.Size(382, 27)
        Me.txt_ModelName.TabIndex = 18
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.txt_System)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(95, 61)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(370, 32)
        Me.FlowLayoutPanel4.TabIndex = 23
        '
        'txt_System
        '
        Me.txt_System.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_System.Location = New System.Drawing.Point(3, 3)
        Me.txt_System.Name = "txt_System"
        Me.txt_System.Size = New System.Drawing.Size(194, 27)
        Me.txt_System.TabIndex = 22
        Me.txt_System.Text = "HIS2_SCH"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(204, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "(NameSpace，必填)"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1186, 636)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Excel轉Script"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.9777!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.0223!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 554.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_ExcelFileName, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.rtb_Script, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_SelectDataExcel, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_TransDataConnStr, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_TransDataTodb, 3, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1180, 630)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "選取檔案(Excel)"
        '
        'txt_ExcelFileName
        '
        Me.txt_ExcelFileName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel3.SetColumnSpan(Me.txt_ExcelFileName, 2)
        Me.txt_ExcelFileName.Enabled = False
        Me.txt_ExcelFileName.Location = New System.Drawing.Point(136, 3)
        Me.txt_ExcelFileName.Name = "txt_ExcelFileName"
        Me.txt_ExcelFileName.Size = New System.Drawing.Size(486, 27)
        Me.txt_ExcelFileName.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "連線字串" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtb_Script
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.rtb_Script, 3)
        Me.rtb_Script.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_Script.Location = New System.Drawing.Point(136, 116)
        Me.rtb_Script.Name = "rtb_Script"
        Me.rtb_Script.Size = New System.Drawing.Size(1041, 511)
        Me.rtb_Script.TabIndex = 8
        Me.rtb_Script.Text = ""
        '
        'btn_SelectDataExcel
        '
        Me.btn_SelectDataExcel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_SelectDataExcel.Location = New System.Drawing.Point(628, 3)
        Me.btn_SelectDataExcel.Name = "btn_SelectDataExcel"
        Me.btn_SelectDataExcel.Size = New System.Drawing.Size(93, 26)
        Me.btn_SelectDataExcel.TabIndex = 2
        Me.btn_SelectDataExcel.Text = "..."
        Me.btn_SelectDataExcel.UseVisualStyleBackColor = True
        '
        'txt_TransDataConnStr
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.txt_TransDataConnStr, 2)
        Me.txt_TransDataConnStr.Location = New System.Drawing.Point(136, 36)
        Me.txt_TransDataConnStr.Name = "txt_TransDataConnStr"
        Me.txt_TransDataConnStr.Size = New System.Drawing.Size(486, 74)
        Me.txt_TransDataConnStr.TabIndex = 10
        Me.txt_TransDataConnStr.Text = ""
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Script"
        '
        'btn_TransDataTodb
        '
        Me.btn_TransDataTodb.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_TransDataTodb.Location = New System.Drawing.Point(628, 60)
        Me.btn_TransDataTodb.Name = "btn_TransDataTodb"
        Me.btn_TransDataTodb.Size = New System.Drawing.Size(93, 26)
        Me.btn_TransDataTodb.TabIndex = 5
        Me.btn_TransDataTodb.Text = "產生Script"
        Me.btn_TransDataTodb.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CodeGenUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 666)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CodeGenUI"
        Me.Text = "程式碼產生器"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ConnStr As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_Table As ComboBox
    Friend WithEvents btn_GenModel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Dir As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_ModelName As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_System As TextBox
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_ExcelFileName As TextBox
    Friend WithEvents btn_SelectDataExcel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents rtb_Script As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_TransDataTodb As Button
    Friend WithEvents txt_TransDataConnStr As RichTextBox
    Friend WithEvents QueryColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IsPK As DataGridViewCheckBoxColumn
    Friend WithEvents SystemName As DataGridViewTextBoxColumn
    Friend WithEvents ColumnName As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDisplayName As DataGridViewTextBoxColumn
    Friend WithEvents ModelColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDataType As DataGridViewComboBoxColumn
    Friend WithEvents visible As DataGridViewCheckBoxColumn
    Friend WithEvents Required As DataGridViewCheckBoxColumn
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
