Imports System.Windows.Forms
Imports logica

Public Class RegistroAdmin
    Dim IdS As Integer
    Dim tabla As DataTable
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub limpiar()
        txtusuario.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txtapellido2.Clear()
        txtclave.Clear()

    End Sub
    Private Sub RegistroAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GBDatos.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
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

        Dim MetodoObtener As New logica.Insertar

        Dim consulta = MetodoObtener.ObtenerUsuarios()
        gridConsulta.DataSource = consulta.Tables("Usuario")

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


        Dim MetodoObtenerUsu As New logica.Insertar
        Dim texbox As New logica.Insertar
        Try

            Dim NombreUsuario = txtfiltro.Text
            If NombreUsuario <> "" Then

                Dim consulta = MetodoObtenerUsu.filtroU(NombreUsuario)
                If consulta IsNot Nothing Then
                    If consulta.Tables("Usuario").Rows.Count > 0 Then
                        gridConsulta.DataSource = consulta.Tables("Usuario")
                        txtusuario.Text = texbox.Usuario(gridConsulta.CurrentRow.Cells.Item(1).Value.ToString())
                        txtnombre.Text = texbox.nombre(gridConsulta.CurrentRow.Cells.Item(2).Value.ToString())
                        txtapellido.Text = texbox.Apellido1(gridConsulta.CurrentRow.Cells.Item(3).Value.ToString())
                        txtapellido2.Text = texbox.Apellido2(gridConsulta.CurrentRow.Cells.Item(4).Value.ToString())
                        txtclave.Text = texbox.clave(gridConsulta.CurrentRow.Cells.Item(6).Value.ToString())
                        GBDatos.Enabled = True
                        btnModificar.Enabled = True
                        btnEliminar.Enabled = True


                    End If


                End If
            End If




        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs)


    End Sub
    Public Sub Cargar()
        Dim UsuarioDataSet As DataSet
        Dim usuario As New logica.Insertar
        UsuarioDataSet = usuario.ObtenerUsuarios()
        tabla = New DataTable()
        tabla = UsuarioDataSet.Tables("Usuario")

        gridConsulta.DataSource = tabla


    End Sub
    Private Sub txtModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim fecha As Date
        fecha = txtFechaNacimiento.Value
        Dim nombre = txtnombre.Text
        Dim primerA = txtapellido.Text
        Dim segundoA = txtapellido2.Text
        Dim identificacion = cbID.SelectedValue
        Dim nacionalidad = cbNacionalidad.SelectedValue
        Dim pais = cbpais.SelectedValue
        Dim sexo = cbSexo.SelectedValue
        Dim usuario = txtfiltro.Text
        Dim contrasena = txtclave.Text


        Dim Obtnerusuario As New logica.Insertar

        Obtnerusuario.ActualizarUsuario(usuario, nombre, primerA, segundoA, fecha, contrasena, pais, nacionalidad, sexo, identificacion)

        MessageBox.Show("El usuario se ha actualizado correctamente", "Informacion", MessageBoxButtons.OK)
        GBDatos.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        Cargar()
        limpiar()
    End Sub

    Private Sub gridConsulta_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles gridConsulta.CellContentClick
        'Try
        '    Dim fecha = gridConsulta.CurrentRow.Cells(5).Value
        '    Dim nombre = gridConsulta.CurrentRow.Cells(2).Value
        '    Dim primerA = gridConsulta.CurrentRow.Cells(3).Value
        '    Dim segundoA = gridConsulta.CurrentRow.Cells(4).Value
        '    Dim identificacion = gridConsulta.CurrentRow.Cells(11).Value
        '    Dim nacionalidad = gridConsulta.CurrentRow.Cells(9).Value
        '    Dim pais = gridConsulta.CurrentRow.Cells(8).Value
        '    Dim sexo = gridConsulta.CurrentRow.Cells(10).Value
        '    Dim usuario = gridConsulta.CurrentRow.Cells(1).Value
        '    Dim contrasena = gridConsulta.CurrentRow.Cells(6).Value
        '    Dim rol = gridConsulta.CurrentRow.Cells(7).Value

        '    Dim data As New logica.Insertar
        '    If (e.ColumnIndex = 12) Then
        '        Dim EstadoRol As Integer
        '        If (gridConsulta.CurrentRow.Cells(6).Value = "Cliente") Then
        '            EstadoRol = 2
        '        Else
        '            EstadoRol = 0
        '        End If
        '        data.ActualizarUsuario(usuario, nombre, primerA, segundoA, fecha, contrasena, rol, pais, nacionalidad, sexo, identificacion)

        '        Windows.Forms.MessageBox.Show("El dato ha sido modificado")
        '    End If

        'Catch ex As Exception
        '    Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub gridConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridConsulta.CellDoubleClick
        'Dim row As DataGridViewRow = gridConsulta.CurrentRow

        'IdS = Convert.ToInt32(row.Cells("Id").Value.ToString())
        'txtFechaNacimiento.Value = Convert.ToDateTime(row.Cells("FechaNacionamiento").Value.ToString)
        'txtnombre.Text = row.Cells("NombreUsuario").Value.ToString()
        'txtapellido.Text = row.Cells("PrimerApellido").Value.ToString()
        'txtapellido2.Text = row.Cells("SegundoApellido").Value.ToString()
        'cbID.SelectedValue = Convert.ToInt32(row.Cells("Descripcion").Value.ToString())
        'cbNacionalidad.SelectedValue = Convert.ToInt32(row.Cells("Nacionalidad").Value.ToString())
        'cbpais.SelectedValue = Convert.ToInt32(row.Cells("pais").Value.ToString())
        'cbSexo.SelectedValue = Convert.ToInt32(row.Cells("sexo").Value.ToString())
        'txtusuario.Text = row.Cells("Usuario").Value.ToString()
        'txtclave.Text = row.Cells("contrasena").Value.ToString()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            Dim resultado As DialogResult
            resultado = MessageBox.Show("¿Está seguro que desea eliminar este usuario de forma permanente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultado = DialogResult.Yes Then

                Dim Metodoeliminar As New logica.Insertar
                Dim row As DataGridViewRow = gridConsulta.CurrentRow
                Dim id As Integer = Convert.ToInt32(row.Cells("Id").Value.ToString())
                Metodoeliminar.BorrarUsuarioM(id)
                Cargar()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GBDatos_Enter(sender As Object, e As EventArgs) Handles GBDatos.Enter

    End Sub
    'Private Sub ConfigModi()
    '    modificar.Image = My.Resources.cheque
    '    modificar.ImageLayout = DataGridViewImageCellLayout.Stretch
    '    modificar.HeaderText = "UPDATE"
    '    modificar.Width = 80
    'End Sub
End Class