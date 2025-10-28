Public Class telaJogador

    Private Sub telaJogador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa o contador na tela com o valor da memória global
        contador_txt.Text = "CONTADOR: " & EstadoGlobal.PlayerScore.ToString()
    End Sub
    Private Sub click_btn_Click(sender As Object, e As EventArgs) Handles click_btn.Click

        ' 1. Atualiza o contador na memória
        EstadoGlobal.PlayerScore += 1

        ' 2. Atualiza o Label na tela
        contador_txt.Text = "CONTADOR: " & EstadoGlobal.PlayerScore.ToString()

        ' 3. Salva no banco de dados 
        atualizarClicks()

    End Sub

    Private Sub contador_txt_Click(sender As Object, e As EventArgs) Handles contador_txt.Click

    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btn_volta_Click(sender As Object, e As EventArgs) Handles btn_volta.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class