Public Class Form3
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        MsgBox("loading file")

        Dim sr As New System.IO.StreamReader("E:\SACPartC\markdata.csv")
        Dim resultArray(4, 8) As String
        Dim linesInFile As Integer = 1
        Dim i As Integer
        Dim columns As Integer
        Dim nameToFind As String
        Dim answer As Integer

        nameToFind = InputBox("What is the student's name?") ' pop up box appears and allows for the user to input a name

        Do Until sr.EndOfStream = True 'same file reading function that is in part B, just modified later on to read it
            linesInFile = linesInFile + 1
            lblAnswer.Text = sr.ReadLine & vbNewLine
            Dim testArray() As String = Split(lblAnswer.Text, Delimiter:=",")

            'MsgBox("next?")

            For columns = 0 To (testArray.Length - 1)
                resultArray(columns, linesInFile) = testArray(columns)
            Next

        Loop

        Dim found As Boolean

        For i = columns To linesInFile
            If resultArray(0, i) = nameToFind Then

                found = True 'when the value in the input box matches the csv, the entry has been found and it is true
                MsgBox("Results found!")
                lblAnswer.Text = resultArray(0, i) 'theoretically should present lblAnswer with the searched data from the csv file

            Else
                MsgBox("Student not found") 'if the data doesnt match, it should show this
            End If 'can glitch here a bit - needs to be fixed to exit the message box
        Next

        answer = MsgBox("Finished?", vbYesNo) 'asked if finished searching, and then closes the program if yes

        If answer = vbYes Then
            Application.Exit()
        End If


    End Sub
End Class