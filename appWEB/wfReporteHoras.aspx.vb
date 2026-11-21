Imports System.Data
Imports capaNegocio
Partial Class wfReporteHoras
    Inherits System.Web.UI.Page
    Dim objActividad As New clsActividad

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("tipo") <> "Administrador" And Session("tipo") <> "Supervisor" Then
            Response.Redirect("wfInicio.aspx")
        End If
        If Not IsPostBack Then
            txtFechaInicio.Text = Date.Today.AddDays(-30).ToString("yyyy-MM-dd")
            txtFechaFin.Text = Date.Today.ToString("yyyy-MM-dd")
        End If
    End Sub

    Protected Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim dt As New DataTable
        Try
            If txtFechaInicio.Text = "" Or txtFechaFin.Text = "" Then
                lblMensaje.Text = "Seleccione las dos fechas!"
                Exit Sub
            End If
            If CDate(txtFechaInicio.Text) > CDate(txtFechaFin.Text) Then
                lblMensaje.Text = "La fecha de inicio no puede ser mayor a la fecha fin!"
                Exit Sub
            End If
            dt = objActividad.reporteHorasPorMaquina(txtFechaInicio.Text, txtFechaFin.Text)
            grvReporte.DataSource = dt
            grvReporte.DataBind()
            If dt.Rows.Count = 0 Then
                lblMensaje.Text = "No hay jornadas cerradas en ese rango de fechas."
                lblResumen.Text = ""
            Else
                Dim totalJornadas As Integer = 0
                Dim totalEstimadas As Decimal = 0
                Dim totalReales As Decimal = 0
                Dim totalAverias As Integer = 0
                For Each fila As DataRow In dt.Rows
                    totalJornadas = totalJornadas + CInt(fila("Jornadas"))
                    totalEstimadas = totalEstimadas + CDec(fila("Horas estimadas"))
                    totalReales = totalReales + CDec(fila("Horas reales"))
                    totalAverias = totalAverias + CInt(fila("Averias"))
                Next
                lblResumen.Text = "Total: " & totalJornadas & " jornadas | " & totalEstimadas & " h estimadas | " & totalReales & " h reales | " & totalAverias & " averías"
                lblMensaje.Text = ""
            End If
        Catch ex As Exception
            lblMensaje.Text = ex.Message
        End Try
    End Sub
End Class
