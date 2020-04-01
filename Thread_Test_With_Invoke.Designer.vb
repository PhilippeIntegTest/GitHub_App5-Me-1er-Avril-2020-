<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thread_Test_With_Invoke
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.U2_Launch_UserControl_As_Thread1 = New App_VB_Test_GitHub.U2_Launch_UserControl_As_Thread()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(-1, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(279, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Appli Test Gestion de Conf GitHub Test n°4"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'U2_Launch_UserControl_As_Thread1
        '
        Me.U2_Launch_UserControl_As_Thread1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.U2_Launch_UserControl_As_Thread1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.U2_Launch_UserControl_As_Thread1.Location = New System.Drawing.Point(-1, 70)
        Me.U2_Launch_UserControl_As_Thread1.Name = "U2_Launch_UserControl_As_Thread1"
        Me.U2_Launch_UserControl_As_Thread1.Size = New System.Drawing.Size(544, 274)
        Me.U2_Launch_UserControl_As_Thread1.TabIndex = 1
        '
        'Thread_Test_With_Invoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.U2_Launch_UserControl_As_Thread1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Thread_Test_With_Invoke"
        Me.Text = "GitHub Create Project n°4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents U2_Launch_UserControl_As_Thread1 As U2_Launch_UserControl_As_Thread
End Class
