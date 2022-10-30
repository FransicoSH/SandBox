<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pais
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblPais = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.DgvPais = New System.Windows.Forms.DataGridView()
        Me.TxtCodigoInternacional = New System.Windows.Forms.TextBox()
        Me.LblCodigoInternacional = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DgvPais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPais
        '
        Me.LblPais.AutoSize = True
        Me.LblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPais.ForeColor = System.Drawing.Color.White
        Me.LblPais.Location = New System.Drawing.Point(29, 55)
        Me.LblPais.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPais.Name = "LblPais"
        Me.LblPais.Size = New System.Drawing.Size(46, 20)
        Me.LblPais.TabIndex = 0
        Me.LblPais.Text = "Pais"
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(223, 51)
        Me.TxtPais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(198, 26)
        Me.TxtPais.TabIndex = 1
        '
        'DgvPais
        '
        Me.DgvPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPais.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPais.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvPais.Location = New System.Drawing.Point(33, 253)
        Me.DgvPais.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvPais.Name = "DgvPais"
        Me.DgvPais.RowHeadersWidth = 62
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.DgvPais.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvPais.Size = New System.Drawing.Size(838, 411)
        Me.DgvPais.TabIndex = 7
        '
        'TxtCodigoInternacional
        '
        Me.TxtCodigoInternacional.Location = New System.Drawing.Point(223, 103)
        Me.TxtCodigoInternacional.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCodigoInternacional.Name = "TxtCodigoInternacional"
        Me.TxtCodigoInternacional.Size = New System.Drawing.Size(198, 26)
        Me.TxtCodigoInternacional.TabIndex = 9
        '
        'LblCodigoInternacional
        '
        Me.LblCodigoInternacional.AutoSize = True
        Me.LblCodigoInternacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigoInternacional.ForeColor = System.Drawing.Color.White
        Me.LblCodigoInternacional.Location = New System.Drawing.Point(29, 108)
        Me.LblCodigoInternacional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodigoInternacional.Name = "LblCodigoInternacional"
        Me.LblCodigoInternacional.Size = New System.Drawing.Size(181, 20)
        Me.LblCodigoInternacional.TabIndex = 8
        Me.LblCodigoInternacional.Text = "Codigo Internacional"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.paises
        Me.PictureBox1.Location = New System.Drawing.Point(560, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 258)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BtnBorrar
        '
        Me.BtnBorrar.FlatAppearance.BorderSize = 0
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.BtnBorrar.Image = Global.Presentacion.My.Resources.Resources.borrar
        Me.BtnBorrar.Location = New System.Drawing.Point(203, 173)
        Me.BtnBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(142, 53)
        Me.BtnBorrar.TabIndex = 6
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = Global.Presentacion.My.Resources.Resources.salvar
        Me.BtnGuardar.Location = New System.Drawing.Point(33, 173)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(142, 53)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar "
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Pais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 692)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtCodigoInternacional)
        Me.Controls.Add(Me.LblCodigoInternacional)
        Me.Controls.Add(Me.DgvPais)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtPais)
        Me.Controls.Add(Me.LblPais)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(919, 748)
        Me.MinimumSize = New System.Drawing.Size(919, 748)
        Me.Name = "Pais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Paises"
        CType(Me.DgvPais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPais As Windows.Forms.Label
    Friend WithEvents TxtPais As Windows.Forms.TextBox
    Friend WithEvents BtnBorrar As Windows.Forms.Button
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents DgvPais As Windows.Forms.DataGridView
    Friend WithEvents TxtCodigoInternacional As Windows.Forms.TextBox
    Friend WithEvents LblCodigoInternacional As Windows.Forms.Label
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
