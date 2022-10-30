Imports logica
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Identificacion
    Dim tablaIdentificacion As DataTable
    Dim IdSeleccionado As Integer

    Public Sub CargarIdentificacion()
        Dim IdentificacionDataSet As DataSet
        IdentificacionDataSet = GetIdentificacion()
        tablaIdentificacion = New DataTable()
        tablaIdentificacion = IdentificacionDataSet.Tables("Identificacion")

        DgvIdentificaciones.DataSource = tablaIdentificacion


    End Sub

    Public Sub Identificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarIdentificacion()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If IdSeleccionado > 0 Then
            ActualizarIdentificacion(IdSeleccionado, TxtDescripcion.Text)
            IdSeleccionado = 0
        Else
            InsertarIdentificacion(TxtDescripcion.Text)
        End If
        CargarIdentificacion()
        LimpiarCampos()


    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim row As DataGridViewRow = DgvIdentificaciones.CurrentRow

        Dim id As Integer = Convert.ToInt32(row.Cells("Id").Value.ToString())
        BorrarIdentificacion(id)


        CargarIdentificacion()
    End Sub

    Private Sub DgvIdentificaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIdentificaciones.CellDoubleClick

        Dim row As DataGridViewRow = DgvIdentificaciones.CurrentRow
        IdSeleccionado = Convert.ToInt32(row.Cells("Id").Value.ToString())
        TxtDescripcion.Text = row.Cells("Descripcion").Value.ToString()
    End Sub

    Private Sub LimpiarCampos()
        TxtDescripcion.Clear()
    End Sub


End Class