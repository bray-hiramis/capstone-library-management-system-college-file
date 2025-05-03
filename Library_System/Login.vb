Imports System.Data.OleDb
Imports System.IO
Public Class LoginForm
    Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb"

    Private Sub dgvrefresh()

        Using conn As New OleDbConnection(con)
            conn.Open()
            Dim command As New OleDbCommand("SELECT * from LogsTimeIn", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            MainForm.TimeInDataGridView1.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using

    End Sub

    Private Sub LoadLogs()
        Dim conn2 As OleDbConnection = New OleDbConnection(con)
        Dim comm As OleDbCommand = New OleDbCommand("Select * From [LogsTimeIn]", conn2)
        Dim sda As OleDbDataAdapter = New OleDbDataAdapter(comm)
        Dim dt As New DataTable
        conn2.Open()
        sda.Fill(dt)
        conn2.Close()
        MainForm.TimeInDataGridView1.DataSource = dt
    End Sub

    Private Sub Logs()
        Try

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;")
                conn.Open()
                Dim command As New OleDbCommand("Insert Into LogsTimeIn ([Date],[Time],[Name],[Action]) Values (@Date, @Time, @Name, @Action)", conn)
                Dim time As New TimeZoneNotFoundException
                Dim d As New DateFormat
                With command.Parameters

                    .AddWithValue("@Date", lblDate.Text)
                    .AddWithValue("@Time", lblTime.Text)
                    .AddWithValue("@Name", txtUsername.Text)
                    .AddWithValue("@Action", "Admin " + txtUsername.Text + " was logged in.")

                End With
                command.ExecuteNonQuery()
                command.Dispose()
                conn.Close()
                LoadLogs()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Login()

        Try

            Dim myconn As OleDbConnection
            myconn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;")
            Dim mycommand As OleDbCommand
            mycommand = New OleDbCommand("Select Username, Password From Administrator Where Username = @Username and Password = @Passwod", myconn)

            Dim username As New OleDbParameter("@Username", OleDbType.VarChar)
            Dim pass As New OleDbParameter("@Password", OleDbType.VarChar)

            username.Value = txtUsername.Text
            pass.Value = txtPassword.Text

            mycommand.Parameters.Add(username)
            mycommand.Parameters.Add(pass)

            mycommand.Connection.Open()

            Dim myreader As OleDbDataReader = mycommand.ExecuteReader(CommandBehavior.CloseConnection)

            Dim login As Object = 0

            If myreader.HasRows Then
                myreader.Read()
                login = myreader(login)

            End If

            If login = Nothing Then
                MsgBox("Login failed, try again. . .", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Access Denied")
                txtPassword.Clear()
                txtUsername.Clear()
            Else
                MsgBox("Welcome to Library Management System", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Login Success!")
                MainForm.Show()
                Logs()
                Me.Hide()
                txtPassword.Text = ""
            End If
            mycommand.Dispose()
            myconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TimerDateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDateTime.Tick
        lblDate.Text = Date.Today
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If Len(Trim(txtUsername.Text)) = 0 Or Len(Trim(txtPassword.Text)) = 0 Then
            MsgBox("Please enter Username and Password", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Denied")

        End If
        Login()
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtPassword.Clear()
        txtUsername.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        AddAccount.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Hide()
        ChangePassword.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        About.Show()
    End Sub
End Class
