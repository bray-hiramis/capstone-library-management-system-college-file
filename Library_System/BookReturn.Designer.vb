<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReturn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookReturn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransact2 = New System.Windows.Forms.TextBox()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.txtBorrowName = New System.Windows.Forms.TextBox()
        Me.txtBookID2 = New System.Windows.Forms.TextBox()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BorrowDataGridView = New System.Windows.Forms.DataGridView()
        Me.TransactionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurposeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookBorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMS_dbDataSet1 = New Library_System.LMS_dbDataSet1()
        Me.BookBorrowTableAdapter = New Library_System.LMS_dbDataSet1TableAdapters.BookBorrowTableAdapter()
        Me.TableAdapterManager = New Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager()
        Me.dtpDuedate = New System.Windows.Forms.DateTimePicker()
        Me.dtpBorrowedDate = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.BorrowDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMS_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 33)
        Me.Panel1.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(296, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Return Book"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Transaction ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Borrower ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Borrower Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Book Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Borrowed Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(395, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Due Date:"
        '
        'txtBookName
        '
        Me.txtBookName.BackColor = System.Drawing.SystemColors.Control
        Me.txtBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.Location = New System.Drawing.Point(118, 313)
        Me.txtBookName.Multiline = True
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.ReadOnly = True
        Me.txtBookName.Size = New System.Drawing.Size(296, 108)
        Me.txtBookName.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Book ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(395, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Return Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(395, 256)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Fine:"
        '
        'txtTransact2
        '
        Me.txtTransact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransact2.Location = New System.Drawing.Point(118, 89)
        Me.txtTransact2.Name = "txtTransact2"
        Me.txtTransact2.Size = New System.Drawing.Size(194, 22)
        Me.txtTransact2.TabIndex = 52
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.BackColor = System.Drawing.SystemColors.Control
        Me.txtBorrowerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerID.Location = New System.Drawing.Point(118, 143)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.ReadOnly = True
        Me.txtBorrowerID.Size = New System.Drawing.Size(194, 22)
        Me.txtBorrowerID.TabIndex = 53
        '
        'txtBorrowName
        '
        Me.txtBorrowName.BackColor = System.Drawing.SystemColors.Control
        Me.txtBorrowName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowName.Location = New System.Drawing.Point(118, 197)
        Me.txtBorrowName.Name = "txtBorrowName"
        Me.txtBorrowName.ReadOnly = True
        Me.txtBorrowName.Size = New System.Drawing.Size(263, 22)
        Me.txtBorrowName.TabIndex = 54
        '
        'txtBookID2
        '
        Me.txtBookID2.BackColor = System.Drawing.SystemColors.Control
        Me.txtBookID2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.3!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookID2.Location = New System.Drawing.Point(118, 251)
        Me.txtBookID2.Name = "txtBookID2"
        Me.txtBookID2.ReadOnly = True
        Me.txtBookID2.Size = New System.Drawing.Size(194, 22)
        Me.txtBookID2.TabIndex = 55
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.Checked = False
        Me.dtpReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReturnDate.Location = New System.Drawing.Point(498, 195)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(159, 21)
        Me.dtpReturnDate.TabIndex = 58
        '
        'txtFine
        '
        Me.txtFine.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFine.ForeColor = System.Drawing.Color.Lime
        Me.txtFine.Location = New System.Drawing.Point(440, 249)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.ReadOnly = True
        Me.txtFine.Size = New System.Drawing.Size(147, 30)
        Me.txtFine.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(521, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 15)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "(Enter Return Date)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(585, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 51)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Return Book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BorrowDataGridView
        '
        Me.BorrowDataGridView.AllowUserToAddRows = False
        Me.BorrowDataGridView.AllowUserToDeleteRows = False
        Me.BorrowDataGridView.AllowUserToResizeColumns = False
        Me.BorrowDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.BorrowDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BorrowDataGridView.AutoGenerateColumns = False
        Me.BorrowDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BorrowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BorrowDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionIDDataGridViewTextBoxColumn, Me.BorrowedDateDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn, Me.BorrowerIDDataGridViewTextBoxColumn, Me.BorrowerNameDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.CopyDataGridViewTextBoxColumn, Me.PurposeDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.BookIDDataGridViewTextBoxColumn})
        Me.BorrowDataGridView.DataSource = Me.BookBorrowBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BorrowDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.BorrowDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.BorrowDataGridView.Location = New System.Drawing.Point(118, 90)
        Me.BorrowDataGridView.MultiSelect = False
        Me.BorrowDataGridView.Name = "BorrowDataGridView"
        Me.BorrowDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BorrowDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BorrowDataGridView.RowHeadersVisible = False
        Me.BorrowDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.BorrowDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.BorrowDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BorrowDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BorrowDataGridView.ShowRowErrors = False
        Me.BorrowDataGridView.Size = New System.Drawing.Size(194, 43)
        Me.BorrowDataGridView.TabIndex = 63
        Me.BorrowDataGridView.Visible = False
        '
        'TransactionIDDataGridViewTextBoxColumn
        '
        Me.TransactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID"
        Me.TransactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID"
        Me.TransactionIDDataGridViewTextBoxColumn.Name = "TransactionIDDataGridViewTextBoxColumn"
        Me.TransactionIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowedDateDataGridViewTextBoxColumn
        '
        Me.BorrowedDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowedDate"
        Me.BorrowedDateDataGridViewTextBoxColumn.HeaderText = "BorrowedDate"
        Me.BorrowedDateDataGridViewTextBoxColumn.Name = "BorrowedDateDataGridViewTextBoxColumn"
        Me.BorrowedDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        Me.DueDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowerIDDataGridViewTextBoxColumn
        '
        Me.BorrowerIDDataGridViewTextBoxColumn.DataPropertyName = "BorrowerID"
        Me.BorrowerIDDataGridViewTextBoxColumn.HeaderText = "BorrowerID"
        Me.BorrowerIDDataGridViewTextBoxColumn.Name = "BorrowerIDDataGridViewTextBoxColumn"
        Me.BorrowerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowerNameDataGridViewTextBoxColumn
        '
        Me.BorrowerNameDataGridViewTextBoxColumn.DataPropertyName = "BorrowerName"
        Me.BorrowerNameDataGridViewTextBoxColumn.HeaderText = "BorrowerName"
        Me.BorrowerNameDataGridViewTextBoxColumn.Name = "BorrowerNameDataGridViewTextBoxColumn"
        Me.BorrowerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        Me.BookNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CopyDataGridViewTextBoxColumn
        '
        Me.CopyDataGridViewTextBoxColumn.DataPropertyName = "Copy"
        Me.CopyDataGridViewTextBoxColumn.HeaderText = "Copy"
        Me.CopyDataGridViewTextBoxColumn.Name = "CopyDataGridViewTextBoxColumn"
        Me.CopyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurposeDataGridViewTextBoxColumn
        '
        Me.PurposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose"
        Me.PurposeDataGridViewTextBoxColumn.HeaderText = "Purpose"
        Me.PurposeDataGridViewTextBoxColumn.Name = "PurposeDataGridViewTextBoxColumn"
        Me.PurposeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookBorrowBindingSource
        '
        Me.BookBorrowBindingSource.DataMember = "BookBorrow"
        Me.BookBorrowBindingSource.DataSource = Me.LMS_dbDataSet1
        '
        'LMS_dbDataSet1
        '
        Me.LMS_dbDataSet1.DataSetName = "LMS_dbDataSet1"
        Me.LMS_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBorrowTableAdapter
        '
        Me.BookBorrowTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministratorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookBorrowTableAdapter = Me.BookBorrowTableAdapter
        Me.TableAdapterManager.BookReturnTableAdapter = Nothing
        Me.TableAdapterManager.BooksLostandReplaceTableAdapter = Nothing
        Me.TableAdapterManager.BooksTableAdapter = Nothing
        Me.TableAdapterManager.LogsActivityTableAdapter = Nothing
        Me.TableAdapterManager.LogsTimeInTableAdapter = Nothing
        Me.TableAdapterManager.LogsTimeOutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dtpDuedate
        '
        Me.dtpDuedate.Checked = False
        Me.dtpDuedate.Enabled = False
        Me.dtpDuedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDuedate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDuedate.Location = New System.Drawing.Point(498, 141)
        Me.dtpDuedate.Name = "dtpDuedate"
        Me.dtpDuedate.Size = New System.Drawing.Size(159, 21)
        Me.dtpDuedate.TabIndex = 64
        '
        'dtpBorrowedDate
        '
        Me.dtpBorrowedDate.Checked = False
        Me.dtpBorrowedDate.Enabled = False
        Me.dtpBorrowedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrowedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBorrowedDate.Location = New System.Drawing.Point(498, 90)
        Me.dtpBorrowedDate.Name = "dtpBorrowedDate"
        Me.dtpBorrowedDate.Size = New System.Drawing.Size(159, 21)
        Me.dtpBorrowedDate.TabIndex = 65
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(468, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 51)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Clear all"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BookReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.ReturnBookBG
        Me.ClientSize = New System.Drawing.Size(708, 433)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtpBorrowedDate)
        Me.Controls.Add(Me.dtpDuedate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFine)
        Me.Controls.Add(Me.dtpReturnDate)
        Me.Controls.Add(Me.txtBookID2)
        Me.Controls.Add(Me.txtBorrowName)
        Me.Controls.Add(Me.txtBorrowerID)
        Me.Controls.Add(Me.txtTransact2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BorrowDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BookReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Return"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BorrowDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMS_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTransact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrowerID As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrowName As System.Windows.Forms.TextBox
    Friend WithEvents txtBookID2 As System.Windows.Forms.TextBox
    Friend WithEvents dtpReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFine As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BorrowDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LMS_dbDataSet1 As Library_System.LMS_dbDataSet1
    Friend WithEvents BookBorrowBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookBorrowTableAdapter As Library_System.LMS_dbDataSet1TableAdapters.BookBorrowTableAdapter
    Friend WithEvents TableAdapterManager As Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TransactionIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CopyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurposeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpDuedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBorrowedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
