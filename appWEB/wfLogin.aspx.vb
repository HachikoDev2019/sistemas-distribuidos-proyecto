Imports capaNegocio

Partial Class wfLogin
    Inherits System.Web.UI.Page
    Dim objPersonal As New clsPersonal

    Protected Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If txtDni.Text <> "" And txtContraseña.Text <> "" Then
                If objPersonal.validarDNI(txtDni.Text) Then
                    If objPersonal.iniciarSesion(txtDni.Text, txtContraseña.Text) Then
                        'lblMensaje.Text = "Bienvenido al Sistema!"
                        Response.Redirect("wfInicio.aspx")
                    Else
                        lblMensaje.Text = "Contraseña incorrecta, intente nuevamente!"
                    End If
                Else
                    lblMensaje.Text = "Usuario no encontrado!"
                End If
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
