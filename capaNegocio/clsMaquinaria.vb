Imports System.Data
Imports capaDatos
Public Class clsMaquinaria
    Dim objMan As New clsMantenimiento
    Dim strCon As String
    Dim dt As New DataTable

    Public Function generarIDMaquinaria() As Integer
        strCon = "select isnull(max(id_maquinaria),0)+1 from maquinaria"
        Try
            dt = objMan.listarComando(strCon)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar el ID de maquinaria!")
        End Try
    End Function

    Public Sub registrarMaquinaria(codigo As String, tipo As String, marca As String, modelo As String, area As String, estado As String, observaciones As String)
        strCon = "insert into maquinaria (nombre_codigo, tipo, marca, modelo, area, estado, observaciones) values('" & codigo & "','" & tipo & "','" & marca & "','" & modelo & "','" & area & "','" & estado & "','" & observaciones & "')"
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al registrar maquinaria!")
        End Try
    End Sub

    Public Sub modificarMaquinaria(id As Integer, codigo As String, tipo As String, marca As String, modelo As String, area As String, estado As String, observaciones As String)
        strCon = "update maquinaria set nombre_codigo='" & codigo & "', tipo='" & tipo & "', marca='" & marca & "', modelo='" & modelo & "', area='" & area & "', estado='" & estado & "', observaciones='" & observaciones & "' where id_maquinaria=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al modificar maquinaria!")
        End Try
    End Sub

    Public Sub eliminarMaquinaria(id As Integer)
        strCon = "delete from maquinaria where id_maquinaria=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("No se puede eliminar: la máquina tiene solicitudes o actividades registradas. Use Dar de Baja.")
        End Try
    End Sub

    Public Sub darBajaMaquinaria(id As Integer)
        strCon = "update maquinaria set estado='Dado de Baja' where id_maquinaria=" & id
        Try
            objMan.ejecutarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja la maquinaria!")
        End Try
    End Sub

    Public Function buscarMaquinaria(codigo As String) As DataTable
        strCon = "select id_maquinaria, nombre_codigo, tipo, marca, modelo, area, estado, observaciones from maquinaria where nombre_codigo='" & codigo & "'"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al buscar maquinaria!")
        End Try
    End Function

    Public Function listarMaquinaria() As DataTable
        strCon = "select id_maquinaria as ID, nombre_codigo as Codigo, tipo as Tipo, marca as Marca, modelo as Modelo, area as Area, estado as Estado from maquinaria"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar la maquinaria!")
        End Try
    End Function

    Public Function listarMaquinasCombo() As DataTable
        strCon = "select id_maquinaria, nombre_codigo + ' - ' + tipo as maquina from maquinaria where estado<>'Dado de Baja' order by nombre_codigo"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las máquinas!")
        End Try
    End Function

    Public Function listarMaquinasDisponibles() As DataTable
        strCon = "select m.id_maquinaria, m.nombre_codigo + ' - ' + m.tipo as maquina from maquinaria m where (m.estado='Operativo' or m.estado='Sin Tarea') and not exists (select 1 from actividad_maquinaria a where a.id_maquinaria = m.id_maquinaria and a.estado='ACTIVO') order by m.nombre_codigo"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las máquinas disponibles!")
        End Try
    End Function

    Public Function listarMaquinasEnMantenimiento() As DataTable
        strCon = "select id_maquinaria, nombre_codigo + ' - ' + tipo as maquina from maquinaria where estado='En Mantenimiento' order by nombre_codigo"
        Try
            Return objMan.listarComando(strCon)
        Catch ex As Exception
            Throw New Exception("Error al listar las máquinas en mantenimiento!")
        End Try
    End Function
End Class
