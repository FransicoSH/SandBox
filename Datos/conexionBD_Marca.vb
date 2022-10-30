Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexionBD_Marca

    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")
    Public Function ObtenerMarca() As DataSet
        Try

            Dim comando As New SqlCommand("SP_ListaMarca", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()

            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion

            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Marca")


            conexion.Close()

            Return dataSet

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)

        End Try
        Return Nothing

    End Function




End Class