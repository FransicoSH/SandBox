Imports Datos
Public Class Insertar
    Public Function insertarCliente(usuario As String, nombre As String, primerA As String, segundoA As String, fecha As Date, contrasena As String, rol As Integer, pais As Integer, nacionalidad As Integer, sexo As Integer, identificacion As Integer) As Integer
        Try
            Dim data As New Usuario

            If usuario IsNot " " Then
                Return data.insertar(usuario, nombre, primerA, segundoA, fecha, contrasena, rol, pais, nacionalidad, sexo, identificacion)
            End If


        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try
    End Function
    Public Function Consultaid() As DataSet

        Try
            Dim data As New CB

            Dim resID = data.ObtenerIdentificacion()
            Return resID

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    Public Function ConsultaNacionalidad() As DataSet

        Try
            Dim data As New CB

            Dim resNacionalidad = data.ObtenerNacionalidad()
            Return resNacionalidad

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ConsultaPais() As DataSet

        Try
            Dim data As New CB

            Dim resPais = data.ObtenerPais()
            Return resPais

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function ConsultaSexo() As DataSet

        Try
            Dim data As New CB

            Dim resSexo = data.ObtenerSexo()
            Return resSexo

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    Public Function ConsultaRol() As DataSet

        Try
            Dim data As New CB

            Dim resRol = data.ObtenerRol()
            Return resRol

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function ObtenerUsuarios() As DataSet

        Try
            Dim data As New Usuario

            Return data.ObtenerUsuarios()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function filtroU(NombreUsuario As String) As DataSet
        Try
            Dim data As New Usuario

            Return data.FiltroUsuario(NombreUsuario)


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub ActualizarUsuario(usuario As String, nombre As String, primerA As String, segundoA As String, fecha As Date, contrasena As String, pais As Integer, nacionalidad As Integer, sexo As Integer, identificacion As Integer)

        Dim data As New Usuario

        data.Modificar(usuario, nombre, primerA, segundoA, fecha, contrasena, pais, nacionalidad, sexo, identificacion)

    End Sub

    Public Sub BorrarUsuarioM(Id As Integer)

        Dim data As New Usuario

        data.BorrarUsuario(Id)

    End Sub
    Public Function Usuario(usuario1 As String) As String

        Dim data As New Usuario

        Return data.NombreUsuario(usuario1)

    End Function
    Public Function Apellido1(PrimerA1 As String) As String

        Dim data As New Usuario

        Return data.primerA(PrimerA1)

    End Function
    Public Function Apellido2(SegundoA1 As String) As String

        Dim data As New Usuario

        Return data.segundoA(SegundoA1)

    End Function
    Public Function nombre(Nombre1 As String) As String

        Dim data As New Usuario

        Return data.nombre(Nombre1)

    End Function
    Public Function clave(Contrasena1 As String) As String

        Dim data As New Usuario

        Return data.contrasena(Contrasena1)

    End Function

End Class
