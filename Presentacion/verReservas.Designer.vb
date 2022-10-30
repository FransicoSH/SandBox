<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class verReservas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridReservas = New System.Windows.Forms.DataGridView()
        Me.ColumCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnBorrrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.BtnVerReservas = New System.Windows.Forms.Button()
        Me.BtnExportarXml = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridReservas)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1383, 408)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservas del usuario "
        '
        'DataGridReservas
        '
        Me.DataGridReservas.AllowUserToDeleteRows = False
        Me.DataGridReservas.AllowUserToResizeColumns = False
        Me.DataGridReservas.AllowUserToResizeRows = False
        Me.DataGridReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridReservas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridReservas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumCheck})
        Me.DataGridReservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridReservas.EnableHeadersVisualStyles = False
        Me.DataGridReservas.Location = New System.Drawing.Point(12, 38)
        Me.DataGridReservas.Name = "DataGridReservas"
        Me.DataGridReservas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridReservas.RowHeadersVisible = False
        Me.DataGridReservas.RowHeadersWidth = 62
        Me.DataGridReservas.RowTemplate.Height = 28
        Me.DataGridReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridReservas.Size = New System.Drawing.Size(1360, 340)
        Me.DataGridReservas.TabIndex = 0
        '
        'ColumCheck
        '
        Me.ColumCheck.FillWeight = 70.0!
        Me.ColumCheck.HeaderText = "Check"
        Me.ColumCheck.MinimumWidth = 8
        Me.ColumCheck.Name = "ColumCheck"
        Me.ColumCheck.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColumCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(1378, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 158)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnBorrrar
        '
        Me.btnBorrrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnBorrrar.FlatAppearance.BorderSize = 0
        Me.btnBorrrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrrar.Image = Global.Presentacion.My.Resources.Resources.borrar
        Me.btnBorrrar.Location = New System.Drawing.Point(1065, 175)
        Me.btnBorrrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBorrrar.Name = "btnBorrrar"
        Me.btnBorrrar.Size = New System.Drawing.Size(157, 66)
        Me.btnBorrrar.TabIndex = 10
        Me.btnBorrrar.Text = "Borrar reserva"
        Me.btnBorrrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBorrrar.UseVisualStyleBackColor = False
        Me.btnBorrrar.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button1.BackgroundImage = Global.Presentacion.My.Resources.Resources.cerrar_sesion
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1281, 679)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 68)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.logoProyecto
        Me.PictureBox1.Location = New System.Drawing.Point(16, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(442, 209)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.Presentacion.My.Resources.Resources.editar__1_
        Me.btnModificar.Location = New System.Drawing.Point(885, 175)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(157, 66)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'BtnVerReservas
        '
        Me.BtnVerReservas.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnVerReservas.FlatAppearance.BorderSize = 0
        Me.BtnVerReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerReservas.ForeColor = System.Drawing.Color.White
        Me.BtnVerReservas.Image = Global.Presentacion.My.Resources.Resources.buscar__1_
        Me.BtnVerReservas.Location = New System.Drawing.Point(705, 175)
        Me.BtnVerReservas.Name = "BtnVerReservas"
        Me.BtnVerReservas.Size = New System.Drawing.Size(157, 66)
        Me.BtnVerReservas.TabIndex = 9
        Me.BtnVerReservas.Text = "Ver Reservas "
        Me.BtnVerReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnVerReservas.UseVisualStyleBackColor = False
        '
        'BtnExportarXml
        '
        Me.BtnExportarXml.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnExportarXml.FlatAppearance.BorderSize = 0
        Me.BtnExportarXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportarXml.ForeColor = System.Drawing.Color.White
        Me.BtnExportarXml.Image = Global.Presentacion.My.Resources.Resources.importar__1_
        Me.BtnExportarXml.Location = New System.Drawing.Point(525, 175)
        Me.BtnExportarXml.Name = "BtnExportarXml"
        Me.BtnExportarXml.Size = New System.Drawing.Size(157, 66)
        Me.BtnExportarXml.TabIndex = 8
        Me.BtnExportarXml.Text = "Exportar xml"
        Me.BtnExportarXml.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnExportarXml.UseVisualStyleBackColor = False
        '
        'verReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1424, 751)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrrar)
        Me.Controls.Add(Me.BtnVerReservas)
        Me.Controls.Add(Me.BtnExportarXml)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1424, 751)
        Me.MinimumSize = New System.Drawing.Size(1424, 751)
        Me.Name = "verReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservas del usuario "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents DataGridReservas As Windows.Forms.DataGridView
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
    Friend WithEvents ColumCheck As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents btnModificar As Windows.Forms.Button
    Friend WithEvents btnBorrrar As Windows.Forms.Button
    Friend WithEvents BtnVerReservas As Windows.Forms.Button
    Friend WithEvents BtnExportarXml As Windows.Forms.Button
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
