<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.CBMSButton = New System.Windows.Forms.Button()
        Me.ClearancesButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ULabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(534, 144)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 26
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'CBMSButton
        '
        Me.CBMSButton.BackColor = System.Drawing.Color.Transparent
        Me.CBMSButton.BackgroundImage = CType(resources.GetObject("CBMSButton.BackgroundImage"), System.Drawing.Image)
        Me.CBMSButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CBMSButton.FlatAppearance.BorderSize = 0
        Me.CBMSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBMSButton.Location = New System.Drawing.Point(185, 261)
        Me.CBMSButton.Name = "CBMSButton"
        Me.CBMSButton.Size = New System.Drawing.Size(255, 53)
        Me.CBMSButton.TabIndex = 25
        Me.CBMSButton.UseVisualStyleBackColor = False
        '
        'ClearancesButton
        '
        Me.ClearancesButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearancesButton.BackgroundImage = CType(resources.GetObject("ClearancesButton.BackgroundImage"), System.Drawing.Image)
        Me.ClearancesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClearancesButton.FlatAppearance.BorderSize = 0
        Me.ClearancesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearancesButton.Location = New System.Drawing.Point(185, 192)
        Me.ClearancesButton.Name = "ClearancesButton"
        Me.ClearancesButton.Size = New System.Drawing.Size(255, 53)
        Me.ClearancesButton.TabIndex = 24
        Me.ClearancesButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(513, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Time:"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel.Location = New System.Drawing.Point(430, 80)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(0, 13)
        Me.DateLabel.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(396, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Date:"
        '
        'ULabel
        '
        Me.ULabel.AutoSize = True
        Me.ULabel.BackColor = System.Drawing.Color.Transparent
        Me.ULabel.Location = New System.Drawing.Point(258, 80)
        Me.ULabel.Name = "ULabel"
        Me.ULabel.Size = New System.Drawing.Size(0, 13)
        Me.ULabel.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(217, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "User: "
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Location = New System.Drawing.Point(552, 80)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(0, 13)
        Me.TimeLabel.TabIndex = 32
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 458)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ULabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.CBMSButton)
        Me.Controls.Add(Me.ClearancesButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents CBMSButton As System.Windows.Forms.Button
    Friend WithEvents ClearancesButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ULabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
End Class
