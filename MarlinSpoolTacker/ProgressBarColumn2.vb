
'---------------------------------------------------------------------
'THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
'KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
'IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'PARTICULAR PURPOSE.
'---------------------------------------------------------------------
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace CustomProgressControl
    ''' <summary>
    ''' A DataGridViewColumn implementation that provides a column that
    ''' will display a progress bar.
    ''' </summary>
    Public Class DataGridViewProgressBarColumn
        Inherits DataGridViewTextBoxColumn
        Public Sub New()
            ' Set the cell template
            CellTemplate = New DataGridViewProgressBarCell()

            ' Set the default style padding
            Dim pad As New Padding(DataGridViewProgressBarCell.STANDARD_HORIZONTAL_MARGIN, DataGridViewProgressBarCell.STANDARD_VERTICAL_MARGIN, DataGridViewProgressBarCell.STANDARD_HORIZONTAL_MARGIN, DataGridViewProgressBarCell.STANDARD_VERTICAL_MARGIN)
            DefaultCellStyle.Padding = pad

            ' Set the default format
            DefaultCellStyle.Format = "## \%"
        End Sub


    End Class

    ''' <summary>
    ''' A DataGridViewCell class that is used to display a progress bar
    ''' within a grid cell.
    ''' </summary>
    Public Class DataGridViewProgressBarCell
        Inherits DataGridViewTextBoxCell
        ''' <summary>
        ''' Standard value to use for horizontal margins
        ''' </summary>
        Friend Const STANDARD_HORIZONTAL_MARGIN As Integer = 4

        ''' <summary>
        ''' Standard value to use for vertical margins
        ''' </summary>
        Friend Const STANDARD_VERTICAL_MARGIN As Integer = 4

        ''' <summary>
        ''' Constructor sets the expected type to int
        ''' </summary>
        Public Sub New()
            Me.ValueType = GetType(Integer)
        End Sub

        ''' <summary>
        ''' Paints the content of the cell
        ''' </summary>
        Protected Overrides Sub Paint(g As Graphics,
                                      clipBounds As Rectangle,
                                      cellBounds As Rectangle,
                                      rowIndex As Integer,
                                      cellState As DataGridViewElementStates,
                                      value As Object, _
                                      formattedValue As Object,
                                      errorText As String,
                                      cellStyle As DataGridViewCellStyle,
                                      advancedBorderStyle As DataGridViewAdvancedBorderStyle,
                                      paintParts As DataGridViewPaintParts)
            Dim leftMargin As Integer = STANDARD_HORIZONTAL_MARGIN
            Dim rightMargin As Integer = STANDARD_HORIZONTAL_MARGIN
            Dim topMargin As Integer = STANDARD_VERTICAL_MARGIN
            Dim bottomMargin As Integer = STANDARD_VERTICAL_MARGIN
            Dim imgHeight As Integer = 1
            Dim imgWidth As Integer = 1
            Dim progressWidth As Integer = 1
            Dim fontPlacement As New PointF(0, 0)

            Dim progressVal As Integer
            If value IsNot Nothing Then
                progressVal = CInt(value)
            Else
                progressVal = 0
            End If

            ' Draws the cell grid
            MyBase.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, _
                formattedValue, errorText, cellStyle, advancedBorderStyle, (paintParts And Not DataGridViewPaintParts.ContentForeground))

            ' Get margins from the style
            If cellStyle IsNot Nothing Then
                leftMargin = cellStyle.Padding.Left
                rightMargin = cellStyle.Padding.Right
                topMargin = cellStyle.Padding.Top
                bottomMargin = cellStyle.Padding.Bottom
            End If

            ' Calculate the sizes
            imgHeight = cellBounds.Bottom - cellBounds.Top - (topMargin + bottomMargin)
            imgWidth = cellBounds.Right - cellBounds.Left - (leftMargin + rightMargin)
            If imgWidth <= 0 Then
                imgWidth = 1
            End If
            If imgHeight <= 0 Then
                imgHeight = 1
            End If

            ' Calculate the progress
            progressWidth = (imgWidth * (progressVal) / 100)
            If progressWidth <= 0 Then
                If progressVal > 0 Then
                    progressWidth = 1
                Else
                    progressWidth = 0
                End If
            End If

            ' Calculate the font
            If formattedValue IsNot Nothing Then
                Dim availArea As New SizeF(imgWidth, imgHeight)
                Dim fontSize As SizeF = g.MeasureString(formattedValue.ToString(), cellStyle.Font, availArea)

                '#Region "[Font Placement Calc]"

                If cellStyle Is Nothing Then
                    fontPlacement.Y = cellBounds.Y + topMargin + ((CSng(imgHeight) - fontSize.Height) / 2)
                    fontPlacement.X = cellBounds.X + leftMargin + ((CSng(imgWidth) - fontSize.Width) / 2)
                Else
                    ' Set the Y vertical position
                    Select Case cellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomCenter,
                             DataGridViewContentAlignment.BottomLeft,
                             DataGridViewContentAlignment.BottomRight
                            If True Then
                                fontPlacement.Y = cellBounds.Y + topMargin + imgHeight - fontSize.Height
                                Exit Select
                            End If
                        Case DataGridViewContentAlignment.TopCenter,
                             DataGridViewContentAlignment.TopLeft,
                             DataGridViewContentAlignment.TopRight
                            If True Then
                                fontPlacement.Y = cellBounds.Y + topMargin - fontSize.Height
                                Exit Select
                            End If
                        Case DataGridViewContentAlignment.MiddleCenter,
                             DataGridViewContentAlignment.MiddleLeft,
                             DataGridViewContentAlignment.MiddleRight,
                             DataGridViewContentAlignment.NotSet
                            If True Then
                                fontPlacement.Y = cellBounds.Y + topMargin + ((CSng(imgHeight) - fontSize.Height) / 2)
                                Exit Select
                            End If
                        Case Else
                            If True Then
                                fontPlacement.Y = cellBounds.Y + topMargin + ((CSng(imgHeight) - fontSize.Height) / 2)
                                Exit Select
                            End If
                    End Select
                    ' Set the X horizontal position
                    Select Case cellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomLeft,
                             DataGridViewContentAlignment.MiddleLeft,
                             DataGridViewContentAlignment.TopLeft
                            If True Then
                                fontPlacement.X = cellBounds.X + leftMargin
                                Exit Select
                            End If
                        Case DataGridViewContentAlignment.BottomRight,
                             DataGridViewContentAlignment.MiddleRight,
                             DataGridViewContentAlignment.TopRight
                            If True Then
                                fontPlacement.X = cellBounds.X + leftMargin + imgWidth - fontSize.Width
                                Exit Select
                            End If
                        Case DataGridViewContentAlignment.BottomCenter,
                             DataGridViewContentAlignment.MiddleCenter,
                             DataGridViewContentAlignment.TopCenter,
                             DataGridViewContentAlignment.NotSet
                            If True Then
                                fontPlacement.X = cellBounds.X + leftMargin + ((CSng(imgWidth) - fontSize.Width) / 2)
                                Exit Select
                            End If
                        Case Else
                            If True Then
                                fontPlacement.X = cellBounds.X + leftMargin + ((CSng(imgWidth) - fontSize.Width) / 2)
                                Exit Select
                            End If
                    End Select
                    '#End Region
                End If
            End If

            ' Draw the background
            Dim backRectangle As New Rectangle(cellBounds.X + leftMargin, cellBounds.Y + topMargin, imgWidth, imgHeight)
            Using backgroundBrush As New SolidBrush(Color.FromKnownColor(KnownColor.LightGray))
                g.FillRectangle(backgroundBrush, backRectangle)
            End Using

            ' Draw the progress bar
            If progressWidth > 0 Then
                Dim progressRectangle As New Rectangle(cellBounds.X + leftMargin, cellBounds.Y + topMargin, progressWidth, imgHeight)
                Dim Color1 As Color = Color.LightGreen
                Dim Color2 As Color = Color.MediumSeaGreen
                If progressVal < Configuration.Config.Data.CriticalThreashold Then
                    Color1 = Color.LightCoral
                    Color2 = Color.OrangeRed
                ElseIf progressVal < Configuration.Config.Data.WarningThreshold Then
                    Color1 = Color.LightGoldenrodYellow
                    Color2 = Color.Goldenrod
                End If
                Using progressGradientBrush As New LinearGradientBrush(progressRectangle, Color1, Color2, LinearGradientMode.Vertical)
                    progressGradientBrush.SetBlendTriangularShape(CSng(0.5))
                    g.FillRectangle(progressGradientBrush, progressRectangle)
                End Using
            End If

            ' Draw the text
            If formattedValue IsNot Nothing AndAlso cellStyle IsNot Nothing Then
                Using fontBrush As New SolidBrush(cellStyle.ForeColor)
                    g.DrawString(formattedValue.ToString(), cellStyle.Font, fontBrush, fontPlacement)
                End Using
            End If
        End Sub
    End Class

End Namespace
