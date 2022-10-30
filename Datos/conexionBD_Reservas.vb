Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexionBD_Reservas
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")

    Public Function ObtenerAeropuerto(Pais As String) As DataSet
        Try

            Dim comando As New SqlCommand("SP_GetAeropuerto", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim parametro As New SqlParameter("@Pais", SqlDbType.NVarChar)
            parametro.Size = 50
            parametro.Value = Pais
            comando.Parameters.Add(parametro)

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Aeropuerto")


            conexion.Close()

            Return dataSet

        Catch ex As Exception

        End Try
        Return Nothing

    End Function

    Public Function ValidacionFechasBD(id As Integer, fecha As String) As DataTable

        Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
            Dim comando As New SqlCommand("SP_fechasReserva", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim parametro1 As New SqlParameter("@idUsuario", SqlDbType.Int)
            parametro1.Value = id
            comando.Parameters.Add(parametro1)

        Dim parametro2 As New SqlParameter("@Fecha", SqlDbType.SmallDateTime)
        parametro2.Value = fecha
            comando.Parameters.Add(parametro2)

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Reserva")

        Dim datos As New DataTable
        datos = dataSet.Tables("Reserva")
            conexion.Close()
            Return datos




    End Function


    Public Function obtengoItinerario(idAeropuerto As Integer) As DataTable
        Try
            Dim comando As New SqlCommand("SP_GetItinerario", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim parametro As New SqlParameter("@idAeropuerto", SqlDbType.Int)
            parametro.Value = idAeropuerto
            comando.Parameters.Add(parametro)

            'Dim parametro2 As New SqlParameter("@FechadeSalida", SqlDbType.SmallDateTime)
            'parametro2.Value = fechaSalida
            'comando.Parameters.Add(parametro2)

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Itinerario")

            Dim datos As New DataTable
            datos = dataSet.Tables("Itinerario")
            conexion.Close()
            Return datos


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Function obtengoModelo(IdAvion As Integer) As DataTable
        Try
            Dim comando As New SqlCommand("SP_obtenerModeloAvion", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim parametro As New SqlParameter("@IdAvion", SqlDbType.Int)
            parametro.Value = IdAvion
            comando.Parameters.Add(parametro)

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Avion")

            Dim datos As New DataTable
            datos = dataSet.Tables("Avion")
            conexion.Close()
            Return datos


        Catch ex As Exception

        End Try
        Return Nothing
    End Function

    Public Sub insertarReserva(FechaSalida As String, FechaLlegada As String, cantidadBoletos As Integer, idUsuario As Integer, idItinerario As Integer, idPais As Integer, PaisSalida As String
                               )


        Dim command As New SqlCommand
            command.CommandText = "SP_RegistrarReserva"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion

            Dim parametro1 As New SqlParameter("@IdItinerario", SqlDbType.Int)
            Dim parametro2 As New SqlParameter("@IdUsuario", SqlDbType.Int)
            Dim parametro3 As New SqlParameter("@FechaSalida", SqlDbType.SmallDateTime)
            Dim parametro4 As New SqlParameter("@FechaHoraRegreso", SqlDbType.SmallDateTime)
            Dim parametro5 As New SqlParameter("@IdPais", SqlDbType.Int)
            Dim parametro6 As New SqlParameter("@CantidadBoletos", SqlDbType.Int)
            Dim parametro7 As New SqlParameter("@PaisSalida", SqlDbType.NChar)
            parametro7.Size = 50

            parametro1.Value = idItinerario
            parametro2.Value = idUsuario
            parametro3.Value = FechaSalida
            parametro4.Value = FechaLlegada
            parametro5.Value = idPais
            parametro6.Value = cantidadBoletos
            parametro7.Value = PaisSalida

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)
            command.Parameters.Add(parametro3)
            command.Parameters.Add(parametro4)
            command.Parameters.Add(parametro5)
            command.Parameters.Add(parametro6)
            command.Parameters.Add(parametro7)
            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()

    End Sub



End Class
