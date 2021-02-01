Module DDA
    Public Sub DDA(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Dim x As Integer
        Dim m, y As Decimal
        m = (y2 - y1) / (x2 - x1)
        x = x1
        y = y1
        While x <= x2
            Form2.Set_1(x, Math.Round(y))
            x = x + 1
            y = y + m
        End While
    End Sub
End Module
