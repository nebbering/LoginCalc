Public Class Calculadora
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private operacao As String
    Private resultado As String
    Private valor As Double
    Private SeOperador As Boolean = False

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtResultado.Text = txtResultado.Text + "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtResultado.Text = txtResultado.Text + "1"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtResultado.Text = ""
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtResultado.Text = txtResultado.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtResultado.Text = txtResultado.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtResultado.Text = txtResultado.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtResultado.Text = txtResultado.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtResultado.Text = txtResultado.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtResultado.Text = txtResultado.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtResultado.Text = txtResultado.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtResultado.Text = txtResultado.Text + "9"
    End Sub

    Private Sub btnPonto_Click(sender As Object, e As EventArgs) Handles btnPonto.Click

        If InStr(txtResultado.Text, ".", CompareMethod.Text) = "0" Then
            txtResultado.Text = txtResultado.Text + "."
        End If

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        AvaliaEFazOperacao()
        operacao = "-"
    End Sub

    Private Sub btnAdi_Click(sender As Object, e As EventArgs) Handles btnAdi.Click
        AvaliaEFazOperacao()
        operacao = "+"
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        AvaliaEFazOperacao()
        operacao = "*"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        AvaliaEFazOperacao()
        operacao = "/"
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click

    End Sub

    Public Sub AvaliaEFazOperacao()
        If SeOperador = True Then
            valor = txtResultado.Text

            Select Case operacao
                Case "+"
                    resultado += valor
                Case "-"
                    resultado -= valor
                Case "*"
                    resultado *= valor
                Case "/"
                    resultado /= valor
            End Select
            txtResultado.Text = resultado

        Else
            txtResultado.Text = valor

        End If

    End Sub

End Class