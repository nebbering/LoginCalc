Imports System.Drawing

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLogin.Parent = PictureBox2
        lblLogin.BackColor = Color.Transparent

        lblSenha.Parent = PictureBox2
        lblSenha.BackColor = Color.Transparent

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click



    End Sub
End Class