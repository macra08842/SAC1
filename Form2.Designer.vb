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
        Me.lblTitle.Location = New System.Drawing.Point(327, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(125, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Class Average Calculator"
        '
        'lblAvrEng
        '
        Me.lblAvrEng.AutoSize = True
        Me.lblAvrEng.Location = New System.Drawing.Point(131, 232)
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
        Me.lblCheck.Location = New System.Drawing.Point(648, 368)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(39, 13)
        Me.lblCheck.TabIndex = 7
        Me.lblCheck.Text = "Label2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.lblAvrMath)
        Me.Controls.Add(Me.lblAvrPe)
        Me.Controls.Add(Me.lblAvrEng)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnAveragePE)
        Me.Controls.Add(Me.btnAverageMath)
        Me.Controls.Add(Me.btnAverageEng)
        Me.Name = "Form2"
        Me.Text = "Form2"
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
End Class
