<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.LblRole = New System.Windows.Forms.Label()
        Me.PnlUserInfo = New System.Windows.Forms.Panel()
        Me.BtnAddPicture = New System.Windows.Forms.Button()
        Me.PtbProfile = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.PnlManageReservations = New System.Windows.Forms.Panel()
        Me.DtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.DtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.BtnReservationAdd = New System.Windows.Forms.Button()
        Me.LblReservationClientName = New System.Windows.Forms.Label()
        Me.LblOutDate = New System.Windows.Forms.Label()
        Me.LblInDate = New System.Windows.Forms.Label()
        Me.LblReservationRoomNumber = New System.Windows.Forms.Label()
        Me.TxtReservationClientName = New System.Windows.Forms.TextBox()
        Me.CmbReservationRoomNumber = New System.Windows.Forms.ComboBox()
        Me.PnlFilterSearch = New System.Windows.Forms.Panel()
        Me.LblSearchByTitle = New System.Windows.Forms.Label()
        Me.RdbByNumber = New System.Windows.Forms.RadioButton()
        Me.RdbByStatus = New System.Windows.Forms.RadioButton()
        Me.RdbByType = New System.Windows.Forms.RadioButton()
        Me.RdbByPrice = New System.Windows.Forms.RadioButton()
        Me.GrpLogs = New System.Windows.Forms.GroupBox()
        Me.RtbLogs = New System.Windows.Forms.RichTextBox()
        Me.LblLastLogs = New System.Windows.Forms.Label()
        Me.DGVShowData = New System.Windows.Forms.DataGridView()
        Me.GrpSidebar = New System.Windows.Forms.GroupBox()
        Me.BtnManagePayments = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnStatistics = New System.Windows.Forms.Button()
        Me.BtnManageRooms = New System.Windows.Forms.Button()
        Me.BtnManageClients = New System.Windows.Forms.Button()
        Me.BtnManageReservation = New System.Windows.Forms.Button()
        Me.PnlManageRooms = New System.Windows.Forms.Panel()
        Me.BtnRoomSearch = New System.Windows.Forms.Button()
        Me.BtnRoomDelete = New System.Windows.Forms.Button()
        Me.BtnRoomUpdate = New System.Windows.Forms.Button()
        Me.BtnAddRoom = New System.Windows.Forms.Button()
        Me.LblRoomPriceDot = New System.Windows.Forms.Label()
        Me.TxtRoomPriceFloat = New System.Windows.Forms.TextBox()
        Me.LblRoomNumber = New System.Windows.Forms.Label()
        Me.LblRoomStatus = New System.Windows.Forms.Label()
        Me.CmbRoomStatus = New System.Windows.Forms.ComboBox()
        Me.LblRoomPrice = New System.Windows.Forms.Label()
        Me.LblRoomType = New System.Windows.Forms.Label()
        Me.TxtRoomPriceInt = New System.Windows.Forms.TextBox()
        Me.TxtRoomNumber = New System.Windows.Forms.TextBox()
        Me.CmbRoomType = New System.Windows.Forms.ComboBox()
        Me.PnlUserInfo.SuspendLayout()
        CType(Me.PtbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMain.SuspendLayout()
        Me.PnlManageReservations.SuspendLayout()
        Me.PnlFilterSearch.SuspendLayout()
        Me.GrpLogs.SuspendLayout()
        CType(Me.DGVShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSidebar.SuspendLayout()
        Me.PnlManageRooms.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.Location = New System.Drawing.Point(3, 3)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(159, 16)
        Me.LblWelcome.TabIndex = 0
        Me.LblWelcome.Text = "Message de Bienvenue"
        '
        'LblRole
        '
        Me.LblRole.AutoSize = True
        Me.LblRole.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRole.Location = New System.Drawing.Point(3, 65)
        Me.LblRole.Name = "LblRole"
        Me.LblRole.Size = New System.Drawing.Size(195, 16)
        Me.LblRole.TabIndex = 1
        Me.LblRole.Text = "Rôle de l'utilisateur connecté"
        '
        'PnlUserInfo
        '
        Me.PnlUserInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUserInfo.Controls.Add(Me.BtnAddPicture)
        Me.PnlUserInfo.Controls.Add(Me.PtbProfile)
        Me.PnlUserInfo.Controls.Add(Me.LblWelcome)
        Me.PnlUserInfo.Controls.Add(Me.LblRole)
        Me.PnlUserInfo.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlUserInfo.Location = New System.Drawing.Point(242, 13)
        Me.PnlUserInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlUserInfo.Name = "PnlUserInfo"
        Me.PnlUserInfo.Size = New System.Drawing.Size(591, 100)
        Me.PnlUserInfo.TabIndex = 2
        '
        'BtnAddPicture
        '
        Me.BtnAddPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddPicture.Location = New System.Drawing.Point(354, 65)
        Me.BtnAddPicture.Name = "BtnAddPicture"
        Me.BtnAddPicture.Size = New System.Drawing.Size(133, 23)
        Me.BtnAddPicture.TabIndex = 3
        Me.BtnAddPicture.Text = "Ajouter une photo"
        Me.BtnAddPicture.UseVisualStyleBackColor = True
        '
        'PtbProfile
        '
        Me.PtbProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PtbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PtbProfile.Location = New System.Drawing.Point(493, 2)
        Me.PtbProfile.Name = "PtbProfile"
        Me.PtbProfile.Size = New System.Drawing.Size(96, 96)
        Me.PtbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbProfile.TabIndex = 2
        Me.PtbProfile.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(9, 475)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(217, 28)
        Me.BtnLogout.TabIndex = 6
        Me.BtnLogout.Text = "Se Déconnecter"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'PnlMain
        '
        Me.PnlMain.Controls.Add(Me.PnlManageReservations)
        Me.PnlMain.Controls.Add(Me.PnlFilterSearch)
        Me.PnlMain.Controls.Add(Me.GrpLogs)
        Me.PnlMain.Controls.Add(Me.DGVShowData)
        Me.PnlMain.Controls.Add(Me.PnlUserInfo)
        Me.PnlMain.Controls.Add(Me.GrpSidebar)
        Me.PnlMain.Controls.Add(Me.PnlManageRooms)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1076, 515)
        Me.PnlMain.TabIndex = 3
        '
        'PnlManageReservations
        '
        Me.PnlManageReservations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlManageReservations.Controls.Add(Me.DtpCheckOut)
        Me.PnlManageReservations.Controls.Add(Me.DtpCheckIn)
        Me.PnlManageReservations.Controls.Add(Me.BtnReservationAdd)
        Me.PnlManageReservations.Controls.Add(Me.LblReservationClientName)
        Me.PnlManageReservations.Controls.Add(Me.LblOutDate)
        Me.PnlManageReservations.Controls.Add(Me.LblInDate)
        Me.PnlManageReservations.Controls.Add(Me.LblReservationRoomNumber)
        Me.PnlManageReservations.Controls.Add(Me.TxtReservationClientName)
        Me.PnlManageReservations.Controls.Add(Me.CmbReservationRoomNumber)
        Me.PnlManageReservations.Location = New System.Drawing.Point(248, 128)
        Me.PnlManageReservations.Name = "PnlManageReservations"
        Me.PnlManageReservations.Size = New System.Drawing.Size(588, 84)
        Me.PnlManageReservations.TabIndex = 27
        Me.PnlManageReservations.Visible = False
        '
        'DtpCheckOut
        '
        Me.DtpCheckOut.CustomFormat = "dd-MM-yyyy"
        Me.DtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpCheckOut.Location = New System.Drawing.Point(461, 19)
        Me.DtpCheckOut.Name = "DtpCheckOut"
        Me.DtpCheckOut.Size = New System.Drawing.Size(121, 23)
        Me.DtpCheckOut.TabIndex = 24
        '
        'DtpCheckIn
        '
        Me.DtpCheckIn.CustomFormat = "dd-MM-yyyy"
        Me.DtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpCheckIn.Location = New System.Drawing.Point(305, 18)
        Me.DtpCheckIn.Name = "DtpCheckIn"
        Me.DtpCheckIn.Size = New System.Drawing.Size(121, 23)
        Me.DtpCheckIn.TabIndex = 23
        '
        'BtnReservationAdd
        '
        Me.BtnReservationAdd.Location = New System.Drawing.Point(419, 53)
        Me.BtnReservationAdd.Name = "BtnReservationAdd"
        Me.BtnReservationAdd.Size = New System.Drawing.Size(164, 23)
        Me.BtnReservationAdd.TabIndex = 22
        Me.BtnReservationAdd.Text = "Réserver une chambre"
        Me.BtnReservationAdd.UseVisualStyleBackColor = True
        '
        'LblReservationClientName
        '
        Me.LblReservationClientName.AutoSize = True
        Me.LblReservationClientName.Location = New System.Drawing.Point(-3, 0)
        Me.LblReservationClientName.Name = "LblReservationClientName"
        Me.LblReservationClientName.Size = New System.Drawing.Size(75, 16)
        Me.LblReservationClientName.TabIndex = 15
        Me.LblReservationClientName.Text = "Nom Client"
        '
        'LblOutDate
        '
        Me.LblOutDate.AutoSize = True
        Me.LblOutDate.Location = New System.Drawing.Point(458, -1)
        Me.LblOutDate.Name = "LblOutDate"
        Me.LblOutDate.Size = New System.Drawing.Size(104, 16)
        Me.LblOutDate.TabIndex = 19
        Me.LblOutDate.Text = "Date De Départ"
        '
        'LblInDate
        '
        Me.LblInDate.AutoSize = True
        Me.LblInDate.Location = New System.Drawing.Point(302, -1)
        Me.LblInDate.Name = "LblInDate"
        Me.LblInDate.Size = New System.Drawing.Size(94, 16)
        Me.LblInDate.TabIndex = 18
        Me.LblInDate.Text = "Date D'arrivée"
        '
        'LblReservationRoomNumber
        '
        Me.LblReservationRoomNumber.AutoSize = True
        Me.LblReservationRoomNumber.Location = New System.Drawing.Point(145, 0)
        Me.LblReservationRoomNumber.Name = "LblReservationRoomNumber"
        Me.LblReservationRoomNumber.Size = New System.Drawing.Size(117, 16)
        Me.LblReservationRoomNumber.TabIndex = 16
        Me.LblReservationRoomNumber.Text = "Numéro Chambre"
        '
        'TxtReservationClientName
        '
        Me.TxtReservationClientName.Location = New System.Drawing.Point(2, 19)
        Me.TxtReservationClientName.Name = "TxtReservationClientName"
        Me.TxtReservationClientName.Size = New System.Drawing.Size(114, 23)
        Me.TxtReservationClientName.TabIndex = 12
        '
        'CmbReservationRoomNumber
        '
        Me.CmbReservationRoomNumber.FormattingEnabled = True
        Me.CmbReservationRoomNumber.Location = New System.Drawing.Point(148, 18)
        Me.CmbReservationRoomNumber.Name = "CmbReservationRoomNumber"
        Me.CmbReservationRoomNumber.Size = New System.Drawing.Size(121, 24)
        Me.CmbReservationRoomNumber.TabIndex = 17
        '
        'PnlFilterSearch
        '
        Me.PnlFilterSearch.Controls.Add(Me.LblSearchByTitle)
        Me.PnlFilterSearch.Controls.Add(Me.RdbByNumber)
        Me.PnlFilterSearch.Controls.Add(Me.RdbByStatus)
        Me.PnlFilterSearch.Controls.Add(Me.RdbByType)
        Me.PnlFilterSearch.Controls.Add(Me.RdbByPrice)
        Me.PnlFilterSearch.Location = New System.Drawing.Point(242, 225)
        Me.PnlFilterSearch.Name = "PnlFilterSearch"
        Me.PnlFilterSearch.Size = New System.Drawing.Size(591, 44)
        Me.PnlFilterSearch.TabIndex = 26
        Me.PnlFilterSearch.Visible = False
        '
        'LblSearchByTitle
        '
        Me.LblSearchByTitle.AutoSize = True
        Me.LblSearchByTitle.Location = New System.Drawing.Point(3, 0)
        Me.LblSearchByTitle.Name = "LblSearchByTitle"
        Me.LblSearchByTitle.Size = New System.Drawing.Size(82, 16)
        Me.LblSearchByTitle.TabIndex = 26
        Me.LblSearchByTitle.Text = "Rechercher :"
        '
        'RdbByNumber
        '
        Me.RdbByNumber.AutoSize = True
        Me.RdbByNumber.Location = New System.Drawing.Point(3, 19)
        Me.RdbByNumber.Name = "RdbByNumber"
        Me.RdbByNumber.Size = New System.Drawing.Size(154, 20)
        Me.RdbByNumber.TabIndex = 22
        Me.RdbByNumber.TabStop = True
        Me.RdbByNumber.Text = "Par numéro chambre"
        Me.RdbByNumber.UseVisualStyleBackColor = True
        '
        'RdbByStatus
        '
        Me.RdbByStatus.AutoSize = True
        Me.RdbByStatus.Location = New System.Drawing.Point(436, 19)
        Me.RdbByStatus.Name = "RdbByStatus"
        Me.RdbByStatus.Size = New System.Drawing.Size(130, 20)
        Me.RdbByStatus.TabIndex = 25
        Me.RdbByStatus.TabStop = True
        Me.RdbByStatus.Text = "Par état chambre"
        Me.RdbByStatus.UseVisualStyleBackColor = True
        '
        'RdbByType
        '
        Me.RdbByType.AutoSize = True
        Me.RdbByType.Location = New System.Drawing.Point(163, 19)
        Me.RdbByType.Name = "RdbByType"
        Me.RdbByType.Size = New System.Drawing.Size(132, 20)
        Me.RdbByType.TabIndex = 23
        Me.RdbByType.TabStop = True
        Me.RdbByType.Text = "Par type chambre"
        Me.RdbByType.UseVisualStyleBackColor = True
        '
        'RdbByPrice
        '
        Me.RdbByPrice.AutoSize = True
        Me.RdbByPrice.Location = New System.Drawing.Point(301, 19)
        Me.RdbByPrice.Name = "RdbByPrice"
        Me.RdbByPrice.Size = New System.Drawing.Size(129, 20)
        Me.RdbByPrice.TabIndex = 24
        Me.RdbByPrice.TabStop = True
        Me.RdbByPrice.Text = "Par prix chambre"
        Me.RdbByPrice.UseVisualStyleBackColor = True
        '
        'GrpLogs
        '
        Me.GrpLogs.Controls.Add(Me.RtbLogs)
        Me.GrpLogs.Controls.Add(Me.LblLastLogs)
        Me.GrpLogs.Dock = System.Windows.Forms.DockStyle.Right
        Me.GrpLogs.Location = New System.Drawing.Point(842, 0)
        Me.GrpLogs.Name = "GrpLogs"
        Me.GrpLogs.Size = New System.Drawing.Size(234, 515)
        Me.GrpLogs.TabIndex = 11
        Me.GrpLogs.TabStop = False
        '
        'RtbLogs
        '
        Me.RtbLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RtbLogs.Location = New System.Drawing.Point(6, 151)
        Me.RtbLogs.Name = "RtbLogs"
        Me.RtbLogs.ReadOnly = True
        Me.RtbLogs.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RtbLogs.Size = New System.Drawing.Size(222, 364)
        Me.RtbLogs.TabIndex = 2
        Me.RtbLogs.Text = ""
        '
        'LblLastLogs
        '
        Me.LblLastLogs.AutoSize = True
        Me.LblLastLogs.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastLogs.Location = New System.Drawing.Point(5, 19)
        Me.LblLastLogs.Name = "LblLastLogs"
        Me.LblLastLogs.Size = New System.Drawing.Size(155, 38)
        Me.LblLastLogs.TabIndex = 0
        Me.LblLastLogs.Text = "Dernières actions " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "du gestionnaire"
        Me.LblLastLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGVShowData
        '
        Me.DGVShowData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVShowData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVShowData.Location = New System.Drawing.Point(242, 284)
        Me.DGVShowData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGVShowData.Name = "DGVShowData"
        Me.DGVShowData.ReadOnly = True
        Me.DGVShowData.Size = New System.Drawing.Size(588, 219)
        Me.DGVShowData.TabIndex = 4
        '
        'GrpSidebar
        '
        Me.GrpSidebar.Controls.Add(Me.BtnLogout)
        Me.GrpSidebar.Controls.Add(Me.BtnManagePayments)
        Me.GrpSidebar.Controls.Add(Me.BtnDashboard)
        Me.GrpSidebar.Controls.Add(Me.LblTitle)
        Me.GrpSidebar.Controls.Add(Me.BtnStatistics)
        Me.GrpSidebar.Controls.Add(Me.BtnManageRooms)
        Me.GrpSidebar.Controls.Add(Me.BtnManageClients)
        Me.GrpSidebar.Controls.Add(Me.BtnManageReservation)
        Me.GrpSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.GrpSidebar.Location = New System.Drawing.Point(0, 0)
        Me.GrpSidebar.Name = "GrpSidebar"
        Me.GrpSidebar.Size = New System.Drawing.Size(234, 515)
        Me.GrpSidebar.TabIndex = 10
        Me.GrpSidebar.TabStop = False
        '
        'BtnManagePayments
        '
        Me.BtnManagePayments.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnManagePayments.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManagePayments.Location = New System.Drawing.Point(9, 297)
        Me.BtnManagePayments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnManagePayments.Name = "BtnManagePayments"
        Me.BtnManagePayments.Size = New System.Drawing.Size(217, 28)
        Me.BtnManagePayments.TabIndex = 4
        Me.BtnManagePayments.Text = "Gérer Paiements"
        Me.BtnManagePayments.UseVisualStyleBackColor = True
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDashboard.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.Location = New System.Drawing.Point(9, 439)
        Me.BtnDashboard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(217, 28)
        Me.BtnDashboard.TabIndex = 7
        Me.BtnDashboard.Text = "Tableau de bord"
        Me.BtnDashboard.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Futura Md BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(4, 19)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(225, 50)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Hotel Management " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnStatistics
        '
        Me.BtnStatistics.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnStatistics.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatistics.Location = New System.Drawing.Point(9, 261)
        Me.BtnStatistics.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnStatistics.Name = "BtnStatistics"
        Me.BtnStatistics.Size = New System.Drawing.Size(217, 28)
        Me.BtnStatistics.TabIndex = 5
        Me.BtnStatistics.Text = "Statistiques"
        Me.BtnStatistics.UseVisualStyleBackColor = True
        '
        'BtnManageRooms
        '
        Me.BtnManageRooms.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnManageRooms.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageRooms.Location = New System.Drawing.Point(9, 153)
        Me.BtnManageRooms.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnManageRooms.Name = "BtnManageRooms"
        Me.BtnManageRooms.Size = New System.Drawing.Size(217, 28)
        Me.BtnManageRooms.TabIndex = 1
        Me.BtnManageRooms.Text = "Gérer Chambres"
        Me.BtnManageRooms.UseVisualStyleBackColor = True
        '
        'BtnManageClients
        '
        Me.BtnManageClients.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnManageClients.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageClients.Location = New System.Drawing.Point(9, 225)
        Me.BtnManageClients.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnManageClients.Name = "BtnManageClients"
        Me.BtnManageClients.Size = New System.Drawing.Size(217, 28)
        Me.BtnManageClients.TabIndex = 3
        Me.BtnManageClients.Text = "Gérer Clients"
        Me.BtnManageClients.UseVisualStyleBackColor = True
        '
        'BtnManageReservation
        '
        Me.BtnManageReservation.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnManageReservation.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageReservation.Location = New System.Drawing.Point(9, 189)
        Me.BtnManageReservation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnManageReservation.Name = "BtnManageReservation"
        Me.BtnManageReservation.Size = New System.Drawing.Size(217, 28)
        Me.BtnManageReservation.TabIndex = 2
        Me.BtnManageReservation.Text = "Gérer Réservations"
        Me.BtnManageReservation.UseVisualStyleBackColor = True
        '
        'PnlManageRooms
        '
        Me.PnlManageRooms.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlManageRooms.Controls.Add(Me.BtnRoomSearch)
        Me.PnlManageRooms.Controls.Add(Me.BtnRoomDelete)
        Me.PnlManageRooms.Controls.Add(Me.BtnRoomUpdate)
        Me.PnlManageRooms.Controls.Add(Me.BtnAddRoom)
        Me.PnlManageRooms.Controls.Add(Me.LblRoomPriceDot)
        Me.PnlManageRooms.Controls.Add(Me.TxtRoomPriceFloat)
        Me.PnlManageRooms.Controls.Add(Me.LblRoomNumber)
        Me.PnlManageRooms.Controls.Add(Me.LblRoomStatus)
        Me.PnlManageRooms.Controls.Add(Me.CmbRoomStatus)
        Me.PnlManageRooms.Controls.Add(Me.LblRoomPrice)
        Me.PnlManageRooms.Controls.Add(Me.LblRoomType)
        Me.PnlManageRooms.Controls.Add(Me.TxtRoomPriceInt)
        Me.PnlManageRooms.Controls.Add(Me.TxtRoomNumber)
        Me.PnlManageRooms.Controls.Add(Me.CmbRoomType)
        Me.PnlManageRooms.Location = New System.Drawing.Point(248, 133)
        Me.PnlManageRooms.Name = "PnlManageRooms"
        Me.PnlManageRooms.Size = New System.Drawing.Size(588, 84)
        Me.PnlManageRooms.TabIndex = 21
        Me.PnlManageRooms.Visible = False
        '
        'BtnRoomSearch
        '
        Me.BtnRoomSearch.Location = New System.Drawing.Point(294, 56)
        Me.BtnRoomSearch.Name = "BtnRoomSearch"
        Me.BtnRoomSearch.Size = New System.Drawing.Size(147, 23)
        Me.BtnRoomSearch.TabIndex = 26
        Me.BtnRoomSearch.Text = "Rechercher chambre"
        Me.BtnRoomSearch.UseVisualStyleBackColor = True
        '
        'BtnRoomDelete
        '
        Me.BtnRoomDelete.Location = New System.Drawing.Point(447, 56)
        Me.BtnRoomDelete.Name = "BtnRoomDelete"
        Me.BtnRoomDelete.Size = New System.Drawing.Size(135, 23)
        Me.BtnRoomDelete.TabIndex = 25
        Me.BtnRoomDelete.Text = "Supprimer chambre"
        Me.BtnRoomDelete.UseVisualStyleBackColor = True
        '
        'BtnRoomUpdate
        '
        Me.BtnRoomUpdate.Location = New System.Drawing.Point(166, 56)
        Me.BtnRoomUpdate.Name = "BtnRoomUpdate"
        Me.BtnRoomUpdate.Size = New System.Drawing.Size(122, 23)
        Me.BtnRoomUpdate.TabIndex = 24
        Me.BtnRoomUpdate.Text = "Modifier chambre"
        Me.BtnRoomUpdate.UseVisualStyleBackColor = True
        '
        'BtnAddRoom
        '
        Me.BtnAddRoom.Location = New System.Drawing.Point(42, 56)
        Me.BtnAddRoom.Name = "BtnAddRoom"
        Me.BtnAddRoom.Size = New System.Drawing.Size(118, 23)
        Me.BtnAddRoom.TabIndex = 22
        Me.BtnAddRoom.Text = "Ajouter chambre"
        Me.BtnAddRoom.UseVisualStyleBackColor = True
        '
        'LblRoomPriceDot
        '
        Me.LblRoomPriceDot.AutoSize = True
        Me.LblRoomPriceDot.Location = New System.Drawing.Point(380, 25)
        Me.LblRoomPriceDot.Name = "LblRoomPriceDot"
        Me.LblRoomPriceDot.Size = New System.Drawing.Size(12, 16)
        Me.LblRoomPriceDot.TabIndex = 23
        Me.LblRoomPriceDot.Text = "."
        '
        'TxtRoomPriceFloat
        '
        Me.TxtRoomPriceFloat.Location = New System.Drawing.Point(398, 18)
        Me.TxtRoomPriceFloat.Name = "TxtRoomPriceFloat"
        Me.TxtRoomPriceFloat.Size = New System.Drawing.Size(24, 23)
        Me.TxtRoomPriceFloat.TabIndex = 23
        Me.TxtRoomPriceFloat.Text = "00"
        '
        'LblRoomNumber
        '
        Me.LblRoomNumber.AutoSize = True
        Me.LblRoomNumber.Location = New System.Drawing.Point(-3, 0)
        Me.LblRoomNumber.Name = "LblRoomNumber"
        Me.LblRoomNumber.Size = New System.Drawing.Size(117, 16)
        Me.LblRoomNumber.TabIndex = 15
        Me.LblRoomNumber.Text = "Numéro Chambre"
        '
        'LblRoomStatus
        '
        Me.LblRoomStatus.AutoSize = True
        Me.LblRoomStatus.Location = New System.Drawing.Point(458, -1)
        Me.LblRoomStatus.Name = "LblRoomStatus"
        Me.LblRoomStatus.Size = New System.Drawing.Size(31, 16)
        Me.LblRoomStatus.TabIndex = 19
        Me.LblRoomStatus.Text = "Etat"
        '
        'CmbRoomStatus
        '
        Me.CmbRoomStatus.FormattingEnabled = True
        Me.CmbRoomStatus.Location = New System.Drawing.Point(461, 18)
        Me.CmbRoomStatus.Name = "CmbRoomStatus"
        Me.CmbRoomStatus.Size = New System.Drawing.Size(121, 24)
        Me.CmbRoomStatus.TabIndex = 20
        '
        'LblRoomPrice
        '
        Me.LblRoomPrice.AutoSize = True
        Me.LblRoomPrice.Location = New System.Drawing.Point(302, -1)
        Me.LblRoomPrice.Name = "LblRoomPrice"
        Me.LblRoomPrice.Size = New System.Drawing.Size(120, 16)
        Me.LblRoomPrice.TabIndex = 18
        Me.LblRoomPrice.Text = "Prix Chambre/Nuit"
        '
        'LblRoomType
        '
        Me.LblRoomType.AutoSize = True
        Me.LblRoomType.Location = New System.Drawing.Point(145, 0)
        Me.LblRoomType.Name = "LblRoomType"
        Me.LblRoomType.Size = New System.Drawing.Size(96, 16)
        Me.LblRoomType.TabIndex = 16
        Me.LblRoomType.Text = "Type Chambre"
        '
        'TxtRoomPriceInt
        '
        Me.TxtRoomPriceInt.Location = New System.Drawing.Point(305, 18)
        Me.TxtRoomPriceInt.Name = "TxtRoomPriceInt"
        Me.TxtRoomPriceInt.Size = New System.Drawing.Size(69, 23)
        Me.TxtRoomPriceInt.TabIndex = 14
        '
        'TxtRoomNumber
        '
        Me.TxtRoomNumber.Location = New System.Drawing.Point(2, 19)
        Me.TxtRoomNumber.Name = "TxtRoomNumber"
        Me.TxtRoomNumber.Size = New System.Drawing.Size(114, 23)
        Me.TxtRoomNumber.TabIndex = 12
        '
        'CmbRoomType
        '
        Me.CmbRoomType.FormattingEnabled = True
        Me.CmbRoomType.Location = New System.Drawing.Point(148, 18)
        Me.CmbRoomType.Name = "CmbRoomType"
        Me.CmbRoomType.Size = New System.Drawing.Size(121, 24)
        Me.CmbRoomType.TabIndex = 17
        '
        'FormManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 515)
        Me.Controls.Add(Me.PnlMain)
        Me.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormGestionnaire"
        Me.PnlUserInfo.ResumeLayout(False)
        Me.PnlUserInfo.PerformLayout()
        CType(Me.PtbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMain.ResumeLayout(False)
        Me.PnlManageReservations.ResumeLayout(False)
        Me.PnlManageReservations.PerformLayout()
        Me.PnlFilterSearch.ResumeLayout(False)
        Me.PnlFilterSearch.PerformLayout()
        Me.GrpLogs.ResumeLayout(False)
        Me.GrpLogs.PerformLayout()
        CType(Me.DGVShowData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSidebar.ResumeLayout(False)
        Me.GrpSidebar.PerformLayout()
        Me.PnlManageRooms.ResumeLayout(False)
        Me.PnlManageRooms.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblWelcome As System.Windows.Forms.Label
    Friend WithEvents LblRole As System.Windows.Forms.Label
    Friend WithEvents PnlUserInfo As System.Windows.Forms.Panel
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents BtnDashboard As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnStatistics As System.Windows.Forms.Button
    Friend WithEvents BtnManagePayments As System.Windows.Forms.Button
    Friend WithEvents BtnManageClients As System.Windows.Forms.Button
    Friend WithEvents BtnManageReservation As System.Windows.Forms.Button
    Friend WithEvents BtnManageRooms As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents DGVShowData As System.Windows.Forms.DataGridView
    Friend WithEvents PtbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents GrpSidebar As System.Windows.Forms.GroupBox
    Friend WithEvents GrpLogs As System.Windows.Forms.GroupBox
    Friend WithEvents LblLastLogs As System.Windows.Forms.Label
    Friend WithEvents BtnAddPicture As System.Windows.Forms.Button
    Friend WithEvents CmbRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents LblRoomType As System.Windows.Forms.Label
    Friend WithEvents LblRoomNumber As System.Windows.Forms.Label
    Friend WithEvents TxtRoomPriceInt As System.Windows.Forms.TextBox
    Friend WithEvents TxtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents LblRoomPrice As System.Windows.Forms.Label
    Friend WithEvents CmbRoomStatus As System.Windows.Forms.ComboBox
    Friend WithEvents LblRoomStatus As System.Windows.Forms.Label
    Friend WithEvents BtnAddRoom As System.Windows.Forms.Button
    Friend WithEvents PnlManageRooms As System.Windows.Forms.Panel
    Friend WithEvents TxtRoomPriceFloat As System.Windows.Forms.TextBox
    Friend WithEvents LblRoomPriceDot As System.Windows.Forms.Label
    Friend WithEvents BtnRoomDelete As System.Windows.Forms.Button
    Friend WithEvents BtnRoomUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnRoomSearch As System.Windows.Forms.Button
    Friend WithEvents RtbLogs As System.Windows.Forms.RichTextBox
    Friend WithEvents PnlFilterSearch As System.Windows.Forms.Panel
    Friend WithEvents RdbByNumber As System.Windows.Forms.RadioButton
    Friend WithEvents RdbByStatus As System.Windows.Forms.RadioButton
    Friend WithEvents RdbByType As System.Windows.Forms.RadioButton
    Friend WithEvents RdbByPrice As System.Windows.Forms.RadioButton
    Friend WithEvents LblSearchByTitle As System.Windows.Forms.Label
    Friend WithEvents PnlManageReservations As System.Windows.Forms.Panel
    Friend WithEvents BtnReservationAdd As System.Windows.Forms.Button
    Friend WithEvents LblReservationClientName As System.Windows.Forms.Label
    Friend WithEvents LblOutDate As System.Windows.Forms.Label
    Friend WithEvents LblInDate As System.Windows.Forms.Label
    Friend WithEvents LblReservationRoomNumber As System.Windows.Forms.Label
    Friend WithEvents TxtReservationClientName As System.Windows.Forms.TextBox
    Friend WithEvents CmbReservationRoomNumber As System.Windows.Forms.ComboBox
    Friend WithEvents DtpCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpCheckIn As System.Windows.Forms.DateTimePicker
End Class
