Public Class FormLogin

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text.ToUpper = "ADMINISTRADOR" And txtPassword.Text.ToUpper = "MASTER" Then
            Me.Hide()
            Dim menu As New MDIContable
            menu.Show()
        Else
            MsgBox("LA CONTRASEÑA Y ELNOMBRE DE USUARIO NO COICIDEN.", MsgBoxStyle.Exclamation, "MENSAJE DE EXCEPCIÓN.")
            txtUsuario.Text = ""
            txtPassword.Text = ""
            txtUsuario.Focus()
        End If
    End Sub
End Class