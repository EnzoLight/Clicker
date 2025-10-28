Public Class jogoADM
    Private Sub click_btn_Click(sender As Object, e As EventArgs)
        ' 1. Atualiza o contador na memória
        PlayerScore += 1

        ' 2. Atualiza o Label na tela
        contador_txt.Text = "CONTADOR: " & PlayerScore.ToString

        ' 3. Salva no banco de dados 
        atualizarClicks()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        telaADM.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class