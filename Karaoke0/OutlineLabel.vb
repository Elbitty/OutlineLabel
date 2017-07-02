Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Public Class OutlineLabel
    Inherits Label
    Public Sub New()
        ForeColor = Color.White
        OutlineForeColor = Color.Black
        OutlineWidth = 2
    End Sub
    Public Property OutlineForeColor() As Color
        Get
            Return m_OutlineForeColor
        End Get
        Set
            m_OutlineForeColor = Value
        End Set
    End Property
    Private m_OutlineForeColor As Color
    Public Property OutlineWidth() As Single
        Get
            Return m_OutlineWidth
        End Get
        Set
            m_OutlineWidth = Value
        End Set
    End Property
    Private m_OutlineWidth As Single
    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        e.Graphics.TextRenderingHint = _textRenderingHint


        e.Graphics.FillRectangle(New SolidBrush(BackColor), ClientRectangle)
        Using gp As New GraphicsPath()
            Using outline As New Pen(OutlineForeColor, OutlineWidth) With {
                .LineJoin = LineJoin.Round
            }
                Using sf As New StringFormat()
                    Using foreBrush As Brush = New SolidBrush(ForeColor)
                        gp.AddString(Text, Font.FontFamily, CInt(Font.Style), Font.Size, ClientRectangle, sf)
                        e.Graphics.ScaleTransform(1.3F, 1.35F)
                        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
                        e.Graphics.DrawPath(outline, gp)
                        e.Graphics.FillPath(foreBrush, gp)
                    End Using
                End Using
            End Using
        End Using

        'Me.OnPaint(e)

    End Sub
    Private _textRenderingHint As TextRenderingHint = TextRenderingHint.SingleBitPerPixel

    Public Property TextRenderingHint() As TextRenderingHint
        Get
            Return _textRenderingHint
        End Get
        Set
            _textRenderingHint = Value
        End Set
    End Property

 

End Class
