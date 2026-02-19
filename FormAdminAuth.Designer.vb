<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminAuth
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAdminPassword = New System.Windows.Forms.TextBox()
        Me.PnlAdminPassword = New System.Windows.Forms.Panel()
        Me.BtnValidate = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PnlAdminPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mot de passe Administrateur"
        '
        'TxtAdminPassword
        '
        Me.TxtAdminPassword.Location = New System.Drawing.Point(6, 35)
        Me.TxtAdminPassword.Name = "TxtAdminPassword"
        Me.TxtAdminPassword.Size = New System.Drawing.Size(260, 20)
        Me.TxtAdminPassword.TabIndex = 1
        Me.TxtAdminPassword.UseSystemPasswordChar = True
        '
        'PnlAdminPassword
        '
        Me.PnlAdminPassword.Controls.Add(Me.BtnCancel)
        Me.PnlAdminPassword.Controls.Add(Me.BtnValidate)
        Me.PnlAdminPassword.Controls.Add(Me.Label1)
        Me.PnlAdminPassword.Controls.Add(Me.TxtAdminPassword)
        Me.PnlAdminPassword.Location = New System.Drawing.Point(64, 75)
        Me.PnlAdminPassword.Name = "PnlAdminPassword"
        Me.PnlAdminPassword.Size = New System.Drawing.Size(275, 124)
        Me.PnlAdminPassword.TabIndex = 2
        '
        'BtnValidate
        '
        Me.BtnValidate.Location = New System.Drawing.Point(6, 78)
        Me.BtnValidate.Name = "BtnValidate"
        Me.BtnValidate.Size = New System.Drawing.Size(75, 23)
        Me.BtnValidate.TabIndex = 2
        Me.BtnValidate.Text = "Valider"
        Me.BtnValidate.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(191, 78)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Annuler"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormAdminAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 261)
        Me.Controls.Add(Me.PnlAdminPassword)
        Me.Name = "FormAdminAuth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire d'authentification Administrateur"
        Me.PnlAdminPassword.ResumeLayout(False)
        Me.PnlAdminPassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents PnlAdminPassword As System.Windows.Forms.Panel
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnValidate As System.Windows.Forms.Button
End Class
