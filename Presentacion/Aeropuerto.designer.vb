<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aeropuerto
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
        Me.TxtCodigoAeropuerto = New System.Windows.Forms.TextBox()
        Me.LblCodigoAeropuerto = New System.Windows.Forms.Label()
        Me.DgvAeropuerto = New System.Windows.Forms.DataGridView()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtAeropuerto = New System.Windows.Forms.TextBox()
        Me.LblAeropuerto = New System.Windows.Forms.Label()
        Me.LblIdPais = New System.Windows.Forms.Label()
        Me.CmbPais = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvAeropuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCodigoAeropuerto
        '
        Me.TxtCodigoAeropuerto.Location = New System.Drawing.Point(234, 77)
        Me.TxtCodigoAeropuerto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCodigoAeropuerto.Name = "TxtCodigoAeropuerto"
        Me.TxtCodigoAeropuerto.Size = New System.Drawing.Size(198, 26)
        Me.TxtCodigoAeropuerto.TabIndex = 2
        '
        'LblCodigoAeropuerto
        '
        Me.LblCodigoAeropuerto.AutoSize = True
        Me.LblCodigoAeropuerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigoAeropuerto.Location = New System.Drawing.Point(28, 79)
        Me.LblCodigoAeropuerto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigoAeropuerto.Name = "LblCodigoAeropuerto"
        Me.LblCodigoAeropuerto.Size = New System.Drawing.Size(165, 20)
        Me.LblCodigoAeropuerto.TabIndex = 15
        Me.LblCodigoAeropuerto.Text = "Codigo Aeropuerto"
        '
        'DgvAeropuerto
        '
        Me.DgvAeropuerto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAeropuerto.Location = New System.Drawing.Point(73, 253)
        Me.DgvAeropuerto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvAeropuerto.Name = "DgvAeropuerto"
        Me.DgvAeropuerto.RowHeadersWidth = 62
        Me.DgvAeropuerto.Size = New System.Drawing.Size(1076, 411)
        Me.DgvAeropuerto.TabIndex = 14
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(218, 194)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(112, 35)
        Me.BtnBorrar.TabIndex = 5
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(81, 194)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(112, 35)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtAeropuerto
        '
        Me.TxtAeropuerto.Location = New System.Drawing.Point(234, 24)
        Me.TxtAeropuerto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAeropuerto.Name = "TxtAeropuerto"
        Me.TxtAeropuerto.Size = New System.Drawing.Size(198, 26)
        Me.TxtAeropuerto.TabIndex = 1
        '
        'LblAeropuerto
        '
        Me.LblAeropuerto.AutoSize = True
        Me.LblAeropuerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAeropuerto.Location = New System.Drawing.Point(92, 27)
        Me.LblAeropuerto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAeropuerto.Name = "LblAeropuerto"
        Me.LblAeropuerto.Size = New System.Drawing.Size(101, 20)
        Me.LblAeropuerto.TabIndex = 10
        Me.LblAeropuerto.Text = "Aeropuerto"
        '
        'LblIdPais
        '
        Me.LblIdPais.AutoSize = True
        Me.LblIdPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdPais.Location = New System.Drawing.Point(147, 136)
        Me.LblIdPais.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIdPais.Name = "LblIdPais"
        Me.LblIdPais.Size = New System.Drawing.Size(46, 20)
        Me.LblIdPais.TabIndex = 5
        Me.LblIdPais.Text = "País"
        '
        'CmbPais
        '
        Me.CmbPais.FormattingEnabled = True
        Me.CmbPais.Location = New System.Drawing.Point(234, 126)
        Me.CmbPais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbPais.Name = "CmbPais"
        Me.CmbPais.Size = New System.Drawing.Size(198, 28)
        Me.CmbPais.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentacion.My.Resources.Resources.aeropuerto
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(859, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 166)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Aeropuerto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CmbPais)
        Me.Controls.Add(Me.LblIdPais)
        Me.Controls.Add(Me.TxtCodigoAeropuerto)
        Me.Controls.Add(Me.LblCodigoAeropuerto)
        Me.Controls.Add(Me.DgvAeropuerto)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtAeropuerto)
        Me.Controls.Add(Me.LblAeropuerto)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Aeropuerto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Aeropuertos"
        CType(Me.DgvAeropuerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCodigoAeropuerto As Windows.Forms.TextBox
    Friend WithEvents LblCodigoAeropuerto As Windows.Forms.Label
    Friend WithEvents DgvAeropuerto As Windows.Forms.DataGridView
    Friend WithEvents BtnBorrar As Windows.Forms.Button
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents TxtAeropuerto As Windows.Forms.TextBox
    Friend WithEvents LblAeropuerto As Windows.Forms.Label
    Friend WithEvents LblIdPais As Windows.Forms.Label
    Friend WithEvents CmbPais As Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
