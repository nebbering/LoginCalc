Imports System.Drawing
Imports System.Windows.Forms

Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblBemVindo.Parent = PictureBox1
        lblBemVindo.BackColor = Color.Transparent

        lblPerg.Parent = PictureBox1
        lblPerg.BackColor = Color.Transparent

    End Sub
End Class