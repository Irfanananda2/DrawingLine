Public Class Form2
    Dim BMP As New Drawing.Bitmap(640, 640)
    Dim GFX As Graphics = Graphics.FromImage(BMP)
    Dim red, green, blue As Int32
    Dim x1(30) As Integer
    Dim x2(30) As Integer
    Dim y1(30) As Integer
    Dim y2(30) As Integer
    Public Function Colors(x, y, z)
        Dim Mycolor As Object = System.Drawing.Color.FromArgb(x, y, z)
        Return Mycolor
    End Function
    Sub reset()
        For i As Integer = 0 To BMP.Width - 1
            For j As Integer = 0 To BMP.Height - 1
                BMP.SetPixel(i, j, Color.White)
            Next
        Next
        PicBoxCanvas.Image = BMP
    End Sub
    Sub Set_1(a As Integer, b As Integer)
        BMP.SetPixel(a, b, Color.Black)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColorBtn1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0)
        ColorBtn2.BackColor = System.Drawing.Color.FromArgb(250, 250, 250)
        ColorBtn3.BackColor = System.Drawing.Color.FromArgb(235, 26, 1)
        ColorBtn4.BackColor = System.Drawing.Color.FromArgb(19, 0, 219)
        ColorBtn5.BackColor = System.Drawing.Color.FromArgb(0, 250, 0)
        ColorBtn6.BackColor = System.Drawing.Color.FromArgb(128, 0, 0)
        ColorBtn7.BackColor = System.Drawing.Color.FromArgb(0, 0, 250)
        ColorBtn8.BackColor = System.Drawing.Color.FromArgb(0, 0, 128)
        ColorBtn9.BackColor = System.Drawing.Color.FromArgb(250, 0, 250)
        ColorBtn10.BackColor = System.Drawing.Color.FromArgb(0, 255, 255)
        ColorBtn11.BackColor = System.Drawing.Color.FromArgb(51, 51, 51)
        ColorBtn12.BackColor = System.Drawing.Color.FromArgb(51, 51, 153)
        ColorBtn13.BackColor = System.Drawing.Color.FromArgb(153, 203, 0)
        ColorBtn14.BackColor = System.Drawing.Color.FromArgb(128, 0, 0)
        ColorBtn15.BackColor = System.Drawing.Color.FromArgb(128, 250, 250)
        ColorBtn16.BackColor = System.Drawing.Color.FromArgb(250, 250, 0)
        Txtred.Text = 0
        TxtGreen.Text = 0
        TxtBlue.Text = 0
        BtnCollorSetting.BackColor = Colors(Convert.ToInt32(Txtred.Text), Convert.ToInt32(TxtGreen.Text), Convert.ToInt32(TxtBlue.Text))
        GFX.FillRectangle(Brushes.White, 0, 0, BMP.Width, BMP.Height)
        PicBoxCanvas.Image = BMP
    End Sub

    Private Sub TxtBlue_TextChanged(sender As Object, e As EventArgs) Handles TxtBlue.TextChanged
        If TxtBlue.Text = "" Then

        ElseIf TxtBlue.Text >= 256 Then

        Else
            blue = Convert.ToInt32(TxtBlue.Text)
            BtnCollorSetting.BackColor = Colors(red, green, blue)
        End If
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Algo.DDA(Convert.ToInt32(TxtX1.Text), Convert.ToInt32(TxtY1.Text), Convert.ToInt32(TxtX2.Text), Convert.ToInt32(TxtY2.Text))
        PicBoxCanvas.Image = BMP
    End Sub

    Private Sub BtnBresenham_Click(sender As Object, e As EventArgs) Handles BtnBresenham.Click
        Bresenham.Midpoint(Convert.ToInt32(TxtX1.Text), Convert.ToInt32(TxtY1.Text), Convert.ToInt32(TxtX2.Text), Convert.ToInt32(TxtY2.Text))
        PicBoxCanvas.Image = BMP
    End Sub

    Private Sub Btnreset_Click(sender As Object, e As EventArgs) Handles Btnreset.Click
        'reset()
        GFX.Clear(Color.White)
        PicBoxCanvas.Image = BMP
    End Sub

    Private Sub Txtred_TextChanged(sender As Object, e As EventArgs) Handles Txtred.TextChanged
        If Txtred.Text = "" Then

        ElseIf Txtred.Text >= 256 Then

        Else
            red = Convert.ToInt32(Txtred.Text)
            BtnCollorSetting.BackColor = Colors(red, green, blue)
        End If
    End Sub

    Private Sub TxtGreen_TextChanged(sender As Object, e As EventArgs) Handles TxtGreen.TextChanged
        If TxtGreen.Text = "" Then

        ElseIf TxtGreen.Text >= 256 Then

        Else
            green = Convert.ToInt32(TxtGreen.Text)
            BtnCollorSetting.BackColor = Colors(red, green, blue)
        End If
    End Sub

    Private Sub BtnDDA_Click(sender As Object, e As EventArgs) Handles BtnDDA.Click
        DDA.DDA(Convert.ToInt32(TxtX1.Text), Convert.ToInt32(TxtY1.Text), Convert.ToInt32(TxtX2.Text), Convert.ToInt32(TxtY2.Text))
        PicBoxCanvas.Image = BMP
    End Sub

End Class