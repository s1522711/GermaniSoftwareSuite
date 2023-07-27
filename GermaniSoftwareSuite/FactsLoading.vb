Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FactsLoading
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Enabled = False
        Timer2.Stop()
        Timer1.Enabled = False
        Timer1.Stop()
        FactsMain.Show()
        Close()
    End Sub
    Private Sub Form1_Close(sender As Object, e As EventArgs)
        FactsLangSel.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.PerformStep()
    End Sub
End Class