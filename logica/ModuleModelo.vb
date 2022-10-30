Imports Datos
Imports System.Windows.Forms

Public Module ModuleModelo

    Dim conexionBD_Modelo As New ConexionBD_Modelo()
    Dim TablaModelo As DataTable
    Public Function GetModelo() As DataSet

        Dim dataset = conexionBD_Modelo.ObtenerModelo()
        TablaModelo = dataset.Tables("Modelo")

        Return dataset

    End Function

End Module
