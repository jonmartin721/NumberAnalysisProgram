Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bttn_Analyze_Click(sender As Object, e As EventArgs) Handles bttn_Analyze.Click
        Dim arrayNumbers() As Double = New Double(9) {CDbl(txt_One.Text), CDbl(txt_Two.Text), CDbl(txt_Three.Text), CDbl(txt_Four.Text), CDbl(txt_Five.Text), CDbl(txt_Six.Text), CDbl(txt_Seven.Text), CDbl(txt_Eight.Text), CDbl(txt_Nine.Text), CDbl(txt_Ten.Text)}

        Dim min As Double = Double.MaxValue
        Dim max As Double = Double.MinValue
        Dim sum As Double
        Dim average As Double

        'Find Lowest and Highest value
        For x As Integer = 0 To 9
            'if lower than current min
            If arrayNumbers(x) < min Then min = arrayNumbers(x)
            'if higher than current max
            If arrayNumbers(x) > max Then max = arrayNumbers(x)
            'add number to running total
            sum += arrayNumbers(x)
        Next
        'calculate the average
        average = sum / 10

        lbl_AverageAnalyze.Text = average.ToString

        lbl_HighestAnalyze.Text = max.ToString

        lbl_LowestAnalyze.Text = min.ToString

        lbl_TotalAnalyze.Text = sum.ToString



    End Sub

    Private Sub bttn_Clear_Click(sender As Object, e As EventArgs) Handles bttn_Clear.Click
        txt_One.Text = String.Empty
        txt_Two.Text = String.Empty
        txt_Three.Text = String.Empty
        txt_Four.Text = String.Empty
        txt_Five.Text = String.Empty
        txt_Six.Text = String.Empty
        txt_Seven.Text = String.Empty
        txt_Eight.Text = String.Empty
        txt_Nine.Text = String.Empty
        txt_Ten.Text = String.Empty
        lbl_LowestAnalyze.Text = String.Empty
        lbl_HighestAnalyze.Text = String.Empty
        lbl_TotalAnalyze.Text = String.Empty
        lbl_AverageAnalyze.Text = String.Empty
        txt_One.Focus()


    End Sub

    Private Sub bttn_Exit_Click(sender As Object, e As EventArgs) Handles bttn_Exit.Click
        Application.Exit()

    End Sub

    Private Sub lbl_Highest_Click(sender As Object, e As EventArgs) Handles lbl_Highest.Click, lbl_Total.Click, lbl_Average.Click

    End Sub
End Class
