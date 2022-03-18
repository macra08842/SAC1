Public Class Form1

    Dim txtName As String
    Dim txtEnglish As Integer
    Dim txtMaths As Integer
    Dim txtPE As Integer
    Dim x As Integer = 0 'number of people in the class accumilative
    Dim y As String = "  people  "
    Dim i As String = "  English:  "
    Dim j As String = "  Maths:  "
    Dim a As String = "  PE:  " 'defines a string variable so then it can be simply connected with an integer
    Dim answer As Integer
    Dim t As Integer = 0
    Dim r As Integer = 0
    Dim q As Integer = 0

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click 'enters the student data, with a single student's full results 

        txtName = tbxName.Text 'connects the variables to the textboxes
        txtEnglish = tbxEnglish.Text
        txtMaths = tbxMaths.Text
        txtPE = tbxPE.Text

        If x >= 0 Then
            x = x + 1
            lblClass.Text = x & y
        End If 'sees how many people there are in the year level and adds one every time the button is clicked

        lblMarks.Text = txtName & i & txtEnglish & j & txtMaths & a & txtPE

        answer = MsgBox("Add another student?", vbYesNo) 'asked if another student wants to be added

        If answer = vbYes Then
            tbxName.Clear() 'clears all textboxes
            tbxEnglish.Clear()
            tbxMaths.Clear()
            tbxPE.Clear()
        Else
            Application.Exit()
        End If 'closes application if they click no
    End Sub

    Private Sub btnNameEnter_Click(sender As Object, e As EventArgs) Handles btnNameEnter.Click

        txtName = tbxName.Text 'connects the variables to the textboxes

        lblAllNames.Text = txtName 'lists names individually 


    End Sub

    Private Sub btnEnglishEnter_Click(sender As Object, e As EventArgs) Handles btnEnglishEnter.Click

        txtEnglish = tbxEnglish.Text 'connects the variables to the textboxes

        lblEnglishMarks.Text = txtEnglish

        If t >= 0 Then
            t = t + 1
            lblEngNum.Text = t & y 'total number of students in class
        End If

    End Sub

    Private Sub btnMathsEnter_Click(sender As Object, e As EventArgs) Handles btnMathsEnter.Click

        txtMaths = tbxMaths.Text 'connects the variables to the textboxes

        lblMathsMarks.Text = txtMaths

        If r >= 0 Then
            r = r + 1
            lblMathNum.Text = r & y 'total number of students in class
        End If

    End Sub

    Private Sub btnPeEnter_Click(sender As Object, e As EventArgs) Handles btnPeEnter.Click

        txtPE = tbxPE.Text 'connects the variables to the textboxes

        lblPEMarks.Text = txtPE

        If q >= 0 Then
            q = q + 1
            lblPENum.Text = q & y 'total number of students in class
        End If

    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnPart3_Click(sender As Object, e As EventArgs) Handles btnPart3.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
