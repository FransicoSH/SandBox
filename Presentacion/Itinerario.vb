Imports logica
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Itinerario
    Dim tablaItinerario As DataTable
    Dim tablaAvion As DataTable
    Dim tablaPais As DataTable
    Dim tablaAeropuerto As DataTable
    Dim IdSeleccionado As Integer

    Public Sub CargarItinerario()
        Dim ItinerarioDataSet As DataSet
        ItinerarioDataSet = GetItinerario()
        tablaItinerario = New DataTable()
        tablaItinerario = ItinerarioDataSet.Tables("Itinerario")

        DgvItinerario.DataSource = tablaItinerario
    End Sub

    Public Sub CargarAvion()
        Dim AvionDataSet As DataSet
        AvionDataSet = GetAvion()
        tablaAvion = New DataTable()
        tablaAvion = AvionDataSet.Tables("Avion")

        CmbAvion.DisplayMember = "Avion"
        CmbAvion.ValueMember = "Id"
        CmbAvion.DataSource = tablaAvion
    End Sub

    'Public Sub ValidarDatos()
    '    If String.IsNullOrEmpty(TxtAvion.Text) Then
    '        MessageBox.Show("Nombre de Avión es requerido")
    '    End If

    '    If String.IsNullOrEmpty(CmbModelo.SelectedValue) Then
    '        MessageBox.Show("Nombre de Modelo es requerido")
    '    End If
    'End Sub

    Public Sub CargarPais()
        Dim PaisDataSet As DataSet
        PaisDataSet = GetPais()
        tablaPais = New DataTable()
        tablaPais = PaisDataSet.Tables("Pais")

        CmbPais.DisplayMember = "Pais"
        CmbPais.ValueMember = "Id"
        CmbPais.DataSource = tablaPais
    End Sub

    Public Sub CargarAeropuerto()
        Dim AeropuertoDataSet As DataSet
        AeropuertoDataSet = GetAeropuerto()
        tablaAeropuerto = New DataTable()
        tablaAeropuerto = AeropuertoDataSet.Tables("Aeropuerto")

        CmbAeropuerto.DisplayMember = "Aeropuerto"
        CmbAeropuerto.ValueMember = "Id"
        CmbAeropuerto.DataSource = tablaAeropuerto
    End Sub
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Public Sub Itinerario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarItinerario()
        CargarAvion()
        CargarPais()
        CargarAeropuerto()
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim fechaSalida As DateTime = DtpFechaHoraSalida.Value.ToShortDateString & " " & dtHoraSalida.Value.ToShortTimeString
        Dim fechaLLegada As DateTime = DtpFechaHoraLlegada.Value.ToShortDateString & " " & dtHoraLLegada.Value.ToShortTimeString

        If IdSeleccionado > 0 Then
            ActualizarItinerario(IdSeleccionado, fechaSalida, fechaLLegada, CmbAvion.SelectedValue, CmbPais.SelectedValue, CmbAeropuerto.SelectedValue)
            IdSeleccionado = 0

        Else
            InsertarItinerario(fechaSalida, fechaLLegada, CmbAvion.SelectedValue, CmbPais.SelectedValue, CmbAeropuerto.SelectedValue)
        End If
        CargarItinerario()
        LimpiarCampos()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿¿Está seguro que desea eliminar las reservas  seleccionadas de forma permanente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Dim row As DataGridViewRow = DgvItinerario.CurrentRow
            Dim id As Integer = Convert.ToInt32(row.Cells("Id").Value.ToString())
            BorrarItinerario(id)
            LimpiarCampos()
            CargarItinerario()

        End If


    End Sub

    Private Sub DgvItinerario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItinerario.CellDoubleClick
        Dim row As DataGridViewRow = DgvItinerario.CurrentRow

        dtHoraSalida.Value = row.Cells("FechaHoraSalida").Value.ToString()
        dtHoraLLegada.Value = row.Cells("FechaHoraLlegada").Value.ToString

        IdSeleccionado = Convert.ToInt32(row.Cells("Id").Value.ToString())
        'TxtFechaSalida.Text = row.Cells("FechaHoraSalida").Value.ToString()
        'TxtFechaLlegada.Text = row.Cells("FechaHoraLlegada").Value.ToString()
        DtpFechaHoraLlegada.Value = row.Cells("FechaHoraLlegada").Value.ToString
        DtpFechaHoraSalida.Value = row.Cells("FechaHoraSalida").Value.ToString()
        CmbAvion.SelectedValue = Convert.ToInt32(row.Cells("IdAvion").Value.ToString())
        CmbPais.SelectedValue = Convert.ToInt32(row.Cells("IdPais").Value.ToString())
        CmbAeropuerto.SelectedValue = Convert.ToInt32(row.Cells("IdAeropuerto").Value.ToString())
    End Sub

    Private Sub LimpiarCampos()
        'TxthoraSalida.Text = "2021-01-01 00:00:00"
        'txtHoraLLegada.Text = "2021-01-01 00:00:00"
        CmbAvion.SelectedIndex = 0
        CmbPais.SelectedIndex = 0
        CmbAeropuerto.SelectedIndex = 0
        IdSeleccionado = -1
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarCampos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show(DtpFechaHoraSalida.Value.ToShortDateString & " " & DtpFechaHoraSalida.Value.ToLongTimeString)
    End Sub

    Private Sub DtpFechaHoraSalida_ValueChanged(sender As Object, e As EventArgs) Handles DtpFechaHoraSalida.ValueChanged

    End Sub

    Private Sub LblAeropuerto_Click(sender As Object, e As EventArgs) Handles LblAeropuerto.Click

    End Sub

    Private Sub CmbPais_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbPais.SelectedValueChanged

        Dim AeropuertoDataSet = GetAeropuertos(CmbPais.Text)

        CmbAeropuerto.DataSource = AeropuertoDataSet.Tables("Aeropuerto")
        CmbAeropuerto.DisplayMember = "Aeropuerto"
        CmbAeropuerto.ValueMember = "Id"
        If CmbAeropuerto.Items.Count > 0 Then
            CmbAeropuerto.SelectedIndex = 0

        End If

    End Sub

    Private Sub DgvItinerario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItinerario.CellContentClick

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class

