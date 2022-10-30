Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports logica
Public Class Registrar

    Private Sub limpiar()

        txtnombre.Clear()
        txtapellido.Clear()
        txtapellido2.Clear()
        txtusuario.Clear()
        txtclave.Clear()
        txtedad.Clear()

    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try

            Dim fecha As Date
            fecha = txtFechaNacimiento.Value
            Dim nombre = txtnombre.Text
            Dim primerA = txtapellido.Text
            Dim segundoA = txtapellido2.Text
            Dim identificacion = cbID.SelectedValue
            Dim nacionalidad = cbNacionalidad.SelectedValue
            Dim pais = cbpais.SelectedValue
            Dim sexo = cbSexo.SelectedValue
            Dim usuario = txtusuario.Text
            Dim contrasena = txtclave.Text
            Dim rol = cbRol.SelectedValue


            Dim MetodoInsert As New logica.Insertar

            If txtnombre.Text IsNot "" And txtapellido.Text IsNot "" And txtapellido2.Text IsNot "" And txtclave.Text IsNot "" And txtusuario.Text IsNot "" Then

                Dim resultado = MetodoInsert.insertarCliente(usuario, nombre, primerA, segundoA, fecha, contrasena, rol, pais, nacionalidad, sexo, identificacion)


                If resultado > 0 Then
                    MessageBox.Show("Los datos se ingresaron correctamente", "Informacion", MessageBoxButtons.OK)
                End If
                limpiar()
            Else
                MessageBox.Show("Por favor complete el formulario correctamente", "Informacion", MessageBoxButtons.OK)
            End If


        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged


    End Sub
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub Registrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Dim COMBO As New logica.Insertar

            Dim data = COMBO.Consultaid()

            cbID.DataSource = data.Tables("Identificacion")
            cbID.ValueMember = "Id"
            cbID.DisplayMember = "Descripcion"
            cbID.SelectedItem = 1

            Dim dato = COMBO.ConsultaNacionalidad()
            cbNacionalidad.DataSource = dato.Tables("Nacionalidad")
            cbNacionalidad.ValueMember = "Id"
            cbNacionalidad.DisplayMember = "Nacionalidad"
            cbNacionalidad.SelectedItem = 1

            Dim dato2 = COMBO.ConsultaPais()
            cbpais.DataSource = dato2.Tables("Pais")
            cbpais.ValueMember = "Id"
            cbpais.DisplayMember = "Pais"
            cbpais.SelectedItem = 1

            Dim dato3 = COMBO.ConsultaSexo()
            cbSexo.DataSource = dato3.Tables("Sexo")
            cbSexo.ValueMember = "Id"
            cbSexo.DisplayMember = "Sexo"
            cbSexo.SelectedItem = 1


            Dim dato4 = COMBO.ConsultaRol()
            cbRol.DataSource = dato4.Tables("Rol")
            cbRol.ValueMember = "Id"
            cbRol.DisplayMember = "Rol"
            cbRol.SelectedValue = 2

            Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btncontinuar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        If GetActivasReservas() = True Then

            Close()

        End If

        Dim Fromlogin As New menuLogin


        Fromlogin.Show()
        Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Gcliente_Enter(sender As Object, e As EventArgs) Handles Gcliente.Enter

    End Sub

    Private Sub txtFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaNacimiento.ValueChanged
        Dim fecha As Date
        fecha = txtFechaNacimiento.Value
        Dim edad% = 2021 - fecha.Year
        txtedad.Text = edad.ToString
    End Sub
End Class