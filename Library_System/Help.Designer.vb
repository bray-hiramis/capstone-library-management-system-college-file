<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdLib = New System.Windows.Forms.Button()
        Me.cmdLostRep = New System.Windows.Forms.Button()
        Me.cmdBReturn = New System.Windows.Forms.Button()
        Me.cmdBorrow = New System.Windows.Forms.Button()
        Me.cmdInvent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmdLib)
        Me.Panel1.Controls.Add(Me.cmdLostRep)
        Me.Panel1.Controls.Add(Me.cmdBReturn)
        Me.Panel1.Controls.Add(Me.cmdBorrow)
        Me.Panel1.Controls.Add(Me.cmdInvent)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 449)
        Me.Panel1.TabIndex = 0
        '
        'cmdLib
        '
        Me.cmdLib.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLib.Enabled = False
        Me.cmdLib.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLib.Image = CType(resources.GetObject("cmdLib.Image"), System.Drawing.Image)
        Me.cmdLib.Location = New System.Drawing.Point(12, 279)
        Me.cmdLib.Name = "cmdLib"
        Me.cmdLib.Size = New System.Drawing.Size(201, 51)
        Me.cmdLib.TabIndex = 12
        Me.cmdLib.Text = "Librarian Information"
        Me.cmdLib.UseVisualStyleBackColor = True
        '
        'cmdLostRep
        '
        Me.cmdLostRep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLostRep.Enabled = False
        Me.cmdLostRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLostRep.Image = CType(resources.GetObject("cmdLostRep.Image"), System.Drawing.Image)
        Me.cmdLostRep.Location = New System.Drawing.Point(12, 214)
        Me.cmdLostRep.Name = "cmdLostRep"
        Me.cmdLostRep.Size = New System.Drawing.Size(201, 51)
        Me.cmdLostRep.TabIndex = 11
        Me.cmdLostRep.Text = "Book Lost and Replacement"
        Me.cmdLostRep.UseVisualStyleBackColor = True
        '
        'cmdBReturn
        '
        Me.cmdBReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBReturn.Enabled = False
        Me.cmdBReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBReturn.Image = CType(resources.GetObject("cmdBReturn.Image"), System.Drawing.Image)
        Me.cmdBReturn.Location = New System.Drawing.Point(12, 149)
        Me.cmdBReturn.Name = "cmdBReturn"
        Me.cmdBReturn.Size = New System.Drawing.Size(201, 51)
        Me.cmdBReturn.TabIndex = 10
        Me.cmdBReturn.Text = "Book Return"
        Me.cmdBReturn.UseVisualStyleBackColor = True
        '
        'cmdBorrow
        '
        Me.cmdBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBorrow.Enabled = False
        Me.cmdBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrow.Image = CType(resources.GetObject("cmdBorrow.Image"), System.Drawing.Image)
        Me.cmdBorrow.Location = New System.Drawing.Point(12, 84)
        Me.cmdBorrow.Name = "cmdBorrow"
        Me.cmdBorrow.Size = New System.Drawing.Size(201, 51)
        Me.cmdBorrow.TabIndex = 9
        Me.cmdBorrow.Text = "Book Borrow"
        Me.cmdBorrow.UseVisualStyleBackColor = True
        '
        'cmdInvent
        '
        Me.cmdInvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdInvent.Enabled = False
        Me.cmdInvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInvent.Image = Global.Library_System.My.Resources.Resources.ButtonBG
        Me.cmdInvent.Location = New System.Drawing.Point(12, 19)
        Me.cmdInvent.Name = "cmdInvent"
        Me.cmdInvent.Size = New System.Drawing.Size(201, 51)
        Me.cmdInvent.TabIndex = 8
        Me.cmdInvent.Text = "Book's Inventory"
        Me.cmdInvent.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Used to open the Book's Inventory  and view the recods"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Used to make a transaction on issuing books."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Used to record the return books"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(234, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Used to report a Lost book and its replacement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(265, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Let's you to view the information of the Librarian"
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.Library_System.My.Resources.Resources.application_delete
        Me.Button5.Location = New System.Drawing.Point(328, 346)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 41)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Delete"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Library_System.My.Resources.Resources.application_form_edit
        Me.Button1.Location = New System.Drawing.Point(12, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 41)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Update"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Library_System.My.Resources.Resources.add
        Me.Button2.Location = New System.Drawing.Point(12, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 41)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Add books"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Used to add a new books"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(102, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Used to update the current records"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Used to delete the current records"
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(904, 473)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Help"
        Me.Text = "Help"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdLib As System.Windows.Forms.Button
    Friend WithEvents cmdLostRep As System.Windows.Forms.Button
    Friend WithEvents cmdBReturn As System.Windows.Forms.Button
    Friend WithEvents cmdBorrow As System.Windows.Forms.Button
    Friend WithEvents cmdInvent As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
