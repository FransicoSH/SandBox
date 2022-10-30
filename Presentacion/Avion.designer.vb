<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Avion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CmbMarca = New System.Windows.Forms.ComboBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblCapacidad = New System.Windows.Forms.Label()
        Me.DgvAvion = New System.Windows.Forms.DataGridView()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtAvion = New System.Windows.Forms.TextBox()
        Me.LblAvion = New System.Windows.Forms.Label()
        Me.CmbModelo = New System.Windows.Forms.ComboBox()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.NmrCapacidad = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SPListaMarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DgvAvion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmrCapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPListaMarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbMarca
        '
        Me.CmbMarca.FormattingEnabled = True
        Me.CmbMarca.Location = New System.Drawing.Point(206, 142)
        Me.CmbMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbMarca.Name = "CmbMarca"
        Me.CmbMarca.Size = New System.Drawing.Size(198, 28)
        Me.CmbMarca.TabIndex = 18
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarca.Location = New System.Drawing.Point(111, 143)
        Me.LblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(61, 20)
        Me.LblMarca.TabIndex = 20
        Me.LblMarca.Text = "Marca"
        '
        'LblCapacidad
        '
        Me.LblCapacidad.AutoSize = True
        Me.LblCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCapacidad.Location = New System.Drawing.Point(75, 91)
        Me.LblCapacidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCapacidad.Name = "LblCapacidad"
        Me.LblCapacidad.Size = New System.Drawing.Size(97, 20)
        Me.LblCapacidad.TabIndex = 24
        Me.LblCapacidad.Text = "Capacidad"
        '
        'DgvAvion
        '
        Me.DgvAvion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAvion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.DgvAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAvion.Location = New System.Drawing.Point(57, 344)
        Me.DgvAvion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvAvion.Name = "DgvAvion"
        Me.DgvAvion.RowHeadersWidth = 62
        Me.DgvAvion.Size = New System.Drawing.Size(883, 297)
        Me.DgvAvion.TabIndex = 23
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(399, 288)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(112, 35)
        Me.BtnBorrar.TabIndex = 21
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(262, 288)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(112, 35)
        Me.BtnGuardar.TabIndex = 19
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtAvion
        '
        Me.TxtAvion.Location = New System.Drawing.Point(206, 39)
        Me.TxtAvion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAvion.Name = "TxtAvion"
        Me.TxtAvion.Size = New System.Drawing.Size(198, 26)
        Me.TxtAvion.TabIndex = 16
        '
        'LblAvion
        '
        Me.LblAvion.AutoSize = True
        Me.LblAvion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAvion.Location = New System.Drawing.Point(117, 39)
        Me.LblAvion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAvion.Name = "LblAvion"
        Me.LblAvion.Size = New System.Drawing.Size(55, 20)
        Me.LblAvion.TabIndex = 22
        Me.LblAvion.Text = "Avion"
        '
        'CmbModelo
        '
        Me.CmbModelo.FormattingEnabled = True
        Me.CmbModelo.Location = New System.Drawing.Point(206, 191)
        Me.CmbModelo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbModelo.Name = "CmbModelo"
        Me.CmbModelo.Size = New System.Drawing.Size(198, 28)
        Me.CmbModelo.TabIndex = 25
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModelo.Location = New System.Drawing.Point(103, 192)
        Me.LblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(69, 20)
        Me.LblModelo.TabIndex = 26
        Me.LblModelo.Text = "Modelo"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(520, 288)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(112, 35)
        Me.BtnCancelar.TabIndex = 27
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'NmrCapacidad
        '
        Me.NmrCapacidad.Location = New System.Drawing.Point(206, 91)
        Me.NmrCapacidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NmrCapacidad.Name = "NmrCapacidad"
        Me.NmrCapacidad.Size = New System.Drawing.Size(200, 26)
        Me.NmrCapacidad.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.viajar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(679, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 213)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'SPListaMarcaBindingSource
        '
        Me.SPListaMarcaBindingSource.DataMember = "SP_ListaMarca"
        '
        'Avion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(971, 692)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NmrCapacidad)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.CmbModelo)
        Me.Controls.Add(Me.LblModelo)
        Me.Controls.Add(Me.CmbMarca)
        Me.Controls.Add(Me.LblMarca)
        Me.Controls.Add(Me.LblCapacidad)
        Me.Controls.Add(Me.DgvAvion)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtAvion)
        Me.Controls.Add(Me.LblAvion)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Avion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Aviones"
        CType(Me.DgvAvion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmrCapacidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPListaMarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbMarca As Windows.Forms.ComboBox
    Friend WithEvents LblMarca As Windows.Forms.Label
    Friend WithEvents LblCapacidad As Windows.Forms.Label
    Friend WithEvents DgvAvion As Windows.Forms.DataGridView
    Friend WithEvents BtnBorrar As Windows.Forms.Button
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents TxtAvion As Windows.Forms.TextBox
    Friend WithEvents LblAvion As Windows.Forms.Label
    Friend WithEvents CmbModelo As Windows.Forms.ComboBox
    Friend WithEvents LblModelo As Windows.Forms.Label

    Friend WithEvents SPListaMarcaBindingSource As Windows.Forms.BindingSource

    Friend WithEvents BtnCancelar As Windows.Forms.Button
    Friend WithEvents NmrCapacidad As Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
