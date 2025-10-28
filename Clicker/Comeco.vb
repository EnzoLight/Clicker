Public Class Comeco
    Sub Comeco_Load() Handles MyBase.Load
        Conecta_banco()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class
