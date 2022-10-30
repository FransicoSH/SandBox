<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuReservas
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
        Me.ReservaDeVuelosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VuelosReservadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSeccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSeccionToolStripMenuItem, Me.ReservaDeVuelosToolStripMenuItem, Me.VuelosReservadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 33)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReservaDeVuelosToolStripMenuItem
        '
        Me.ReservaDeVuelosToolStripMenuItem.Name = "ReservaDeVuelosToolStripMenuItem"
        Me.ReservaDeVuelosToolStripMenuItem.Size = New System.Drawing.Size(174, 29)
        Me.ReservaDeVuelosToolStripMenuItem.Text = "Reserva de vuelos "
        '
        'VuelosReservadosToolStripMenuItem
        '
        Me.VuelosReservadosToolStripMenuItem.Name = "VuelosReservadosToolStripMenuItem"
        Me.VuelosReservadosToolStripMenuItem.Size = New System.Drawing.Size(177, 29)
        Me.VuelosReservadosToolStripMenuItem.Text = "Vuelos reservados "
        '
        'CerrarSeccionToolStripMenuItem
        '
        Me.CerrarSeccionToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.opcion_de_cerrar_sesion
        Me.CerrarSeccionToolStripMenuItem.Name = "CerrarSeccionToolStripMenuItem"
        Me.CerrarSeccionToolStripMenuItem.Size = New System.Drawing.Size(40, 29)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.logoProyecto
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(34, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(452, 255)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'menuReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "menuReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu Reservas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents ReservaDeVuelosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents VuelosReservadosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSeccionToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
