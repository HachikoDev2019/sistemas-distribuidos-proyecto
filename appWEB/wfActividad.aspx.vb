Imports System.Data
Imports capaNegocio
Partial Class wfActividad
    Inherits System.Web.UI.Page
    Dim objActividad As New clsActividad
    Dim objMaquinaria As New clsMaquinaria
    Dim objPersonal As New clsPersonal

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                ddlMaquina.DataSource = objMaquinaria.listarMaquinasCombo
                ddlMaquina.DataTextField = "maquina"
                ddlMaquina.DataValueField = "id_maquinaria"
                ddlMaquina.DataBind()
                ddlOperador.DataSource = objPersonal.listarOperariosCombo
                ddlOperador.DataTextField = "operador"
                ddlOperador.DataValueField = "id_personal"
                ddlOperador.DataBind()
            Catch ex As Exception
                lblMensaje.Text = ex.Message
            End Try
        End If
        listarActividad
    End Sub

    Private Sub listarActividad()
        Try
            grvActividad.DataSource = objActividad.listarActividad
            grvActividad.DataBind()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If btnNuevo.Text.Equals("Nuevo") Then
                limpiarControles()
                btnNuevo.Text = "Guardar"
                txtId.Text = objActividad.generarIDActividad
                ddlMaquina.Focus()
            Else
                btnNuevo.Text = "Nuevo"
                objActividad.registrarActividad(CInt(ddlMaquina.SelectedValue), CInt(ddlOperador.SelectedValue), ddlZona.Text, ddlCombustibleInicial.SelectedValue, txtHorasEstimadas.Text)
                lblMensaje.Text = "Actividad registrada correctamente!"
                limpiarControles()
                listarActividad()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Private Sub limpiarControles()
        txtId .Text =""
        ddlCombustibleFinal.SelectedValue = ""
        txtHorasEstimadas .Text =""
        txtHorasReales .Text =""
        txtMotivoRetraso .Text =""
        txtObservacionFalla.Text = ""
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objActividad.modificarActividad(CInt(txtId.Text), ddlZona.Text, ddlCombustibleInicial.SelectedValue, ddlCombustibleFinal.SelectedValue, txtHorasEstimadas.Text, txtHorasReales.Text, txtMotivoRetraso.Text, txtObservacionFalla.Text, ddlEstado.Text)
            lblMensaje.Text = "Actividad modificada correctamente!"
            limpiarControles()
            listarActividad()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objActividad.eliminarActividad(CInt(txtId.Text))
            lblMensaje.Text = "Actividad eliminada correctamente!"
            limpiarControles()
            listarActividad()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Try
            objActividad.finalizarActividad(CInt(txtId.Text), ddlCombustibleFinal.SelectedValue, txtHorasReales.Text, txtMotivoRetraso.Text)
            lblMensaje.Text = "Actividad finalizada correctamente!"
            limpiarControles()
            listarActividad()
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub

    Protected Sub grvActividad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles grvActividad.SelectedIndexChanged
        txtId.Text = grvActividad.SelectedRow.Cells(1).Text
        btnBuscar_Click(sender, e)
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dtAct As New DataTable
        Try
            If txtId.Text <> "" Then
                dtAct = objActividad.buscarActividad(CInt(txtId.Text))
                If dtAct.Rows.Count > 0 Then
                    txtId.Text = dtAct.Rows(0).Item(0)
                    ddlMaquina.SelectedValue = dtAct.Rows(0).Item(1).ToString()
                    ddlOperador.SelectedValue = dtAct.Rows(0).Item(3).ToString()
                    ddlZona.Text = dtAct.Rows(0).Item(6)
                    If dtAct.Rows(0).Item(7).ToString() <> "" Then ddlCombustibleInicial.SelectedValue = CInt(dtAct.Rows(0).Item(7)).ToString()
                    If dtAct.Rows(0).Item(8).ToString() <> "" Then ddlCombustibleFinal.SelectedValue = CInt(dtAct.Rows(0).Item(8)).ToString() Else ddlCombustibleFinal.SelectedValue = ""
                    txtHorasEstimadas.Text = dtAct.Rows(0).Item(9).ToString()
                    txtHorasReales.Text = dtAct.Rows(0).Item(10).ToString()
                    txtMotivoRetraso.Text = dtAct.Rows(0).Item(11).ToString()
                    txtObservacionFalla.Text = dtAct.Rows(0).Item(12).ToString()
                    ddlEstado.Text = dtAct.Rows(0).Item(13)
                Else
                    lblMensaje.Text = "ID no está registrado!"
                    limpiarControles()
                    txtId.Focus()
                End If
            Else
                lblMensaje.Text = "Ingrese ID a buscar!"
                limpiarControles()
                txtId.Focus()
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
