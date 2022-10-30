<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Identificacion
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
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DgvIdentificaciones = New System.Windows.Forms.DataGridView()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        CType(Me.DgvIdentificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(32, 43)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcion.TabIndex = 0
        Me.LblDescripcion.Text = "Descripcion"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(110, 43)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(133, 20)
        Me.TxtDescripcion.TabIndex = 1
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(35, 90)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DgvIdentificaciones
        '
        Me.DgvIdentificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvIdentificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvIdentificaciones.Location = New System.Drawing.Point(35, 150)
        Me.DgvIdentificaciones.Name = "DgvIdentificaciones"
        Me.DgvIdentificaciones.Size = New System.Drawing.Size(728, 267)
        Me.DgvIdentificaciones.TabIndex = 3
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(126, 90)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBorrar.TabIndex = 4
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'Identificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 447)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.DgvIdentificaciones)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Name = "Identificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Identificacion"
        CType(Me.DgvIdentificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDescripcion As Windows.Forms.Label
    Friend WithEvents TxtDescripcion As Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents DgvIdentificaciones As Windows.Forms.DataGridView
    Friend WithEvents BtnBorrar As Windows.Forms.Button
End Class
