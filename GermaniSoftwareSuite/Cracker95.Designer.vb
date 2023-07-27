<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cracker95
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cracker95))
        CdSelect = New RadioButton()
        OemSelect = New RadioButton()
        KeyTypeGroup = New GroupBox()
        GenButton = New Button()
        OutputBox = New TextBox()
        ValidatorInput = New TextBox()
        ValidatorBtn = New Button()
        ValidatorOutput = New Label()
        CopyBtn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        SuiteReturnBTN = New Button()
        KeyTypeGroup.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CdSelect
        ' 
        CdSelect.AutoSize = True
        CdSelect.Checked = True
        CdSelect.Location = New Point(6, 22)
        CdSelect.Name = "CdSelect"
        CdSelect.Size = New Size(65, 19)
        CdSelect.TabIndex = 0
        CdSelect.TabStop = True
        CdSelect.Text = "CD-Key"
        CdSelect.UseVisualStyleBackColor = True
        ' 
        ' OemSelect
        ' 
        OemSelect.AutoSize = True
        OemSelect.Location = New Point(6, 47)
        OemSelect.Name = "OemSelect"
        OemSelect.Size = New Size(75, 19)
        OemSelect.TabIndex = 1
        OemSelect.Text = "OEM-Key"
        OemSelect.UseVisualStyleBackColor = True
        ' 
        ' KeyTypeGroup
        ' 
        KeyTypeGroup.Controls.Add(CdSelect)
        KeyTypeGroup.Controls.Add(OemSelect)
        KeyTypeGroup.Location = New Point(216, 100)
        KeyTypeGroup.Name = "KeyTypeGroup"
        KeyTypeGroup.Size = New Size(89, 74)
        KeyTypeGroup.TabIndex = 2
        KeyTypeGroup.TabStop = False
        KeyTypeGroup.Text = "Key Type"
        ' 
        ' GenButton
        ' 
        GenButton.Location = New Point(216, 42)
        GenButton.Name = "GenButton"
        GenButton.Size = New Size(75, 23)
        GenButton.TabIndex = 3
        GenButton.Text = "Generate!"
        GenButton.UseVisualStyleBackColor = True
        ' 
        ' OutputBox
        ' 
        OutputBox.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point)
        OutputBox.Location = New Point(12, 41)
        OutputBox.Name = "OutputBox"
        OutputBox.ReadOnly = True
        OutputBox.Size = New Size(198, 24)
        OutputBox.TabIndex = 4
        ' 
        ' ValidatorInput
        ' 
        ValidatorInput.Font = New Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ValidatorInput.Location = New Point(12, 252)
        ValidatorInput.Name = "ValidatorInput"
        ValidatorInput.PlaceholderText = "Enter Key To Validate"
        ValidatorInput.Size = New Size(198, 26)
        ValidatorInput.TabIndex = 5
        ' 
        ' ValidatorBtn
        ' 
        ValidatorBtn.Location = New Point(216, 252)
        ValidatorBtn.Name = "ValidatorBtn"
        ValidatorBtn.Size = New Size(75, 23)
        ValidatorBtn.TabIndex = 6
        ValidatorBtn.Text = "Validate!"
        ValidatorBtn.UseVisualStyleBackColor = True
        ' 
        ' ValidatorOutput
        ' 
        ValidatorOutput.AutoSize = True
        ValidatorOutput.ForeColor = SystemColors.ControlText
        ValidatorOutput.Location = New Point(12, 278)
        ValidatorOutput.Name = "ValidatorOutput"
        ValidatorOutput.Size = New Size(167, 15)
        ValidatorOutput.TabIndex = 7
        ValidatorOutput.Text = "Enter a key above to validate it"
        ' 
        ' CopyBtn
        ' 
        CopyBtn.Location = New Point(216, 71)
        CopyBtn.Name = "CopyBtn"
        CopyBtn.Size = New Size(75, 23)
        CopyBtn.TabIndex = 8
        CopyBtn.Text = "Copy Key!"
        CopyBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 234)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 15)
        Label1.TabIndex = 9
        Label1.Text = "CD/OEM Key Validator"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.trolla
        PictureBox1.Location = New Point(43, 100)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(94, 96)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' SuiteReturnBTN
        ' 
        SuiteReturnBTN.Location = New Point(12, 12)
        SuiteReturnBTN.Name = "SuiteReturnBTN"
        SuiteReturnBTN.Size = New Size(167, 23)
        SuiteReturnBTN.TabIndex = 11
        SuiteReturnBTN.Text = "Return to software selection"
        SuiteReturnBTN.UseVisualStyleBackColor = True
        ' 
        ' Cracker95
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(334, 303)
        Controls.Add(SuiteReturnBTN)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(CopyBtn)
        Controls.Add(ValidatorOutput)
        Controls.Add(ValidatorBtn)
        Controls.Add(ValidatorInput)
        Controls.Add(OutputBox)
        Controls.Add(GenButton)
        Controls.Add(KeyTypeGroup)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimumSize = New Size(350, 307)
        Name = "Cracker95"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cracker95 GUI"
        KeyTypeGroup.ResumeLayout(False)
        KeyTypeGroup.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CdSelect As RadioButton
    Friend WithEvents OemSelect As RadioButton
    Friend WithEvents KeyTypeGroup As GroupBox
    Friend WithEvents GenButton As Button
    Friend WithEvents OutputBox As TextBox
    Friend WithEvents ValidatorInput As TextBox
    Friend WithEvents ValidatorBtn As Button
    Friend WithEvents ValidatorOutput As Label
    Friend WithEvents CopyBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SuiteReturnBTN As Button
End Class
