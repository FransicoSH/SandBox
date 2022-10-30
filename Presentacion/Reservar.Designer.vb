<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reservar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBxItinerario = New System.Windows.Forms.GroupBox()
        Me.DtgReservas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbAeropuerto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtRegreso = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBusacr = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtSalida = New System.Windows.Forms.DateTimePicker()
        Me.lbSalida = New System.Windows.Forms.Label()
        Me.nupPasajeros = New System.Windows.Forms.NumericUpDown()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbRegreso = New System.Windows.Forms.Label()
        Me.UI_ShadowPanel1 = New UIDC.UI_ShadowPanel()
        Me.GBxItinerario.SuspendLayout()
        CType(Me.DtgReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupPasajeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBxItinerario
        '
        Me.GBxItinerario.BackColor = System.Drawing.Color.Transparent
        Me.GBxItinerario.Controls.Add(Me.DtgReservas)
        Me.GBxItinerario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBxItinerario.ForeColor = System.Drawing.Color.Black
        Me.GBxItinerario.Location = New System.Drawing.Point(489, 274)
        Me.GBxItinerario.Name = "GBxItinerario"
        Me.GBxItinerario.Size = New System.Drawing.Size(982, 417)
        Me.GBxItinerario.TabIndex = 21
        Me.GBxItinerario.TabStop = False
        Me.GBxItinerario.Text = "Itinerarios"
        Me.GBxItinerario.Visible = False
        '
        'DtgReservas
        '
        Me.DtgReservas.AllowUserToAddRows = False
        Me.DtgReservas.AllowUserToResizeColumns = False
        Me.DtgReservas.AllowUserToResizeRows = False
        Me.DtgReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgReservas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.DtgReservas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DtgReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DtgReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgReservas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgReservas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DtgReservas.GridColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.DtgReservas.Location = New System.Drawing.Point(6, 25)
        Me.DtgReservas.MultiSelect = False
        Me.DtgReservas.Name = "DtgReservas"
        Me.DtgReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DtgReservas.RowHeadersVisible = False
        Me.DtgReservas.RowHeadersWidth = 62
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.DtgReservas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DtgReservas.RowTemplate.Height = 28
        Me.DtgReservas.Size = New System.Drawing.Size(950, 369)
        Me.DtgReservas.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.cerrar_sesion
        Me.Button1.Location = New System.Drawing.Point(1336, 709)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 48)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Column1"
        Me.DataGridViewImageColumn1.MinimumWidth = 8
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 150
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.logoProyecto
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(495, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(452, 255)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'cmbAeropuerto
        '
        Me.cmbAeropuerto.ForeColor = System.Drawing.Color.Black
        Me.cmbAeropuerto.FormattingEnabled = True
        Me.cmbAeropuerto.Location = New System.Drawing.Point(171, 486)
        Me.cmbAeropuerto.Name = "cmbAeropuerto"
        Me.cmbAeropuerto.Size = New System.Drawing.Size(229, 28)
        Me.cmbAeropuerto.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(76, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Salida "
        '
        'DtRegreso
        '
        Me.DtRegreso.CustomFormat = ""
        Me.DtRegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtRegreso.Location = New System.Drawing.Point(171, 314)
        Me.DtRegreso.Name = "DtRegreso"
        Me.DtRegreso.Size = New System.Drawing.Size(110, 26)
        Me.DtRegreso.TabIndex = 11
        Me.DtRegreso.Value = New Date(2021, 11, 5, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(46, 491)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Aeropuerto"
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(172, 142)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(148, 26)
        Me.txtDestino.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(74, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Origen "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(64, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Regreso"
        '
        'btnBusacr
        '
        Me.btnBusacr.ForeColor = System.Drawing.Color.Black
        Me.btnBusacr.Location = New System.Drawing.Point(183, 542)
        Me.btnBusacr.Name = "btnBusacr"
        Me.btnBusacr.Size = New System.Drawing.Size(140, 48)
        Me.btnBusacr.TabIndex = 1
        Me.btnBusacr.Text = "Buscar Vuelos"
        Me.btnBusacr.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(56, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Pasajeros"
        '
        'DtSalida
        '
        Me.DtSalida.CustomFormat = "DD-mm-YYYY"
        Me.DtSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtSalida.Location = New System.Drawing.Point(172, 228)
        Me.DtSalida.Name = "DtSalida"
        Me.DtSalida.Size = New System.Drawing.Size(110, 26)
        Me.DtSalida.TabIndex = 10
        Me.DtSalida.Value = New Date(2021, 11, 21, 0, 0, 0, 0)
        '
        'lbSalida
        '
        Me.lbSalida.AutoSize = True
        Me.lbSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSalida.ForeColor = System.Drawing.Color.Maroon
        Me.lbSalida.Location = New System.Drawing.Point(291, 228)
        Me.lbSalida.Name = "lbSalida"
        Me.lbSalida.Size = New System.Drawing.Size(23, 29)
        Me.lbSalida.TabIndex = 20
        Me.lbSalida.Text = "*"
        Me.lbSalida.Visible = False
        '
        'nupPasajeros
        '
        Me.nupPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nupPasajeros.Location = New System.Drawing.Point(172, 400)
        Me.nupPasajeros.Name = "nupPasajeros"
        Me.nupPasajeros.Size = New System.Drawing.Size(56, 26)
        Me.nupPasajeros.TabIndex = 16
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(172, 55)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(148, 26)
        Me.txtOrigen.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(70, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Destino"
        '
        'lbRegreso
        '
        Me.lbRegreso.AutoSize = True
        Me.lbRegreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegreso.ForeColor = System.Drawing.Color.Maroon
        Me.lbRegreso.Location = New System.Drawing.Point(290, 314)
        Me.lbRegreso.Name = "lbRegreso"
        Me.lbRegreso.Size = New System.Drawing.Size(23, 29)
        Me.lbRegreso.TabIndex = 21
        Me.lbRegreso.Text = "*"
        Me.lbRegreso.Visible = False
        '
        'UI_ShadowPanel1
        '
        Me.UI_ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.UI_ShadowPanel1.BaseColor = System.Drawing.Color.DarkOrange
        Me.UI_ShadowPanel1.Controls.Add(Me.lbRegreso)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label1)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label2)
        Me.UI_ShadowPanel1.Controls.Add(Me.cmbAeropuerto)
        Me.UI_ShadowPanel1.Controls.Add(Me.txtOrigen)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label3)
        Me.UI_ShadowPanel1.Controls.Add(Me.nupPasajeros)
        Me.UI_ShadowPanel1.Controls.Add(Me.DtRegreso)
        Me.UI_ShadowPanel1.Controls.Add(Me.lbSalida)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label6)
        Me.UI_ShadowPanel1.Controls.Add(Me.DtSalida)
        Me.UI_ShadowPanel1.Controls.Add(Me.txtDestino)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label5)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label4)
        Me.UI_ShadowPanel1.Controls.Add(Me.btnBusacr)
        Me.UI_ShadowPanel1.Location = New System.Drawing.Point(13, 43)
        Me.UI_ShadowPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UI_ShadowPanel1.Name = "UI_ShadowPanel1"
        Me.UI_ShadowPanel1.ParentControl = Me
        Me.UI_ShadowPanel1.Radius = 15
        Me.UI_ShadowPanel1.ShadowColor = System.Drawing.Color.Maroon
        Me.UI_ShadowPanel1.ShadowShift = 20
        Me.UI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.UI_ShadowPanel1.Size = New System.Drawing.Size(458, 648)
        Me.UI_ShadowPanel1.TabIndex = 28
        '
        'Reservar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1488, 778)
        Me.ControlBox = False
        Me.Controls.Add(Me.UI_ShadowPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GBxItinerario)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1488, 778)
        Me.MinimumSize = New System.Drawing.Size(1488, 778)
        Me.Name = "Reservar"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservas"
        Me.GBxItinerario.ResumeLayout(False)
        CType(Me.DtgReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupPasajeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_ShadowPanel1.ResumeLayout(False)
        Me.UI_ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBxItinerario As Windows.Forms.GroupBox
    Friend WithEvents DtgReservas As Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents cmbAeropuerto As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents DtRegreso As Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtDestino As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents btnBusacr As Windows.Forms.Button
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents DtSalida As Windows.Forms.DateTimePicker
    Friend WithEvents lbSalida As Windows.Forms.Label
    Friend WithEvents nupPasajeros As Windows.Forms.NumericUpDown
    Friend WithEvents txtOrigen As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents lbRegreso As Windows.Forms.Label
    Friend WithEvents UI_ShadowPanel1 As UIDC.UI_ShadowPanel
End Class
