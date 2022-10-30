Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexionBD_Pais
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerPais() As DataSet
        Try

            Dim comando As New SqlCommand("SP_ListaPais", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Pais")


            conexion.Close()

            Return dataSet

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
        Return Nothing

    End Function

    Public Sub InsertarPais(Pais As String, CodigoInternacionalPais As String)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_InsertarPais"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Pais", SqlDbType.VarChar)
            Dim parametro2 As New SqlParameter("@CodigoInternacionalPais", SqlDbType.VarChar)

            parametro1.Value = Pais
            parametro2.Value = CodigoInternacionalPais

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)

            'ejecutamos el sp
            conexion.Open()
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

    Public Sub BorrarPais(Id As Integer)


        Dim command As New SqlCommand
        command.CommandText = "SP_BorrarPais"
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
                MessageBox.Show("No puede borrar un Pais, el cual, ya está ligado a una reserva")
            End If
        Else
            MessageBox.Show("El pais se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK)
        End If
    End Sub


    Public Sub ActualizarPais(Id As Integer, Pais As String, CodigoInternacionalPais As String)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_ActualizarPais"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)
            Dim parametro2 As New SqlParameter("@Pais", SqlDbType.VarChar)
            parametro2.Size = 20
            Dim parametro3 As New SqlParameter("@CodigoInternacionalPais", SqlDbType.VarChar)
            parametro2.Size = 20

            parametro1.Value = Id
            parametro2.Value = Pais
            parametro3.Value = CodigoInternacionalPais

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)
            command.Parameters.Add(parametro3)

            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

End Class