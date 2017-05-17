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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.CBMSButton = New System.Windows.Forms.Button()
        Me.ClearancesButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PopulationButton = New System.Windows.Forms.Button()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(576, 159)
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
        Me.CBMSButton.Location = New System.Drawing.Point(222, 276)
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
        Me.ClearancesButton.Location = New System.Drawing.Point(222, 204)
        Me.ClearancesButton.Name = "ClearancesButton"
        Me.ClearancesButton.Size = New System.Drawing.Size(255, 53)
        Me.ClearancesButton.TabIndex = 24
        Me.ClearancesButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(518, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(401, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(222, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "User: "
        '
        'PopulationButton
        '
        Me.PopulationButton.BackgroundImage = CType(resources.GetObject("PopulationButton.BackgroundImage"), System.Drawing.Image)
        Me.PopulationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PopulationButton.FlatAppearance.BorderSize = 0
        Me.PopulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PopulationButton.Location = New System.Drawing.Point(222, 354)
        Me.PopulationButton.Name = "PopulationButton"
        Me.PopulationButton.Size = New System.Drawing.Size(255, 53)
        Me.PopulationButton.TabIndex = 33
        Me.PopulationButton.UseVisualStyleBackColor = True
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.Location = New System.Drawing.Point(263, 125)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(0, 13)
        Me.userLabel.TabIndex = 34
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(440, 125)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(0, 13)
        Me.dateLabel.TabIndex = 35
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(557, 125)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(0, 13)
        Me.timeLabel.TabIndex = 36
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(663, 458)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.PopulationButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.CBMSButton)
        Me.Controls.Add(Me.ClearancesButton)
        Me.DoubleBuffered = True
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PopulationButton As System.Windows.Forms.Button
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents timeLabel As System.Windows.Forms.Label
End Class
