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
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxEnglish = New System.Windows.Forms.TextBox()
        Me.tbxMaths = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEnglish = New System.Windows.Forms.Label()
        Me.lblMaths = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblPE = New System.Windows.Forms.Label()
        Me.tbxPE = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblMarks = New System.Windows.Forms.Label()
        Me.btnNameEnter = New System.Windows.Forms.Button()
        Me.btnEnglishEnter = New System.Windows.Forms.Button()
        Me.btnMathsEnter = New System.Windows.Forms.Button()
        Me.btnPeEnter = New System.Windows.Forms.Button()
        Me.lblAllNames = New System.Windows.Forms.Label()
        Me.lblEnglishMarks = New System.Windows.Forms.Label()
        Me.lblMathsMarks = New System.Windows.Forms.Label()
        Me.lblPEMarks = New System.Windows.Forms.Label()
        Me.lblEngNum = New System.Windows.Forms.Label()
        Me.lblMathNum = New System.Windows.Forms.Label()
        Me.lblPENum = New System.Windows.Forms.Label()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.btnPart3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(234, 94)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(100, 20)
        Me.tbxName.TabIndex = 0
        '
        'tbxEnglish
        '
        Me.tbxEnglish.Location = New System.Drawing.Point(234, 161)
        Me.tbxEnglish.Name = "tbxEnglish"
        Me.tbxEnglish.Size = New System.Drawing.Size(100, 20)
        Me.tbxEnglish.TabIndex = 1
        '
        'tbxMaths
        '
        Me.tbxMaths.Location = New System.Drawing.Point(234, 221)
        Me.tbxMaths.Name = "tbxMaths"
        Me.tbxMaths.Size = New System.Drawing.Size(100, 20)
        Me.tbxMaths.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(112, 93)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(82, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Student's Name"
        '
        'lblEnglish
        '
        Me.lblEnglish.AutoSize = True
        Me.lblEnglish.Location = New System.Drawing.Point(112, 164)
        Me.lblEnglish.Name = "lblEnglish"
        Me.lblEnglish.Size = New System.Drawing.Size(73, 13)
        Me.lblEnglish.TabIndex = 4
        Me.lblEnglish.Text = "English Marks"
        '
        'lblMaths
        '
        Me.lblMaths.AutoSize = True
        Me.lblMaths.Location = New System.Drawing.Point(117, 228)
        Me.lblMaths.Name = "lblMaths"
        Me.lblMaths.Size = New System.Drawing.Size(68, 13)
        Me.lblMaths.TabIndex = 5
        Me.lblMaths.Text = "Maths Marks"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(37, 338)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(108, 41)
        Me.btnEnter.TabIndex = 6
        Me.btnEnter.Text = "Enter Student data"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblPE
        '
        Me.lblPE.AutoSize = True
        Me.lblPE.Location = New System.Drawing.Point(117, 292)
        Me.lblPE.Name = "lblPE"
        Me.lblPE.Size = New System.Drawing.Size(53, 13)
        Me.lblPE.TabIndex = 7
        Me.lblPE.Text = "PE Marks"
        '
        'tbxPE
        '
        Me.tbxPE.Location = New System.Drawing.Point(234, 290)
        Me.tbxPE.Name = "tbxPE"
        Me.tbxPE.Size = New System.Drawing.Size(100, 20)
        Me.tbxPE.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(347, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(101, 13)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "End of Year Results"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(48, 406)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(78, 13)
        Me.lblClass.TabIndex = 10
        Me.lblClass.Text = "Class numbers:"
        '
        'lblMarks
        '
        Me.lblMarks.AutoSize = True
        Me.lblMarks.Location = New System.Drawing.Point(177, 352)
        Me.lblMarks.Name = "lblMarks"
        Me.lblMarks.Size = New System.Drawing.Size(78, 13)
        Me.lblMarks.TabIndex = 11
        Me.lblMarks.Text = "Student marks:"
        '
        'btnNameEnter
        '
        Me.btnNameEnter.Location = New System.Drawing.Point(350, 92)
        Me.btnNameEnter.Name = "btnNameEnter"
        Me.btnNameEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnNameEnter.TabIndex = 12
        Me.btnNameEnter.Text = "Enter"
        Me.btnNameEnter.UseVisualStyleBackColor = True
        '
        'btnEnglishEnter
        '
        Me.btnEnglishEnter.Location = New System.Drawing.Point(350, 161)
        Me.btnEnglishEnter.Name = "btnEnglishEnter"
        Me.btnEnglishEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnglishEnter.TabIndex = 13
        Me.btnEnglishEnter.Text = "Enter"
        Me.btnEnglishEnter.UseVisualStyleBackColor = True
        '
        'btnMathsEnter
        '
        Me.btnMathsEnter.Location = New System.Drawing.Point(350, 219)
        Me.btnMathsEnter.Name = "btnMathsEnter"
        Me.btnMathsEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnMathsEnter.TabIndex = 14
        Me.btnMathsEnter.Text = "Enter"
        Me.btnMathsEnter.UseVisualStyleBackColor = True
        '
        'btnPeEnter
        '
        Me.btnPeEnter.Location = New System.Drawing.Point(350, 287)
        Me.btnPeEnter.Name = "btnPeEnter"
        Me.btnPeEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnPeEnter.TabIndex = 15
        Me.btnPeEnter.Text = "Enter"
        Me.btnPeEnter.UseVisualStyleBackColor = True
        '
        'lblAllNames
        '
        Me.lblAllNames.AutoSize = True
        Me.lblAllNames.Location = New System.Drawing.Point(443, 94)
        Me.lblAllNames.Name = "lblAllNames"
        Me.lblAllNames.Size = New System.Drawing.Size(97, 13)
        Me.lblAllNames.TabIndex = 16
        Me.lblAllNames.Text = "Names of Students"
        '
        'lblEnglishMarks
        '
        Me.lblEnglishMarks.AutoSize = True
        Me.lblEnglishMarks.Location = New System.Drawing.Point(443, 161)
        Me.lblEnglishMarks.Name = "lblEnglishMarks"
        Me.lblEnglishMarks.Size = New System.Drawing.Size(86, 13)
        Me.lblEnglishMarks.TabIndex = 17
        Me.lblEnglishMarks.Text = "All English marks"
        '
        'lblMathsMarks
        '
        Me.lblMathsMarks.AutoSize = True
        Me.lblMathsMarks.Location = New System.Drawing.Point(443, 221)
        Me.lblMathsMarks.Name = "lblMathsMarks"
        Me.lblMathsMarks.Size = New System.Drawing.Size(82, 13)
        Me.lblMathsMarks.TabIndex = 18
        Me.lblMathsMarks.Text = "All Maths Marks"
        '
        'lblPEMarks
        '
        Me.lblPEMarks.AutoSize = True
        Me.lblPEMarks.Location = New System.Drawing.Point(443, 287)
        Me.lblPEMarks.Name = "lblPEMarks"
        Me.lblPEMarks.Size = New System.Drawing.Size(67, 13)
        Me.lblPEMarks.TabIndex = 19
        Me.lblPEMarks.Text = "All PE Marks"
        '
        'lblEngNum
        '
        Me.lblEngNum.AutoSize = True
        Me.lblEngNum.Location = New System.Drawing.Point(640, 161)
        Me.lblEngNum.Name = "lblEngNum"
        Me.lblEngNum.Size = New System.Drawing.Size(114, 13)
        Me.lblEngNum.TabIndex = 21
        Me.lblEngNum.Text = "English Class Numbers"
        '
        'lblMathNum
        '
        Me.lblMathNum.AutoSize = True
        Me.lblMathNum.Location = New System.Drawing.Point(640, 219)
        Me.lblMathNum.Name = "lblMathNum"
        Me.lblMathNum.Size = New System.Drawing.Size(104, 13)
        Me.lblMathNum.TabIndex = 22
        Me.lblMathNum.Text = "Math Class Numbers"
        '
        'lblPENum
        '
        Me.lblPENum.AutoSize = True
        Me.lblPENum.Location = New System.Drawing.Point(640, 287)
        Me.lblPENum.Name = "lblPENum"
        Me.lblPENum.Size = New System.Drawing.Size(94, 13)
        Me.lblPENum.TabIndex = 23
        Me.lblPENum.Text = "PE class numbers:"
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(446, 371)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(122, 39)
        Me.btnForm2.TabIndex = 24
        Me.btnForm2.Text = "Part 2 - Averages"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'btnPart3
        '
        Me.btnPart3.Location = New System.Drawing.Point(589, 371)
        Me.btnPart3.Name = "btnPart3"
        Me.btnPart3.Size = New System.Drawing.Size(120, 39)
        Me.btnPart3.TabIndex = 25
        Me.btnPart3.Text = "Part 3 - Searching Results"
        Me.btnPart3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPart3)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.lblPENum)
        Me.Controls.Add(Me.lblMathNum)
        Me.Controls.Add(Me.lblEngNum)
        Me.Controls.Add(Me.lblPEMarks)
        Me.Controls.Add(Me.lblMathsMarks)
        Me.Controls.Add(Me.lblEnglishMarks)
        Me.Controls.Add(Me.lblAllNames)
        Me.Controls.Add(Me.btnPeEnter)
        Me.Controls.Add(Me.btnMathsEnter)
        Me.Controls.Add(Me.btnEnglishEnter)
        Me.Controls.Add(Me.btnNameEnter)
        Me.Controls.Add(Me.lblMarks)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tbxPE)
        Me.Controls.Add(Me.lblPE)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblMaths)
        Me.Controls.Add(Me.lblEnglish)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tbxMaths)
        Me.Controls.Add(Me.tbxEnglish)
        Me.Controls.Add(Me.tbxName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbxEnglish As TextBox
    Friend WithEvents tbxMaths As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEnglish As Label
    Friend WithEvents lblMaths As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblPE As Label
    Friend WithEvents tbxPE As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents lblMarks As Label
    Friend WithEvents btnNameEnter As Button
    Friend WithEvents btnEnglishEnter As Button
    Friend WithEvents btnMathsEnter As Button
    Friend WithEvents btnPeEnter As Button
    Friend WithEvents lblAllNames As Label
    Friend WithEvents lblEnglishMarks As Label
    Friend WithEvents lblMathsMarks As Label
    Friend WithEvents lblPEMarks As Label
    Friend WithEvents lblEngNum As Label
    Friend WithEvents lblMathNum As Label
    Friend WithEvents lblPENum As Label
    Friend WithEvents btnForm2 As Button
    Friend WithEvents btnPart3 As Button
End Class
