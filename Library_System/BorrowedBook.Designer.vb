<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowedBook
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowedBook))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBookName3 = New System.Windows.Forms.TextBox()
        Me.txtTransactID = New System.Windows.Forms.TextBox()
        Me.dtpBorrowedDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.cboCopy = New System.Windows.Forms.ComboBox()
        Me.cboPurpose = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cmdGen2 = New System.Windows.Forms.Button()
        Me.cmdBorrow = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdNew2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookSubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JointAuthor1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopyrightYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CopiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMS_dbDataSet1 = New Library_System.LMS_dbDataSet1()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.BooksTableAdapter = New Library_System.LMS_dbDataSet1TableAdapters.BooksTableAdapter()
        Me.TableAdapterManager = New Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMS_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 33)
        Me.Panel1.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(360, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Borrow Book"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 430)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 16)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Phone Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 372)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Course:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Borrower ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Due Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Borrowed Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Transaction ID:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label21.Location = New System.Drawing.Point(369, 430)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 16)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(369, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Purpose:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label19.Location = New System.Drawing.Point(369, 314)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 16)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Copy:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label17.Location = New System.Drawing.Point(366, 143)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Book Name:"
        '
        'txtBookName3
        '
        Me.txtBookName3.BackColor = System.Drawing.SystemColors.Info
        Me.txtBookName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName3.Location = New System.Drawing.Point(450, 140)
        Me.txtBookName3.Multiline = True
        Me.txtBookName3.Name = "txtBookName3"
        Me.txtBookName3.Size = New System.Drawing.Size(379, 84)
        Me.txtBookName3.TabIndex = 8
        '
        'txtTransactID
        '
        Me.txtTransactID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactID.Location = New System.Drawing.Point(116, 79)
        Me.txtTransactID.Name = "txtTransactID"
        Me.txtTransactID.ReadOnly = True
        Me.txtTransactID.Size = New System.Drawing.Size(236, 22)
        Me.txtTransactID.TabIndex = 1
        '
        'dtpBorrowedDate
        '
        Me.dtpBorrowedDate.Enabled = False
        Me.dtpBorrowedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrowedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBorrowedDate.Location = New System.Drawing.Point(115, 137)
        Me.dtpBorrowedDate.Name = "dtpBorrowedDate"
        Me.dtpBorrowedDate.Size = New System.Drawing.Size(159, 22)
        Me.dtpBorrowedDate.TabIndex = 2
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(116, 196)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(158, 22)
        Me.dtpDueDate.TabIndex = 3
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerID.Location = New System.Drawing.Point(95, 307)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(257, 22)
        Me.txtBorrowerID.TabIndex = 5
        '
        'cboCourse
        '
        Me.cboCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Items.AddRange(New Object() {"Information Technology (TechVoc)", "HRM (TechVoc)", "Office Administration", "BS Office Administation", "BS Information Technology"})
        Me.cboCourse.Location = New System.Drawing.Point(95, 364)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(257, 24)
        Me.cboCourse.TabIndex = 6
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(115, 424)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(237, 22)
        Me.txtPhoneNo.TabIndex = 7
        '
        'cboCopy
        '
        Me.cboCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCopy.FormattingEnabled = True
        Me.cboCopy.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1"})
        Me.cboCopy.Location = New System.Drawing.Point(450, 305)
        Me.cboCopy.Name = "cboCopy"
        Me.cboCopy.Size = New System.Drawing.Size(161, 24)
        Me.cboCopy.TabIndex = 10
        '
        'cboPurpose
        '
        Me.cboPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPurpose.FormattingEnabled = True
        Me.cboPurpose.Items.AddRange(New Object() {"Research Work", "Reviewer", "Project", "Thesis"})
        Me.cboPurpose.Location = New System.Drawing.Point(450, 364)
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.Size = New System.Drawing.Size(267, 24)
        Me.cboPurpose.TabIndex = 11
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"New", "Old"})
        Me.cboStatus.Location = New System.Drawing.Point(450, 419)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(161, 24)
        Me.cboStatus.TabIndex = 12
        '
        'cmdGen2
        '
        Me.cmdGen2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGen2.Location = New System.Drawing.Point(354, 79)
        Me.cmdGen2.Name = "cmdGen2"
        Me.cmdGen2.Size = New System.Drawing.Size(95, 23)
        Me.cmdGen2.TabIndex = 0
        Me.cmdGen2.Text = "Generate"
        Me.cmdGen2.UseVisualStyleBackColor = True
        '
        'cmdBorrow
        '
        Me.cmdBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrow.Location = New System.Drawing.Point(727, 405)
        Me.cmdBorrow.Name = "cmdBorrow"
        Me.cmdBorrow.Size = New System.Drawing.Size(102, 49)
        Me.cmdBorrow.TabIndex = 13
        Me.cmdBorrow.Text = "Borrow"
        Me.cmdBorrow.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(66, 250)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(286, 22)
        Me.txtName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Name:"
        '
        'cmdNew2
        '
        Me.cmdNew2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNew2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew2.Location = New System.Drawing.Point(727, 405)
        Me.cmdNew2.Name = "cmdNew2"
        Me.cmdNew2.Size = New System.Drawing.Size(102, 49)
        Me.cmdNew2.TabIndex = 13
        Me.cmdNew2.Text = "New"
        Me.cmdNew2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(369, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Book ID:"
        '
        'txtBookID
        '
        Me.txtBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookID.Location = New System.Drawing.Point(450, 250)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.ReadOnly = True
        Me.txtBookID.Size = New System.Drawing.Size(161, 22)
        Me.txtBookID.TabIndex = 9
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.BookSubjectDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.JointAuthor1DataGridViewTextBoxColumn, Me.BookCategoryDataGridViewTextBoxColumn, Me.BookClassDataGridViewTextBoxColumn, Me.PublisherNameDataGridViewTextBoxColumn, Me.CopyrightYearDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.CopiesDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.EditionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.SupplierDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.BooksBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(450, 203)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.ShowRowErrors = False
        Me.DataGridView2.Size = New System.Drawing.Size(379, 45)
        Me.DataGridView2.TabIndex = 68
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        Me.BookIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookSubjectDataGridViewTextBoxColumn
        '
        Me.BookSubjectDataGridViewTextBoxColumn.DataPropertyName = "BookSubject"
        Me.BookSubjectDataGridViewTextBoxColumn.HeaderText = "BookSubject"
        Me.BookSubjectDataGridViewTextBoxColumn.Name = "BookSubjectDataGridViewTextBoxColumn"
        Me.BookSubjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "BookName"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        Me.BookNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JointAuthor1DataGridViewTextBoxColumn
        '
        Me.JointAuthor1DataGridViewTextBoxColumn.DataPropertyName = "JointAuthor1"
        Me.JointAuthor1DataGridViewTextBoxColumn.HeaderText = "JointAuthor1"
        Me.JointAuthor1DataGridViewTextBoxColumn.Name = "JointAuthor1DataGridViewTextBoxColumn"
        Me.JointAuthor1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookCategoryDataGridViewTextBoxColumn
        '
        Me.BookCategoryDataGridViewTextBoxColumn.DataPropertyName = "BookCategory"
        Me.BookCategoryDataGridViewTextBoxColumn.HeaderText = "BookCategory"
        Me.BookCategoryDataGridViewTextBoxColumn.Name = "BookCategoryDataGridViewTextBoxColumn"
        Me.BookCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookClassDataGridViewTextBoxColumn
        '
        Me.BookClassDataGridViewTextBoxColumn.DataPropertyName = "BookClass"
        Me.BookClassDataGridViewTextBoxColumn.HeaderText = "BookClass"
        Me.BookClassDataGridViewTextBoxColumn.Name = "BookClassDataGridViewTextBoxColumn"
        Me.BookClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PublisherNameDataGridViewTextBoxColumn
        '
        Me.PublisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName"
        Me.PublisherNameDataGridViewTextBoxColumn.HeaderText = "PublisherName"
        Me.PublisherNameDataGridViewTextBoxColumn.Name = "PublisherNameDataGridViewTextBoxColumn"
        Me.PublisherNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CopyrightYearDataGridViewTextBoxColumn
        '
        Me.CopyrightYearDataGridViewTextBoxColumn.DataPropertyName = "CopyrightYear"
        Me.CopyrightYearDataGridViewTextBoxColumn.HeaderText = "CopyrightYear"
        Me.CopyrightYearDataGridViewTextBoxColumn.Name = "CopyrightYearDataGridViewTextBoxColumn"
        Me.CopyrightYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        Me.BarcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CopiesDataGridViewTextBoxColumn
        '
        Me.CopiesDataGridViewTextBoxColumn.DataPropertyName = "Copies"
        Me.CopiesDataGridViewTextBoxColumn.HeaderText = "Copies"
        Me.CopiesDataGridViewTextBoxColumn.Name = "CopiesDataGridViewTextBoxColumn"
        Me.CopiesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EditionDataGridViewTextBoxColumn
        '
        Me.EditionDataGridViewTextBoxColumn.DataPropertyName = "Edition"
        Me.EditionDataGridViewTextBoxColumn.HeaderText = "Edition"
        Me.EditionDataGridViewTextBoxColumn.Name = "EditionDataGridViewTextBoxColumn"
        Me.EditionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        Me.SupplierDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.LMS_dbDataSet1
        '
        'LMS_dbDataSet1
        '
        Me.LMS_dbDataSet1.DataSetName = "LMS_dbDataSet1"
        Me.LMS_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdClear
        '
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClear.Location = New System.Drawing.Point(734, 225)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(95, 23)
        Me.cmdClear.TabIndex = 69
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministratorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookBorrowTableAdapter = Nothing
        Me.TableAdapterManager.BookReturnTableAdapter = Nothing
        Me.TableAdapterManager.BooksLostandReplaceTableAdapter = Nothing
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.LogsActivityTableAdapter = Nothing
        Me.TableAdapterManager.LogsTimeInTableAdapter = Nothing
        Me.TableAdapterManager.LogsTimeOutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BorrowedBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.AddBooksBG3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 466)
        Me.Controls.Add(Me.txtBookName3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdGen2)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboPurpose)
        Me.Controls.Add(Me.cboCopy)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.txtBorrowerID)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.dtpBorrowedDate)
        Me.Controls.Add(Me.txtTransactID)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdBorrow)
        Me.Controls.Add(Me.cmdNew2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BorrowedBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrowed Book"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMS_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBookName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTransactID As System.Windows.Forms.TextBox
    Friend WithEvents dtpBorrowedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBorrowerID As System.Windows.Forms.TextBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents cboCopy As System.Windows.Forms.ComboBox
    Friend WithEvents cboPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmdGen2 As System.Windows.Forms.Button
    Friend WithEvents cmdBorrow As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdNew2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents LMS_dbDataSet1 As Library_System.LMS_dbDataSet1
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As Library_System.LMS_dbDataSet1TableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents BookIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookSubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JointAuthor1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JointAuthor2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JointAuthor3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookCategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CopyrightYearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CopiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
