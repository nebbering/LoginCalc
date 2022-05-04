Public Class Calculadora
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private operacao As String
    Private resultado As String
    Private valor As Double
    Private Operador As Boolean = False

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "1"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtResultado.Text = ""
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Concatenar()
        txtResultado.Text = txtResultado.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Concatenar()
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
        '        txtResultado.Text = 
    End Sub

    Public Sub AvaliaEFazOperacao()
        If Operador = True Then
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

    Public Sub Concatenar()

        If Operador = True Then

            txtResultado.Text = ""
            Operador = False

        ElseIf txtResultado.Text = "0" Then

            txtResultado.Text = ""

        End If
    End Sub

End Class