Imports Datos
Imports System.Windows.Forms
Public Module ModuleAeropuerto

    Dim conexionBD_Aeropuerto As New conexionBD_Aeropuerto()
    Dim TablaAeropuerto As DataTable
    Public Function GetAeropuerto() As DataSet

        Dim dataset = conexionBD_Aeropuerto.ObtenerAeropuerto()
        TablaAeropuerto = dataset.Tables("Aeropuerto")

        Return dataset

    End Function
    Public Sub InsertarAeropuerto(Aeropuerto As String, CodigoInternacionalAeropuerto As String, IdPais As Integer)

        conexionBD_Aeropuerto.InsertarAeropuerto(Aeropuerto, CodigoInternacionalAeropuerto, IdPais)

    End Sub

    Public Sub BorrarAeropuerto(Id As Integer)

        conexionBD_Aeropuerto.BorrarAeropuerto(Id)


    End Sub

    Public Sub ActualizarAeropuerto(Id As Integer, Aeropuerto As String, CodigoInternacionalAeropuerto As String, IdPais As Integer)

        conexionBD_Aeropuerto.ActualizarPais(Id, Aeropuerto, CodigoInternacionalAeropuerto, IdPais)

    End Sub

End Module

