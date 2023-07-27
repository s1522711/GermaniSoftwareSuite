Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class FactsLangSel
    Private Sub BtnEn_Click(sender As Object, e As EventArgs) Handles BtnEn.Click
        FactsMain.GroupBox1.Text = "Sprache"
        FactsMain.Button1.Text = "Get Fact!"
        FactsMain.Button1.Width = "143"
        FactsMain.Button1.Height = "30"
        FactsMain.TextBox1.Location = New Point(165, 12)
        FactsMain.Width = "508"
        FactsMain.GroupBox1.Width = "147"
        FactsMain.TextBox1.Text = "Please Press The Button to Start!"
        FactsMain.Text = "Fact Generator"
        FactsMain.EnSel.Checked = 1
        FactsMain.DeSel.Checked = 0
        FactsLoading.Label1.Text = "LOADING, PLEASE WAIT!"
        FactsLoading.Text = "Loading Fact generator"
        FactsMain.GroupBox2.Width = "147"
        FactsMain.GroupBox2.Text = "Fact Type"
        FactsMain.RanFact.Text = "Random Fact"
        FactsMain.DayFact.Text = "Fact of the Day"
        SuiteReturnBTN.Text = "Return to software selection"
        FactsLoading.Timer1.Enabled = True
        FactsLoading.Timer2.Enabled = True
        FactsLoading.Show()
        Close()
    End Sub

    Private Sub BtnDe_Click(sender As Object, e As EventArgs) Handles BtnDe.Click
        FactsMain.GroupBox1.Text = "Language"
        FactsMain.Button1.Text = "Holen Sie sich Tatsachen!"
        FactsMain.Button1.Width = "195"
        FactsMain.Button1.Height = "30"
        FactsMain.TextBox1.Location = New Point(213, 12)
        FactsMain.Width = "558"
        FactsMain.GroupBox1.Width = "195"
        FactsMain.TextBox1.Text = "Bitte drücken Sie die Taste, um zu starten!"
        FactsMain.Text = "Faktengenerator"
        FactsMain.DeSel.Checked = 1
        FactsMain.EnSel.Checked = 0
        FactsLoading.Label1.Text = "LADEN, BITTE WARTEN!"
        FactsLoading.Text = "Laden des Faktengenerators"
        Text = "Faktengenerator"
        FactsMain.GroupBox2.Width = "195"
        FactsMain.GroupBox2.Text = "Faktentyp"
        FactsMain.RanFact.Text = "Zufälliger Fakt"
        FactsMain.DayFact.Text = "Fakt des Tages"
        SuiteReturnBTN.Text = "Zurück zur Softwareauswahl"
        FactsLoading.Timer1.Enabled = True
        FactsLoading.Timer2.Enabled = True
        FactsLoading.Show()
        Close()
    End Sub

    Private Sub FactsLangSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()
    End Sub

    Private Sub SuiteReturnBTN_Click(sender As Object, e As EventArgs) Handles SuiteReturnBTN.Click
        Form1.Show()
        Close()
    End Sub
End Class
