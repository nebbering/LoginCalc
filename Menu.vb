Imports System.Drawing
Imports System.Windows.Forms

Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblBemVindo.Parent = PictureBox1
        lblBemVindo.BackColor = Color.Transparent

        lblPerg.Parent = PictureBox1
        lblPerg.BackColor = Color.Transparent

    End Sub

    Private Sub btnAcessar_Click(sender As Object, e As EventArgs) Handles btnAcessar.Click

        Dim access As Calculadora
        access = New Calculadora
        access.Show()
        Me.Close()

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        Dim volt As Login
        volt = New Login
        volt.Show()
        Me.Close()

    End Sub


End Class