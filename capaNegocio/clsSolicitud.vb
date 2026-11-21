Imports System.Data
Imports capaDatos
Public Class clsSolicitud
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    Public Function generarIDSolicitud() As Integer
        strCon = "select isnull(max(id_solicitud),0)+1 from solicitudes"
        Try
            dt = objMan.listarComando(strCon)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de solicitud!")
        End Try
    End Function

    Public Sub registrarSolicitud(idPersonal As Integer, idMaquinaria As Integer, descripcion As String, area As String, prioridad As String)
        Dim dt As New DataTable
        dt = objMan.listarComando("select top 1 s.id_solicitud, p.nombres + ' ' + p.apellidos, s.estado from solicitudes s inner join personal p on s.id_personal = p.id_personal where s.id_maquinaria=" & idMaquinaria & " and (s.estado='Pendiente' or s.estado='En revisión')")
        If dt.Rows.Count > 0 Then
            Throw New Exception("Esta máquina ya tiene la solicitud N° " & dt.Rows(0).Item(0) & " en estado " & dt.Rows(0).Item(2) & " (registrada por " & dt.Rows(0).Item(1) & "). Espere a que sea atendida!")
        End If
        strCon = "insert into solicitudes (id_personal, id_maquinaria, descripcion, area, prioridad, estado) values(" & idPersonal & "," & idMaquinaria & ",'" & descripcion & "','" & area & "','" & prioridad & "','Pendiente')"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar solicitud!")
        End Try
    End Sub

    Public Sub modificarSolicitud(id As Integer, idMaquinaria As Integer, descripcion As String, area As String, prioridad As String, estado As String, comentario As String)
        If estado = "Aprobado" Then
            Dim dt As New DataTable
            dt = objMan.listarComando("select count(*) from actividad_maquinaria where id_maquinaria=" & idMaquinaria & " and estado='ACTIVO'")
            If CInt(dt.Rows(0).Item(0)) > 0 Then
                Throw New Exception("No se puede aprobar: la máquina está en una jornada ACTIVA. Primero finalice la jornada o márquela como AVERIADO!")
            End If
        End If
        strCon = "update solicitudes set id_maquinaria=" & idMaquinaria & ", descripcion='" & descripcion & "', area='" & area & "', prioridad='" & prioridad & "', estado='" & estado & "', comentario='" & comentario & "' where id_solicitud=" & id
        Try
            objMan.ejecutarComando(strCon)
            If estado = "Aprobado" Then
                strCon = "update maquinaria set estado='En Mantenimiento' where id_maquinaria=" & idMaquinaria
                objMan.ejecutarComando(strCon)
            End If
        Catch ex As Exception
            Throw New Exception("Error al modificar solicitud!")
        End Try
    End Sub

    Public Sub eliminarSolicitud(id As Integer)
        strCon = "delete from solicitudes where id_solicitud=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al eliminar solicitud!")
        End Try
    End Sub

    Public Function buscarSolicitud(id As Integer) As DataTable
        strCon = "select s.id_solicitud, s.id_personal, p.dni, p.nombres + ' ' + p.apellidos, s.descripcion, s.area, s.prioridad, s.estado, s.comentario, s.id_maquinaria from solicitudes s inner join personal p on s.id_personal = p.id_personal where s.id_solicitud=" & id
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al buscar solicitud!")
        End Try
    End Function

    Public Function listarSolicitudes() As DataTable
        strCon = "select s.id_solicitud as ID, p.nombres + ' ' + p.apellidos as Solicitante, m.nombre_codigo as Maquina, s.descripcion as Descripcion, s.area as Area, s.prioridad as Prioridad, s.estado as Estado, convert(varchar(10), s.fecha_registro, 103) as Fecha from solicitudes s inner join personal p on s.id_personal = p.id_personal left join maquinaria m on s.id_maquinaria = m.id_maquinaria order by s.id_solicitud desc"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las solicitudes!")
        End Try
    End Function

    Public Function listarMisSolicitudes(idPersonal As Integer) As DataTable
        strCon = "select s.id_solicitud as ID, m.nombre_codigo as Maquina, s.descripcion as Descripcion, s.area as Area, s.prioridad as Prioridad, s.estado as Estado, s.comentario as Comentario, convert(varchar(10), s.fecha_registro, 103) as Fecha from solicitudes s left join maquinaria m on s.id_maquinaria = m.id_maquinaria where s.id_personal=" & idPersonal & " order by s.id_solicitud desc"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar mis solicitudes!")
        End Try
    End Function
End Class
