Public Class index
    Dim username As String
    Public Sub setUsername(user As String)
        username = user
    End Sub
    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Vous etes connecté en tant qu " & username.ToUpper
        carLabel.Text = "CARS"
        rentLabel.Text = "RENTS"
        clientLabel.Text = "CLIENTS"
    End Sub

    Private Sub deco_Click(sender As Object, e As EventArgs) Handles deco.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rentPage.Show()
        Me.Hide()
    End Sub

End Class