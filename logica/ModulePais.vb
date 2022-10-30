Imports Datos
Imports System.Windows.Forms

Public Module ModulePais
    Dim conexionBD_Pais As New conexionBD_Pais()
    Dim TablaPais As DataTable
    Public Function GetPais() As DataSet

        Dim dataset = conexionBD_Pais.ObtenerPais()
        TablaPais = dataset.Tables("Pais")

        Return dataset

    End Function

    Public Sub InsertarPais(Pais As String, CodigoCodigoInternacionalPais As String
                                      )
        conexionBD_Pais.InsertarPais(Pais, CodigoCodigoInternacionalPais)


    End Sub

    Public Sub BorrarPais(Id As Integer)
        Dim conexionBD_Pais As New conexionBD_Pais()
        conexionBD_Pais.BorrarPais(Id)


    End Sub

    Public Sub ActualizarPais(Id As Integer, Pais As String, CodigoInternacionalPais As String)

        conexionBD_Pais.ActualizarPais(Id, Pais, CodigoInternacionalPais)

    End Sub

End Module
