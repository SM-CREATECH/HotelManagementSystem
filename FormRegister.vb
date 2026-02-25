Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class FormRegister
    Private Sub FormRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UserSession.RoleName <> "Administrateur" Then
            MessageBox.Show("Accès refusé. Authentification Administrateur requise.", "Sécurité 🔒",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning)

            Dim authForm As New FormAdminAuth()
            authForm.ShowDialog()

            If authForm.IsAuthorized = False Then
                Me.Close()
            End If
        End If

        Using con = Database.GetConnection()
            con.Open()

            Dim query As String =
                "SELECT RoleID, RoleName FROM Roles WHERE RoleName <> 'Administrateur'"

            Dim adapter As New MySqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)

            CmbRole.DataSource = table
            CmbRole.DisplayMember = "RoleName"
            CmbRole.ValueMember = "RoleID"
            CmbRole.DropDownStyle = ComboBoxStyle.DropDownList
            CmbRole.SelectedIndex = -1
        End Using
    End Sub

    Private Sub BtnBackRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackRegister.Click
        FormLogin.Show()
        Me.Close()
    End Sub

    Private Sub FormRegister_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Centrer la vue
        TLPContainerRegister.Left = (Me.ClientSize.Width - TLPContainerRegister.Width) / 2
        TLPContainerRegister.Top = (Me.ClientSize.Height - TLPContainerRegister.Height) / 2
    End Sub

    Private Sub BtnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegister.Click
        'Validation des champs
        If TxtUsernameRegister.Text.Trim() = "" OrElse TxtPasswordRegister.Text.Trim() = "" OrElse TxtPasswordConfirm.Text.Trim() = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            Exit Sub
        End If

        If CmbRole.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez sélectionner un rôle.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            Exit Sub
        End If

        If TxtPasswordRegister.Text.Length < 6 Then
            MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            Exit Sub
        End If

        If TxtPasswordRegister.Text.Trim() <> TxtPasswordConfirm.Text.Trim() Then
            MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            TxtPasswordConfirm.Clear()
            TxtPasswordConfirm.Focus()
            Exit Sub
        End If

        Using con = Database.GetConnection()

            Try
                con.Open()

                'Vérifier si username existe déjà
                Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @username"
                Using checkCmd As New MySqlCommand(checkQuery, con)

                    checkCmd.Parameters.AddWithValue("@username", TxtUsernameRegister.Text.Trim())

                    Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userExists > 0 Then
                        MessageBox.Show("Ce nom d'utilisateur existe déjà.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                'Hash du mot de passe
                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(TxtPasswordRegister.Text.Trim())

                'Récupérer RoleID depuis ComboBox
                Dim roleID As Integer = CInt(CmbRole.SelectedValue)

                'Insertion
                Dim insertQuery As String =
                    "INSERT INTO Users (Username, UserPasswordHash, UserRoleID, UserIsActive) " &
                    "VALUES (@username, @password, @roleID, TRUE)"

                Using insertCmd As New MySqlCommand(insertQuery, con)

                    insertCmd.Parameters.AddWithValue("@username", TxtUsernameRegister.Text.Trim())
                    insertCmd.Parameters.AddWithValue("@password", hashedPassword)
                    insertCmd.Parameters.AddWithValue("@roleID", roleID)

                    insertCmd.ExecuteNonQuery()
                End Using

                'Réinitialiser les champs
                TxtUsernameRegister.Clear()
                TxtPasswordRegister.Clear()
                TxtPasswordConfirm.Clear()
                CmbRole.SelectedIndex = -1

                'Récupérer le rôle sélectionné
                Dim roleName As String = CmbRole.Text

                MessageBox.Show("Inscription réussie ✅", "Information",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)

                Select Case roleName
                    Case "Receptionniste"
                        FormReceptionist.Show()
                    Case "Gestionnaire"
                        FormManager.Show()
                End Select

                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class