Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexionBD_Itinerario
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerItinerario() As DataSet
        Try

            Dim comando As New SqlCommand("SP_ListaItinerario", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Itinerario")


            conexion.Close()

            Return dataSet

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
        Return Nothing

    End Function

    Public Sub InsertarItinerario(FechaHoraSalida As Date, FechaHoraLlegada As Date, IdAvion As Integer, IdPais As Integer, IdAeropuerto As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_InsertarItinerario"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@FechaHoraSalida", SqlDbType.DateTime)
            Dim parametro2 As New SqlParameter("@FechaHoraLLegada", SqlDbType.DateTime)
            Dim parametro3 As New SqlParameter("@IdAvion", SqlDbType.Int)
            Dim parametro4 As New SqlParameter("@IdPais", SqlDbType.Int)
            Dim parametro5 As New SqlParameter("@IdAeropuerto", SqlDbType.Int)

            parametro1.Value = FechaHoraSalida
            parametro2.Value = FechaHoraLlegada
            parametro3.Value = IdAvion
            parametro4.Value = IdPais
            parametro5.Value = IdAeropuerto

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)
            command.Parameters.Add(parametro3)
            command.Parameters.Add(parametro4)
            command.Parameters.Add(parametro5)

            'ejecutamos el sp
            conexion.Open()
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

    Public Sub BorrarItinerario(Id As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_BorrarAvion"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)

            parametro1.Value = Id

            command.Parameters.Add(parametro1)
            command.Parameters.Add("@ERROR_NUMBER", SqlDbType.Int).Direction = ParameterDirection.Output

            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()

            If IsNumeric(command.Parameters("@ERROR_NUMBER").Value) Then
                Dim resultado = command.Parameters("@ERROR_NUMBER").Value
                If resultado = "547" Then
                    MessageBox.Show("No puede borrar un Itinerario, el cual, ya está ligado a una reserva")
                End If
            Else
                MessageBox.Show("EL Itinerario se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub


    Public Sub ActualizarItinerario(Id As Integer, FechaHoraSalida As Date, FechaHoraLlegada As Date, IdAvion As Integer, IdPais As Integer, IdAeropuerto As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_ActualizarItinerario"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)
            Dim parametro2 As New SqlParameter("@FechaHoraSalida", SqlDbType.DateTime)
            Dim parametro3 As New SqlParameter("@FechaHoraLlegada", SqlDbType.DateTime)
            Dim parametro4 As New SqlParameter("@IdAvion", SqlDbType.Int)
            Dim parametro5 As New SqlParameter("@IdPais", SqlDbType.Int)
            Dim parametro6 As New SqlParameter("@IdAeropuerto", SqlDbType.Int)

            parametro1.Value = Id
            parametro2.Value = FechaHoraSalida
            parametro3.Value = FechaHoraLlegada
            parametro4.Value = IdAvion
            parametro5.Value = IdPais
            parametro6.Value = IdAeropuerto

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)
            command.Parameters.Add(parametro3)
            command.Parameters.Add(parametro4)
            command.Parameters.Add(parametro5)
            command.Parameters.Add(parametro6)

            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

End Class


