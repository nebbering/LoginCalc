Public Class Calculadora
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private operacao As String
    Private ValorResultado As Nullable(Of Double) = Nothing
    Private valor2 As Double
    Private Operador As Boolean

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtResultado.Text = "0"
        valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Concatenar()
        txtResultado.Text &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Concatenar()
        txtResultado.Text &= "1"
    End Sub


    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Concatenar()
        txtResultado.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Concatenar()
        txtResultado.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Concatenar()
        txtResultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Concatenar()
        txtResultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Concatenar()
        txtResultado.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Concatenar()
        txtResultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Concatenar()
        txtResultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Concatenar()
        txtResultado.Text &= "9"
    End Sub

    Private Sub btnPonto_Click(sender As Object, e As EventArgs) Handles btnPonto.Click
        Concatenar()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = "0" Then
            txtResultado.Text &= "."
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
        AvaliaEFazOperacao()
        operacao = ""

    End Sub

    Public Sub AvaliaEFazOperacao()
        Operador = True
        valor2 = Val(txtResultado.Text)

        If ValorResultado IsNot Nothing Then

            Select Case operacao
                Case "+"
                    ValorResultado = ValorResultado + valor2
                Case "-"
                    ValorResultado -= valor2
                Case "*"
                    ValorResultado *= valor2
                Case "/"
                    ValorResultado /= valor2
            End Select
            txtResultado.Text = ValorResultado

        Else
            ValorResultado = valor2

        End If

    End Sub

    Public Sub Concatenar()

        If Operador = True Then

            txtResultado.Text = ""
            Operador = False

        ElseIf txtResultado.Text = "0" Then

            txtResultado.Text = ""

        End If
    End Sub

End Class