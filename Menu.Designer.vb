<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAcessar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.lblBemVindo = New System.Windows.Forms.Label()
        Me.lblPerg = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 267)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnAcessar
        '
        Me.btnAcessar.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcessar.Location = New System.Drawing.Point(58, 154)
        Me.btnAcessar.Name = "btnAcessar"
        Me.btnAcessar.Size = New System.Drawing.Size(88, 35)
        Me.btnAcessar.TabIndex = 1
        Me.btnAcessar.Text = "ACESSAR O SISTEMA"
        Me.btnAcessar.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(182, 154)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(88, 35)
        Me.btnVoltar.TabIndex = 2
        Me.btnVoltar.Text = "VOLTAR"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'lblBemVindo
        '
        Me.lblBemVindo.AutoSize = True
        Me.lblBemVindo.BackColor = System.Drawing.Color.Transparent
        Me.lblBemVindo.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBemVindo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBemVindo.Location = New System.Drawing.Point(92, 85)
        Me.lblBemVindo.Name = "lblBemVindo"
        Me.lblBemVindo.Size = New System.Drawing.Size(155, 25)
        Me.lblBemVindo.TabIndex = 3
        Me.lblBemVindo.Text = "BEM-VINDO(A)!"
        Me.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPerg
        '
        Me.lblPerg.AutoSize = True
        Me.lblPerg.BackColor = System.Drawing.Color.Transparent
        Me.lblPerg.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerg.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblPerg.Location = New System.Drawing.Point(59, 110)
        Me.lblPerg.Name = "lblPerg"
        Me.lblPerg.Size = New System.Drawing.Size(211, 25)
        Me.lblPerg.TabIndex = 4
        Me.lblPerg.Text = "O QUE DESEJA FAZER?"
        Me.lblPerg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(340, 261)
        Me.Controls.Add(Me.lblPerg)
        Me.Controls.Add(Me.lblBemVindo)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnAcessar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents btnAcessar As Windows.Forms.Button
    Friend WithEvents btnVoltar As Windows.Forms.Button
    Friend WithEvents lblBemVindo As Windows.Forms.Label
    Friend WithEvents lblPerg As Windows.Forms.Label
End Class
