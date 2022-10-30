Imports System.Xml
Imports Datos

Public Module ModuleVerReservas
    Dim conexionBDVerReserva As New conexionBD_VerResevas()
    Public Function verListaDeReservas() As DataTable
        Dim TablaReservas = conexionBDVerReserva.ObtenerReserva(id)
        If TablaReservas.Rows.Count = 0 Then
            Return Nothing
        Else
            Return TablaReservas
        End If
    End Function

    Public Sub ExportarXmL(url As String, datos As DataTable)

        Try
            Dim config As New XmlWriterSettings()
            config.Indent = True
            Using writer As XmlWriter = XmlWriter.Create(url, config)
                writer.WriteStartDocument()
                writer.WriteStartElement("ListaRervas")
                For Each filas As DataRow In datos.Rows
                    writer.WriteStartElement("Reserva")
                    writer.WriteElementString("Codigo_Reserva", filas("Codigo Reserva"))
                    writer.WriteElementString("País_de_partida", filas("País de partida"))
                    writer.WriteElementString("Fecha_de_salida", filas("Fecha de salida"))
                    writer.WriteElementString("Fecha_de_regreso", filas("Fecha de regreso"))
                    writer.WriteElementString("Pais_de_destino", filas("Pais de destino"))

                    writer.WriteElementString("Cantidad_de_pasajes_comprados", filas("Cantidad de pasajes comprados"))
                    writer.WriteElementString("Codigo_Itinerario", filas("Codigo Itinerario"))
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try



    End Sub
    Public Sub BorrarReserva(id As Integer)

        conexionBDVerReserva.borrarReserva(id)

    End Sub

    Public Sub ModificarReserva(ID As Integer, fechaDeRegreso As String)

        conexionBDVerReserva.ModificarRreserva(fechaDeRegreso, ID)

    End Sub



End Module
