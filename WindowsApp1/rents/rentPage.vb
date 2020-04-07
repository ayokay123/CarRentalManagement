Imports MySql.Data.MySqlClient

Public Class rentPage
    Dim cnx As New MySqlConnection("datasource=localhost;database=dbcars;username=root;password=")
    Dim username As String
    Public Sub setUsername(user As String)
        username = user
    End Sub
    'inserer une location
    Private Sub insertRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertRent.Click
        Dim cmd As MySqlCommand = cnx.CreateCommand
        Dim dr As MySqlDataReader

        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()

        Dim dateRentCh As String = Format(dateRent.Value, "yyyy-MM-dd")

        If cinRent.Text = "" Or idRent.Text = "" Or nbjRent.Text = "" Or prixRent.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs!", "Insertion de location", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage2
            Exit Sub
        End If

        cmd.CommandText = "select * from clients where ncin=" & cinRent.Text & " "
        dr = cmd.ExecuteReader
        cmd.Dispose()
        If dr.HasRows = False Then
            MessageBox.Show("Client introuvable!", "Insertion de location", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage2
            Exit Sub
        End If
        dr.Dispose()

        cmd.CommandText = "select * from cars where id=" & idRent.Text & " "
        dr = cmd.ExecuteReader
        cmd.Dispose()
        If dr.HasRows = False Then
            MessageBox.Show("Voiture introuvable!", "Insertion de location", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage2
            Exit Sub
        End If
        dr.Dispose()

        cmd.CommandText = "select * from rent where id=" & idRent.Text & " and date='" & dateRentCh & "'"
        dr = cmd.ExecuteReader
        cmd.Dispose()
        If dr.HasRows Then
            MessageBox.Show("Voiture indisponible!", "Insertion de location", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage2
            Exit Sub
        End If
        dr.Dispose()



        cmd.CommandText = "insert into rent (ncin, id, date, nbd, pd) values (" & cinRent.Text & "," & idRent.Text & ",'" & dateRentCh & "'," & nbjRent.Text & "," & prixRent.Text & ")"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Location Ajoutée avec succès!", "Insertion de location", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.Dispose()
        Exit Sub


    End Sub

    'pour update une voiture
    Private Sub updateRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateRent.Click
        Dim cmd As MySqlCommand = cnx.CreateCommand
        Dim dr As MySqlDataReader
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()

        Dim dateRentCh As String = Format(dateRentUD.Value, "yyyy-MM-dd")

        If cinRentUD.Text = "" Or idRentUD.Text = "" Or nbjRentUD.Text = "" Or prixRentUD.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs!", "Modification de location", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        End If

        cmd.CommandText = "select * from rent where ncin=" & cinRentUD.Text & " and id=" & idRentUD.Text & " and date='" & dateRentCh & "'"
        dr = cmd.ExecuteReader
        cmd.Dispose()

        If dr.HasRows = False Then
            dr.Dispose()
            MessageBox.Show("Location introuvable!", "Modification de location", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        Else
            dr.Dispose()
            If DialogResult.OK = MessageBox.Show("Voulez-vous modifier cette location ?", "Modification de location", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) Then
                cmd.CommandText = "update rent set nbd=" & nbjRentUD.Text & ", pd=" & prixRentUD.Text & " where ncin=" & cinRentUD.Text & " and id=" & idRentUD.Text & " and date='" & dateRentCh & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Location modifiée avec succès!", "Modification de location", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Dispose()
                Me.TabControl3.SelectedTab = Me.TabPage3
                Exit Sub
            End If
        End If
    End Sub

    'pour trouver une ncin
    Private Sub trouver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trouver1.Click
        Dim cmd As MySqlCommand = cnx.CreateCommand
        Dim dr As MySqlDataReader
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()

        If cinRentUD.Text = "" Then
            MessageBox.Show("Veuillez entrer une cin!", "Recherche de client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        End If


        cmd.CommandText = "select * from clients where ncin=" & cinRentUD.Text & " "
        dr = cmd.ExecuteReader
        cmd.Dispose()

        If dr.HasRows Then
            dr.Dispose()
            MessageBox.Show("Client touvé!", "Recherche de client", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        Else
            dr.Dispose()
            MessageBox.Show("Client inexistant!", "Recherche de client", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        End If

    End Sub

    'pour trouver une id voiture
    Private Sub trouver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trouver2.Click
        Dim cmd As MySqlCommand = cnx.CreateCommand
        Dim dr As MySqlDataReader
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()

        If idRentUD.Text = "" Then
            MessageBox.Show("Veuillez entrer une ID!", "Recherche de voiture", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        End If

        cmd.CommandText = "select * from cars where id=" & idRentUD.Text & " "
        dr = cmd.ExecuteReader
        cmd.Dispose()

        If dr.HasRows Then
            dr.Dispose()
            MessageBox.Show("Voiture touvé!", "Recherche de voiture", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        Else
            dr.Dispose()
            MessageBox.Show("Voiture inexistant!", "Recherche de voiture", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        End If

    End Sub

    'supprimer une location
    Private Sub deleteRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteRent.Click
        Dim cmd As MySqlCommand = cnx.CreateCommand
        Dim dr As MySqlDataReader
        If ConnectionState.Open Then
            cnx.Close()
        End If
        cnx.Open()

        Dim dateRentCh As String = Format(dateRentUD.Value, "yyyy-MM-dd")

        If cinRentUD.Text = "" Or idRentUD.Text = "" Then
            MessageBox.Show("Veuillez remplir CIN et ID!", "Suppression de location", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        End If

        cmd.CommandText = "select * from rent where ncin=" & cinRentUD.Text & " and id=" & idRentUD.Text & " and date='" & dateRentCh & "'"
        dr = cmd.ExecuteReader
        cmd.Dispose()

        If dr.HasRows = False Then
            dr.Dispose()
            MessageBox.Show("Location introuvable!", "Suppression de location", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.TabControl3.SelectedTab = Me.TabPage3
            Exit Sub
        Else
            dr.Dispose()
            If DialogResult.OK = MessageBox.Show("Voulez-vous supprimer cette location ?", "Suppression de location", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) Then
                cmd.CommandText = "delete from rent where ncin=" & cinRentUD.Text & " and id=" & idRentUD.Text & " and date='" & dateRentCh & "'"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Location supprimée avec succès!", "Suppression de location", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Dispose()
                Me.TabControl3.SelectedTab = Me.TabPage3
                Exit Sub
            End If
        End If

    End Sub

    'rentabilité par jour
    Private Sub TrouverRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrouverRent.Click
        Dim dateRentCh As String = Format(dateRentR.Value, "yyyy-MM-dd")
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter("select * from rent where date='" & dateRentCh & "'", cnx)
        dt.Dispose()
        da.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub rentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        www.Text = "Vous etes connecté en tant qu " & username.ToUpper
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter("select * from rent", cnx)
        dt.Dispose()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub retour_Click(sender As Object, e As EventArgs) Handles retour.Click
        index.Show()
        Me.Hide()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Enter
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter("select * from rent", cnx)
        dt.Dispose()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
