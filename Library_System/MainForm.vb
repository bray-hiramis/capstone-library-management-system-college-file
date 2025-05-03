Imports System.Data.OleDb
Imports System.IO

Public Class MainForm

    Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb"
    Dim con As OleDbConnection

    Private Sub Logs()
        Try

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;")
                conn.Open()
                Dim command As New OleDbCommand("Insert Into LogsTimeIn ([Date],[Time],[Name],[Action]) Values (@Date, @Time, @Name, @Action)", conn)
                With command.Parameters

                    .AddWithValue("@Date", lblDateMain.Text)
                    .AddWithValue("@Time", lblTimeMain.Text)
                    .AddWithValue("@Name", LoginForm.txtUsername.Text)
                    .AddWithValue("@Action", "Admin " + LoginForm.txtUsername.Text + " was logged out.")

                End With
                command.ExecuteNonQuery()
                command.Dispose()
                conn.Close()
                LoadLogsTimeINOUT()
                LoginForm.txtUsername.Clear()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadLogsTimeINOUT()
        Dim conn2 As OleDbConnection = New OleDbConnection(str)
        Dim comm As OleDbCommand = New OleDbCommand("Select * From LogsTimeIn", conn2)
        Dim sda As OleDbDataAdapter = New OleDbDataAdapter(comm)
        Dim dt As New DataTable
        conn2.Open()
        sda.Fill(dt)
        conn2.Close()
        TimeInDataGridView1.DataSource = dt
    End Sub
    Private Sub LoadLogsAct()
        Dim conn3 As OleDbConnection = New OleDbConnection(str)
        Dim comm1 As OleDbCommand = New OleDbCommand("Select * From LogsActivity", conn3)
        Dim sda2 As OleDbDataAdapter = New OleDbDataAdapter(comm1)
        Dim dt1 As New DataTable
        conn3.Open()
        sda2.Fill(dt1)
        conn3.Close()
        ActDataGridView.DataSource = dt1
    End Sub

    Public Sub addDGVTImeINOUT()

        TimeInDataGridView1.Columns(0).Width = 150
        TimeInDataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TimeInDataGridView1.Columns(1).Width = 150
        TimeInDataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TimeInDataGridView1.Columns(2).Width = 190
        TimeInDataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        TimeInDataGridView1.Columns(3).Width = 210
        TimeInDataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Public Sub addDGVAct()

        ActDataGridView.Columns(0).Width = 150
        ActDataGridView.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ActDataGridView.Columns(1).Width = 150
        ActDataGridView.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ActDataGridView.Columns(2).Width = 190
        ActDataGridView.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ActDataGridView.Columns(3).Width = 210
        ActDataGridView.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub RefreshBooks()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
            conn.Open()
            Dim command As New OleDbCommand("SELECT * from Books", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            InventoryDataGridView.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.Administrator' table. You can move, or remove it, as needed.
        Me.AdministratorTableAdapter.Fill(Me.LMS_dbDataSet1.Administrator)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.BookReturn' table. You can move, or remove it, as needed.
        Me.BookReturnTableAdapter.Fill(Me.LMS_dbDataSet1.BookReturn)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.BooksLostandReplace' table. You can move, or remove it, as needed.
        Me.BooksLostandReplaceTableAdapter.Fill(Me.LMS_dbDataSet1.BooksLostandReplace)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.BookBorrow' table. You can move, or remove it, as needed.
        Me.BookBorrowTableAdapter.Fill(Me.LMS_dbDataSet1.BookBorrow)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.LogsActivity' table. You can move, or remove it, as needed.
        Me.LogsActivityTableAdapter.Fill(Me.LMS_dbDataSet1.LogsActivity)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.LogsTimeIn' table. You can move, or remove it, as needed.
        Me.LogsTimeInTableAdapter.Fill(Me.LMS_dbDataSet1.LogsTimeIn)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LMS_dbDataSet1.Books)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.BookReturn' table. You can move, or remove it, as needed.
        Me.BooksLostandReplaceTableAdapter.Fill(Me.LMS_dbDataSet1.BooksLostandReplace)
        'TODO: This line of code loads data into the 'LMS_dbDataSet.BooksLostandReplace1' table. You can move, or remove it, as needed.
        HidePanel()
        addDGVTImeINOUT()
        addDGVAct()
        ResizeTable()
        ResizeBorrowTable()
        LoadLogsTimeINOUT()
        LoadLogsActivity()
        ResizeReturnTable()
    End Sub

    Private Sub ResizeTable()
        InventoryDataGridView.Columns(0).Width = 115
        InventoryDataGridView.Columns(1).Width = 220
        InventoryDataGridView.Columns(2).Width = 490
        InventoryDataGridView.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        InventoryDataGridView.Columns(3).Width = 210
        InventoryDataGridView.Columns(4).Width = 210
        InventoryDataGridView.Columns(5).Width = 220
        InventoryDataGridView.Columns(6).Width = 190
        InventoryDataGridView.Columns(7).Width = 190
        InventoryDataGridView.Columns(8).Width = 130
        InventoryDataGridView.Columns(9).Width = 210
        InventoryDataGridView.Columns(10).Width = 210
        InventoryDataGridView.Columns(13).Width = 210
        InventoryDataGridView.Columns(15).Width = 210
        InventoryDataGridView.Columns(16).Width = 210
    End Sub

    Private Sub ResizeBorrowTable()
        DataGridView1.Columns(0).Width = 230
        DataGridView1.Columns(1).Width = 280
        DataGridView1.Columns(2).Width = 280
        DataGridView1.Columns(3).Width = 230
        DataGridView1.Columns(4).Width = 260
        DataGridView1.Columns(5).Width = 260
        DataGridView1.Columns(6).Width = 240
        DataGridView1.Columns(7).Width = 490
        DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(8).Width = 120
        DataGridView1.Columns(9).Width = 230
        DataGridView1.Columns(10).Width = 180
    End Sub

    Private Sub ResizeReturnTable()
        DataGridView2.Columns(0).Width = 190
        DataGridView2.Columns(1).Width = 190
        DataGridView2.Columns(2).Width = 260
        DataGridView2.Columns(3).Width = 490
        DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.Columns(4).Width = 190
        DataGridView2.Columns(5).Width = 190
        DataGridView2.Columns(6).Width = 190
        DataGridView2.Columns(7).Width = 160
        DataGridView2.Columns(8).Width = 190
    End Sub

    Public Sub HidePanel()
        PanelLogs.Hide()
        PanelInventory.Hide()
        PanelBookBorrow.Hide()
        PanelBookReturn.Hide()
        PanelLostandReplace.Hide()
        PanelLostandReplace.Hide()
        PanelLibrarianInfo.Hide()
        PanelLibrarianInfo.Hide()
    End Sub

    Private Sub LogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogsToolStripMenuItem.Click
        PanelLogs.Top = False
        PanelLogs.Left = False
        PanelLogs.Show()
        PanelInventory.Hide()
        PanelBookBorrow.Hide()
        PanelBookReturn.Hide()
        PanelLostandReplace.Hide()
        PanelLibrarianInfo.Hide()
        PanelShowAll.Controls.Add(PanelLogs)
    End Sub

    Private Sub LoadLogsActivity()
        Dim conn2 As OleDbConnection = New OleDbConnection(str)
        Dim comm As OleDbCommand = New OleDbCommand("Select * From LogsActivity", conn2)
        Dim sda As OleDbDataAdapter = New OleDbDataAdapter(comm)
        Dim dt As New DataTable
        conn2.Open()
        sda.Fill(dt)
        conn2.Close()
        ActDataGridView.DataSource = dt
    End Sub

    Private Sub PanelShow_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelLogs.Paint
        LoadLogsActivity()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTimeMain.Text = TimeOfDay
        lblDateMain.Text = Date.Today

    End Sub


    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdInvent.MouseMove
        lblFunctions.Text = "View the stocks of the books."
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInvent.MouseLeave
        lblFunctions.Text = ""
    End Sub

    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdBorrow.MouseMove
        lblFunctions.Text = "View the records of the book and information about the borrower."
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrow.MouseLeave
        lblFunctions.Text = ""
    End Sub

    Private Sub cmdBReturn_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdBReturn.MouseMove
        lblFunctions.Text = "View the records of returned books"
    End Sub

    Private Sub cmdBReturn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBReturn.MouseLeave
        lblFunctions.Text = ""
    End Sub

    Private Sub cmdLostRep_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdLostRep.MouseMove
        lblFunctions.Text = "View the records of lost and replaced books."
    End Sub

    Private Sub cmdLostRep_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLostRep.MouseLeave
        lblFunctions.Text = ""
    End Sub

    Private Sub cmdLib_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdLib.MouseMove
        lblFunctions.Text = "View the information about the Librarian."
    End Sub

    Private Sub cmdLib_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLib.MouseLeave
        lblFunctions.Text = ""
    End Sub



    Private Sub lblCloseLogs_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCloseLogs.MouseMove
        lblCloseLogs.ForeColor = Color.DarkOrange
    End Sub

    Private Sub lblCloseLogs_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCloseLogs.MouseLeave
        lblCloseLogs.ForeColor = Color.Black
    End Sub

    Private Sub lblCloseLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCloseLogs.Click
        PanelLogs.Hide()
    End Sub

    Private Sub lblMinMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMinMain.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblCloseMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCloseMain.Click
        If MsgBox("Are you sure you want to leave?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Leave") = MsgBoxResult.Yes Then

            Me.Hide()
            LoginForm.Show()
            PanelLogs.Hide()
            Logs()
        ElseIf MsgBoxResult.No Then

        End If

    End Sub

    Private Sub lblCloseMain_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCloseMain.MouseMove
        lblCloseMain.ForeColor = Color.DarkOrange
    End Sub

    Private Sub lblMinMain_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblMinMain.MouseMove
        lblMinMain.ForeColor = Color.DarkOrange
    End Sub

    Private Sub lblCloseMain_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCloseMain.MouseLeave
        lblCloseMain.ForeColor = Color.Black
    End Sub

    Private Sub lblMinMain_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMinMain.MouseLeave
        lblMinMain.ForeColor = Color.Black
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lblTimeINOUT.Visible = True
        TimeInDataGridView1.BringToFront()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lblTimeINOUT.Visible = False
        ActDataGridView.BringToFront()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInvent.Click
        PanelInventory.Top = False
        PanelInventory.Left = False
        PanelInventory.Show()
        PanelLogs.Hide()
        PanelBookBorrow.Hide()
        PanelBookReturn.Hide()
        PanelLostandReplace.Hide()
        PanelLibrarianInfo.Hide()
        PanelShowAll.Controls.Add(PanelInventory)
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        Me.BooksBindingSource.Filter = "(BookName like '%" & txtSearch.Text & "%') or (BookSubject like '%" & txtSearch.Text & "%')"
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Leave
        txtSearch.Text = "Enter Book name or Book Subject"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AddBooks.cboBCategory.Text = "N/A"
        AddBooks.cboBClass.Text = "N/A"
        AddBooks.cboBSubj.Text = "N/A"
        AddBooks.cboCopyYear.Text = "N/A"
        AddBooks.cboStats.Text = "N/A"
        AddBooks.ShowDialog()
        AddBooks.cmdAdd.BringToFront()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UpdateBooks.ShowDialog()
        UpdateBooks.cboBCategory.Text = ""
        UpdateBooks.cboBClass.Text = ""
        UpdateBooks.cboBSubj.Text = ""
        UpdateBooks.cboCopyYear.Text = ""
        UpdateBooks.cboStats.Text = ""
    End Sub

    Private Sub InventoryDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InventoryDataGridView.CellClick
        If InventoryDataGridView.RowCount > 0 Then

            UpdateBooks.txtBID.Text = Me.InventoryDataGridView.CurrentRow.Cells(0).Value
            UpdateBooks.cboBSubj.Text = Me.InventoryDataGridView.CurrentRow.Cells(1).Value
            UpdateBooks.txtBName.Text = Me.InventoryDataGridView.CurrentRow.Cells(2).Value
            UpdateBooks.txtAuthor.Text = Me.InventoryDataGridView.CurrentRow.Cells(3).Value
            UpdateBooks.txtAuthor1.Text = Me.InventoryDataGridView.CurrentRow.Cells(16).Value
            UpdateBooks.cboBCategory.Text = Me.InventoryDataGridView.CurrentRow.Cells(4).Value
            UpdateBooks.cboBClass.Text = Me.InventoryDataGridView.CurrentRow.Cells(5).Value
            UpdateBooks.txtPubName.Text = Me.InventoryDataGridView.CurrentRow.Cells(6).Value
            UpdateBooks.cboCopyYear.Text = Me.InventoryDataGridView.CurrentRow.Cells(7).Value
            UpdateBooks.txtBarcode.Text = Me.InventoryDataGridView.CurrentRow.Cells(8).Value
            UpdateBooks.txtISBN.Text = Me.InventoryDataGridView.CurrentRow.Cells(9).Value
            UpdateBooks.txtCopies.Text = Me.InventoryDataGridView.CurrentRow.Cells(10).Value
            UpdateBooks.cboStats.Text = Me.InventoryDataGridView.CurrentRow.Cells(11).Value
            UpdateBooks.txtEdition.Text = Me.InventoryDataGridView.CurrentRow.Cells(12).Value
            UpdateBooks.txtPrice.Text = Me.InventoryDataGridView.CurrentRow.Cells(13).Value
            UpdateBooks.txtSupplier.Text = Me.InventoryDataGridView.CurrentRow.Cells(14).Value


        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If InventoryDataGridView.RowCount = 0 Then
            MsgBox("There is no Book record(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No Record")
        Else



            If MsgBox("Are you sure you want to delete this book?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
                    conn.Open()
                    Dim command As New OleDbCommand("delete * from Books where BookID = @del", conn)
                    command.Parameters.AddWithValue("@del", InventoryDataGridView.CurrentRow.Cells(0).Value)
                    Try
                        command.ExecuteNonQuery()
                        command.Dispose()
                        Dim command2 As New OleDbCommand("select * from Books", conn)
                        Dim adapter2 As New OleDbDataAdapter
                        Dim dt2 As New DataTable
                        adapter2.SelectCommand = command2
                        adapter2.Fill(dt2)
                        InventoryDataGridView.DataSource = dt2
                        MsgBox("Book record is now Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Deleted")
                        adapter2.Dispose()
                        command2.Dispose()
                        conn.Close()


                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    Try

                        Using conn1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;")
                            conn1.Open()
                            Dim command1 As New OleDbCommand("Insert Into LogsActivity ([Date],[Time],[Name],[Action]) Values (@Date, @Time, @Name, @Action)", conn1)
                            With command1.Parameters

                                .AddWithValue("@Date", lblDateMain.Text)
                                .AddWithValue("@Time", lblTimeMain.Text)
                                .AddWithValue("@Name", LoginForm.txtUsername.Text)
                                .AddWithValue("@Action", "Admin " + LoginForm.txtUsername.Text + " deleted a book.")

                            End With
                            command1.ExecuteNonQuery()
                            command1.Dispose()
                            conn1.Close()
                            LoadLogsActivity()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            Else

            End If
        End If
    End Sub

    Private Sub Label1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        Label1.ForeColor = Color.Orange
    End Sub

    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        PanelInventory.Hide()
    End Sub

    Private Sub PanelInventory_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelInventory.Paint
        Me.BooksTableAdapter.Fill(Me.LMS_dbDataSet1.Books)
    End Sub

    Private Sub cmdBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrow.Click
        PanelBookBorrow.Top = False
        PanelBookBorrow.Left = False
        PanelBookBorrow.Show()
        PanelLogs.Hide()
        PanelInventory.Hide()
        PanelBookReturn.Hide()
        PanelLostandReplace.Hide()
        PanelLibrarianInfo.Hide()
        PanelShowAll.Controls.Add(PanelBookBorrow)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BorrowedBook.ShowDialog()
        BorrowedBook.cboCopy.SelectedItem = ""
        BorrowedBook.cboCourse.SelectedItem = ""
        BorrowedBook.cboPurpose.SelectedItem = ""
        BorrowedBook.cboStatus.SelectedItem = ""
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        PanelBookBorrow.Hide()
    End Sub

    Private Sub Label4_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseMove
        Label4.ForeColor = Color.Orange
    End Sub

    Private Sub Label4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("There is no information", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No Information")
        Else
            If MsgBox("Are you sure you want to remove this Book Borrower Information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
                    conn.Open()
                    Dim command As New OleDbCommand("delete * from BookBorrow where TransactionID = @del", conn)
                    command.Parameters.AddWithValue("@del", DataGridView1.CurrentRow.Cells(0).Value)
                    Try
                        command.ExecuteNonQuery()
                        command.Dispose()
                        Dim command2 As New OleDbCommand("select * from BookBorrow", conn)
                        Dim adapter2 As New OleDbDataAdapter
                        Dim dt2 As New DataTable
                        adapter2.SelectCommand = command2
                        adapter2.Fill(dt2)
                        DataGridView1.DataSource = dt2
                        MsgBox("Record is now Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Deleted")
                        adapter2.Dispose()
                        command2.Dispose()
                        conn.Close()
                    Catch ex As Exception

                    End Try
                End Using
            Else
            End If
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.BookBorrowTableAdapter.Fill(Me.LMS_dbDataSet1.BookBorrow)
    End Sub

    Private Sub TextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        TextBox2.Text = "Enter transaction ID to search"
    End Sub

    Private Sub TextBox2_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
            Me.BookBorrowBindingSource.Filter = "TransactionID = '" & TextBox2.Text & "'"
    End Sub

    Private Sub cmdBReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBReturn.Click
        PanelBookReturn.Top = False
        PanelBookReturn.Left = False
        PanelBookReturn.Show()
        PanelLogs.Hide()
        PanelInventory.Hide()
        PanelBookBorrow.Hide()
        PanelLostandReplace.Hide()
        PanelLibrarianInfo.Hide()
        PanelShowAll.Controls.Add(PanelBookReturn)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        BookReturn.ShowDialog()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        PanelBookReturn.Hide()
    End Sub

    Private Sub Label6_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label6.MouseMove
        Label6.ForeColor = Color.Orange
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Black
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.BookReturnTableAdapter.Fill(Me.LMS_dbDataSet1.BookReturn)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Me.DataGridView2.RowCount = 0 Then
            MsgBox("There is no Information", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No Information")
        Else
            If MsgBox("Are you sure you want to remove this Book Return Information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
                    conn.Open()
                    Dim command As New OleDbCommand("delete * from BookReturn where TransactionID = @del", conn)
                    command.Parameters.AddWithValue("@del", DataGridView2.CurrentRow.Cells(0).Value)
                    Try
                        command.ExecuteNonQuery()
                        command.Dispose()
                        Dim command2 As New OleDbCommand("select * from BookReturn", conn)
                        Dim adapter2 As New OleDbDataAdapter
                        Dim dt2 As New DataTable
                        adapter2.SelectCommand = command2
                        adapter2.Fill(dt2)
                        DataGridView2.DataSource = dt2
                        MsgBox("Record is now Deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Deleted")
                        adapter2.Dispose()
                        command2.Dispose()
                        conn.Close()
                    Catch ex As Exception

                    End Try
                End Using
            Else
            End If
        End If
    End Sub

    Private Sub TextBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Click
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        TextBox3.Text = "Enter Trasaction ID to search"
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Me.BookReturnBindingSource.Filter = "TransactionID = '" & TextBox3.Text & "'"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        LostandReplacement.ShowDialog()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        PanelLostandReplace.Hide()
    End Sub

    Private Sub cmdLostRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLostRep.Click
        PanelLostandReplace.Top = False
        PanelLostandReplace.Left = False
        PanelLostandReplace.Show()
        PanelLogs.Hide()
        PanelInventory.Hide()
        PanelBookBorrow.Hide()
        PanelBookReturn.Hide()
        PanelLibrarianInfo.Hide()
        PanelShowAll.Controls.Add(PanelLostandReplace)
    End Sub

    Private Sub Label9_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label9.MouseMove
        Label9.ForeColor = Color.Orange
    End Sub

    Private Sub Label9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.MouseLeave
        Label9.ForeColor = Color.Black
    End Sub

    Private Sub PanelBookBorrow_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelBookBorrow.Paint
        Me.BookBorrowTableAdapter.Fill(Me.LMS_dbDataSet1.BookBorrow)
    End Sub

    Private Sub PanelLostandReplace_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelLostandReplace.Paint
        Me.BooksLostandReplaceTableAdapter.Fill(Me.LMS_dbDataSet1.BooksLostandReplace)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.BooksLostandReplaceTableAdapter.Fill(Me.LMS_dbDataSet1.BooksLostandReplace)
    End Sub

    Private Sub TextBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.Click
        TextBox4.Text = ""
    End Sub

    Private Sub TextBox4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.Leave
        TextBox4.Text = "Enter Book ID to search"
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Me.BooksLostandReplaceBindingSource.Filter = "BookID like '%" & TextBox4.Text & "%'"
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddAccount.Show()
    End Sub

    Private Sub cmdLib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLib.Click
        PanelLibrarianInfo.Top = False
        PanelLibrarianInfo.Left = False
        PanelLibrarianInfo.Show()
        PanelLogs.Hide()
        PanelInventory.Hide()
        PanelBookBorrow.Hide()
        PanelBookReturn.Hide()
        PanelLostandReplace.Hide()
        PanelShowAll.Controls.Add(PanelLibrarianInfo)
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        PanelLibrarianInfo.Hide()
        Me.AdministratorTableAdapter.Fill(Me.LMS_dbDataSet1.Administrator)
    End Sub

    Private Sub Label11_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label11.MouseMove
        Label11.ForeColor = Color.Orange
    End Sub

    Private Sub Label11_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.MouseLeave
        Label11.ForeColor = Color.Black
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.AdministratorTableAdapter.Fill(Me.LMS_dbDataSet1.Administrator)
    End Sub


    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Me.AdministratorBindingSource.MoveNext()
    End Sub

    Private Sub cmdPre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPre.Click
        Me.AdministratorBindingSource.MovePrevious()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Me.AdministratorBindingSource.Filter = "Username like '%" & TextBox5.Text & "%'"
    End Sub

   

    Private Sub cmdUpdateInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateInfo.Click
        If cmdSave.Enabled = False Then
            cmdUpdateInfo.Enabled = False
            cmdPre.Enabled = False
            cmdNext.Enabled = False
            cmdSave.Enabled = True
            cmdDeleteInfo.Enabled = False
            Label1.Visible = False
            txtAddress.ReadOnly = False
            txtAdminID.ReadOnly = False
            txtEmail.ReadOnly = False
            txtFirstname.ReadOnly = False
            txtLastname.ReadOnly = False
            txtMI.ReadOnly = False
            txtPhone.ReadOnly = False
            txtUsername.ReadOnly = False
            TextBox5.Enabled = False
            cboDept.Enabled = True
            cboGender.Enabled = True
            dtpBirth.Enabled = True
        End If
    End Sub

    Private Sub UpdateAdmin()
        'If txtAuthor.Text = "" Or txtAuthor1.Text = "" Or txtBarcode.Text = "" Or txtBarcode.Text = "" Or txtBID.Text = "" Or txtBName.Text = "" Or txtCopies.Text = "" Or txtEdition.Text = "" Or txtEdition.Text = "" Or txtISBN.Text = "" Or txtPrice.Text = "" Or txtPubName.Text = "" Or txtSupplier.Text = "" Or cboBCategory.Text = "" Or cboBClass.Text = "" Or cboBSubj.Text = "" Or cboCopyYear.Text = "" Or cboStats.Text = "" Then
        'MsgBox("All fields are required", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        'Else
        Try
            con = New OleDbConnection(str)
            con.Open()
            Dim update As String
            update = " UPDATE [Administrator] SET [Username] = '" & txtUsername.Text & "', [Password] = '" & txtPassword.Text & "', [Firstname] = '" & txtFirstname.Text & "', [Lastname] = '" & txtLastname.Text & "', [Mid_Initial] = '" & txtMI.Text & "', [Gender] = '" & cboGender.Text & "', [Address] = '" & txtAddress.Text & "', [Email] = '" & txtEmail.Text & "', [DateOfBirth] = '" & dtpBirth.Value & "', [Department] = '" & cboDept.Text & "', [PhoneNumber] = '" & txtPhone.Text & "' WHERE [AdminID] = " & txtAdminID.Text & ""
            Dim command As OleDbCommand = New OleDbCommand(update, con)
            command.ExecuteNonQuery()
            command.Dispose()
            MsgBox("Administrator acoount updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Updated")
            con.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        'End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Me.Validate()
            Me.AdministratorBindingSource.EndEdit()
            Me.AdministratorTableAdapter.Update(Me.LMS_dbDataSet1.Administrator)
            Me.AdministratorTableAdapter.Fill(Me.LMS_dbDataSet1.Administrator)
            MsgBox("Administrator acoount updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Updated")
            cmdUpdateInfo.Enabled = True
            cmdPre.Enabled = True
            cmdNext.Enabled = True
            cmdSave.Enabled = False
            cmdDeleteInfo.Enabled = True
            Label1.Visible = True
            txtAddress.ReadOnly = True
            txtAdminID.ReadOnly = True
            txtEmail.ReadOnly = True
            txtFirstname.ReadOnly = True
            txtLastname.ReadOnly = True
            txtMI.ReadOnly = True
            txtPhone.ReadOnly = True
            txtUsername.ReadOnly = True
            TextBox5.Enabled = True
            cboDept.Enabled = False
            cboGender.Enabled = False
            dtpBirth.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdDeleteInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteInfo.Click
        If MsgBox("Are you sure you want to delete this account?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Deleting") = MsgBoxResult.Yes Then
            Me.AdministratorBindingSource.RemoveCurrent()
            MsgBox("Administrator acoount deleted", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Deleted")
        Else

        End If
    End Sub

    Private Sub PanelLibrarianInfo_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelLibrarianInfo.Paint

    End Sub

    Private Sub SendNotificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendNotificationToolStripMenuItem.Click
        Database.ShowDialog()
    End Sub

    Private Sub WordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("winword.exe")
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click
        System.Diagnostics.Process.Start("excel.exe")
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe")
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordpadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("wordpad.exe")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help.ShowDialog()
    End Sub
End Class