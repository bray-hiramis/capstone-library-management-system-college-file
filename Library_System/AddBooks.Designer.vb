<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBooks))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBName = New System.Windows.Forms.TextBox()
        Me.cboBSubj = New System.Windows.Forms.ComboBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtAuthor1 = New System.Windows.Forms.TextBox()
        Me.cboBCategory = New System.Windows.Forms.ComboBox()
        Me.cboBClass = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboCopyYear = New System.Windows.Forms.ComboBox()
        Me.txtPubName = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.cboStats = New System.Windows.Forms.ComboBox()
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMS_dbDataSet = New Library_System.LMS_dbDataSet()
        Me.BooksTableAdapter = New Library_System.LMS_dbDataSetTableAdapters.BooksTableAdapter()
        Me.TableAdapterManager = New Library_System.LMS_dbDataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMS_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 33)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(336, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BookID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Book Subject:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Book Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Author:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Joint Authors:"
        '
        'txtBID
        '
        Me.txtBID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBID.Location = New System.Drawing.Point(111, 71)
        Me.txtBID.Name = "txtBID"
        Me.txtBID.ReadOnly = True
        Me.txtBID.Size = New System.Drawing.Size(112, 22)
        Me.txtBID.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Book Category:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Book Class:"
        '
        'txtBName
        '
        Me.txtBName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBName.Location = New System.Drawing.Point(111, 140)
        Me.txtBName.Multiline = True
        Me.txtBName.Name = "txtBName"
        Me.txtBName.Size = New System.Drawing.Size(356, 48)
        Me.txtBName.TabIndex = 11
        '
        'cboBSubj
        '
        Me.cboBSubj.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBSubj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBSubj.FormattingEnabled = True
        Me.cboBSubj.Items.AddRange(New Object() {"Computer Fundamentals", "Computer Programming", "English", "Filipino", "History", "Mathematics", "Psychology", "Science", "Values"})
        Me.cboBSubj.Location = New System.Drawing.Point(111, 104)
        Me.cboBSubj.Name = "cboBSubj"
        Me.cboBSubj.Size = New System.Drawing.Size(203, 24)
        Me.cboBSubj.Sorted = True
        Me.cboBSubj.TabIndex = 12
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(126, 200)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(272, 22)
        Me.txtAuthor.TabIndex = 13
        '
        'txtAuthor1
        '
        Me.txtAuthor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor1.Location = New System.Drawing.Point(126, 235)
        Me.txtAuthor1.Multiline = True
        Me.txtAuthor1.Name = "txtAuthor1"
        Me.txtAuthor1.Size = New System.Drawing.Size(341, 92)
        Me.txtAuthor1.TabIndex = 14
        '
        'cboBCategory
        '
        Me.cboBCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBCategory.FormattingEnabled = True
        Me.cboBCategory.Items.AddRange(New Object() {"Charts", "Clippings", "Dissertation", "Feasibility/Project/Research Study", "Journals", "Maps", "Pamphlets", "Referrence", "Serials Bound", "Serials Unbound", "Term Paper", "Thesis"})
        Me.cboBCategory.Location = New System.Drawing.Point(126, 338)
        Me.cboBCategory.Name = "cboBCategory"
        Me.cboBCategory.Size = New System.Drawing.Size(257, 24)
        Me.cboBCategory.TabIndex = 17
        '
        'cboBClass
        '
        Me.cboBClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBClass.FormattingEnabled = True
        Me.cboBClass.Items.AddRange(New Object() {"Arts and Recreation", "Computer Science", "History, Geography and Biography", "Languange", "Literature", "Philosophy and Psychology", "Religion", "Science"})
        Me.cboBClass.Location = New System.Drawing.Point(126, 373)
        Me.cboBClass.Name = "cboBClass"
        Me.cboBClass.Size = New System.Drawing.Size(303, 24)
        Me.cboBClass.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(472, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Publisher Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(472, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Copyright Year:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(472, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Barcode:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(472, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "ISBN:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(472, 224)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 17)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Copies:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(472, 261)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Status:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(472, 298)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 17)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Edition:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(472, 335)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 17)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Price:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(472, 372)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 17)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Supplier:"
        '
        'cboCopyYear
        '
        Me.cboCopyYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCopyYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCopyYear.FormattingEnabled = True
        Me.cboCopyYear.Items.AddRange(New Object() {"2026", "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980"})
        Me.cboCopyYear.Location = New System.Drawing.Point(584, 106)
        Me.cboCopyYear.Name = "cboCopyYear"
        Me.cboCopyYear.Size = New System.Drawing.Size(158, 24)
        Me.cboCopyYear.TabIndex = 28
        '
        'txtPubName
        '
        Me.txtPubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPubName.Location = New System.Drawing.Point(584, 69)
        Me.txtPubName.Name = "txtPubName"
        Me.txtPubName.Size = New System.Drawing.Size(219, 22)
        Me.txtPubName.TabIndex = 29
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(543, 145)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(239, 22)
        Me.txtBarcode.TabIndex = 30
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(543, 182)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(239, 22)
        Me.txtISBN.TabIndex = 31
        '
        'cboStats
        '
        Me.cboStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStats.FormattingEnabled = True
        Me.cboStats.Items.AddRange(New Object() {"New", "Old"})
        Me.cboStats.Location = New System.Drawing.Point(543, 254)
        Me.cboStats.Name = "cboStats"
        Me.cboStats.Size = New System.Drawing.Size(140, 24)
        Me.cboStats.TabIndex = 33
        '
        'txtEdition
        '
        Me.txtEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdition.Location = New System.Drawing.Point(543, 293)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(260, 22)
        Me.txtEdition.TabIndex = 34
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(543, 330)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(140, 22)
        Me.txtPrice.TabIndex = 35
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.Location = New System.Drawing.Point(542, 367)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(261, 22)
        Me.txtSupplier.TabIndex = 36
        '
        'cmdAdd
        '
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Image = Global.Library_System.My.Resources.Resources.add
        Me.cmdAdd.Location = New System.Drawing.Point(705, 397)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(102, 37)
        Me.cmdAdd.TabIndex = 37
        Me.cmdAdd.Text = "Add Book"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtCopies
        '
        Me.txtCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopies.Location = New System.Drawing.Point(542, 219)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(141, 22)
        Me.txtCopies.TabIndex = 39
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Image = Global.Library_System.My.Resources.Resources.arrow_refresh
        Me.cmdGenerate.Location = New System.Drawing.Point(229, 71)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(85, 24)
        Me.cmdGenerate.TabIndex = 40
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = Global.Library_System.My.Resources.Resources.add
        Me.cmdNew.Location = New System.Drawing.Point(705, 397)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(102, 37)
        Me.cmdNew.TabIndex = 41
        Me.cmdNew.Text = "New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.LMS_dbDataSet
        '
        'LMS_dbDataSet
        '
        Me.LMS_dbDataSet.DataSetName = "LMS_dbDataSet"
        Me.LMS_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.BooksLostandReplace1TableAdapter = Nothing
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.LogsActivityTableAdapter = Nothing
        Me.TableAdapterManager.LogsTimeInTableAdapter = Nothing
        Me.TableAdapterManager.LogsTimeOutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library_System.LMS_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.AddBooksBG3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 444)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.txtCopies)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtEdition)
        Me.Controls.Add(Me.cboStats)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.txtPubName)
        Me.Controls.Add(Me.cboCopyYear)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboBClass)
        Me.Controls.Add(Me.cboBCategory)
        Me.Controls.Add(Me.txtAuthor1)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.cboBSubj)
        Me.Controls.Add(Me.txtBName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Books"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMS_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBName As System.Windows.Forms.TextBox
    Friend WithEvents cboBSubj As System.Windows.Forms.ComboBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor1 As System.Windows.Forms.TextBox
    Friend WithEvents cboBCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cboBClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboCopyYear As System.Windows.Forms.ComboBox
    Friend WithEvents txtPubName As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents cboStats As System.Windows.Forms.ComboBox
    Friend WithEvents txtEdition As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents txtCopies As System.Windows.Forms.TextBox
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents LMS_dbDataSet As Library_System.LMS_dbDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As Library_System.LMS_dbDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As Library_System.LMS_dbDataSetTableAdapters.TableAdapterManager
End Class
