<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        LinkLabel1 = New LinkLabel()
        senha_txt = New TextBox()
        nome_txt = New TextBox()
        btn_logar = New Button()
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
        Panel1.BackColor = Color.DarkSeaGreen
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(senha_txt)
        Panel1.Controls.Add(nome_txt)
        Panel1.Controls.Add(btn_logar)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(168, 67)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(471, 338)
        Panel1.TabIndex = 0
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(196, 279)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(66, 15)
        LinkLabel1.TabIndex = 10
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "registrar-se"
        ' 
        ' senha_txt
        ' 
        senha_txt.Location = New Point(147, 165)
        senha_txt.Name = "senha_txt"
        senha_txt.Size = New Size(211, 23)
        senha_txt.TabIndex = 9
        ' 
        ' nome_txt
        ' 
        nome_txt.Location = New Point(147, 102)
        nome_txt.Name = "nome_txt"
        nome_txt.Size = New Size(247, 23)
        nome_txt.TabIndex = 6
        ' 
        ' btn_logar
        ' 
        btn_logar.Location = New Point(130, 228)
        btn_logar.Name = "btn_logar"
        btn_logar.Size = New Size(204, 48)
        btn_logar.TabIndex = 5
        btn_logar.Text = "LOGAR"
        btn_logar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(50, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 2
        Label3.Text = "Usrname/Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(99, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "Senha:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(196, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 32)
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
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents senha_txt As TextBox
    Friend WithEvents nome_txt As TextBox
    Friend WithEvents btn_logar As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
