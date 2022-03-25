Public Class Form4

    'code in btnEnglish_Click is the same for all other buttons, just with different values

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click

        Dim sr As New System.IO.StreamReader("E:\SACPartD\markdata (2).csv") ' defines the file so it can be read
        Dim lines() As String = System.IO.File.ReadAllLines("E:\SACPartD\markdata (2).csv") ' attaches the csv file to the array

        For Each line In lines(1) 'for each line in the csv, read all lines and then sort
            Array.Sort(lines)
        Next
        lblResultsE.Text = (lines(1)) 'display the sorted results from the point 1 in a label
        MsgBox("done!") 'message box pops up to confirm this happening

    End Sub

    Private Sub btnMaths_Click(sender As Object, e As EventArgs) Handles btnMaths.Click

        Dim sr As New System.IO.StreamReader("E:\SACPartD\markdata (2).csv")
        Dim lines() As String = System.IO.File.ReadAllLines("E:\SACPartD\markdata (2).csv")

        For Each line In lines(2)
            Array.Sort(lines)
        Next
        lblResultsM.Text = (lines(2))
        MsgBox("done!")

    End Sub

    Private Sub btnPe_Click(sender As Object, e As EventArgs) Handles btnPe.Click

        Dim sr As New System.IO.StreamReader("E:\SACPartD\markdata (2).csv")
        Dim lines() As String = System.IO.File.ReadAllLines("E:\SACPartD\markdata (2).csv")

        For Each line In lines(3)
            Array.Sort(lines)
        Next
        Label1.Text = (lines(3))
        MsgBox("done!")


    End Sub
End Class