<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Me.LblUsernameRegister = New System.Windows.Forms.Label()
        Me.LblPasswordRegister = New System.Windows.Forms.Label()
        Me.LblRoleRegister = New System.Windows.Forms.Label()
        Me.CmbRole = New System.Windows.Forms.ComboBox()
        Me.TxtUsernameRegister = New System.Windows.Forms.TextBox()
        Me.TxtPasswordRegister = New System.Windows.Forms.TextBox()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.BtnBackRegister = New System.Windows.Forms.Button()
        Me.TLPContainerRegister = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblPasswordConfirm = New System.Windows.Forms.Label()
        Me.TxtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.LblRegisterInAllSecurity = New System.Windows.Forms.Label()
        Me.TLPPasswordRegister = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPUsernameAndRole = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPButtonsRegister = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPContainerRegister.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TLPPasswordRegister.SuspendLayout()
        Me.TLPUsernameAndRole.SuspendLayout()
        Me.TLPButtonsRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUsernameRegister
        '
        Me.LblUsernameRegister.AutoSize = True
        Me.LblUsernameRegister.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblUsernameRegister.Location = New System.Drawing.Point(3, 36)
        Me.LblUsernameRegister.Name = "LblUsernameRegister"
        Me.LblUsernameRegister.Size = New System.Drawing.Size(291, 13)
        Me.LblUsernameRegister.TabIndex = 0
        Me.LblUsernameRegister.Text = "Nom d'utilisateur"
        '
        'LblPasswordRegister
        '
        Me.LblPasswordRegister.AutoSize = True
        Me.LblPasswordRegister.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblPasswordRegister.Location = New System.Drawing.Point(3, 8)
        Me.LblPasswordRegister.Name = "LblPasswordRegister"
        Me.LblPasswordRegister.Size = New System.Drawing.Size(589, 13)
        Me.LblPasswordRegister.TabIndex = 1
        Me.LblPasswordRegister.Text = "Mot de passe"
        '
        'LblRoleRegister
        '
        Me.LblRoleRegister.AutoSize = True
        Me.LblRoleRegister.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblRoleRegister.Location = New System.Drawing.Point(300, 36)
        Me.LblRoleRegister.Name = "LblRoleRegister"
        Me.LblRoleRegister.Size = New System.Drawing.Size(292, 13)
        Me.LblRoleRegister.TabIndex = 2
        Me.LblRoleRegister.Text = "Rôle"
        '
        'CmbRole
        '
        Me.CmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRole.FormattingEnabled = True
        Me.CmbRole.Items.AddRange(New Object() {"Faire un choix"})
        Me.CmbRole.Location = New System.Drawing.Point(300, 52)
        Me.CmbRole.Name = "CmbRole"
        Me.CmbRole.Size = New System.Drawing.Size(292, 21)
        Me.CmbRole.TabIndex = 3
        '
        'TxtUsernameRegister
        '
        Me.TxtUsernameRegister.Location = New System.Drawing.Point(3, 52)
        Me.TxtUsernameRegister.Name = "TxtUsernameRegister"
        Me.TxtUsernameRegister.Size = New System.Drawing.Size(291, 20)
        Me.TxtUsernameRegister.TabIndex = 4
        '
        'TxtPasswordRegister
        '
        Me.TxtPasswordRegister.Location = New System.Drawing.Point(3, 24)
        Me.TxtPasswordRegister.Name = "TxtPasswordRegister"
        Me.TxtPasswordRegister.Size = New System.Drawing.Size(589, 20)
        Me.TxtPasswordRegister.TabIndex = 5
        Me.TxtPasswordRegister.UseSystemPasswordChar = True
        '
        'BtnRegister
        '
        Me.BtnRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRegister.Location = New System.Drawing.Point(3, 3)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(291, 29)
        Me.BtnRegister.TabIndex = 6
        Me.BtnRegister.Text = "S'inscrire"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'BtnBackRegister
        '
        Me.BtnBackRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBackRegister.Location = New System.Drawing.Point(300, 3)
        Me.BtnBackRegister.Name = "BtnBackRegister"
        Me.BtnBackRegister.Size = New System.Drawing.Size(292, 29)
        Me.BtnBackRegister.TabIndex = 7
        Me.BtnBackRegister.Text = "Retour"
        Me.BtnBackRegister.UseVisualStyleBackColor = True
        '
        'TLPContainerRegister
        '
        Me.TLPContainerRegister.ColumnCount = 1
        Me.TLPContainerRegister.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPContainerRegister.Controls.Add(Me.TableLayoutPanel1, 0, 3)
        Me.TLPContainerRegister.Controls.Add(Me.LblRegisterInAllSecurity, 0, 0)
        Me.TLPContainerRegister.Controls.Add(Me.TLPPasswordRegister, 0, 2)
        Me.TLPContainerRegister.Controls.Add(Me.TLPUsernameAndRole, 0, 1)
        Me.TLPContainerRegister.Controls.Add(Me.TLPButtonsRegister, 0, 4)
        Me.TLPContainerRegister.Location = New System.Drawing.Point(73, 29)
        Me.TLPContainerRegister.Name = "TLPContainerRegister"
        Me.TLPContainerRegister.RowCount = 5
        Me.TLPContainerRegister.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPContainerRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.78595!))
        Me.TLPContainerRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58064!))
        Me.TLPContainerRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.93548!))
        Me.TLPContainerRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.32258!))
        Me.TLPContainerRegister.Size = New System.Drawing.Size(601, 352)
        Me.TLPContainerRegister.TabIndex = 8
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LblPasswordConfirm, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPasswordConfirm, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 224)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(595, 61)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'LblPasswordConfirm
        '
        Me.LblPasswordConfirm.AutoSize = True
        Me.LblPasswordConfirm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblPasswordConfirm.Location = New System.Drawing.Point(3, 17)
        Me.LblPasswordConfirm.Name = "LblPasswordConfirm"
        Me.LblPasswordConfirm.Size = New System.Drawing.Size(589, 13)
        Me.LblPasswordConfirm.TabIndex = 1
        Me.LblPasswordConfirm.Text = "Mot de passe de confirmation"
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(3, 33)
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(589, 20)
        Me.TxtPasswordConfirm.TabIndex = 5
        Me.TxtPasswordConfirm.UseSystemPasswordChar = True
        '
        'LblRegisterInAllSecurity
        '
        Me.LblRegisterInAllSecurity.AutoSize = True
        Me.LblRegisterInAllSecurity.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblRegisterInAllSecurity.Font = New System.Drawing.Font("Futura Md BT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegisterInAllSecurity.Location = New System.Drawing.Point(3, 0)
        Me.LblRegisterInAllSecurity.Name = "LblRegisterInAllSecurity"
        Me.LblRegisterInAllSecurity.Size = New System.Drawing.Size(595, 42)
        Me.LblRegisterInAllSecurity.TabIndex = 11
        Me.LblRegisterInAllSecurity.Text = "Inscrivez-vous en toute sécurité"
        Me.LblRegisterInAllSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TLPPasswordRegister
        '
        Me.TLPPasswordRegister.ColumnCount = 1
        Me.TLPPasswordRegister.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPPasswordRegister.Controls.Add(Me.LblPasswordRegister, 0, 0)
        Me.TLPPasswordRegister.Controls.Add(Me.TxtPasswordRegister, 0, 1)
        Me.TLPPasswordRegister.Location = New System.Drawing.Point(3, 155)
        Me.TLPPasswordRegister.Name = "TLPPasswordRegister"
        Me.TLPPasswordRegister.RowCount = 3
        Me.TLPPasswordRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPPasswordRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPPasswordRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPPasswordRegister.Size = New System.Drawing.Size(595, 63)
        Me.TLPPasswordRegister.TabIndex = 10
        '
        'TLPUsernameAndRole
        '
        Me.TLPUsernameAndRole.ColumnCount = 2
        Me.TLPUsernameAndRole.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPUsernameAndRole.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPUsernameAndRole.Controls.Add(Me.TxtUsernameRegister, 0, 1)
        Me.TLPUsernameAndRole.Controls.Add(Me.LblUsernameRegister, 0, 0)
        Me.TLPUsernameAndRole.Controls.Add(Me.LblRoleRegister, 1, 0)
        Me.TLPUsernameAndRole.Controls.Add(Me.CmbRole, 1, 1)
        Me.TLPUsernameAndRole.Location = New System.Drawing.Point(3, 45)
        Me.TLPUsernameAndRole.Name = "TLPUsernameAndRole"
        Me.TLPUsernameAndRole.RowCount = 2
        Me.TLPUsernameAndRole.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPUsernameAndRole.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPUsernameAndRole.Size = New System.Drawing.Size(595, 98)
        Me.TLPUsernameAndRole.TabIndex = 9
        '
        'TLPButtonsRegister
        '
        Me.TLPButtonsRegister.ColumnCount = 2
        Me.TLPButtonsRegister.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtonsRegister.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtonsRegister.Controls.Add(Me.BtnRegister, 0, 0)
        Me.TLPButtonsRegister.Controls.Add(Me.BtnBackRegister, 1, 0)
        Me.TLPButtonsRegister.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLPButtonsRegister.Location = New System.Drawing.Point(3, 314)
        Me.TLPButtonsRegister.Name = "TLPButtonsRegister"
        Me.TLPButtonsRegister.RowCount = 1
        Me.TLPButtonsRegister.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPButtonsRegister.Size = New System.Drawing.Size(595, 35)
        Me.TLPButtonsRegister.TabIndex = 11
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 473)
        Me.Controls.Add(Me.TLPContainerRegister)
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire d'Inscription"
        Me.TLPContainerRegister.ResumeLayout(False)
        Me.TLPContainerRegister.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TLPPasswordRegister.ResumeLayout(False)
        Me.TLPPasswordRegister.PerformLayout()
        Me.TLPUsernameAndRole.ResumeLayout(False)
        Me.TLPUsernameAndRole.PerformLayout()
        Me.TLPButtonsRegister.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblUsernameRegister As System.Windows.Forms.Label
    Friend WithEvents LblPasswordRegister As System.Windows.Forms.Label
    Friend WithEvents LblRoleRegister As System.Windows.Forms.Label
    Friend WithEvents CmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents TxtUsernameRegister As System.Windows.Forms.TextBox
    Friend WithEvents TxtPasswordRegister As System.Windows.Forms.TextBox
    Friend WithEvents BtnRegister As System.Windows.Forms.Button
    Friend WithEvents BtnBackRegister As System.Windows.Forms.Button
    Friend WithEvents TLPContainerRegister As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLPUsernameAndRole As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLPPasswordRegister As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LblRegisterInAllSecurity As System.Windows.Forms.Label
    Friend WithEvents TLPButtonsRegister As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LblPasswordConfirm As System.Windows.Forms.Label
    Friend WithEvents TxtPasswordConfirm As System.Windows.Forms.TextBox
End Class
