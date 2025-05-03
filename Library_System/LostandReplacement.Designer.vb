<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostandReplacement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LostandReplacement))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNameLost = New System.Windows.Forms.TextBox()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.txtLostPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLostAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.LostBookDataGridView = New System.Windows.Forms.DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookSubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.JointAuthor1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMS_dbDataSet1 = New Library_System.LMS_dbDataSet1()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtReplacedAuthor = New System.Windows.Forms.TextBox()
        Me.txtReplaceBookName = New System.Windows.Forms.TextBox()
        Me.txtBookIDReplace = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdReplace = New System.Windows.Forms.Button()
        Me.cmdClearAll = New System.Windows.Forms.Button()
        Me.BooksTableAdapter = New Library_System.LMS_dbDataSet1TableAdapters.BooksTableAdapter()
        Me.TableAdapterManager = New Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LostBookDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMS_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 33)
        Me.Panel1.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(240, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Book lost and replacement"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Book ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Name of the lost book:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Book Author:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtNameLost)
        Me.GroupBox1.Controls.Add(Me.txtPenalty)
        Me.GroupBox1.Controls.Add(Me.txtLostPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLostAuthor)
        Me.GroupBox1.Controls.Add(Me.txtBookID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LostBookDataGridView)
        Me.GroupBox1.Controls.Add(Me.cmdClear)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 226)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information of the lost book"
        '
        'txtNameLost
        '
        Me.txtNameLost.Location = New System.Drawing.Point(171, 26)
        Me.txtNameLost.Multiline = True
        Me.txtNameLost.Name = "txtNameLost"
        Me.txtNameLost.Size = New System.Drawing.Size(355, 74)
        Me.txtNameLost.TabIndex = 48
        '
        'txtPenalty
        '
        Me.txtPenalty.BackColor = System.Drawing.Color.Black
        Me.txtPenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenalty.ForeColor = System.Drawing.Color.Lime
        Me.txtPenalty.Location = New System.Drawing.Point(420, 182)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.ReadOnly = True
        Me.txtPenalty.Size = New System.Drawing.Size(117, 22)
        Me.txtPenalty.TabIndex = 54
        '
        'txtLostPrice
        '
        Me.txtLostPrice.BackColor = System.Drawing.Color.Black
        Me.txtLostPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLostPrice.ForeColor = System.Drawing.Color.Lime
        Me.txtLostPrice.Location = New System.Drawing.Point(420, 134)
        Me.txtLostPrice.Name = "txtLostPrice"
        Me.txtLostPrice.ReadOnly = True
        Me.txtLostPrice.Size = New System.Drawing.Size(117, 22)
        Me.txtLostPrice.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Penalty:"
        '
        'txtLostAuthor
        '
        Me.txtLostAuthor.Location = New System.Drawing.Point(114, 181)
        Me.txtLostAuthor.Name = "txtLostAuthor"
        Me.txtLostAuthor.Size = New System.Drawing.Size(237, 21)
        Me.txtLostAuthor.TabIndex = 49
        '
        'txtBookID
        '
        Me.txtBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookID.Location = New System.Drawing.Point(114, 136)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(167, 22)
        Me.txtBookID.TabIndex = 47
        '
        'LostBookDataGridView
        '
        Me.LostBookDataGridView.AllowUserToAddRows = False
        Me.LostBookDataGridView.AllowUserToDeleteRows = False
        Me.LostBookDataGridView.AllowUserToResizeColumns = False
        Me.LostBookDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.LostBookDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.LostBookDataGridView.AutoGenerateColumns = False
        Me.LostBookDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LostBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LostBookDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.BookSubjectDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.BookCategoryDataGridViewTextBoxColumn, Me.BookClassDataGridViewTextBoxColumn, Me.PublisherNameDataGridViewTextBoxColumn, Me.CopyrightYearDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.CopiesDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.EditionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.SupplierDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.JointAuthor1DataGridViewTextBoxColumn})
        Me.LostBookDataGridView.DataSource = Me.BooksBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LostBookDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.LostBookDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.LostBookDataGridView.Location = New System.Drawing.Point(171, 76)
        Me.LostBookDataGridView.MultiSelect = False
        Me.LostBookDataGridView.Name = "LostBookDataGridView"
        Me.LostBookDataGridView.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LostBookDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.LostBookDataGridView.RowHeadersVisible = False
        Me.LostBookDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.LostBookDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.LostBookDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LostBookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LostBookDataGridView.ShowRowErrors = False
        Me.LostBookDataGridView.Size = New System.Drawing.Size(355, 48)
        Me.LostBookDataGridView.TabIndex = 56
        Me.LostBookDataGridView.Visible = False
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
        'JointAuthor1DataGridViewTextBoxColumn
        '
        Me.JointAuthor1DataGridViewTextBoxColumn.DataPropertyName = "JointAuthor1"
        Me.JointAuthor1DataGridViewTextBoxColumn.HeaderText = "JointAuthor1"
        Me.JointAuthor1DataGridViewTextBoxColumn.Name = "JointAuthor1DataGridViewTextBoxColumn"
        Me.JointAuthor1DataGridViewTextBoxColumn.ReadOnly = True
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
        Me.cmdClear.Location = New System.Drawing.Point(432, 101)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(96, 30)
        Me.cmdClear.TabIndex = 51
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtReplacedAuthor)
        Me.GroupBox2.Controls.Add(Me.txtReplaceBookName)
        Me.GroupBox2.Controls.Add(Me.txtBookIDReplace)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 226)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information of the replaced book"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 33)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtReplacedAuthor
        '
        Me.txtReplacedAuthor.Location = New System.Drawing.Point(114, 175)
        Me.txtReplacedAuthor.Name = "txtReplacedAuthor"
        Me.txtReplacedAuthor.Size = New System.Drawing.Size(365, 21)
        Me.txtReplacedAuthor.TabIndex = 49
        '
        'txtReplaceBookName
        '
        Me.txtReplaceBookName.Location = New System.Drawing.Point(207, 80)
        Me.txtReplaceBookName.Multiline = True
        Me.txtReplaceBookName.Name = "txtReplaceBookName"
        Me.txtReplaceBookName.Size = New System.Drawing.Size(355, 74)
        Me.txtReplaceBookName.TabIndex = 48
        '
        'txtBookIDReplace
        '
        Me.txtBookIDReplace.Location = New System.Drawing.Point(114, 32)
        Me.txtBookIDReplace.Name = "txtBookIDReplace"
        Me.txtBookIDReplace.ReadOnly = True
        Me.txtBookIDReplace.Size = New System.Drawing.Size(167, 21)
        Me.txtBookIDReplace.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Book ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Name of the replaced book:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Book Author:"
        '
        'cmdReplace
        '
        Me.cmdReplace.Location = New System.Drawing.Point(600, 101)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(106, 43)
        Me.cmdReplace.TabIndex = 0
        Me.cmdReplace.Text = "Replaced Book"
        Me.cmdReplace.UseVisualStyleBackColor = True
        '
        'cmdClearAll
        '
        Me.cmdClearAll.Location = New System.Drawing.Point(600, 150)
        Me.cmdClearAll.Name = "cmdClearAll"
        Me.cmdClearAll.Size = New System.Drawing.Size(106, 43)
        Me.cmdClearAll.TabIndex = 52
        Me.cmdClearAll.Text = "Clear All"
        Me.cmdClearAll.UseVisualStyleBackColor = True
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
        'LostandReplacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.LostadnReplace1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(718, 564)
        Me.Controls.Add(Me.cmdClearAll)
        Me.Controls.Add(Me.cmdReplace)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LostandReplacement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LostandReplacement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LostBookDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMS_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBookID As System.Windows.Forms.TextBox
    Friend WithEvents txtLostAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtNameLost As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtReplacedAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtReplaceBookName As System.Windows.Forms.TextBox
    Friend WithEvents txtBookIDReplace As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdReplace As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPenalty As System.Windows.Forms.TextBox
    Friend WithEvents txtLostPrice As System.Windows.Forms.TextBox
    Friend WithEvents LostBookDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdClearAll As System.Windows.Forms.Button
    Friend WithEvents LMS_dbDataSet1 As Library_System.LMS_dbDataSet1
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As Library_System.LMS_dbDataSet1TableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents JointAuthor2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JointAuthor3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookSubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents JointAuthor1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
