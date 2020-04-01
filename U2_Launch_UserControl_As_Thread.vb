Imports System.ComponentModel

Public Class U2_Launch_UserControl_As_Thread



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (BackgroundWorker1.IsBusy = False) Then
            '--- Launch Thread    ---------------------------------------------------
            Button1.BackColor = Color.Orange
            Button1.Text = "Thread is running"
            BackgroundWorker1.RunWorkerAsync()


        Else
            Button1.Text = "Thread is already running"
            Button1.BackColor = Color.OrangeRed
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        U2_Thread_Loop_Test1.Loop_With_Animation_Test_Thread()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Button1.Text = "Thread: Event= RunWorkerCompleted"
        Button1.BackColor = Color.YellowGreen

    End Sub
End Class
