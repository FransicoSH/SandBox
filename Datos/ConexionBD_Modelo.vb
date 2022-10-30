Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ConexionBD_Modelo

    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerModelo() As DataSet
        Try

            Dim comando As New SqlCommand("SP_ListaModelo", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Modelo")


            conexion.Close()

            Return dataSet

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
        Return Nothing

    End Function




End Class