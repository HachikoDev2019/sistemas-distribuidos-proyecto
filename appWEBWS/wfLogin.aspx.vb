Imports System.Data

Partial Class wfLogin
    Inherits System.Web.UI.Page
    Dim objPersonal As New ServiceReferencePomalca.wsPomalcaSoapClient
    Dim objBitacora As New ServiceReferencePomalca.wsPomalcaSoapClient

    Protected Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If txtDni.Text <> "" And txtContraseña.Text <> "" Then
                If objPersonal.validarDNI(txtDni.Text) Then
                    If objPersonal.iniciarSesion(txtDni.Text, txtContraseña.Text) Then
                        'lblMensaje.Text = "Bienvenido al Sistema!"
                        Dim dtUsu As New DataTable
                        dtUsu = objPersonal.buscarPersonal(txtDni.Text)
                        Session("dni") = txtDni.Text
                        Session("nombre") = dtUsu.Rows(0).Item(2) & " " & dtUsu.Rows(0).Item(3)
                        Session("tipo") = dtUsu.Rows(0).Item(7)
                        Session("id") = dtUsu.Rows(0).Item(0)
                        Try
                            objBitacora.registrarBitacora(CInt(dtUsu.Rows(0).Item(0)), "login", 0)
                        Catch ex As Exception
                        End Try
                        Session("intentos") = 0
                        Response.Redirect("wfInicio.aspx")
                    Else
                        Session("intentos") = CInt(Session("intentos")) + 1
                        Try
                            objBitacora.registrarBitacora(0, "login failed", CInt(Session("intentos")))
                        Catch ex As Exception
                        End Try
                        lblMensaje.Text = "Contraseña incorrecta, intente nuevamente!"
                    End If
                Else
                    Session("intentos") = CInt(Session("intentos")) + 1
                    Try
                        objBitacora.registrarBitacora(0, "login failed", CInt(Session("intentos")))
                    Catch ex As Exception
                    End Try
                    lblMensaje.Text = "Usuario no encontrado!"
                End If
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
