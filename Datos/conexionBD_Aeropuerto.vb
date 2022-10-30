Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexionBD_Aeropuerto
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerAeropuerto() As DataSet
        Try

            Dim comando As New SqlCommand("SP_ListaAeropuerto", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Aeropuerto")


            conexion.Close()

            Return dataSet

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
        Return Nothing

    End Function

    Public Sub InsertarAeropuerto(Aeropuerto As String, CodigoInternacionalAeropuerto As String, IdPais As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_InsertarAeropuerto"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Aeropuerto", SqlDbType.VarChar)
            Dim parametro2 As New SqlParameter("@CodigoInternacionalAeropuerto", SqlDbType.VarChar)
            Dim parametro3 As New SqlParameter("@IdPais", SqlDbType.Int)

            parametro1.Value = Aeropuerto
            parametro2.Value = CodigoInternacionalAeropuerto
            parametro3.Value = IdPais

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)
            command.Parameters.Add(parametro3)

            'ejecutamos el sp
            conexion.Open()
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

    Public Sub BorrarAeropuerto(Id As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_BorrarAeropuerto"
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
                If resultado = 547 Then
                    MessageBox.Show("No puede borrar un aeropuerto, el cual, ya está ligado a una reserva")
                End If
            Else
                MessageBox.Show("EL aeropuerto se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK)
            End If


        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub


    Public Sub ActualizarPais(Id As Integer, Aeropuerto As String, CodigoInternacionalAeropuerto As String, IdPais As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_ActualizarAeropuerto"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)
            Dim parametro2 As New SqlParameter("@Aeropuerto", SqlDbType.VarChar)
            parametro2.Size = 20
            Dim parametro3 As New SqlParameter("@CodigoInternacionalAeropuerto", SqlDbType.VarChar)
            parametro2.Size = 20
            Dim parametro4 As New SqlParameter("@IdPais", SqlDbType.Int)

            parametro1.Value = Id
            parametro2.Value = Aeropuerto
            parametro3.Value = CodigoInternacionalAeropuerto
            parametro4.Value = IdPais

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)
            command.Parameters.Add(parametro3)
            command.Parameters.Add(parametro4)

            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

End Class

