<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderForm))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PRODUCTNAME = New System.Windows.Forms.Label()
        Me.productprice = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.quantitynum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalamntbox = New System.Windows.Forms.TextBox()
        Me.PRODUCTIMG = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clientname = New System.Windows.Forms.TextBox()
        Me.clientaddress = New System.Windows.Forms.TextBox()
        Me.clientcontact = New System.Windows.Forms.TextBox()
        Me.clientemail = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ServcsPage = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PRODUCTIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(5, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "CLIENT NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(5, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "CONTACT # :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "EMAIL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(8, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ADDRESS:"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.PRODUCTNAME)
        Me.Panel1.Controls.Add(Me.productprice)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.quantitynum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.totalamntbox)
        Me.Panel1.Controls.Add(Me.PRODUCTIMG)
        Me.Panel1.Location = New System.Drawing.Point(668, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 321)
        Me.Panel1.TabIndex = 25
        '
        'PRODUCTNAME
        '
        Me.PRODUCTNAME.AutoSize = True
        Me.PRODUCTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCTNAME.ForeColor = System.Drawing.Color.White
        Me.PRODUCTNAME.Location = New System.Drawing.Point(29, 34)
        Me.PRODUCTNAME.Name = "PRODUCTNAME"
        Me.PRODUCTNAME.Size = New System.Drawing.Size(199, 24)
        Me.PRODUCTNAME.TabIndex = 28
        Me.PRODUCTNAME.Text = "PRODUCT/S NAME:"
        '
        'productprice
        '
        Me.productprice.BackColor = System.Drawing.Color.White
        Me.productprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productprice.Location = New System.Drawing.Point(150, 211)
        Me.productprice.Name = "productprice"
        Me.productprice.ReadOnly = True
        Me.productprice.Size = New System.Drawing.Size(131, 22)
        Me.productprice.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(29, 255)
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
        Me.Label2.Location = New System.Drawing.Point(29, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "PRICE:"
        '
        'quantitynum
        '
        Me.quantitynum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantitynum.Location = New System.Drawing.Point(150, 167)
        Me.quantitynum.Name = "quantitynum"
        Me.quantitynum.Size = New System.Drawing.Size(131, 22)
        Me.quantitynum.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "QUANTITY:"
        '
        'totalamntbox
        '
        Me.totalamntbox.BackColor = System.Drawing.Color.White
        Me.totalamntbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamntbox.Location = New System.Drawing.Point(150, 258)
        Me.totalamntbox.Name = "totalamntbox"
        Me.totalamntbox.ReadOnly = True
        Me.totalamntbox.Size = New System.Drawing.Size(131, 22)
        Me.totalamntbox.TabIndex = 41
        '
        'PRODUCTIMG
        '
        Me.PRODUCTIMG.Image = CType(resources.GetObject("PRODUCTIMG.Image"), System.Drawing.Image)
        Me.PRODUCTIMG.Location = New System.Drawing.Point(323, 12)
        Me.PRODUCTIMG.Name = "PRODUCTIMG"
        Me.PRODUCTIMG.Size = New System.Drawing.Size(312, 288)
        Me.PRODUCTIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PRODUCTIMG.TabIndex = 0
        Me.PRODUCTIMG.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(220, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 31)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "CUSTOMER INFO:"
        '
        'clientname
        '
        Me.clientname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientname.Location = New System.Drawing.Point(142, 59)
        Me.clientname.Name = "clientname"
        Me.clientname.Size = New System.Drawing.Size(488, 26)
        Me.clientname.TabIndex = 32
        '
        'clientaddress
        '
        Me.clientaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientaddress.Location = New System.Drawing.Point(142, 138)
        Me.clientaddress.Multiline = True
        Me.clientaddress.Name = "clientaddress"
        Me.clientaddress.Size = New System.Drawing.Size(488, 95)
        Me.clientaddress.TabIndex = 33
        '
        'clientcontact
        '
        Me.clientcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientcontact.Location = New System.Drawing.Point(142, 99)
        Me.clientcontact.Name = "clientcontact"
        Me.clientcontact.Size = New System.Drawing.Size(193, 26)
        Me.clientcontact.TabIndex = 34
        '
        'clientemail
        '
        Me.clientemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientemail.Location = New System.Drawing.Point(142, 250)
        Me.clientemail.Name = "clientemail"
        Me.clientemail.Size = New System.Drawing.Size(218, 26)
        Me.clientemail.TabIndex = 35
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(668, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 35)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1334, 518)
        Me.Panel2.TabIndex = 42
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(577, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 35)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.ServcsPage)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1334, 109)
        Me.Panel4.TabIndex = 51
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
        Me.ServcsPage.Size = New System.Drawing.Size(210, 31)
        Me.ServcsPage.TabIndex = 4
        Me.ServcsPage.Text = "ORDER FORM"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Firebrick
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.clientname)
        Me.Panel3.Controls.Add(Me.clientcontact)
        Me.Panel3.Controls.Add(Me.clientaddress)
        Me.Panel3.Controls.Add(Me.clientemail)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(11, 133)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(652, 321)
        Me.Panel3.TabIndex = 0
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(1334, 518)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PRODUCTIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents clientname As TextBox
    Friend WithEvents clientaddress As TextBox
    Friend WithEvents clientcontact As TextBox
    Friend WithEvents clientemail As TextBox
    Friend WithEvents quantitynum As TextBox
    Friend WithEvents productprice As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PRODUCTIMG As PictureBox
    Friend WithEvents PRODUCTNAME As Label
    Friend WithEvents totalamntbox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ServcsPage As Label
    Friend WithEvents Button2 As Button
End Class
