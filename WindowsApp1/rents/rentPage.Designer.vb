<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rentPage))
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dateRent = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nbjRent = New System.Windows.Forms.TextBox()
        Me.idRent = New System.Windows.Forms.TextBox()
        Me.insertRent = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cinRent = New System.Windows.Forms.TextBox()
        Me.prixRent = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.trouver2 = New System.Windows.Forms.Button()
        Me.dateRentUD = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.prixRentUD = New System.Windows.Forms.TextBox()
        Me.nbjRentUD = New System.Windows.Forms.TextBox()
        Me.deleteRent = New System.Windows.Forms.Button()
        Me.updateRent = New System.Windows.Forms.Button()
        Me.idRentUD = New System.Windows.Forms.TextBox()
        Me.trouver1 = New System.Windows.Forms.Button()
        Me.cinRentUD = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dateRentR = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TrouverRent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.www = New System.Windows.Forms.Label()
        Me.retour = New System.Windows.Forms.Button()
        Me.TabControl3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Controls.Add(Me.TabPage4)
        Me.TabControl3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(0, 120)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(630, 333)
        Me.TabControl3.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(622, 298)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Location"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(585, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dateRent)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.nbjRent)
        Me.TabPage2.Controls.Add(Me.idRent)
        Me.TabPage2.Controls.Add(Me.insertRent)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cinRent)
        Me.TabPage2.Controls.Add(Me.prixRent)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(622, 298)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ajouter une location"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dateRent
        '
        Me.dateRent.Location = New System.Drawing.Point(210, 128)
        Me.dateRent.Name = "dateRent"
        Me.dateRent.Size = New System.Drawing.Size(281, 26)
        Me.dateRent.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(69, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 22)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Prix par jour"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nombre de jour"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(69, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Date Location"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ID Voiture"
        '
        'nbjRent
        '
        Me.nbjRent.Location = New System.Drawing.Point(210, 166)
        Me.nbjRent.Name = "nbjRent"
        Me.nbjRent.Size = New System.Drawing.Size(281, 26)
        Me.nbjRent.TabIndex = 7
        '
        'idRent
        '
        Me.idRent.Location = New System.Drawing.Point(210, 87)
        Me.idRent.Name = "idRent"
        Me.idRent.Size = New System.Drawing.Size(281, 26)
        Me.idRent.TabIndex = 5
        '
        'insertRent
        '
        Me.insertRent.BackColor = System.Drawing.Color.LimeGreen
        Me.insertRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.insertRent.ForeColor = System.Drawing.Color.White
        Me.insertRent.Location = New System.Drawing.Point(210, 248)
        Me.insertRent.Name = "insertRent"
        Me.insertRent.Size = New System.Drawing.Size(281, 39)
        Me.insertRent.TabIndex = 4
        Me.insertRent.Text = "Ajouter"
        Me.insertRent.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CIN Client"
        '
        'cinRent
        '
        Me.cinRent.Location = New System.Drawing.Point(210, 38)
        Me.cinRent.Name = "cinRent"
        Me.cinRent.Size = New System.Drawing.Size(281, 26)
        Me.cinRent.TabIndex = 1
        '
        'prixRent
        '
        Me.prixRent.Location = New System.Drawing.Point(210, 208)
        Me.prixRent.Name = "prixRent"
        Me.prixRent.Size = New System.Drawing.Size(281, 26)
        Me.prixRent.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.trouver2)
        Me.TabPage3.Controls.Add(Me.dateRentUD)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.prixRentUD)
        Me.TabPage3.Controls.Add(Me.nbjRentUD)
        Me.TabPage3.Controls.Add(Me.deleteRent)
        Me.TabPage3.Controls.Add(Me.updateRent)
        Me.TabPage3.Controls.Add(Me.idRentUD)
        Me.TabPage3.Controls.Add(Me.trouver1)
        Me.TabPage3.Controls.Add(Me.cinRentUD)
        Me.TabPage3.Location = New System.Drawing.Point(4, 31)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(622, 298)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Modifier/Supprimer une location"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'trouver2
        '
        Me.trouver2.BackColor = System.Drawing.Color.DodgerBlue
        Me.trouver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.trouver2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trouver2.ForeColor = System.Drawing.Color.White
        Me.trouver2.Location = New System.Drawing.Point(497, 62)
        Me.trouver2.Name = "trouver2"
        Me.trouver2.Size = New System.Drawing.Size(75, 26)
        Me.trouver2.TabIndex = 19
        Me.trouver2.Text = "Find"
        Me.trouver2.UseVisualStyleBackColor = False
        '
        'dateRentUD
        '
        Me.dateRentUD.Location = New System.Drawing.Point(235, 111)
        Me.dateRentUD.Name = "dateRentUD"
        Me.dateRentUD.Size = New System.Drawing.Size(284, 26)
        Me.dateRentUD.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(65, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 22)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Prix par jour"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(65, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 22)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Nombre de jour"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Date Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ID Voiture"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CIN Client"
        '
        'prixRentUD
        '
        Me.prixRentUD.Location = New System.Drawing.Point(235, 200)
        Me.prixRentUD.Name = "prixRentUD"
        Me.prixRentUD.Size = New System.Drawing.Size(223, 26)
        Me.prixRentUD.TabIndex = 12
        '
        'nbjRentUD
        '
        Me.nbjRentUD.Location = New System.Drawing.Point(235, 152)
        Me.nbjRentUD.Name = "nbjRentUD"
        Me.nbjRentUD.Size = New System.Drawing.Size(223, 26)
        Me.nbjRentUD.TabIndex = 11
        '
        'deleteRent
        '
        Me.deleteRent.BackColor = System.Drawing.Color.Red
        Me.deleteRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteRent.ForeColor = System.Drawing.Color.White
        Me.deleteRent.Location = New System.Drawing.Point(367, 242)
        Me.deleteRent.Name = "deleteRent"
        Me.deleteRent.Size = New System.Drawing.Size(139, 35)
        Me.deleteRent.TabIndex = 9
        Me.deleteRent.Text = "Supprimer"
        Me.deleteRent.UseVisualStyleBackColor = False
        '
        'updateRent
        '
        Me.updateRent.BackColor = System.Drawing.Color.LimeGreen
        Me.updateRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateRent.ForeColor = System.Drawing.Color.White
        Me.updateRent.Location = New System.Drawing.Point(111, 242)
        Me.updateRent.Name = "updateRent"
        Me.updateRent.Size = New System.Drawing.Size(138, 35)
        Me.updateRent.TabIndex = 7
        Me.updateRent.Text = "Modifier"
        Me.updateRent.UseVisualStyleBackColor = False
        '
        'idRentUD
        '
        Me.idRentUD.Location = New System.Drawing.Point(235, 66)
        Me.idRentUD.Name = "idRentUD"
        Me.idRentUD.Size = New System.Drawing.Size(223, 26)
        Me.idRentUD.TabIndex = 4
        '
        'trouver1
        '
        Me.trouver1.BackColor = System.Drawing.Color.DodgerBlue
        Me.trouver1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.trouver1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trouver1.ForeColor = System.Drawing.Color.White
        Me.trouver1.Location = New System.Drawing.Point(497, 23)
        Me.trouver1.Name = "trouver1"
        Me.trouver1.Size = New System.Drawing.Size(75, 26)
        Me.trouver1.TabIndex = 2
        Me.trouver1.Text = "Find"
        Me.trouver1.UseVisualStyleBackColor = False
        '
        'cinRentUD
        '
        Me.cinRentUD.Location = New System.Drawing.Point(235, 23)
        Me.cinRentUD.Name = "cinRentUD"
        Me.cinRentUD.Size = New System.Drawing.Size(223, 26)
        Me.cinRentUD.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dateRentR)
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.Controls.Add(Me.TrouverRent)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 31)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(622, 298)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Rentabilité du jour"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dateRentR
        '
        Me.dateRentR.Location = New System.Drawing.Point(168, 66)
        Me.dateRentR.Name = "dateRentR"
        Me.dateRentR.Size = New System.Drawing.Size(279, 26)
        Me.dateRentR.TabIndex = 4
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(58, 133)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(509, 150)
        Me.DataGridView2.TabIndex = 3
        '
        'TrouverRent
        '
        Me.TrouverRent.BackColor = System.Drawing.Color.DodgerBlue
        Me.TrouverRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrouverRent.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrouverRent.ForeColor = System.Drawing.Color.White
        Me.TrouverRent.Location = New System.Drawing.Point(473, 66)
        Me.TrouverRent.Name = "TrouverRent"
        Me.TrouverRent.Size = New System.Drawing.Size(135, 26)
        Me.TrouverRent.TabIndex = 2
        Me.TrouverRent.Text = "Find"
        Me.TrouverRent.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date location"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(26, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 75)
        Me.Panel1.TabIndex = 3
        '
        'www
        '
        Me.www.AutoSize = True
        Me.www.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.www.ForeColor = System.Drawing.Color.White
        Me.www.Location = New System.Drawing.Point(142, 54)
        Me.www.Name = "www"
        Me.www.Size = New System.Drawing.Size(52, 18)
        Me.www.TabIndex = 5
        Me.www.Text = "Label7"
        '
        'retour
        '
        Me.retour.BackgroundImage = CType(resources.GetObject("retour.BackgroundImage"), System.Drawing.Image)
        Me.retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.retour.FlatAppearance.BorderSize = 0
        Me.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retour.Location = New System.Drawing.Point(513, 22)
        Me.retour.Name = "retour"
        Me.retour.Size = New System.Drawing.Size(85, 75)
        Me.retour.TabIndex = 6
        Me.retour.UseVisualStyleBackColor = True
        '
        'rentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(626, 450)
        Me.Controls.Add(Me.retour)
        Me.Controls.Add(Me.www)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rentPage"
        Me.Text = "IZI RENT- Rents"
        Me.TabControl3.ResumeLayout(False)
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

    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nbjRent As TextBox
    Friend WithEvents idRent As TextBox
    Friend WithEvents insertRent As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cinRent As TextBox
    Friend WithEvents prixRent As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents prixRentUD As TextBox
    Friend WithEvents nbjRentUD As TextBox
    Friend WithEvents deleteRent As Button
    Friend WithEvents updateRent As Button
    Friend WithEvents idRentUD As TextBox
    Friend WithEvents trouver1 As Button
    Friend WithEvents cinRentUD As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TrouverRent As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dateRent As DateTimePicker
    Friend WithEvents trouver2 As Button
    Friend WithEvents dateRentUD As DateTimePicker
    Friend WithEvents dateRentR As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents www As Label
    Friend WithEvents retour As Button
End Class
