<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrator
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
        Me.GrpSidebar = New System.Windows.Forms.GroupBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnManagePayments = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnStatistics = New System.Windows.Forms.Button()
        Me.BtnManageUsers = New System.Windows.Forms.Button()
        Me.BtnSaveRestoreDB = New System.Windows.Forms.Button()
        Me.BtnManageUsersRoles = New System.Windows.Forms.Button()
        Me.PnlUserInfo = New System.Windows.Forms.Panel()
        Me.BtnAddPicture = New System.Windows.Forms.Button()
        Me.PtbProfile = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRole = New System.Windows.Forms.Label()
        Me.GrpLogs = New System.Windows.Forms.GroupBox()
        Me.RtbLogs = New System.Windows.Forms.RichTextBox()
        Me.LblLastLogs = New System.Windows.Forms.Label()
        Me.DGVShowData = New System.Windows.Forms.DataGridView()
        Me.PnlManageUsers = New System.Windows.Forms.Panel()
        Me.BtnUserSearch = New System.Windows.Forms.Button()
        Me.BtnUserDelete = New System.Windows.Forms.Button()
        Me.BtnUserUpdate = New System.Windows.Forms.Button()
        Me.BtnAddUser = New System.Windows.Forms.Button()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblUserRole = New System.Windows.Forms.Label()
        Me.CmbUserRole = New System.Windows.Forms.ComboBox()
        Me.LblPasswordConfirm = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.GrpSidebar.SuspendLayout()
        Me.PnlUserInfo.SuspendLayout()
        CType(Me.PtbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpLogs.SuspendLayout()
        CType(Me.DGVShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlManageUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.Location = New System.Drawing.Point(36, 37)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(0, 13)
        Me.LblWelcome.TabIndex = 0
        '
        'GrpSidebar
        '
        Me.GrpSidebar.Controls.Add(Me.BtnLogout)
        Me.GrpSidebar.Controls.Add(Me.BtnManagePayments)
        Me.GrpSidebar.Controls.Add(Me.BtnDashboard)
        Me.GrpSidebar.Controls.Add(Me.LblTitle)
        Me.GrpSidebar.Controls.Add(Me.BtnStatistics)
        Me.GrpSidebar.Controls.Add(Me.BtnManageUsers)
        Me.GrpSidebar.Controls.Add(Me.BtnSaveRestoreDB)
        Me.GrpSidebar.Controls.Add(Me.BtnManageUsersRoles)
        Me.GrpSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.GrpSidebar.Location = New System.Drawing.Point(0, 0)
        Me.GrpSidebar.Name = "GrpSidebar"
        Me.GrpSidebar.Size = New System.Drawing.Size(234, 505)
        Me.GrpSidebar.TabIndex = 11
        Me.GrpSidebar.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(9, 465)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(217, 28)
        Me.BtnLogout.TabIndex = 6
        Me.BtnLogout.Text = "Se Déconnecter"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnManagePayments
        '
        Me.BtnManagePayments.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnManagePayments.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManagePayments.Location = New System.Drawing.Point(9, 292)
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
        Me.BtnDashboard.Location = New System.Drawing.Point(9, 429)
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
        Me.BtnStatistics.Location = New System.Drawing.Point(9, 256)
        Me.BtnStatistics.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnStatistics.Name = "BtnStatistics"
        Me.BtnStatistics.Size = New System.Drawing.Size(217, 28)
        Me.BtnStatistics.TabIndex = 5
        Me.BtnStatistics.Text = "Statistiques"
        Me.BtnStatistics.UseVisualStyleBackColor = True
        '
        'BtnManageUsers
        '
        Me.BtnManageUsers.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnManageUsers.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageUsers.Location = New System.Drawing.Point(9, 148)
        Me.BtnManageUsers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnManageUsers.Name = "BtnManageUsers"
        Me.BtnManageUsers.Size = New System.Drawing.Size(217, 28)
        Me.BtnManageUsers.TabIndex = 1
        Me.BtnManageUsers.Text = "Gérer Utilisateurs"
        Me.BtnManageUsers.UseVisualStyleBackColor = True
        '
        'BtnSaveRestoreDB
        '
        Me.BtnSaveRestoreDB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnSaveRestoreDB.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveRestoreDB.Location = New System.Drawing.Point(9, 220)
        Me.BtnSaveRestoreDB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSaveRestoreDB.Name = "BtnSaveRestoreDB"
        Me.BtnSaveRestoreDB.Size = New System.Drawing.Size(217, 28)
        Me.BtnSaveRestoreDB.TabIndex = 3
        Me.BtnSaveRestoreDB.Text = "Sauvegarder / Restaurer La Base"
        Me.BtnSaveRestoreDB.UseVisualStyleBackColor = True
        '
        'BtnManageUsersRoles
        '
        Me.BtnManageUsersRoles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnManageUsersRoles.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManageUsersRoles.Location = New System.Drawing.Point(9, 184)
        Me.BtnManageUsersRoles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnManageUsersRoles.Name = "BtnManageUsersRoles"
        Me.BtnManageUsersRoles.Size = New System.Drawing.Size(217, 28)
        Me.BtnManageUsersRoles.TabIndex = 2
        Me.BtnManageUsersRoles.Text = "Gérer Rôles Utilisateurs"
        Me.BtnManageUsersRoles.UseVisualStyleBackColor = True
        '
        'PnlUserInfo
        '
        Me.PnlUserInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUserInfo.Controls.Add(Me.BtnAddPicture)
        Me.PnlUserInfo.Controls.Add(Me.PtbProfile)
        Me.PnlUserInfo.Controls.Add(Me.Label1)
        Me.PnlUserInfo.Controls.Add(Me.LblRole)
        Me.PnlUserInfo.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlUserInfo.Location = New System.Drawing.Point(240, 13)
        Me.PnlUserInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlUserInfo.Name = "PnlUserInfo"
        Me.PnlUserInfo.Size = New System.Drawing.Size(591, 100)
        Me.PnlUserInfo.TabIndex = 12
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Message de Bienvenue"
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
        'GrpLogs
        '
        Me.GrpLogs.Controls.Add(Me.RtbLogs)
        Me.GrpLogs.Controls.Add(Me.LblLastLogs)
        Me.GrpLogs.Dock = System.Windows.Forms.DockStyle.Right
        Me.GrpLogs.Location = New System.Drawing.Point(842, 0)
        Me.GrpLogs.Name = "GrpLogs"
        Me.GrpLogs.Size = New System.Drawing.Size(234, 505)
        Me.GrpLogs.TabIndex = 13
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
        Me.RtbLogs.Size = New System.Drawing.Size(222, 354)
        Me.RtbLogs.TabIndex = 2
        Me.RtbLogs.Text = ""
        '
        'LblLastLogs
        '
        Me.LblLastLogs.AutoSize = True
        Me.LblLastLogs.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastLogs.Location = New System.Drawing.Point(5, 19)
        Me.LblLastLogs.Name = "LblLastLogs"
        Me.LblLastLogs.Size = New System.Drawing.Size(165, 38)
        Me.LblLastLogs.TabIndex = 0
        Me.LblLastLogs.Text = "Dernières actions " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de l'administrateur"
        Me.LblLastLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGVShowData
        '
        Me.DGVShowData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVShowData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGVShowData.Location = New System.Drawing.Point(246, 273)
        Me.DGVShowData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGVShowData.Name = "DGVShowData"
        Me.DGVShowData.ReadOnly = True
        Me.DGVShowData.Size = New System.Drawing.Size(588, 219)
        Me.DGVShowData.TabIndex = 14
        '
        'PnlManageUsers
        '
        Me.PnlManageUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlManageUsers.Controls.Add(Me.TxtPassword)
        Me.PnlManageUsers.Controls.Add(Me.BtnUserSearch)
        Me.PnlManageUsers.Controls.Add(Me.BtnUserDelete)
        Me.PnlManageUsers.Controls.Add(Me.BtnUserUpdate)
        Me.PnlManageUsers.Controls.Add(Me.BtnAddUser)
        Me.PnlManageUsers.Controls.Add(Me.LblUsername)
        Me.PnlManageUsers.Controls.Add(Me.LblUserRole)
        Me.PnlManageUsers.Controls.Add(Me.CmbUserRole)
        Me.PnlManageUsers.Controls.Add(Me.LblPasswordConfirm)
        Me.PnlManageUsers.Controls.Add(Me.LblPassword)
        Me.PnlManageUsers.Controls.Add(Me.TxtPasswordConfirm)
        Me.PnlManageUsers.Controls.Add(Me.TxtUsername)
        Me.PnlManageUsers.Location = New System.Drawing.Point(240, 120)
        Me.PnlManageUsers.Name = "PnlManageUsers"
        Me.PnlManageUsers.Size = New System.Drawing.Size(588, 84)
        Me.PnlManageUsers.TabIndex = 22
        Me.PnlManageUsers.Visible = False
        '
        'BtnUserSearch
        '
        Me.BtnUserSearch.Location = New System.Drawing.Point(294, 56)
        Me.BtnUserSearch.Name = "BtnUserSearch"
        Me.BtnUserSearch.Size = New System.Drawing.Size(147, 23)
        Me.BtnUserSearch.TabIndex = 26
        Me.BtnUserSearch.Text = "Rechercher utilisateur"
        Me.BtnUserSearch.UseVisualStyleBackColor = True
        '
        'BtnUserDelete
        '
        Me.BtnUserDelete.Location = New System.Drawing.Point(447, 56)
        Me.BtnUserDelete.Name = "BtnUserDelete"
        Me.BtnUserDelete.Size = New System.Drawing.Size(135, 23)
        Me.BtnUserDelete.TabIndex = 25
        Me.BtnUserDelete.Text = "Supprimer utilisateur"
        Me.BtnUserDelete.UseVisualStyleBackColor = True
        '
        'BtnUserUpdate
        '
        Me.BtnUserUpdate.Location = New System.Drawing.Point(166, 56)
        Me.BtnUserUpdate.Name = "BtnUserUpdate"
        Me.BtnUserUpdate.Size = New System.Drawing.Size(122, 23)
        Me.BtnUserUpdate.TabIndex = 24
        Me.BtnUserUpdate.Text = "Modifier utilisateur"
        Me.BtnUserUpdate.UseVisualStyleBackColor = True
        '
        'BtnAddUser
        '
        Me.BtnAddUser.Location = New System.Drawing.Point(42, 56)
        Me.BtnAddUser.Name = "BtnAddUser"
        Me.BtnAddUser.Size = New System.Drawing.Size(118, 23)
        Me.BtnAddUser.TabIndex = 22
        Me.BtnAddUser.Text = "Ajouter utilisateur"
        Me.BtnAddUser.UseVisualStyleBackColor = True
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(-3, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(78, 13)
        Me.LblUsername.TabIndex = 15
        Me.LblUsername.Text = "Nom Utilisateur"
        '
        'LblUserRole
        '
        Me.LblUserRole.AutoSize = True
        Me.LblUserRole.Location = New System.Drawing.Point(458, 0)
        Me.LblUserRole.Name = "LblUserRole"
        Me.LblUserRole.Size = New System.Drawing.Size(95, 13)
        Me.LblUserRole.TabIndex = 19
        Me.LblUserRole.Text = "Rôle de l'utilisateur"
        '
        'CmbUserRole
        '
        Me.CmbUserRole.FormattingEnabled = True
        Me.CmbUserRole.Location = New System.Drawing.Point(461, 18)
        Me.CmbUserRole.Name = "CmbUserRole"
        Me.CmbUserRole.Size = New System.Drawing.Size(121, 21)
        Me.CmbUserRole.TabIndex = 20
        '
        'LblPasswordConfirm
        '
        Me.LblPasswordConfirm.AutoSize = True
        Me.LblPasswordConfirm.Location = New System.Drawing.Point(295, 0)
        Me.LblPasswordConfirm.Name = "LblPasswordConfirm"
        Me.LblPasswordConfirm.Size = New System.Drawing.Size(146, 13)
        Me.LblPasswordConfirm.TabIndex = 18
        Me.LblPasswordConfirm.Text = "Mot de passe de confirmation"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(132, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(71, 13)
        Me.LblPassword.TabIndex = 16
        Me.LblPassword.Text = "Mot de passe"
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(298, 19)
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(143, 20)
        Me.TxtPasswordConfirm.TabIndex = 14
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(3, 19)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(114, 20)
        Me.TxtUsername.TabIndex = 12
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(135, 19)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(143, 20)
        Me.TxtPassword.TabIndex = 23
        '
        'FormAdministrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 505)
        Me.Controls.Add(Me.PnlManageUsers)
        Me.Controls.Add(Me.DGVShowData)
        Me.Controls.Add(Me.GrpLogs)
        Me.Controls.Add(Me.PnlUserInfo)
        Me.Controls.Add(Me.GrpSidebar)
        Me.Controls.Add(Me.LblWelcome)
        Me.Name = "FormAdministrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdmin"
        Me.GrpSidebar.ResumeLayout(False)
        Me.GrpSidebar.PerformLayout()
        Me.PnlUserInfo.ResumeLayout(False)
        Me.PnlUserInfo.PerformLayout()
        CType(Me.PtbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpLogs.ResumeLayout(False)
        Me.GrpLogs.PerformLayout()
        CType(Me.DGVShowData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlManageUsers.ResumeLayout(False)
        Me.PnlManageUsers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblWelcome As System.Windows.Forms.Label
    Friend WithEvents GrpSidebar As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnManagePayments As System.Windows.Forms.Button
    Friend WithEvents BtnDashboard As System.Windows.Forms.Button
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents BtnStatistics As System.Windows.Forms.Button
    Friend WithEvents BtnManageUsers As System.Windows.Forms.Button
    Friend WithEvents BtnSaveRestoreDB As System.Windows.Forms.Button
    Friend WithEvents BtnManageUsersRoles As System.Windows.Forms.Button
    Friend WithEvents PnlUserInfo As System.Windows.Forms.Panel
    Friend WithEvents BtnAddPicture As System.Windows.Forms.Button
    Friend WithEvents PtbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblRole As System.Windows.Forms.Label
    Friend WithEvents GrpLogs As System.Windows.Forms.GroupBox
    Friend WithEvents RtbLogs As System.Windows.Forms.RichTextBox
    Friend WithEvents LblLastLogs As System.Windows.Forms.Label
    Friend WithEvents DGVShowData As System.Windows.Forms.DataGridView
    Friend WithEvents PnlManageUsers As System.Windows.Forms.Panel
    Friend WithEvents BtnUserSearch As System.Windows.Forms.Button
    Friend WithEvents BtnUserDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUserUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAddUser As System.Windows.Forms.Button
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents LblUserRole As System.Windows.Forms.Label
    Friend WithEvents CmbUserRole As System.Windows.Forms.ComboBox
    Friend WithEvents LblPasswordConfirm As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtPasswordConfirm As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
End Class
