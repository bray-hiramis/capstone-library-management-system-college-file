Imports System.Data
Imports System.IO
Imports System.Data.OleDb

Public Class UpdateBooks
    Public con As OleDbConnection = New OleDbConnection
    Public cmd As OleDbCommand
    Public viewrecord As OleDbDataReader
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;"
    Public str As String

    

    Public Sub closeconnection()
        con.Close()
    End Sub


   

    Private Sub UpdateBooks()
        If txtAuthor.Text = "" Or txtAuthor1.Text = "" Or txtBarcode.Text = "" Or txtBarcode.Text = "" Or txtBID.Text = "" Or txtBName.Text = "" Or txtCopies.Text = "" Or txtEdition.Text = "" Or txtEdition.Text = "" Or txtISBN.Text = "" Or txtPrice.Text = "" Or txtPubName.Text = "" Or txtSupplier.Text = "" Or cboBCategory.Text = "" Or cboBClass.Text = "" Or cboBSubj.Text = "" Or cboCopyYear.Text = "" Or cboStats.Text = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        Else
            Try
                con = New OleDbConnection(connection)
                con.Open()
                Dim update As String
                update = " UPDATE [Books] SET [BookSubject] ='" & (cboBSubj.Text) & "', [BookName] ='" & (txtBName.Text) & "', [Author] ='" & (txtAuthor.Text) & "', [JointAuthor1] ='" & (txtAuthor1.Text) & "', [BookCategory] ='" & (cboBCategory.Text) & "', [BookClass] ='" & (cboBClass.Text) & "', [PublisherName] ='" & (txtPubName.Text) & "', [CopyrightYear] ='" & (cboCopyYear.Text) & "', [Barcode] ='" & (txtBarcode.Text) & "', [ISBN] ='" & (txtISBN.Text) & "', [Copies] ='" & (txtCopies.Text) & "', [Status] ='" & (cboStats.Text) & "', [Edition] ='" & (txtEdition.Text) & "', [Price] ='" & (txtPrice.Text) & "', [Supplier] ='" & (txtSupplier.Text) & "' WHERE [BookID] =" & Val(txtBID.Text) & ""
                Dim command As OleDbCommand = New OleDbCommand(update, con)
                command.ExecuteNonQuery()
                command.Dispose()
                MsgBox("Book Record is now Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Updated")
                con.Close()
                Clearall2()
                MainForm.BooksTableAdapter.Fill(MainForm.LMS_dbDataSet1.Books)
                Me.BooksTableAdapter.Fill(Me.LMS_dbDataSet1.Books)
                UnenableContent()


                Try

                    Using conn1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;")
                        conn1.Open()
                        Dim command1 As New OleDbCommand("Insert Into LogsActivity ([Date],[Time],[Name],[Action]) Values (@Date, @Time, @Name, @Action)", conn1)
                        With command1.Parameters

                            .AddWithValue("@Date", MainForm.lblDateMain.Text)
                            .AddWithValue("@Time", MainForm.lblTimeMain.Text)
                            .AddWithValue("@Name", LoginForm.txtUsername.Text)
                            .AddWithValue("@Action", "Admin " + LoginForm.txtUsername.Text + " updated a book.")

                        End With
                        command1.ExecuteNonQuery()
                        command1.Dispose()
                        conn1.Close()
                        LoadLogsActivity()
                    End Using
                Catch ex As Exception
                End Try


            Catch ex As Exception

                MsgBox(ex.Message)

            End Try


            
        End If
    End Sub

    Private Sub RefreshBooks3()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
            conn.Open()
            Dim command As New OleDbCommand("SELECT * from Books", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            MainForm.InventoryDataGridView.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using
    End Sub

    

    Public Sub Clearall2()
        txtAuthor.Clear()
        txtAuthor1.Clear()
        txtBarcode.Clear()
        txtBID.Clear()
        txtBName.Clear()
        txtCopies.Clear()
        txtEdition.Clear()
        txtISBN.Clear()
        txtPrice.Clear()
        txtPubName.Clear()
        txtSupplier.Clear()
        cboBCategory.SelectedItem = ""
        cboBClass.SelectedItem = ""
        cboBSubj.SelectedItem = ""
        cboCopyYear.SelectedItem = ""
        cboStats.SelectedItem = ""
    End Sub
    Public Sub UnenableContent()
        txtAuthor.Enabled = False
        txtAuthor1.Enabled = False
        txtBarcode.Enabled = False
        txtBID.Enabled = False
        txtBName.Enabled = False
        txtCopies.Enabled = False
        txtEdition.Enabled = False
        txtISBN.Enabled = False
        txtPrice.Enabled = False
        txtPubName.Enabled = False
        txtSupplier.Enabled = False
        cboBCategory.Enabled = False
        cboBClass.Enabled = False
        cboBSubj.Enabled = False
        cboCopyYear.Enabled = False
        cboStats.Enabled = False
    End Sub

    Public Sub EnableContent()
        txtAuthor.Enabled = True
        txtAuthor1.Enabled = True
        txtBarcode.Enabled = True
        txtBID.Enabled = True
        txtBName.Enabled = True
        txtCopies.Enabled = True
        txtEdition.Enabled = True
        txtISBN.Enabled = True
        txtPrice.Enabled = True
        txtPubName.Enabled = True
        txtSupplier.Enabled = True
        cboBCategory.Enabled = True
        cboBClass.Enabled = True
        cboBSubj.Enabled = True
        cboCopyYear.Enabled = True
        cboStats.Enabled = True
    End Sub

    Private Sub UpdateBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LMS_dbDataSet1.Books)
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LMS_dbDataSet1.Books)
        EnableContent()
    End Sub

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

    

    Private Sub cmdUpdateBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateBook.Click
        UpdateBooks()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Clearall2()
        UnenableContent()
    End Sub

    Private Sub Label20_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Label20.ForeColor = Color.Orange
    End Sub

    Private Sub Label20_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Label20.ForeColor = Color.Black
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        Clearall2()
        RefreshBooks3()
        UnenableContent()
    End Sub

    Private Sub UpdateBooks_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    End Sub
End Class