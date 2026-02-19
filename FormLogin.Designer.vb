<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LblSGH = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblRegister = New System.Windows.Forms.Label()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.TLPUsername = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TLPPassword = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPNotHaveAccount = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPUsername.SuspendLayout()
        Me.TLPPassword.SuspendLayout()
        Me.TLPNotHaveAccount.SuspendLayout()
        Me.TLPButtons.SuspendLayout()
        Me.TLPContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSGH
        '
        Me.LblSGH.AutoSize = True
        Me.LblSGH.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblSGH.Font = New System.Drawing.Font("Futura Md BT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSGH.Location = New System.Drawing.Point(3, 0)
        Me.LblSGH.Name = "LblSGH"
        Me.LblSGH.Size = New System.Drawing.Size(508, 42)
        Me.LblSGH.TabIndex = 0
        Me.LblSGH.Text = "Système de Gestion d’Hôtel"
        Me.LblSGH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblPassword.Location = New System.Drawing.Point(3, 15)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(502, 13)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Mot de passe"
        '
        'BtnLogin
        '
        Me.BtnLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLogin.Location = New System.Drawing.Point(3, 3)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(248, 29)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Se Connecter"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnExit.Location = New System.Drawing.Point(257, 3)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(248, 29)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Quitter"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(3, 31)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(502, 20)
        Me.TxtPassword.TabIndex = 6
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'LblRegister
        '
        Me.LblRegister.AutoSize = True
        Me.LblRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblRegister.Location = New System.Drawing.Point(3, 0)
        Me.LblRegister.Name = "LblRegister"
        Me.LblRegister.Size = New System.Drawing.Size(248, 41)
        Me.LblRegister.TabIndex = 7
        Me.LblRegister.Text = "Vous n'avez pas encore de compte ?"
        Me.LblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRegister.FlatAppearance.BorderSize = 0
        Me.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.ForeColor = System.Drawing.Color.Blue
        Me.BtnRegister.Location = New System.Drawing.Point(257, 3)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(248, 35)
        Me.BtnRegister.TabIndex = 8
        Me.BtnRegister.Text = "Créer un compte gratuitement."
        Me.BtnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblUsername.Location = New System.Drawing.Point(3, 15)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(502, 13)
        Me.LblUsername.TabIndex = 9
        Me.LblUsername.Text = "Nom d'utilisateur"
        '
        'TLPUsername
        '
        Me.TLPUsername.ColumnCount = 1
        Me.TLPUsername.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPUsername.Controls.Add(Me.LblUsername, 0, 0)
        Me.TLPUsername.Controls.Add(Me.TxtUsername, 0, 1)
        Me.TLPUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPUsername.Location = New System.Drawing.Point(3, 98)
        Me.TLPUsername.Name = "TLPUsername"
        Me.TLPUsername.RowCount = 2
        Me.TLPUsername.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPUsername.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPUsername.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPUsername.Size = New System.Drawing.Size(508, 57)
        Me.TLPUsername.TabIndex = 0
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(3, 31)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(502, 20)
        Me.TxtUsername.TabIndex = 5
        '
        'TLPPassword
        '
        Me.TLPPassword.ColumnCount = 1
        Me.TLPPassword.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPPassword.Controls.Add(Me.LblPassword, 0, 0)
        Me.TLPPassword.Controls.Add(Me.TxtPassword, 0, 1)
        Me.TLPPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPPassword.Location = New System.Drawing.Point(3, 161)
        Me.TLPPassword.Name = "TLPPassword"
        Me.TLPPassword.RowCount = 2
        Me.TLPPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPPassword.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPPassword.Size = New System.Drawing.Size(508, 57)
        Me.TLPPassword.TabIndex = 9
        '
        'TLPNotHaveAccount
        '
        Me.TLPNotHaveAccount.ColumnCount = 2
        Me.TLPNotHaveAccount.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPNotHaveAccount.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPNotHaveAccount.Controls.Add(Me.BtnRegister, 1, 0)
        Me.TLPNotHaveAccount.Controls.Add(Me.LblRegister, 0, 0)
        Me.TLPNotHaveAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPNotHaveAccount.Location = New System.Drawing.Point(3, 224)
        Me.TLPNotHaveAccount.Name = "TLPNotHaveAccount"
        Me.TLPNotHaveAccount.RowCount = 1
        Me.TLPNotHaveAccount.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPNotHaveAccount.Size = New System.Drawing.Size(508, 41)
        Me.TLPNotHaveAccount.TabIndex = 10
        '
        'TLPButtons
        '
        Me.TLPButtons.ColumnCount = 2
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtons.Controls.Add(Me.BtnLogin, 0, 0)
        Me.TLPButtons.Controls.Add(Me.BtnExit, 1, 0)
        Me.TLPButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLPButtons.Location = New System.Drawing.Point(3, 279)
        Me.TLPButtons.Name = "TLPButtons"
        Me.TLPButtons.RowCount = 1
        Me.TLPButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TLPButtons.Size = New System.Drawing.Size(508, 35)
        Me.TLPButtons.TabIndex = 11
        '
        'TLPContainer
        '
        Me.TLPContainer.ColumnCount = 1
        Me.TLPContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPContainer.Controls.Add(Me.LblSGH, 0, 0)
        Me.TLPContainer.Controls.Add(Me.TLPUsername, 0, 1)
        Me.TLPContainer.Controls.Add(Me.TLPNotHaveAccount, 0, 3)
        Me.TLPContainer.Controls.Add(Me.TLPPassword, 0, 2)
        Me.TLPContainer.Controls.Add(Me.TLPButtons, 0, 4)
        Me.TLPContainer.Location = New System.Drawing.Point(106, 47)
        Me.TLPContainer.Name = "TLPContainer"
        Me.TLPContainer.RowCount = 5
        Me.TLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TLPContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TLPContainer.Size = New System.Drawing.Size(514, 317)
        Me.TLPContainer.TabIndex = 12
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 396)
        Me.Controls.Add(Me.TLPContainer)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire de Connexion"
        Me.TLPUsername.ResumeLayout(False)
        Me.TLPUsername.PerformLayout()
        Me.TLPPassword.ResumeLayout(False)
        Me.TLPPassword.PerformLayout()
        Me.TLPNotHaveAccount.ResumeLayout(False)
        Me.TLPNotHaveAccount.PerformLayout()
        Me.TLPButtons.ResumeLayout(False)
        Me.TLPContainer.ResumeLayout(False)
        Me.TLPContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblSGH As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblRegister As System.Windows.Forms.Label
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents TLPUsername As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TLPPassword As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLPNotHaveAccount As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLPButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLPContainer As System.Windows.Forms.TableLayoutPanel

End Class
