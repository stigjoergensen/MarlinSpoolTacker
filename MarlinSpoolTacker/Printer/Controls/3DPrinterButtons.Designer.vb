<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _3DPrinterButtons
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
        Me.XyButton1 = New MarlinSpoolTacker.XYButton()
        Me.SuspendLayout()
        '
        'XyButton1
        '
        Me.XyButton1.ButtonDirection = MarlinSpoolTacker.XYButton.Direction.North
        Me.XyButton1.ButtonIndex = 1
        Me.XyButton1.ButtonSize = New System.Drawing.Size(0, 0)
        Me.XyButton1.Location = New System.Drawing.Point(63, 51)
        Me.XyButton1.Name = "XyButton1"
        Me.XyButton1.Size = New System.Drawing.Size(64, 55)
        Me.XyButton1.TabIndex = 0
        Me.XyButton1.TextFont = New System.Drawing.Font("Arial", 10.0!)
        Me.XyButton1.Value = -10.9!
        '
        '_3DPrinterButtons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.XyButton1)
        Me.Name = "_3DPrinterButtons"
        Me.Size = New System.Drawing.Size(615, 547)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XyButton1 As MarlinSpoolTacker.XYButton

End Class
