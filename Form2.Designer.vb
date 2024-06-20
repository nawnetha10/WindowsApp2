<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.phn_no = New System.Windows.Forms.Label()
        Me.git = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BtnStartPause = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Create Submission Form "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(278, 116)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Name"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Location = New System.Drawing.Point(281, 150)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(41, 16)
        Me.email.TabIndex = 3
        Me.email.Text = "Email"
        '
        'phn_no
        '
        Me.phn_no.AutoSize = True
        Me.phn_no.Location = New System.Drawing.Point(245, 189)
        Me.phn_no.Name = "phn_no"
        Me.phn_no.Size = New System.Drawing.Size(97, 16)
        Me.phn_no.TabIndex = 4
        Me.phn_no.Text = "Phone Number"
        '
        'git
        '
        Me.git.AutoSize = True
        Me.git.Location = New System.Drawing.Point(270, 229)
        Me.git.Name = "git"
        Me.git.Size = New System.Drawing.Size(72, 16)
        Me.git.TabIndex = 5
        Me.git.Text = "Github Link"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(375, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 22)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(375, 150)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(375, 189)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(172, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(375, 223)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(172, 22)
        Me.TextBox4.TabIndex = 9
        '
        'BtnStartPause
        '
        Me.BtnStartPause.Location = New System.Drawing.Point(264, 277)
        Me.BtnStartPause.Name = "BtnStartPause"
        Me.BtnStartPause.Size = New System.Drawing.Size(162, 33)
        Me.BtnStartPause.TabIndex = 11
        Me.BtnStartPause.Text = "Start"
        Me.BtnStartPause.UseVisualStyleBackColor = True
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(375, 340)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(113, 31)
        Me.Submit.TabIndex = 12
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(463, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(463, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 14
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.BtnStartPause)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.git)
        Me.Controls.Add(Me.phn_no)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form2"
        Me.Text = "Create"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents email As Label
    Friend WithEvents phn_no As Label
    Friend WithEvents git As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BtnStartPause As Button
    Friend WithEvents Submit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
