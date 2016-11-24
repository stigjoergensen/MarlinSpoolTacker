<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Console
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
        Me.Transmit = New System.Windows.Forms.Button()
        Me.Command = New System.Windows.Forms.TextBox()
        Me.ConsoleOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Transmit
        '
        Me.Transmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Transmit.Location = New System.Drawing.Point(642, 322)
        Me.Transmit.Name = "Transmit"
        Me.Transmit.Size = New System.Drawing.Size(75, 23)
        Me.Transmit.TabIndex = 0
        Me.Transmit.Text = "Transmit"
        Me.Transmit.UseVisualStyleBackColor = True
        '
        'Command
        '
        Me.Command.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command.Location = New System.Drawing.Point(4, 324)
        Me.Command.Name = "Command"
        Me.Command.Size = New System.Drawing.Size(632, 20)
        Me.Command.TabIndex = 1
        '
        'ConsoleOutput
        '
        Me.ConsoleOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsoleOutput.Location = New System.Drawing.Point(4, 4)
        Me.ConsoleOutput.Name = "ConsoleOutput"
        Me.ConsoleOutput.Size = New System.Drawing.Size(713, 314)
        Me.ConsoleOutput.TabIndex = 2
        Me.ConsoleOutput.Text = ""
        '
        'Console
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ConsoleOutput)
        Me.Controls.Add(Me.Command)
        Me.Controls.Add(Me.Transmit)
        Me.Name = "Console"
        Me.Size = New System.Drawing.Size(720, 348)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Transmit As System.Windows.Forms.Button
    Friend WithEvents Command As System.Windows.Forms.TextBox
    Friend WithEvents ConsoleOutput As System.Windows.Forms.RichTextBox

End Class
