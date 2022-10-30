Imports logica
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Reservar

    Private Const BorderWidth As Integer = 6
    Private _resizeDir As ResizeDirection = ResizeDirection.None

    Public Enum ResizeDirection
        None = 0
        left = 1
        topLeft = 2
        TopRight = 4
        Rigth = 5
        BottomRight = 6
        Botton = 7
        BottonLeft = 8
    End Enum


    Dim tablaAeropuertos As DataTable
    Dim reservar As New DataGridViewImageColumn
    Private Sub llenoCb(data As DataSet)

        cmbAeropuerto.DataSource = data.Tables("Aeropuerto")
        cmbAeropuerto.DisplayMember = "Aeropuerto"
        cmbAeropuerto.ValueMember = "Id"
        If cmbAeropuerto.Items.Count > 0 Then
            cmbAeropuerto.SelectedIndex = 0

        End If


    End Sub


    Private Function validacionFecha() As Boolean
        Dim fecha1 = DtSalida.Value
        Dim fecha2 = DtRegreso.Value
        Dim resutado = getValidacionFechas(fecha1.Year & "-" & fecha1.Month & "-" & fecha1.Day)
        Dim resutado2 = getValidacionFechas(fecha2.Year & "-" & fecha2.Month & "-" & fecha2.Day)


        If resutado = False Then
            MessageBox.Show("Ya tiene una reserva en esa fecha")
            lbSalida.Visible = True
            Return False
        ElseIf resutado2 = False Then
            MessageBox.Show("Ya tiene una reserva en esa fecha")
            lbRegreso.Visible = True
            Return False
        End If
        Return True

    End Function

    Private Sub btnBusacr_Click(sender As Object, e As EventArgs) Handles btnBusacr.Click
        DtgReservas.Columns.Clear()


        If cmbAeropuerto.Text IsNot "" Then

            Dim tabla = ObtengoItinerario_Logica(cmbAeropuerto.SelectedValue, DtSalida.Text)

            If tabla.Rows.Count <> 0 Then
                GBxItinerario.Visible = True

                DtgReservas.DataSource = tabla
                'DtgReservas.Columns.RemoveAt(0)
                imgDatagrid()
                DtgReservas.Columns.Add(reservar)


            Else
                MessageBox.Show("No hay vuelos para la fecha seleccionada")
            End If
        Else
            MessageBox.Show("Debe agregar un país de destino")
        End If
    End Sub

    Private Sub txtDestino_TextChanged(sender As Object, e As EventArgs) Handles txtDestino.TextChanged

        llenoCb(GetAeropuertos(txtDestino.Text))

    End Sub

    Private Sub DtgReservas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgReservas.CellClick
        Dim index As Integer

        If DtgReservas.Columns(e.ColumnIndex).Index = 8 Then
            lbRegreso.Visible = False
            lbSalida.Visible = False
            If txtDestino.Text IsNot "" And txtOrigen.Text IsNot "" And nupPasajeros.Value <> 0 Then

                If validacionFecha() = True Then
                    index = DtgReservas.Rows(e.RowIndex).Cells(0).Value

                    If DtgReservas.Rows(e.RowIndex).Cells(7).Value >= nupPasajeros.Value Then

                        InsertarReserva(DtSalida.Text, DtRegreso.Text, nupPasajeros.Value, index, txtOrigen.Text, cmbAeropuerto.SelectedIndex)
                        lbRegreso.Visible = False
                        lbSalida.Visible = False
                        Dim formVerReservas As New verReservas()
                        formVerReservas.Show()
                        Dispose()
                    Else
                        MessageBox.Show("La cantidad de boletos es mayor que la disponible")

                    End If

                End If
            Else
                MessageBox.Show("Todos los campos son obligatorios. Complete los campos vacíos")

            End If
        End If



    End Sub




    Public Sub imgDatagrid()
        reservar.Image = My.Resources.reserva
        reservar.ImageLayout = DataGridViewImageCellLayout.Normal
        reservar.Width = 50

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function

    Private Sub Reservar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))


    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GBxItinerario_Enter(sender As Object, e As EventArgs) Handles GBxItinerario.Enter

    End Sub

    Private Sub cmbAeropuerto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAeropuerto.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MessageBox.Show(cmbAeropuerto.SelectedValue)
    End Sub

    Private Sub DtgReservas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgReservas.CellContentClick

    End Sub
End Class