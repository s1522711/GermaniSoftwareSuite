<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OggyMainScreen
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(OggyMainScreen))
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        LoadingLabel = New Label()
        PassTextBox = New TextBox()
        PassButton = New Button()
        SuiteReturnBTN = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "New Pic!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.ImageLocation = "https://piggo.cc/cat/img.png"
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(3, 45, 3, 3)
        PictureBox1.Size = New Size(515, 305)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' LoadingLabel
        ' 
        LoadingLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LoadingLabel.AutoSize = True
        LoadingLabel.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        LoadingLabel.Location = New Point(147, 153)
        LoadingLabel.Name = "LoadingLabel"
        LoadingLabel.Size = New Size(129, 33)
        LoadingLabel.TabIndex = 2
        LoadingLabel.Text = "LOADING"
        LoadingLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PassTextBox
        ' 
        PassTextBox.Cursor = Cursors.IBeam
        PassTextBox.Location = New Point(131, 11)
        PassTextBox.Name = "PassTextBox"
        PassTextBox.Size = New Size(100, 23)
        PassTextBox.TabIndex = 3
        PassTextBox.UseSystemPasswordChar = True
        ' 
        ' PassButton
        ' 
        PassButton.Cursor = Cursors.Hand
        PassButton.FlatStyle = FlatStyle.Popup
        PassButton.Location = New Point(237, 11)
        PassButton.Name = "PassButton"
        PassButton.Size = New Size(94, 23)
        PassButton.TabIndex = 4
        PassButton.Text = "Test Password!"
        PassButton.UseVisualStyleBackColor = True
        ' 
        ' SuiteReturnBTN
        ' 
        SuiteReturnBTN.Location = New Point(337, 11)
        SuiteReturnBTN.Name = "SuiteReturnBTN"
        SuiteReturnBTN.Size = New Size(167, 23)
        SuiteReturnBTN.TabIndex = 13
        SuiteReturnBTN.Text = "Return to software selection"
        SuiteReturnBTN.UseVisualStyleBackColor = True
        ' 
        ' OggyMainScreen
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(515, 305)
        Controls.Add(SuiteReturnBTN)
        Controls.Add(PassButton)
        Controls.Add(PassTextBox)
        Controls.Add(LoadingLabel)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(38, 38)
        MaximizeBox = False
        Name = "OggyMainScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Oggy App"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoadingLabel As Label
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents PassButton As Button
    Friend WithEvents SuiteReturnBTN As Button
End Class
