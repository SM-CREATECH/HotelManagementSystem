Public Class FormAdministrator

    Private Sub FormAdministrateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblWelcome.Text = "Bienvenue " & UserSession.Username.ToUpper
    End Sub
End Class