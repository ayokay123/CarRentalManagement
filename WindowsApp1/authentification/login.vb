Imports MySql.Data.MySqlClient
Public Class login
    Dim chaine As String = "datasource=localhost;database=dbcars;username=root;password="
    Dim cnx As New MySqlConnection(chaine)
    Dim cmd As MySqlCommand = cnx.CreateCommand()
    Dim dr As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("il faut remplir tous les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Clear()
            TextBox2.Clear()
            Exit Sub
        End If
        cnx.Open()
        cmd.CommandText = "select * from users where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MessageBox.Show("Votre connexion a été effectuée avec success", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            index.setUsername(TextBox1.Text)
            Form3.setUsername(TextBox1.Text)
            Form1.setUsername(TextBox1.Text)
            rentPage.setUsername(TextBox1.Text)
            TextBox2.Text = ""
            TextBox1.Text = ""
            index.Show()
            Me.Hide()
        Else
            MessageBox.Show("nom d'utilisateur ou mot de passe incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Clear()
            TextBox2.Clear()
            Exit Sub
        End If
        dr.Dispose()
        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
