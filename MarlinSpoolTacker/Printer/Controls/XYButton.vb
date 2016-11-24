Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class XYButton
    Private Const NumberFormat = "N1"

    Public Enum Direction
        North = 0
        East = 1
        South = 2
        West = 3
    End Enum

    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Property ButtonDirection As Direction
    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Property ButtonSize As Size
    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Property TextFont As Font
    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Property CirclePen As Pen = Pens.Gray
    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Property ButtonIndex As Integer = 1
    <EditorBrowsable(EditorBrowsableState.Always)> _
    <Browsable(True)> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
    <Bindable(True)> _
    Public Property Value As Single = -10.9

    Public Property TextBrush As Brush = Brushes.Black

    Private GPath As System.Drawing.Drawing2D.GraphicsPath
    Private TextGraphics As System.Drawing.Graphics

    Private StringFormat As StringFormat = New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
    Private TextSize As SizeF
    Private CircleSize As Single

    Public Sub New()
        InitializeComponent()
        TextGraphics = Me.CreateGraphics()
        ButtonDirection = Direction.North
        GPath = New GraphicsPath()
        TextFont = New Font("arial", 10)
        TextSize = TextGraphics.MeasureString((-10.9).ToString(NumberFormat), TextFont)
        CircleSize = Math.Max(TextSize.Height, TextSize.Width)
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
    End Sub

    Private Function OffsetPoint(x As String, y As Single) As Point
        Dim CenterPoint As Point = New Point(Me.Parent.Width / 2, Me.Parent.Height / 2)
        CenterPoint.Offset(((x * CircleSize) * ButtonIndex), ((y * CircleSize) * ButtonIndex))
        Return CenterPoint
    End Function

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)
        Dim CenterText As Rectangle = New Rectangle(((Me.Width - CircleSize) / 2), ((Me.Height - CircleSize) / 2), CircleSize, CircleSize)
        Select Case ButtonDirection
            Case Direction.North
                'GPath.ad
                'GPath.AddLines(OffsetPoint(-1, 1))
                'GPath.AddLines(OffsetPoint(-1, -1))
                'GPath.AddLines(OffsetPoint(1, -1))
                'GPath.AddLines(OffsetPoint(1, 1))
        End Select
        e.Graphics.DrawString(Value.ToString(NumberFormat), TextFont, TextBrush, CenterText, StringFormat)
        e.Graphics.DrawEllipse(Pens.Black, CenterText)
    End Sub

End Class
