<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Gcliente = New System.Windows.Forms.GroupBox()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cbpais = New System.Windows.Forms.ComboBox()
        Me.cbNacionalidad = New System.Windows.Forms.ComboBox()
        Me.cbID = New System.Windows.Forms.ComboBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtapellido2 = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Gcliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gcliente
        '
        Me.Gcliente.BackColor = System.Drawing.Color.Transparent
        Me.Gcliente.Controls.Add(Me.cbRol)
        Me.Gcliente.Controls.Add(Me.cbSexo)
        Me.Gcliente.Controls.Add(Me.cbpais)
        Me.Gcliente.Controls.Add(Me.cbNacionalidad)
        Me.Gcliente.Controls.Add(Me.cbID)
        Me.Gcliente.Controls.Add(Me.lblRol)
        Me.Gcliente.Controls.Add(Me.Label13)
        Me.Gcliente.Controls.Add(Me.Label4)
        Me.Gcliente.Controls.Add(Me.txtFechaNacimiento)
        Me.Gcliente.Controls.Add(Me.txtnombre)
        Me.Gcliente.Controls.Add(Me.txtapellido)
        Me.Gcliente.Controls.Add(Me.txtapellido2)
        Me.Gcliente.Controls.Add(Me.txtedad)
        Me.Gcliente.Controls.Add(Me.Label12)
        Me.Gcliente.Controls.Add(Me.Label11)
        Me.Gcliente.Controls.Add(Me.Label10)
        Me.Gcliente.Controls.Add(Me.Label9)
        Me.Gcliente.Controls.Add(Me.Label8)
        Me.Gcliente.Controls.Add(Me.lblEdad)
        Me.Gcliente.Controls.Add(Me.Label6)
        Me.Gcliente.Controls.Add(Me.btnAceptar)
        Me.Gcliente.Controls.Add(Me.txtclave)
        Me.Gcliente.Controls.Add(Me.txtusuario)
        Me.Gcliente.Controls.Add(Me.Label3)
        Me.Gcliente.Controls.Add(Me.Label2)
        Me.Gcliente.Controls.Add(Me.lblTitulo1)
        Me.Gcliente.Location = New System.Drawing.Point(507, 14)
        Me.Gcliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gcliente.Name = "Gcliente"
        Me.Gcliente.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gcliente.Size = New System.Drawing.Size(578, 885)
        Me.Gcliente.TabIndex = 2
        Me.Gcliente.TabStop = False
        '
        'cbRol
        '
        Me.cbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Location = New System.Drawing.Point(268, 760)
        Me.cbRol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(204, 30)
        Me.cbRol.TabIndex = 32
        '
        'cbSexo
        '
        Me.cbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(272, 455)
        Me.cbSexo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(200, 30)
        Me.cbSexo.TabIndex = 31
        '
        'cbpais
        '
        Me.cbpais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpais.FormattingEnabled = True
        Me.cbpais.Location = New System.Drawing.Point(272, 392)
        Me.cbpais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbpais.Name = "cbpais"
        Me.cbpais.Size = New System.Drawing.Size(200, 30)
        Me.cbpais.TabIndex = 30
        '
        'cbNacionalidad
        '
        Me.cbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNacionalidad.FormattingEnabled = True
        Me.cbNacionalidad.Location = New System.Drawing.Point(272, 338)
        Me.cbNacionalidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbNacionalidad.Name = "cbNacionalidad"
        Me.cbNacionalidad.Size = New System.Drawing.Size(200, 30)
        Me.cbNacionalidad.TabIndex = 29
        '
        'cbID
        '
        Me.cbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbID.FormattingEnabled = True
        Me.cbID.Location = New System.Drawing.Point(272, 280)
        Me.cbID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbID.Name = "cbID"
        Me.cbID.Size = New System.Drawing.Size(200, 30)
        Me.cbID.TabIndex = 28
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.Black
        Me.lblRol.Location = New System.Drawing.Point(204, 760)
        Me.lblRol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(47, 35)
        Me.lblRol.TabIndex = 26
        Me.lblRol.Text = "Rol"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(100, 280)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 35)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Identificacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(117, 392)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 35)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Pais Origen "
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(272, 514)
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(200, 28)
        Me.txtFechaNacimiento.TabIndex = 21
        '
        'txtnombre
        '
        Me.txtnombre.AcceptsTab = True
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(272, 111)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(200, 28)
        Me.txtnombre.TabIndex = 1
        '
        'txtapellido
        '
        Me.txtapellido.AcceptsTab = True
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(272, 165)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(200, 28)
        Me.txtapellido.TabIndex = 2
        '
        'txtapellido2
        '
        Me.txtapellido2.AcceptsTab = True
        Me.txtapellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido2.Location = New System.Drawing.Point(272, 220)
        Me.txtapellido2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtapellido2.Name = "txtapellido2"
        Me.txtapellido2.Size = New System.Drawing.Size(200, 28)
        Me.txtapellido2.TabIndex = 3
        '
        'txtedad
        '
        Me.txtedad.AcceptsTab = True
        Me.txtedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedad.Location = New System.Drawing.Point(268, 692)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.ReadOnly = True
        Me.txtedad.Size = New System.Drawing.Size(204, 28)
        Me.txtedad.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(99, 165)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 35)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Primer apellido"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(74, 220)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 35)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Segundo apellido "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(99, 338)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 35)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Nacionalidad "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(188, 455)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 35)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Sexo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(40, 511)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 35)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fecha de nacimiento"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.ForeColor = System.Drawing.Color.Black
        Me.lblEdad.Location = New System.Drawing.Point(188, 689)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(66, 35)
        Me.lblEdad.TabIndex = 8
        Me.lblEdad.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(165, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 35)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nombre"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAceptar.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Location = New System.Drawing.Point(286, 832)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(144, 43)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Registrarse"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtclave
        '
        Me.txtclave.AcceptsTab = True
        Me.txtclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(268, 635)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(204, 28)
        Me.txtclave.TabIndex = 11
        Me.txtclave.UseSystemPasswordChar = True
        '
        'txtusuario
        '
        Me.txtusuario.AcceptsTab = True
        Me.txtusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(268, 571)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(204, 28)
        Me.txtusuario.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(134, 632)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(159, 568)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario "
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Sitka Heading", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo1.Location = New System.Drawing.Point(36, 25)
        Me.lblTitulo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(521, 63)
        Me.lblTitulo1.TabIndex = 0
        Me.lblTitulo1.Text = "¡Bienvenido a CASIVAGO!"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerrar.Image = Global.Presentacion.My.Resources.Resources.cerrar_sesion
        Me.btnCerrar.Location = New System.Drawing.Point(1016, 918)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(144, 57)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Presentacion.My.Resources.Resources.f_elconfidencial_com_original_9ea_2b2_df3_9ea2b2df3d0eb0a4bd7042e4ed08d84f
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1173, 989)
        Me.ControlBox = False
        Me.Controls.Add(Me.Gcliente)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1173, 989)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1173, 989)
        Me.Name = "Registrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.Gcliente.ResumeLayout(False)
        Me.Gcliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gcliente As Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As Windows.Forms.Button
    Friend WithEvents txtnombre As Windows.Forms.TextBox
    Friend WithEvents txtapellido As Windows.Forms.TextBox
    Friend WithEvents txtapellido2 As Windows.Forms.TextBox
    Friend WithEvents txtedad As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents lblEdad As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents btnAceptar As Windows.Forms.Button
    Friend WithEvents txtclave As Windows.Forms.TextBox
    Friend WithEvents txtusuario As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents lblTitulo1 As Windows.Forms.Label
    Friend WithEvents txtFechaNacimiento As Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents lblRol As Windows.Forms.Label
    Friend WithEvents cbSexo As Windows.Forms.ComboBox
    Friend WithEvents cbpais As Windows.Forms.ComboBox
    Friend WithEvents cbNacionalidad As Windows.Forms.ComboBox
    Friend WithEvents cbID As Windows.Forms.ComboBox
    Friend WithEvents cbRol As Windows.Forms.ComboBox
End Class
