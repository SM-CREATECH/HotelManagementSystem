Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class FormLogin
    Private Sub FormLogin_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        TLPContainer.Left = (Me.ClientSize.Width - TLPContainer.Width) / 2
        TLPContainer.Top = (Me.ClientSize.Height - TLPContainer.Height) / 2
        TLPUsername.Left = (Me.ClientSize.Width - TLPUsername.Width) / 2
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show(
        "Voulez-vous vraiment quitter l'application ?",
        "Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        'Validation des champs
        If TxtUsername.Text.Trim() = "" OrElse TxtPassword.Text.Trim() = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur ❌")
            Exit Sub
        End If

        Using con = Database.GetConnection()
            Try
                con.Open()
                'MessageBox.Show("Connexion MySQL réussie ✅", "Information")

                Dim query As String =
                "SELECT UserID, Username, UserPasswordHash, RoleName, ProfilePhotoPath " &
                "FROM Users " &
                "INNER JOIN Roles ON UserRoleID = RoleID " &
                "WHERE Username = @username AND UserIsActive = TRUE"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@username", TxtUsername.Text.Trim())

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim hashedPassword As String = reader("UserPasswordHash").ToString()

                            If BCrypt.Net.BCrypt.Verify(TxtPassword.Text.Trim(), hashedPassword) Then
                                UserSession.UserID = CInt(reader("UserID"))
                                UserSession.Username = reader("Username").ToString()
                                UserSession.RoleName = reader("RoleName").ToString()

                                'Ajout de la photo de profil si disponible
                                If Not IsDBNull(reader("ProfilePhotoPath")) Then
                                    UserProfilePhotoPath = reader("ProfilePhotoPath").ToString()
                                Else
                                    UserProfilePhotoPath = ""
                                End If

                                Dim role As String = reader("RoleName").ToString()

                                If role = "Administrateur" Then
                                    MessageBox.Show("Connexion réussie en tant qu'" & role & ".", "Information")
                                Else
                                    MessageBox.Show("Connexion réussie en tant que " & role & ".", "Information")
                                End If

                                'Réinitialiser les champs
                                TxtUsername.Clear()
                                TxtPassword.Clear()

                                Select Case role
                                    Case "Administrateur"
                                        ' Ouvrir FormAdmin
                                        FormAdministrator.Show()
                                    Case "Receptionniste"
                                        ' Ouvrir FormReception
                                        FormReceptionist.Show()
                                    Case "Gestionnaire"
                                        ' Ouvrir FormGestion
                                        FormManager.Show()
                                End Select
                                Me.Hide()
                            Else
                                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur ❌")
                            End If
                        Else
                            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur ❌")
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(vbCrLf & ex.Message, "Erreur ❌")
            End Try
        End Using
    End Sub

    Private Sub BtnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegister.Click
        Me.Hide()
        FormRegister.Show()
    End Sub
End Class
