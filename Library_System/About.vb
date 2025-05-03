Public Class About

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub Label2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        Label2.ForeColor = Color.Orange
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black
    End Sub
End Class