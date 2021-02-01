Public Class Form1
    Dim BMP As New Drawing.Bitmap(640, 640)
    Dim GFX As Graphics = Graphics.FromImage(BMP)
    Dim Mycolor As Object = System.Drawing.Color.FromArgb(0, 0, 0)
    Private Sub BtnDrawLine_Click(sender As Object, e As EventArgs) Handles BtnDrawLine.Click
        Dim Mypen As Pen
        Mypen = New Pen(Brushes.Black, 1)
        GFX.FillRectangle(Brushes.White, 0, 0, BMP.Width, BMP.Height)
        GFX.DrawLine(Mypen, 50, 100, 100, 100)
        GFX.DrawLine(Mypen, 100, 100, 100, 50)
        GFX.DrawLine(Mypen, 100, 50, 50, 50)
        GFX.DrawLine(Mypen, 50, 50, 50, 100)
        BMP.SetPixel(75, 75, Mycolor)
        PictureBox1.Image = BMP
    End Sub

End Class
