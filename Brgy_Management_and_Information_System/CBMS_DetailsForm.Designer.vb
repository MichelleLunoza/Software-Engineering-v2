<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CBMS_DetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CBMS_DetailsForm))
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ViewDetailsButton = New System.Windows.Forms.Button()
        Me.HHNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeadFamilyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalMaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TotalPurokButton = New System.Windows.Forms.Button()
        Me.TotalFamilyButton = New System.Windows.Forms.Button()
        Me.OverallTotalButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(249, 283)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(281, 20)
        Me.SearchTextBox.TabIndex = 75
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Location = New System.Drawing.Point(143, 290)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(80, 13)
        Me.Label.TabIndex = 74
        Me.Label.Text = "Head of Family:"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(548, 280)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 76
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1257, 198)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 33)
        Me.BackButton.TabIndex = 73
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ViewDetailsButton
        '
        Me.ViewDetailsButton.Location = New System.Drawing.Point(1202, 319)
        Me.ViewDetailsButton.Name = "ViewDetailsButton"
        Me.ViewDetailsButton.Size = New System.Drawing.Size(112, 56)
        Me.ViewDetailsButton.TabIndex = 80
        Me.ViewDetailsButton.Text = "Delete"
        Me.ViewDetailsButton.UseVisualStyleBackColor = True
        '
        'HHNumberDataGridViewTextBoxColumn
        '
        Me.HHNumberDataGridViewTextBoxColumn.DataPropertyName = "HHNumber"
        Me.HHNumberDataGridViewTextBoxColumn.HeaderText = "HH Number"
        Me.HHNumberDataGridViewTextBoxColumn.Name = "HHNumberDataGridViewTextBoxColumn"
        Me.HHNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HeadFamilyDataGridViewTextBoxColumn
        '
        Me.HeadFamilyDataGridViewTextBoxColumn.DataPropertyName = "HeadFamily"
        Me.HeadFamilyDataGridViewTextBoxColumn.HeaderText = "Head of the Family"
        Me.HeadFamilyDataGridViewTextBoxColumn.Name = "HeadFamilyDataGridViewTextBoxColumn"
        Me.HeadFamilyDataGridViewTextBoxColumn.ReadOnly = True
        Me.HeadFamilyDataGridViewTextBoxColumn.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TotalPopulation"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total Population"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalMaleDataGridViewTextBoxColumn
        '
        Me.TotalMaleDataGridViewTextBoxColumn.DataPropertyName = "TotalMale"
        Me.TotalMaleDataGridViewTextBoxColumn.HeaderText = "Total Male"
        Me.TotalMaleDataGridViewTextBoxColumn.Name = "TotalMaleDataGridViewTextBoxColumn"
        Me.TotalMaleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TotalFemale"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Total Female"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TotalOFW"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total OFW"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TotalPWD"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total PWD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "zero_12Months"
        Me.DataGridViewTextBoxColumn5.HeaderText = "0-12 Months"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "two_5YrsOld"
        Me.DataGridViewTextBoxColumn6.HeaderText = "2-5 Yrs Old"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "six_12YrsOld"
        Me.DataGridViewTextBoxColumn7.HeaderText = "6-12 Yrs Old"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SeniorCitizen"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Senior Citizen"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "thirteen_17YrsOld"
        Me.DataGridViewTextBoxColumn8.HeaderText = "13-17 Yrs Old"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(464, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(571, 39)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Computer Based Monitoring System"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(146, 319)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(657, 378)
        Me.DataGridView1.TabIndex = 85
        '
        'TotalPurokButton
        '
        Me.TotalPurokButton.Location = New System.Drawing.Point(1202, 443)
        Me.TotalPurokButton.Name = "TotalPurokButton"
        Me.TotalPurokButton.Size = New System.Drawing.Size(112, 56)
        Me.TotalPurokButton.TabIndex = 86
        Me.TotalPurokButton.Text = "Total by Purok"
        Me.TotalPurokButton.UseVisualStyleBackColor = True
        '
        'TotalFamilyButton
        '
        Me.TotalFamilyButton.Location = New System.Drawing.Point(1202, 381)
        Me.TotalFamilyButton.Name = "TotalFamilyButton"
        Me.TotalFamilyButton.Size = New System.Drawing.Size(112, 56)
        Me.TotalFamilyButton.TabIndex = 87
        Me.TotalFamilyButton.Text = "Total (Family)"
        Me.TotalFamilyButton.UseVisualStyleBackColor = True
        '
        'OverallTotalButton
        '
        Me.OverallTotalButton.Location = New System.Drawing.Point(1202, 505)
        Me.OverallTotalButton.Name = "OverallTotalButton"
        Me.OverallTotalButton.Size = New System.Drawing.Size(112, 56)
        Me.OverallTotalButton.TabIndex = 88
        Me.OverallTotalButton.Text = "Overall Total"
        Me.OverallTotalButton.UseVisualStyleBackColor = True
        '
        'CBMS_DetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 712)
        Me.Controls.Add(Me.OverallTotalButton)
        Me.Controls.Add(Me.TotalFamilyButton)
        Me.Controls.Add(Me.TotalPurokButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ViewDetailsButton)
        Me.DoubleBuffered = True
        Me.Name = "CBMS_DetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CBMS_DetailsForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ViewDetailsButton As System.Windows.Forms.Button
    Friend WithEvents HHNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeadFamilyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalMaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TotalPurokButton As System.Windows.Forms.Button
    Friend WithEvents TotalFamilyButton As System.Windows.Forms.Button
    Friend WithEvents OverallTotalButton As System.Windows.Forms.Button
End Class
