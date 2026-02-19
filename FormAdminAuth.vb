Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class FormAdminAuth

    Public Property IsAuthorized As Boolean = False

    Private Sub FormAdminAuth_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        PnlAdminPassword.Left = (Me.ClientSize.Width - PnlAdminPassword.Width) / 2
        PnlAdminPassword.Top = (Me.ClientSize.Height - PnlAdminPassword.Height) / 2
    End Sub

    Private Sub BtnValidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnValidate.Click
        Using con = Database.GetConnection()
            con.Open()

            Dim query As String =
                "SELECT UserPasswordHash FROM Users " &
                "INNER JOIN Roles ON UserRoleID = RoleID " &
                "WHERE RoleName = 'Administrateur'"

            Using cmd As New MySqlCommand(query, con)

                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then

                    Dim hashedPassword As String = result.ToString()

                    If BCrypt.Net.BCrypt.Verify(TxtAdminPassword.Text.Trim(), hashedPassword) Then
                        IsAuthorized = True
                        Me.Close()
                    Else
                        MessageBox.Show("Mot de passe administrateur incorrect.", "Erreur ❌")
                        TxtAdminPassword.Clear()
                        TxtAdminPassword.Focus()
                    End If

                Else
                    MessageBox.Show("Aucun administrateur actif trouvé.", "Erreur ❌")
                End If

            End Using
        End Using
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Dim result As DialogResult = MessageBox.Show(
        "Voulez-vous vraiment quitter l'application ?",
        "Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class