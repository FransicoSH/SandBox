Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexionBD_Identificacion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerIdentificacion() As DataSet
        Try

            Dim comando As New SqlCommand("SP_ListaIdentificacion", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Identificacion")


            conexion.Close()

            Return dataSet

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
        Return Nothing

    End Function

    Public Sub InsertarIdentificacion(Descripcion As String)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_InsertarIdentificacion"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Descripcion", SqlDbType.VarChar)

            parametro1.Value = Descripcion

            command.Parameters.Add(parametro1)

            'ejecutamos el sp
            conexion.Open()
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

    Public Sub BorrarIdentificacion(Id As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_BorrarIdentificacion"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)

            parametro1.Value = Id

            command.Parameters.Add(parametro1)
            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub


    Public Sub ActualizarIdentificacion(Id As Integer, Descripcion As String)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_ActualizarIdentificacion"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)
            Dim parametro2 As New SqlParameter("@Descripcion", SqlDbType.VarChar)
            parametro2.Size = 20

            parametro1.Value = Id
            parametro2.Value = Descripcion

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)

            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

End Class
