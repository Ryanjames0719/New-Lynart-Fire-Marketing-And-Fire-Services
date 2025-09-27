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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PRODUCTNAME = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Userlabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clientname = New System.Windows.Forms.TextBox()
        Me.clientaddress = New System.Windows.Forms.TextBox()
        Me.clientcontact = New System.Windows.Forms.TextBox()
        Me.clientemail = New System.Windows.Forms.TextBox()
        Me.quantitynum = New System.Windows.Forms.TextBox()
        Me.productprice = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totalamntbox = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PRODUCTIMG = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(510, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 19)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "LYNART MARKETING"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(-5, -1)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(43, 38)
        Me.btnMenu.TabIndex = 18
        Me.btnMenu.Text = "☰"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 22)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "CLIENT NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 22)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "CONTACT #:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(446, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 22)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "EMAIL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 22)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ADDRESS:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.PRODUCTNAME)
        Me.Panel1.Controls.Add(Me.PRODUCTIMG)
        Me.Panel1.Location = New System.Drawing.Point(52, 385)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 145)
        Me.Panel1.TabIndex = 25
        '
        'PRODUCTNAME
        '
        Me.PRODUCTNAME.AutoSize = True
        Me.PRODUCTNAME.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCTNAME.ForeColor = System.Drawing.Color.White
        Me.PRODUCTNAME.Location = New System.Drawing.Point(181, 66)
        Me.PRODUCTNAME.Name = "PRODUCTNAME"
        Me.PRODUCTNAME.Size = New System.Drawing.Size(156, 22)
        Me.PRODUCTNAME.TabIndex = 28
        Me.PRODUCTNAME.Text = "PRODUCT NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 547)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 22)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "QUANTITY:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 593)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 22)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "PRICE:"
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Firebrick
        Me.pnlMenu.Controls.Add(Me.Label19)
        Me.pnlMenu.Controls.Add(Me.Label14)
        Me.pnlMenu.Controls.Add(Me.Label12)
        Me.pnlMenu.Controls.Add(Me.Label13)
        Me.pnlMenu.Controls.Add(Me.Label15)
        Me.pnlMenu.Controls.Add(Me.Label16)
        Me.pnlMenu.Controls.Add(Me.Label17)
        Me.pnlMenu.Controls.Add(Me.Label18)
        Me.pnlMenu.Controls.Add(Me.Userlabel)
        Me.pnlMenu.Controls.Add(Me.Label9)
        Me.pnlMenu.Controls.Add(Me.PictureBox1)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(10, 679)
        Me.pnlMenu.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(38, 556)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 22)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "LOG-OUT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 368)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 25)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "WARRANTIES"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 281)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 25)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "MAINTENANCE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 25)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "SERVICES"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 25)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "PRODUCTS"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 419)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 25)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "SETTINGS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(29, 188)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 25)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "INVENTORY"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(28, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 25)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "HOME"
        '
        'Userlabel
        '
        Me.Userlabel.AutoSize = True
        Me.Userlabel.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlabel.Location = New System.Drawing.Point(114, 80)
        Me.Userlabel.Name = "Userlabel"
        Me.Userlabel.Size = New System.Drawing.Size(65, 25)
        Me.Userlabel.TabIndex = 13
        Me.Userlabel.Text = "USER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 22)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "LYNART MARKETING"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(333, 32)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "ORDER FORM FOR ""ITEM"""
        '
        'clientname
        '
        Me.clientname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientname.Location = New System.Drawing.Point(209, 143)
        Me.clientname.Name = "clientname"
        Me.clientname.Size = New System.Drawing.Size(507, 26)
        Me.clientname.TabIndex = 32
        '
        'clientaddress
        '
        Me.clientaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientaddress.Location = New System.Drawing.Point(146, 235)
        Me.clientaddress.Multiline = True
        Me.clientaddress.Name = "clientaddress"
        Me.clientaddress.Size = New System.Drawing.Size(570, 95)
        Me.clientaddress.TabIndex = 33
        '
        'clientcontact
        '
        Me.clientcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientcontact.Location = New System.Drawing.Point(209, 190)
        Me.clientcontact.Name = "clientcontact"
        Me.clientcontact.Size = New System.Drawing.Size(213, 26)
        Me.clientcontact.TabIndex = 34
        '
        'clientemail
        '
        Me.clientemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientemail.Location = New System.Drawing.Point(518, 190)
        Me.clientemail.Name = "clientemail"
        Me.clientemail.Size = New System.Drawing.Size(198, 26)
        Me.clientemail.TabIndex = 35
        '
        'quantitynum
        '
        Me.quantitynum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantitynum.Location = New System.Drawing.Point(174, 547)
        Me.quantitynum.Name = "quantitynum"
        Me.quantitynum.Size = New System.Drawing.Size(131, 22)
        Me.quantitynum.TabIndex = 36
        '
        'productprice
        '
        Me.productprice.BackColor = System.Drawing.Color.White
        Me.productprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productprice.Location = New System.Drawing.Point(174, 593)
        Me.productprice.Name = "productprice"
        Me.productprice.ReadOnly = True
        Me.productprice.Size = New System.Drawing.Size(131, 22)
        Me.productprice.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(329, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 44)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 22)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "ITEM ORDERED:"
        '
        'totalamntbox
        '
        Me.totalamntbox.BackColor = System.Drawing.Color.White
        Me.totalamntbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamntbox.Location = New System.Drawing.Point(477, 569)
        Me.totalamntbox.Name = "totalamntbox"
        Me.totalamntbox.ReadOnly = True
        Me.totalamntbox.Size = New System.Drawing.Size(131, 22)
        Me.totalamntbox.TabIndex = 41
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(351, 569)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 22)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "TOTAL:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PRODUCTIMG
        '
        Me.PRODUCTIMG.Image = CType(resources.GetObject("PRODUCTIMG.Image"), System.Drawing.Image)
        Me.PRODUCTIMG.Location = New System.Drawing.Point(12, 15)
        Me.PRODUCTIMG.Name = "PRODUCTIMG"
        Me.PRODUCTIMG.Size = New System.Drawing.Size(163, 117)
        Me.PRODUCTIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PRODUCTIMG.TabIndex = 0
        Me.PRODUCTIMG.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(685, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(767, 679)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.totalamntbox)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.productprice)
        Me.Controls.Add(Me.quantitynum)
        Me.Controls.Add(Me.clientemail)
        Me.Controls.Add(Me.clientcontact)
        Me.Controls.Add(Me.clientaddress)
        Me.Controls.Add(Me.clientname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderForm"
        Me.Text = "OrderForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnMenu As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents clientname As TextBox
    Friend WithEvents clientaddress As TextBox
    Friend WithEvents clientcontact As TextBox
    Friend WithEvents clientemail As TextBox
    Friend WithEvents quantitynum As TextBox
    Friend WithEvents productprice As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PRODUCTIMG As PictureBox
    Friend WithEvents PRODUCTNAME As Label
    Friend WithEvents Userlabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents totalamntbox As TextBox
    Friend WithEvents Label20 As Label
End Class
