Imports logica
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Avion
    Dim tablaAvion As DataTable
    Dim tablaMarca As DataTable
    Dim tablaModelo As DataTable
    Dim IdSeleccionado As Integer

    Public Sub CargarAvion()
        Dim AvionDataSet As DataSet
        AvionDataSet = GetAvion()
        tablaAvion = New DataTable()
        tablaAvion = AvionDataSet.Tables("Avion")

        DgvAvion.DataSource = tablaAvion
    End Sub

    Public Sub CargarMarca()
        Dim MarcaDataSet As DataSet
        MarcaDataSet = GetMarca()
        tablaMarca = New DataTable()
        tablaMarca = MarcaDataSet.Tables("Marca")

        CmbMarca.DisplayMember = "Marca"
        CmbMarca.ValueMember = "Id"
        CmbMarca.DataSource = tablaMarca
    End Sub

    Public Sub ValidarDatos()
        If String.IsNullOrEmpty(TxtAvion.Text) Then
            MessageBox.Show("Nombre de Avión es requerido")
        End If

        If String.IsNullOrEmpty(CmbModelo.SelectedValue) Then
            MessageBox.Show("Nombre de Modelo es requerido")
        End If
    End Sub

    Public Sub CargarModelo()
        Dim ModeloDataSet As DataSet
        ModeloDataSet = GetModelo()
        tablaModelo = New DataTable()
        tablaModelo = ModeloDataSet.Tables("Modelo")

        CmbModelo.DisplayMember = "Modelo"
        CmbModelo.ValueMember = "Id"
        CmbModelo.DataSource = tablaModelo
    End Sub

    Public Sub Avion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAvion()
        CargarMarca()
        CargarModelo()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If IdSeleccionado > 0 Then
            ActualizarAvion(IdSeleccionado, TxtAvion.Text, NmrCapacidad.Value, CmbMarca.SelectedValue, CmbModelo.SelectedValue)
            IdSeleccionado = 0

        Else
            InsertarAvion(TxtAvion.Text, NmrCapacidad.Value, CmbMarca.SelectedValue, CmbModelo.SelectedValue)
        End If
        CargarAvion()
        LimpiarCampos()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Está seguro que desea eliminar este Avion de forma permanente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Dim row As DataGridViewRow = DgvAvion.CurrentRow
            Dim id As Integer = Convert.ToInt32(row.Cells("Id").Value.ToString())
            BorrarAvion(id)
            LimpiarCampos()
            CargarAvion()
        End If

    End Sub

    Private Sub DgvAvion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAvion.CellDoubleClick

        Dim row As DataGridViewRow = DgvAvion.CurrentRow
        IdSeleccionado = Convert.ToInt32(row.Cells("Id").Value.ToString())
        TxtAvion.Text = row.Cells("Avion").Value.ToString()
        NmrCapacidad.Value = Convert.ToInt32(row.Cells("Capacidad").Value.ToString())
        CmbMarca.SelectedValue = Convert.ToInt32(row.Cells("IdMarca").Value.ToString())
        CmbModelo.SelectedValue = Convert.ToInt32(row.Cells("IdModelo").Value.ToString())

    End Sub

    Private Sub LimpiarCampos()
        TxtAvion.Clear()
        NmrCapacidad.Value = 0
        CmbMarca.SelectedIndex = 0
        CmbModelo.SelectedIndex = 0
        IdSeleccionado = -1
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarCampos()

    End Sub
End Class