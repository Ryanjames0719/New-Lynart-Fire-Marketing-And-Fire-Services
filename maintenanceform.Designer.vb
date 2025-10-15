<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class maintenanceform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maintenanceform))
        Me.clientemail = New System.Windows.Forms.TextBox()
        Me.clientcontact = New System.Windows.Forms.TextBox()
        Me.clientaddress = New System.Windows.Forms.TextBox()
        Me.clientname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.partname = New System.Windows.Forms.Label()
        Me.partpic = New System.Windows.Forms.PictureBox()
        Me.cmbPriority = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.quantitynum = New System.Windows.Forms.TextBox()
        Me.totalamntbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.partsprice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.repairman = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ServcsPage = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.partpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clientemail
        '
        Me.clientemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientemail.Location = New System.Drawing.Point(149, 245)
        Me.clientemail.Name = "clientemail"
        Me.clientemail.Size = New System.Drawing.Size(248, 26)
        Me.clientemail.TabIndex = 48
        '
        'clientcontact
        '
        Me.clientcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientcontact.Location = New System.Drawing.Point(149, 95)
        Me.clientcontact.Name = "clientcontact"
        Me.clientcontact.Size = New System.Drawing.Size(248, 26)
        Me.clientcontact.TabIndex = 47
        '
        'clientaddress
        '
        Me.clientaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientaddress.Location = New System.Drawing.Point(151, 135)
        Me.clientaddress.Multiline = True
        Me.clientaddress.Name = "clientaddress"
        Me.clientaddress.Size = New System.Drawing.Size(497, 95)
        Me.clientaddress.TabIndex = 46
        '
        'clientname
        '
        Me.clientname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientname.Location = New System.Drawing.Point(149, 56)
        Me.clientname.Name = "clientname"
        Me.clientname.Size = New System.Drawing.Size(499, 26)
        Me.clientname.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(127, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 31)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "CUSTOMER INFO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "ADDRESS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "EMAIL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "CONTACT #:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(12, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 20)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "CLIENT NAME:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.cmbPriority)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.repairman)
        Me.Panel1.Controls.Add(Me.partname)
        Me.Panel1.Controls.Add(Me.partpic)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.quantitynum)
        Me.Panel1.Controls.Add(Me.totalamntbox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.partsprice)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(695, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 296)
        Me.Panel1.TabIndex = 50
        '
        'partname
        '
        Me.partname.AutoSize = True
        Me.partname.BackColor = System.Drawing.Color.Firebrick
        Me.partname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partname.ForeColor = System.Drawing.Color.White
        Me.partname.Location = New System.Drawing.Point(34, 58)
        Me.partname.Name = "partname"
        Me.partname.Size = New System.Drawing.Size(149, 24)
        Me.partname.TabIndex = 52
        Me.partname.Text = "PARTS NAME:"
        '
        'partpic
        '
        Me.partpic.Image = CType(resources.GetObject("partpic.Image"), System.Drawing.Image)
        Me.partpic.Location = New System.Drawing.Point(415, 31)
        Me.partpic.Name = "partpic"
        Me.partpic.Size = New System.Drawing.Size(160, 159)
        Me.partpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partpic.TabIndex = 0
        Me.partpic.TabStop = False
        '
        'cmbPriority
        '
        Me.cmbPriority.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPriority.FormattingEnabled = True
        Me.cmbPriority.Location = New System.Drawing.Point(213, 247)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Size = New System.Drawing.Size(160, 28)
        Me.cmbPriority.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(34, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "QUANTITY:"
        '
        'quantitynum
        '
        Me.quantitynum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantitynum.Location = New System.Drawing.Point(213, 126)
        Me.quantitynum.Name = "quantitynum"
        Me.quantitynum.Size = New System.Drawing.Size(140, 22)
        Me.quantitynum.TabIndex = 53
        '
        'totalamntbox
        '
        Me.totalamntbox.BackColor = System.Drawing.Color.White
        Me.totalamntbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamntbox.Location = New System.Drawing.Point(213, 212)
        Me.totalamntbox.Name = "totalamntbox"
        Me.totalamntbox.Size = New System.Drawing.Size(140, 22)
        Me.totalamntbox.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(34, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "PRICE:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(34, 209)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 24)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "TOTAL:"
        '
        'partsprice
        '
        Me.partsprice.BackColor = System.Drawing.Color.White
        Me.partsprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partsprice.Location = New System.Drawing.Point(213, 168)
        Me.partsprice.Name = "partsprice"
        Me.partsprice.Size = New System.Drawing.Size(140, 22)
        Me.partsprice.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(340, 608)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 38)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1334, 518)
        Me.Panel2.TabIndex = 62
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Firebrick
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.clientemail)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.clientcontact)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.clientaddress)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.clientname)
        Me.Panel3.Location = New System.Drawing.Point(11, 132)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(679, 296)
        Me.Panel3.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(34, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 24)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "REQUEST TYPE:"
        '
        'repairman
        '
        Me.repairman.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repairman.FormattingEnabled = True
        Me.repairman.Location = New System.Drawing.Point(401, 245)
        Me.repairman.Name = "repairman"
        Me.repairman.Size = New System.Drawing.Size(189, 28)
        Me.repairman.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(397, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 24)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "REPAIRMAN:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Firebrick
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.ServcsPage)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1334, 109)
        Me.Panel5.TabIndex = 60
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1234, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Firebrick
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(986, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "LYNART MARKETING"
        '
        'ServcsPage
        '
        Me.ServcsPage.AutoSize = True
        Me.ServcsPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServcsPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ServcsPage.Location = New System.Drawing.Point(32, 31)
        Me.ServcsPage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ServcsPage.Name = "ServcsPage"
        Me.ServcsPage.Size = New System.Drawing.Size(572, 31)
        Me.ServcsPage.TabIndex = 4
        Me.ServcsPage.Text = "PARTS REPLACEMENT REQUEST FORM"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(604, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 35)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(695, 446)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 35)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "SUBMIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'maintenanceform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1334, 518)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "maintenanceform"
        Me.Text = "maintenanceform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.partpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clientemail As TextBox
    Friend WithEvents clientcontact As TextBox
    Friend WithEvents clientaddress As TextBox
    Friend WithEvents clientname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents totalamntbox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents partsprice As TextBox
    Friend WithEvents quantitynum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbPriority As ComboBox
    Friend WithEvents partpic As PictureBox
    Friend WithEvents partname As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents repairman As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ServcsPage As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
