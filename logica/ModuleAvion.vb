Imports Datos
Imports System.Windows.Forms
Public Module ModuleAvion

    Dim conexionBD_Avion As New conexionBD_Avion()
    Dim TablaAvion As DataTable
    Public Function GetAvion() As DataSet

        Dim dataset = conexionBD_Avion.ObtenerAvion()
        TablaAvion = dataset.Tables("Avion")

        Return dataset

    End Function

    Public Sub InsertarAvion(Avion As String, Capacidad As Integer, IdMarca As Integer, IdModelo As Integer)
        conexionBD_Avion.InsertarAvion(Avion, Capacidad, IdMarca, IdModelo)

    End Sub

    Public Sub BorrarAvion(Id As Integer)

        conexionBD_Avion.BorrarAvion(Id)


    End Sub

    Public Sub ActualizarAvion(Id As Integer, Avion As String, Capacidad As Integer, IdMarca As Integer, IdModelo As Integer)

        conexionBD_Avion.ActualizarAvion(Id, Avion, Capacidad, IdMarca, IdModelo)

    End Sub

End Module

