Imports Datos
Imports System.Windows.Forms
Public Module Module1
    Dim conexionBDReservas As New conexionBD_Reservas()
    Dim TablaAeropuertos As DataTable
    Dim tablaItinerario As DataTable

    Public Function GetAeropuertos(pais As String) As DataSet

        Dim dataset = conexionBDReservas.ObtenerAeropuerto(pais)
        TablaAeropuertos = dataset.Tables("Aeropuerto")

        Return dataset

    End Function
    Public Function getValidacionFechas(fecha As String) As Boolean
        ' Esta wea de validación me saco las canas y me hizo desvelarme bien machín XD
        Dim datos As DataTable
        datos = conexionBDReservas.ValidacionFechasBD(id, fecha)
        If IsNothing(datos) Then  'Si en la consulta no encuentra una reserva pude ser utilizado esa fecha
            Return True

        End If
        Return False
    End Function
    Public Function ObtengoItinerario_Logica(idAeropuerto As Integer, fechasalida As String) As DataTable
        'Nota: Francisco Solano Hernándes   
        'formato de la tabla que verá el usuario =====>  
        '|Fecha de salida     |  Fecha de LLegada   | Pais        | Avion  | Marca   |  Modelo  | Capacidad|
        '|--|	2/12/2021 00:00:00  |Costa Rica	  | Prueba | Airbus  |	A330    |   502    |
        Try
            'Se busca el nombre del aeropuerto escogido por el usuario para extraer de la misma tabla, fila el, id del aeropuerto 
            tablaItinerario = conexionBDReservas.obtengoItinerario(idAeropuerto)
            If tablaItinerario IsNot Nothing Then

                Dim datos As New DataTable
                datos.Columns.Add("Codigo de vuelo")
                datos.Columns.Add(tablaItinerario.Columns.Item(1).ColumnName)
                datos.Columns.Add(tablaItinerario.Columns.Item(2).ColumnName)
                datos.Columns.Add(tablaItinerario.Columns.Item(3).ColumnName)
                datos.Columns.Add(tablaItinerario.Columns.Item(4).ColumnName)
                datos.Columns.Add(tablaItinerario.Columns.Item(5).ColumnName)
                datos.Columns.Add(tablaItinerario.Columns.Item(6).ColumnName)
                datos.Columns.Add(tablaItinerario.Columns.Item(7).ColumnName)
                For Each row As DataRow In tablaItinerario.Rows
                    Dim dato As String = row.Item("FechaHoraSalida")
                    Dim fecha() = dato.Split(" ")
                    If fechasalida = fecha(0) Then
                        datos.Rows.Add(row.Item("id"), row.Item("FechaHoraSalida"), row.Item("FechaHoraLlegada"), row.Item("Pais"), row.Item("Avion"), row.Item("Marca"), row.Item("Modelo"), row.Item("Capacidad"))
                    End If
                Next
                Return datos
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function



    Public Sub InsertarReserva(FechaSalida As String, FechaLlegada As String, cantidadBoletos As Integer, idItinerario As Integer, paisSalida As String, idAeropuerto As Integer)


        Dim idPais As Integer = TablaAeropuertos.Rows.Item(idAeropuerto).Item(2)
        conexionBDReservas.insertarReserva(FechaSalida, FechaLlegada, cantidadBoletos, id, idItinerario, idPais, paisSalida)




    End Sub





End Module
