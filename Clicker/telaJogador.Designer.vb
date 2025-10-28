<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class telaJogador
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
        click_btn = New Button()
        contador_txt = New Label()
        btn_volta = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(btn_volta, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' click_btn
        ' 
        click_btn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        click_btn.Location = New Point(74, 278)
        click_btn.Name = "click_btn"
        click_btn.Size = New Size(291, 56)
        click_btn.TabIndex = 0
        click_btn.Text = "CLICAR"
        click_btn.UseVisualStyleBackColor = True
        ' 
        ' contador_txt
        ' 
        contador_txt.AutoSize = True
        contador_txt.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        contador_txt.Location = New Point(13, 16)
        contador_txt.Name = "contador_txt"
        contador_txt.Size = New Size(164, 32)
        contador_txt.TabIndex = 1
        contador_txt.Text = "CONTADOR: "
        ' 
        ' btn_volta
        ' 
        btn_volta.BackgroundImageLayout = ImageLayout.None
        btn_volta.Image = My.Resources.Resources.botao_voltar__1_
        btn_volta.Location = New Point(12, 12)
        btn_volta.Name = "btn_volta"
        btn_volta.Size = New Size(35, 35)
        btn_volta.SizeMode = PictureBoxSizeMode.StretchImage
        btn_volta.TabIndex = 3
        btn_volta.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Honeydew
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(click_btn)
        Panel1.Location = New Point(12, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(442, 354)
        Panel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(contador_txt)
        Panel2.Location = New Point(20, 22)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(371, 60)
        Panel2.TabIndex = 2
        ' 
        ' telaJogador
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(btn_volta)
        Name = "telaJogador"
        Text = "telaJogador"
        CType(btn_volta, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents click_btn As Button
    Friend WithEvents contador_txt As Label
    Friend WithEvents btn_volta As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
