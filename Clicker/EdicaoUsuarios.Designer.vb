<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdicaoUsuarios
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
        components = New ComponentModel.Container()
        users_grid = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        TIPO = New DataGridViewTextBoxColumn()
        username = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        senha = New DataGridViewTextBoxColumn()
        contador = New DataGridViewTextBoxColumn()
        btn_excluir = New Button()
        Timer_atualizacao = New Timer(components)
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        CType(users_grid, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' users_grid
        ' 
        users_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        users_grid.Columns.AddRange(New DataGridViewColumn() {id, nome, TIPO, username, email, senha, contador})
        users_grid.Location = New Point(24, 173)
        users_grid.Name = "users_grid"
        users_grid.Size = New Size(745, 172)
        users_grid.TabIndex = 0
        ' 
        ' id
        ' 
        id.DataPropertyName = "ID"
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' nome
        ' 
        nome.DataPropertyName = "NOME"
        nome.HeaderText = "NOME"
        nome.Name = "nome"
        ' 
        ' TIPO
        ' 
        TIPO.DataPropertyName = "TIPO"
        TIPO.HeaderText = "TIPO"
        TIPO.Name = "TIPO"
        ' 
        ' username
        ' 
        username.DataPropertyName = "USERNAME"
        username.HeaderText = "USERNAME"
        username.Name = "username"
        ' 
        ' email
        ' 
        email.DataPropertyName = "EMAIL"
        email.HeaderText = "EMAIL"
        email.Name = "email"
        ' 
        ' senha
        ' 
        senha.DataPropertyName = "SENHA"
        senha.HeaderText = "SENHA"
        senha.Name = "senha"
        ' 
        ' contador
        ' 
        contador.DataPropertyName = "CONTADOR"
        contador.HeaderText = "CONTADOR"
        contador.Name = "contador"
        ' 
        ' btn_excluir
        ' 
        btn_excluir.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_excluir.Location = New Point(264, 370)
        btn_excluir.Name = "btn_excluir"
        btn_excluir.Size = New Size(254, 50)
        btn_excluir.TabIndex = 1
        btn_excluir.Text = "Excluir Usuário"
        btn_excluir.UseVisualStyleBackColor = True
        ' 
        ' Timer_atualizacao
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.botao_voltar__1_
        PictureBox1.Location = New Point(12, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(810, 48)
        Panel1.TabIndex = 4
        ' 
        ' EdicaoUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btn_excluir)
        Controls.Add(users_grid)
        Name = "EdicaoUsuarios"
        Text = "EdicaoUsuarios"
        CType(users_grid, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents users_grid As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents senha As DataGridViewTextBoxColumn
    Friend WithEvents contador As DataGridViewTextBoxColumn
    Friend WithEvents btn_excluir As Button
    Friend WithEvents Timer_atualizacao As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
