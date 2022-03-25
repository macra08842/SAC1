<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMaths = New System.Windows.Forms.Button()
        Me.btnPe = New System.Windows.Forms.Button()
        Me.lblResultsE = New System.Windows.Forms.Label()
        Me.lblResultsM = New System.Windows.Forms.Label()
        Me.lblResultsP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnglish
        '
        Me.btnEnglish.Location = New System.Drawing.Point(237, 171)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(125, 23)
        Me.btnEnglish.TabIndex = 0
        Me.btnEnglish.Text = "Click Here for English"
        Me.btnEnglish.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(291, 117)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(180, 13)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "HIghest Student Results Per Subject"
        '
        'btnMaths
        '
        Me.btnMaths.Location = New System.Drawing.Point(237, 200)
        Me.btnMaths.Name = "btnMaths"
        Me.btnMaths.Size = New System.Drawing.Size(125, 23)
        Me.btnMaths.TabIndex = 3
        Me.btnMaths.Text = "Click Here for Maths"
        Me.btnMaths.UseVisualStyleBackColor = True
        '
        'btnPe
        '
        Me.btnPe.Location = New System.Drawing.Point(237, 229)
        Me.btnPe.Name = "btnPe"
        Me.btnPe.Size = New System.Drawing.Size(125, 23)
        Me.btnPe.TabIndex = 4
        Me.btnPe.Text = "Click Here for PE"
        Me.btnPe.UseVisualStyleBackColor = True
        '
        'lblResultsE
        '
        Me.lblResultsE.AutoSize = True
        Me.lblResultsE.Location = New System.Drawing.Point(399, 176)
        Me.lblResultsE.Name = "lblResultsE"
        Me.lblResultsE.Size = New System.Drawing.Size(42, 13)
        Me.lblResultsE.TabIndex = 5
        Me.lblResultsE.Text = "Results"
        '
        'lblResultsM
        '
        Me.lblResultsM.AutoSize = True
        Me.lblResultsM.Location = New System.Drawing.Point(399, 210)
        Me.lblResultsM.Name = "lblResultsM"
        Me.lblResultsM.Size = New System.Drawing.Size(42, 13)
        Me.lblResultsM.TabIndex = 6
        Me.lblResultsM.Text = "Results"
        '
        'lblResultsP
        '
        Me.lblResultsP.AutoSize = True
        Me.lblResultsP.Location = New System.Drawing.Point(399, 239)
        Me.lblResultsP.Name = "lblResultsP"
        Me.lblResultsP.Size = New System.Drawing.Size(42, 13)
        Me.lblResultsP.TabIndex = 7
        Me.lblResultsP.Text = "Results"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(601, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResultsP)
        Me.Controls.Add(Me.lblResultsM)
        Me.Controls.Add(Me.lblResultsE)
        Me.Controls.Add(Me.btnPe)
        Me.Controls.Add(Me.btnMaths)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnEnglish)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnglish As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMaths As Button
    Friend WithEvents btnPe As Button
    Friend WithEvents lblResultsE As Label
    Friend WithEvents lblResultsM As Label
    Friend WithEvents lblResultsP As Label
    Friend WithEvents Label1 As Label
End Class
