<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuration
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuration))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AutoConnect = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.autoSave = New System.Windows.Forms.CheckBox()
        Me.CriticalThreashold = New System.Windows.Forms.NumericUpDown()
        Me.WarningThreshold = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxOpenLastSpoolDB = New System.Windows.Forms.CheckBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPageMacros = New System.Windows.Forms.TabPage()
        Me.DataGridViewMacro = New System.Windows.Forms.DataGridView()
        Me.TabPageMaterials = New System.Windows.Forms.TabPage()
        Me.DataGridViewMaterial = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemperatureMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemperatureMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GlassTransition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Density = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripMaterialList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList32x32 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.CriticalThreashold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarningThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPageMacros.SuspendLayout()
        CType(Me.DataGridViewMacro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMaterials.SuspendLayout()
        CType(Me.DataGridViewMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripMaterialList.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Automatitically connect to the printer on start"
        '
        'AutoConnect
        '
        Me.AutoConnect.AutoSize = True
        Me.AutoConnect.Location = New System.Drawing.Point(262, 43)
        Me.AutoConnect.Name = "AutoConnect"
        Me.AutoConnect.Size = New System.Drawing.Size(15, 14)
        Me.AutoConnect.TabIndex = 21
        Me.AutoConnect.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Automatically save the Spool Database on exit"
        '
        'autoSave
        '
        Me.autoSave.AutoSize = True
        Me.autoSave.Location = New System.Drawing.Point(262, 22)
        Me.autoSave.Name = "autoSave"
        Me.autoSave.Size = New System.Drawing.Size(15, 14)
        Me.autoSave.TabIndex = 19
        Me.autoSave.UseVisualStyleBackColor = True
        '
        'CriticalThreashold
        '
        Me.CriticalThreashold.Location = New System.Drawing.Point(262, 89)
        Me.CriticalThreashold.Name = "CriticalThreashold"
        Me.CriticalThreashold.Size = New System.Drawing.Size(120, 20)
        Me.CriticalThreashold.TabIndex = 18
        '
        'WarningThreshold
        '
        Me.WarningThreshold.Location = New System.Drawing.Point(262, 63)
        Me.WarningThreshold.Name = "WarningThreshold"
        Me.WarningThreshold.Size = New System.Drawing.Size(120, 20)
        Me.WarningThreshold.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Remaining filament critical threashold (percent)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Remaing filament warning threshold (percent)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Automatically open the last Spool Database"
        '
        'CheckBoxOpenLastSpoolDB
        '
        Me.CheckBoxOpenLastSpoolDB.AutoSize = True
        Me.CheckBoxOpenLastSpoolDB.Location = New System.Drawing.Point(262, 2)
        Me.CheckBoxOpenLastSpoolDB.Name = "CheckBoxOpenLastSpoolDB"
        Me.CheckBoxOpenLastSpoolDB.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxOpenLastSpoolDB.TabIndex = 13
        Me.CheckBoxOpenLastSpoolDB.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPageMacros)
        Me.TabControl2.Controls.Add(Me.TabPageMaterials)
        Me.TabControl2.Location = New System.Drawing.Point(409, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(714, 415)
        Me.TabControl2.TabIndex = 12
        '
        'TabPageMacros
        '
        Me.TabPageMacros.Controls.Add(Me.DataGridViewMacro)
        Me.TabPageMacros.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMacros.Name = "TabPageMacros"
        Me.TabPageMacros.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMacros.Size = New System.Drawing.Size(706, 389)
        Me.TabPageMacros.TabIndex = 0
        Me.TabPageMacros.Text = "Macros"
        Me.TabPageMacros.UseVisualStyleBackColor = True
        '
        'DataGridViewMacro
        '
        Me.DataGridViewMacro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewMacro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridViewMacro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMacro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.GCode})
        Me.DataGridViewMacro.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataGridViewMacro.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewMacro.Name = "DataGridViewMacro"
        Me.DataGridViewMacro.Size = New System.Drawing.Size(700, 383)
        Me.DataGridViewMacro.TabIndex = 0
        '
        'TabPageMaterials
        '
        Me.TabPageMaterials.Controls.Add(Me.DataGridViewMaterial)
        Me.TabPageMaterials.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMaterials.Name = "TabPageMaterials"
        Me.TabPageMaterials.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMaterials.Size = New System.Drawing.Size(706, 389)
        Me.TabPageMaterials.TabIndex = 1
        Me.TabPageMaterials.Text = "Base materials"
        Me.TabPageMaterials.UseVisualStyleBackColor = True
        '
        'DataGridViewMaterial
        '
        Me.DataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialType, Me.TemperatureMin, Me.TemperatureMax, Me.GlassTransition, Me.Density})
        Me.DataGridViewMaterial.ContextMenuStrip = Me.ContextMenuStripMaterialList
        Me.DataGridViewMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewMaterial.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewMaterial.Name = "DataGridViewMaterial"
        Me.DataGridViewMaterial.Size = New System.Drawing.Size(700, 383)
        Me.DataGridViewMaterial.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Title"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GCodes"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "GCode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MaterialType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TemperatureMin"
        Me.DataGridViewTextBoxColumn4.HeaderText = "From Temp"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 76
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TemperatureMax"
        Me.DataGridViewTextBoxColumn5.HeaderText = "To Temp"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 67
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "GlassTransition"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Glass transition"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 93
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DensityDisplay"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Density gram/cm3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 106
        '
        'Title
        '
        Me.Title.DataPropertyName = "Title"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.Title.DefaultCellStyle = DataGridViewCellStyle1
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        '
        'GCode
        '
        Me.GCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GCode.DataPropertyName = "GCodes"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GCode.DefaultCellStyle = DataGridViewCellStyle2
        Me.GCode.HeaderText = "GCode"
        Me.GCode.Name = "GCode"
        '
        'MaterialType
        '
        Me.MaterialType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaterialType.DataPropertyName = "MaterialType"
        Me.MaterialType.HeaderText = "Type"
        Me.MaterialType.Name = "MaterialType"
        '
        'TemperatureMin
        '
        Me.TemperatureMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TemperatureMin.DataPropertyName = "TemperatureMin"
        Me.TemperatureMin.HeaderText = "From Temp"
        Me.TemperatureMin.Name = "TemperatureMin"
        Me.TemperatureMin.Width = 76
        '
        'TemperatureMax
        '
        Me.TemperatureMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TemperatureMax.DataPropertyName = "TemperatureMax"
        Me.TemperatureMax.HeaderText = "To Temp"
        Me.TemperatureMax.Name = "TemperatureMax"
        Me.TemperatureMax.Width = 67
        '
        'GlassTransition
        '
        Me.GlassTransition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GlassTransition.DataPropertyName = "GlassTransition"
        Me.GlassTransition.HeaderText = "Glass transition"
        Me.GlassTransition.Name = "GlassTransition"
        Me.GlassTransition.Width = 93
        '
        'Density
        '
        Me.Density.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Density.DataPropertyName = "DensityDisplay"
        Me.Density.HeaderText = "Density gram/cm3"
        Me.Density.Name = "Density"
        Me.Density.Width = 106
        '
        'ContextMenuStripMaterialList
        '
        Me.ContextMenuStripMaterialList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMaterialToolStripMenuItem, Me.RemoveMaterialToolStripMenuItem})
        Me.ContextMenuStripMaterialList.Name = "ContextMenuStripMaterialList"
        Me.ContextMenuStripMaterialList.Size = New System.Drawing.Size(164, 70)
        Me.ContextMenuStripMaterialList.Text = "New Material"
        '
        'NewMaterialToolStripMenuItem
        '
        Me.NewMaterialToolStripMenuItem.Name = "NewMaterialToolStripMenuItem"
        Me.NewMaterialToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.NewMaterialToolStripMenuItem.Text = "New Material"
        '
        'RemoveMaterialToolStripMenuItem
        '
        Me.RemoveMaterialToolStripMenuItem.Name = "RemoveMaterialToolStripMenuItem"
        Me.RemoveMaterialToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RemoveMaterialToolStripMenuItem.Text = "Remove Material"
        '
        'ImageList32x32
        '
        Me.ImageList32x32.ImageStream = CType(resources.GetObject("ImageList32x32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList32x32.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList32x32.Images.SetKeyName(0, "exec.ico")
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AutoConnect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.autoSave)
        Me.Controls.Add(Me.CriticalThreashold)
        Me.Controls.Add(Me.WarningThreshold)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxOpenLastSpoolDB)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "Configuration"
        Me.Size = New System.Drawing.Size(1126, 424)
        CType(Me.CriticalThreashold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarningThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPageMacros.ResumeLayout(False)
        CType(Me.DataGridViewMacro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMaterials.ResumeLayout(False)
        CType(Me.DataGridViewMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripMaterialList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AutoConnect As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents autoSave As System.Windows.Forms.CheckBox
    Friend WithEvents CriticalThreashold As System.Windows.Forms.NumericUpDown
    Friend WithEvents WarningThreshold As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxOpenLastSpoolDB As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageMacros As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewMacro As System.Windows.Forms.DataGridView
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPageMaterials As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents MaterialType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemperatureMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemperatureMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GlassTransition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Density As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStripMaterialList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewMaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveMaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImageList32x32 As System.Windows.Forms.ImageList

End Class
