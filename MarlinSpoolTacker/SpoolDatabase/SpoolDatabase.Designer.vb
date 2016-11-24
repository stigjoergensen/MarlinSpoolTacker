<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpoolDatabase
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DataGridViewSpools = New System.Windows.Forms.DataGridView()
        Me.SpoolID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpoolType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remaining = New MarlinSpoolTacker.CustomProgressControl.DataGridViewProgressBarColumn()
        Me.Temperature = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESteps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Used = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diameter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flag7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Flag0 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Unused1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unused2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialogSpoolDB = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialogSpoolDB = New System.Windows.Forms.SaveFileDialog()
        Me.ContextMenuStripSpoolList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuNewSpool = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEditSpool = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridViewSpools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripSpoolList.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonTest
        '
        Me.ButtonTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTest.Location = New System.Drawing.Point(947, 415)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTest.TabIndex = 19
        Me.ButtonTest.Text = "Test"
        Me.ButtonTest.UseVisualStyleBackColor = True
        '
        'ButtonUpload
        '
        Me.ButtonUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonUpload.Enabled = False
        Me.ButtonUpload.Location = New System.Drawing.Point(84, 415)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpload.TabIndex = 18
        Me.ButtonUpload.Text = "Upload"
        Me.ButtonUpload.UseVisualStyleBackColor = True
        '
        'ButtonDownload
        '
        Me.ButtonDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonDownload.Enabled = False
        Me.ButtonDownload.Location = New System.Drawing.Point(3, 415)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDownload.TabIndex = 17
        Me.ButtonDownload.Text = "Download"
        Me.ButtonDownload.UseVisualStyleBackColor = True
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLoad.Location = New System.Drawing.Point(1028, 415)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLoad.TabIndex = 16
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Location = New System.Drawing.Point(1109, 415)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 15
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'DataGridViewSpools
        '
        Me.DataGridViewSpools.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSpools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSpools.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SpoolID, Me.SpoolType, Me.Description, Me.Remaining, Me.Temperature, Me.FlowRate, Me.ESteps, Me.Length, Me.Used, Me.Diameter, Me.Flag7, Me.Flag6, Me.Flag5, Me.Flag4, Me.Flag3, Me.Flag2, Me.Flag1, Me.Flag0, Me.Unused1, Me.Unused2, Me.EOL})
        Me.DataGridViewSpools.ContextMenuStrip = Me.ContextMenuStripSpoolList
        Me.DataGridViewSpools.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewSpools.MultiSelect = False
        Me.DataGridViewSpools.Name = "DataGridViewSpools"
        Me.DataGridViewSpools.ReadOnly = True
        Me.DataGridViewSpools.Size = New System.Drawing.Size(1181, 406)
        Me.DataGridViewSpools.TabIndex = 14
        '
        'SpoolID
        '
        Me.SpoolID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SpoolID.DataPropertyName = "SpoolID"
        Me.SpoolID.HeaderText = "SpoolID"
        Me.SpoolID.Name = "SpoolID"
        Me.SpoolID.ReadOnly = True
        Me.SpoolID.Width = 68
        '
        'SpoolType
        '
        Me.SpoolType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SpoolType.DataPropertyName = "SpoolType"
        Me.SpoolType.HeaderText = "Type"
        Me.SpoolType.Name = "SpoolType"
        Me.SpoolType.ReadOnly = True
        Me.SpoolType.Width = 54
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Remaining
        '
        Me.Remaining.DataPropertyName = "RemainingPCT"
        DataGridViewCellStyle1.Format = "## \%"
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(4)
        Me.Remaining.DefaultCellStyle = DataGridViewCellStyle1
        Me.Remaining.HeaderText = "Remaining"
        Me.Remaining.Name = "Remaining"
        Me.Remaining.ReadOnly = True
        '
        'Temperature
        '
        Me.Temperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Temperature.DataPropertyName = "TemperatureDisplay"
        Me.Temperature.HeaderText = "Temp"
        Me.Temperature.Name = "Temperature"
        Me.Temperature.ReadOnly = True
        Me.Temperature.Width = 57
        '
        'FlowRate
        '
        Me.FlowRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FlowRate.DataPropertyName = "FlowRateDisplay"
        Me.FlowRate.HeaderText = "Flow rate"
        Me.FlowRate.Name = "FlowRate"
        Me.FlowRate.ReadOnly = True
        Me.FlowRate.Width = 73
        '
        'ESteps
        '
        Me.ESteps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESteps.DataPropertyName = "ESteps"
        Me.ESteps.HeaderText = "E-Steps"
        Me.ESteps.Name = "ESteps"
        Me.ESteps.ReadOnly = True
        Me.ESteps.Width = 67
        '
        'Length
        '
        Me.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Length.DataPropertyName = "LengthDisplay"
        Me.Length.HeaderText = "Length"
        Me.Length.Name = "Length"
        Me.Length.ReadOnly = True
        Me.Length.Width = 63
        '
        'Used
        '
        Me.Used.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Used.DataPropertyName = "UsedDisplay"
        Me.Used.HeaderText = "Used"
        Me.Used.Name = "Used"
        Me.Used.ReadOnly = True
        Me.Used.Width = 55
        '
        'Diameter
        '
        Me.Diameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Diameter.DataPropertyName = "DiameterDisplay"
        Me.Diameter.HeaderText = "Diameter"
        Me.Diameter.Name = "Diameter"
        Me.Diameter.ReadOnly = True
        Me.Diameter.Width = 72
        '
        'Flag7
        '
        Me.Flag7.DataPropertyName = "Flag7"
        Me.Flag7.HeaderText = "Unknown7"
        Me.Flag7.Name = "Flag7"
        Me.Flag7.ReadOnly = True
        Me.Flag7.Visible = False
        '
        'Flag6
        '
        Me.Flag6.DataPropertyName = "Flag6"
        Me.Flag6.HeaderText = "Unknown6"
        Me.Flag6.Name = "Flag6"
        Me.Flag6.ReadOnly = True
        Me.Flag6.Visible = False
        '
        'Flag5
        '
        Me.Flag5.DataPropertyName = "Flag5"
        Me.Flag5.HeaderText = "Unknown5"
        Me.Flag5.Name = "Flag5"
        Me.Flag5.ReadOnly = True
        Me.Flag5.Visible = False
        '
        'Flag4
        '
        Me.Flag4.DataPropertyName = "Flag4"
        Me.Flag4.HeaderText = "Unknown4"
        Me.Flag4.Name = "Flag4"
        Me.Flag4.ReadOnly = True
        Me.Flag4.Visible = False
        '
        'Flag3
        '
        Me.Flag3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Flag3.DataPropertyName = "FlagForceTemperature"
        Me.Flag3.FalseValue = "0"
        Me.Flag3.HeaderText = "ForceTemperature"
        Me.Flag3.Name = "Flag3"
        Me.Flag3.ReadOnly = True
        Me.Flag3.TrueValue = "1"
        Me.Flag3.Width = 98
        '
        'Flag2
        '
        Me.Flag2.DataPropertyName = "Flag2"
        Me.Flag2.HeaderText = "HotEnd B2"
        Me.Flag2.Name = "Flag2"
        Me.Flag2.ReadOnly = True
        Me.Flag2.Visible = False
        '
        'Flag1
        '
        Me.Flag1.DataPropertyName = "Flag1"
        Me.Flag1.HeaderText = "HotEnd B1"
        Me.Flag1.Name = "Flag1"
        Me.Flag1.ReadOnly = True
        Me.Flag1.Visible = False
        '
        'Flag0
        '
        Me.Flag0.DataPropertyName = "Flag0"
        Me.Flag0.HeaderText = "HotEnd B0"
        Me.Flag0.Name = "Flag0"
        Me.Flag0.ReadOnly = True
        Me.Flag0.Visible = False
        '
        'Unused1
        '
        Me.Unused1.DataPropertyName = "Unused1"
        Me.Unused1.HeaderText = "Unused1"
        Me.Unused1.Name = "Unused1"
        Me.Unused1.ReadOnly = True
        Me.Unused1.Visible = False
        '
        'Unused2
        '
        Me.Unused2.DataPropertyName = "Unused2"
        Me.Unused2.HeaderText = "Unused2"
        Me.Unused2.Name = "Unused2"
        Me.Unused2.ReadOnly = True
        Me.Unused2.Visible = False
        '
        'EOL
        '
        Me.EOL.DataPropertyName = "EOL"
        Me.EOL.HeaderText = "EOL"
        Me.EOL.Name = "EOL"
        Me.EOL.ReadOnly = True
        Me.EOL.Visible = False
        '
        'OpenFileDialogSpoolDB
        '
        Me.OpenFileDialogSpoolDB.DefaultExt = "*.sdb"
        Me.OpenFileDialogSpoolDB.FileName = "Spool.sdb"
        Me.OpenFileDialogSpoolDB.Filter = "Spool Database|*.sdb"
        Me.OpenFileDialogSpoolDB.Title = "open spool database"
        '
        'SaveFileDialogSpoolDB
        '
        Me.SaveFileDialogSpoolDB.DefaultExt = "*.sdb"
        Me.SaveFileDialogSpoolDB.FileName = "spool.sdb"
        Me.SaveFileDialogSpoolDB.Filter = "Spool Database|*.sdb"
        Me.SaveFileDialogSpoolDB.Title = "Save Spool Database"
        '
        'ContextMenuStripSpoolList
        '
        Me.ContextMenuStripSpoolList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNewSpool, Me.MenuEditSpool})
        Me.ContextMenuStripSpoolList.Name = "ContextMenuStripSpoolList"
        Me.ContextMenuStripSpoolList.Size = New System.Drawing.Size(132, 48)
        '
        'MenuNewSpool
        '
        Me.MenuNewSpool.Name = "MenuNewSpool"
        Me.MenuNewSpool.Size = New System.Drawing.Size(131, 22)
        Me.MenuNewSpool.Text = "New Spool"
        '
        'MenuEditSpool
        '
        Me.MenuEditSpool.Name = "MenuEditSpool"
        Me.MenuEditSpool.Size = New System.Drawing.Size(131, 22)
        Me.MenuEditSpool.Text = "Edit Spool"
        '
        'SpoolDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonTest)
        Me.Controls.Add(Me.ButtonUpload)
        Me.Controls.Add(Me.ButtonDownload)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.DataGridViewSpools)
        Me.Name = "SpoolDatabase"
        Me.Size = New System.Drawing.Size(1187, 441)
        CType(Me.DataGridViewSpools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripSpoolList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonTest As System.Windows.Forms.Button
    Friend WithEvents ButtonUpload As System.Windows.Forms.Button
    Friend WithEvents ButtonDownload As System.Windows.Forms.Button
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewSpools As System.Windows.Forms.DataGridView
    Friend WithEvents SpoolID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpoolType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remaining As MarlinSpoolTacker.CustomProgressControl.DataGridViewProgressBarColumn
    Friend WithEvents Temperature As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESteps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Length As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Used As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diameter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Flag7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Flag6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Flag5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Flag4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Flag3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Flag2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Flag1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Flag0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Unused1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unused2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialogSpoolDB As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialogSpoolDB As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ContextMenuStripSpoolList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuNewSpool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEditSpool As System.Windows.Forms.ToolStripMenuItem

End Class
