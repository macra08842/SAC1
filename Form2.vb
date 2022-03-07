Public Class Form2

    Dim y As Integer = 6 ' y = 6 number of rows so then an average can be derived
    Dim z As Integer = 3



    Private Sub btnAverageEng_Click(sender As Object, e As EventArgs) Handles btnAverageEng.Click


        Dim sr As New System.IO.StreamReader("E:\SACPartB\markdata.csv") 'opens the csv file
        Dim linesInFile As Integer = 1 'defines the lines
        Dim x As Integer = 0 'one array, seperated by commas
        lblCheck.Text = x
        lblNumEng.Text = y 'number of students in the class



        Do Until sr.EndOfStream = True 'do this function until the end of the file
            linesInFile = linesInFile + 1 'allows for a row with headings
            lblCheck.Text = sr.ReadLine & vbNewLine 'reads one line and moves to the next until the end of the file
            Dim testArray() As String = Split(lblCheck.Text, Delimiter:=",") 'defines the array as a string and definesthe delimiter as a comma
            lblAvrEng.Text = Val(testArray(1)) / y ' presents only the 2nd column of information in the label
            MsgBox("Done?", vbOK) ' continues the code down the next line

        Loop

        'this process is the same for every other button listed below


    End Sub

    Private Sub btnAveragePE_Click(sender As Object, e As EventArgs) Handles btnAveragePE.Click


        Dim sr As New System.IO.StreamReader("E:\SACPartB\markdata.csv")
        Dim linesInFile As Integer = 1
        Dim x As Integer = 0
        lblCheck.Text = x
        lblNumPe.Text = y

        Do Until sr.EndOfStream = True
            linesInFile = linesInFile + 1
            lblCheck.Text = sr.ReadLine & vbNewLine
            Dim testArray() As String = Split(lblCheck.Text, Delimiter:=",")
            lblAvrPe.Text = testArray(2) / y
            MsgBox("Done?", vbOK)

        Loop

    End Sub

    Private Sub btnAverageMath_Click(sender As Object, e As EventArgs) Handles btnAverageMath.Click


        Dim sr As New System.IO.StreamReader("E:\SACPartB\markdata.csv")
        Dim linesInFile As Integer = 1
        Dim x As Integer = 0
        lblCheck.Text = x
        lblNumMath.Text = y

        Do Until sr.EndOfStream = True
            linesInFile = linesInFile + 1
            lblCheck.Text = sr.ReadLine & vbNewLine
            Dim testArray() As String = Split(lblCheck.Text, Delimiter:=",")
            lblAvrMath.Text = testArray(3) / y
            MsgBox("Done?", vbOK)

        Loop

    End Sub

    Private Sub btnStuAvr_Click(sender As Object, e As EventArgs) Handles btnStuAvr.Click

        Dim sr As New System.IO.StreamReader("E:\SACPartB\markdata.csv")
        Dim linesInFile As Integer = 1
        Dim x As Integer = 0
        lblCheck.Text = x
        lblNumMath.Text = y

        Do Until sr.EndOfStream = True
            linesInFile = linesInFile + 1
            lblCheck.Text = sr.ReadLine & vbNewLine
            Dim testArray() As String = Split(lblCheck.Text, Delimiter:=",")
            lblStudAvr.Text = (Val(testArray(1)) + Val(testArray(2)) + Val(testArray(3))) / z
            MsgBox("Done?", vbOK)

        Loop

    End Sub
End Class