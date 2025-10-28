Public Class CadastroADM
    Private Sub registro_btn_Click(sender As Object, e As EventArgs) Handles registro_btn.Click
        InserirUsuario(nome_txt.Text, senha_txt.Text, tipo_cmb.Text, email_txt.Text, username_txt.Text)
        Me.Hide()
        telaADM.Show()
    End Sub

    Private Sub CadastroADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Conecta_banco()
    End Sub
End Class