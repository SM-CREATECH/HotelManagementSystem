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
        Me.PtbProfile = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LsbHistorical = New System.Windows.Forms.ListBox()
        Me.LblActus = New System.Windows.Forms.Label()
        Me.DGVShowData = New System.Windows.Forms.DataGridView()
        Me.GrpSidebar = New System.Windows.Forms.GroupBox()
        Me.BtnManagePayments = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnStatistics = New System.Windows.Forms.Button()
        Me.BtnManageRooms = New System.Windows.Forms.Button()
        Me.BtnManageClients = New System.Windows.Forms.Button()
        Me.BtnManageReservation = New System.Windows.Forms.Button()
        Me.BtnAddPicture = New System.Windows.Forms.Button()
        Me.PnlUserInfo.SuspendLayout()
        CType(Me.PtbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVShowData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSidebar.SuspendLayout()
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
        Me.PnlUserInfo.Location = New System.Drawing.Point(242, 9)
        Me.PnlUserInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlUserInfo.Name = "PnlUserInfo"
        Me.PnlUserInfo.Size = New System.Drawing.Size(593, 100)
        Me.PnlUserInfo.TabIndex = 2
        '
        'PtbProfile
        '
        Me.PtbProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PtbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PtbProfile.Location = New System.Drawing.Point(495, 2)
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
        Me.PnlMain.Controls.Add(Me.GroupBox1)
        Me.PnlMain.Controls.Add(Me.DGVShowData)
        Me.PnlMain.Controls.Add(Me.PnlUserInfo)
        Me.PnlMain.Controls.Add(Me.GrpSidebar)
        Me.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlMain.Location = New System.Drawing.Point(0, 0)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(1078, 515)
        Me.PnlMain.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LsbHistorical)
        Me.GroupBox1.Controls.Add(Me.LblActus)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(844, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 515)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'LsbHistorical
        '
        Me.LsbHistorical.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LsbHistorical.FormattingEnabled = True
        Me.LsbHistorical.ItemHeight = 16
        Me.LsbHistorical.Location = New System.Drawing.Point(6, 147)
        Me.LsbHistorical.Name = "LsbHistorical"
        Me.LsbHistorical.Size = New System.Drawing.Size(222, 372)
        Me.LsbHistorical.TabIndex = 1
        '
        'LblActus
        '
        Me.LblActus.AutoSize = True
        Me.LblActus.Font = New System.Drawing.Font("Futura Md BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActus.Location = New System.Drawing.Point(5, 19)
        Me.LblActus.Name = "LblActus"
        Me.LblActus.Size = New System.Drawing.Size(155, 38)
        Me.LblActus.TabIndex = 0
        Me.LblActus.Text = "Dernières actions " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "du gestionnaire"
        Me.LblActus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGVShowData
        '
        Me.DGVShowData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVShowData.Location = New System.Drawing.Point(242, 153)
        Me.DGVShowData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGVShowData.Name = "DGVShowData"
        Me.DGVShowData.Size = New System.Drawing.Size(590, 350)
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
        'BtnAddPicture
        '
        Me.BtnAddPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddPicture.Location = New System.Drawing.Point(356, 65)
        Me.BtnAddPicture.Name = "BtnAddPicture"
        Me.BtnAddPicture.Size = New System.Drawing.Size(133, 23)
        Me.BtnAddPicture.TabIndex = 3
        Me.BtnAddPicture.Text = "Ajouter une photo"
        Me.BtnAddPicture.UseVisualStyleBackColor = True
        '
        'FormManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 515)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVShowData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSidebar.ResumeLayout(False)
        Me.GrpSidebar.PerformLayout()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblActus As System.Windows.Forms.Label
    Friend WithEvents LsbHistorical As System.Windows.Forms.ListBox
    Friend WithEvents BtnAddPicture As System.Windows.Forms.Button
End Class
