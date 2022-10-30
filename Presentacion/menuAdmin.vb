Imports logica

Public Class menuAdmin
    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

    End Sub

    Private Sub PAISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAISToolStripMenuItem.Click
        Dim formPais As New Pais
        formPais.ShowDialog()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        Dim formRegistro As New Registrar()
        formRegistro.ShowDialog()
    End Sub

    Private Sub VerListaUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click

    End Sub

    Private Sub CerrarSeccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSeccionToolStripMenuItem.Click
        Dim formLogin As New menuLogin
        formLogin.Show()
        Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim formVer As New VerListaUsuario()
        formVer.ShowDialog()
    End Sub

    Private Sub AeropuertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AeropuertosToolStripMenuItem.Click
        Dim formAeropuerto As New Aeropuerto
        formAeropuerto.ShowDialog()

    End Sub

    Private Sub ItinerariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItinerariosToolStripMenuItem.Click
        Dim formItinerario As New Itinerario
        formItinerario.ShowDialog()
    End Sub

    Private Sub AvionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvionesToolStripMenuItem.Click
        Dim formAvion As New Avion
        formAvion.ShowDialog()
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        RegistroAdmin.Show()
    End Sub
End Class