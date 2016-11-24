Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class BlueButton
    '    Inherits Button
    Private MState As MOUSESTATE
    Private ButtonRect As Rectangle

    Private Enum MOUSESTATE
        Down
        Up
        Hover
        Leave
    End Enum

#Region "Constructor"
    Public Sub New()
        InitializeComponent()

        Me.DoubleBuffered = True
        Me.Size = New Size(80, 25)

        'Set initial size for Graphics to use
        ButtonRect = Rectangle.FromLTRB(0, 0, Me.ClientRectangle.Right - 1, Me.ClientRectangle.Bottom - 1)
        MState = MOUSESTATE.Leave
    End Sub
#End Region

#Region "Overrides"
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        'Setup
        Dim G As Graphics = pevent.Graphics
        G.SmoothingMode = SmoothingMode.AntiAlias
        G.Clear(Color.FromArgb(255, 230, 230, 230))

        'Choose brushes and pens
        Dim SB As New SolidBrush(Color.FromArgb(100, 0, 100, 200))
        Dim P As New Pen(SB, 1.0F)

        'Draw the border
        G.DrawRectangle(P, Rectangle.FromLTRB(0, 0, ClientRectangle.Right - 1, ClientRectangle.Bottom - 1))

        Dim TopGradient As Color
        Dim BottomGradient As Color

        TopGradient = InlineAssignHelper(BottomGradient, Color.Black)

        Select Case MState
            Case MOUSESTATE.Down
                TopGradient = Color.FromArgb(100, 0, 180, 255)
                BottomGradient = Color.FromArgb(100, 0, 180, 255)
                Exit Select
            Case MOUSESTATE.Hover
                TopGradient = Color.FromArgb(10, 0, 210, 255)
                BottomGradient = Color.FromArgb(100, 0, 210, 255)
                Exit Select
            Case MOUSESTATE.Leave
                TopGradient = Color.FromArgb(10, 0, 180, 255)
                BottomGradient = Color.FromArgb(100, 0, 180, 255)
                Exit Select
        End Select

        'Fill the rectangle with a linear gradient
        Using LGB As New LinearGradientBrush(ButtonRect, TopGradient, BottomGradient, 90.0F)
            G.FillRectangle(LGB, ButtonRect)
        End Using

        'Draw the text to the button
        GDrawString(G, Me.Text)

        P.Dispose()
        SB.Dispose()
    End Sub

    Protected Overrides Sub OnMouseDown(mevent As MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        MState = MOUSESTATE.Down
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        MState = MOUSESTATE.Hover
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        MState = MOUSESTATE.Hover
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        MState = MOUSESTATE.Leave
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        'Set new size for Graphics to use
        ButtonRect = Rectangle.FromLTRB(0, 0, Me.ClientRectangle.Right - 1, Me.ClientRectangle.Bottom - 1)

        'Force the control to be redrawn
        Me.Invalidate()
    End Sub
#End Region

#Region "Helper Methods"
    Protected Sub GDrawString(G As Graphics, text As String)
        If text.Length > 0 Then
            Dim size As Size = G.MeasureString(text, Font, Width).ToSize()
            Dim pos As New Point(Me.Width / 2 - size.Width / 2, Me.Height / 2 - size.Height / 2)
            Using SB As New SolidBrush(Color.FromArgb(200, 0, 150, 220))
                G.DrawString(text, Me.Font, SB, pos.X, pos.Y)
            End Using
        End If
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
#End Region
End Class
