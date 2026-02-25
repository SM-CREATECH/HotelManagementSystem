Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class FormAdministrator

    Private Sub FormAdministrator_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        IO.File.WriteAllText("logs.txt", RtbLogs.Text)
    End Sub

    Private Sub FormAdministrateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UserSession.RoleName <> "Administrateur" Then
            MessageBox.Show("Accès refusé.")
            Me.Close()
        End If

        LblWelcome.Text = "Bienvenue, " & vbCrLf & UserSession.Username
        LblRole.Text = "Rôle : " & vbCrLf & UserSession.RoleName

        Try
            If Not String.IsNullOrEmpty(UserProfilePhotoPath) Then
                Dim fullPath As String = IO.Path.Combine(Application.StartupPath, UserProfilePhotoPath)
                If IO.File.Exists(fullPath) Then
                    PtbProfile.Image = Image.FromFile(fullPath)
                    PtbProfile.SizeMode = PictureBoxSizeMode.Zoom
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Impossible de charger la photo de profil : " & ex.Message)
        End Try

        Using con = Database.GetConnection()
            con.Open()

            Dim query As String =
                "SELECT RoleID, RoleName FROM Roles"

            Dim adapter As New MySqlDataAdapter(query, con)
            Dim table As New DataTable()
            adapter.Fill(table)

            CmbUserRole.DataSource = table
            CmbUserRole.DisplayMember = "RoleName"
            CmbUserRole.ValueMember = "RoleID"
            CmbUserRole.DropDownStyle = ComboBoxStyle.DropDownList
            CmbUserRole.SelectedIndex = -1
        End Using

        Using con = Database.GetConnection()
            con.Open()

            Dim queryTypes As String =
                "SELECT RoomTypeID, RoomTypeName FROM RoomTypes"
            Dim queryStatus As String =
               "SELECT RoomStatusID, RoomStatusName FROM RoomStatuses"
            Dim queryLoadAvailabeRoom As String = "SELECT RoomID, RoomNumber FROM rooms " &
            "WHERE RoomStatusID IN (1,3)" ' Disponible / En nettoyage

            Dim adapterType As New MySqlDataAdapter(queryTypes, con)
            Dim tableType As New DataTable()
            adapterType.Fill(tableType)

            Dim adapterStatus As New MySqlDataAdapter(queryStatus, con)
            Dim tableStatus As New DataTable()
            adapterStatus.Fill(tableStatus)

            Dim adapterLoadAvailabeRoom As New MySqlDataAdapter(queryLoadAvailabeRoom, con)
            Dim tableLoadAvailabeRoom As New DataTable()
            adapterLoadAvailabeRoom.Fill(tableLoadAvailabeRoom)

            'CmbRoomType.DataSource = tableType
            'CmbRoomType.DisplayMember = "RoomTypeName"
            'CmbRoomType.ValueMember = "RoomTypeID"
            'CmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList
            'CmbRoomType.SelectedIndex = -1

            'CmbUserRole.DataSource = tableStatus
            'CmbUserRole.DisplayMember = "RoomStatusName"
            'CmbUserRole.ValueMember = "RoomStatusID"
            'CmbUserRole.DropDownStyle = ComboBoxStyle.DropDownList
            'CmbUserRole.SelectedIndex = -1

            'CmbReservationRoomNumber.DataSource = tableLoadAvailabeRoom
            'CmbReservationRoomNumber.DisplayMember = "RoomNumber"
            'CmbReservationRoomNumber.ValueMember = "RoomID"
            'CmbReservationRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
            'CmbReservationRoomNumber.SelectedIndex = -1
        End Using

        ' Vérifier s'il y a un fichier log (pour afficher les dernières actions du gestionnaire courant)
        If IO.File.Exists("logs.txt") Then
            Dim lignes() As String = IO.File.ReadAllLines("logs.txt")

            Array.Reverse(lignes)
            RtbLogs.Lines = lignes
        End If
    End Sub

    ' Code pour ajouter les dernières actions de l'administrateur courant (logs)
    Private Sub AjouterLog(ByVal message As String)
        Dim logMessage As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") &
                    " - " & message

        RtbLogs.Text = logMessage & Environment.NewLine & RtbLogs.Text
    End Sub

    Private Sub MasquerTousLesPanels()
        PnlManageUsers.Visible = False
        'PnlFilterSearch.Visible = False
        'PnlManageReservations.Visible = False
        PnlManageUsers.SendToBack()
        'PnlManageReservations.SendToBack()
        ' Ajoute ici les futurs panels si nécessaire
    End Sub

    Private Sub ChargerDonnees(ByVal query As String)
        Using con = Database.GetConnection()
            Using cmd As New MySqlCommand(query, con)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                adapter.Fill(table)
                DGVShowData.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub BtnManageUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnManageUsers.Click
        MasquerTousLesPanels()
        PnlManageUsers.Visible = True
        PnlManageUsers.BringToFront()

        DGVShowData.DataSource = Nothing
        ChargerDonnees("SELECT Username AS `Noms Utilisateurs`, RoleName AS `Rôle Utilisateur`, UserIsActive AS `Actif`" &
        "FROM Users " &
        "INNER JOIN Roles ON UserRoleID = RoleID " &
        "ORDER BY Username DESC")
    End Sub

    Private Sub BtnAddPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPicture.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Sélectionner une photo de profil"

            Try
                If ofd.ShowDialog() = DialogResult.OK Then
                    ' Vérifier si le fichier existe
                    If Not IO.File.Exists(ofd.FileName) Then
                        MessageBox.Show("Le fichier sélectionné n'existe pas.", "Erreur ⚠️",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                        Return
                    End If

                    ' Vérifier la taille du fichier
                    Dim fileInfo As New IO.FileInfo(ofd.FileName)
                    If fileInfo.Length > 2 * 1024 * 1024 Then
                        MessageBox.Show("La photo est trop grande (max 2 Mo).", "Erreur ⚠️",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                        Return
                    End If

                    ' Charger l'image
                    Dim img As Image = Nothing
                    Try
                        img = Image.FromFile(ofd.FileName)
                    Catch ex As Exception
                        MessageBox.Show("Impossible de charger l'image. Vérifiez le format ou le fichier est corrompu." & vbCrLf & ex.Message, "Erreur ⚠️", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End Try

                    ' Créer le dossier ProfilePhotos si nécessaire
                    Dim profileFolder As String = IO.Path.Combine(Application.StartupPath, "ProfilePhotos")
                    If Not IO.Directory.Exists(profileFolder) Then
                        IO.Directory.CreateDirectory(profileFolder)
                    End If

                    ' Générer un nom unique pour l'image (par ex. avec l'heure)
                    Dim fileName As String = "Profile_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & IO.Path.GetExtension(ofd.FileName)
                    Dim destPath As String = IO.Path.Combine(profileFolder, fileName)

                    ' Copier le fichier dans le dossier
                    IO.File.Copy(ofd.FileName, destPath, True)

                    ' Stocker le chemin relatif dans la variable globale
                    UserProfilePhotoPath = IO.Path.Combine("ProfilePhotos", fileName)

                    ' Sauvegarder dans la base
                    Using con = Database.GetConnection()
                        con.Open()
                        Dim query As String = "UPDATE Users SET ProfilePhotoPath = @path WHERE UserID = @id"
                        Using cmd As New MySqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@path", UserProfilePhotoPath)
                            cmd.Parameters.AddWithValue("@id", UserSession.UserID)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Affecter l'image au PictureBox
                    PtbProfile.Image = Image.FromFile(destPath)
                    PtbProfile.SizeMode = PictureBoxSizeMode.Zoom
                End If
            Catch ex As Exception
                MessageBox.Show("Une erreur inattendue est survenue lors de la sélection de l'image :" & vbCrLf & ex.Message,
                                "Erreur ⚠️", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        Dim result As DialogResult =
        MessageBox.Show("Voulez-vous vous déconnecter ?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            UserSession.UserID = 0
            UserSession.Username = ""
            UserSession.RoleName = ""

            FormLogin.Show()

            Me.Close()
        End If
    End Sub

    Private Sub BtnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddUser.Click
        'Validation des champs
        If TxtUsername.Text.Trim() = "" OrElse TxtPassword.Text.Trim() = "" OrElse TxtPasswordConfirm.Text.Trim() = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            Exit Sub
        End If

        If CmbUserRole.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez sélectionner un rôle.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            Exit Sub
        End If

        If TxtPassword.Text.Length < 6 Then
            MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            Exit Sub
        End If

        If TxtPassword.Text.Trim() <> TxtPasswordConfirm.Text.Trim() Then
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

                    checkCmd.Parameters.AddWithValue("@username", TxtUsername.Text.Trim())

                    Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userExists > 0 Then
                        MessageBox.Show("Ce nom d'utilisateur existe déjà.", "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                'Hash du mot de passe
                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(TxtPassword.Text.Trim())

                'Récupérer RoleID depuis ComboBox
                Dim roleID As Integer = CInt(CmbUserRole.SelectedValue)

                'Insertion
                Dim insertQuery As String =
                    "INSERT INTO Users (Username, UserPasswordHash, UserRoleID, UserIsActive) " &
                    "VALUES (@username, @password, @roleID, TRUE)"

                Using insertCmd As New MySqlCommand(insertQuery, con)

                    insertCmd.Parameters.AddWithValue("@username", TxtUsername.Text.Trim())
                    insertCmd.Parameters.AddWithValue("@password", hashedPassword)
                    insertCmd.Parameters.AddWithValue("@roleID", roleID)

                    insertCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Utilisateur Ajoutée avec succès ✅", "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                AjouterLog("Ajout de l'utilisateur : " & TxtUsername.Text)

                ChargerDonnees("SELECT Username AS `Noms Utilisateurs`, RoleName AS `Rôle Utilisateur`, UserIsActive AS `Actif`" &
                "FROM Users " &
                "INNER JOIN Roles ON UserRoleID = RoleID " &
                "ORDER BY Username DESC")

                'Réinitialiser les champs
                'ResetChamps()
                TxtUsername.Clear()
                TxtPassword.Clear()
                TxtPasswordConfirm.Clear()
                CmbUserRole.SelectedIndex = -1
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erreur ❌",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class