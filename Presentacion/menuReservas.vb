Imports logica
Imports System.Runtime.InteropServices

Public Class menuReservas
    Private Sub ReservaDeVuelosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservaDeVuelosToolStripMenuItem.Click
        Dim reservar As New Reservar()
        reservar.ShowDialog()
    End Sub

    Private Sub VuelosReservadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VuelosReservadosToolStripMenuItem.Click
        Dim verReserva As New verReservas()
        verReserva.ShowDialog()
    End Sub

    Private Sub CerrarSeccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSeccionToolStripMenuItem.Click
        If GetActivasReservas() = True Then
            SetActivarReserva(False)
            Close()
        Else
            Dim formLogin As New menuLogin
            formLogin.Show()
            Close()
        End If


    End Sub
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, HE As Integer) As IntPtr

    End Function
    Private Sub menuReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20))
    End Sub
End Class