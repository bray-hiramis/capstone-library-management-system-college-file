<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateBooks))
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.cboStats = New System.Windows.Forms.ComboBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtPubName = New System.Windows.Forms.TextBox()
        Me.cboCopyYear = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboBClass = New System.Windows.Forms.ComboBox()
        Me.cboBCategory = New System.Windows.Forms.ComboBox()
        Me.txtAuthor1 = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.cboBSubj = New System.Windows.Forms.ComboBox()
        Me.txtBName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdUpdateBook = New System.Windows.Forms.Button()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMS_dbDataSet1 = New Library_System.LMS_dbDataSet1()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.BooksTableAdapter = New Library_System.LMS_dbDataSet1TableAdapters.BooksTableAdapter()
        Me.TableAdapterManager = New Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMS_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCopies
        '
        Me.txtCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopies.Location = New System.Drawing.Point(546, 217)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(141, 22)
        Me.txtCopies.TabIndex = 71
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.Location = New System.Drawing.Point(546, 365)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(261, 22)
        Me.txtSupplier.TabIndex = 70
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(547, 328)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(140, 22)
        Me.txtPrice.TabIndex = 69
        '
        'txtEdition
        '
        Me.txtEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdition.Location = New System.Drawing.Point(547, 291)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(260, 22)
        Me.txtEdition.TabIndex = 68
        '
        'cboStats
        '
        Me.cboStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStats.FormattingEnabled = True
        Me.cboStats.Items.AddRange(New Object() {"New", "Old"})
        Me.cboStats.Location = New System.Drawing.Point(547, 252)
        Me.cboStats.Name = "cboStats"
        Me.cboStats.Size = New System.Drawing.Size(140, 24)
        Me.cboStats.TabIndex = 67
        '
        'txtISBN
        '
        Me.txtISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(547, 180)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(239, 22)
        Me.txtISBN.TabIndex = 66
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(547, 143)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(239, 22)
        Me.txtBarcode.TabIndex = 65
        '
        'txtPubName
        '
        Me.txtPubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPubName.Location = New System.Drawing.Point(588, 67)
        Me.txtPubName.Name = "txtPubName"
        Me.txtPubName.Size = New System.Drawing.Size(219, 22)
        Me.txtPubName.TabIndex = 64
        '
        'cboCopyYear
        '
        Me.cboCopyYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCopyYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCopyYear.FormattingEnabled = True
        Me.cboCopyYear.Items.AddRange(New Object() {"2026", "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980"})
        Me.cboCopyYear.Location = New System.Drawing.Point(588, 104)
        Me.cboCopyYear.Name = "cboCopyYear"
        Me.cboCopyYear.Size = New System.Drawing.Size(158, 24)
        Me.cboCopyYear.TabIndex = 63
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(476, 370)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 17)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Supplier:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(476, 333)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 17)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Price:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(476, 296)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 17)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Edition:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(476, 259)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Status:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(476, 222)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 17)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Copies:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(476, 185)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 17)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "ISBN:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(476, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 17)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Barcode:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(476, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 17)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Copyright Year:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(476, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 17)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Publisher Name:"
        '
        'cboBClass
        '
        Me.cboBClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBClass.FormattingEnabled = True
        Me.cboBClass.Items.AddRange(New Object() {"Arts and Recreation", "Computer Science", "History, Geography and Biography", "Languange", "Literature", "Philosophy and Psychology", "Religion", "Science"})
        Me.cboBClass.Location = New System.Drawing.Point(130, 371)
        Me.cboBClass.Name = "cboBClass"
        Me.cboBClass.Size = New System.Drawing.Size(303, 24)
        Me.cboBClass.TabIndex = 53
        '
        'cboBCategory
        '
        Me.cboBCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBCategory.FormattingEnabled = True
        Me.cboBCategory.Items.AddRange(New Object() {"Charts", "Clippings", "Dissertation", "Feasibility/Project/Research Study", "Journals", "Maps", "Pamphlets", "Referrence", "Serials Bound", "Serials Unbound", "Term Paper", "Thesis"})
        Me.cboBCategory.Location = New System.Drawing.Point(130, 336)
        Me.cboBCategory.Name = "cboBCategory"
        Me.cboBCategory.Size = New System.Drawing.Size(257, 24)
        Me.cboBCategory.TabIndex = 52
        '
        'txtAuthor1
        '
        Me.txtAuthor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor1.Location = New System.Drawing.Point(130, 233)
        Me.txtAuthor1.Multiline = True
        Me.txtAuthor1.Name = "txtAuthor1"
        Me.txtAuthor1.Size = New System.Drawing.Size(341, 92)
        Me.txtAuthor1.TabIndex = 51
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(130, 198)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(272, 22)
        Me.txtAuthor.TabIndex = 50
        '
        'cboBSubj
        '
        Me.cboBSubj.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboBSubj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBSubj.FormattingEnabled = True
        Me.cboBSubj.Items.AddRange(New Object() {"Computer Fundamentals", "Computer Programming", "English", "Filipino", "History", "Mathematics", "Psychology", "Science", "Values"})
        Me.cboBSubj.Location = New System.Drawing.Point(115, 102)
        Me.cboBSubj.Name = "cboBSubj"
        Me.cboBSubj.Size = New System.Drawing.Size(203, 24)
        Me.cboBSubj.Sorted = True
        Me.cboBSubj.TabIndex = 49
        '
        'txtBName
        '
        Me.txtBName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBName.Location = New System.Drawing.Point(115, 138)
        Me.txtBName.Multiline = True
        Me.txtBName.Name = "txtBName"
        Me.txtBName.Size = New System.Drawing.Size(356, 48)
        Me.txtBName.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Book Class:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Book Category:"
        '
        'txtBID
        '
        Me.txtBID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBID.Location = New System.Drawing.Point(115, 69)
        Me.txtBID.Name = "txtBID"
        Me.txtBID.ReadOnly = True
        Me.txtBID.Size = New System.Drawing.Size(112, 22)
        Me.txtBID.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Joint Authors:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Author:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Book Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Book Subject:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "BookID:"
        '
        'cmdUpdateBook
        '
        Me.cmdUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUpdateBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateBook.Image = Global.Library_System.My.Resources.Resources.application_form_edit
        Me.cmdUpdateBook.Location = New System.Drawing.Point(705, 393)
        Me.cmdUpdateBook.Name = "cmdUpdateBook"
        Me.cmdUpdateBook.Size = New System.Drawing.Size(102, 37)
        Me.cmdUpdateBook.TabIndex = 74
        Me.cmdUpdateBook.Text = "Update"
        Me.cmdUpdateBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdUpdateBook.UseVisualStyleBackColor = True
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
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Image = Global.Library_System.My.Resources.Resources.arrow_refresh
        Me.cmdClear.Location = New System.Drawing.Point(597, 392)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(102, 37)
        Me.cmdClear.TabIndex = 77
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 33)
        Me.Panel1.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(341, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Books"
        '
        'UpdateBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.UpdateBG
        Me.ClientSize = New System.Drawing.Size(819, 444)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdUpdateBook)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Books"
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMS_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCopies As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtEdition As System.Windows.Forms.TextBox
    Friend WithEvents cboStats As System.Windows.Forms.ComboBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtPubName As System.Windows.Forms.TextBox
    Friend WithEvents cboCopyYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboBClass As System.Windows.Forms.ComboBox
    Friend WithEvents cboBCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtAuthor1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents cboBSubj As System.Windows.Forms.ComboBox
    Friend WithEvents txtBName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdUpdateBook As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents JointAuthor2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JointAuthor3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LMS_dbDataSet1 As Library_System.LMS_dbDataSet1
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As Library_System.LMS_dbDataSet1TableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As Library_System.LMS_dbDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
