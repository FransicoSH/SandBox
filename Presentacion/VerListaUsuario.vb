Imports logica
Imports System.Windows.Forms

Public Class VerListaUsuario
    Private Sub btnVerUsuario_Click(sender As Object, e As EventArgs) Handles btnVerUsuario.Click
        Dim tabla As New DataTable

        tabla = ListaCliente()
        If tabla IsNot Nothing Then
            DataGridView1.DataSource = tabla
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DataGridView1.Rows.Count <> 0 Then
            Dim idUsuario As Integer = DataGridView1.SelectedCells.Item(0).Value
            If idUsuario <> 0 Then
                Dim formReservas As New menuReservas
                setIdUsuari(idUsuario)
                SetActivarReserva(True)
                formReservas.ShowDialog()
            End If
        Else
            MessageBox.Show("¡Debe selecionar un Usuario!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub VerListaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#f3d598")
        GroupBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#f3d598")
    End Sub
End Class