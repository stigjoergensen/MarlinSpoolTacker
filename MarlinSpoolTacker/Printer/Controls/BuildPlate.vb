Imports System.ComponentModel

Public Class BuildPlate
    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Property BuildSize As Size
    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Property BuildPlateColor As Color = Color.LemonChiffon

    Const AreaMargin As Integer = 20

    Private XScale, YScale As Single
    Private BuildArea As Rectangle
    Private BuildPlateBrush As SolidBrush

    Private TextFont As Font

    Public Sub New()
        InitializeComponent()
        BuildPlateBrush = New SolidBrush(BuildPlateColor)
        TextFont = New Font("Ariel", 10)
    End Sub

    Private Function mmToPoint(X As Double, Y As Double) As Point
        Return New Point((X / XScale) + BuildArea.Left, (Y / YScale) + BuildArea.Top)
    End Function

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Not BuildSize.IsEmpty Then
            Dim aspectRatio As Double = BuildSize.Width / BuildSize.Height
            BuildArea = New Rectangle(AreaMargin, AreaMargin, Me.Width - (AreaMargin * 2), (Me.Width - (AreaMargin * 2)) / aspectRatio)
            If BuildArea.Height > Me.Height - (AreaMargin * 2) Then
                BuildArea = New Rectangle(AreaMargin, AreaMargin, (Me.Height - (AreaMargin * 2)) * aspectRatio, Me.Height - (AreaMargin * 2))
            End If
            XScale = BuildSize.Width / BuildArea.Width
            YScale = BuildSize.Height / BuildArea.Height
        End If
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)

        e.Graphics.FillRectangle(SystemBrushes.Control, New Rectangle(0, 0, Me.Width, Me.Height))
        e.Graphics.FillRectangle(BuildPlateBrush, BuildArea)

        Dim cmLine As Pen = New Pen(Color.Black, 1)
        cmLine.DashStyle = Drawing2D.DashStyle.Dot

        Dim TextPoint As Point
        Dim TextSize As SizeF
        TextSize = e.Graphics.MeasureString("cm", TextFont)
        TextPoint = mmToPoint(0, 0)
        TextPoint.Y = TextPoint.Y - TextSize.Height
        TextPoint.X = TextPoint.X - TextSize.Width
        e.Graphics.DrawString("cm", TextFont, Brushes.Black, TextPoint)
        For i As Integer = 1 To Conversion.Int(BuildSize.Width / 10)
            TextPoint = mmToPoint(i * 10, 0)
            e.Graphics.DrawLine(cmLine, TextPoint, mmToPoint(i * 10, BuildSize.Height))
            TextSize = e.Graphics.MeasureString(i.ToString(), TextFont)
            TextPoint.Y = TextPoint.Y - TextSize.Height
            TextPoint.X = TextPoint.X - (TextSize.Width / 2) + 1
            e.Graphics.DrawString(i.ToString(), TextFont, Brushes.Black, TextPoint)
        Next
        For i As Integer = 1 To Conversion.Int(BuildSize.Height / 10)
            TextPoint = mmToPoint(0, i * 10)
            e.Graphics.DrawLine(cmLine, TextPoint, mmToPoint(BuildSize.Width, i * 10))
            TextSize = e.Graphics.MeasureString(i.ToString(), TextFont)
            TextPoint.Y = TextPoint.Y - (TextSize.Height / 2)
            TextPoint.X = TextPoint.X - TextSize.Width
            e.Graphics.DrawString(i.ToString(), TextFont, Brushes.Black, TextPoint)
        Next


    End Sub

End Class
