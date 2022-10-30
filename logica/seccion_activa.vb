
Imports Datos
Imports System.Windows.Forms
Public Module logica
    Dim datosUsuarios As New DataTable
    Dim conexionBD As New conexionBD()
    Public id As Integer
    Public NombreUsuario As String

    Public Function validacionUsuario(usuario As String, contraseña As String) As String

        datosUsuarios = conexionBD.datosUsuario()

        For i = 0 To datosUsuarios.Rows.Count - 1
            If usuario = datosUsuarios.Rows.Item(i).Item(1) And contraseña = datosUsuarios.Rows.Item(i).Item(6) Then

                If datosUsuarios.Rows.Item(i).Item(7) = "Cliente" Then
                    id = datosUsuarios.Rows.Item(i).Item(0)
                End If
                Return datosUsuarios.Rows.Item(i).Item(7)
            End If
        Next
        Return "0"
    End Function
End Module
