Imports logica
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Pais
    Dim tablaPais As DataTable
    Dim IdSeleccionado As Integer

    Public Sub CargarPais()
        Dim PaisDataSet As DataSet
        PaisDataSet = GetPais()
        tablaPais = New DataTable()
        tablaPais = PaisDataSet.Tables("Pais")

        DgvPais.DataSource = tablaPais


    End Sub

    Public Sub Pais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPais()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If IdSeleccionado > 0 Then
            ActualizarPais(IdSeleccionado, TxtPais.Text, TxtCodigoInternacional.Text)
            IdSeleccionado = 0
        Else
            InsertarPais(TxtPais.Text, TxtCodigoInternacional.Text)
        End If
        CargarPais()
        LimpiarCampos()


    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Está seguro que desea eliminar este pais de forma permanente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            Dim row As DataGridViewRow = DgvPais.CurrentRow
            Dim id As Integer = Convert.ToInt32(row.Cells("Id").Value.ToString())
            BorrarPais(id)
            CargarPais()
        End If
    End Sub

    Private Sub DgvPais_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPais.CellDoubleClick

        Dim row As DataGridViewRow = DgvPais.CurrentRow
        IdSeleccionado = Convert.ToInt32(row.Cells("Id").Value.ToString())
        TxtPais.Text = row.Cells("Pais").Value.ToString()
        TxtCodigoInternacional.Text = row.Cells("CodigoInternacionalPais").Value.ToString()
    End Sub

    Private Sub LimpiarCampos()
        TxtPais.Clear()
        TxtCodigoInternacional.Clear()
    End Sub

    Private Sub DgvPais_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPais.CellContentClick

    End Sub
End Class