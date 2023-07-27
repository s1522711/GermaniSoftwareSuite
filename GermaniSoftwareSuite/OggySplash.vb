Imports System.Threading
Imports Microsoft.VisualBasic.Logging

Public Class OggySplash
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        OggyMainScreen.Show()
        Close()
    End Sub
End Class


