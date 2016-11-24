<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboBoxComPort = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSpeed = New System.Windows.Forms.ComboBox()
        Me.CheckBoxConnect = New System.Windows.Forms.CheckBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusSpacer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusConnected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPagePrinter = New System.Windows.Forms.TabPage()
        Me._3dPrinter1 = New MarlinSpoolTacker._3dPrinter()
        Me.TabPageSpoolDB = New System.Windows.Forms.TabPage()
        Me.SpoolDatabase1 = New MarlinSpoolTacker.SpoolDatabase()
        Me.TabPageConsole = New System.Windows.Forms.TabPage()
        Me.Console1 = New MarlinSpoolTacker.Console()
        Me.TabPageConfig = New System.Windows.Forms.TabPage()
        Me.Configuration1 = New MarlinSpoolTacker.Configuration()
        Me.ContextMenuStripMacroList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewMacroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMacroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelPrinterName = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewProgressBarColumn1 = New MarlinSpoolTacker.CustomProgressControl.DataGridViewProgressBarColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPagePrinter.SuspendLayout()
        Me.TabPageSpoolDB.SuspendLayout()
        Me.TabPageConsole.SuspendLayout()
        Me.TabPageConfig.SuspendLayout()
        Me.ContextMenuStripMacroList.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxComPort
        '
        Me.ComboBoxComPort.FormattingEnabled = True
        Me.ComboBoxComPort.Location = New System.Drawing.Point(13, 13)
        Me.ComboBoxComPort.Name = "ComboBoxComPort"
        Me.ComboBoxComPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxComPort.TabIndex = 1
        '
        'ComboBoxSpeed
        '
        Me.ComboBoxSpeed.FormattingEnabled = True
        Me.ComboBoxSpeed.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "56000", "57600", "115200", "128000", "153600", "230400", "256000", "460800", "921600"})
        Me.ComboBoxSpeed.Location = New System.Drawing.Point(141, 13)
        Me.ComboBoxSpeed.Name = "ComboBoxSpeed"
        Me.ComboBoxSpeed.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSpeed.TabIndex = 4
        '
        'CheckBoxConnect
        '
        Me.CheckBoxConnect.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBoxConnect.Location = New System.Drawing.Point(268, 12)
        Me.CheckBoxConnect.Name = "CheckBoxConnect"
        Me.CheckBoxConnect.Size = New System.Drawing.Size(75, 23)
        Me.CheckBoxConnect.TabIndex = 9
        Me.CheckBoxConnect.Text = "Connect"
        Me.CheckBoxConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxConnect.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel, Me.ToolStripStatusSpacer, Me.ToolStripStatusConnected})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 435)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip.TabIndex = 11
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusSpacer
        '
        Me.ToolStripStatusSpacer.Name = "ToolStripStatusSpacer"
        Me.ToolStripStatusSpacer.Size = New System.Drawing.Size(934, 17)
        Me.ToolStripStatusSpacer.Spring = True
        '
        'ToolStripStatusConnected
        '
        Me.ToolStripStatusConnected.Name = "ToolStripStatusConnected"
        Me.ToolStripStatusConnected.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusConnected.Text = "Disconnected"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPagePrinter)
        Me.TabControl1.Controls.Add(Me.TabPageSpoolDB)
        Me.TabControl1.Controls.Add(Me.TabPageConsole)
        Me.TabControl1.Controls.Add(Me.TabPageConfig)
        Me.TabControl1.Location = New System.Drawing.Point(13, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1003, 391)
        Me.TabControl1.TabIndex = 12
        '
        'TabPagePrinter
        '
        Me.TabPagePrinter.Controls.Add(Me._3dPrinter1)
        Me.TabPagePrinter.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePrinter.Name = "TabPagePrinter"
        Me.TabPagePrinter.Size = New System.Drawing.Size(995, 365)
        Me.TabPagePrinter.TabIndex = 3
        Me.TabPagePrinter.Text = "Printer"
        Me.TabPagePrinter.UseVisualStyleBackColor = True
        '
        '_3dPrinter1
        '
        Me._3dPrinter1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._3dPrinter1.Location = New System.Drawing.Point(3, 3)
        Me._3dPrinter1.Name = "_3dPrinter1"
        Me._3dPrinter1.Size = New System.Drawing.Size(989, 359)
        Me._3dPrinter1.TabIndex = 0
        '
        'TabPageSpoolDB
        '
        Me.TabPageSpoolDB.Controls.Add(Me.SpoolDatabase1)
        Me.TabPageSpoolDB.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSpoolDB.Name = "TabPageSpoolDB"
        Me.TabPageSpoolDB.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSpoolDB.Size = New System.Drawing.Size(995, 365)
        Me.TabPageSpoolDB.TabIndex = 0
        Me.TabPageSpoolDB.Text = "Spool Database"
        Me.TabPageSpoolDB.UseVisualStyleBackColor = True
        '
        'SpoolDatabase1
        '
        Me.SpoolDatabase1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpoolDatabase1.Location = New System.Drawing.Point(3, 3)
        Me.SpoolDatabase1.Name = "SpoolDatabase1"
        Me.SpoolDatabase1.Size = New System.Drawing.Size(989, 359)
        Me.SpoolDatabase1.TabIndex = 0
        '
        'TabPageConsole
        '
        Me.TabPageConsole.Controls.Add(Me.Console1)
        Me.TabPageConsole.Location = New System.Drawing.Point(4, 22)
        Me.TabPageConsole.Name = "TabPageConsole"
        Me.TabPageConsole.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageConsole.Size = New System.Drawing.Size(995, 365)
        Me.TabPageConsole.TabIndex = 1
        Me.TabPageConsole.Text = "Console"
        Me.TabPageConsole.UseVisualStyleBackColor = True
        '
        'Console1
        '
        Me.Console1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Console1.Location = New System.Drawing.Point(3, 3)
        Me.Console1.Name = "Console1"
        Me.Console1.Size = New System.Drawing.Size(989, 359)
        Me.Console1.TabIndex = 0
        '
        'TabPageConfig
        '
        Me.TabPageConfig.Controls.Add(Me.Configuration1)
        Me.TabPageConfig.Location = New System.Drawing.Point(4, 22)
        Me.TabPageConfig.Name = "TabPageConfig"
        Me.TabPageConfig.Size = New System.Drawing.Size(995, 365)
        Me.TabPageConfig.TabIndex = 2
        Me.TabPageConfig.Text = "Configuration"
        Me.TabPageConfig.UseVisualStyleBackColor = True
        '
        'Configuration1
        '
        Me.Configuration1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Configuration1.Location = New System.Drawing.Point(0, 0)
        Me.Configuration1.Name = "Configuration1"
        Me.Configuration1.Size = New System.Drawing.Size(995, 365)
        Me.Configuration1.TabIndex = 0
        '
        'ContextMenuStripMacroList
        '
        Me.ContextMenuStripMacroList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMacroToolStripMenuItem, Me.DeleteMacroToolStripMenuItem})
        Me.ContextMenuStripMacroList.Name = "ContextMenuStripMacroList"
        Me.ContextMenuStripMacroList.Size = New System.Drawing.Size(145, 48)
        '
        'NewMacroToolStripMenuItem
        '
        Me.NewMacroToolStripMenuItem.Name = "NewMacroToolStripMenuItem"
        Me.NewMacroToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NewMacroToolStripMenuItem.Text = "New Macro"
        '
        'DeleteMacroToolStripMenuItem
        '
        Me.DeleteMacroToolStripMenuItem.Name = "DeleteMacroToolStripMenuItem"
        Me.DeleteMacroToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.DeleteMacroToolStripMenuItem.Text = "Delete Macro"
        '
        'LabelPrinterName
        '
        Me.LabelPrinterName.AutoSize = True
        Me.LabelPrinterName.Location = New System.Drawing.Point(349, 17)
        Me.LabelPrinterName.Name = "LabelPrinterName"
        Me.LabelPrinterName.Size = New System.Drawing.Size(65, 13)
        Me.LabelPrinterName.TabIndex = 13
        Me.LabelPrinterName.Text = "PrinterName"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SpoolID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SpoolID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SpoolType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewProgressBarColumn1
        '
        Me.DataGridViewProgressBarColumn1.DataPropertyName = "RemainPCT"
        DataGridViewCellStyle1.Format = "## \%"
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(4)
        Me.DataGridViewProgressBarColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewProgressBarColumn1.HeaderText = "Remaining"
        Me.DataGridViewProgressBarColumn1.Name = "DataGridViewProgressBarColumn1"
        Me.DataGridViewProgressBarColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TemperatureDisplay"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Temp"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FlowRateDisplay"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Flow rate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ESteps"
        Me.DataGridViewTextBoxColumn6.HeaderText = "E-Steps"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Length"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Length"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Used"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Used"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DiameterDisplay"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Diameter"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Unused1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Unused1"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Unused2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Unused2"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "EOL"
        Me.DataGridViewTextBoxColumn12.HeaderText = "EOL"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Title"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn13.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "GCodes"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn14.HeaderText = "GCode"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "MaterialType"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TemperatureMin"
        Me.DataGridViewTextBoxColumn16.HeaderText = "From Temp"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "TemperatureMax"
        Me.DataGridViewTextBoxColumn17.HeaderText = "To Temp"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "GlassTransition"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Glass transition"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Density"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Density"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 457)
        Me.Controls.Add(Me.LabelPrinterName)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.CheckBoxConnect)
        Me.Controls.Add(Me.ComboBoxSpeed)
        Me.Controls.Add(Me.ComboBoxComPort)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Marlin Spool Tracker"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPagePrinter.ResumeLayout(False)
        Me.TabPageSpoolDB.ResumeLayout(False)
        Me.TabPageConsole.ResumeLayout(False)
        Me.TabPageConfig.ResumeLayout(False)
        Me.ContextMenuStripMacroList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxComPort As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxSpeed As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxConnect As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusSpacer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusConnected As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageSpoolDB As System.Windows.Forms.TabPage
    Friend WithEvents TabPageConsole As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePrinter As System.Windows.Forms.TabPage
    Friend WithEvents TabPageConfig As System.Windows.Forms.TabPage
    Friend WithEvents LabelPrinterName As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStripMacroList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewMacroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteMacroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewProgressBarColumn1 As MarlinSpoolTacker.CustomProgressControl.DataGridViewProgressBarColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _3dPrinter1 As MarlinSpoolTacker._3dPrinter
    Friend WithEvents Console1 As MarlinSpoolTacker.Console
    Friend WithEvents Configuration1 As MarlinSpoolTacker.Configuration
    Friend WithEvents SpoolDatabase1 As MarlinSpoolTacker.SpoolDatabase

End Class
