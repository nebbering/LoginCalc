Imports System.Drawing
Imports System.Windows.Forms

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLogin.Parent = PictureBox2
        lblLogin.BackColor = Color.Transparent

        lblSenha.Parent = PictureBox2
        lblSenha.BackColor = Color.Transparent

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If txtLogin.Text = "@nebbering97" And txtSenha.Text = "321" Then

            Dim calc As Calculadora
            calc = New Calculadora
            calc.Show()

        ElseIf MessageBox.Show("Usuário e/ou senha incorreto!") Then

        End If



    End Sub
End Class