Option Strict On

Public Class U2_Thread_Loop_Test
#Const Flag_Mode_Debug_Full = "No"
#Const Flag_Mode_Debug_Medium = "No"
#Const Flag_Mode_Invoke_Inside_Thread = "Yes"



    Public Counter_Number_Of_Click As Integer = 0

    Private Sub Button_Thread_Click(sender As Object, e As EventArgs) Handles Button_Thread.Click
        '------------------------------------------------------------------------------
        '---  Show Info on this task    -----------------------------------------------
        '------------------------------------------------------------------------------
         On Error GoTo Errhandler_Avec_Diagnostic

#If Flag_Mode_Invoke_Inside_Thread = "Yes" Then
        '#### Me or main Window context    ######################################
        '------------------------------------------------------------------------------
        '---  Use Invoke because event is sent from another process                 ---
        '------------------------------------------------------------------------------
        Me.Invoke(New MethodInvoker(Sub()
#End If   '==== #If Flag_Mode_Invoke_Inside_Thread = True Then   ...                         =============     


                                        Counter_Number_Of_Click = Counter_Number_Of_Click + 1

                                        '******************************************************************************
                                        '****  Part_1: Show some info about the process                           *****
                                        '******************************************************************************
                                        TextBox1.Text = "Show Counter Click value Counter= " & Counter_Number_Of_Click.ToString
                                        Dim Counter_Modulo_2 As Integer
                                        Counter_Modulo_2 = Counter_Number_Of_Click Mod 2
                                        If (Counter_Modulo_2 = 0) Then
                                            TextBox1.BackColor = Color.LightPink
                                        Else
                                            TextBox1.BackColor = Color.Yellow
                                        End If
                                        System.Windows.Forms.Application.DoEvents()
                                        '******************************************************************************
                                        '****  Part_2: Show some info about the process    [Branch1]              *****
                                        '******************************************************************************


                                        '******************************************************************************
                                        '****  Part_3: Show some info about the process    [Branch1]              *****
                                        '******************************************************************************


                                        '******************************************************************************
                                        '****  Part_3: Show some info about the process    [Branch2]              *****
                                        '******************************************************************************

#If Flag_Mode_Invoke_Inside_Thread = "Yes" Then
                                    End Sub))
        '------------------------------------------------------------------------------
        '---  Use Invoke because event is sent from another process                 ---
        '------------------------------------------------------------------------------
#End If   '==== #If Flag_Mode_Invoke_Inside_Thread = True Then   ...                         =============     

        Exit sub
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:

#If Flag_Mode_Invoke_Inside_Thread = "Yes" Then
        Me.Invoke(New MethodInvoker(Sub()
#End If   '==== #If Flag_Mode_Invoke_Inside_Thread = True Then   ...                         =============     
        '-------------------------------------------------------------------------------
        '--- L'erreur est appelée dans un thread                                   -----
        '--- => on provoque l'affichage à partir du contexte de la page principale -----
        '---    [Sinon les messages se mélangent puis blocage]                     ----- 
        '-------------------------------------------------------------------------------
        'Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Launch_Appli() ")
        '------------         Fin traitement des erreurs                   -------------
#If Flag_Mode_Invoke_Inside_Thread = "Yes" Then
                                    End Sub))
#End If   '==== #If Flag_Mode_Invoke_Inside_Thread = True Then   ...                         =============     
        Resume Next
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Loop_With_Animation_Test_Thread()
    End Sub

    Public Sub Loop_With_Animation_Test_Thread()
        '------------------------------------------------------------------------------
        '---  Show Info on this task    -----------------------------------------------
        '------------------------------------------------------------------------------
        On Error GoTo Errhandler_Avec_Diagnostic

#If Flag_Mode_Invoke_Inside_Thread = "Yes" Then
        '#### Me or main Window context    ######################################
        '------------------------------------------------------------------------------
        '---  Use Invoke because event is sent from another process                 ---
        '------------------------------------------------------------------------------
        Me.Invoke(New MethodInvoker(Sub()
#End If   '==== #If Flag_Mode_Invoke_Inside_Thread = True Then   ...                         =============     

                                        Dim Counter_Loop_Thread_Max As Long = 0
                                        Dim Counter_Loop_Thread As Long = 0
                                        Long.TryParse(TextBox3_Counter_Max.Text, Counter_Loop_Thread_Max)

                                        For Counter_Loop_Thread = 1 To Counter_Loop_Thread_Max


                                            '******************************************************************************
                                            '****  Part_1: Show some info about the process                           *****
                                            '******************************************************************************
                                            TextBox_Loop.Text = "Show Counter_Loop for Thread= " & Counter_Loop_Thread.ToString
                                            Dim Counter_Modulo_2 As Long
                                            Counter_Modulo_2 = Counter_Loop_Thread Mod 1000
                                            If (Counter_Modulo_2 < 500) Then
                                                TextBox_Loop.BackColor = Color.LightPink
                                            Else
                                                TextBox_Loop.BackColor = Color.LightBlue
                                            End If

                                            System.Windows.Forms.Application.DoEvents()
                                            '******************************************************************************
                                            '****  Part_2: Show some info about the process    [Branch1]              *****
                                            '******************************************************************************
                                        Next Counter_Loop_Thread

#If Flag_Mode_Invoke_Inside_Thread = "Yes" Then
                                    End Sub))
        '------------------------------------------------------------------------------
        '---  Use Invoke because event is sent from another process                 ---
        '------------------------------------------------------------------------------
#End If   '==== #If Flag_Mode_Invoke_Inside_Thread = True Then   ...                         =============     

        Exit Sub
        '-------------------------------------------------------------------------------
Errhandler_Avec_Diagnostic:

#If Flag_Mode_Invoke_Inside_Thread = "Yes" Then
        Me.Invoke(New MethodInvoker(Sub()
#End If   '==== #If Flag_Mode_Invoke_Inside_Thread = True Then   ...                         =============     
                                        '-------------------------------------------------------------------------------
                                        '--- L'erreur est appelée dans un thread                                   -----
                                        '--- => on provoque l'affichage à partir du contexte de la page principale -----
                                        '---    [Sinon les messages se mélangent puis blocage]                     ----- 
                                        '-------------------------------------------------------------------------------
                                        'Call U_Msg_Local1.Affiche_Erreur("Error Launcher: Launch_Appli() ")
                                        '------------         Fin traitement des erreurs                   -------------
#If Flag_Mode_Invoke_Inside_Thread = "Yes" Then
                                    End Sub))
#End If   '==== #If Flag_Mode_Invoke_Inside_Thread = True Then   ...                         =============     
        Resume Next



    End Sub

End Class
