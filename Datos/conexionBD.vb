Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexionBD
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=CRIVAGO;Integrated Security=True")

    Public Function datosUsuario() As DataTable

        Try


            Dim comando As New SqlCommand("SP_ListaUsuarios", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()
            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Usuario")
            Dim datos As New DataTable
            datos = dataSet.Tables("usuario")
            conexion.Close()
            Return datos

        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)
        End Try

    End Function

    Public Function ListaCliente() As DataTable

        Try

            Dim comando As New SqlCommand("SP_ListaClientes", conexion)
            comando.CommandType = CommandType.StoredProcedure
            conexion.Open()
            Dim dataAdapter As New SqlDataAdapter
            dataAdapter.SelectCommand = comando
            dataAdapter.SelectCommand.Connection = conexion
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "Usuario")
            Dim datos As New DataTable
            datos = dataSet.Tables("Usuario")
            conexion.Close()
            Return datos


        Catch ex As Exception
            Throw New System.Exception("An exception has occurred.", ex)
        End Try


        Return Nothing
    End Function

End Class


