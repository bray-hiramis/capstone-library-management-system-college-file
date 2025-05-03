Imports System.Data.OleDb
Imports System.IO

Public Class AddAccount

    Dim con As OleDbConnection
    Dim command As OleDbCommand
    Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=|DataDirectory|\LMS_db.accdb"
    Dim bytImage() As Byte


    Private Sub AddAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.Administrator' table. You can move, or remove it, as needed.
        Me.AdministratorTableAdapter.Fill(Me.LMS_dbDataSet1.Administrator)
        txtAdminID.Focus()
        cmdNew.Enabled = True
    End Sub

    Public Sub clearall()
        txtAddress.Clear()
        txtAdminID.Clear()
        txtEmail.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtMI.Clear()
        txtPassword.Clear()
        txtPhone.Clear()
        txtUsername.Clear()
        cboDept.Text = ""
        cboGender.Text = ""
        dtpBirth.Value = Date.Today
    End Sub


    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = PictureBoxAdmin.Height
        Dim iWidth As Integer = PictureBoxAdmin.Width
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, PictureBoxAdmin.Handle.ToInt32, 0)
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PictureBoxAdmin.Width, PictureBoxAdmin.Height, SWP_NOMOVE Or SWP_NOZORDER)
        Else
            DestroyWindow(hHwnd)
        End If
    End Sub

    Private Sub ClosePreviewWindow()
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If txtAddress.Text = "" Or txtAdminID.Text = "" Or txtEmail.Text = "" Or txtFirstname.Text = "" Or txtLastname.Text = "" Or txtMI.Text = "" Or txtPassword.Text = "" Or txtPhone.Text = "" Or txtUsername.Text = "" Or cboDept.Text = "N/A" Or cboGender.Text = "N/A" Or dtpBirth.Value = Date.Today Then
                MsgBox("All fields are required", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtRetypePass.Text <> txtPassword.Text Then
            MsgBox("Password mismatch", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Mismatch")
        Else
            Try

                '"INSERT INTO [Administrator] ([AdminID], [Username], [Password], [Firstname], [Lastname], [Mid_Initial], [Gender], [Address], [Email], [DateOfBirth], [Department], [PhoneNumber], [Picture]) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13)")
                Dim ms As New System.IO.MemoryStream
                Dim bmpImage As New Bitmap(PictureBoxAdmin.Image)

                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                bytImage = ms.ToArray()
                ms.Close()
                con = New OleDbConnection(str)
                con.Open()

                Dim insert As String = "INSERT INTO [Administrator] ([Username], [Password], [Firstname], [Lastname], [Mid_Initial], [Gender], [Address], [Email], [DateOfBirth], [Department], [AdminID], [PhoneNumber]) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12)"
                command = New OleDbCommand(insert)
                command.Connection = con

                command.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "Username"))
                command.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "Password"))
                command.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "Firstname"))
                command.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "Lastname"))
                command.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "Mid_Initial"))
                command.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "Gender"))
                command.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "Address"))
                command.Parameters.Add(New OleDbParameter("@d8", System.Data.OleDb.OleDbType.VarChar, 30, "Email"))
                command.Parameters.Add(New OleDbParameter("@d9", System.Data.OleDb.OleDbType.VarChar, 30, "DateOfBirth"))
                command.Parameters.Add(New OleDbParameter("@d10", System.Data.OleDb.OleDbType.VarChar, 30, "Department"))
                command.Parameters.Add(New OleDbParameter("@d11", System.Data.OleDb.OleDbType.VarChar, 30, "AdminID"))
                command.Parameters.Add(New OleDbParameter("@d12", System.Data.OleDb.OleDbType.VarChar, 30, "PhoneNumber"))


                command.Parameters("@d1").Value = Trim(txtUsername.Text)
                command.Parameters("@d2").Value = Trim(txtPassword.Text)
                command.Parameters("@d3").Value = Trim(txtFirstname.Text)
                command.Parameters("@d4").Value = Trim(txtLastname.Text)
                command.Parameters("@d5").Value = Trim(txtMI.Text)
                command.Parameters("@d6").Value = Trim(cboGender.Text)
                command.Parameters("@d7").Value = Trim(txtAddress.Text)
                command.Parameters("@d8").Value = Trim(txtEmail.Text)
                command.Parameters("@d9").Value = Trim(dtpBirth.Value)
                command.Parameters("@d10").Value = Trim(cboDept.Text)
                command.Parameters("@d11").Value = Trim(txtAdminID.Text)
                command.Parameters("@d12").Value = Trim(txtPhone.Text)


                command.ExecuteNonQuery()

                If con.State = ConnectionState.Open Then
                    Me.AdministratorTableAdapter.Fill(Me.LMS_dbDataSet1.Administrator)
                    MsgBox("Account Created", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
                    clearall()
                    cmdAdd.Enabled = False
                    cmdNew.Enabled = True
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        clearall()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        cmdNew.Enabled = False
    End Sub

    Private Sub AddAccount_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
    End Sub
End Class