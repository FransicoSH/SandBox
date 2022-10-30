Imports System.Windows.Forms
Imports logica

Public Class menuLogin
    Private Sub btnregistrocliente_Click(sender As Object, e As EventArgs) Handles btnregistrocliente.Click
        Dim FormCrearUsuario As New Registrar()

        FormCrearUsuario.cbRol.SelectedValue = 2
        FormCrearUsuario.lblRol.Visible = False
        FormCrearUsuario.cbRol.Visible = False
        FormCrearUsuario.ShowDialog()

        Close()
    End Sub

    Private Sub btnclienteiniciar_Click(sender As Object, e As EventArgs) Handles btnclienteiniciar.Click
        Dim rol As String
        rol = validacionUsuario(txtusuario.Text, txtContraseña.Text)
        Select Case rol
            Case "Administrativo"
                Dim FormAdmin As New menuAdmin()
                FormAdmin.Show()

                Close()
            Case "Cliente"
                Dim formUsuario As New menuReservas()
                formUsuario.Show()
                Close()
            Case "0"
                MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub
End Class