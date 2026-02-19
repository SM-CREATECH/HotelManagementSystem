Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class FormManager

    Private Sub FormGestionnaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If UserSession.RoleName <> "Gestionnaire" Then
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
    End Sub

    Private Sub BtnRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnManageRooms.Click
        Using con = Database.GetConnection()
            Dim query As String = "SELECT * FROM Rooms"

            Using cmd As New MySqlCommand(query, con)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                adapter.Fill(table)

                DGVShowData.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub BtnReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnManageReservation.Click
        Using con = Database.GetConnection()
            Dim query As String =
            "SELECT r.ReservationID, c.FullName, rm.RoomNumber, r.CheckInDate, r.CheckOutDate " &
            "FROM Reservations r " &
            "INNER JOIN Clients c ON r.ClientID = c.ClientID " &
            "INNER JOIN Rooms rm ON r.RoomID = rm.RoomID"

            Using cmd As New MySqlCommand(query, con)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                adapter.Fill(table)

                DGVShowData.DataSource = table
            End Using
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

    'Private Sub BtnAjouterClient_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAjouterClient.Click
    ' Code pour ajouter un client...

    ' Ajouter automatiquement l'action
    'Historique.AjouterAction(LsbHistorical, "Création d'un client : " & TxtNom.Text)
    'End Sub

    'Private Sub BtnAjouterReservation_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAjouterReservation.Click
    ' Code pour ajouter réservation...

    'Historique.AjouterAction(LsbHistorical, "Nouvelle réservation pour : " & TxtClient.Text)
    'End Sub

    Private Sub BtnAddPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPicture.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Images (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Sélectionner une photo de profil"

            Try
                If ofd.ShowDialog() = DialogResult.OK Then
                    ' Vérifier si le fichier existe
                    If Not IO.File.Exists(ofd.FileName) Then
                        MessageBox.Show("Le fichier sélectionné n'existe pas.", "Erreur ⚠️", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' Vérifier la taille du fichier
                    Dim fileInfo As New IO.FileInfo(ofd.FileName)
                    If fileInfo.Length > 2 * 1024 * 1024 Then
                        MessageBox.Show("La photo est trop grande (max 2 Mo).", "Erreur ⚠️", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show("Une erreur inattendue est survenue lors de la sélection de l'image :" & vbCrLf & ex.Message, "Erreur ⚠️", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class