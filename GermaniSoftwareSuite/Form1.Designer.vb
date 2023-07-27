<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Cracker95BTN = New Button()
        OggyBTN = New Button()
        ScamazonBTN = New Button()
        FactBTN = New Button()
        TitleLabel = New Label()
        SuspendLayout()
        ' 
        ' Cracker95BTN
        ' 
        Cracker95BTN.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Cracker95BTN.ForeColor = Color.OrangeRed
        Cracker95BTN.Image = My.Resources.Resources.trolla1
        Cracker95BTN.Location = New Point(37, 92)
        Cracker95BTN.Name = "Cracker95BTN"
        Cracker95BTN.Size = New Size(112, 78)
        Cracker95BTN.TabIndex = 0
        Cracker95BTN.Text = "Cracker95"
        Cracker95BTN.UseVisualStyleBackColor = True
        ' 
        ' OggyBTN
        ' 
        OggyBTN.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        OggyBTN.ForeColor = Color.OrangeRed
        OggyBTN.Image = My.Resources.Resources.IMG_20230518_155745_tigr_112x149
        OggyBTN.Location = New Point(155, 92)
        OggyBTN.Name = "OggyBTN"
        OggyBTN.Size = New Size(112, 78)
        OggyBTN.TabIndex = 1
        OggyBTN.Text = "Oggy Pics"
        OggyBTN.UseVisualStyleBackColor = True
        ' 
        ' ScamazonBTN
        ' 
        ScamazonBTN.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ScamazonBTN.ForeColor = Color.OrangeRed
        ScamazonBTN.Image = My.Resources.Resources.funny_memes_dank_memes_good_memes_dumb_memes_random_memes_memes_funny_lol_relatable_memes_meme_dump_112x59
        ScamazonBTN.Location = New Point(273, 92)
        ScamazonBTN.Name = "ScamazonBTN"
        ScamazonBTN.Size = New Size(112, 78)
        ScamazonBTN.TabIndex = 13
        ScamazonBTN.Text = "Scamazon"
        ScamazonBTN.UseVisualStyleBackColor = True
        ' 
        ' FactBTN
        ' 
        FactBTN.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        FactBTN.ForeColor = Color.OrangeRed
        FactBTN.Image = My.Resources.Resources.nerd_2647_x_2000_picture_altr74v3p764nsbh_112x63
        FactBTN.Location = New Point(391, 92)
        FactBTN.Name = "FactBTN"
        FactBTN.Size = New Size(112, 78)
        FactBTN.TabIndex = 14
        FactBTN.Text = "Fact Generator"
        FactBTN.UseVisualStyleBackColor = True
        ' 
        ' TitleLabel
        ' 
        TitleLabel.AutoSize = True
        TitleLabel.Font = New Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        TitleLabel.Location = New Point(12, 9)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New Size(512, 52)
        TitleLabel.TabIndex = 15
        TitleLabel.Text = "The Germani Software Suite"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 182)
        Controls.Add(TitleLabel)
        Controls.Add(FactBTN)
        Controls.Add(ScamazonBTN)
        Controls.Add(OggyBTN)
        Controls.Add(Cracker95BTN)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "The Germani Software Suite"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cracker95BTN As Button
    Friend WithEvents OggyBTN As Button
    Friend WithEvents ScamazonBTN As Button
    Friend WithEvents FactBTN As Button
    Friend WithEvents TitleLabel As Label
End Class
