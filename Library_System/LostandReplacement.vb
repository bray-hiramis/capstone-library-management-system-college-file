Imports System.Data
Imports System.Data.OleDb

Public Class LostandReplacement

    Dim con As OleDbConnection
    Dim command As OleDbCommand
    Dim str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb"

    Public Sub AutoSearch()
        ' //  for autosearch of books
        Try
            Using connect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
                connect.Open()
                Dim command As New OleDbCommand("Select * From Books Where (BookName like '%' +@BName+ '%')  ", connect)
                With command.Parameters
                    .AddWithValue("@BName", txtNameLost.Text)
                End With
                Dim adapter2 As New OleDbDataAdapter
                Dim datatable As New DataTable
                adapter2.SelectCommand = command
                LostBookDataGridView.DataSource = datatable
                adapter2.Dispose()
                command.Dispose()
                connect.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR4", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshBooksLostandReplace()
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LMS_db.accdb")
            conn.Open()
            Dim command As New OleDbCommand("SELECT * from BooksLostandReplace", conn)
            Dim adapter As New OleDbDataAdapter
            Dim dt As New DataTable
            adapter.SelectCommand = command
            adapter.Fill(dt)
            LostBookDataGridView.DataSource = dt
            adapter.Dispose()
            command.Dispose()
            conn.Close()
        End Using
    End Sub

    Public Sub ClearAllObjects()
        txtBookID.Clear()
        txtBookIDReplace.Clear()
        txtLostAuthor.Clear()
        txtLostPrice.Clear()
        txtNameLost.Clear()
        txtPenalty.Clear()
        txtReplaceBookName.Clear()
        txtReplacedAuthor.Clear()
    End Sub


    Sub ClearAll()
        txtNameLost.Text = ""
        txtBookID.Text = ""
        txtLostAuthor.Text = ""
        txtLostPrice.Text = ""
        txtPenalty.Text = ""
    End Sub

    Public Sub UnenableContent()
        txtNameLost.Enabled = False
        txtBookID.Enabled = False
        txtLostAuthor.Enabled = False
        
    End Sub

    Public Sub EnableContent()
        txtNameLost.Enabled = True
        txtBookID.Enabled = True
        txtLostAuthor.Enabled = True
    End Sub

    Public Sub ResizeTable()
        LostBookDataGridView.Columns(0).Visible = False
        LostBookDataGridView.Columns(1).Visible = False
        LostBookDataGridView.Columns(2).Width = 355
        LostBookDataGridView.Columns(3).Visible = False
        LostBookDataGridView.Columns(4).Visible = False
        LostBookDataGridView.Columns(5).Visible = False
        LostBookDataGridView.Columns(6).Visible = False
        LostBookDataGridView.Columns(7).Visible = False
        LostBookDataGridView.Columns(8).Visible = False
        LostBookDataGridView.Columns(9).Visible = False
        LostBookDataGridView.Columns(10).Visible = False
        LostBookDataGridView.Columns(11).Visible = False
        LostBookDataGridView.Columns(12).Visible = False
        LostBookDataGridView.Columns(13).Visible = False
        LostBookDataGridView.Columns(14).Visible = False
        LostBookDataGridView.Columns(15).Visible = False
    End Sub

    Private Sub LostandReplacement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMS_dbDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LMS_dbDataSet1.Books)
        ResizeTable()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub Label20_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Label20.ForeColor = Color.Orange
    End Sub

    Private Sub Label20_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Label20.ForeColor = Color.Black
    End Sub

    Private Sub txtNameLost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNameLost.KeyPress

        LostBookDataGridView.Visible = True
        Me.BooksBindingSource.Filter = "(BookName like '%" & txtNameLost.Text & "%')"

    End Sub

    Private Sub txtNameLost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameLost.TextChanged

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        EnableContent()
        ClearAll()
    End Sub

   

    Private Sub LostBookDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LostBookDataGridView.CellClick
        If Me.LostBookDataGridView.RowCount > 0 Then
            Me.txtBookID.Text = Me.LostBookDataGridView.CurrentRow.Cells(0).Value
            Me.txtNameLost.Text = Me.LostBookDataGridView.CurrentRow.Cells(2).Value
            Me.txtLostAuthor.Text = Me.LostBookDataGridView.CurrentRow.Cells(3).Value
            Me.txtLostPrice.Text = Me.LostBookDataGridView.CurrentRow.Cells(13).Value
            Me.LostBookDataGridView.Visible = False
            UnenableContent()
            txtPenalty.Text = Val(txtLostPrice.Text) / 2
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim BookID As New Random
        Dim randomBookID As Integer = BookID.Next(10000, 99999)
        Dim generatedtostring As String = randomBookID.ToString("00000")
        txtBookIDReplace.Text = generatedtostring
    End Sub

    Private Sub cmdReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReplace.Click
        If txtBookID.Text = "" Or txtBookIDReplace.Text = "" Or txtLostAuthor.Text = "" Or txtLostPrice.Text = "" Or txtNameLost.Text = "" Or txtPenalty.Text = "" Or txtReplaceBookName.Text = "" Or txtReplacedAuthor.Text = "" Then
            MsgBox("All fields are required", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        Else
            con = New OleDbConnection(str)
            con.Open()

            Dim insert As String = "INSERT INTO BooksLostandReplace (BookID, BookNameLost, BookAuthor, BookReplacementName, BookReplacementAuthor, BookReplacementID, Price, Penalty) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)"
            command = New OleDbCommand(insert)
            command.Connection = con

            command.Parameters.Add(New OleDbParameter("@d1", System.Data.OleDb.OleDbType.VarChar, 30, "BookID"))
            command.Parameters.Add(New OleDbParameter("@d2", System.Data.OleDb.OleDbType.VarChar, 30, "BookNameLost"))
            command.Parameters.Add(New OleDbParameter("@d3", System.Data.OleDb.OleDbType.VarChar, 30, "BookAuthor"))
            command.Parameters.Add(New OleDbParameter("@d4", System.Data.OleDb.OleDbType.VarChar, 30, "BookReplacementName"))
            command.Parameters.Add(New OleDbParameter("@d5", System.Data.OleDb.OleDbType.VarChar, 30, "BookReplacementAuthor"))
            command.Parameters.Add(New OleDbParameter("@d6", System.Data.OleDb.OleDbType.VarChar, 30, "BookReplacementID"))
            command.Parameters.Add(New OleDbParameter("@d7", System.Data.OleDb.OleDbType.VarChar, 30, "Price"))
            command.Parameters.Add(New OleDbParameter("@d8", System.Data.OleDb.OleDbType.VarChar, 30, "Penalty"))

            command.Parameters("@d1").Value = Trim(txtBookID.Text)
            command.Parameters("@d2").Value = Trim(txtNameLost.Text)
            command.Parameters("@d3").Value = Trim(txtLostAuthor.Text)
            command.Parameters("@d4").Value = Trim(txtReplaceBookName.Text)
            command.Parameters("@d5").Value = Trim(txtReplacedAuthor.Text)
            command.Parameters("@d6").Value = Trim(txtBookIDReplace.Text)
            command.Parameters("@d7").Value = Trim(txtLostPrice.Text)
            command.Parameters("@d8").Value = Trim(txtPenalty.Text)
            command.ExecuteNonQuery()

            Try
                If con.State = ConnectionState.Open Then
                    MsgBox("New book is now replaced", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Replaced")
                    ClearAll()
                    AddBooks.txtBID.Text = txtBookIDReplace.Text
                    AddBooks.txtBName.Text = txtReplaceBookName.Text
                    AddBooks.txtAuthor.Text = txtReplacedAuthor.Text
                    MainForm.BooksLostandReplaceTableAdapter.Fill(Me.LMS_dbDataSet1.BooksLostandReplace)
                    Me.Hide()
                    AddBooks.ShowDialog()
                End If
                
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub cmdClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearAll.Click
        ClearAllObjects()
    End Sub
End Class