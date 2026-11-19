Public Class CalculatorForm
    Dim N1, N2, Result As Integer

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Try
            N1 = txtNumber1.Text
            N2 = txtNumber2.Text
            Result = N1 * N2
            txtResult.Text = Result
        Catch
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnDivInt_Click(sender As Object, e As EventArgs) Handles btnDivInt.Click
        Try
            N1 = txtNumber1.Text
            N2 = txtNumber2.Text
            Result = N1 \ N2
            txtResult.Text = Result
        Catch ex As DivideByZeroException
            MessageBox.Show("Can't divide by zero.")
        Catch ex As Exception
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnDivDec_Click(sender As Object, e As EventArgs) Handles btnDivDec.Click
        Dim N1D, N2D, ResultD As Decimal
        Try
            N1D = txtNumber1.Text
            N2D = txtNumber2.Text
            ResultD = N1D / N2D
            txtResult.Text = ResultD
        Catch ex As DivideByZeroException
            MessageBox.Show("Can't divide by zero.")
        Catch
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            N1 = txtNumber1.Text
            N2 = txtNumber2.Text
            Result = N1 Mod N2
            txtResult.Text = Result
        Catch ex As DivideByZeroException
            MessageBox.Show("Can't divide by zero.")
        Catch
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        wlcomeForm.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        N1 = 0
        N2 = 0
        Result = 0
        txtNumber1.Text = ""
        txtNumber2.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Try
            N1 = txtNumber1.Text
            N2 = txtNumber2.Text
            Result = Math.Max(N1, N2)
            txtResult.Text = Result
        Catch ex As Exception
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnMIn_Click(sender As Object, e As EventArgs) Handles btnMIn.Click
        Try
            N1 = txtNumber1.Text
            N2 = txtNumber2.Text
            Result = Math.Min(N1, N2)
            txtResult.Text = Result
        Catch ex As Exception
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnSqrRoot_Click(sender As Object, e As EventArgs) Handles btnSqrRoot.Click
        Dim N1D, ResultD As Double
        Try
            N1D = txtNumber1.Text
            txtNumber2.Text = ""
            ResultD = Math.Sqrt(N1D)
            txtResult.Text = ResultD
        Catch ex As Exception
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnPow_Click(sender As Object, e As EventArgs) Handles btnPow.Click
        Dim N1D, N2D, ResultD As Double
        Try
            N1D = txtNumber1.Text
            N2D = txtNumber2.Text
            ResultD = Math.Pow(N1D, N2D)
            txtResult.Text = ResultD
        Catch ex As Exception
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnCeiling_Click(sender As Object, e As EventArgs) Handles btnCeiling.Click
        Dim N1D, N2D, ResultD As Double
        Try
            N1D = txtNumber1.Text
            txtNumber2.Text = ""
            ResultD = Math.Ceiling(N1D)
            txtResult.Text = ResultD
        Catch ex As Exception
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnFloor_Click(sender As Object, e As EventArgs) Handles btnFloor.Click
        Dim N1D, N2D, ResultD As Double
        Try
            N1D = txtNumber1.Text
            txtNumber2.Text = ""
            ResultD = Math.Floor(N1D)
            txtResult.Text = ResultD
        Catch ex As Exception
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub

    Private Sub btnRnd1_Click(sender As Object, e As EventArgs) Handles btnRnd1.Click
        txtResult.Text = Int(Rnd() * 101)
        txtNumber1.Text = ""
        txtNumber2.Text = ""
    End Sub

    Private Sub btnRnd2_Click(sender As Object, e As EventArgs) Handles btnRnd2.Click
        txtResult.Text = Int(Rnd() * 100) + 1
        txtNumber1.Text = ""
        txtNumber2.Text = ""
    End Sub

    Private Sub CalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Try
            N1 = txtNumber1.Text
            N2 = txtNumber2.Text
            Result = N1 - N2
            txtResult.Text = Result
        Catch
            MessageBox.Show("Please enter a number.")
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            N1 = txtNumber1.Text
            N2 = txtNumber2.Text
            Result = N1 + N2
            txtResult.Text = Result
        Catch
            MessageBox.Show("Please enter a number.")
        End Try
    End Sub
End Class
