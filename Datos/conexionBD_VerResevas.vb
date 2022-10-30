Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexionBD_VerResevas
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerReserva(IdUsuario As Integer) As DataTable
        'Try

        Dim comando As New SqlCommand("SP_ObtenerReserva", conexion)
        comando.CommandType = CommandType.StoredProcedure
        conexion.Open()

        Dim parametro As New SqlParameter("@iDUsuario", SqlDbType.Int)
        parametro.Value = IdUsuario
        comando.Parameters.Add(parametro)

        Dim dataAdapter As New SqlDataAdapter
        dataAdapter.SelectCommand = comando
        dataAdapter.SelectCommand.Connection = conexion

        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "Reserva")

        Dim datos As New DataTable
        datos = dataSet.Tables("Reserva")
        conexion.Close()
        Return datos

        'Catch ex As Exception

        'End Try
        'Return Nothing

    End Function

    Public Sub borrarReserva(id As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_BorrarReserva"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)

            parametro1.Value = id

            command.Parameters.Add(parametro1)
            command.Parameters.Add("@ERROR_NUMBER", SqlDbType.Int).Direction = ParameterDirection.Output

            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()


            If IsNumeric(command.Parameters("@ERROR_NUMBER").Value) Then
                Dim resultado = command.Parameters("@ERROR_NUMBER").Value
                If resultado = 547 Then
                    MessageBox.Show("No puede borrar un Usuario, el cual, ya está ligado a una reserva")
                End If
            Else
                MessageBox.Show("La reserva se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK)
            End If






        Catch ex As Exception

        End Try
    End Sub

    Public Sub ModificarRreserva(fecha As String, id As Integer)

        Try

            Dim command As New SqlCommand
            command.CommandText = "SP_modificarReserva"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            command.Parameters.Add("@id", SqlDbType.Int).Value = id
            command.Parameters.Add("@fechaRegreso", SqlDbType.SmallDateTime).Value = fecha

            Dim parametro1 As New SqlParameter("@Resultado", SqlDbType.VarChar)
            parametro1.Size = 60

            command.Parameters.Add(parametro1).Direction = ParameterDirection.Output

            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()
            MessageBox.Show(command.Parameters("@Resultado").Value)

        Catch ex As Exception

        End Try



    End Sub











End Class
