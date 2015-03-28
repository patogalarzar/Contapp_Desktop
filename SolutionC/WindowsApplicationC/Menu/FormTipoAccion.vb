Public Class FormTipoAccion

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If rbFacturacion.Checked = True Then
            MsgBox("Facturación")
        ElseIf rbNotacredito.Checked = True Then
            MsgBox("Nota de Crédito")
        ElseIf rbCliente.Checked = True Then
            MsgBox("Cliente")

            'Valida que el formulario no se abra mas de una vez (si no cumple ninguna de las siguientes condicionales el form esta abierto, entonces lo muestra y trae al frente)
            If My.Forms.FormClientes Is Nothing Then 'pregunta si el form esta vacio (no se ha ejecutado ninguna instacia)
                My.Forms.FormClientes = New FormClientes   ' crea una nueva instacia
                My.Forms.MDIContable.ToolStripStatusLabel.Text = "Cliente" ' envia informacion delusuario que se logueo para auditoria
            End If
            If My.Forms.FormClientes.IsDisposed Then 'pregunta si el form ha sido utilizado (se ejecuto una instacia y se cerro el form)
                FormClientes = New FormClientes ' se reinicia la instacia creando una nueva
                My.Forms.MDIContable.ToolStripStatusLabel.Text = "Cliente" ' envia informacion delusuario que se logueo para auditoria
            End If
            FormClientes.Show() ' muestra el form
            FormClientes.BringToFront() ' trae al frente al form sobre los demas forms abiertos

        ElseIf rbCompras.Checked = True Then
            MsgBox("Compras")
        ElseIf rbBodega.Checked = True Then
            MsgBox("Bodega")
        ElseIf rbProveedor.Checked = True Then
            MsgBox("Proveedor")
        Else
            MsgBox("Seleccione una opción")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
