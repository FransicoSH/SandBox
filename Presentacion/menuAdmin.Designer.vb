<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuAdmin
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CerrarSeccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AeropuertosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItinerariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSeccionToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReservasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.PAISToolStripMenuItem, Me.AeropuertosToolStripMenuItem, Me.ItinerariosToolStripMenuItem, Me.AvionesToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(153, 29)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento "
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.ReservasToolStripMenuItem.Text = "Cliente"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(270, 34)
        Me.ToolStripMenuItem1.Text = "Ver lista Usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.logoProyecto
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(42, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(452, 255)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'CerrarSeccionToolStripMenuItem
        '
        Me.CerrarSeccionToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.opcion_de_cerrar_sesion
        Me.CerrarSeccionToolStripMenuItem.Name = "CerrarSeccionToolStripMenuItem"
        Me.CerrarSeccionToolStripMenuItem.Size = New System.Drawing.Size(40, 29)
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.ModificarClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.editar
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.agregar_usuario
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        Me.AgregarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AgregarUsuarioToolStripMenuItem.Text = "Agregar usuario"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.editar
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar Cliente "
        '
        'PAISToolStripMenuItem
        '
        Me.PAISToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.paises
        Me.PAISToolStripMenuItem.Name = "PAISToolStripMenuItem"
        Me.PAISToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PAISToolStripMenuItem.Text = "Pais "
        '
        'AeropuertosToolStripMenuItem
        '
        Me.AeropuertosToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.aeropuerto
        Me.AeropuertosToolStripMenuItem.Name = "AeropuertosToolStripMenuItem"
        Me.AeropuertosToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AeropuertosToolStripMenuItem.Text = "Aeropuertos"
        '
        'ItinerariosToolStripMenuItem
        '
        Me.ItinerariosToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.itinerario
        Me.ItinerariosToolStripMenuItem.Name = "ItinerariosToolStripMenuItem"
        Me.ItinerariosToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ItinerariosToolStripMenuItem.Text = "Itinerarios"
        '
        'AvionesToolStripMenuItem
        '
        Me.AvionesToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.viajar
        Me.AvionesToolStripMenuItem.Name = "AvionesToolStripMenuItem"
        Me.AvionesToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AvionesToolStripMenuItem.Text = "Aviones"
        '
        'menuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents PAISToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents AeropuertosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItinerariosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvionesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSeccionToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
