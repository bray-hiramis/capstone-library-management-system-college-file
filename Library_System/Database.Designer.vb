<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Database))
        Me.RadioBackup = New System.Windows.Forms.RadioButton()
        Me.RadioRetrieve = New System.Windows.Forms.RadioButton()
        Me.txtVerifyPass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUserPass = New System.Windows.Forms.TextBox()
        Me.txtMode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioBackup
        '
        Me.RadioBackup.AutoSize = True
        Me.RadioBackup.BackColor = System.Drawing.Color.Transparent
        Me.RadioBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioBackup.Location = New System.Drawing.Point(14, 31)
        Me.RadioBackup.Name = "RadioBackup"
        Me.RadioBackup.Size = New System.Drawing.Size(143, 22)
        Me.RadioBackup.TabIndex = 2
        Me.RadioBackup.TabStop = True
        Me.RadioBackup.Text = "Backup Database"
        Me.RadioBackup.UseVisualStyleBackColor = False
        '
        'RadioRetrieve
        '
        Me.RadioRetrieve.AutoSize = True
        Me.RadioRetrieve.BackColor = System.Drawing.Color.Transparent
        Me.RadioRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioRetrieve.Location = New System.Drawing.Point(230, 31)
        Me.RadioRetrieve.Name = "RadioRetrieve"
        Me.RadioRetrieve.Size = New System.Drawing.Size(147, 22)
        Me.RadioRetrieve.TabIndex = 3
        Me.RadioRetrieve.TabStop = True
        Me.RadioRetrieve.Text = "Retrieve Database"
        Me.RadioRetrieve.UseVisualStyleBackColor = False
        '
        'txtVerifyPass
        '
        Me.txtVerifyPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifyPass.Location = New System.Drawing.Point(48, 137)
        Me.txtVerifyPass.Name = "txtVerifyPass"
        Me.txtVerifyPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVerifyPass.Size = New System.Drawing.Size(42, 22)
        Me.txtVerifyPass.TabIndex = 2
        Me.txtVerifyPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtVerifyPass.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(37, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(322, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.TabStop = False
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtUserPass
        '
        Me.txtUserPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPass.Location = New System.Drawing.Point(-4, 137)
        Me.txtUserPass.Name = "txtUserPass"
        Me.txtUserPass.Size = New System.Drawing.Size(20, 22)
        Me.txtUserPass.TabIndex = 4
        Me.txtUserPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUserPass.Visible = False
        '
        'txtMode
        '
        Me.txtMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMode.Location = New System.Drawing.Point(22, 137)
        Me.txtMode.Name = "txtMode"
        Me.txtMode.Size = New System.Drawing.Size(20, 22)
        Me.txtMode.TabIndex = 5
        Me.txtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMode.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioRetrieve)
        Me.GroupBox1.Controls.Add(Me.RadioBackup)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 65)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose an action"
        '
        'Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library_System.My.Resources.Resources.DatabaseBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(411, 134)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtMode)
        Me.Controls.Add(Me.txtUserPass)
        Me.Controls.Add(Me.txtVerifyPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioBackup As System.Windows.Forms.RadioButton
    Friend WithEvents RadioRetrieve As System.Windows.Forms.RadioButton
    Friend WithEvents txtVerifyPass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtUserPass As System.Windows.Forms.TextBox
    Friend WithEvents txtMode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
