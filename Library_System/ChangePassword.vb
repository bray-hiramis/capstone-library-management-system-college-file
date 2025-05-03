Imports System.Data.OleDb
Imports System.Data

Public Class ChangePassword

    Dim con As OleDbConnection
    Dim command As OleDbCommand
    Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtConfirmNewPassword.Text = "" Or txtNewPass.Text = "" Or txtOldPass.Text = "" Or txtUser.Text = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        End If

        Try

            con = New OleDbConnection(str)
            command = New OleDbCommand
            Dim dr As OleDbDataReader

            con.Open()

            command.CommandText = "select [Username],[Password] from Administrator where Username = '" & txtUser.Text & "'"
            command.Connection = con
            dr = command.ExecuteReader

            If dr.Read Then
                If UCase(dr("Password")) = UCase(txtOldPass.Text) Then

                    If txtNewPass.Text = txtConfirmNewPassword.Text Then

                        Dim cmd1 As New OleDb.OleDbCommand("Update [Administrator] Set [Password] = @UPass Where [Username] ='" & txtUser.Text & "' ", con)

                        'Password
                        Dim Pass As OleDbParameter = New OleDbParameter("@UPass", OleDbType.VarWChar, 8)
                        Pass.Value = txtNewPass.Text.ToString()
                        cmd1.Parameters.Add(Pass)


                        If cmd1.ExecuteNonQuery() Then
                            con.Close()
                            MsgBox("Password Updated", MsgBoxStyle.Information, "Update")
                            MainForm.AdministratorTableAdapter.Fill(MainForm.LMS_dbDataSet1.Administrator)
                            txtConfirmNewPassword.Clear()
                            txtNewPass.Clear()
                            txtOldPass.Clear()
                            txtUser.Clear()
                        Else
                            MsgBox("Password Update failed ", MsgBoxStyle.Critical, "Updation Failed")
                        End If

                    Else
                        MessageBox.Show("Password & confirm password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else
                    MsgBox("Old password is Wrong", MsgBoxStyle.Critical, "Password Wrong")
                End If
            End If

            Return

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ChangePassword_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
    End Sub
End Class