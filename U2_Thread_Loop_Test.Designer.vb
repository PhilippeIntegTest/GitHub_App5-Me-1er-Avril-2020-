<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U2_Thread_Loop_Test
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
        Me.Button_Thread = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Loop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3_Counter_Max = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Thread
        '
        Me.Button_Thread.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button_Thread.Location = New System.Drawing.Point(3, 3)
        Me.Button_Thread.Name = "Button_Thread"
        Me.Button_Thread.Size = New System.Drawing.Size(230, 23)
        Me.Button_Thread.TabIndex = 0
        Me.Button_Thread.Text = "Small animation (Internal)"
        Me.Button_Thread.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(323, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "General info at Startup of the process"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "General Info on Object :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "String from Worker Thread"
        '
        'TextBox_Loop
        '
        Me.TextBox_Loop.Location = New System.Drawing.Point(146, 79)
        Me.TextBox_Loop.Name = "TextBox_Loop"
        Me.TextBox_Loop.Size = New System.Drawing.Size(323, 20)
        Me.TextBox_Loop.TabIndex = 3
        Me.TextBox_Loop.Text = "Animation From Loop"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Counter Loop Max"
        '
        'TextBox3_Counter_Max
        '
        Me.TextBox3_Counter_Max.Location = New System.Drawing.Point(146, 105)
        Me.TextBox3_Counter_Max.Name = "TextBox3_Counter_Max"
        Me.TextBox3_Counter_Max.Size = New System.Drawing.Size(76, 20)
        Me.TextBox3_Counter_Max.TabIndex = 5
        Me.TextBox3_Counter_Max.Text = "20000"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(3, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Loop High CPU Power + Display"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'U2_Thread_Loop_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3_Counter_Max)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_Loop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button_Thread)
        Me.Name = "U2_Thread_Loop_Test"
        Me.Size = New System.Drawing.Size(460, 134)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Thread As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Loop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3_Counter_Max As TextBox
    Friend WithEvents Button1 As Button
End Class
