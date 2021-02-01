Module Algo
    Public Sub DDA(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Dim dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1)

        If x1 < x2 And y1 = y2 Then                                     'Case 1
            For i As Integer = x1 To x2
                Form2.Set_1(i, y1)
            Next
        ElseIf y1 < y2 And x1 = x2 Then                                 'Case 2
            For j As Integer = y1 To y2
                Form2.Set_1(x1, j)
            Next
        ElseIf x1 > x2 And y1 = y2 Then                                 'Case 3
            For i As Integer = x2 To x1
                Form2.Set_1(i, y1)
            Next
        ElseIf y1 > y2 And x1 = x2 Then                                 'Case 4
            For j As Integer = y2 To y1
                Form2.Set_1(x1, j)
            Next
        ElseIf x1 < x2 And y1 < y2 And dx = dy Then                     'Case 5
            For i As Integer = x1 To x2
                Form2.Set_1(i, y1)
                y1 += 1
            Next
        ElseIf x1 > x2 And y1 < y2 And dx = dy Then                     'Case 6
            For j As Integer = y1 To y2
                Form2.Set_1(x1, j)
                x1 -= 1
            Next
        ElseIf x1 > x2 And y1 > y2 And dx = dy Then                     'Case 7
            For i As Integer = x2 To x1
                Form2.Set_1(x1, y1)
                y1 -= 1
                x1 -= 1
            Next
        ElseIf x1 < x2 And y1 > y2 And dx = dy Then
            For i As Integer = x1 To x2
                Form2.Set_1(x1, y1)
                y1 -= 1
            Next
        End If
    End Sub
End Module
