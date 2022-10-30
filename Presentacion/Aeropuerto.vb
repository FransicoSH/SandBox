Imports logica
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Aeropuerto
    Dim tablaAeropuerto As DataTable
    Dim tablaPais As DataTable
    Dim IdSeleccionado As Integer

    Public Sub CargarAeropuerto()
        Dim AeropuertoDataSet As DataSet
        AeropuertoDataSet = GetAeropuerto()
        tablaAeropuerto = New DataTable()
        tablaAeropuerto = AeropuertoDataSet.Tables("Aeropuerto")

        DgvAeropuerto.DataSource = tablaAeropuerto
    End Sub

    Public Sub CargarPais()
        Dim PaisDataSet As DataSet
        PaisDataSet = GetPais()
        tablaPais = New DataTable()
        tablaPais = PaisDataSet.Tables("Pais")

        CmbPais.DisplayMember = "Pais"
        CmbPais.ValueMember = "Id"
        CmbPais.DataSource = tablaPais
    End Sub


    Public Sub Aeropuerto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAeropuerto()
        CargarPais()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If IdSeleccionado > 0 Then
            ActualizarAeropuerto(IdSeleccionado, TxtAeropuerto.Text, TxtCodigoAeropuerto.Text, CmbPais.SelectedValue)
            IdSeleccionado = 0
        Else
            InsertarAeropuerto(TxtAeropuerto.Text, TxtCodigoAeropuerto.Text, CmbPais.SelectedValue)
        End If
        CargarAeropuerto()
        LimpiarCampos()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click

        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Está seguro que desea eliminar este aeropuerto de forma permanente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Dim row As DataGridViewRow = DgvAeropuerto.CurrentRow
            Dim id As Integer = Convert.ToInt32(row.Cells("Id").Value.ToString())
            BorrarAeropuerto(id)
            CargarAeropuerto()
        End If


    End Sub

    Private Sub DgvAeropuerto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAeropuerto.CellDoubleClick

        Dim row As DataGridViewRow = DgvAeropuerto.CurrentRow
        IdSeleccionado = Convert.ToInt32(row.Cells("Id").Value.ToString())
        TxtAeropuerto.Text = row.Cells("Aeropuerto").Value.ToString()
        TxtCodigoAeropuerto.Text = row.Cells("CodigoInternacionalAeropuerto").Value.ToString()
        CmbPais.SelectedValue = Convert.ToInt32(row.Cells("IdPais").Value.ToString())
    End Sub

    Private Sub LimpiarCampos()
        TxtAeropuerto.Clear()
        TxtCodigoAeropuerto.Clear()
        CmbPais.SelectedIndex = 0
    End Sub

End Class