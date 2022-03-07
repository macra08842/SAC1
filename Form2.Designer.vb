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
        Me.btnAverageEng = New System.Windows.Forms.Button()
        Me.btnAverageMath = New System.Windows.Forms.Button()
        Me.btnAveragePE = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAvrEng = New System.Windows.Forms.Label()
        Me.lblAvrPe = New System.Windows.Forms.Label()
        Me.lblAvrMath = New System.Windows.Forms.Label()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.lblNumEng = New System.Windows.Forms.Label()
        Me.lblNumPe = New System.Windows.Forms.Label()
        Me.lblNumMath = New System.Windows.Forms.Label()
        Me.btnStuAvr = New System.Windows.Forms.Button()
        Me.lblStudAvr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAverageEng
        '
        Me.btnAverageEng.Location = New System.Drawing.Point(109, 148)
        Me.btnAverageEng.Name = "btnAverageEng"
        Me.btnAverageEng.Size = New System.Drawing.Size(109, 45)
        Me.btnAverageEng.TabIndex = 0
        Me.btnAverageEng.Text = "Find Average English Marks"
        Me.btnAverageEng.UseVisualStyleBackColor = True
        '
        'btnAverageMath
        '
        Me.btnAverageMath.Location = New System.Drawing.Point(539, 148)
        Me.btnAverageMath.Name = "btnAverageMath"
        Me.btnAverageMath.Size = New System.Drawing.Size(107, 45)
        Me.btnAverageMath.TabIndex = 1
        Me.btnAverageMath.Text = "Find Average Maths Marks"
        Me.btnAverageMath.UseVisualStyleBackColor = True
        '
        'btnAveragePE
        '
        Me.btnAveragePE.Location = New System.Drawing.Point(311, 148)
        Me.btnAveragePE.Name = "btnAveragePE"
        Me.btnAveragePE.Size = New System.Drawing.Size(108, 45)
        Me.btnAveragePE.TabIndex = 2
        Me.btnAveragePE.Text = "Find Average PE Marks"
        Me.btnAveragePE.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Source Code Pro Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(229, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(324, 27)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Class Average Calculator"
        '
        'lblAvrEng
        '
        Me.lblAvrEng.AutoSize = True
        Me.lblAvrEng.Location = New System.Drawing.Point(125, 232)
        Me.lblAvrEng.Name = "lblAvrEng"
        Me.lblAvrEng.Size = New System.Drawing.Size(78, 13)
        Me.lblAvrEng.TabIndex = 4
        Me.lblAvrEng.Text = "Average Score"
        '
        'lblAvrPe
        '
        Me.lblAvrPe.AutoSize = True
        Me.lblAvrPe.Location = New System.Drawing.Point(330, 231)
        Me.lblAvrPe.Name = "lblAvrPe"
        Me.lblAvrPe.Size = New System.Drawing.Size(78, 13)
        Me.lblAvrPe.TabIndex = 5
        Me.lblAvrPe.Text = "Average Score"
        '
        'lblAvrMath
        '
        Me.lblAvrMath.AutoSize = True
        Me.lblAvrMath.Location = New System.Drawing.Point(559, 232)
        Me.lblAvrMath.Name = "lblAvrMath"
        Me.lblAvrMath.Size = New System.Drawing.Size(76, 13)
        Me.lblAvrMath.TabIndex = 6
        Me.lblAvrMath.Text = "Average score"
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Location = New System.Drawing.Point(596, 380)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(39, 13)
        Me.lblCheck.TabIndex = 7
        Me.lblCheck.Text = "Label2"
        '
        'lblNumEng
        '
        Me.lblNumEng.AutoSize = True
        Me.lblNumEng.Location = New System.Drawing.Point(125, 289)
        Me.lblNumEng.Name = "lblNumEng"
        Me.lblNumEng.Size = New System.Drawing.Size(77, 13)
        Me.lblNumEng.TabIndex = 8
        Me.lblNumEng.Text = "Class Numbers"
        '
        'lblNumPe
        '
        Me.lblNumPe.AutoSize = True
        Me.lblNumPe.Location = New System.Drawing.Point(333, 289)
        Me.lblNumPe.Name = "lblNumPe"
        Me.lblNumPe.Size = New System.Drawing.Size(77, 13)
        Me.lblNumPe.TabIndex = 9
        Me.lblNumPe.Text = "Class Numbers"
        '
        'lblNumMath
        '
        Me.lblNumMath.AutoSize = True
        Me.lblNumMath.Location = New System.Drawing.Point(558, 289)
        Me.lblNumMath.Name = "lblNumMath"
        Me.lblNumMath.Size = New System.Drawing.Size(77, 13)
        Me.lblNumMath.TabIndex = 10
        Me.lblNumMath.Text = "Class Numbers"
        '
        'btnStuAvr
        '
        Me.btnStuAvr.Location = New System.Drawing.Point(167, 350)
        Me.btnStuAvr.Name = "btnStuAvr"
        Me.btnStuAvr.Size = New System.Drawing.Size(105, 51)
        Me.btnStuAvr.TabIndex = 11
        Me.btnStuAvr.Text = "Student Average"
        Me.btnStuAvr.UseVisualStyleBackColor = True
        '
        'lblStudAvr
        '
        Me.lblStudAvr.AutoSize = True
        Me.lblStudAvr.Location = New System.Drawing.Point(321, 369)
        Me.lblStudAvr.Name = "lblStudAvr"
        Me.lblStudAvr.Size = New System.Drawing.Size(84, 13)
        Me.lblStudAvr.TabIndex = 12
        Me.lblStudAvr.Text = "student average"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStudAvr)
        Me.Controls.Add(Me.btnStuAvr)
        Me.Controls.Add(Me.lblNumMath)
        Me.Controls.Add(Me.lblNumPe)
        Me.Controls.Add(Me.lblNumEng)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.lblAvrMath)
        Me.Controls.Add(Me.lblAvrPe)
        Me.Controls.Add(Me.lblAvrEng)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAveragePE)
        Me.Controls.Add(Me.btnAverageMath)
        Me.Controls.Add(Me.btnAverageEng)
        Me.Name = "Form2"
        Me.Text = "Part B"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAverageEng As Button
    Friend WithEvents btnAverageMath As Button
    Friend WithEvents btnAveragePE As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAvrEng As Label
    Friend WithEvents lblAvrPe As Label
    Friend WithEvents lblAvrMath As Label
    Friend WithEvents lblCheck As Label
    Friend WithEvents lblNumEng As Label
    Friend WithEvents lblNumPe As Label
    Friend WithEvents lblNumMath As Label
    Friend WithEvents btnStuAvr As Button
    Friend WithEvents lblStudAvr As Label
End Class
