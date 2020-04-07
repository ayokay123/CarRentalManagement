Imports MySql.Data.MySqlClient
Public Class Form3
    Dim username As String
    Dim cnx As New MySqlConnection("datasource=localhost;database=dbcars;username=root;password=")
    Dim cmd As MySqlCommand = cnx.CreateCommand()
    Dim cmd2 As MySqlCommand = cnx.CreateCommand()
    Dim dr As MySqlDataReader
    Dim dt As New DataTable()
    Dim dt2 As New DataTable()
    Dim result As Integer
    Public Sub setUsername(user As String)
        username = user
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = "Vous etes connecté en tant qu " & username.ToUpper
        Dim da As New MySqlDataAdapter("select * from cars", cnx)
        dt.Dispose()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Enter
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter("select * from cars", cnx)
        dt.Dispose()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If id_c.Text = "" Or mat_c.Text = "" Or IsNumeric(id_c.Text) = False Then
            MessageBox.Show("Il faut remplire tout les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd2.CommandText = "select * from cars where id=" & id_c.Text
        dr = cmd2.ExecuteReader
        If dr.HasRows Then
            MessageBox.Show("ID deja existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            id_c.Text = ""
            mat_c.Text = ""
            Exit Sub
        End If


        cmd.CommandText = "insert into cars values('" & id_c.Text & "', '" & mat_c.Text & "')"
        result = cmd.ExecuteNonQuery()
        If (result > 0) Then
            MessageBox.Show("Voiture ajoutée avec succès", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            id_c.Text = ""
            mat_c.Text = ""
            Me.TabControl1.SelectedTab = Me.TabPage1
        Else
            MessageBox.Show("Erreur au niveau de requete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        cmd2.Dispose()
        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub find_Click(sender As Object, e As EventArgs) Handles find.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If TextBox1.Text = "" Then
            MessageBox.Show("Il faut inserer un id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd2.CommandText = "select * from cars where id=" & TextBox1.Text
        dr = cmd2.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                TextBox3.Text = dr(1)
            Loop
        Else
            MessageBox.Show("ID pas trouvé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = ""
            Exit Sub
        End If
        cmd2.Dispose()
        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If TextBox3.Text = "" Or TextBox1.Text = "" Then
            MessageBox.Show("il faut remplir le champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd.CommandText = "update cars set mar='" & TextBox3.Text & "' where id=" & TextBox1.Text
        result = cmd.ExecuteNonQuery()
        If (result > 0) Then
            MessageBox.Show("Voiture mis à jour avec succés", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Text = ""
            TextBox3.Text = ""
            Me.TabControl1.SelectedTab = Me.TabPage1
        Else
            MessageBox.Show("Erreur au niveau de requete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If TextBox1.Text = "" Then
            MessageBox.Show("il faut remplir le champs id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd.CommandText = "delete from cars where id=" & TextBox1.Text
        result = cmd.ExecuteNonQuery()
        If (result > 0) Then
            MessageBox.Show("Voiture supprimé avec succès", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Text = ""
            TextBox3.Text = ""
            Me.TabControl1.SelectedTab = Me.TabPage1
        Else
            MessageBox.Show("Erreur au niveau de requete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If id_stat.Text = "" Then
            MessageBox.Show("il faut remplir le champs id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd2.CommandText = "select * from cars where id=" & id_stat.Text
        dr = cmd2.ExecuteReader

        If dr.HasRows Then
            dr.Dispose()
        Else
            MessageBox.Show("ID pas trouvé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            id_stat.Text = ""
            Exit Sub
        End If
        Dim query As String = "select * from rent where id=" & id_stat.Text
        Dim da2 As New MySqlDataAdapter(query, cnx)
        dt2.Dispose()
        da2.Fill(dt2)
        DataGridView2.DataSource = dt2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        index.Show()
        Me.Hide()

    End Sub
End Class