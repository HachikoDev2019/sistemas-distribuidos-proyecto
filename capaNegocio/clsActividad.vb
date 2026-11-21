Imports System.Data
Imports capaDatos
Public Class clsActividad
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    Public Function generarIDActividad() As Integer
        strCon = "select isnull(max(id_actividad),0)+1 from actividad_maquinaria"
        Try
            dt = objMan.listarComando(strCon)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de actividad!")
        End Try
    End Function

    Public Sub registrarActividad(idMaquinaria As Integer, idPersonal As Integer, zona As String, combustibleInicial As String, horasEstimadas As String)
        Dim dtOp As New DataTable
        dtOp = objMan.listarComando("select count(*) from actividad_maquinaria where id_personal=" & idPersonal & " and estado='ACTIVO'")
        If CInt(dtOp.Rows(0).Item(0)) > 0 Then
            Throw New Exception("El operario ya tiene una jornada ACTIVA. Finalícela antes de asignarle otra!")
        End If
        strCon = "insert into actividad_maquinaria (id_maquinaria, id_personal, zona, combustible_inicial, horas_estimadas, estado, fecha_inicio) values(" & idMaquinaria & "," & idPersonal & ",'" & zona & "'," & combustibleInicial.Replace(",", ".") & "," & horasEstimadas.Replace(",", ".") & ",'ACTIVO',getdate())"
        Try
            objMan.ejecutarComando(strCon)
            strCon = "update maquinaria set estado='Operativo' where id_maquinaria=" & idMaquinaria
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar actividad!")
        End Try
    End Sub

    Public Sub modificarActividad(id As Integer, zona As String, combustibleInicial As String, combustibleFinal As String, horasEstimadas As String, horasReales As String, motivoRetraso As String, observacionFalla As String, estado As String)
        Dim dtEst As New DataTable
        dtEst = objMan.listarComando("select estado from actividad_maquinaria where id_actividad=" & id)
        If dtEst.Rows.Count > 0 AndAlso dtEst.Rows(0).Item(0).ToString() <> "ACTIVO" Then
            Throw New Exception("La jornada ya está cerrada (" & dtEst.Rows(0).Item(0).ToString() & "). No se puede modificar ni finalizar!")
        End If
        If combustibleFinal = "" Then combustibleFinal = "null"
        If horasReales = "" Then horasReales = "null"
        If combustibleInicial = "" Then combustibleInicial = "null"
        If horasEstimadas = "" Then horasEstimadas = "null"
        Dim cierre As String = ""
        If estado = "AVERIADO" Or estado = "FINALIZADO" Then
            cierre = ", fecha_fin=getdate()"
        End If
        strCon = "update actividad_maquinaria set zona='" & zona & "', combustible_inicial=" & combustibleInicial.Replace(",", ".") & ", combustible_final=" & combustibleFinal.Replace(",", ".") & ", horas_estimadas=" & horasEstimadas.Replace(",", ".") & ", horas_reales=" & horasReales.Replace(",", ".") & ", motivo_retraso='" & motivoRetraso & "', observacion_falla='" & observacionFalla & "', estado='" & estado & "'" & cierre & " where id_actividad=" & id
        Try
            objMan.ejecutarComando(strCon)
            If estado = "AVERIADO" Then
                strCon = "update maquinaria set estado='En Mantenimiento' where id_maquinaria=(select id_maquinaria from actividad_maquinaria where id_actividad=" & id & ")"
                objMan.ejecutarComando(strCon)
            ElseIf estado = "FINALIZADO" Then
                strCon = "update maquinaria set estado='Sin Tarea' where id_maquinaria=(select id_maquinaria from actividad_maquinaria where id_actividad=" & id & ")"
                objMan.ejecutarComando(strCon)
            End If
        Catch ex As Exception
            Throw New Exception("Error al modificar actividad!")
        End Try
    End Sub

    Public Sub eliminarActividad(id As Integer)
        strCon = "delete from actividad_maquinaria where id_actividad=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar actividad!")
        End Try
    End Sub

    Public Sub finalizarActividad(id As Integer, combustibleFinal As String, horasReales As String, motivoRetraso As String)
        Dim dtEst As New DataTable
        dtEst = objMan.listarComando("select estado from actividad_maquinaria where id_actividad=" & id)
        If dtEst.Rows.Count > 0 AndAlso dtEst.Rows(0).Item(0).ToString() <> "ACTIVO" Then
            Throw New Exception("La jornada ya está cerrada (" & dtEst.Rows(0).Item(0).ToString() & "). No se puede modificar ni finalizar!")
        End If
        If combustibleFinal = "" Then combustibleFinal = "null"
        If horasReales = "" Then horasReales = "null"
        strCon = "update actividad_maquinaria set combustible_final=" & combustibleFinal.Replace(",", ".") & ", horas_reales=" & horasReales.Replace(",", ".") & ", motivo_retraso='" & motivoRetraso & "', estado='FINALIZADO', fecha_fin=getdate() where id_actividad=" & id
        Try
            objMan.ejecutarComando(strCon)
            strCon = "update maquinaria set estado='Sin Tarea' where id_maquinaria=(select id_maquinaria from actividad_maquinaria where id_actividad=" & id & ")"
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al finalizar actividad!")
        End Try
    End Sub

    Public Function buscarActividad(id As Integer) As DataTable
        strCon = "select a.id_actividad, a.id_maquinaria, m.nombre_codigo, a.id_personal, p.dni, p.nombres + ' ' + p.apellidos, a.zona, a.combustible_inicial, a.combustible_final, a.horas_estimadas, a.horas_reales, a.motivo_retraso, a.observacion_falla, a.estado from actividad_maquinaria a inner join maquinaria m on a.id_maquinaria = m.id_maquinaria inner join personal p on a.id_personal = p.id_personal where a.id_actividad=" & id
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al buscar actividad!")
        End Try
    End Function

    Public Function listarActividad() As DataTable
        strCon = "select a.id_actividad as ID, m.nombre_codigo as Maquina, p.nombres + ' ' + p.apellidos as Personal, a.zona as Zona, a.estado as Estado, convert(varchar(16), a.fecha_inicio, 120) as Inicio from actividad_maquinaria a inner join maquinaria m on a.id_maquinaria = m.id_maquinaria inner join personal p on a.id_personal = p.id_personal order by a.id_actividad desc"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar la actividad!")
        End Try
    End Function

    Public Function listarJornadasActivas() As DataTable
        strCon = "select a.id_actividad as ID, m.nombre_codigo as Maquina, p.nombres + ' ' + p.apellidos as Operador, a.zona as Zona, convert(varchar(16), a.fecha_inicio, 120) as Inicio, a.horas_estimadas as [Horas estimadas], cast(datediff(minute, a.fecha_inicio, getdate()) / 60.0 as decimal(10,1)) as [Horas transcurridas], case when datediff(minute, a.fecha_inicio, getdate()) / 60.0 > a.horas_estimadas then 'RETRASADA' else 'En tiempo' end as Situacion from actividad_maquinaria a inner join maquinaria m on a.id_maquinaria = m.id_maquinaria inner join personal p on a.id_personal = p.id_personal where a.estado='ACTIVO' order by a.fecha_inicio"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las jornadas activas!")
        End Try
    End Function

    Public Function reporteHorasPorMaquina(fechaInicio As String, fechaFin As String) As DataTable
        strCon = "select m.nombre_codigo as Maquina, m.tipo as Tipo, count(a.id_actividad) as Jornadas, isnull(sum(a.horas_estimadas),0) as [Horas estimadas], isnull(sum(a.horas_reales),0) as [Horas reales], isnull(sum(a.horas_reales),0) - isnull(sum(a.horas_estimadas),0) as Diferencia, sum(case when a.estado='AVERIADO' then 1 else 0 end) as Averias from actividad_maquinaria a inner join maquinaria m on a.id_maquinaria = m.id_maquinaria where a.estado<>'ACTIVO' and convert(date, a.fecha_inicio) between '" & fechaInicio & "' and '" & fechaFin & "' group by m.nombre_codigo, m.tipo order by m.nombre_codigo"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al generar el reporte de horas!")
        End Try
    End Function
End Class
