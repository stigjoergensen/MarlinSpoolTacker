<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3dPrinter
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.HeaterPanel = New System.Windows.Forms.Panel()
        Me.ButtonControlPanel = New System.Windows.Forms.Panel()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TemperatureBar1 = New MarlinSpoolTacker.TemperatureBar()
        Me._3DPrinterButtons1 = New MarlinSpoolTacker._3DPrinterButtons()
        Me.BuildPlate1 = New MarlinSpoolTacker.BuildPlate()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.HeaterPanel.SuspendLayout()
        Me.ButtonControlPanel.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.HeaterPanel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonControlPanel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BuildPlate1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TrackBar1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1128, 577)
        Me.SplitContainer1.SplitterDistance = 376
        Me.SplitContainer1.TabIndex = 0
        '
        'HeaterPanel
        '
        Me.HeaterPanel.AutoSize = True
        Me.HeaterPanel.Controls.Add(Me.TemperatureBar1)
        Me.HeaterPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaterPanel.Location = New System.Drawing.Point(0, 231)
        Me.HeaterPanel.Name = "HeaterPanel"
        Me.HeaterPanel.Size = New System.Drawing.Size(376, 25)
        Me.HeaterPanel.TabIndex = 1
        '
        'ButtonControlPanel
        '
        Me.ButtonControlPanel.Controls.Add(Me._3DPrinterButtons1)
        Me.ButtonControlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.ButtonControlPanel.Name = "ButtonControlPanel"
        Me.ButtonControlPanel.Size = New System.Drawing.Size(376, 231)
        Me.ButtonControlPanel.TabIndex = 0
        '
        'TrackBar1
        '
        Me.TrackBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TrackBar1.Location = New System.Drawing.Point(703, 0)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 577)
        Me.TrackBar1.TabIndex = 0
        '
        'TemperatureBar1
        '
        Me.TemperatureBar1.AutoHeight = True
        Me.TemperatureBar1.ColdColor = System.Drawing.Color.DeepSkyBlue
        Me.TemperatureBar1.CurrentTemperature = 120
        Me.TemperatureBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TemperatureBar1.HotColor = System.Drawing.Color.OrangeRed
        Me.TemperatureBar1.Location = New System.Drawing.Point(0, 0)
        Me.TemperatureBar1.MarkerColor = System.Drawing.Color.Black
        Me.TemperatureBar1.Name = "TemperatureBar1"
        Me.TemperatureBar1.Size = New System.Drawing.Size(376, 25)
        Me.TemperatureBar1.TabIndex = 0
        Me.TemperatureBar1.TargetTemperature = 255
        Me.TemperatureBar1.TemperatureMargin = 10
        Me.TemperatureBar1.Text = "Bed"
        Me.TemperatureBar1.TextColor = System.Drawing.Color.Black
        '
        '_3DPrinterButtons1
        '
        Me._3DPrinterButtons1.Location = New System.Drawing.Point(4, 4)
        Me._3DPrinterButtons1.Name = "_3DPrinterButtons1"
        Me._3DPrinterButtons1.Size = New System.Drawing.Size(229, 216)
        Me._3DPrinterButtons1.TabIndex = 0
        '
        'BuildPlate1
        '
        Me.BuildPlate1.BackColor = System.Drawing.SystemColors.Control
        Me.BuildPlate1.BuildSize = New System.Drawing.Size(225, 175)
        Me.BuildPlate1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BuildPlate1.Location = New System.Drawing.Point(0, 0)
        Me.BuildPlate1.Name = "BuildPlate1"
        Me.BuildPlate1.Size = New System.Drawing.Size(703, 577)
        Me.BuildPlate1.TabIndex = 1
        '
        '_3dPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "_3dPrinter"
        Me.Size = New System.Drawing.Size(1128, 577)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.HeaterPanel.ResumeLayout(False)
        Me.ButtonControlPanel.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents HeaterPanel As System.Windows.Forms.Panel
    Friend WithEvents ButtonControlPanel As System.Windows.Forms.Panel
    Friend WithEvents _3DPrinterButtons1 As MarlinSpoolTacker._3DPrinterButtons
    Friend WithEvents TemperatureBar1 As MarlinSpoolTacker.TemperatureBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents BuildPlate1 As MarlinSpoolTacker.BuildPlate

End Class
