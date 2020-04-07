<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tel = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.btn_aj = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cin = New System.Windows.Forms.TextBox()
        Me.adr = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adr_1 = New System.Windows.Forms.TextBox()
        Me.tel_1 = New System.Windows.Forms.TextBox()
        Me.lname_1 = New System.Windows.Forms.TextBox()
        Me.suppp = New System.Windows.Forms.Button()
        Me.modd = New System.Windows.Forms.Button()
        Me.fname_1 = New System.Windows.Forms.TextBox()
        Me.find_me = New System.Windows.Forms.Button()
        Me.cin_1 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.find_it = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_it = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 117)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(584, 333)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(576, 298)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clients"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.tel)
        Me.TabPage2.Controls.Add(Me.lname)
        Me.TabPage2.Controls.Add(Me.fname)
        Me.TabPage2.Controls.Add(Me.btn_aj)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cin)
        Me.TabPage2.Controls.Add(Me.adr)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(576, 298)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ajouter un client"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(96, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 22)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Adresse"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(96, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Telephone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(96, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "First Name"
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(263, 166)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(237, 26)
        Me.tel.TabIndex = 7
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(263, 126)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(237, 26)
        Me.lname.TabIndex = 6
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(263, 84)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(237, 26)
        Me.fname.TabIndex = 5
        '
        'btn_aj
        '
        Me.btn_aj.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_aj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aj.ForeColor = System.Drawing.Color.White
        Me.btn_aj.Location = New System.Drawing.Point(263, 244)
        Me.btn_aj.Name = "btn_aj"
        Me.btn_aj.Size = New System.Drawing.Size(237, 39)
        Me.btn_aj.TabIndex = 4
        Me.btn_aj.Text = "Ajouter"
        Me.btn_aj.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CIN"
        '
        'cin
        '
        Me.cin.Location = New System.Drawing.Point(263, 37)
        Me.cin.Name = "cin"
        Me.cin.Size = New System.Drawing.Size(237, 26)
        Me.cin.TabIndex = 1
        '
        'adr
        '
        Me.adr.Location = New System.Drawing.Point(263, 204)
        Me.adr.Name = "adr"
        Me.adr.Size = New System.Drawing.Size(237, 26)
        Me.adr.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.adr_1)
        Me.TabPage3.Controls.Add(Me.tel_1)
        Me.TabPage3.Controls.Add(Me.lname_1)
        Me.TabPage3.Controls.Add(Me.suppp)
        Me.TabPage3.Controls.Add(Me.modd)
        Me.TabPage3.Controls.Add(Me.fname_1)
        Me.TabPage3.Controls.Add(Me.find_me)
        Me.TabPage3.Controls.Add(Me.cin_1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 31)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(576, 298)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Modifier/Supprimer un client"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(81, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 22)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Adresse"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(81, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 22)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Telephone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CIN"
        '
        'adr_1
        '
        Me.adr_1.Location = New System.Drawing.Point(218, 200)
        Me.adr_1.Name = "adr_1"
        Me.adr_1.Size = New System.Drawing.Size(223, 26)
        Me.adr_1.TabIndex = 12
        '
        'tel_1
        '
        Me.tel_1.Location = New System.Drawing.Point(218, 152)
        Me.tel_1.Name = "tel_1"
        Me.tel_1.Size = New System.Drawing.Size(223, 26)
        Me.tel_1.TabIndex = 11
        '
        'lname_1
        '
        Me.lname_1.Location = New System.Drawing.Point(218, 110)
        Me.lname_1.Name = "lname_1"
        Me.lname_1.Size = New System.Drawing.Size(223, 26)
        Me.lname_1.TabIndex = 10
        '
        'suppp
        '
        Me.suppp.BackColor = System.Drawing.Color.Red
        Me.suppp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suppp.ForeColor = System.Drawing.Color.White
        Me.suppp.Location = New System.Drawing.Point(362, 242)
        Me.suppp.Name = "suppp"
        Me.suppp.Size = New System.Drawing.Size(139, 35)
        Me.suppp.TabIndex = 9
        Me.suppp.Text = "Supprimer"
        Me.suppp.UseVisualStyleBackColor = False
        '
        'modd
        '
        Me.modd.BackColor = System.Drawing.Color.LimeGreen
        Me.modd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modd.ForeColor = System.Drawing.Color.White
        Me.modd.Location = New System.Drawing.Point(131, 242)
        Me.modd.Name = "modd"
        Me.modd.Size = New System.Drawing.Size(138, 35)
        Me.modd.TabIndex = 7
        Me.modd.Text = "Modifier"
        Me.modd.UseVisualStyleBackColor = False
        '
        'fname_1
        '
        Me.fname_1.Location = New System.Drawing.Point(218, 66)
        Me.fname_1.Name = "fname_1"
        Me.fname_1.Size = New System.Drawing.Size(223, 26)
        Me.fname_1.TabIndex = 4
        '
        'find_me
        '
        Me.find_me.BackColor = System.Drawing.Color.DodgerBlue
        Me.find_me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.find_me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.find_me.ForeColor = System.Drawing.Color.White
        Me.find_me.Location = New System.Drawing.Point(484, 22)
        Me.find_me.Name = "find_me"
        Me.find_me.Size = New System.Drawing.Size(75, 26)
        Me.find_me.TabIndex = 2
        Me.find_me.Text = "Find"
        Me.find_me.UseVisualStyleBackColor = False
        '
        'cin_1
        '
        Me.cin_1.Location = New System.Drawing.Point(218, 22)
        Me.cin_1.Name = "cin_1"
        Me.cin_1.Size = New System.Drawing.Size(223, 26)
        Me.cin_1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.Controls.Add(Me.find_it)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.id_it)
        Me.TabPage4.Location = New System.Drawing.Point(4, 31)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(576, 298)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Rentabilité d'un client"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(58, 133)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(471, 150)
        Me.DataGridView2.TabIndex = 3
        '
        'find_it
        '
        Me.find_it.BackColor = System.Drawing.Color.DodgerBlue
        Me.find_it.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.find_it.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.find_it.ForeColor = System.Drawing.Color.White
        Me.find_it.Location = New System.Drawing.Point(394, 63)
        Me.find_it.Name = "find_it"
        Me.find_it.Size = New System.Drawing.Size(135, 26)
        Me.find_it.TabIndex = 2
        Me.find_it.Text = "Find"
        Me.find_it.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CIN"
        '
        'id_it
        '
        Me.id_it.Location = New System.Drawing.Point(177, 63)
        Me.id_it.Name = "id_it"
        Me.id_it.Size = New System.Drawing.Size(183, 26)
        Me.id_it.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(15, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 75)
        Me.Panel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(488, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 75)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(132, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Label7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(583, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "IZI RENT- Clients"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_aj As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cin As TextBox
    Friend WithEvents adr As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents suppp As Button
    Friend WithEvents modd As Button
    Friend WithEvents fname_1 As TextBox
    Friend WithEvents find_me As Button
    Friend WithEvents cin_1 As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents find_it As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents id_it As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tel As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents adr_1 As TextBox
    Friend WithEvents tel_1 As TextBox
    Friend WithEvents lname_1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
