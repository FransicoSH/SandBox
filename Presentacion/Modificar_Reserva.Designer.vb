<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Reserva
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
        Me.UI_ShadowPanel1 = New UIDC.UI_ShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtRegreso = New System.Windows.Forms.DateTimePicker()
        Me.DtSalida = New System.Windows.Forms.DateTimePicker()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdReserva = New System.Windows.Forms.TextBox()
        Me.UI_ShadowPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UI_ShadowPanel1
        '
        Me.UI_ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.UI_ShadowPanel1.BaseColor = System.Drawing.Color.DarkOrange
        Me.UI_ShadowPanel1.Controls.Add(Me.Label5)
        Me.UI_ShadowPanel1.Controls.Add(Me.txtIdReserva)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label1)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label2)
        Me.UI_ShadowPanel1.Controls.Add(Me.txtOrigen)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label3)
        Me.UI_ShadowPanel1.Controls.Add(Me.DtRegreso)
        Me.UI_ShadowPanel1.Controls.Add(Me.DtSalida)
        Me.UI_ShadowPanel1.Controls.Add(Me.txtDestino)
        Me.UI_ShadowPanel1.Controls.Add(Me.Label4)
        Me.UI_ShadowPanel1.Location = New System.Drawing.Point(13, 26)
        Me.UI_ShadowPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UI_ShadowPanel1.Name = "UI_ShadowPanel1"
        Me.UI_ShadowPanel1.ParentControl = Me
        Me.UI_ShadowPanel1.Radius = 15
        Me.UI_ShadowPanel1.ShadowColor = System.Drawing.Color.Maroon
        Me.UI_ShadowPanel1.ShadowShift = 20
        Me.UI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada
        Me.UI_ShadowPanel1.Size = New System.Drawing.Size(1309, 241)
        Me.UI_ShadowPanel1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(256, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Origen "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(526, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Destino"
        '
        'txtOrigen
        '
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Location = New System.Drawing.Point(354, 101)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.ReadOnly = True
        Me.txtOrigen.Size = New System.Drawing.Size(148, 26)
        Me.txtOrigen.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(790, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Salida "
        '
        'DtRegreso
        '
        Me.DtRegreso.CustomFormat = ""
        Me.DtRegreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtRegreso.Location = New System.Drawing.Point(1114, 101)
        Me.DtRegreso.Name = "DtRegreso"
        Me.DtRegreso.Size = New System.Drawing.Size(110, 26)
        Me.DtRegreso.TabIndex = 11
        Me.DtRegreso.Value = New Date(2021, 11, 5, 0, 0, 0, 0)
        '
        'DtSalida
        '
        Me.DtSalida.CustomFormat = "DD-mm-YYYY"
        Me.DtSalida.Enabled = False
        Me.DtSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtSalida.Location = New System.Drawing.Point(863, 101)
        Me.DtSalida.Name = "DtSalida"
        Me.DtSalida.Size = New System.Drawing.Size(110, 26)
        Me.DtSalida.TabIndex = 10
        Me.DtSalida.Value = New Date(2021, 11, 21, 0, 0, 0, 0)
        '
        'txtDestino
        '
        Me.txtDestino.Enabled = False
        Me.txtDestino.Location = New System.Drawing.Point(618, 101)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.ReadOnly = True
        Me.txtDestino.Size = New System.Drawing.Size(148, 26)
        Me.txtDestino.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1014, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Regreso"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.logoProyecto
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(1343, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(452, 241)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(1655, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 48)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1490, 373)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 48)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(42, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Codigo Reserva"
        '
        'txtIdReserva
        '
        Me.txtIdReserva.Enabled = False
        Me.txtIdReserva.Location = New System.Drawing.Point(170, 102)
        Me.txtIdReserva.Name = "txtIdReserva"
        Me.txtIdReserva.ReadOnly = True
        Me.txtIdReserva.Size = New System.Drawing.Size(57, 26)
        Me.txtIdReserva.TabIndex = 16
        '
        'Modificar_Reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1807, 433)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.UI_ShadowPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Modificar_Reserva"
        Me.Text = "Modificar_Reserva"
        Me.UI_ShadowPanel1.ResumeLayout(False)
        Me.UI_ShadowPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UI_ShadowPanel1 As UIDC.UI_ShadowPanel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtOrigen As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents DtRegreso As Windows.Forms.DateTimePicker
    Friend WithEvents DtSalida As Windows.Forms.DateTimePicker
    Friend WithEvents txtDestino As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtIdReserva As Windows.Forms.TextBox
End Class
