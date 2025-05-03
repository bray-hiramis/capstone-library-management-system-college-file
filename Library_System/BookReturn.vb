Imports System.Data
Imports System.Data.OleDb

Public Class BookReturn

    Dim con As OleDbConnection
    Dim command As OleDbCommand
    Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb"

    

    Private Sub RefreshBooks()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
            conn.Open()
            Dim command As New OleDbCommand("SELECT * from BookReturn", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            MainForm.DataGridView2.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using
    End Sub

    Public Sub TableAdjust()
        BorrowDataGridView.Columns(0).Width = 194
        BorrowDataGridView.Columns(1).Visible = False
        BorrowDataGridView.Columns(2).Visible = False
        BorrowDataGridView.Columns(3).Visible = False
        BorrowDataGridView.Columns(4).Visible = False
        BorrowDataGridView.Columns(5).Visible = False
        BorrowDataGridView.Columns(6).Visible = False
        BorrowDataGridView.Columns(7).Visible = False
        BorrowDataGridView.Columns(8).Visible = False
        BorrowDataGridView.Columns(9).Visible = False
        BorrowDataGridView.Columns(10).Visible = False
        BorrowDataGridView.Columns(11).Visible = False
    End Sub

    Public Sub UneableObjects()
        txtBookID2.Enabled = False
        txtBookName.Enabled = False
        dtpBorrowedDate.Enabled = False
        txtBorrowerID.Enabled = False
        txtBorrowName.Enabled = False
        dtpDuedate.Enabled = False
        txtFine.Enabled = False
        dtpReturnDate.Enabled = False
    End Sub

    Public Sub EnableContent()
        txtBookID2.Enabled = True
        txtBookName.Enabled = True
        dtpBorrowedDate.Enabled = True
        txtBorrowerID.Enabled = True
        txtBorrowName.Enabled = True
        dtpDuedate.Enabled = True
        txtFine.Enabled = True
        txtTransact2.Enabled = True
        dtpReturnDate.Enabled = True
    End Sub

    Public Sub ClearAll()
        txtBookID2.Clear()
        txtBookName.Clear()
        dtpBorrowedDate.Value = Today()
        txtBorrowerID.Clear()
        txtBorrowName.Clear()
        dtpDuedate.Value = Today
        txtFine.Clear()
        txtTransact2.Clear()
        dtpReturnDate.Value = Today
    End Sub

    Private Sub txtTransact2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransact2.KeyPress
        Me.BorrowDataGridView.Visible = True
        Me.BookBorrowBindingSource.Filter = "TransactionID like '%" & txtTransact2.Text & "%'"
    End Sub

    Private Sub BookReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.BookBorrow' table. You can move, or remove it, as needed.
        Me.BookBorrowTableAdapter.Fill(Me.LMS_dbDataSet1.BookBorrow)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.BookBorrow' table. You can move, or remove it, as needed.
        Me.BookBorrowTableAdapter.Fill(Me.LMS_dbDataSet1.BookBorrow)
        RefreshBooks()
        TableAdjust()
        dtpReturnDate.Enabled = False
    End Sub

    Private Sub dtpReturnDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpReturnDate.ValueChanged
        Dim st As Integer = dtpReturnDate.Value.Date.Subtract(dtpDuedate.Value).Days
        If (st > 0) Then
            txtFine.Text = (st * 5).ToString()
        Else
            txtFine.Text = 0
        End If
    End Sub


    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Hide()
        ClearAll()
        dtpReturnDate.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtBookID2.Text = "" Or txtBookName.Text = "" Or dtpDuedate.Value = Today Or txtBorrowerID.Text = "" Or txtBorrowName.Text = "" Or txtTransact2.Text = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        Else
            Try

                con = New OleDbConnection(str)
                con.Open()

                Dim insert As String = "INSERT INTO BookReturn (TransactionID, BorrowerID, BorrowerName, BookName, BorrowedDate, DueDate, ReturnDate, Fine, BookID) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)"
                command = New OleDbCommand(insert)
                command.Connection = con

                command.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "TransactionID"))
                command.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "BorrowerID"))
                command.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "BorrowerName"))
                command.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "BookName"))
                command.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "BorrowedDate"))
                command.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "DueDate"))
                command.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "ReturnDate"))
                command.Parameters.Add(New OleDbParameter("@d8", System.Data.OleDb.OleDbType.VarChar, 30, "Fine"))
                command.Parameters.Add(New OleDbParameter("@d9", System.Data.OleDb.OleDbType.VarChar, 30, "BookID"))

                command.Parameters("@d1").Value = Trim(txtTransact2.Text)
                command.Parameters("@d2").Value = Trim(txtBorrowerID.Text)
                command.Parameters("@d3").Value = Trim(txtBorrowName.Text)
                command.Parameters("@d4").Value = Trim(txtBookName.Text)
                command.Parameters("@d5").Value = Trim(dtpBorrowedDate.Value)
                command.Parameters("@d6").Value = Trim(dtpDuedate.Value)
                command.Parameters("@d7").Value = Trim(dtpReturnDate.Value)
                command.Parameters("@d8").Value = Trim(txtFine.Text)
                command.Parameters("@d9").Value = Trim(txtBookID2.Text)
                command.ExecuteNonQuery()

                If con.State = ConnectionState.Open Then
                    MsgBox("Book return success", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Returned")
                    MainForm.BookReturnTableAdapter.Fill(MainForm.LMS_dbDataSet1.BookReturn)
                    ClearAll()
                    UneableObjects()
                End If


            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BorrowDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BorrowDataGridView.CellClick
        If Me.BorrowDataGridView.RowCount > 0 Then

            Me.txtTransact2.Text = Me.BorrowDataGridView.CurrentRow.Cells(0).Value
            Me.txtBorrowerID.Text = Me.BorrowDataGridView.CurrentRow.Cells(3).Value
            Me.txtBorrowName.Text = Me.BorrowDataGridView.CurrentRow.Cells(4).Value
            Me.txtBookName.Text = Me.BorrowDataGridView.CurrentRow.Cells(7).Value
            Me.dtpBorrowedDate.Value = Me.BorrowDataGridView.CurrentRow.Cells(1).Value
            Me.dtpDuedate.Value = Me.BorrowDataGridView.CurrentRow.Cells(2).Value
            Me.txtBookID2.Text = Me.BorrowDataGridView.CurrentRow.Cells(11).Value
            Me.BorrowDataGridView.Visible = False
            dtpReturnDate.Enabled = True
            txtFine.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClearAll()
    End Sub
End Class