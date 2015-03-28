Public Class FormTipoAccion
    Dim clientes As New FormClientes

    Private Function OpenSubForm(ByVal form As Form) As Boolean
        'Chequeo si ya está abierto.
        For Each f As Form In Application.OpenForms
            'Si está abierto devuelvo False (no se puede abrir).
            If f.Name = form.Name Then
                Return False
            End If
        Next

        'Si se llega a este punto es porque no está abierto.
        'Abro el formulario.
        form.MdiParent = MDIContable
        form.Show()

        'Indico apertura exitosa.
        Return True
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If rbFacturacion.Checked = True Then
            MsgBox("Facturación")
        ElseIf rbNotacredito.Checked = True Then
            MsgBox("Nota de Crédito")
        ElseIf rbCliente.Checked = True Then
            'Valida que el formulario no se abra mas de una vez (si el valor false es el form esta abierto, entonces lo muestra y trae al frente)
            Me.Hide()
            clientes.Show()
            'OpenSubForm(clientes)

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
