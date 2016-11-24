<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditor
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
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelRemaining = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelFullWeight = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonUsed = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Diameter = New System.Windows.Forms.ComboBox()
        Me.ButtonLength = New System.Windows.Forms.Button()
        Me.ForceTemperature = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Used = New System.Windows.Forms.NumericUpDown()
        Me.Length = New System.Windows.Forms.NumericUpDown()
        Me.ESteps = New System.Windows.Forms.NumericUpDown()
        Me.FlowRate = New System.Windows.Forms.NumericUpDown()
        Me.Temperature = New System.Windows.Forms.NumericUpDown()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.SpoolType = New System.Windows.Forms.ComboBox()
        Me.SpoolID = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OpenDate = New System.Windows.Forms.DateTimePicker()
        Me.BuyDate = New System.Windows.Forms.DateTimePicker()
        Me.Manufactor = New System.Windows.Forms.TextBox()
        Me.ButtonColorPicker = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorText = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Used, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Length, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESteps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpoolID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Location = New System.Drawing.Point(13, 482)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 17
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOK.Location = New System.Drawing.Point(577, 482)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 18
        Me.ButtonOK.Text = "Ok"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LabelRemaining)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.LabelFullWeight)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 377)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 99)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional Information"
        '
        'LabelRemaining
        '
        Me.LabelRemaining.AutoSize = True
        Me.LabelRemaining.Location = New System.Drawing.Point(110, 36)
        Me.LabelRemaining.Name = "LabelRemaining"
        Me.LabelRemaining.Size = New System.Drawing.Size(83, 13)
        Me.LabelRemaining.TabIndex = 3
        Me.LabelRemaining.Text = "LabelRemaining"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Remaining weight"
        '
        'LabelFullWeight
        '
        Me.LabelFullWeight.AutoSize = True
        Me.LabelFullWeight.Location = New System.Drawing.Point(110, 19)
        Me.LabelFullWeight.Name = "LabelFullWeight"
        Me.LabelFullWeight.Size = New System.Drawing.Size(83, 13)
        Me.LabelFullWeight.TabIndex = 1
        Me.LabelFullWeight.Text = "LabelFullWeight"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Full Weight"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(15, 10)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Size = New System.Drawing.Size(636, 361)
        Me.SplitContainer1.SplitterDistance = 273
        Me.SplitContainer1.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ButtonUsed)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Diameter)
        Me.GroupBox2.Controls.Add(Me.ButtonLength)
        Me.GroupBox2.Controls.Add(Me.ForceTemperature)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Used)
        Me.GroupBox2.Controls.Add(Me.Length)
        Me.GroupBox2.Controls.Add(Me.ESteps)
        Me.GroupBox2.Controls.Add(Me.FlowRate)
        Me.GroupBox2.Controls.Add(Me.Temperature)
        Me.GroupBox2.Controls.Add(Me.Description)
        Me.GroupBox2.Controls.Add(Me.SpoolType)
        Me.GroupBox2.Controls.Add(Me.SpoolID)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 355)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Basic Spool information"
        '
        'ButtonUsed
        '
        Me.ButtonUsed.Location = New System.Drawing.Point(245, 201)
        Me.ButtonUsed.Name = "ButtonUsed"
        Me.ButtonUsed.Size = New System.Drawing.Size(24, 23)
        Me.ButtonUsed.TabIndex = 45
        Me.ButtonUsed.Text = "..."
        Me.ButtonUsed.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Diameter"
        '
        'Diameter
        '
        Me.Diameter.DisplayMember = "DiameterValue"
        Me.Diameter.FormattingEnabled = True
        Me.Diameter.Location = New System.Drawing.Point(119, 96)
        Me.Diameter.Name = "Diameter"
        Me.Diameter.Size = New System.Drawing.Size(121, 21)
        Me.Diameter.TabIndex = 43
        Me.Diameter.ValueMember = "DiameterValue"
        '
        'ButtonLength
        '
        Me.ButtonLength.Location = New System.Drawing.Point(245, 172)
        Me.ButtonLength.Name = "ButtonLength"
        Me.ButtonLength.Size = New System.Drawing.Size(24, 23)
        Me.ButtonLength.TabIndex = 42
        Me.ButtonLength.Text = "..."
        Me.ButtonLength.UseVisualStyleBackColor = True
        '
        'ForceTemperature
        '
        Me.ForceTemperature.AutoSize = True
        Me.ForceTemperature.Location = New System.Drawing.Point(119, 253)
        Me.ForceTemperature.Name = "ForceTemperature"
        Me.ForceTemperature.Size = New System.Drawing.Size(116, 17)
        Me.ForceTemperature.TabIndex = 26
        Me.ForceTemperature.Text = "Force Temperature"
        Me.ForceTemperature.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Used (cm)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Length (cm)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "E-Steps"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Flow rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Temperature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Spool ID"
        '
        'Used
        '
        Me.Used.Location = New System.Drawing.Point(119, 201)
        Me.Used.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Used.Name = "Used"
        Me.Used.Size = New System.Drawing.Size(120, 20)
        Me.Used.TabIndex = 33
        '
        'Length
        '
        Me.Length.Location = New System.Drawing.Point(119, 175)
        Me.Length.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(120, 20)
        Me.Length.TabIndex = 32
        '
        'ESteps
        '
        Me.ESteps.Location = New System.Drawing.Point(119, 149)
        Me.ESteps.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.ESteps.Name = "ESteps"
        Me.ESteps.Size = New System.Drawing.Size(120, 20)
        Me.ESteps.TabIndex = 31
        Me.ESteps.Value = New Decimal(New Integer() {65535, 0, 0, 0})
        '
        'FlowRate
        '
        Me.FlowRate.DecimalPlaces = 2
        Me.FlowRate.Location = New System.Drawing.Point(119, 123)
        Me.FlowRate.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.FlowRate.Name = "FlowRate"
        Me.FlowRate.Size = New System.Drawing.Size(120, 20)
        Me.FlowRate.TabIndex = 30
        '
        'Temperature
        '
        Me.Temperature.Location = New System.Drawing.Point(119, 227)
        Me.Temperature.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.Temperature.Minimum = New Decimal(New Integer() {145, 0, 0, 0})
        Me.Temperature.Name = "Temperature"
        Me.Temperature.Size = New System.Drawing.Size(120, 20)
        Me.Temperature.TabIndex = 29
        Me.Temperature.Value = New Decimal(New Integer() {145, 0, 0, 0})
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(119, 69)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(121, 20)
        Me.Description.TabIndex = 28
        '
        'SpoolType
        '
        Me.SpoolType.DisplayMember = "MaterialType"
        Me.SpoolType.FormattingEnabled = True
        Me.SpoolType.Location = New System.Drawing.Point(119, 41)
        Me.SpoolType.Name = "SpoolType"
        Me.SpoolType.Size = New System.Drawing.Size(121, 21)
        Me.SpoolType.TabIndex = 27
        Me.SpoolType.ValueMember = "MaterialType"
        '
        'SpoolID
        '
        Me.SpoolID.Location = New System.Drawing.Point(119, 14)
        Me.SpoolID.Name = "SpoolID"
        Me.SpoolID.Size = New System.Drawing.Size(120, 20)
        Me.SpoolID.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.ColorText)
        Me.GroupBox3.Controls.Add(Me.ButtonColorPicker)
        Me.GroupBox3.Controls.Add(Me.Manufactor)
        Me.GroupBox3.Controls.Add(Me.BuyDate)
        Me.GroupBox3.Controls.Add(Me.OpenDate)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 355)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extended spool information"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Manufactor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Color"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Date of purchase"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Open Date"
        '
        'OpenDate
        '
        Me.OpenDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenDate.Location = New System.Drawing.Point(141, 91)
        Me.OpenDate.Name = "OpenDate"
        Me.OpenDate.Size = New System.Drawing.Size(200, 20)
        Me.OpenDate.TabIndex = 4
        '
        'BuyDate
        '
        Me.BuyDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuyDate.Location = New System.Drawing.Point(141, 65)
        Me.BuyDate.Name = "BuyDate"
        Me.BuyDate.Size = New System.Drawing.Size(200, 20)
        Me.BuyDate.TabIndex = 5
        '
        'Manufactor
        '
        Me.Manufactor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Manufactor.Location = New System.Drawing.Point(141, 13)
        Me.Manufactor.Name = "Manufactor"
        Me.Manufactor.Size = New System.Drawing.Size(200, 20)
        Me.Manufactor.TabIndex = 6
        '
        'ButtonColorPicker
        '
        Me.ButtonColorPicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonColorPicker.Location = New System.Drawing.Point(317, 37)
        Me.ButtonColorPicker.Name = "ButtonColorPicker"
        Me.ButtonColorPicker.Size = New System.Drawing.Size(24, 23)
        Me.ButtonColorPicker.TabIndex = 43
        Me.ButtonColorPicker.Text = "..."
        Me.ButtonColorPicker.UseVisualStyleBackColor = True
        '
        'ColorText
        '
        Me.ColorText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColorText.Location = New System.Drawing.Point(141, 39)
        Me.ColorText.Name = "ColorText"
        Me.ColorText.ReadOnly = True
        Me.ColorText.Size = New System.Drawing.Size(170, 20)
        Me.ColorText.TabIndex = 44
        '
        'FormEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 517)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Name = "FormEditor"
        Me.Text = "Spool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Used, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Length, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESteps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlowRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Temperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpoolID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelRemaining As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelFullWeight As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonUsed As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Diameter As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonLength As System.Windows.Forms.Button
    Friend WithEvents ForceTemperature As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Used As System.Windows.Forms.NumericUpDown
    Friend WithEvents Length As System.Windows.Forms.NumericUpDown
    Friend WithEvents ESteps As System.Windows.Forms.NumericUpDown
    Friend WithEvents FlowRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Temperature As System.Windows.Forms.NumericUpDown
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents SpoolType As System.Windows.Forms.ComboBox
    Friend WithEvents SpoolID As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Manufactor As System.Windows.Forms.TextBox
    Friend WithEvents BuyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ButtonColorPicker As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorText As System.Windows.Forms.TextBox
End Class
