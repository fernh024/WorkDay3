Option Strict On

Public Class Form1

  
    Private Sub btnFindLarger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double



        If (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then

            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

            If (num1 < 0 Or num2 < 0) Then
                MessageBox.Show("Error: Please type positive number.", "Error")
                Return

            End If

            If num1 > num2 Then
                txtResult.Text = "The Larger Number is " & num1
            ElseIf num2 > num1 Then
                txtResult.Text = "The Larger Number is " & num2
            Else
                txtResult.Text = "the two are equal"
            End If

        Else
            MessageBox.Show("Error: Please type a number.", "ERROR")

        End If

    End Sub
End Class


' if not(isnumeric(txtfirstnum.text) and isnumeric(txtsecondnum.text)) then 
' MessageBox.Show("Error: Please type a number.", "ERROR")
' return

'this "return" terminates the event handler without actually reacing the end of the program.  cleans up the code 
' it also eliminates the elseif statement. 
' if user dows the worng thing it checks then return restarts the program.  

