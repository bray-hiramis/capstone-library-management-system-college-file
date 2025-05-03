Imports System.Data.OleDb
Imports System.IO

Public Class Database

    Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;"

    Private Sub LoadLogsActivity()
        Dim conn2 As OleDbConnection = New OleDbConnection(str)
        Dim comm As OleDbCommand = New OleDbCommand("Select * From LogsActivity", conn2)
        Dim sda As OleDbDataAdapter = New OleDbDataAdapter(comm)
        Dim dt As New DataTable
        conn2.Open()
        sda.Fill(dt)
        conn2.Close()
        MainForm.ActDataGridView.DataSource = dt
    End Sub

    Private Sub LogsBackup()
        Try

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;")
                conn.Open()
                Dim command As New OleDbCommand("Insert Into LogsActivity ([Date],[Time],[Name],[Action]) Values (@Date, @Time, @Name, @Action)", conn)
                With command.Parameters

                    .AddWithValue("@Date", MainForm.lblDateMain.Text)
                    .AddWithValue("@Time", MainForm.lblTimeMain.Text)
                    .AddWithValue("@Name", LoginForm.txtUsername.Text)
                    .AddWithValue("@Action", "Admin " + LoginForm.txtUsername.Text + " Backed up the database.")

                End With
                command.ExecuteNonQuery()
                command.Dispose()
                conn.Close()
                LoadLogsActivity()

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LogsRetrieve()
        Try

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;")
                conn.Open()
                Dim command As New OleDbCommand("Insert Into LogsActivity ([Date],[Time],[Name],[Action]) Values (@Date, @Time, @Name, @Action)", conn)
                With command.Parameters

                    .AddWithValue("@Date", MainForm.lblDateMain.Text)
                    .AddWithValue("@Time", MainForm.lblTimeMain.Text)
                    .AddWithValue("@Name", LoginForm.txtUsername.Text)
                    .AddWithValue("@Action", "Admin " + LoginForm.txtUsername.Text + " Retrieved the database.")

                End With
                command.ExecuteNonQuery()
                command.Dispose()
                conn.Close()
                LoadLogsActivity()

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            Dim pass As String = txtUserPass.Text

            If RadioBackup.Checked = False And RadioRetrieve.Checked = False Then
                MsgBox("Please select an action to execute.")
            ElseIf txtVerifyPass.Text = pass And RadioBackup.Checked = True Then
                Dim FileToMove As String
                Dim MoveLocation As String
                Dim FileToDel As String

                FileToMove = "" & System.Environment.CurrentDirectory & "\LMS_db.accdb"
                MoveLocation = "" & System.Environment.CurrentDirectory & "\backup\LMS_db.accdb"
                FileToDel = "" & System.Environment.CurrentDirectory & "\backup\LMS_db.accdb"

                System.IO.File.Delete(FileToDel)
                System.IO.File.Copy(FileToMove, MoveLocation)
                MsgBox("Database successfully backed up", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Successful")

                LogsBackup()

                txtVerifyPass.Text = ""
                Me.Hide()

            ElseIf txtVerifyPass.Text = pass And RadioRetrieve.Checked = True Then
                Dim FileToMove As String
                Dim MoveLocation As String
                Dim FileToDel As String

                FileToMove = "" & System.Environment.CurrentDirectory & "\backup\LMS_db.accdb"
                MoveLocation = "" & System.Environment.CurrentDirectory & "\LMS_db.accdb"
                FileToDel = "" & System.Environment.CurrentDirectory & "\LMS_db.accdb"

                System.IO.File.Delete(FileToDel)
                System.IO.File.Copy(FileToMove, MoveLocation)
                MsgBox("Database successfully retrieved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Successful")

                LogsRetrieve()

                txtVerifyPass.Text = ""
                Me.Hide()

            Else
                MsgBox("Access Denied!")
                txtVerifyPass.Text = ""
            End If
    End Sub

End Class