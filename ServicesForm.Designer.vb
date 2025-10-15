<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServicesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServicesForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.refillitem = New System.Windows.Forms.Label()
        Me.kilogramstxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PRODUCTNAME = New System.Windows.Forms.Label()
        Me.refillprice = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.quantitynum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalamntbox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.clientaddress = New System.Windows.Forms.TextBox()
        Me.custemail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.contactnum = New System.Windows.Forms.TextBox()
        Me.clientname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ServcsPage = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, -7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(14, 770)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1334, 518)
        Me.Panel2.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.refillitem)
        Me.Panel4.Controls.Add(Me.kilogramstxt)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.PRODUCTNAME)
        Me.Panel4.Controls.Add(Me.refillprice)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.quantitynum)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.totalamntbox)
        Me.Panel4.Location = New System.Drawing.Point(704, 123)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(605, 332)
        Me.Panel4.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(25, 179)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(145, 24)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "REFILL DATE:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 180)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(238, 22)
        Me.DateTimePicker1.TabIndex = 45
        '
        'refillitem
        '
        Me.refillitem.AutoSize = True
        Me.refillitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refillitem.ForeColor = System.Drawing.Color.White
        Me.refillitem.Location = New System.Drawing.Point(26, 78)
        Me.refillitem.Name = "refillitem"
        Me.refillitem.Size = New System.Drawing.Size(144, 24)
        Me.refillitem.TabIndex = 44
        Me.refillitem.Text = "ITEM/S NAME"
        '
        'kilogramstxt
        '
        Me.kilogramstxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilogramstxt.Location = New System.Drawing.Point(436, 223)
        Me.kilogramstxt.Name = "kilogramstxt"
        Me.kilogramstxt.Size = New System.Drawing.Size(131, 22)
        Me.kilogramstxt.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(329, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 24)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "KG:"
        '
        'PRODUCTNAME
        '
        Me.PRODUCTNAME.AutoSize = True
        Me.PRODUCTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCTNAME.ForeColor = System.Drawing.Color.White
        Me.PRODUCTNAME.Location = New System.Drawing.Point(26, 35)
        Me.PRODUCTNAME.Name = "PRODUCTNAME"
        Me.PRODUCTNAME.Size = New System.Drawing.Size(305, 24)
        Me.PRODUCTNAME.TabIndex = 28
        Me.PRODUCTNAME.Text = "ITEM/S NAME AND CAPACITY:"
        '
        'refillprice
        '
        Me.refillprice.BackColor = System.Drawing.Color.White
        Me.refillprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refillprice.Location = New System.Drawing.Point(146, 267)
        Me.refillprice.Name = "refillprice"
        Me.refillprice.ReadOnly = True
        Me.refillprice.Size = New System.Drawing.Size(131, 22)
        Me.refillprice.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(327, 267)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 24)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "TOTAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(22, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "PRICE:"
        '
        'quantitynum
        '
        Me.quantitynum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantitynum.Location = New System.Drawing.Point(146, 223)
        Me.quantitynum.Name = "quantitynum"
        Me.quantitynum.Size = New System.Drawing.Size(131, 22)
        Me.quantitynum.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(22, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "QUANTITY:"
        '
        'totalamntbox
        '
        Me.totalamntbox.BackColor = System.Drawing.Color.White
        Me.totalamntbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamntbox.Location = New System.Drawing.Point(436, 270)
        Me.totalamntbox.Name = "totalamntbox"
        Me.totalamntbox.ReadOnly = True
        Me.totalamntbox.Size = New System.Drawing.Size(131, 22)
        Me.totalamntbox.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Firebrick
        Me.Panel3.Controls.Add(Me.clientaddress)
        Me.Panel3.Controls.Add(Me.custemail)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.contactnum)
        Me.Panel3.Controls.Add(Me.clientname)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(27, 123)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(672, 332)
        Me.Panel3.TabIndex = 0
        '
        'clientaddress
        '
        Me.clientaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientaddress.Location = New System.Drawing.Point(157, 161)
        Me.clientaddress.Multiline = True
        Me.clientaddress.Name = "clientaddress"
        Me.clientaddress.Size = New System.Drawing.Size(481, 95)
        Me.clientaddress.TabIndex = 53
        '
        'custemail
        '
        Me.custemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custemail.Location = New System.Drawing.Point(157, 274)
        Me.custemail.Name = "custemail"
        Me.custemail.Size = New System.Drawing.Size(218, 26)
        Me.custemail.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(22, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "EMAIL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(22, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "ADDRESS:"
        '
        'contactnum
        '
        Me.contactnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactnum.Location = New System.Drawing.Point(157, 106)
        Me.contactnum.Name = "contactnum"
        Me.contactnum.Size = New System.Drawing.Size(218, 26)
        Me.contactnum.TabIndex = 49
        '
        'clientname
        '
        Me.clientname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientname.Location = New System.Drawing.Point(157, 67)
        Me.clientname.Name = "clientname"
        Me.clientname.Size = New System.Drawing.Size(481, 26)
        Me.clientname.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(20, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "CONTACT #:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(20, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 20)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "CLIENT NAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(142, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 31)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "CUSTOMER INFO"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Firebrick
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.ServcsPage)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1334, 109)
        Me.Panel5.TabIndex = 54
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Firebrick
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(986, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(242, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "LYNART MARKETING"
        '
        'ServcsPage
        '
        Me.ServcsPage.AutoSize = True
        Me.ServcsPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServcsPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ServcsPage.Location = New System.Drawing.Point(32, 31)
        Me.ServcsPage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ServcsPage.Name = "ServcsPage"
        Me.ServcsPage.Size = New System.Drawing.Size(352, 31)
        Me.ServcsPage.TabIndex = 4
        Me.ServcsPage.Text = "REFILL REQUEST FORM"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(604, 471)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 35)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(695, 471)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 35)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "SUBMIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ServicesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(1334, 518)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ServicesForm"
        Me.Text = "ServiesForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents contactnum As TextBox
    Friend WithEvents clientname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents custemail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents clientaddress As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents kilogramstxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PRODUCTNAME As Label
    Friend WithEvents refillprice As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents quantitynum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents totalamntbox As TextBox
    Friend WithEvents refillitem As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ServcsPage As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
