Imports Datos
Imports System.Windows.Forms
Public Module ModuleMarca
    Dim conexionBD_Marca As New conexionBD_Marca()
    Dim TablaMarca As DataTable
    Public Function GetMarca() As DataSet

        Dim dataset = conexionBD_Marca.ObtenerMarca()
        TablaMarca = dataset.Tables("Marca")

        Return dataset

    End Function

End Module

