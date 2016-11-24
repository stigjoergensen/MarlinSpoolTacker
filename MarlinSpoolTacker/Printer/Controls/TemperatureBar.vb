Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class TemperatureBar
    Public Property TargetTemperature As Integer
    Public Property CurrentTemperature As Integer
    Public Property TemperatureMargin As Integer = 10
    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Overrides Property Text As String
    Public Property ColdColor As Color = Color.DeepSkyBlue
    Public Property HotColor As Color = Color.OrangeRed
    Public Property TextColor As Color = Color.Black
    Public Property MarkerColor As Color = Color.Black
    Public Property AutoHeight As Boolean = True

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Me.Refresh()
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)
        Dim BarMargin As Integer = 2

        Dim TargetTempStr As String = TargetTemperature.ToString() + "°"
        Dim CurrentTempStr As String = CurrentTemperature.ToString() + "°"
        Dim MaxTemperature As Integer = TargetTemperature + TemperatureMargin
        Dim DrawFont As New System.Drawing.Font("Arial", 10, FontStyle.Bold)
        Dim TemperatureStr As String = String.Format("{0} / {1}", CurrentTempStr, TargetTempStr)
        Dim TextHeight As Integer = Math.Max(Math.Max(e.Graphics.MeasureString(TargetTempStr, DrawFont).Height, e.Graphics.MeasureString(CurrentTempStr, DrawFont).Height), e.Graphics.MeasureString(Text, DrawFont).Height)
        If AutoHeight Then
            Me.Height = TextHeight + (BarMargin * 4)
        End If

        Dim TextY = (Me.Height - TextHeight) / 2
        Dim TextX = (Me.Width - e.Graphics.MeasureString(TemperatureStr, DrawFont).Width) * 0.75


        Dim pen As New Pen(MarkerColor, 2)
        pen.StartCap = LineCap.DiamondAnchor
        pen.EndCap = LineCap.DiamondAnchor

        Dim BarRect As New Rectangle(0, BarMargin, Me.Width, Me.Height - BarMargin - BarMargin)

        Using progressGradient As New LinearGradientBrush(BarRect, ColdColor, HotColor, 0)
            progressGradient.GammaCorrection = True
            e.Graphics.FillRectangle(progressGradient, BarRect)
        End Using

        Dim CurrentX As Integer = Me.Width / (MaxTemperature / CurrentTemperature)
        Dim TargetX As Integer = Me.Width / (MaxTemperature / TargetTemperature)

        e.Graphics.DrawLine(pen, CurrentX + BarRect.Left, BarRect.Top - 1, CurrentX + BarRect.Left, BarRect.Top + BarRect.Height + 1)
        e.Graphics.DrawLine(pen, TargetX + BarRect.Left, BarRect.Top - 2, TargetX + BarRect.Left, BarRect.Top + BarRect.Height + 2)
        Dim TextBrush As New SolidBrush(TextColor)
        e.Graphics.DrawString(Text, DrawFont, TextBrush, New Point(5, TextY))
        e.Graphics.DrawString(TemperatureStr, DrawFont, TextBrush, New Point(TextX, TextY))

    End Sub
End Class
