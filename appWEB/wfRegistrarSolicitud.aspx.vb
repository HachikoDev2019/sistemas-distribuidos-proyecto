Imports capaNegocio
Partial Class wfRegistrarSolicitud
    Inherits System.Web.UI.Page
    Dim objSolicitud As New clsSolicitud
    Dim objMaquinaria As New clsMaquinaria

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblSolicitante.Text = Session("nombre")
            Try
                ddlMaquina.DataSource = objMaquinaria.listarMaquinasDisponibles
                ddlMaquina.DataTextField = "maquina"
                ddlMaquina.DataValueField = "id_maquinaria"
                ddlMaquina.DataBind()
            Catch ex As Exception
                lblMensaje.Text = ex.Message
            End Try
        End If
    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            If txtDescripcion.Text = "" Then
                lblMensaje.Text = "Ingrese la descripción del problema!"
                Exit Sub
            End If
            objSolicitud.registrarSolicitud(CInt(Session("id")), CInt(ddlMaquina.SelectedValue), txtDescripcion.Text, ddlArea.Text, ddlPrioridad.Text)
            lblMensaje.Text = "Solicitud registrada correctamente! Puede ver su estado en Mis solicitudes."
            txtDescripcion.Text = ""
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDescripcion.Text = ""
        lblMensaje.Text = ""
    End Sub
End Class
