<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroAdmin
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
        Me.gridConsulta = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cbpais = New System.Windows.Forms.ComboBox()
        Me.cbNacionalidad = New System.Windows.Forms.ComboBox()
        Me.cbID = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtapellido2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.gridConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDatos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridConsulta
        '
        Me.gridConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridConsulta.Location = New System.Drawing.Point(58, 493)
        Me.gridConsulta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gridConsulta.Name = "gridConsulta"
        Me.gridConsulta.RowHeadersWidth = 62
        Me.gridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridConsulta.Size = New System.Drawing.Size(1254, 376)
        Me.gridConsulta.TabIndex = 31
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(998, 419)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(144, 43)
        Me.btnEliminar.TabIndex = 33
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(1169, 419)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(144, 43)
        Me.btnModificar.TabIndex = 32
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.Location = New System.Drawing.Point(363, 440)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(144, 35)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(62, 436)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 35)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Filtro"
        '
        'txtfiltro
        '
        Me.txtfiltro.AcceptsTab = True
        Me.txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfiltro.Location = New System.Drawing.Point(140, 443)
        Me.txtfiltro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(202, 28)
        Me.txtfiltro.TabIndex = 37
        '
        'cbSexo
        '
        Me.cbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(727, 154)
        Me.cbSexo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(200, 30)
        Me.cbSexo.TabIndex = 60
        '
        'cbpais
        '
        Me.cbpais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpais.FormattingEnabled = True
        Me.cbpais.Location = New System.Drawing.Point(727, 22)
        Me.cbpais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbpais.Name = "cbpais"
        Me.cbpais.Size = New System.Drawing.Size(200, 30)
        Me.cbpais.TabIndex = 59
        '
        'cbNacionalidad
        '
        Me.cbNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNacionalidad.FormattingEnabled = True
        Me.cbNacionalidad.Location = New System.Drawing.Point(219, 296)
        Me.cbNacionalidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbNacionalidad.Name = "cbNacionalidad"
        Me.cbNacionalidad.Size = New System.Drawing.Size(200, 30)
        Me.cbNacionalidad.TabIndex = 58
        '
        'cbID
        '
        Me.cbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbID.FormattingEnabled = True
        Me.cbID.Location = New System.Drawing.Point(219, 225)
        Me.cbID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbID.Name = "cbID"
        Me.cbID.Size = New System.Drawing.Size(200, 30)
        Me.cbID.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(33, 222)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 35)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Identificacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(571, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 35)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Pais Origen "
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(727, 99)
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(200, 28)
        Me.txtFechaNacimiento.TabIndex = 53
        '
        'txtnombre
        '
        Me.txtnombre.AcceptsTab = True
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(219, 29)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(200, 28)
        Me.txtnombre.TabIndex = 39
        '
        'txtapellido
        '
        Me.txtapellido.AcceptsTab = True
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(221, 96)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(200, 28)
        Me.txtapellido.TabIndex = 41
        '
        'txtapellido2
        '
        Me.txtapellido2.AcceptsTab = True
        Me.txtapellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido2.Location = New System.Drawing.Point(219, 158)
        Me.txtapellido2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtapellido2.Name = "txtapellido2"
        Me.txtapellido2.Size = New System.Drawing.Size(200, 28)
        Me.txtapellido2.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(21, 99)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 35)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Primer apellido"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 158)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 35)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Segundo apellido "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(33, 291)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 35)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Nacionalidad "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(645, 151)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 35)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Sexo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(487, 93)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 35)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Fecha de nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(90, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 35)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Nombre"
        '
        'txtclave
        '
        Me.txtclave.AcceptsTab = True
        Me.txtclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(725, 296)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(204, 28)
        Me.txtclave.TabIndex = 49
        Me.txtclave.UseSystemPasswordChar = True
        '
        'txtusuario
        '
        Me.txtusuario.AcceptsTab = True
        Me.txtusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(727, 228)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(204, 28)
        Me.txtusuario.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(571, 291)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 35)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(603, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 35)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Usuario "
        '
        'GBDatos
        '
        Me.GBDatos.BackColor = System.Drawing.Color.Transparent
        Me.GBDatos.Controls.Add(Me.PictureBox1)
        Me.GBDatos.Controls.Add(Me.Label6)
        Me.GBDatos.Controls.Add(Me.cbSexo)
        Me.GBDatos.Controls.Add(Me.txtnombre)
        Me.GBDatos.Controls.Add(Me.Label9)
        Me.GBDatos.Controls.Add(Me.txtFechaNacimiento)
        Me.GBDatos.Controls.Add(Me.txtclave)
        Me.GBDatos.Controls.Add(Me.cbpais)
        Me.GBDatos.Controls.Add(Me.txtusuario)
        Me.GBDatos.Controls.Add(Me.Label3)
        Me.GBDatos.Controls.Add(Me.Label12)
        Me.GBDatos.Controls.Add(Me.Label2)
        Me.GBDatos.Controls.Add(Me.Label8)
        Me.GBDatos.Controls.Add(Me.Label4)
        Me.GBDatos.Controls.Add(Me.cbNacionalidad)
        Me.GBDatos.Controls.Add(Me.txtapellido)
        Me.GBDatos.Controls.Add(Me.cbID)
        Me.GBDatos.Controls.Add(Me.Label11)
        Me.GBDatos.Controls.Add(Me.Label10)
        Me.GBDatos.Controls.Add(Me.Label13)
        Me.GBDatos.Controls.Add(Me.txtapellido2)
        Me.GBDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GBDatos.Location = New System.Drawing.Point(68, 14)
        Me.GBDatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBDatos.Size = New System.Drawing.Size(1244, 363)
        Me.GBDatos.TabIndex = 61
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.editar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(938, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 217)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'RegistroAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1399, 922)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.gridConsulta)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RegistroAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistroAdmin"
        CType(Me.gridConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridConsulta As Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As Windows.Forms.Button
    Friend WithEvents btnModificar As Windows.Forms.Button
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtfiltro As Windows.Forms.TextBox
    Friend WithEvents cbSexo As Windows.Forms.ComboBox
    Friend WithEvents cbpais As Windows.Forms.ComboBox
    Friend WithEvents cbNacionalidad As Windows.Forms.ComboBox
    Friend WithEvents cbID As Windows.Forms.ComboBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtFechaNacimiento As Windows.Forms.DateTimePicker
    Friend WithEvents txtnombre As Windows.Forms.TextBox
    Friend WithEvents txtapellido As Windows.Forms.TextBox
    Friend WithEvents txtapellido2 As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtclave As Windows.Forms.TextBox
    Friend WithEvents txtusuario As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents GBDatos As Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
