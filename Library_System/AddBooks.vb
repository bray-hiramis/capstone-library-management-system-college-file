Imports System.Data
Imports System.Data.OleDb
Public Class AddBooks

    Dim connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb"
    Dim con As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader

    Private Sub RefreshBooks2()
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

    Public Sub BookIDchecker()
        Try
            con = New OleDbConnection(connection)
            con.Open()
            Dim ct As String = "SELECT BookID from Books WHERE BookID=@find"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "BookID"))
            cmd.Parameters("@find").Value = txtBID.Text
            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("Book ID is Already Exists", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBID.Text = ""
            End If
            If Not rdr Is Nothing Then
                rdr.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Clearall()
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
        cboBCategory.Text = ""
        cboBClass.Text = ""
        cboBSubj.Text = ""
        cboCopyYear.Text = ""
        cboStats.Text = ""
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
        cmdGenerate.Enabled = False
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
        cmdGenerate.Enabled = True
    End Sub

    Private Sub Label20_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Label20.ForeColor = Color.Orange
    End Sub

    Private Sub Label20_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Label20.ForeColor = Color.Black
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainForm.Show()
        cboBCategory.SelectedItem = ""
        Clearall()
        Me.Close()


        EnableContent()
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        Dim BookID As New Random
        Dim randomBookID As Integer = BookID.Next(10000, 99999)
        Dim generatedtostring As String = randomBookID.ToString("00000")
        txtBID.Text = generatedtostring
    End Sub



    Private Sub txtCopies_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCopies.TextChanged
        If txtCopies.Text = "a" Or txtCopies.Text = "A" Then
            txtCopies.Text = ""
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtCopies.Text = "b" Or txtCopies.Text = "B" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "c" Or txtCopies.Text = "C" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "d" Or txtCopies.Text = "D" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "e" Or txtCopies.Text = "E" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "f" Or txtCopies.Text = "F" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "g" Or txtCopies.Text = "G" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "h" Or txtCopies.Text = "H" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "i" Or txtCopies.Text = "I" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "j" Or txtCopies.Text = "J" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "k" Or txtCopies.Text = "K" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "l" Or txtCopies.Text = "L" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "M" Or txtCopies.Text = "m" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "n" Or txtCopies.Text = "N" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "o" Or txtCopies.Text = "O" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "p" Or txtCopies.Text = "P" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "q" Or txtCopies.Text = "Q" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "r" Or txtCopies.Text = "R" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "s" Or txtCopies.Text = "S" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "t" Or txtCopies.Text = "T" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "u" Or txtCopies.Text = "U" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "v" Or txtCopies.Text = "V" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "W" Or txtCopies.Text = "w" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "x" Or txtCopies.Text = "X" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "y" Or txtCopies.Text = "Y" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "z" Or txtCopies.Text = "Z" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "ñ" Or txtCopies.Text = "Ñ" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        ElseIf txtCopies.Text = "!" Or txtCopies.Text = "@" Or txtCopies.Text = "#" Or txtCopies.Text = "$" Or txtCopies.Text = "%" Or txtCopies.Text = "^" Or txtCopies.Text = "&" Or txtCopies.Text = "*" Or txtCopies.Text = "(" Or txtCopies.Text = ")" Or txtCopies.Text = "-" Or txtCopies.Text = "_" Or txtCopies.Text = "=" Or txtCopies.Text = "+" Or txtCopies.Text = "[" Or txtCopies.Text = "{" Or txtCopies.Text = "]" Or txtCopies.Text = "}" Or txtCopies.Text = "\" Or txtCopies.Text = "|" Or txtCopies.Text = ";" Or txtCopies.Text = ":" Or txtCopies.Text = "'" Or txtCopies.Text = "," Or txtCopies.Text = "<" Or txtCopies.Text = "." Or txtCopies.Text = ">" Or txtCopies.Text = "/" Or txtCopies.Text = "?" Or txtCopies.Text = "~" Or txtCopies.Text = "`" Or txtCopies.Text = """" Then
            MsgBox("Only Numbers are accepted", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            txtCopies.Text = ""
        End If
    End Sub



    Private Sub AddBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMS_dbDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LMS_dbDataSet.Books)
        EnableContent()
    End Sub

    Private Sub LoadLogsActivity()
        Dim conn2 As OleDbConnection = New OleDbConnection(connection)
        Dim comm As OleDbCommand = New OleDbCommand("Select * From LogsActivity", conn2)
        Dim sda As OleDbDataAdapter = New OleDbDataAdapter(comm)
        Dim dt As New DataTable
        conn2.Open()
        sda.Fill(dt)
        conn2.Close()
        MainForm.ActDataGridView.DataSource = dt
    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If txtAuthor.Text = "" And txtBarcode.Text = "" And txtBID.Text = "" And txtBName.Text = "" And txtCopies.Text = "" And txtISBN.Text = "" And txtPubName.Text = "" And cboBCategory.Text = "" And cboBClass.Text = "" And cboBSubj.Text = "" And cboCopyYear.Text = "" And cboStats.Text = "" And txtAuthor1.Text = "" And txtSupplier.Text = "" And txtPrice.Text = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtAuthor.Text = "" Then
            MsgBox("Author of the book is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtAuthor1.Text = "" Then
            MsgBox("Atleast one Joint Author", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtBarcode.Text = "" Then
            MsgBox("Barcode is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtBID.Text = "" Then
            MsgBox("Book ID is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtBName.Text = "" Then
            MsgBox("Name of the Book is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtISBN.Text = "" Then
            MsgBox("ISBN is Required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtPubName.Text = "" Then
            MsgBox("Publisher Name is Required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf cboBCategory.Text = "" Then
            MsgBox("Book Category is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf cboBClass.Text = "" Then
            MsgBox("Book Class is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf cboBSubj.Text = "" Then
            MsgBox("Book Subject is Required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtPrice.Text = "" Then
            MsgBox("Price of the book is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtSupplier.Text = "" Then
            MsgBox("Supplier of the book is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf txtCopies.Text = "" Then
            MsgBox("Copies of the books are required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
        ElseIf cboStats.Text = "" Then
            MsgBox("Status of the book is required", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")

        Else

            Try
                Dim conn1 As OleDbConnection
                conn1 = New OleDbConnection(connection)
                conn1.Open()

                Dim cb As String = "INSERT INTO Books (BookID, BookSubject, BookName, Author, JointAuthor1, BookCategory, BookClass, PublisherName, CopyrightYear, Barcode, ISBN, Copies, Status, Edition, Price, Supplier) Values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16)"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(cb)

                cmd.Connection = conn1

                cmd.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "BookID"))
                cmd.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "BookSubject"))
                cmd.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "BookName"))
                cmd.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "Author"))
                cmd.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "JointAuthor1"))
                cmd.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "BookCategory"))
                cmd.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "BookClass"))
                cmd.Parameters.Add(New OleDbParameter("@d8", System.Data.OleDb.OleDbType.VarChar, 30, "PublisherName"))
                cmd.Parameters.Add(New OleDbParameter("@d9", System.Data.OleDb.OleDbType.VarChar, 30, "CopyrightYear"))
                cmd.Parameters.Add(New OleDbParameter("@d10", System.Data.OleDb.OleDbType.VarChar, 30, "Barcode"))
                cmd.Parameters.Add(New OleDbParameter("@d11", System.Data.OleDb.OleDbType.VarChar, 30, "ISBN"))
                cmd.Parameters.Add(New OleDbParameter("@d12", System.Data.OleDb.OleDbType.VarChar, 30, "Copies"))
                cmd.Parameters.Add(New OleDbParameter("@d13", System.Data.OleDb.OleDbType.VarChar, 30, "Status"))
                cmd.Parameters.Add(New OleDbParameter("@d14", System.Data.OleDb.OleDbType.VarChar, 30, "Edition"))
                cmd.Parameters.Add(New OleDbParameter("@d15", System.Data.OleDb.OleDbType.VarChar, 30, "Price"))
                cmd.Parameters.Add(New OleDbParameter("@d16", System.Data.OleDb.OleDbType.VarChar, 30, "Supplier"))

                cmd.Parameters("@d1").Value = Trim(txtBID.Text)
                cmd.Parameters("@d2").Value = Trim(cboBSubj.Text)
                cmd.Parameters("@d3").Value = Trim(txtBName.Text)
                cmd.Parameters("@d4").Value = Trim(txtAuthor.Text)
                cmd.Parameters("@d5").Value = Trim(txtAuthor1.Text)
                cmd.Parameters("@d6").Value = Trim(cboBCategory.Text)
                cmd.Parameters("@d7").Value = Trim(cboBClass.Text)
                cmd.Parameters("@d8").Value = Trim(txtPubName.Text)
                cmd.Parameters("@d9").Value = Trim(cboCopyYear.Text)
                cmd.Parameters("@d10").Value = Trim(txtBarcode.Text)
                cmd.Parameters("@d11").Value = Trim(txtISBN.Text)
                cmd.Parameters("@d12").Value = Trim(txtCopies.Text)
                cmd.Parameters("@d13").Value = Trim(cboStats.Text)
                cmd.Parameters("@d14").Value = Trim(txtEdition.Text)
                cmd.Parameters("@d15").Value = Trim(txtPrice.Text)
                cmd.Parameters("@d16").Value = Trim(txtSupplier.Text)
                BookIDchecker()
                cmd.ExecuteNonQuery()
                If conn1.State = ConnectionState.Open Then
                    MessageBox.Show("New Book has been added", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MainForm.BooksTableAdapter.Fill(MainForm.LMS_dbDataSet1.Books)
                    Clearall()
                    UnenableContent()
                    cmdNew.BringToFront()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try

                Using conn1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb;Persist Security Info=False;")
                    conn1.Open()
                    Dim command1 As New OleDbCommand("Insert Into LogsActivity ([Date],[Time],[Name],[Action]) Values (@Date, @Time, @Name, @Action)", conn1)
                    With command1.Parameters

                        .AddWithValue("@Date", MainForm.lblDateMain.Text)
                        .AddWithValue("@Time", MainForm.lblTimeMain.Text)
                        .AddWithValue("@Name", LoginForm.txtUsername.Text)
                        .AddWithValue("@Action", "Admin " + LoginForm.txtUsername.Text + " added a new book.")

                    End With
                    command1.ExecuteNonQuery()
                    command1.Dispose()
                    conn1.Close()
                    LoadLogsActivity()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        EnableContent()
        cmdAdd.BringToFront()
    End Sub

    Private Sub txtBID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBID.TextChanged
        Me.BooksBindingSource.Filter = "(BookName like '%" & txtBID.Text & "%')"
    End Sub

    Private Sub AddBooks_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Clearall()
    End Sub

    
End Class