<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroADM
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
        Label6 = New Label()
        tipo_cmb = New ComboBox()
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
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(tipo_cmb)
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
        Panel1.Location = New Point(24, 70)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(310, 356)
        Panel1.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(28, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 10
        Label6.Text = "Tipo:"
        ' 
        ' tipo_cmb
        ' 
        tipo_cmb.FormattingEnabled = True
        tipo_cmb.Items.AddRange(New Object() {"JOGADOR", "ADM"})
        tipo_cmb.Location = New Point(81, 235)
        tipo_cmb.Name = "tipo_cmb"
        tipo_cmb.Size = New Size(203, 23)
        tipo_cmb.TabIndex = 9
        ' 
        ' senha_txt
        ' 
        senha_txt.Location = New Point(81, 188)
        senha_txt.Name = "senha_txt"
        senha_txt.Size = New Size(203, 23)
        senha_txt.TabIndex = 8
        ' 
        ' email_txt
        ' 
        email_txt.Location = New Point(81, 94)
        email_txt.Name = "email_txt"
        email_txt.Size = New Size(203, 23)
        email_txt.TabIndex = 7
        ' 
        ' username_txt
        ' 
        username_txt.Location = New Point(96, 140)
        username_txt.Name = "username_txt"
        username_txt.Size = New Size(188, 23)
        username_txt.TabIndex = 7
        ' 
        ' nome_txt
        ' 
        nome_txt.Location = New Point(81, 55)
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
        Label5.Location = New Point(27, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 4
        Label5.Text = "Senha:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 3
        Label4.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 57)
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Moccasin
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(-12, -9)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(823, 49)
        Panel2.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.clickyOcu
        PictureBox1.Location = New Point(448, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(304, 367)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = My.Resources.Resources.botao_voltar__1_
        PictureBox2.Location = New Point(15, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' CadastroADM
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "CadastroADM"
        Text = "CadastroADM"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tipo_cmb As ComboBox
    Friend WithEvents senha_txt As TextBox
    Friend WithEvents email_txt As TextBox
    Friend WithEvents username_txt As TextBox
    Friend WithEvents nome_txt As TextBox
    Friend WithEvents registro_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        telaADM.Show()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
End Class
