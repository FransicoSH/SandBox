<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Itinerario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmbPais = New System.Windows.Forms.ComboBox()
        Me.LblPais = New System.Windows.Forms.Label()
        Me.CmbAvion = New System.Windows.Forms.ComboBox()
        Me.LbAvion = New System.Windows.Forms.Label()
        Me.LblFechaHoraLlegada = New System.Windows.Forms.Label()
        Me.DgvItinerario = New System.Windows.Forms.DataGridView()
        Me.LblFechaHoraSalida = New System.Windows.Forms.Label()
        Me.CmbAeropuerto = New System.Windows.Forms.ComboBox()
        Me.LblAeropuerto = New System.Windows.Forms.Label()
        Me.DtpFechaHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaHoraLlegada = New System.Windows.Forms.DateTimePicker()
        Me.dtHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtHoraLLegada = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DgvItinerario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbPais
        '
        Me.CmbPais.FormattingEnabled = True
        Me.CmbPais.Location = New System.Drawing.Point(235, 83)
        Me.CmbPais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbPais.Name = "CmbPais"
        Me.CmbPais.Size = New System.Drawing.Size(293, 28)
        Me.CmbPais.TabIndex = 37
        '
        'LblPais
        '
        Me.LblPais.AutoSize = True
        Me.LblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPais.Location = New System.Drawing.Point(27, 95)
        Me.LblPais.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPais.Name = "LblPais"
        Me.LblPais.Size = New System.Drawing.Size(143, 20)
        Me.LblPais.TabIndex = 38
        Me.LblPais.Text = "País de Destino"
        '
        'CmbAvion
        '
        Me.CmbAvion.FormattingEnabled = True
        Me.CmbAvion.Location = New System.Drawing.Point(235, 37)
        Me.CmbAvion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbAvion.Name = "CmbAvion"
        Me.CmbAvion.Size = New System.Drawing.Size(293, 28)
        Me.CmbAvion.TabIndex = 30
        '
        'LbAvion
        '
        Me.LbAvion.AutoSize = True
        Me.LbAvion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAvion.Location = New System.Drawing.Point(27, 49)
        Me.LbAvion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAvion.Name = "LbAvion"
        Me.LbAvion.Size = New System.Drawing.Size(55, 20)
        Me.LbAvion.TabIndex = 32
        Me.LbAvion.Text = "Avion"
        '
        'LblFechaHoraLlegada
        '
        Me.LblFechaHoraLlegada.AutoSize = True
        Me.LblFechaHoraLlegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaHoraLlegada.Location = New System.Drawing.Point(27, 91)
        Me.LblFechaHoraLlegada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFechaHoraLlegada.Name = "LblFechaHoraLlegada"
        Me.LblFechaHoraLlegada.Size = New System.Drawing.Size(194, 20)
        Me.LblFechaHoraLlegada.TabIndex = 36
        Me.LblFechaHoraLlegada.Text = "Fecha y Hora Llegada"
        '
        'DgvItinerario
        '
        Me.DgvItinerario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvItinerario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.DgvItinerario.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvItinerario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvItinerario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItinerario.Location = New System.Drawing.Point(36, 548)
        Me.DgvItinerario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvItinerario.Name = "DgvItinerario"
        Me.DgvItinerario.RowHeadersWidth = 62
        Me.DgvItinerario.Size = New System.Drawing.Size(1091, 296)
        Me.DgvItinerario.TabIndex = 35
        '
        'LblFechaHoraSalida
        '
        Me.LblFechaHoraSalida.AutoSize = True
        Me.LblFechaHoraSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaHoraSalida.Location = New System.Drawing.Point(27, 39)
        Me.LblFechaHoraSalida.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFechaHoraSalida.Name = "LblFechaHoraSalida"
        Me.LblFechaHoraSalida.Size = New System.Drawing.Size(180, 20)
        Me.LblFechaHoraSalida.TabIndex = 34
        Me.LblFechaHoraSalida.Text = "Fecha y Hora Salida"
        '
        'CmbAeropuerto
        '
        Me.CmbAeropuerto.FormattingEnabled = True
        Me.CmbAeropuerto.Location = New System.Drawing.Point(235, 139)
        Me.CmbAeropuerto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbAeropuerto.Name = "CmbAeropuerto"
        Me.CmbAeropuerto.Size = New System.Drawing.Size(293, 28)
        Me.CmbAeropuerto.TabIndex = 41
        '
        'LblAeropuerto
        '
        Me.LblAeropuerto.AutoSize = True
        Me.LblAeropuerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAeropuerto.Location = New System.Drawing.Point(27, 147)
        Me.LblAeropuerto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAeropuerto.Name = "LblAeropuerto"
        Me.LblAeropuerto.Size = New System.Drawing.Size(200, 20)
        Me.LblAeropuerto.TabIndex = 42
        Me.LblAeropuerto.Text = "Aeropuerto de destino "
        '
        'DtpFechaHoraSalida
        '
        Me.DtpFechaHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaHoraSalida.Location = New System.Drawing.Point(237, 33)
        Me.DtpFechaHoraSalida.Name = "DtpFechaHoraSalida"
        Me.DtpFechaHoraSalida.Size = New System.Drawing.Size(123, 26)
        Me.DtpFechaHoraSalida.TabIndex = 45
        '
        'DtpFechaHoraLlegada
        '
        Me.DtpFechaHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaHoraLlegada.Location = New System.Drawing.Point(237, 89)
        Me.DtpFechaHoraLlegada.Name = "DtpFechaHoraLlegada"
        Me.DtpFechaHoraLlegada.Size = New System.Drawing.Size(123, 26)
        Me.DtpFechaHoraLlegada.TabIndex = 47
        '
        'dtHoraSalida
        '
        Me.dtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHoraSalida.Location = New System.Drawing.Point(387, 33)
        Me.dtHoraSalida.Name = "dtHoraSalida"
        Me.dtHoraSalida.Size = New System.Drawing.Size(123, 26)
        Me.dtHoraSalida.TabIndex = 48
        '
        'dtHoraLLegada
        '
        Me.dtHoraLLegada.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dtHoraLLegada.Checked = False
        Me.dtHoraLLegada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHoraLLegada.Location = New System.Drawing.Point(387, 89)
        Me.dtHoraLLegada.Name = "dtHoraLLegada"
        Me.dtHoraLLegada.Size = New System.Drawing.Size(123, 26)
        Me.dtHoraLLegada.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblFechaHoraSalida)
        Me.GroupBox1.Controls.Add(Me.LblFechaHoraLlegada)
        Me.GroupBox1.Controls.Add(Me.DtpFechaHoraSalida)
        Me.GroupBox1.Controls.Add(Me.dtHoraLLegada)
        Me.GroupBox1.Controls.Add(Me.DtpFechaHoraLlegada)
        Me.GroupBox1.Controls.Add(Me.dtHoraSalida)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(36, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 157)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LbAvion)
        Me.GroupBox2.Controls.Add(Me.CmbAvion)
        Me.GroupBox2.Controls.Add(Me.LblPais)
        Me.GroupBox2.Controls.Add(Me.CmbPais)
        Me.GroupBox2.Controls.Add(Me.CmbAeropuerto)
        Me.GroupBox2.Controls.Add(Me.LblAeropuerto)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 211)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Avion"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.cerrar_sesion
        Me.Button1.Location = New System.Drawing.Point(1016, 871)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 44)
        Me.Button1.TabIndex = 51
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.itinerario__2_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(689, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 487)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.Presentacion.My.Resources.Resources.boton_x
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.Location = New System.Drawing.Point(344, 450)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(144, 58)
        Me.BtnCancelar.TabIndex = 39
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBorrar.FlatAppearance.BorderSize = 0
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Image = Global.Presentacion.My.Resources.Resources.borrar
        Me.BtnBorrar.Location = New System.Drawing.Point(203, 450)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(133, 58)
        Me.BtnBorrar.TabIndex = 33
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.Presentacion.My.Resources.Resources.salvar
        Me.BtnGuardar.Location = New System.Drawing.Point(36, 450)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(142, 57)
        Me.BtnGuardar.TabIndex = 31
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Itinerario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 993)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.DgvItinerario)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1176, 993)
        Me.MinimumSize = New System.Drawing.Size(1176, 993)
        Me.Name = "Itinerario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Itinerarios"
        CType(Me.DgvItinerario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancelar As Windows.Forms.Button
    Friend WithEvents CmbPais As Windows.Forms.ComboBox
    Friend WithEvents LblPais As Windows.Forms.Label
    Friend WithEvents CmbAvion As Windows.Forms.ComboBox
    Friend WithEvents LbAvion As Windows.Forms.Label
    Friend WithEvents LblFechaHoraLlegada As Windows.Forms.Label
    Friend WithEvents DgvItinerario As Windows.Forms.DataGridView
    Friend WithEvents BtnBorrar As Windows.Forms.Button
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents LblFechaHoraSalida As Windows.Forms.Label
    Friend WithEvents CmbAeropuerto As Windows.Forms.ComboBox
    Friend WithEvents LblAeropuerto As Windows.Forms.Label
    Friend WithEvents DtpFechaHoraSalida As Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaHoraLlegada As Windows.Forms.DateTimePicker
    Friend WithEvents dtHoraSalida As Windows.Forms.DateTimePicker
    Friend WithEvents dtHoraLLegada As Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
End Class
