<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jogoADM
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
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        contador_txt = New Label()
        click_btn = New Button()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AntiqueWhite
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-11, -6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(833, 48)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.botao_voltar__1_
        PictureBox1.Location = New Point(14, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.AntiqueWhite
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(click_btn)
        Panel2.Location = New Point(25, 75)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(442, 354)
        Panel2.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(contador_txt)
        Panel3.Location = New Point(20, 22)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(371, 60)
        Panel3.TabIndex = 2
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
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.clickyF
        PictureBox2.Location = New Point(479, 108)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(312, 295)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' jogoADM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "jogoADM"
        Text = "jogoADM"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents contador_txt As Label
    Friend WithEvents click_btn As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
