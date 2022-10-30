
Imports System.Windows.Forms
Imports logica
Class verReservas
    Dim tablaDatos As New DataTable
    Dim importoLista As Boolean = False

    Private Function validacionDeCheckDataGreid() As Boolean
        'se valida que no exporte un xml si no hay un valor marcado 

        Dim cont As Integer = 0
        For i = 0 To DataGridReservas.Rows.Count - 1
            If DataGridReservas.Rows.Item(i).Cells.Item(0).Value = True Then
                cont = +1
            End If
        Next


        If (cont = 1) Then
            Return True
        Else
            Return False
        End If



    End Function


    Private Function AgregoDatos() As DataTable



        For i As Integer = 0 To DataGridReservas.Rows.Count - 1
            If DataGridReservas.Rows.Item(i).Cells.Item(0).Value = True Then
                tablaDatos.Rows.Add(DataGridReservas.Rows.Item(i).Cells.Item(1).Value, DataGridReservas.Rows.Item(i).Cells.Item(4).Value, DataGridReservas.Rows.Item(i).Cells.Item(2).Value, DataGridReservas.Rows.Item(i).Cells.Item(3).Value, DataGridReservas.Rows.Item(i).Cells.Item(5).Value, DataGridReservas.Rows.Item(i).Cells.Item(6).Value, DataGridReservas.Rows.Item(i).Cells.Item(7).Value)
            End If
        Next
        Return tablaDatos
    End Function



    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    <Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub verReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tablaDatos.Columns.Add("Codigo Reserva")
        tablaDatos.Columns.Add("País de partida")
        tablaDatos.Columns.Add("Fecha de salida")
        tablaDatos.Columns.Add("Fecha de regreso")
        tablaDatos.Columns.Add("Pais de destino")
        tablaDatos.Columns.Add("Cantidad de pasajes comprados")
        tablaDatos.Columns.Add("Codigo Itinerario")
        If GetActivasReservas() = True Then
            btnModificar.Visible = True
            btnBorrrar.Visible = True
        End If
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim formModificar As New Modificar_Reserva

        If validacionDeCheckDataGreid() = True Then
            formModificar.txtIdReserva.Text = DataGridReservas.SelectedCells.Item(1).Value

            formModificar.txtOrigen.Text = DataGridReservas.SelectedCells.Item(4).Value
            formModificar.txtDestino.Text = DataGridReservas.SelectedCells.Item(5).Value
            formModificar.DtSalida.Value = DataGridReservas.SelectedCells.Item(2).Value

            formModificar.DtRegreso.Value = DataGridReservas.SelectedCells.Item(3).Value
            formModificar.Show()
        Else
            MessageBox.Show("Debe selecionar una reserva", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Close()
    End Sub

    Private Sub BtnVerReservas_Click(sender As Object, e As EventArgs) Handles BtnVerReservas.Click
        Dim datos = verListaDeReservas()
        If datos IsNot Nothing Then
            DataGridReservas.DataSource = datos
            importoLista = True
        Else
            MessageBox.Show("¡No tiene reservas registradas!", "INFORME", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnExportarXml_Click(sender As Object, e As EventArgs) Handles BtnExportarXml.Click
        If importoLista = True Then
            AgregoDatos()
            If tablaDatos.Rows.Count <> 0 Then
                SaveFileDialog1.Title = "Seleccione una ubicación"
                SaveFileDialog1.Filter = "XML|*.xml"

                If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim url = SaveFileDialog1.FileName
                    ExportarXmL(url, tablaDatos)
                    MessageBox.Show("¡Se exportó exictosamente!", "INFORME", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            Else
                MessageBox.Show("¡Debe marcar al menos una reserva!", "INFORME", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("¡Debe importa la lista de reservas!", "INFORME", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnBorrrar_Click(sender As Object, e As EventArgs) Handles btnBorrrar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿¿Está seguro que desea eliminar las reservas  seleccionadas de forma permanente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then

            For i = 0 To DataGridReservas.Rows.Count - 1
                If DataGridReservas.Rows.Item(i).Cells.Item(0).Value = True Then
                    BorrarReserva(DataGridReservas.Rows.Item(i).Cells.Item(1).Value)
                    BtnVerReservas.PerformClick()
                End If
            Next
        End If
    End Sub

    Private Sub BtnExportarXml_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnExportarXml.MouseUp

    End Sub
End Class