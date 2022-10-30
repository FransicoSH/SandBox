Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Usuario
    Dim Usuario1, Nombre1, PrimerA1, SegundoA1, Contrasena1 As String

    Public Function NombreUsuario(usuario1 As String) As String
        Return usuario1
    End Function

    Public Function nombre(Nombre1 As String) As String
        Return Nombre1
    End Function

    Public Function segundoA(SegundoA1 As String) As String
        Return SegundoA1
    End Function

    Public Function primerA(PrimerA1 As String) As String
        Return PrimerA1
    End Function

    Public Function contrasena(Contrasena1 As String) As String
        Return Contrasena1
    End Function

    Dim conectar As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")

    Public Function insertar(usuario As String, nombre As String, primerA As String, segundoA As String, fecha As Date, contrasena As String, rol As Integer, pais As Integer, nacionalidad As Integer, sexo As Integer, identificacion As Integer) As Integer
        Dim rest As Integer
        Try

            Dim command As New SqlCommand

            command.CommandText = "dbo.SP_InsertarUsuario"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar

            command.Parameters.Clear()

            command.Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = usuario
            command.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = nombre
            command.Parameters.Add("@PrimerApellido", SqlDbType.NVarChar, 50).Value = primerA
            command.Parameters.Add("@SegundoApellido", SqlDbType.NVarChar, 50).Value = segundoA
            command.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = fecha
            command.Parameters.Add("@Contrasena", SqlDbType.NVarChar, 50).Value = contrasena
            command.Parameters.Add("@IdRol", SqlDbType.Int).Value = rol
            command.Parameters.Add("@IdPais", SqlDbType.Int).Value = pais
            command.Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = nacionalidad
            command.Parameters.Add("@IdSexo", SqlDbType.Int).Value = sexo
            command.Parameters.Add("@IdIdentificacion", SqlDbType.Int).Value = identificacion
            command.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output

            conectar.Open()

            command.ExecuteNonQuery()

            conectar.Close()

            rest = command.Parameters("@Id").Value


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


        Return rest
    End Function
    Public Function ObtenerUsuarios() As DataSet
        Dim ds As New DataSet()
        Try
            Dim command As New SqlCommand

            command.CommandText = "SP_ListaUsuarios"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar

            conectar.Open()

            Dim adapter As New SqlDataAdapter(command)

            adapter.Fill(ds, "Usuario")

            conectar.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return ds
    End Function
    Public Function FiltroUsuario(NombreUsuario As String) As DataSet


        Dim ds As New DataSet()

        Try
            Dim command As New SqlCommand

            command.CommandText = "[dbo].[FiltrarUsuario]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar

            conectar.Open()

            If NombreUsuario <> "" Then
                command.Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = NombreUsuario

            Else
                command.Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = DBNull.Value

            End If


            Dim adapter As New SqlDataAdapter
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = conectar
            adapter.Fill(ds, "Usuario")

            conectar.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return ds
    End Function
    Public Function Modificar(usuario As String, nombre As String, primerA As String, segundoA As String, fecha As Date, contrasena As String, pais As Integer, nacionalidad As Integer, sexo As Integer, identificacion As Integer) As Integer
        Dim Resultado As Integer
        Try

            Dim command As New SqlCommand

            command.CommandText = "dbo.SP_ActualizarUsuario"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar

            command.Parameters.Clear()

            command.Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = usuario
            command.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = nombre
            command.Parameters.Add("@PrimerApellido", SqlDbType.NVarChar, 50).Value = primerA
            command.Parameters.Add("@SegundoApellido", SqlDbType.NVarChar, 50).Value = segundoA
            command.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = fecha
            command.Parameters.Add("@Contrasena", SqlDbType.NVarChar, 50).Value = contrasena
            command.Parameters.Add("@IdPais", SqlDbType.Int).Value = pais
            command.Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = nacionalidad
            command.Parameters.Add("@IdSexo", SqlDbType.Int).Value = sexo
            command.Parameters.Add("@IdIdentificacion", SqlDbType.Int).Value = identificacion
            'command.Parameters.Add("@cod_error", SqlDbType.Int).Direction = ParameterDirection.Output
            'command.Parameters.Add("@msg_error", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
            'command.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output

            conectar.Open()

            command.ExecuteNonQuery()

            conectar.Close()
            'Resultado = command.Parameters("@Id").Value
            'Dim varerror = command.Parameters("@cod_error").Value

            'If varerror <> 0 Then
            '    Throw New Exception(command.Parameters("@msg_error").Value)
            'End If


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Resultado
    End Function
    Public Sub BorrarUsuario(Id As Integer)

        Try
            Dim command As New SqlCommand
            command.CommandText = "dbo.SP_BorrarUsuario"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar
            Dim parametro1 As New SqlParameter("@Id", SqlDbType.Int)

            parametro1.Value = Id

            command.Parameters.Add(parametro1)
            command.Parameters.Add("@ERROR_NUMBER", SqlDbType.Int).Direction = ParameterDirection.Output

            conectar.Open()
            'ejecutamos el sp
            command.ExecuteNonQuery()
            conectar.Close()

            If IsNumeric(command.Parameters("@ERROR_NUMBER").Value) Then
                Dim resultado = command.Parameters("@ERROR_NUMBER").Value
                If resultado = 547 Then
                    MessageBox.Show("No puede borrar un Usuario, el cual, ya está ligado a una reserva")
                End If
            Else
                MessageBox.Show("EL usuario se ha eliminado correctamente", "Informacion", MessageBoxButtons.OK)
            End If




        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
    End Sub
End Class
Public Class CB
    Dim conectar As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerIdentificacion() As DataSet
        Dim resultado As New DataSet()
        Try

            Dim command As New SqlCommand

            command.CommandText = "dbo.SP_ListaIdentificacion"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar


            conectar.Open()
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(resultado, "Identificacion")
            conectar.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return resultado
    End Function
    Public Function ObtenerNacionalidad() As DataSet
        Dim resultado As New DataSet()
        Try

            Dim command As New SqlCommand

            command.CommandText = "[dbo].[SP_ListaNacionalidad]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar

            conectar.Open()
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(resultado, "Nacionalidad")
            conectar.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return resultado
    End Function
    Public Function ObtenerPais() As DataSet
        Dim resultado As New DataSet()
        Try

            Dim command As New SqlCommand

            command.CommandText = "[dbo].[SP_ListaPais]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar

            conectar.Open()
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(resultado, "Pais")
            conectar.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return resultado
    End Function
    Public Function ObtenerSexo() As DataSet
        Dim resultado As New DataSet()
        Try

            Dim command As New SqlCommand

            command.CommandText = "[dbo].[SP_ListaSexo]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar

            conectar.Open()
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(resultado, "Sexo")
            conectar.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return resultado
    End Function
    Public Function ObtenerRol() As DataSet
        Dim resultado As New DataSet()
        Try

            Dim command As New SqlCommand

            command.CommandText = "[dbo].[SP_ListaRol]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conectar

            conectar.Open()
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(resultado, "Rol")
            conectar.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return resultado
    End Function

End Class
