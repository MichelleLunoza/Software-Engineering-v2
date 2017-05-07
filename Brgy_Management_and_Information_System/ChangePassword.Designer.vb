<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewPassTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmNewPassTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValidateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ChangePasswordButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OldUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OldPassTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "New Username:"
        '
        'NewUsernameTextBox
        '
        Me.NewUsernameTextBox.Location = New System.Drawing.Point(173, 18)
        Me.NewUsernameTextBox.Name = "NewUsernameTextBox"
        Me.NewUsernameTextBox.Size = New System.Drawing.Size(224, 20)
        Me.NewUsernameTextBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Confirm New Password:"
        '
        'NewPassTextBox
        '
        Me.NewPassTextBox.Location = New System.Drawing.Point(173, 57)
        Me.NewPassTextBox.Name = "NewPassTextBox"
        Me.NewPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPassTextBox.Size = New System.Drawing.Size(224, 20)
        Me.NewPassTextBox.TabIndex = 13
        '
        'ConfirmNewPassTextBox
        '
        Me.ConfirmNewPassTextBox.Location = New System.Drawing.Point(173, 92)
        Me.ConfirmNewPassTextBox.Name = "ConfirmNewPassTextBox"
        Me.ConfirmNewPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmNewPassTextBox.Size = New System.Drawing.Size(224, 20)
        Me.ConfirmNewPassTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "New Password:"
        '
        'ValidateButton
        '
        Me.ValidateButton.BackColor = System.Drawing.Color.Transparent
        Me.ValidateButton.BackgroundImage = CType(resources.GetObject("ValidateButton.BackgroundImage"), System.Drawing.Image)
        Me.ValidateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ValidateButton.FlatAppearance.BorderSize = 0
        Me.ValidateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ValidateButton.Location = New System.Drawing.Point(168, 383)
        Me.ValidateButton.Name = "ValidateButton"
        Me.ValidateButton.Size = New System.Drawing.Size(152, 46)
        Me.ValidateButton.TabIndex = 43
        Me.ValidateButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearButton.BackgroundImage = CType(resources.GetObject("ClearButton.BackgroundImage"), System.Drawing.Image)
        Me.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Location = New System.Drawing.Point(352, 383)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(152, 46)
        Me.ClearButton.TabIndex = 42
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ChangePasswordButton
        '
        Me.ChangePasswordButton.BackColor = System.Drawing.Color.Transparent
        Me.ChangePasswordButton.BackgroundImage = CType(resources.GetObject("ChangePasswordButton.BackgroundImage"), System.Drawing.Image)
        Me.ChangePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChangePasswordButton.FlatAppearance.BorderSize = 0
        Me.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangePasswordButton.Location = New System.Drawing.Point(168, 382)
        Me.ChangePasswordButton.Name = "ChangePasswordButton"
        Me.ChangePasswordButton.Size = New System.Drawing.Size(130, 31)
        Me.ChangePasswordButton.TabIndex = 41
        Me.ChangePasswordButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NewUsernameTextBox)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.NewPassTextBox)
        Me.Panel2.Controls.Add(Me.ConfirmNewPassTextBox)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(107, 218)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(423, 140)
        Me.Panel2.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Old Password:"
        '
        'OldUsernameTextBox
        '
        Me.OldUsernameTextBox.Location = New System.Drawing.Point(165, 35)
        Me.OldUsernameTextBox.Name = "OldUsernameTextBox"
        Me.OldUsernameTextBox.Size = New System.Drawing.Size(224, 20)
        Me.OldUsernameTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Old Username:"
        '
        'OldPassTextBox
        '
        Me.OldPassTextBox.Location = New System.Drawing.Point(165, 74)
        Me.OldPassTextBox.Name = "OldPassTextBox"
        Me.OldPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OldPassTextBox.Size = New System.Drawing.Size(224, 20)
        Me.OldPassTextBox.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.OldUsernameTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.OldPassTextBox)
        Me.Panel1.Location = New System.Drawing.Point(107, 218)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 124)
        Me.Panel1.TabIndex = 39
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 496)
        Me.Controls.Add(Me.ValidateButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ChangePasswordButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePassword"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NewUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NewPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmNewPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ValidateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ChangePasswordButton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OldUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OldPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
