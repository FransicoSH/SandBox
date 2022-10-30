Imports Datos
Imports System.Windows.Forms
Public Module ModuleIdentificacion
    Dim conexionBD_Identificacion As New conexionBD_Identificacion()
    Dim TablaIdentificacion As DataTable
    Public Function GetIdentificacion() As DataSet

        Dim dataset = conexionBD_Identificacion.ObtenerIdentificacion()
        TablaIdentificacion = dataset.Tables("Identificacion")

        Return dataset

    End Function

    Public Sub InsertarIdentificacion(Descripcion As String)

        conexionBD_Identificacion.InsertarIdentificacion(Descripcion)


    End Sub

    Public Sub BorrarIdentificacion(Id As Integer)

        conexionBD_Identificacion.BorrarIdentificacion(Id)


    End Sub

    Public Sub ActualizarIdentificacion(Id As Integer, Descripcion As String)

        conexionBD_Identificacion.ActualizarIdentificacion(Id, Descripcion)

    End Sub

End Module
