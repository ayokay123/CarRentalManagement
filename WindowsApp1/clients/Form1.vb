Imports MySql.Data.MySqlClient
Public Class Form1
    Dim username As String
    Dim cnx As New MySqlConnection("datasource=localhost;database=dbcars;username=root;password=")
    Dim cmd As MySqlCommand = cnx.CreateCommand()
    Dim cmd2 As MySqlCommand = cnx.CreateCommand()
    Dim dr As MySqlDataReader
    Dim dt As New DataTable()
    Dim result As Integer
    Public Sub setUsername(user As String)
        username = user
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = "Vous etes connecté en tant qu " & username.ToUpper
        Dim da As New MySqlDataAdapter("select * from clients", cnx)
        dt.Dispose()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btn_aj_Click(sender As Object, e As EventArgs) Handles btn_aj.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If cin.Text = "" Or fname.Text = "" Or lname.Text = "" Or tel.Text = "" Or adr.Text = "" Or IsNumeric(tel.Text) = False Or IsNumeric(cin.Text) = False Then
            MessageBox.Show("Il faut remplire tout les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd2.CommandText = "select * from clients where ncin=" & cin.Text
        dr = cmd2.ExecuteReader
        If dr.HasRows Then
            MessageBox.Show("CIN deja existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cin.Text = ""
            fname.Text = ""
            lname.Text = ""
            tel.Text = ""
            adr.Text = ""
            Exit Sub
        End If


        cmd.CommandText = "insert into clients values('" & cin.Text & "', '" & fname.Text & "', '" & lname.Text & "', '" & tel.Text & "', '" & adr.Text & "')"
        result = cmd.ExecuteNonQuery()
        If (result > 0) Then
            MessageBox.Show("Client ajoutée avec succès", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cin.Text = ""
            fname.Text = ""
            lname.Text = ""
            tel.Text = ""
            adr.Text = ""
            Me.TabControl2.SelectedTab = Me.TabPage1
        Else
            MessageBox.Show("Erreur au niveau de requete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        cmd2.Dispose()
        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Enter
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter("select * from clients", cnx)
        dt.Dispose()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub find_me_Click(sender As Object, e As EventArgs) Handles find_me.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If cin_1.Text = "" Or IsNumeric(id_it.Text) Then
            MessageBox.Show("Il faut inserer un cin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd2.CommandText = "select * from clients where ncin=" & cin_1.Text
        dr = cmd2.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                fname_1.Text = dr(1)
                lname_1.Text = dr(2)
                tel_1.Text = dr(3)
                adr_1.Text = dr(4)
            Loop
        Else
            MessageBox.Show("CIN pas trouvé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cin_1.Text = ""
            Exit Sub
        End If
        cmd2.Dispose()
        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub modd_Click(sender As Object, e As EventArgs) Handles modd.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If cin_1.Text = "" Or fname_1.Text = "" Or lname_1.Text = "" Or tel_1.Text = "" Or adr_1.Text = "" Or IsNumeric(tel_1.Text) = False Or IsNumeric(cin_1.Text) = False Then
            MessageBox.Show("Il faut remplire tout les champs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd.CommandText = "update clients set fname='" & fname_1.Text & "',lname='" & lname_1.Text & "',tel='" & tel_1.Text & "',adr='" & adr_1.Text & "' where cin=" & cin_1.Text
        result = cmd.ExecuteNonQuery()
        If (result > 0) Then
            MessageBox.Show("Client mis à jour avec succés", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fname_1.Text = ""
            lname_1.Text = ""
            tel_1.Text = ""
            adr_1.Text = ""
            cin_1.Text = ""
            Me.TabControl2.SelectedTab = Me.TabPage1
        Else
            MessageBox.Show("Erreur au niveau de requete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub suppp_Click(sender As Object, e As EventArgs) Handles suppp.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If cin_1.Text = "" Or IsNumeric(id_it.Text) Then
            MessageBox.Show("il faut remplir le champs cin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd.CommandText = "delete from clients where ncin=" & cin_1.Text
        result = cmd.ExecuteNonQuery()
        If (result > 0) Then
            MessageBox.Show("Client supprimé avec succès", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            fname_1.Text = ""
            lname_1.Text = ""
            tel_1.Text = ""
            adr_1.Text = ""
            cin_1.Text = ""
            Me.TabControl2.SelectedTab = Me.TabPage1
        Else
            MessageBox.Show("Erreur au niveau de requete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        cmd.Dispose()
        cnx.Close()
    End Sub

    Private Sub find_it_Click(sender As Object, e As EventArgs) Handles find_it.Click
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()
        If id_it.Text = "" Or IsNumeric(id_it.Text) Then
            MessageBox.Show("il faut remplir le champs id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        cmd2.CommandText = "select * from clients where ncin=" & id_it.Text
        dr = cmd2.ExecuteReader

        If dr.HasRows Then
            dr.Dispose()
        Else
            MessageBox.Show("CIN pas trouvé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            id_it.Text = ""
            Exit Sub
        End If
        Dim query As String = "select * from rent where ncin=" & id_it.Text
        Dim da2 As New MySqlDataAdapter(query, cnx)
        dt.Dispose()
        da2.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        index.Show()
        Me.Hide()
    End Sub

End Class