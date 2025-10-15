<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.passbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.userbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(566, 370)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(146, 41)
        Me.loginbtn.TabIndex = 24
        Me.loginbtn.Text = "LOG IN"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(589, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "PASSWORD"
        '
        'passbox
        '
        Me.passbox.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.passbox.Location = New System.Drawing.Point(463, 283)
        Me.passbox.Name = "passbox"
        Me.passbox.Size = New System.Drawing.Size(354, 30)
        Me.passbox.TabIndex = 20
        Me.passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passbox.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(588, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "USERNAME"
        '
        'userbox
        '
        Me.userbox.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbox.Location = New System.Drawing.Point(463, 180)
        Me.userbox.Name = "userbox"
        Me.userbox.Size = New System.Drawing.Size(354, 30)
        Me.userbox.TabIndex = 18
        Me.userbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "LYNART MARKETING"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(815, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(544, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 66)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "LOGIN "
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(823, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 29)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "👁"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(431, 436)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.loginbtn)
        Me.Panel2.Controls.Add(Me.userbox)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.passbox)
        Me.Panel2.Location = New System.Drawing.Point(-3, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 436)
        Me.Panel2.TabIndex = 28
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(893, 437)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents passbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents userbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
