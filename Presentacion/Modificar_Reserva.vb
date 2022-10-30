
Imports System.Windows.Forms

Imports logica
Public Class Modificar_Reserva

    Dim id As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fecha1 As Date = DtSalida.Value
        Dim fecha2 As Date = DtRegreso.Value
        If fecha1 < fecha2 Then
            ModificarReserva(txtIdReserva.Text, DtRegreso.Text)
        Else

            MessageBox.Show("No puede agregar una fecha menor a la de salida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub
End Class