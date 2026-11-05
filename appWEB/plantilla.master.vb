
Partial Class plantilla
    Inherits System.Web.UI.MasterPage

    Protected Sub btnMInicio_Click(sender As Object, e As EventArgs) Handles btnMInicio.Click
        Response.Redirect("wfInicio.aspx")
    End Sub

    Protected Sub btnMIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnMIniciarSesion.Click
        Response.Redirect("wfLogin.aspx")
    End Sub

    Protected Sub btnMCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnMCerrarSesion.Click
        Response.Redirect("wfLogin.aspx")
    End Sub

    Protected Sub btnMPersonal_Click(sender As Object, e As EventArgs) Handles btnMPersonal.Click
        Response.Redirect("wfPersonal.aspx")
    End Sub
End Class
