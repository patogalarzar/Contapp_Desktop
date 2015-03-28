Public Class FormLogin
    Public Sub validarUsuario()
        If txtUsuario.Text.ToUpper = "ADMIN" And txtPassword.Text.ToUpper = "MASTER" Then
            Me.Hide()
            Dim menu As New MDIContable
            menu.Show()
        Else
            MsgBox("EL NOMBRE DE USUARIO Y LA CONTRASEÑA NO COINCIDEN.", MsgBoxStyle.OkOnly, "MENSAJE DE EXCEPCIÓN.")
            txtUsuario.Text = ""
            txtPassword.Text = ""
            txtUsuario.Focus()
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        validarUsuario()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        ' si se pulsa enter
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            validarUsuario()
        End If
    End Sub
End Class