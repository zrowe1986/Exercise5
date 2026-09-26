Public Class Form1

    ' The concrete needs to be 4 inches deep, which is 0.33 feet
    Const DEPTH As Double = 0.33
    ' Cost of concrete per cubic yard
    Const COST_PER_CU_YD As Double = 80.0

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Variables to hold what the user types in
        Dim length As Double
        Dim width As Double

        ' Read the length from the textbox, make sure it's actually a number
        If Not Double.TryParse(txtLength.Text, length) Then
            MessageBox.Show("Please enter a valid number for length.")
            Return
        End If

        ' Same thing but for width
        If Not Double.TryParse(txtWidth.Text, width) Then
            MessageBox.Show("Please enter a valid number for width.")
            Return
        End If

        ' Volume = length times width times depth, gives us cubic feet
        Dim cuFt As Double = length * width * DEPTH
        ' There are 27 cubic feet in a cubic yard (3 x 3 x 3), so divide by 27
        Dim cuYd As Double = cuFt / 27
        ' Multiply cubic yards by the price per cubic yard to get total cost
        Dim cost As Double = cuYd * COST_PER_CU_YD

        ' Show both volume numbers in one label
        lblVolume.Text = "Volume: " & cuFt.ToString("N2") & " cu ft / " & cuYd.ToString("N2") & " cu yd"
        ' Show the cost
        lblCost.Text = "Cost: " & cost.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Empty out the textboxes and results so the form looks fresh again
        txtLength.Text = ""
        txtWidth.Text = ""
        lblVolume.Text = "Volume: 0.00 cu ft / 0.00 cu yd"
        lblCost.Text = "Cost: $0.00"
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' Close the form and end the program
        Me.Close()
    End Sub

End Class