Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexionBD_Avion

    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerAvion() As DataSet
        Try

            Dim comando As New SqlCommand("SP_ListaAvion", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Avion")


            conexion.Close()

            Return dataSet

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
        Return Nothing

    End Function

    Public Sub InsertarAvion(Avion As String, Capacidad As Integer, IdMarca As Integer, IdModelo As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_InsertarAvion"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Avion", SqlDbType.VarChar)
            Dim parametro2 As New SqlParameter("@Capacidad", SqlDbType.Int)
            Dim parametro3 As New SqlParameter("@IdMarca", SqlDbType.Int)
            Dim parametro4 As New SqlParameter("@IdModelo", SqlDbType.Int)

            parametro1.Value = Avion
            parametro2.Value = Capacidad
            parametro3.Value = IdMarca
            parametro4.Value = IdModelo

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)
            command.Parameters.Add(parametro3)
            command.Parameters.Add(parametro4)

            'ejecutamos el sp
            conexion.Open()
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

    Public Sub BorrarAvion(Id As Integer)

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
                If resultado = 547 Then
                    MessageBox.Show("No puede borrar un avion, el cual, ya está ligado a una reserva")
                End If
            Else
                MessageBox.Show("EL Avion se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK)
            End If


        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub


    Public Sub ActualizarAvion(Id As Integer, Avion As String, Capacidad As Integer, IdMarca As Integer, IdModelo As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "SP_ActualizarAvion"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)
            Dim parametro2 As New SqlParameter("@Avion", SqlDbType.VarChar)
            parametro2.Size = 60
            Dim parametro3 As New SqlParameter("@Capacidad", SqlDbType.Int)
            Dim parametro4 As New SqlParameter("@IdMarca", SqlDbType.Int)
            Dim parametro5 As New SqlParameter("@IdModelo", SqlDbType.Int)

            parametro1.Value = Id
            parametro2.Value = Avion
            parametro3.Value = Capacidad
            parametro4.Value = IdMarca
            parametro5.Value = IdModelo

            command.Parameters.Add(parametro1)
            command.Parameters.Add(parametro2)
            command.Parameters.Add(parametro3)
            command.Parameters.Add(parametro4)
            command.Parameters.Add(parametro5)

            conexion.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub

End Class


