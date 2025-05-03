Imports System.Data
Imports System.Data.OleDb

Public Class BorrowedBook

    Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb"
    Dim connect As OleDbConnection
    Dim command As OleDbCommand

    Private Sub RefreshBooks()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
            conn.Open()
            Dim command As New OleDbCommand("SELECT * from BookBorrow", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            MainForm.DataGridView1.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using
    End Sub

    Private Sub ResizeTable()
        DataGridView2.Columns(0).Visible = False
        DataGridView2.Columns(1).Visible = False
        DataGridView2.Columns(2).Width = 376
        DataGridView2.Columns(3).Visible = False
        DataGridView2.Columns(4).Visible = False
        DataGridView2.Columns(5).Visible = False
        DataGridView2.Columns(6).Visible = False
        DataGridView2.Columns(7).Visible = False
        DataGridView2.Columns(8).Visible = False
        DataGridView2.Columns(9).Visible = False
        DataGridView2.Columns(10).Visible = False
        DataGridView2.Columns(11).Visible = False
        DataGridView2.Columns(12).Visible = False
        DataGridView2.Columns(13).Visible = False
        DataGridView2.Columns(14).Visible = False
        DataGridView2.Columns(15).Visible = False
    End Sub

    Public Sub clearall()
        txtBookName3.Clear()
        txtBorrowerID.Clear()
        txtName.Clear()
        txtPhoneNo.Clear()
        txtTransactID.Clear()
        txtBookID.Clear()
        dtpBorrowedDate.Value = Today
        dtpDueDate.Value = Today
        cboCopy.Text = ""
        cboCourse.Text = ""
        cboPurpose.Text = ""
        cboStatus.Text = ""
    End Sub

    Public Sub EnableObjects()
        txtBookName3.Enabled = True
        txtBorrowerID.Enabled = True
        txtName.Enabled = True
        txtPhoneNo.Enabled = True
        txtTransactID.Enabled = True
        dtpDueDate.Enabled = True
        cboCopy.Enabled = True
        cboCourse.Enabled = True
        cboPurpose.Enabled = True
        cboStatus.Enabled = True
        cmdGen2.Enabled = True
    End Sub

    Public Sub UnenableObjects()
        txtBookName3.Enabled = False
        txtBorrowerID.Enabled = False
        txtName.Enabled = False
        txtPhoneNo.Enabled = False
        txtTransactID.Enabled = False
        dtpDueDate.Enabled = False
        cboCopy.Enabled = False
        cboCourse.Enabled = False
        cboPurpose.Enabled = False
        cboStatus.Enabled = False
        cmdGen2.Enabled = False
    End Sub


    Private Sub BorrowedBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.BookBorrow' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LMS_dbDataSet1.Books)
        Me.DataGridView2.Visible = False
        clearall()
        ResizeTable()
        cmdGen2.Focus()
        cmdGen2.Enabled = True
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        clearall()
        cmdBorrow.BringToFront()
        EnableObjects()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrow.Click

        If txtBookName3.Text = "" Or txtBorrowerID.Text = "" Or txtPhoneNo.Text = "" Or txtPhoneNo.Text = "" Or txtTransactID.Text = "" Or cboCopy.Text = "" Or cboCourse.Text = "" Or cboPurpose.Text = "" Or cboStatus.Text = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        Else
            Try

                connect = New OleDbConnection(str)
                connect.Open()

                Dim insert As String = "INSERT INTO BookBorrow (TransactionID, BorrowedDate, DueDate, BorrowerID, BorrowerName, Course, PhoneNumber, BookName, Copy, Purpose, Status, BookID) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12)"
                command = New OleDbCommand(insert)
                command.Connection = connect

                command.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "TransactionID"))
                command.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "BorrowedDate"))
                command.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "DueDate"))
                command.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "BorrowerID"))
                command.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "BorrowerName"))
                command.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "Course"))
                command.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "PhoneNumber"))
                command.Parameters.Add(New OleDbParameter("@d8", System.Data.OleDb.OleDbType.VarChar, 30, "BookName"))
                command.Parameters.Add(New OleDbParameter("@d9", System.Data.OleDb.OleDbType.VarChar, 30, "Copy"))
                command.Parameters.Add(New OleDbParameter("@d10", System.Data.OleDb.OleDbType.VarChar, 30, "Purpose"))
                command.Parameters.Add(New OleDbParameter("@d11", System.Data.OleDb.OleDbType.VarChar, 30, "Status"))
                command.Parameters.Add(New OleDbParameter("@d12", System.Data.OleDb.OleDbType.VarChar, 30, "BookID"))

                command.Parameters("@d1").Value = Trim(txtTransactID.Text)
                command.Parameters("@d2").Value = Trim(dtpBorrowedDate.Value)
                command.Parameters("@d3").Value = Trim(dtpDueDate.Value)
                command.Parameters("@d4").Value = Trim(txtBorrowerID.Text)
                command.Parameters("@d5").Value = Trim(txtName.Text)
                command.Parameters("@d6").Value = Trim(cboCourse.Text)
                command.Parameters("@d7").Value = Trim(txtPhoneNo.Text)
                command.Parameters("@d8").Value = Trim(txtBookName3.Text)
                command.Parameters("@d9").Value = Trim(cboCopy.Text)
                command.Parameters("@d10").Value = Trim(cboPurpose.Text)
                command.Parameters("@d11").Value = Trim(cboStatus.Text)
                command.Parameters("@d12").Value = Trim(txtBookID.Text)
                command.ExecuteNonQuery()
                
                If connect.State = ConnectionState.Open Then
                    Call MainForm.BookBorrowTableAdapter.Fill(MainForm.LMS_dbDataSet1.BookBorrow)
                    MessageBox.Show("Book Borrowing Success", "Borrowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UnenableObjects()
                    clearall()
                    cmdNew2.BringToFront()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub cmdNew2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew2.Click
        EnableObjects()
        cmdBorrow.BringToFront()
        clearall()
    End Sub

    Private Sub cmdGen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGen2.Click
        Dim BookID As New Random
        Dim randomBookID As Integer = BookID.Next(10000, 99999)
        Dim generatedtostring As String = randomBookID.ToString("00000")
        txtTransactID.Text = generatedtostring
    End Sub

    Private Sub Label20_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Label20.ForeColor = Color.Orange
    End Sub

    Private Sub Label20_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Label20.ForeColor = Color.Black
    End Sub

    Private Sub txtBookName3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBookName3.KeyPress
        Me.DataGridView2.Visible = True

        Me.BooksBindingSource.Filter = "(BookName like '%" & txtBookName3.Text & "%')"
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If Me.DataGridView2.RowCount > 0 Then
            Me.txtBookName3.Text = Me.DataGridView2.CurrentRow.Cells(2).Value
            Me.txtBookID.Text = Me.DataGridView2.CurrentRow.Cells(0).Value
            Me.DataGridView2.Visible = False
            txtBookName3.Enabled = False
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtBookName3.Text = ""
        txtBookID.Text = ""
        txtBookName3.Enabled = True
    End Sub

End Class