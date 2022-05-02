Public Class Calculadora
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtResultado.Text = "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtResultado.Text = "1"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtResultado.Text = "0"
    End Sub
End Class