Public Class Splash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        If ProgressBar1.Value = 10 Then

        ElseIf ProgressBar1.Value = 20 Then
        ElseIf ProgressBar1.Value = 40 Then
        ElseIf ProgressBar1.Value = 60 Then
        ElseIf ProgressBar1.Value = 80 Then
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub
End Class