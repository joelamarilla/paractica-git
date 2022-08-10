Public Class Form1


    Private Sub btbcerrar1_Click(sender As Object, e As EventArgs) Handles btbcerrar1.Click
        End
    End Sub

    Private Sub btbcerrar2_Click(sender As Object, e As EventArgs) Handles btbcerrar2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub
End Class
