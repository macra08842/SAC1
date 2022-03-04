<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEnglish = New System.Windows.Forms.Label()
        Me.lblMaths = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblPE = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(387, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(387, 164)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(387, 240)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(265, 107)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(82, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Student's Name"
        '
        'lblEnglish
        '
        Me.lblEnglish.AutoSize = True
        Me.lblEnglish.Location = New System.Drawing.Point(265, 171)
        Me.lblEnglish.Name = "lblEnglish"
        Me.lblEnglish.Size = New System.Drawing.Size(73, 13)
        Me.lblEnglish.TabIndex = 4
        Me.lblEnglish.Text = "English Marks"
        '
        'lblMaths
        '
        Me.lblMaths.AutoSize = True
        Me.lblMaths.Location = New System.Drawing.Point(265, 247)
        Me.lblMaths.Name = "lblMaths"
        Me.lblMaths.Size = New System.Drawing.Size(68, 13)
        Me.lblMaths.TabIndex = 5
        Me.lblMaths.Text = "Maths Marks"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(571, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblPE
        '
        Me.lblPE.AutoSize = True
        Me.lblPE.Location = New System.Drawing.Point(268, 313)
        Me.lblPE.Name = "lblPE"
        Me.lblPE.Size = New System.Drawing.Size(53, 13)
        Me.lblPE.TabIndex = 7
        Me.lblPE.Text = "PE Marks"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(387, 305)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblPE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMaths)
        Me.Controls.Add(Me.lblEnglish)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEnglish As Label
    Friend WithEvents lblMaths As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblPE As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
End Class
