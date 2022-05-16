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

        If txtLogin.Text = "asd" And txtSenha.Text = "dsa" Then

            Dim menu As Menu
            menu = New Menu
            Me.Hide()
            menu.Show()

        ElseIf txtLogin.Text = "" And txtSenha.Text = "" Then

            MessageBox.Show("Por favor, insira os dados de login.")

        ElseIf MessageBox.Show("Usuário e/ou senha incorreto!") Then

        End If


    End Sub
End Class