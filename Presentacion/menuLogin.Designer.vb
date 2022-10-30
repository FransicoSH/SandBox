<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuLogin))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.iniciocliente = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnclienteiniciar = New System.Windows.Forms.Button()
        Me.btnregistrocliente = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.iniciocliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-14, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 19
        '
        'iniciocliente
        '
        Me.iniciocliente.BackColor = System.Drawing.Color.Transparent
        Me.iniciocliente.Controls.Add(Me.Label13)
        Me.iniciocliente.Controls.Add(Me.btnclienteiniciar)
        Me.iniciocliente.Controls.Add(Me.btnregistrocliente)
        Me.iniciocliente.Controls.Add(Me.Label30)
        Me.iniciocliente.Controls.Add(Me.txtContraseña)
        Me.iniciocliente.Controls.Add(Me.txtusuario)
        Me.iniciocliente.Controls.Add(Me.Label31)
        Me.iniciocliente.Controls.Add(Me.Label32)
        Me.iniciocliente.Controls.Add(Me.Label33)
        Me.iniciocliente.Location = New System.Drawing.Point(18, -3)
        Me.iniciocliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.iniciocliente.Name = "iniciocliente"
        Me.iniciocliente.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.iniciocliente.Size = New System.Drawing.Size(604, 403)
        Me.iniciocliente.TabIndex = 21
        Me.iniciocliente.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(90, 265)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(446, 35)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "si no tiene una cuenta por favor registrese "
        '
        'btnclienteiniciar
        '
        Me.btnclienteiniciar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnclienteiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclienteiniciar.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclienteiniciar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnclienteiniciar.Location = New System.Drawing.Point(322, 329)
        Me.btnclienteiniciar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnclienteiniciar.Name = "btnclienteiniciar"
        Me.btnclienteiniciar.Size = New System.Drawing.Size(144, 43)
        Me.btnclienteiniciar.TabIndex = 14
        Me.btnclienteiniciar.Text = "Iniciar"
        Me.btnclienteiniciar.UseVisualStyleBackColor = False
        '
        'btnregistrocliente
        '
        Me.btnregistrocliente.BackColor = System.Drawing.Color.AliceBlue
        Me.btnregistrocliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnregistrocliente.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregistrocliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnregistrocliente.Location = New System.Drawing.Point(105, 329)
        Me.btnregistrocliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnregistrocliente.Name = "btnregistrocliente"
        Me.btnregistrocliente.Size = New System.Drawing.Size(144, 43)
        Me.btnregistrocliente.TabIndex = 10
        Me.btnregistrocliente.Text = "Registrarse"
        Me.btnregistrocliente.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label30.Location = New System.Drawing.Point(90, 103)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(377, 35)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "Inicia sesion y gestione sus reservas"
        '
        'txtContraseña
        '
        Me.txtContraseña.AcceptsTab = True
        Me.txtContraseña.Location = New System.Drawing.Point(238, 225)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(194, 26)
        Me.txtContraseña.TabIndex = 9
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'txtusuario
        '
        Me.txtusuario.AcceptsTab = True
        Me.txtusuario.Location = New System.Drawing.Point(238, 162)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(194, 26)
        Me.txtusuario.TabIndex = 8
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(99, 218)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(128, 35)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Contraseña"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(129, 162)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(100, 35)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Usuario "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Sitka Heading", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(6, 25)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(444, 63)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "¡Bienvenido CasiVago"
        '
        'menuLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(644, 409)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.iniciocliente)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menuLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.iniciocliente.ResumeLayout(False)
        Me.iniciocliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents iniciocliente As Windows.Forms.GroupBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents btnclienteiniciar As Windows.Forms.Button
    Friend WithEvents btnregistrocliente As Windows.Forms.Button
    Friend WithEvents Label30 As Windows.Forms.Label
    Friend WithEvents txtContraseña As Windows.Forms.TextBox
    Friend WithEvents txtusuario As Windows.Forms.TextBox
    Friend WithEvents Label31 As Windows.Forms.Label
    Friend WithEvents Label32 As Windows.Forms.Label
    Friend WithEvents Label33 As Windows.Forms.Label
End Class
