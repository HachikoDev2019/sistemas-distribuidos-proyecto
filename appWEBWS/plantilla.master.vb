
Partial Class plantilla
    Inherits System.Web.UI.MasterPage
    Dim objBitacora As New ServiceReferencePomalca.wsPomalcaSoapClient

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("tipo") Is Nothing Then
            Response.Redirect("wfLogin.aspx")
        End If
        lblUsuario.Text = Session("nombre") & " (" & Session("tipo") & ")"
        aplicarPermisos()
    End Sub

    Private Sub aplicarPermisos()
        Dim tipo As String = Session("tipo")
        btnMPersonal.Visible = (tipo = "Administrador")
        btnMMaquinaria.Visible = (tipo = "Administrador" Or tipo = "Supervisor")
        btnMMantenimientos.Visible = (tipo = "Administrador" Or tipo = "Supervisor")
        btnMZonas.Visible = (tipo = "Administrador" Or tipo = "Supervisor")
        btnMSolicitudes.Visible = (tipo = "Administrador" Or tipo = "Supervisor")
        btnMRegistrarSolicitud.Visible = True
        btnMMisSolicitudes.Visible = True
        btnMActividad.Visible = True
        btnMJornadasActivas.Visible = True
        btnMReporteHoras.Visible = (tipo = "Administrador" Or tipo = "Supervisor")
        btnMIniciarSesion.Visible = False
        btnMBitacora.Visible = (tipo = "Administrador")
        btnMCambiarContrasena.Visible = True
        lblModMaquinaria.Visible = btnMMaquinaria.Visible
    End Sub

    Protected Sub btnMInicio_Click(sender As Object, e As EventArgs) Handles btnMInicio.Click
        Response.Redirect("wfInicio.aspx")
    End Sub

    Protected Sub btnMIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnMIniciarSesion.Click
        Response.Redirect("wfLogin.aspx")
    End Sub

    Protected Sub btnMCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnMCerrarSesion.Click
        Try
            objBitacora.registrarBitacora(CInt(Session("id")), "logout", 0)
        Catch ex As Exception
        End Try
        Session.Abandon()
        Response.Redirect("wfLogin.aspx")
    End Sub

    Protected Sub btnMPersonal_Click(sender As Object, e As EventArgs) Handles btnMPersonal.Click
        Response.Redirect("wfPersonal.aspx")
    End Sub

    Protected Sub btnMMaquinaria_Click(sender As Object, e As EventArgs) Handles btnMMaquinaria.Click
        Response.Redirect("wfMaquinaria.aspx")
    End Sub

    Protected Sub btnMMantenimientos_Click(sender As Object, e As EventArgs) Handles btnMMantenimientos.Click
        Response.Redirect("wfMantenimientos.aspx")
    End Sub

    Protected Sub btnMZonas_Click(sender As Object, e As EventArgs) Handles btnMZonas.Click
        Response.Redirect("wfZonas.aspx")
    End Sub

    Protected Sub btnMSolicitudes_Click(sender As Object, e As EventArgs) Handles btnMSolicitudes.Click
        Response.Redirect("wfSolicitudes.aspx")
    End Sub

    Protected Sub btnMRegistrarSolicitud_Click(sender As Object, e As EventArgs) Handles btnMRegistrarSolicitud.Click
        Response.Redirect("wfRegistrarSolicitud.aspx")
    End Sub

    Protected Sub btnMMisSolicitudes_Click(sender As Object, e As EventArgs) Handles btnMMisSolicitudes.Click
        Response.Redirect("wfMisSolicitudes.aspx")
    End Sub

    Protected Sub btnMActividad_Click(sender As Object, e As EventArgs) Handles btnMActividad.Click
        Response.Redirect("wfActividad.aspx")
    End Sub

    Protected Sub btnMJornadasActivas_Click(sender As Object, e As EventArgs) Handles btnMJornadasActivas.Click
        Response.Redirect("wfJornadasActivas.aspx")
    End Sub

    Protected Sub btnMReporteHoras_Click(sender As Object, e As EventArgs) Handles btnMReporteHoras.Click
        Response.Redirect("wfReporteHoras.aspx")
    End Sub

    Protected Sub btnMCambiarContrasena_Click(sender As Object, e As EventArgs) Handles btnMCambiarContrasena.Click
        Response.Redirect("wfCambiarContrasena.aspx")
    End Sub

    Protected Sub btnMBitacora_Click(sender As Object, e As EventArgs) Handles btnMBitacora.Click
        Response.Redirect("wfBitacora.aspx")
    End Sub
End Class
