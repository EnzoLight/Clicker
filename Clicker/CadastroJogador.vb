Public Class CadastroJogador
    Private Sub registro_btn_Click(sender As Object, e As EventArgs) Handles registro_btn.Click
        InserirUsuario(nome_txt.Text, senha_txt.Text, "JOGADOR", email_txt.Text, username_txt.Text)
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class