Public Class Form2


    Private Sub btnAverageEng_Click(sender As Object, e As EventArgs) Handles btnAverageEng.Click

        Dim sr As New System.IO.StreamReader("E:\SACPartB\markdata.csv")
        Dim linesInFile As Integer = 1
        Dim x As Integer = 0
        lblCheck.Text = x

        Do Until sr.EndOfStream = True
            linesInFile = linesInFile + 1
            lblCheck.Text = sr.ReadLine & vbNewLine
            Dim testArray() As String = Split(lblCheck.Text, Delimiter:=",")
            lblAvrEng.Text = testArray(1)
            MsgBox("next?", vbOK)
        Loop


    End Sub

    Private Sub btnAveragePE_Click(sender As Object, e As EventArgs) Handles btnAveragePE.Click


        Dim sr As New System.IO.StreamReader("E:\SACPartB\markdata.csv")
        Dim linesInFile As Integer = 1
        Dim x As Integer = 0
        lblCheck.Text = x

        Do Until sr.EndOfStream = True
            linesInFile = linesInFile + 1
            lblCheck.Text = sr.ReadLine & vbNewLine
            Dim testArray() As String = Split(lblCheck.Text, Delimiter:=",")
            lblAvrPe.Text = testArray(2)
            MsgBox("next?", vbOK)
        Loop

    End Sub

    Private Sub btnAverageMath_Click(sender As Object, e As EventArgs) Handles btnAverageMath.Click


        Dim sr As New System.IO.StreamReader("E:\SACPartB\markdata.csv")
        Dim linesInFile As Integer = 1
        Dim x As Integer = 0
        lblCheck.Text = x

        Do Until sr.EndOfStream = True
            linesInFile = linesInFile + 1
            lblCheck.Text = sr.ReadLine & vbNewLine
            Dim testArray() As String = Split(lblCheck.Text, Delimiter:=",")
            lblAvrMath.Text = testArray(3)
            MsgBox("next?", vbOK)
        Loop

    End Sub
End Class