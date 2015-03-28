<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvClienteGeneral = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.gbTelefonos = New System.Windows.Forms.GroupBox()
        Me.txtTelefono1ClienteGeneral = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono2ClienteGeneral = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbTipoClienteGeneral = New System.Windows.Forms.GroupBox()
        Me.cmbTipoCliente = New System.Windows.Forms.ComboBox()
        Me.gbFechaIngresoClienteGeneral = New System.Windows.Forms.GroupBox()
        Me.dtpFechaIngresoClienteGeneral = New System.Windows.Forms.DateTimePicker()
        Me.gbOligadoLlevarContabilidad = New System.Windows.Forms.GroupBox()
        Me.rbNOLlevaContabilidad = New System.Windows.Forms.RadioButton()
        Me.rbSILlevaContabilidad = New System.Windows.Forms.RadioButton()
        Me.gbNroResolucionContEspecial = New System.Windows.Forms.GroupBox()
        Me.txtnroResContEspecial = New System.Windows.Forms.TextBox()
        Me.gbIngresoObservaciones = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.gbInformacionContacto = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContactoClienteGeneral = New System.Windows.Forms.TextBox()
        Me.txtEmailClienteGeneral = New System.Windows.Forms.TextBox()
        Me.gbDatosClienteGeneral = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.lblIdClienteGeneral = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRucCiClienteGeneral = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellidoNombreComercial = New System.Windows.Forms.TextBox()
        Me.txtNombreRazonSocialClienteGeneral = New System.Windows.Forms.TextBox()
        Me.gbDireccionClienteGeneral = New System.Windows.Forms.GroupBox()
        Me.lblIdCiudad = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtDireccionUbicacionClienteGeneral = New System.Windows.Forms.TextBox()
        Me.txtDireccionFacturacionClienteGeneral = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvClienteGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbTelefonos.SuspendLayout()
        Me.gbTipoClienteGeneral.SuspendLayout()
        Me.gbFechaIngresoClienteGeneral.SuspendLayout()
        Me.gbOligadoLlevarContabilidad.SuspendLayout()
        Me.gbNroResolucionContEspecial.SuspendLayout()
        Me.gbIngresoObservaciones.SuspendLayout()
        Me.gbInformacionContacto.SuspendLayout()
        Me.gbDatosClienteGeneral.SuspendLayout()
        Me.gbDireccionClienteGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvClienteGeneral)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.gbTelefonos)
        Me.GroupBox1.Controls.Add(Me.gbTipoClienteGeneral)
        Me.GroupBox1.Controls.Add(Me.gbFechaIngresoClienteGeneral)
        Me.GroupBox1.Controls.Add(Me.gbOligadoLlevarContabilidad)
        Me.GroupBox1.Controls.Add(Me.gbNroResolucionContEspecial)
        Me.GroupBox1.Controls.Add(Me.gbIngresoObservaciones)
        Me.GroupBox1.Controls.Add(Me.gbInformacionContacto)
        Me.GroupBox1.Controls.Add(Me.gbDatosClienteGeneral)
        Me.GroupBox1.Controls.Add(Me.gbDireccionClienteGeneral)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 622)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'dgvClienteGeneral
        '
        Me.dgvClienteGeneral.AllowUserToAddRows = False
        Me.dgvClienteGeneral.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvClienteGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClienteGeneral.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvClienteGeneral.Location = New System.Drawing.Point(4, 343)
        Me.dgvClienteGeneral.Name = "dgvClienteGeneral"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvClienteGeneral.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvClienteGeneral.Size = New System.Drawing.Size(731, 276)
        Me.dgvClienteGeneral.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.txtBuscarCliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Consolas", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 39)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSCAR CLIENTE"
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(26, 14)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(697, 20)
        Me.txtBuscarCliente.TabIndex = 0
        '
        'gbTelefonos
        '
        Me.gbTelefonos.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbTelefonos.Controls.Add(Me.txtTelefono1ClienteGeneral)
        Me.gbTelefonos.Controls.Add(Me.Label7)
        Me.gbTelefonos.Controls.Add(Me.txtTelefono2ClienteGeneral)
        Me.gbTelefonos.Controls.Add(Me.Label8)
        Me.gbTelefonos.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTelefonos.Location = New System.Drawing.Point(549, 238)
        Me.gbTelefonos.Name = "gbTelefonos"
        Me.gbTelefonos.Size = New System.Drawing.Size(186, 65)
        Me.gbTelefonos.TabIndex = 46
        Me.gbTelefonos.TabStop = False
        Me.gbTelefonos.Text = "TELÉFONOS"
        '
        'txtTelefono1ClienteGeneral
        '
        Me.txtTelefono1ClienteGeneral.Location = New System.Drawing.Point(96, 13)
        Me.txtTelefono1ClienteGeneral.Name = "txtTelefono1ClienteGeneral"
        Me.txtTelefono1ClienteGeneral.Size = New System.Drawing.Size(82, 20)
        Me.txtTelefono1ClienteGeneral.TabIndex = 0
        Me.txtTelefono1ClienteGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "TELÉFONO Nº 1:"
        '
        'txtTelefono2ClienteGeneral
        '
        Me.txtTelefono2ClienteGeneral.Location = New System.Drawing.Point(97, 38)
        Me.txtTelefono2ClienteGeneral.Name = "txtTelefono2ClienteGeneral"
        Me.txtTelefono2ClienteGeneral.Size = New System.Drawing.Size(82, 20)
        Me.txtTelefono2ClienteGeneral.TabIndex = 1
        Me.txtTelefono2ClienteGeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "TELÉFONO Nº 2:"
        '
        'gbTipoClienteGeneral
        '
        Me.gbTipoClienteGeneral.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbTipoClienteGeneral.Controls.Add(Me.cmbTipoCliente)
        Me.gbTipoClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipoClienteGeneral.Location = New System.Drawing.Point(549, 192)
        Me.gbTipoClienteGeneral.Name = "gbTipoClienteGeneral"
        Me.gbTipoClienteGeneral.Size = New System.Drawing.Size(186, 46)
        Me.gbTipoClienteGeneral.TabIndex = 45
        Me.gbTipoClienteGeneral.TabStop = False
        Me.gbTipoClienteGeneral.Text = "TIPO DE CLIENTE"
        '
        'cmbTipoCliente
        '
        Me.cmbTipoCliente.FormattingEnabled = True
        Me.cmbTipoCliente.Items.AddRange(New Object() {"ALARMA", "GUARDIANIA", "ALARMA Y GUARDIANIA"})
        Me.cmbTipoCliente.Location = New System.Drawing.Point(6, 17)
        Me.cmbTipoCliente.Name = "cmbTipoCliente"
        Me.cmbTipoCliente.Size = New System.Drawing.Size(172, 21)
        Me.cmbTipoCliente.TabIndex = 2
        '
        'gbFechaIngresoClienteGeneral
        '
        Me.gbFechaIngresoClienteGeneral.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbFechaIngresoClienteGeneral.Controls.Add(Me.dtpFechaIngresoClienteGeneral)
        Me.gbFechaIngresoClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFechaIngresoClienteGeneral.Location = New System.Drawing.Point(549, 149)
        Me.gbFechaIngresoClienteGeneral.Name = "gbFechaIngresoClienteGeneral"
        Me.gbFechaIngresoClienteGeneral.Size = New System.Drawing.Size(186, 43)
        Me.gbFechaIngresoClienteGeneral.TabIndex = 44
        Me.gbFechaIngresoClienteGeneral.TabStop = False
        Me.gbFechaIngresoClienteGeneral.Text = "FECHA DE INGRESO"
        '
        'dtpFechaIngresoClienteGeneral
        '
        Me.dtpFechaIngresoClienteGeneral.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngresoClienteGeneral.Location = New System.Drawing.Point(6, 13)
        Me.dtpFechaIngresoClienteGeneral.Name = "dtpFechaIngresoClienteGeneral"
        Me.dtpFechaIngresoClienteGeneral.Size = New System.Drawing.Size(172, 20)
        Me.dtpFechaIngresoClienteGeneral.TabIndex = 1
        '
        'gbOligadoLlevarContabilidad
        '
        Me.gbOligadoLlevarContabilidad.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbOligadoLlevarContabilidad.Controls.Add(Me.rbNOLlevaContabilidad)
        Me.gbOligadoLlevarContabilidad.Controls.Add(Me.rbSILlevaContabilidad)
        Me.gbOligadoLlevarContabilidad.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOligadoLlevarContabilidad.Location = New System.Drawing.Point(549, 106)
        Me.gbOligadoLlevarContabilidad.Name = "gbOligadoLlevarContabilidad"
        Me.gbOligadoLlevarContabilidad.Size = New System.Drawing.Size(186, 43)
        Me.gbOligadoLlevarContabilidad.TabIndex = 41
        Me.gbOligadoLlevarContabilidad.TabStop = False
        Me.gbOligadoLlevarContabilidad.Text = "OBLIG LLEVAR CONTABILIDAD"
        '
        'rbNOLlevaContabilidad
        '
        Me.rbNOLlevaContabilidad.AutoSize = True
        Me.rbNOLlevaContabilidad.Location = New System.Drawing.Point(102, 17)
        Me.rbNOLlevaContabilidad.Name = "rbNOLlevaContabilidad"
        Me.rbNOLlevaContabilidad.Size = New System.Drawing.Size(37, 17)
        Me.rbNOLlevaContabilidad.TabIndex = 9
        Me.rbNOLlevaContabilidad.TabStop = True
        Me.rbNOLlevaContabilidad.Text = "NO"
        Me.rbNOLlevaContabilidad.UseVisualStyleBackColor = True
        '
        'rbSILlevaContabilidad
        '
        Me.rbSILlevaContabilidad.AutoSize = True
        Me.rbSILlevaContabilidad.Location = New System.Drawing.Point(46, 17)
        Me.rbSILlevaContabilidad.Name = "rbSILlevaContabilidad"
        Me.rbSILlevaContabilidad.Size = New System.Drawing.Size(37, 17)
        Me.rbSILlevaContabilidad.TabIndex = 8
        Me.rbSILlevaContabilidad.TabStop = True
        Me.rbSILlevaContabilidad.Text = "SI"
        Me.rbSILlevaContabilidad.UseVisualStyleBackColor = True
        '
        'gbNroResolucionContEspecial
        '
        Me.gbNroResolucionContEspecial.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbNroResolucionContEspecial.Controls.Add(Me.txtnroResContEspecial)
        Me.gbNroResolucionContEspecial.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbNroResolucionContEspecial.Location = New System.Drawing.Point(549, 60)
        Me.gbNroResolucionContEspecial.Name = "gbNroResolucionContEspecial"
        Me.gbNroResolucionContEspecial.Size = New System.Drawing.Size(186, 46)
        Me.gbNroResolucionContEspecial.TabIndex = 43
        Me.gbNroResolucionContEspecial.TabStop = False
        Me.gbNroResolucionContEspecial.Text = "Nº RESOL CONTRIB ESPECIAL"
        '
        'txtnroResContEspecial
        '
        Me.txtnroResContEspecial.Location = New System.Drawing.Point(6, 13)
        Me.txtnroResContEspecial.Name = "txtnroResContEspecial"
        Me.txtnroResContEspecial.Size = New System.Drawing.Size(172, 20)
        Me.txtnroResContEspecial.TabIndex = 6
        Me.txtnroResContEspecial.Text = "0"
        Me.txtnroResContEspecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbIngresoObservaciones
        '
        Me.gbIngresoObservaciones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbIngresoObservaciones.Controls.Add(Me.Label11)
        Me.gbIngresoObservaciones.Controls.Add(Me.txtObservaciones)
        Me.gbIngresoObservaciones.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIngresoObservaciones.Location = New System.Drawing.Point(4, 303)
        Me.gbIngresoObservaciones.Name = "gbIngresoObservaciones"
        Me.gbIngresoObservaciones.Size = New System.Drawing.Size(731, 40)
        Me.gbIngresoObservaciones.TabIndex = 42
        Me.gbIngresoObservaciones.TabStop = False
        Me.gbIngresoObservaciones.Text = "OBSERVACIONES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "OBSERVACIONES:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(183, 13)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(540, 20)
        Me.txtObservaciones.TabIndex = 0
        Me.txtObservaciones.Text = "..."
        '
        'gbInformacionContacto
        '
        Me.gbInformacionContacto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbInformacionContacto.Controls.Add(Me.Label10)
        Me.gbInformacionContacto.Controls.Add(Me.Label9)
        Me.gbInformacionContacto.Controls.Add(Me.txtContactoClienteGeneral)
        Me.gbInformacionContacto.Controls.Add(Me.txtEmailClienteGeneral)
        Me.gbInformacionContacto.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformacionContacto.Location = New System.Drawing.Point(4, 238)
        Me.gbInformacionContacto.Name = "gbInformacionContacto"
        Me.gbInformacionContacto.Size = New System.Drawing.Size(545, 65)
        Me.gbInformacionContacto.TabIndex = 39
        Me.gbInformacionContacto.TabStop = False
        Me.gbInformacionContacto.Text = "CONTÁCTO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "NOMBRE DE CONTACTO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "E-MAIL:"
        '
        'txtContactoClienteGeneral
        '
        Me.txtContactoClienteGeneral.Location = New System.Drawing.Point(183, 14)
        Me.txtContactoClienteGeneral.Name = "txtContactoClienteGeneral"
        Me.txtContactoClienteGeneral.Size = New System.Drawing.Size(354, 20)
        Me.txtContactoClienteGeneral.TabIndex = 3
        '
        'txtEmailClienteGeneral
        '
        Me.txtEmailClienteGeneral.Location = New System.Drawing.Point(183, 38)
        Me.txtEmailClienteGeneral.Name = "txtEmailClienteGeneral"
        Me.txtEmailClienteGeneral.Size = New System.Drawing.Size(171, 20)
        Me.txtEmailClienteGeneral.TabIndex = 2
        '
        'gbDatosClienteGeneral
        '
        Me.gbDatosClienteGeneral.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbDatosClienteGeneral.Controls.Add(Me.Label12)
        Me.gbDatosClienteGeneral.Controls.Add(Me.cmbTipoIdentificacion)
        Me.gbDatosClienteGeneral.Controls.Add(Me.lblIdClienteGeneral)
        Me.gbDatosClienteGeneral.Controls.Add(Me.Label3)
        Me.gbDatosClienteGeneral.Controls.Add(Me.Label2)
        Me.gbDatosClienteGeneral.Controls.Add(Me.txtRucCiClienteGeneral)
        Me.gbDatosClienteGeneral.Controls.Add(Me.Label1)
        Me.gbDatosClienteGeneral.Controls.Add(Me.txtApellidoNombreComercial)
        Me.gbDatosClienteGeneral.Controls.Add(Me.txtNombreRazonSocialClienteGeneral)
        Me.gbDatosClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosClienteGeneral.Location = New System.Drawing.Point(4, 60)
        Me.gbDatosClienteGeneral.Name = "gbDatosClienteGeneral"
        Me.gbDatosClienteGeneral.Size = New System.Drawing.Size(545, 89)
        Me.gbDatosClienteGeneral.TabIndex = 40
        Me.gbDatosClienteGeneral.TabStop = False
        Me.gbDatosClienteGeneral.Text = "CLIENTE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "TIPO IDENTIFICACIÓN:"
        '
        'cmbTipoIdentificacion
        '
        Me.cmbTipoIdentificacion.FormattingEnabled = True
        Me.cmbTipoIdentificacion.Items.AddRange(New Object() {"RUC", "CEDULA", "PASAPORTE", "VENTA A CONSUMIDOR FINAL", "IDENTIFICACION DEL EXTERIOR"})
        Me.cmbTipoIdentificacion.Location = New System.Drawing.Point(182, 12)
        Me.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion"
        Me.cmbTipoIdentificacion.Size = New System.Drawing.Size(149, 21)
        Me.cmbTipoIdentificacion.TabIndex = 7
        '
        'lblIdClienteGeneral
        '
        Me.lblIdClienteGeneral.AutoSize = True
        Me.lblIdClienteGeneral.Location = New System.Drawing.Point(57, 0)
        Me.lblIdClienteGeneral.Name = "lblIdClienteGeneral"
        Me.lblIdClienteGeneral.Size = New System.Drawing.Size(25, 13)
        Me.lblIdClienteGeneral.TabIndex = 6
        Me.lblIdClienteGeneral.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "APELLIDO / NOMBRE COMERCIAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOMBRE / RAZÓN SOCIAL:"
        '
        'txtRucCiClienteGeneral
        '
        Me.txtRucCiClienteGeneral.Location = New System.Drawing.Point(422, 13)
        Me.txtRucCiClienteGeneral.Name = "txtRucCiClienteGeneral"
        Me.txtRucCiClienteGeneral.Size = New System.Drawing.Size(115, 20)
        Me.txtRucCiClienteGeneral.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "RUC / C. I.:"
        '
        'txtApellidoNombreComercial
        '
        Me.txtApellidoNombreComercial.Location = New System.Drawing.Point(183, 61)
        Me.txtApellidoNombreComercial.Name = "txtApellidoNombreComercial"
        Me.txtApellidoNombreComercial.Size = New System.Drawing.Size(354, 20)
        Me.txtApellidoNombreComercial.TabIndex = 2
        '
        'txtNombreRazonSocialClienteGeneral
        '
        Me.txtNombreRazonSocialClienteGeneral.Location = New System.Drawing.Point(183, 37)
        Me.txtNombreRazonSocialClienteGeneral.Name = "txtNombreRazonSocialClienteGeneral"
        Me.txtNombreRazonSocialClienteGeneral.Size = New System.Drawing.Size(354, 20)
        Me.txtNombreRazonSocialClienteGeneral.TabIndex = 1
        '
        'gbDireccionClienteGeneral
        '
        Me.gbDireccionClienteGeneral.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbDireccionClienteGeneral.Controls.Add(Me.lblIdCiudad)
        Me.gbDireccionClienteGeneral.Controls.Add(Me.Label6)
        Me.gbDireccionClienteGeneral.Controls.Add(Me.Label5)
        Me.gbDireccionClienteGeneral.Controls.Add(Me.Label4)
        Me.gbDireccionClienteGeneral.Controls.Add(Me.txtCiudad)
        Me.gbDireccionClienteGeneral.Controls.Add(Me.txtDireccionUbicacionClienteGeneral)
        Me.gbDireccionClienteGeneral.Controls.Add(Me.txtDireccionFacturacionClienteGeneral)
        Me.gbDireccionClienteGeneral.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDireccionClienteGeneral.Location = New System.Drawing.Point(4, 149)
        Me.gbDireccionClienteGeneral.Name = "gbDireccionClienteGeneral"
        Me.gbDireccionClienteGeneral.Size = New System.Drawing.Size(545, 89)
        Me.gbDireccionClienteGeneral.TabIndex = 38
        Me.gbDireccionClienteGeneral.TabStop = False
        Me.gbDireccionClienteGeneral.Text = "UBICACIÓN"
        '
        'lblIdCiudad
        '
        Me.lblIdCiudad.AutoSize = True
        Me.lblIdCiudad.Location = New System.Drawing.Point(367, 15)
        Me.lblIdCiudad.Name = "lblIdCiudad"
        Me.lblIdCiudad.Size = New System.Drawing.Size(25, 13)
        Me.lblIdCiudad.TabIndex = 9
        Me.lblIdCiudad.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "DIRECCIÓN FACTURACIÓN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DIRECCIÓN UBICACIÓN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CIUDAD:"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(183, 13)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(177, 20)
        Me.txtCiudad.TabIndex = 5
        '
        'txtDireccionUbicacionClienteGeneral
        '
        Me.txtDireccionUbicacionClienteGeneral.Location = New System.Drawing.Point(183, 37)
        Me.txtDireccionUbicacionClienteGeneral.Name = "txtDireccionUbicacionClienteGeneral"
        Me.txtDireccionUbicacionClienteGeneral.Size = New System.Drawing.Size(354, 20)
        Me.txtDireccionUbicacionClienteGeneral.TabIndex = 3
        '
        'txtDireccionFacturacionClienteGeneral
        '
        Me.txtDireccionFacturacionClienteGeneral.Location = New System.Drawing.Point(183, 61)
        Me.txtDireccionFacturacionClienteGeneral.Name = "txtDireccionFacturacionClienteGeneral"
        Me.txtDireccionFacturacionClienteGeneral.Size = New System.Drawing.Size(354, 20)
        Me.txtDireccionFacturacionClienteGeneral.TabIndex = 4
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(740, 624)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvClienteGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbTelefonos.ResumeLayout(False)
        Me.gbTelefonos.PerformLayout()
        Me.gbTipoClienteGeneral.ResumeLayout(False)
        Me.gbFechaIngresoClienteGeneral.ResumeLayout(False)
        Me.gbOligadoLlevarContabilidad.ResumeLayout(False)
        Me.gbOligadoLlevarContabilidad.PerformLayout()
        Me.gbNroResolucionContEspecial.ResumeLayout(False)
        Me.gbNroResolucionContEspecial.PerformLayout()
        Me.gbIngresoObservaciones.ResumeLayout(False)
        Me.gbIngresoObservaciones.PerformLayout()
        Me.gbInformacionContacto.ResumeLayout(False)
        Me.gbInformacionContacto.PerformLayout()
        Me.gbDatosClienteGeneral.ResumeLayout(False)
        Me.gbDatosClienteGeneral.PerformLayout()
        Me.gbDireccionClienteGeneral.ResumeLayout(False)
        Me.gbDireccionClienteGeneral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscarCliente As System.Windows.Forms.TextBox
    Friend WithEvents gbTelefonos As System.Windows.Forms.GroupBox
    Friend WithEvents txtTelefono1ClienteGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono2ClienteGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbTipoClienteGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents gbFechaIngresoClienteGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaIngresoClienteGeneral As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbOligadoLlevarContabilidad As System.Windows.Forms.GroupBox
    Friend WithEvents rbNOLlevaContabilidad As System.Windows.Forms.RadioButton
    Friend WithEvents rbSILlevaContabilidad As System.Windows.Forms.RadioButton
    Friend WithEvents gbNroResolucionContEspecial As System.Windows.Forms.GroupBox
    Friend WithEvents txtnroResContEspecial As System.Windows.Forms.TextBox
    Friend WithEvents gbIngresoObservaciones As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents gbInformacionContacto As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtContactoClienteGeneral As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailClienteGeneral As System.Windows.Forms.TextBox
    Friend WithEvents gbDatosClienteGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoIdentificacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblIdClienteGeneral As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRucCiClienteGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoNombreComercial As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreRazonSocialClienteGeneral As System.Windows.Forms.TextBox
    Friend WithEvents gbDireccionClienteGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents lblIdCiudad As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionUbicacionClienteGeneral As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionFacturacionClienteGeneral As System.Windows.Forms.TextBox
    Friend WithEvents dgvClienteGeneral As System.Windows.Forms.DataGridView
End Class
