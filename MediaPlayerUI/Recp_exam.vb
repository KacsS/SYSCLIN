Public Class Recp_exam
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PrintDialog1.ShowDialog Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim LAPIZ As New SolidBrush(orden.ForeColor)
        Dim AREA_IMPRESION As Graphics = e.Graphics
        AREA_IMPRESION.DrawString(orden.Text, orden.Font, LAPIZ, 0, 0)
    End Sub
End Class