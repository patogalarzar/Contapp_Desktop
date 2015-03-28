<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTipoAccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbTipoAccion = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.rbNotacredito = New System.Windows.Forms.RadioButton()
        Me.rbBodega = New System.Windows.Forms.RadioButton()
        Me.rbCompras = New System.Windows.Forms.RadioButton()
        Me.rbFacturacion = New System.Windows.Forms.RadioButton()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbTipoAccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTipoAccion
        '
        Me.gbTipoAccion.Controls.Add(Me.Label1)
        Me.gbTipoAccion.Controls.Add(Me.rbProveedor)
        Me.gbTipoAccion.Controls.Add(Me.rbCliente)
        Me.gbTipoAccion.Controls.Add(Me.rbNotacredito)
        Me.gbTipoAccion.Controls.Add(Me.rbBodega)
        Me.gbTipoAccion.Controls.Add(Me.rbCompras)
        Me.gbTipoAccion.Controls.Add(Me.rbFacturacion)
        Me.gbTipoAccion.Controls.Add(Me.btnCancelar)
        Me.gbTipoAccion.Controls.Add(Me.btnAceptar)
        Me.gbTipoAccion.Controls.Add(Me.Label2)
        Me.gbTipoAccion.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipoAccion.Location = New System.Drawing.Point(0, -8)
        Me.gbTipoAccion.Name = "gbTipoAccion"
        Me.gbTipoAccion.Size = New System.Drawing.Size(368, 218)
        Me.gbTipoAccion.TabIndex = 0
        Me.gbTipoAccion.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Escoge una opción"
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProveedor.Location = New System.Drawing.Point(213, 117)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(98, 22)
        Me.rbProveedor.TabIndex = 7
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCliente.Location = New System.Drawing.Point(50, 117)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(82, 22)
        Me.rbCliente.TabIndex = 4
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'rbNotacredito
        '
        Me.rbNotacredito.AutoSize = True
        Me.rbNotacredito.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotacredito.Location = New System.Drawing.Point(50, 90)
        Me.rbNotacredito.Name = "rbNotacredito"
        Me.rbNotacredito.Size = New System.Drawing.Size(146, 22)
        Me.rbNotacredito.TabIndex = 3
        Me.rbNotacredito.TabStop = True
        Me.rbNotacredito.Text = "Nota de Crédito"
        Me.rbNotacredito.UseVisualStyleBackColor = True
        '
        'rbBodega
        '
        Me.rbBodega.AutoSize = True
        Me.rbBodega.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBodega.Location = New System.Drawing.Point(213, 90)
        Me.rbBodega.Name = "rbBodega"
        Me.rbBodega.Size = New System.Drawing.Size(74, 22)
        Me.rbBodega.TabIndex = 6
        Me.rbBodega.TabStop = True
        Me.rbBodega.Text = "Bodega"
        Me.rbBodega.UseVisualStyleBackColor = True
        '
        'rbCompras
        '
        Me.rbCompras.AutoSize = True
        Me.rbCompras.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCompras.Location = New System.Drawing.Point(213, 63)
        Me.rbCompras.Name = "rbCompras"
        Me.rbCompras.Size = New System.Drawing.Size(82, 22)
        Me.rbCompras.TabIndex = 5
        Me.rbCompras.TabStop = True
        Me.rbCompras.Text = "Compras"
        Me.rbCompras.UseVisualStyleBackColor = True
        '
        'rbFacturacion
        '
        Me.rbFacturacion.AutoSize = True
        Me.rbFacturacion.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFacturacion.Location = New System.Drawing.Point(50, 63)
        Me.rbFacturacion.Name = "rbFacturacion"
        Me.rbFacturacion.Size = New System.Drawing.Size(114, 22)
        Me.rbFacturacion.TabIndex = 2
        Me.rbFacturacion.TabStop = True
        Me.rbFacturacion.Text = "Facturación"
        Me.rbFacturacion.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Location = New System.Drawing.Point(26, 164)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(155, 45)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Location = New System.Drawing.Point(187, 164)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(155, 45)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(24, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(315, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "____________________________________________"
        '
        'FormTipoAccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(368, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbTipoAccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormTipoAccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbTipoAccion.ResumeLayout(False)
        Me.gbTipoAccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbTipoAccion As System.Windows.Forms.GroupBox
    Friend WithEvents rbProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbNotacredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbBodega As System.Windows.Forms.RadioButton
    Friend WithEvents rbCompras As System.Windows.Forms.RadioButton
    Friend WithEvents rbFacturacion As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
