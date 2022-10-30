Imports Datos
Imports System.Windows.Forms
Public Module ModuleItinerario

    Dim conexionBD_Itinerario As New conexionBD_Itinerario()
    Dim TablaItinerario As DataTable
    Public Function GetItinerario() As DataSet

        Dim dataset = conexionBD_Itinerario.ObtenerItinerario()
        TablaItinerario = dataset.Tables("Itinerario")

        Return dataset

    End Function

    Public Sub InsertarItinerario(FechaHoraSalida As Date, FechaHoraLlegada As Date, IdAvion As Integer, IdPais As Integer, IdAeropuerto As Integer)
        conexionBD_Itinerario.InsertarItinerario(FechaHoraSalida, FechaHoraLlegada, IdAvion, IdPais, IdAeropuerto)

    End Sub

    Public Sub BorrarItinerario(Id As Integer)

        conexionBD_Itinerario.BorrarItinerario(Id)


    End Sub

    Public Sub ActualizarItinerario(Id As Integer, FechaHoraSalida As Date, FechaHoraLlegada As Date, IdAvion As Integer, IdPais As Integer, IdAeropuerto As Integer)

        conexionBD_Itinerario.ActualizarItinerario(Id, FechaHoraSalida, FechaHoraLlegada, IdAvion, IdPais, IdAeropuerto)

    End Sub

End Module

