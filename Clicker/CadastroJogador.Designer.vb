<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroJogador
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
        Panel1 = New Panel()
        senha_txt = New TextBox()
        email_txt = New TextBox()
        username_txt = New TextBox()
        nome_txt = New TextBox()
        registro_btn = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(senha_txt)
        Panel1.Controls.Add(email_txt)
        Panel1.Controls.Add(username_txt)
        Panel1.Controls.Add(nome_txt)
        Panel1.Controls.Add(registro_btn)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(31, 61)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(310, 356)
        Panel1.TabIndex = 0
        ' 
        ' senha_txt
        ' 
        senha_txt.Location = New Point(75, 215)
        senha_txt.Name = "senha_txt"
        senha_txt.Size = New Size(203, 23)
        senha_txt.TabIndex = 8
        ' 
        ' email_txt
        ' 
        email_txt.Location = New Point(75, 121)
        email_txt.Name = "email_txt"
        email_txt.Size = New Size(203, 23)
        email_txt.TabIndex = 7
        ' 
        ' username_txt
        ' 
        username_txt.Location = New Point(90, 167)
        username_txt.Name = "username_txt"
        username_txt.Size = New Size(188, 23)
        username_txt.TabIndex = 7
        ' 
        ' nome_txt
        ' 
        nome_txt.Location = New Point(75, 82)
        nome_txt.Name = "nome_txt"
        nome_txt.Size = New Size(203, 23)
        nome_txt.TabIndex = 6
        ' 
        ' registro_btn
        ' 
        registro_btn.Location = New Point(54, 285)
        registro_btn.Name = "registro_btn"
        registro_btn.Size = New Size(191, 48)
        registro_btn.TabIndex = 5
        registro_btn.Text = "Registrar-se"
        registro_btn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 4
        Label5.Text = "Senha:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 3
        Label4.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nome:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(124, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 0
        Label1.Text = "DADOS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.botao_voltar__1_
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' CadastroJogador
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "CadastroJogador"
        Text = "CadastroJogador"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents senha_txt As TextBox
    Friend WithEvents email_txt As TextBox
    Friend WithEvents username_txt As TextBox
    Friend WithEvents nome_txt As TextBox
    Friend WithEvents registro_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
