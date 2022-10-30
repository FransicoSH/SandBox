Imports Datos

Public Module ModuleAdmin
    Dim conexionBD As New conexionBD
    Dim ActivarReserva As Boolean = False
    Dim NombreDecliente As String
    Public Function VerListaUsuario() As DataTable
        Return conexionBD.datosUsuario()
    End Function

    Public Function ListaCliente() As DataTable
        Dim datos As New DataTable
        datos = conexionBD.ListaCliente()
        If datos IsNot Nothing Then
            id = datos.Rows.Item(0).Item(0)
            NombreDecliente = datos.Rows.Item(0).Item(1)
            Return datos
        End If

        Return Nothing
    End Function


    Public Sub setIdUsuari(SetId As Integer)

        id = SetId

    End Sub

    Public Function GetActivasReservas() As Boolean
        Return ActivarReserva
    End Function
    Public Sub SetActivarReserva(Reserva As Boolean)
        ActivarReserva = Reserva
    End Sub


End Module
