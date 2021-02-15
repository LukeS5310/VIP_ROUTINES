<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAIN))
        Me.SSTRIP = New System.Windows.Forms.StatusStrip()
        Me.TS_PROGRESSINFO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TS_PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TS_MEMORY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TAB_CNTRL = New System.Windows.Forms.TabControl()
        Me.ADV_8 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LBL_TEXT3 = New System.Windows.Forms.Label()
        Me.LBL_MAN_ADV8_OUTPUT_PATH = New System.Windows.Forms.Label()
        Me.BTN_BROWSE_OUTPUT = New System.Windows.Forms.Button()
        Me.LBL_TEXT2 = New System.Windows.Forms.Label()
        Me.LBL_TEXT1 = New System.Windows.Forms.Label()
        Me.BTN_BROWSE_MAN_ADV_FOLDER = New System.Windows.Forms.Button()
        Me.LBL_MAN_ADV8_PATH = New System.Windows.Forms.Label()
        Me.DTP_ADV = New System.Windows.Forms.DateTimePicker()
        Me.CBLIST_WEEKDAYS = New System.Windows.Forms.CheckedListBox()
        Me.BTN_DBG = New System.Windows.Forms.Button()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.ADV_DB = New System.Data.DataSet()
        Me.ADV_TABLE = New System.Data.DataTable()
        Me.SOURSE = New System.Data.DataColumn()
        Me.SNILS = New System.Data.DataColumn()
        Me.FA = New System.Data.DataColumn()
        Me.IM = New System.Data.DataColumn()
        Me.OT = New System.Data.DataColumn()
        Me.RDAT = New System.Data.DataColumn()
        Me.GENDER = New System.Data.DataColumn()
        Me.BIRTHPLACE = New System.Data.DataColumn()
        Me.DEATHDAT = New System.Data.DataColumn()
        Me.ACTDAT = New System.Data.DataColumn()
        Me.ACTNUM = New System.Data.DataColumn()
        Me.ZAGS = New System.Data.DataColumn()
        Me.SVEDTIME = New System.Data.DataColumn()
        Me.ID = New System.Data.DataColumn()
        Me.ADV_PK = New System.Data.DataColumn()
        Me.MAN_TABLE = New System.Data.DataTable()
        Me.MAN_SOURSE = New System.Data.DataColumn()
        Me.RA = New System.Data.DataColumn()
        Me.MAN_SNILS = New System.Data.DataColumn()
        Me.MAN_FA = New System.Data.DataColumn()
        Me.MAN_IM = New System.Data.DataColumn()
        Me.MAN_OT = New System.Data.DataColumn()
        Me.MAN_RDAT = New System.Data.DataColumn()
        Me.MAN_GENDER = New System.Data.DataColumn()
        Me.MAN_BIRTHPLACE = New System.Data.DataColumn()
        Me.MAN_DEATHDAT = New System.Data.DataColumn()
        Me.MAN_ACTDAT = New System.Data.DataColumn()
        Me.MAN_ACTNUM = New System.Data.DataColumn()
        Me.MAN_STATUS = New System.Data.DataColumn()
        Me.MAN_SVEDTIME = New System.Data.DataColumn()
        Me.MAN_ID = New System.Data.DataColumn()
        Me.MAN_PK = New System.Data.DataColumn()
        Me.DoCompare = New System.ComponentModel.BackgroundWorker()
        Me.Check_Loop = New System.Windows.Forms.Timer(Me.components)
        Me.FormFile = New System.ComponentModel.BackgroundWorker()
        Me.Mem_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyAreaIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SSTRIP.SuspendLayout()
        Me.TAB_CNTRL.SuspendLayout()
        Me.ADV_8.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ADV_DB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADV_TABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAN_TABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSTRIP
        '
        Me.SSTRIP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_PROGRESSINFO, Me.TS_PB, Me.TS_MEMORY})
        Me.SSTRIP.Location = New System.Drawing.Point(0, 256)
        Me.SSTRIP.Name = "SSTRIP"
        Me.SSTRIP.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.SSTRIP.Size = New System.Drawing.Size(614, 22)
        Me.SSTRIP.TabIndex = 0
        Me.SSTRIP.Text = "SStrip"
        '
        'TS_PROGRESSINFO
        '
        Me.TS_PROGRESSINFO.Name = "TS_PROGRESSINFO"
        Me.TS_PROGRESSINFO.Size = New System.Drawing.Size(71, 17)
        Me.TS_PROGRESSINFO.Text = "OPERATION"
        '
        'TS_PB
        '
        Me.TS_PB.Name = "TS_PB"
        Me.TS_PB.Size = New System.Drawing.Size(100, 16)
        '
        'TS_MEMORY
        '
        Me.TS_MEMORY.Name = "TS_MEMORY"
        Me.TS_MEMORY.Size = New System.Drawing.Size(76, 17)
        Me.TS_MEMORY.Text = "MEM_USAGE"
        '
        'TAB_CNTRL
        '
        Me.TAB_CNTRL.Controls.Add(Me.ADV_8)
        Me.TAB_CNTRL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TAB_CNTRL.Location = New System.Drawing.Point(0, 0)
        Me.TAB_CNTRL.Name = "TAB_CNTRL"
        Me.TAB_CNTRL.SelectedIndex = 0
        Me.TAB_CNTRL.Size = New System.Drawing.Size(614, 256)
        Me.TAB_CNTRL.TabIndex = 1
        '
        'ADV_8
        '
        Me.ADV_8.Controls.Add(Me.TableLayoutPanel1)
        Me.ADV_8.Location = New System.Drawing.Point(4, 22)
        Me.ADV_8.Name = "ADV_8"
        Me.ADV_8.Padding = New System.Windows.Forms.Padding(3)
        Me.ADV_8.Size = New System.Drawing.Size(606, 230)
        Me.ADV_8.TabIndex = 0
        Me.ADV_8.Text = "АДВ-8"
        Me.ADV_8.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.83333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LBL_TEXT3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LBL_MAN_ADV8_OUTPUT_PATH, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_BROWSE_OUTPUT, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LBL_TEXT2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LBL_TEXT1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_BROWSE_MAN_ADV_FOLDER, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LBL_MAN_ADV8_PATH, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DTP_ADV, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CBLIST_WEEKDAYS, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BTN_DBG, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 224)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LBL_TEXT3
        '
        Me.LBL_TEXT3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_TEXT3.AutoSize = True
        Me.LBL_TEXT3.Location = New System.Drawing.Point(3, 133)
        Me.LBL_TEXT3.Name = "LBL_TEXT3"
        Me.LBL_TEXT3.Size = New System.Drawing.Size(108, 13)
        Me.LBL_TEXT3.TabIndex = 6
        Me.LBL_TEXT3.Text = "Время выполнения:"
        '
        'LBL_MAN_ADV8_OUTPUT_PATH
        '
        Me.LBL_MAN_ADV8_OUTPUT_PATH.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_MAN_ADV8_OUTPUT_PATH.AutoSize = True
        Me.LBL_MAN_ADV8_OUTPUT_PATH.Location = New System.Drawing.Point(266, 77)
        Me.LBL_MAN_ADV8_OUTPUT_PATH.Name = "LBL_MAN_ADV8_OUTPUT_PATH"
        Me.LBL_MAN_ADV8_OUTPUT_PATH.Size = New System.Drawing.Size(36, 13)
        Me.LBL_MAN_ADV8_OUTPUT_PATH.TabIndex = 5
        Me.LBL_MAN_ADV8_OUTPUT_PATH.Text = "PATH"
        '
        'BTN_BROWSE_OUTPUT
        '
        Me.BTN_BROWSE_OUTPUT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN_BROWSE_OUTPUT.Location = New System.Drawing.Point(202, 72)
        Me.BTN_BROWSE_OUTPUT.Name = "BTN_BROWSE_OUTPUT"
        Me.BTN_BROWSE_OUTPUT.Size = New System.Drawing.Size(58, 23)
        Me.BTN_BROWSE_OUTPUT.TabIndex = 4
        Me.BTN_BROWSE_OUTPUT.Text = "Обзор..."
        Me.BTN_BROWSE_OUTPUT.UseVisualStyleBackColor = True
        '
        'LBL_TEXT2
        '
        Me.LBL_TEXT2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_TEXT2.AutoSize = True
        Me.LBL_TEXT2.Location = New System.Drawing.Point(3, 71)
        Me.LBL_TEXT2.Name = "LBL_TEXT2"
        Me.LBL_TEXT2.Size = New System.Drawing.Size(169, 26)
        Me.LBL_TEXT2.TabIndex = 3
        Me.LBL_TEXT2.Text = "Папка для сохранения готовых файлов"
        '
        'LBL_TEXT1
        '
        Me.LBL_TEXT1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_TEXT1.AutoSize = True
        Me.LBL_TEXT1.Location = New System.Drawing.Point(3, 21)
        Me.LBL_TEXT1.Name = "LBL_TEXT1"
        Me.LBL_TEXT1.Size = New System.Drawing.Size(164, 13)
        Me.LBL_TEXT1.TabIndex = 0
        Me.LBL_TEXT1.Text = "Папка с файлами MAN и ADV8"
        '
        'BTN_BROWSE_MAN_ADV_FOLDER
        '
        Me.BTN_BROWSE_MAN_ADV_FOLDER.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN_BROWSE_MAN_ADV_FOLDER.Location = New System.Drawing.Point(202, 16)
        Me.BTN_BROWSE_MAN_ADV_FOLDER.Name = "BTN_BROWSE_MAN_ADV_FOLDER"
        Me.BTN_BROWSE_MAN_ADV_FOLDER.Size = New System.Drawing.Size(58, 23)
        Me.BTN_BROWSE_MAN_ADV_FOLDER.TabIndex = 1
        Me.BTN_BROWSE_MAN_ADV_FOLDER.Text = "Обзор..."
        Me.BTN_BROWSE_MAN_ADV_FOLDER.UseVisualStyleBackColor = True
        '
        'LBL_MAN_ADV8_PATH
        '
        Me.LBL_MAN_ADV8_PATH.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LBL_MAN_ADV8_PATH.AutoSize = True
        Me.LBL_MAN_ADV8_PATH.Location = New System.Drawing.Point(266, 21)
        Me.LBL_MAN_ADV8_PATH.Name = "LBL_MAN_ADV8_PATH"
        Me.LBL_MAN_ADV8_PATH.Size = New System.Drawing.Size(36, 13)
        Me.LBL_MAN_ADV8_PATH.TabIndex = 2
        Me.LBL_MAN_ADV8_PATH.Text = "PATH"
        '
        'DTP_ADV
        '
        Me.DTP_ADV.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DTP_ADV.CustomFormat = "HH:mm"
        Me.DTP_ADV.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_ADV.Location = New System.Drawing.Point(202, 130)
        Me.DTP_ADV.Name = "DTP_ADV"
        Me.DTP_ADV.ShowUpDown = True
        Me.DTP_ADV.Size = New System.Drawing.Size(58, 20)
        Me.DTP_ADV.TabIndex = 7
        Me.DTP_ADV.Value = New Date(2019, 10, 31, 14, 0, 0, 0)
        '
        'CBLIST_WEEKDAYS
        '
        Me.CBLIST_WEEKDAYS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CBLIST_WEEKDAYS.FormattingEnabled = True
        Me.CBLIST_WEEKDAYS.Items.AddRange(New Object() {"Понедельник", "Вторник", "Среда", "Четверг ", "Пятница", "Суббота", "Воскресенье"})
        Me.CBLIST_WEEKDAYS.Location = New System.Drawing.Point(266, 115)
        Me.CBLIST_WEEKDAYS.Name = "CBLIST_WEEKDAYS"
        Me.TableLayoutPanel1.SetRowSpan(Me.CBLIST_WEEKDAYS, 2)
        Me.CBLIST_WEEKDAYS.Size = New System.Drawing.Size(331, 106)
        Me.CBLIST_WEEKDAYS.TabIndex = 9
        '
        'BTN_DBG
        '
        Me.BTN_DBG.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_DBG.Location = New System.Drawing.Point(3, 184)
        Me.BTN_DBG.Name = "BTN_DBG"
        Me.BTN_DBG.Size = New System.Drawing.Size(193, 23)
        Me.BTN_DBG.TabIndex = 8
        Me.BTN_DBG.Text = "DEBUG"
        Me.BTN_DBG.UseVisualStyleBackColor = True
        '
        'ADV_DB
        '
        Me.ADV_DB.DataSetName = "ADV_DB"
        Me.ADV_DB.Tables.AddRange(New System.Data.DataTable() {Me.ADV_TABLE, Me.MAN_TABLE})
        '
        'ADV_TABLE
        '
        Me.ADV_TABLE.Columns.AddRange(New System.Data.DataColumn() {Me.SOURSE, Me.SNILS, Me.FA, Me.IM, Me.OT, Me.RDAT, Me.GENDER, Me.BIRTHPLACE, Me.DEATHDAT, Me.ACTDAT, Me.ACTNUM, Me.ZAGS, Me.SVEDTIME, Me.ID, Me.ADV_PK})
        Me.ADV_TABLE.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"PK"}, True)})
        Me.ADV_TABLE.PrimaryKey = New System.Data.DataColumn() {Me.ADV_PK}
        Me.ADV_TABLE.TableName = "ADV_TABLE"
        '
        'SOURSE
        '
        Me.SOURSE.Caption = "Sourse"
        Me.SOURSE.ColumnName = "SOURSE"
        Me.SOURSE.DataType = GetType(Byte)
        '
        'SNILS
        '
        Me.SNILS.Caption = "SNILS"
        Me.SNILS.ColumnName = "SNILS"
        Me.SNILS.MaxLength = 14
        '
        'FA
        '
        Me.FA.Caption = "FA"
        Me.FA.ColumnName = "FA"
        Me.FA.MaxLength = 32
        '
        'IM
        '
        Me.IM.Caption = "IM"
        Me.IM.ColumnName = "IM"
        Me.IM.MaxLength = 40
        '
        'OT
        '
        Me.OT.Caption = "OT"
        Me.OT.ColumnName = "OT"
        Me.OT.MaxLength = 40
        '
        'RDAT
        '
        Me.RDAT.Caption = "RDAT"
        Me.RDAT.ColumnName = "RDAT"
        Me.RDAT.DataType = GetType(Date)
        '
        'GENDER
        '
        Me.GENDER.Caption = "GENDER"
        Me.GENDER.ColumnName = "GENDER"
        Me.GENDER.MaxLength = 1
        '
        'BIRTHPLACE
        '
        Me.BIRTHPLACE.Caption = "BIRTHPLACE"
        Me.BIRTHPLACE.ColumnName = "BIRTHPLACE"
        Me.BIRTHPLACE.MaxLength = 192
        '
        'DEATHDAT
        '
        Me.DEATHDAT.Caption = "DEATHDAT"
        Me.DEATHDAT.ColumnName = "DEATHDAT"
        Me.DEATHDAT.DataType = GetType(Date)
        '
        'ACTDAT
        '
        Me.ACTDAT.Caption = "ACTDAT"
        Me.ACTDAT.ColumnName = "ACTDAT"
        Me.ACTDAT.DataType = GetType(Date)
        '
        'ACTNUM
        '
        Me.ACTNUM.Caption = "ACTNUM"
        Me.ACTNUM.ColumnName = "ACTNUM"
        Me.ACTNUM.MaxLength = 32
        '
        'ZAGS
        '
        Me.ZAGS.Caption = "ZAGS"
        Me.ZAGS.ColumnName = "ZAGS"
        Me.ZAGS.MaxLength = 208
        '
        'SVEDTIME
        '
        Me.SVEDTIME.Caption = "SVEDTIME"
        Me.SVEDTIME.ColumnName = "SVEDTIME"
        Me.SVEDTIME.DataType = GetType(Date)
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.ColumnName = "ID"
        Me.ID.MaxLength = 32
        '
        'ADV_PK
        '
        Me.ADV_PK.AllowDBNull = False
        Me.ADV_PK.AutoIncrement = True
        Me.ADV_PK.Caption = "PK"
        Me.ADV_PK.ColumnName = "PK"
        Me.ADV_PK.DataType = GetType(Long)
        '
        'MAN_TABLE
        '
        Me.MAN_TABLE.Columns.AddRange(New System.Data.DataColumn() {Me.MAN_SOURSE, Me.RA, Me.MAN_SNILS, Me.MAN_FA, Me.MAN_IM, Me.MAN_OT, Me.MAN_RDAT, Me.MAN_GENDER, Me.MAN_BIRTHPLACE, Me.MAN_DEATHDAT, Me.MAN_ACTDAT, Me.MAN_ACTNUM, Me.MAN_STATUS, Me.MAN_SVEDTIME, Me.MAN_ID, Me.MAN_PK})
        Me.MAN_TABLE.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"PK"}, True)})
        Me.MAN_TABLE.PrimaryKey = New System.Data.DataColumn() {Me.MAN_PK}
        Me.MAN_TABLE.TableName = "MAN_TABLE"
        '
        'MAN_SOURSE
        '
        Me.MAN_SOURSE.Caption = "SOURSE"
        Me.MAN_SOURSE.ColumnName = "SOURSE"
        Me.MAN_SOURSE.DataType = GetType(Byte)
        '
        'RA
        '
        Me.RA.Caption = "RA"
        Me.RA.ColumnName = "RA"
        Me.RA.DataType = GetType(Short)
        '
        'MAN_SNILS
        '
        Me.MAN_SNILS.Caption = "SNILS"
        Me.MAN_SNILS.ColumnName = "SNILS"
        Me.MAN_SNILS.MaxLength = 14
        '
        'MAN_FA
        '
        Me.MAN_FA.Caption = "FA"
        Me.MAN_FA.ColumnName = "FA"
        Me.MAN_FA.MaxLength = 32
        '
        'MAN_IM
        '
        Me.MAN_IM.Caption = "IM"
        Me.MAN_IM.ColumnName = "IM"
        Me.MAN_IM.MaxLength = 40
        '
        'MAN_OT
        '
        Me.MAN_OT.Caption = "OT"
        Me.MAN_OT.ColumnName = "OT"
        Me.MAN_OT.MaxLength = 32
        '
        'MAN_RDAT
        '
        Me.MAN_RDAT.Caption = "RDAT"
        Me.MAN_RDAT.ColumnName = "RDAT"
        Me.MAN_RDAT.DataType = GetType(Date)
        '
        'MAN_GENDER
        '
        Me.MAN_GENDER.Caption = "GENDER"
        Me.MAN_GENDER.ColumnName = "GENDER"
        Me.MAN_GENDER.MaxLength = 1
        '
        'MAN_BIRTHPLACE
        '
        Me.MAN_BIRTHPLACE.Caption = "BIRTHPLACE"
        Me.MAN_BIRTHPLACE.ColumnName = "BIRTHPLACE"
        Me.MAN_BIRTHPLACE.MaxLength = 192
        '
        'MAN_DEATHDAT
        '
        Me.MAN_DEATHDAT.Caption = "DEATHDAT"
        Me.MAN_DEATHDAT.ColumnName = "DEATHDAT"
        Me.MAN_DEATHDAT.DataType = GetType(Date)
        '
        'MAN_ACTDAT
        '
        Me.MAN_ACTDAT.Caption = "ACTDAT"
        Me.MAN_ACTDAT.ColumnName = "ACTDAT"
        Me.MAN_ACTDAT.DataType = GetType(Date)
        '
        'MAN_ACTNUM
        '
        Me.MAN_ACTNUM.Caption = "ACTNUM"
        Me.MAN_ACTNUM.ColumnName = "ACTNUM"
        Me.MAN_ACTNUM.MaxLength = 32
        '
        'MAN_STATUS
        '
        Me.MAN_STATUS.Caption = "STATUS"
        Me.MAN_STATUS.ColumnName = "STATUS"
        Me.MAN_STATUS.DataType = GetType(SByte)
        '
        'MAN_SVEDTIME
        '
        Me.MAN_SVEDTIME.Caption = "SVEDTIME"
        Me.MAN_SVEDTIME.ColumnName = "SVEDTIME"
        Me.MAN_SVEDTIME.DataType = GetType(Date)
        '
        'MAN_ID
        '
        Me.MAN_ID.Caption = "ID"
        Me.MAN_ID.ColumnName = "ID"
        Me.MAN_ID.MaxLength = 32
        '
        'MAN_PK
        '
        Me.MAN_PK.AllowDBNull = False
        Me.MAN_PK.AutoIncrement = True
        Me.MAN_PK.Caption = "PK"
        Me.MAN_PK.ColumnName = "PK"
        Me.MAN_PK.DataType = GetType(Integer)
        '
        'DoCompare
        '
        Me.DoCompare.WorkerReportsProgress = True
        '
        'Check_Loop
        '
        Me.Check_Loop.Interval = 60000
        '
        'FormFile
        '
        Me.FormFile.WorkerReportsProgress = True
        '
        'Mem_Timer
        '
        Me.Mem_Timer.Enabled = True
        Me.Mem_Timer.Interval = 1000
        '
        'NotifyAreaIcon
        '
        Me.NotifyAreaIcon.BalloonTipText = "Обработчик запущен"
        Me.NotifyAreaIcon.Icon = CType(resources.GetObject("NotifyAreaIcon.Icon"), System.Drawing.Icon)
        Me.NotifyAreaIcon.Text = "Обработчик запущен"
        Me.NotifyAreaIcon.Visible = True
        '
        'MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 278)
        Me.Controls.Add(Me.TAB_CNTRL)
        Me.Controls.Add(Me.SSTRIP)
        Me.Name = "MAIN"
        Me.Text = "Обработчик выгрузок ПТК НВП"
        Me.SSTRIP.ResumeLayout(False)
        Me.SSTRIP.PerformLayout()
        Me.TAB_CNTRL.ResumeLayout(False)
        Me.ADV_8.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ADV_DB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADV_TABLE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAN_TABLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SSTRIP As StatusStrip
    Friend WithEvents TS_PROGRESSINFO As ToolStripStatusLabel
    Friend WithEvents TS_PB As ToolStripProgressBar
    Friend WithEvents TS_MEMORY As ToolStripStatusLabel
    Friend WithEvents TAB_CNTRL As TabControl
    Friend WithEvents ADV_8 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LBL_TEXT1 As Label
    Friend WithEvents BTN_BROWSE_MAN_ADV_FOLDER As Button
    Friend WithEvents LBL_MAN_ADV8_PATH As Label
    Friend WithEvents LBL_TEXT2 As Label
    Friend WithEvents LBL_MAN_ADV8_OUTPUT_PATH As Label
    Friend WithEvents BTN_BROWSE_OUTPUT As Button
    Friend WithEvents FBD As FolderBrowserDialog
    Friend WithEvents LBL_TEXT3 As Label
    Friend WithEvents DTP_ADV As DateTimePicker
    Friend WithEvents ADV_DB As DataSet
    Friend WithEvents ADV_TABLE As DataTable
    Friend WithEvents SOURSE As DataColumn
    Friend WithEvents SNILS As DataColumn
    Friend WithEvents FA As DataColumn
    Friend WithEvents IM As DataColumn
    Friend WithEvents OT As DataColumn
    Friend WithEvents RDAT As DataColumn
    Friend WithEvents GENDER As DataColumn
    Friend WithEvents BIRTHPLACE As DataColumn
    Friend WithEvents DEATHDAT As DataColumn
    Friend WithEvents ACTDAT As DataColumn
    Friend WithEvents ACTNUM As DataColumn
    Friend WithEvents ZAGS As DataColumn
    Friend WithEvents SVEDTIME As DataColumn
    Friend WithEvents ID As DataColumn
    Friend WithEvents ADV_PK As DataColumn
    Friend WithEvents MAN_TABLE As DataTable
    Friend WithEvents MAN_SOURSE As DataColumn
    Friend WithEvents RA As DataColumn
    Friend WithEvents MAN_SNILS As DataColumn
    Friend WithEvents MAN_FA As DataColumn
    Friend WithEvents MAN_IM As DataColumn
    Friend WithEvents MAN_OT As DataColumn
    Friend WithEvents MAN_RDAT As DataColumn
    Friend WithEvents MAN_GENDER As DataColumn
    Friend WithEvents MAN_BIRTHPLACE As DataColumn
    Friend WithEvents MAN_DEATHDAT As DataColumn
    Friend WithEvents MAN_ACTDAT As DataColumn
    Friend WithEvents MAN_ACTNUM As DataColumn
    Friend WithEvents MAN_STATUS As DataColumn
    Friend WithEvents MAN_SVEDTIME As DataColumn
    Friend WithEvents MAN_ID As DataColumn
    Friend WithEvents MAN_PK As DataColumn
    Friend WithEvents DoCompare As System.ComponentModel.BackgroundWorker
    Friend WithEvents BTN_DBG As Button
    Friend WithEvents Check_Loop As Timer
    Friend WithEvents FormFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents Mem_Timer As Timer
    Friend WithEvents CBLIST_WEEKDAYS As CheckedListBox
    Friend WithEvents NotifyAreaIcon As NotifyIcon
End Class
