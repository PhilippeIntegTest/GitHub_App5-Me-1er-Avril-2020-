<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U2_Launch_UserControl_As_Thread
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.U2_Thread_Loop_Test1 = New App_VB_Test_GitHub.U2_Thread_Loop_Test()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(21, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comment lancer des ""UserControl"" existants dans un WorkerThread ?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(24, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start UserControl ""Loop"" in a Thread"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(486, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Le problème: on ne peut pas faire d'affichage dans une fenètre à partir du code l" &
    "ancé dans un thread." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "==> Donc une classe d'affichage (UserControl) ne peut s'ex" &
    "ecuter dans un WorkerThread !"
        '
        'U2_Thread_Loop_Test1
        '
        Me.U2_Thread_Loop_Test1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.U2_Thread_Loop_Test1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.U2_Thread_Loop_Test1.Location = New System.Drawing.Point(50, 97)
        Me.U2_Thread_Loop_Test1.Name = "U2_Thread_Loop_Test1"
        Me.U2_Thread_Loop_Test1.Size = New System.Drawing.Size(460, 154)
        Me.U2_Thread_Loop_Test1.TabIndex = 2
        '
        'BackgroundWorker1
        '
        '
        'U2_Launch_UserControl_As_Thread
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.U2_Thread_Loop_Test1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "U2_Launch_UserControl_As_Thread"
        Me.Size = New System.Drawing.Size(540, 299)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents U2_Thread_Loop_Test1 As U2_Thread_Loop_Test
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
