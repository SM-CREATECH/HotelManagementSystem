Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class FormManager

    Private Sub FormManager_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        IO.File.WriteAllText("logs.txt", RtbLogs.Text)

        If UserSession.RoleName = "Administrateur" Then
            FormAdministrator.Show()
            Me.Close()
        End If
    End Sub

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

            CmbRoomType.DataSource = tableType
            CmbRoomType.DisplayMember = "RoomTypeName"
            CmbRoomType.ValueMember = "RoomTypeID"
            CmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList
            CmbRoomType.SelectedIndex = -1

            CmbRoomStatus.DataSource = tableStatus
            CmbRoomStatus.DisplayMember = "RoomStatusName"
            CmbRoomStatus.ValueMember = "RoomStatusID"
            CmbRoomStatus.DropDownStyle = ComboBoxStyle.DropDownList
            CmbRoomStatus.SelectedIndex = -1

            CmbReservationRoomNumber.DataSource = tableLoadAvailabeRoom
            CmbReservationRoomNumber.DisplayMember = "RoomNumber"
            CmbReservationRoomNumber.ValueMember = "RoomID"
            CmbReservationRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
            CmbReservationRoomNumber.SelectedIndex = -1
        End Using

        ' Vérifier s'il y a un fichier log (pour afficher les dernières actions du gestionnaire courant)
        If IO.File.Exists("logs.txt") Then
            Dim lignes() As String = IO.File.ReadAllLines("logs.txt")

            Array.Reverse(lignes)
            RtbLogs.Lines = lignes
        End If
    End Sub

    ' Code pour ajouter les dernières actions du gestionnaire courant (logs)
    Private Sub AjouterLog(ByVal message As String)
        Dim logMessage As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") &
                    " - " & message

        RtbLogs.Text = logMessage & Environment.NewLine & RtbLogs.Text
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

    Private Sub MasquerTousLesPanels()
        PnlManageRooms.Visible = False
        PnlFilterSearch.Visible = False
        PnlManageReservations.Visible = False
        PnlManageRooms.SendToBack()
        PnlManageReservations.SendToBack()
        ' Ajoute ici les futurs panels si nécessaire
    End Sub

    Private Sub BtnRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnManageRooms.Click
        MasquerTousLesPanels()
        PnlManageRooms.Visible = True
        PnlManageRooms.BringToFront()

        DGVShowData.DataSource = Nothing
        ChargerDonnees("SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
        "CONCAT(FORMAT(r.RoomPrice, 2), ' HTG') AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
        "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
        "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
        "ORDER BY RoomNumber DESC")
    End Sub

    Private Sub BtnReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnManageReservation.Click
        MasquerTousLesPanels()
        PnlManageReservations.Visible = True
        PnlManageReservations.BringToFront()

        DGVShowData.DataSource = Nothing
        ChargerDonnees("SELECT c.ClientFullName AS `Nom Client`, CONCAT(rm.RoomNumber, '(rm.RoomStatusName)', ' / ', " &
        "FORMAT(rm.RoomPrice, 2), ' HTG') AS `Numéro Chambre (Etat) / Prix`, " &
        "r.ReservationCheckInDate AS `Date d'arrivée`, r.ReservationCheckOutDate AS `Date de départ`, " &
        " r.ReservationNights AS `Nombre de nuits`, r.ReservationTotalCost AS `Coût total`, rs.ReservationStatusName AS `Statut` " &
        "FROM reservations r " &
        "INNER JOIN clients c  ON r.ReservationClientID = c.ClientID " &
        "INNER JOIN rooms rm ON r.ReservationRoomID = rm.RoomID " &
        "INNER JOIN ReservationStatuses rs ON r.ReservationStatusID = rs.ReservationStatusID " &
        "ORDER BY r.ReservationCheckInDate DESC")
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

    ' Code vérification si chambre existe
    Private Function RoomExiste(ByVal roomNumber As String) As Boolean
        Using con = Database.GetConnection()
            con.Open()

            Dim query As String = "SELECT COUNT(*) FROM Rooms WHERE RoomNumber = @num"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@num", roomNumber)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub TxtRoomPriceInt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRoomPriceInt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtRoomPriceFloat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRoomPriceFloat.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Limiter à 2 caractères
        If TxtRoomPriceFloat.Text.Length >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtRoomPriceFloat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRoomPriceFloat.Leave
        If TxtRoomPriceFloat.Text.Length = 0 Then
            TxtRoomPriceFloat.Text = "00"
        ElseIf TxtRoomPriceFloat.Text.Length = 1 Then
            TxtRoomPriceFloat.Text &= "0"
        End If
    End Sub

    ' Code pour réinitialiser les champs
    Private Sub ResetChamps()
        TxtRoomNumber.Clear()
        CmbRoomType.SelectedIndex = -1
        TxtRoomPriceFloat.Clear()
        TxtRoomPriceInt.Clear()
        CmbRoomStatus.SelectedIndex = -1
    End Sub

    ' Code insertion chambre
    Private Sub BtnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddRoom.Click
        Try
            TxtRoomNumber.Enabled = True

            If DGVShowData.SelectedRows.Count > 0 Then
                ' Réinitialiser les champs
                ResetChamps()

                DGVShowData.SelectionMode = DataGridViewSelectionMode.CellSelect
            End If

            If PnlFilterSearch.Visible = True Then
                PnlFilterSearch.Visible = False
                RdbByNumber.Checked = False
                RdbByPrice.Checked = False
                RdbByStatus.Checked = False
                RdbByType.Checked = False
                LblRoomNumber.Enabled = True
                TxtRoomNumber.Enabled = True
                LblRoomType.Enabled = True
                CmbRoomType.Enabled = True
                LblRoomPrice.Enabled = True
                TxtRoomPriceInt.Enabled = True
                LblRoomPriceDot.Enabled = True
                TxtRoomPriceFloat.Enabled = True
                LblRoomStatus.Enabled = True
                CmbRoomStatus.Enabled = True

                ' Réinitialiser les champs
                ResetChamps()

                ChargerDonnees("SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
                "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
                "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
                "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
                "ORDER BY RoomNumber DESC")
            End If

            If RoomExiste(TxtRoomNumber.Text.Trim()) Then
                MessageBox.Show("Ce numéro de chambre existe déjà.", "Erreur ⚠️",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                Exit Sub
            End If

            If TxtRoomNumber.Text = "" Then
                MessageBox.Show("Veuillez saisir le numéro de chambre.", "Erreur ⚠️",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                Exit Sub
            End If

            If CmbRoomType.SelectedIndex = -1 Then
                MessageBox.Show("Veuillez choisir le type de chambre.", "Erreur ⚠️",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                Exit Sub
            End If

            If TxtRoomPriceInt.Text = "" Then
                MessageBox.Show("Veuillez saisir la partie entière du prix.", "Erreur ⚠️",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                Exit Sub
            End If

            If CmbRoomStatus.SelectedIndex = -1 Then
                MessageBox.Show("Veuillez choisir l'état de la chambre.", "Erreur ⚠️",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim prixString As String = TxtRoomPriceInt.Text & "." & TxtRoomPriceFloat.Text
            Dim prix As Decimal

            If Not Decimal.TryParse(prixString, Globalization.NumberStyles.Any,
                                    Globalization.CultureInfo.InvariantCulture, prix) Then
                MessageBox.Show("Prix invalide.", "Erreur ⚠️",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                Exit Sub
            End If

            Using con = Database.GetConnection()
                con.Open()

                Dim query As String = "INSERT INTO Rooms (RoomNumber, RoomTypeID, RoomPrice, RoomStatusID) " &
                          "VALUES (@num, @typeID, @price, @statusID)"

                Dim typeID As Integer = CInt(CmbRoomType.SelectedValue)
                Dim statusID As Integer = CInt(CmbRoomStatus.SelectedValue)

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@num", TxtRoomNumber.Text)
                    cmd.Parameters.AddWithValue("@typeID", typeID)
                    cmd.Parameters.AddWithValue("@price", prix)
                    cmd.Parameters.AddWithValue("@statusID", statusID)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Chambre ajoutée avec succès ✅", "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            AjouterLog("Ajout de la chambre N° " & TxtRoomNumber.Text)

            ' Réinitialiser les champs
            ResetChamps()
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'ajout : " & ex.Message)
        End Try

        ChargerDonnees("SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
        "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
        "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
        "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
        "ORDER BY RoomNumber DESC")
    End Sub

    ' Code modification chambre
    Private Sub BtnRoomUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRoomUpdate.Click
        Try
            ' Activer la sélection complète de ligne
            DGVShowData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGVShowData.MultiSelect = False

            TxtRoomNumber.Enabled = False
            If PnlFilterSearch.Visible = True Then
                PnlFilterSearch.Visible = False
                RdbByNumber.Checked = False
                RdbByPrice.Checked = False
                RdbByStatus.Checked = False
                RdbByType.Checked = False
                LblRoomNumber.Enabled = True
                TxtRoomNumber.Enabled = False
                LblRoomType.Enabled = True
                CmbRoomType.Enabled = True
                LblRoomPrice.Enabled = True
                TxtRoomPriceInt.Enabled = True
                LblRoomPriceDot.Enabled = True
                TxtRoomPriceFloat.Enabled = True
                LblRoomStatus.Enabled = True
                CmbRoomStatus.Enabled = True

                ' Réinitialiser les champs
                ResetChamps()

                ChargerDonnees("SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
                "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
                "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
                "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
                "ORDER BY RoomNumber DESC")
            End If

            If DGVShowData.SelectedRows.Count = 0 Then
                MessageBox.Show("Veuillez d'abord sélectionner une ligne entière dans la table ci-dessous.", "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim prixString As String = TxtRoomPriceInt.Text & "." & TxtRoomPriceFloat.Text
            Dim prix As Decimal

            If Not Decimal.TryParse(prixString, Globalization.NumberStyles.Any,
                                    Globalization.CultureInfo.InvariantCulture, prix) Then
                MessageBox.Show("Prix invalide.", "Erreur ⚠️",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim numero As String = DGVShowData.SelectedRows(0).Cells("Numéro chambre").Value.ToString()

            If ChambreEstLiee(numero) Then
                MessageBox.Show("Impossible de supprimer. Cette chambre est liée à des réservations.", "Avertissement ⚠️",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Voulez-vous vraiment modifier la chambre " & numero & " ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Using con = Database.GetConnection()
                    con.Open()

                    Dim query As String =
                        "UPDATE Rooms SET RoomTypeID=@typeID, RoomPrice=@price, RoomStatusID=@statusID " &
                        "WHERE RoomNumber=@num"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@num", TxtRoomNumber.Text.Trim())
                        cmd.Parameters.AddWithValue("@typeID", CInt(CmbRoomType.SelectedValue))
                        cmd.Parameters.AddWithValue("@price", prix)
                        cmd.Parameters.AddWithValue("@statusID", CInt(CmbRoomStatus.SelectedValue))

                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Chambre modifiée avec succès ✅", "Succès",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                AjouterLog("Modification de la chambre N° " & TxtRoomNumber.Text)

                DGVShowData.SelectionMode = DataGridViewSelectionMode.CellSelect
                DGVShowData.MultiSelect = False
                TxtRoomNumber.Enabled = True

                ' Réinitialiser les champs
                ResetChamps()
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la modification : " & ex.Message, "Erreur ⚠️",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        ChargerDonnees("SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
        "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
        "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
        "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
        "ORDER BY RoomNumber DESC")
    End Sub

    ' Filtrer recherche chambre par numéro
    Private Sub RdbByNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbByNumber.CheckedChanged
        LblRoomNumber.Enabled = RdbByNumber.Checked
        TxtRoomNumber.Enabled = RdbByNumber.Checked

        CmbRoomType.Enabled = False
        TxtRoomPriceInt.Enabled = False
        TxtRoomPriceFloat.Enabled = False
        CmbRoomStatus.Enabled = False
    End Sub

    ' Filtrer recherche chambre par type
    Private Sub RdbByType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbByType.CheckedChanged
        LblRoomType.Enabled = RdbByType.Checked
        CmbRoomType.Enabled = RdbByType.Checked

        TxtRoomNumber.Enabled = False
        TxtRoomPriceInt.Enabled = False
        TxtRoomPriceFloat.Enabled = False
        CmbRoomStatus.Enabled = False
    End Sub

    ' Filtrer recherche chambre par prix
    Private Sub RdbByPrice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbByPrice.CheckedChanged
        LblRoomPrice.Enabled = RdbByPrice.Checked
        LblRoomPriceDot.Enabled = RdbByPrice.Checked
        TxtRoomPriceInt.Enabled = RdbByPrice.Checked
        TxtRoomPriceFloat.Enabled = RdbByPrice.Checked

        TxtRoomNumber.Enabled = False
        CmbRoomType.Enabled = False
        CmbRoomStatus.Enabled = False
    End Sub

    ' Filtrer recherche chambre par état
    Private Sub RdbByStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbByStatus.CheckedChanged
        LblRoomStatus.Enabled = RdbByStatus.Checked
        CmbRoomStatus.Enabled = RdbByStatus.Checked

        TxtRoomNumber.Enabled = False
        CmbRoomType.Enabled = False
        TxtRoomPriceInt.Enabled = False
        TxtRoomPriceFloat.Enabled = False
    End Sub

    ' Code rechercher chambre
    Private Sub BtnRoomSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRoomSearch.Click
        LblRoomNumber.Enabled = False
        TxtRoomNumber.Enabled = False
        LblRoomType.Enabled = False
        CmbRoomType.Enabled = False
        LblRoomPrice.Enabled = False
        TxtRoomPriceInt.Enabled = False
        LblRoomPriceDot.Enabled = False
        TxtRoomPriceFloat.Enabled = False
        LblRoomStatus.Enabled = False
        CmbRoomStatus.Enabled = False

        PnlFilterSearch.Visible = True

        If DGVShowData.SelectedRows.Count > 0 Then
            ' Réinitialiser les champs
            ResetChamps()

            DGVShowData.SelectionMode = DataGridViewSelectionMode.CellSelect
        End If

        Dim query As String = ""
        Dim valeur As String = ""

        If RdbByNumber.Checked Then
            LblRoomNumber.Enabled = RdbByNumber.Checked
            TxtRoomNumber.Enabled = RdbByNumber.Checked
            If TxtRoomNumber.Text.Trim() = "" Then
                MessageBox.Show("Veuillez préciser le numéro du chambre à rechercher.", "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                Exit Sub
            End If
            query = "SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
                "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
                "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
                "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
                "WHERE RoomNumber LIKE @val"
            valeur = "%" & TxtRoomNumber.Text.Trim() & "%"
            AjouterLog("Recherche d'une chambre de N° " & TxtRoomNumber.Text)

            ' Réinitialiser le champ
            TxtRoomNumber.Clear()
        ElseIf RdbByType.Checked Then
            LblRoomType.Enabled = RdbByType.Checked
            CmbRoomType.Enabled = RdbByType.Checked
            If CmbRoomType.SelectedIndex = -1 Then
                MessageBox.Show("Veuillez choisir le type de chambre à rechercher dans la liste.", "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                Exit Sub
            End If
            query = "SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
                "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
                "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
                "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
                "WHERE t.RoomTypeName LIKE @val"
            valeur = "%" & CmbRoomType.Text & "%"
            AjouterLog("Recherche d'une chambre de type " & CmbRoomType.Text)

            ' Réinitialiser le champ
            CmbRoomType.SelectedIndex = -1
        ElseIf RdbByPrice.Checked Then
            LblRoomPrice.Enabled = RdbByPrice.Checked
            LblRoomPriceDot.Enabled = RdbByPrice.Checked
            TxtRoomPriceInt.Enabled = RdbByPrice.Checked
            TxtRoomPriceFloat.Enabled = RdbByPrice.Checked
            If TxtRoomPriceInt.Text.Trim() = "" Then
                MessageBox.Show("Veuillez préciser le prix du chambre à rechercher.", "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                Exit Sub
            End If
            query = "SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
                "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
                "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
                "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
                "WHERE RoomPrice = @val"
            valeur = TxtRoomPriceInt.Text & "." & TxtRoomPriceFloat.Text
            AjouterLog("Recherche d'une chambre de prix " & TxtRoomPriceInt.Text & "." & TxtRoomPriceFloat.Text)

            ' Réinitialiser les champs
            TxtRoomPriceFloat.Clear()
            TxtRoomPriceInt.Clear()
        ElseIf RdbByStatus.Checked Then
            LblRoomStatus.Enabled = RdbByStatus.Checked
            CmbRoomStatus.Enabled = RdbByStatus.Checked
            If CmbRoomStatus.SelectedIndex = -1 Then
                MessageBox.Show("Veuillez choisir l'état du chambre à rechercher dans la liste.", "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                Exit Sub
            End If
            query = "SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
                "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
                "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
                "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
                "WHERE s.RoomStatusName LIKE @val"
            valeur = "%" & CmbRoomStatus.Text & "%"
            AjouterLog("Recherche d'une chambre de statut " & CmbRoomStatus.Text)

            ' Réinitialiser le champ
            CmbRoomStatus.SelectedIndex = -1
        Else
            MessageBox.Show("Veuillez choisir un critère de recherche.", "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            Exit Sub
        End If

        Using con = Database.GetConnection()
            con.Open()

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@val", valeur)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count = 0 Then
                    MessageBox.Show("Aucune chambre trouvée correspondant au critère.",
                                    "Recherche", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                    DGVShowData.DataSource = Nothing
                Else
                    DGVShowData.DataSource = table
                End If
            End Using
        End Using
    End Sub

    ' Code de vérification si une chambre est liée avant d'accepter la supression
    Private Function ChambreEstLiee(ByVal numero As String) As Boolean
        Using con = Database.GetConnection()
            con.Open()

            ' Récupérer le RoomID
            Dim querySelectIdChambre As String = "SELECT RoomID FROM Rooms WHERE RoomNumber=@num"
            Dim roomId As Object

            Using cmd As New MySqlCommand(querySelectIdChambre, con)
                cmd.Parameters.AddWithValue("@num", numero)
                roomId = cmd.ExecuteScalar()
            End Using

            ' Si aucune chambre trouvée
            If roomId Is Nothing Then
                Return False
            End If

            ' Vérifier liaison dans Reservations
            Dim queryCheck As String =
                "SELECT COUNT(*) FROM Reservations WHERE ReservationRoomID=@id"

            Using cmd As New MySqlCommand(queryCheck, con)
                cmd.Parameters.AddWithValue("@id", CInt(roomId))

                Dim count As Integer = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    ' Code supression chambre
    Private Sub BtnRoomDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRoomDelete.Click
        Try
            ' Activer la sélection complète de ligne
            DGVShowData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DGVShowData.MultiSelect = False

            TxtRoomNumber.Enabled = True
            If PnlFilterSearch.Visible = True Then
                PnlFilterSearch.Visible = False
                RdbByNumber.Checked = False
                RdbByPrice.Checked = False
                RdbByStatus.Checked = False
                RdbByType.Checked = False
                LblRoomNumber.Enabled = True
                TxtRoomNumber.Enabled = True
                LblRoomType.Enabled = True
                CmbRoomType.Enabled = True
                LblRoomPrice.Enabled = True
                TxtRoomPriceInt.Enabled = True
                LblRoomPriceDot.Enabled = True
                TxtRoomPriceFloat.Enabled = True
                LblRoomStatus.Enabled = True
                CmbRoomStatus.Enabled = True

                ' Réinitialiser les champs
                ResetChamps()

                ChargerDonnees("SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
                "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
                "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
                "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
                "ORDER BY RoomNumber DESC")
            End If

            If DGVShowData.SelectedRows.Count = 0 Then
                MessageBox.Show("Veuillez d'abord sélectionner une ligne entière dans la table ci-dessous.", "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim numero As String = DGVShowData.SelectedRows(0).Cells("Numéro chambre").Value.ToString()

            If ChambreEstLiee(numero) Then
                MessageBox.Show("Impossible de supprimer. Cette chambre est liée à des réservations.", "Avertissement ⚠️",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Voulez-vous vraiment supprimer la chambre " & numero & " ?", "Confirmation",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                Using con = Database.GetConnection()
                    con.Open()

                    Dim query As String = "DELETE FROM Rooms WHERE RoomNumber=@num"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@num", numero)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Chambre suprimée avec succès ✅", "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                AjouterLog("Supression de la chambre N° " & numero)

                DGVShowData.SelectionMode = DataGridViewSelectionMode.CellSelect
                DGVShowData.MultiSelect = False
                TxtRoomNumber.Enabled = True

                ' Réinitialiser les champs
                ResetChamps()
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la supression : " & ex.Message, "Erreur ⚠️",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        ChargerDonnees("SELECT r.RoomNumber AS `Numéro Chambre`, t.RoomTypeName AS `Type Chambre`," &
        "r.RoomPrice AS `Prix Chambre`, s.RoomStatusName AS `Etat` FROM Rooms r " &
        "INNER JOIN RoomTypes t ON r.RoomTypeID = t.RoomTypeID " &
        "INNER JOIN RoomStatuses s ON r.RoomStatusID = s.RoomStatusID " &
        "ORDER BY RoomNumber DESC")
    End Sub

    Private Sub DGVShowData_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGVShowData.CellFormatting
        If DGVShowData.Columns(e.ColumnIndex).Name = "Etat" Then
            If e.Value IsNot Nothing Then
                Dim status As String = e.Value.ToString()

                Select Case status
                    Case "Disponible"
                        DGVShowData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                    Case "Occupée"
                        DGVShowData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                    Case "En nettoyage"
                        DGVShowData.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
                End Select
            End If
        End If
    End Sub

    Private Sub DGVShowData_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVShowData.SelectionChanged
        If DGVShowData.SelectedRows.Count = 0 Then Exit Sub

        Dim row As DataGridViewRow = DGVShowData.SelectedRows(0)

        ' Numéro
        TxtRoomNumber.Text = row.Cells("Numéro Chambre").Value.ToString()

        ' Type
        CmbRoomType.Text = row.Cells("Type Chambre").Value.ToString()

        ' Prix
        Dim prix As Decimal = CDec(row.Cells("Prix Chambre").Value)

        TxtRoomPriceInt.Text = Math.Truncate(prix).ToString()
        TxtRoomPriceFloat.Text =
            ((prix - Math.Truncate(prix)) * 100).ToString("00")

        ' Etat
        CmbRoomStatus.Text = row.Cells("Etat").Value.ToString()
    End Sub

    ' Code réservations
    Private Sub BtnReservationAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReservationAdd.Click
        Try
            ' Validation dates
            If DtpCheckOut.Value.Date <= DtpCheckIn.Value.Date Then
                MessageBox.Show("La date de départ doit être après la date d'arrivée.", "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                Exit Sub
            End If

            'If CmbClients.SelectedIndex = -1 Or CmbRooms.SelectedIndex = -1 Then
            'ageBox.Show("Veuillez sélectionner un client et une chambre.")
            'Exit Sub
            'End If

            'Dim clientID As Integer = CInt(CmbClients.SelectedValue)
            Dim roomID As Integer = CInt(CmbReservationRoomNumber.SelectedValue)
            Dim checkIn As Date = DtpCheckIn.Value.Date
            Dim checkOut As Date = DtpCheckOut.Value.Date

            Using con = Database.GetConnection()
                con.Open()

                ' Vérifier chevauchement de dates
                Dim checkQuery As String =
                "SELECT COUNT(*) FROM reservations " &
                "WHERE ReservationRoomID = @roomID " &
                "AND ReservationStatusID IN (1,2) " &
                "AND (@checkIn < ReservationCheckOutDate " &
                "AND @checkOut > ReservationCheckInDate)"

                Using checkCmd As New MySqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@roomID", roomID)
                    checkCmd.Parameters.AddWithValue("@checkIn", checkIn)
                    checkCmd.Parameters.AddWithValue("@checkOut", checkOut)

                    Dim count As Integer = CInt(checkCmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("La chambre est déjà réservée pour cette période.", "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End Using

                ' Récupérer prix actuel de la chambre
                Dim priceQuery As String =
                    "SELECT RoomPrice FROM rooms WHERE RoomID=@roomID"

                Dim roomPrice As Decimal

                Using priceCmd As New MySqlCommand(priceQuery, con)
                    priceCmd.Parameters.AddWithValue("@roomID", roomID)
                    roomPrice = CDec(priceCmd.ExecuteScalar())
                End Using

                ' Insérer réservation
                Dim insertQuery As String =
                    "INSERT INTO reservations " &
                    "(ReservationClientID, ReservationRoomID, " &
                    "ReservationCheckInDate, ReservationCheckOutDate, " &
                    "ReservationRoomPrice, ReservationStatusID) " &
                    "VALUES (@clientID, @roomID, @checkIn, @checkOut, @price, 1)"

                Using insertCmd As New MySqlCommand(insertQuery, con)
                    'insertCmd.Parameters.AddWithValue("@clientID", clientID)
                    insertCmd.Parameters.AddWithValue("@roomID", roomID)
                    insertCmd.Parameters.AddWithValue("@checkIn", checkIn)
                    insertCmd.Parameters.AddWithValue("@checkOut", checkOut)
                    insertCmd.Parameters.AddWithValue("@price", roomPrice)

                    insertCmd.ExecuteNonQuery()
                End Using

                ' Mettre chambre en Occupée
                Dim updateRoom As String =
                    "UPDATE rooms SET RoomStatusID = 3 WHERE RoomID=@roomID"

                Using updateCmd As New MySqlCommand(updateRoom, con)
                    updateCmd.Parameters.AddWithValue("@roomID", roomID)
                    updateCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Réservation enregistrée avec succès ✅", "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            AjouterLog("Nouvelle réservation du client enregistrée.")

            'ChargerReservations()
            'ChargerChambresDisponibles()
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message, "Erreur ⚠️",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' Forcer la sortie d'une réservation à être au moins +1 jour
    Private Sub DtpCheckIn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpCheckIn.ValueChanged
        DtpCheckOut.MinDate = DtpCheckIn.Value.AddDays(1)
    End Sub
End Class