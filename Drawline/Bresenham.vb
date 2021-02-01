Module Bresenham
    Public Sub Midpoint(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Dim m, p, x, y, dx, dy As Decimal
        dx = Math.Abs(x2 - x1)
        dy = Math.Abs(y2 - y1)
        If (x2 - x1) = 0 Then
            m = dy
        Else
            m = dy / dx
        End If
        p = 2 * dy - dx
        x = x1
        y = y1
        While x <= x2
            Form2.Set_1(x, y)
            x += 1
            If p >= 1 Then
                y += 1
                p += 2 * dy - 2 * dx
            Else
                y = y
                p = p + 2 * dy
            End If
        End While
    End Sub
End Module
