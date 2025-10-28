Imports Microsoft.VisualBasic.ApplicationServices

Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    ' Este código deve estar na classe do seu Form de Login (ex: Form1)
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click

        ' Garantir que a conexão ao banco está aberta antes de validar
        If ConexaoBD.conn.State <> ConnectionState.Open Then
            ConexaoBD.Conecta_banco()
        End If

        Dim user_input As String = nome_txt.Text
        Dim senha_input As String = senha_txt.Text

        ' CHAMA A NOVA FUNÇÃO QUE VALIDA E SALVA ID/PONTUAÇÃO NA MEMÓRIA GLOBAL
        Dim tipo As String = ConexaoBD.CarregarDadosUsuario(user_input, senha_input)

        If tipo = "JOGADOR" Then

            ' 1. A PONTUAÇÃO E ID JÁ ESTÃO EM EstadoGlobal.PlayerScore e PlayerID

            ' 2. Abre a tela
            Me.Hide()
            Dim telaJogador As New telaJogador()
            telaJogador.Show()

        ElseIf tipo = "ADM" Then
            ' ... (Lógica para ADM - ID e TIPO também estarão salvos no EstadoGlobal, se necessário) ...
            Me.Hide()
            Dim telaAdm As New telaADM()
            telaAdm.Show()

        ElseIf tipo = "" Then
            MessageBox.Show("Credenciais inválidas. Tente novamente.", "Login Falhou")

        ElseIf tipo = "ERRO" Then
            MessageBox.Show("Não foi possível processar o login devido a um erro no banco de dados.", "Erro Crítico")

        Else
            MessageBox.Show($"Tipo de usuário desconhecido: {tipo}", "Erro")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        CadastroJogador.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Comeco.Show()
    End Sub
End Class