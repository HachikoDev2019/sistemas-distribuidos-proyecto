Imports System.CodeDom
Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports capaNegocio

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class wsPomalca
    Inherits System.Web.Services.WebService
    Dim objPersonal As New clsPersonal
    Dim objMaquinaria As New clsMaquinaria
    Dim objSolicitud As New clsSolicitud
    Dim objActividad As New clsActividad
    Dim objBitacora As New clsBitacora
    Dim objZona As New clsZona
    Dim objMantenimiento As New clsMantenimientoMaquina

    ' ===== PERSONAL =====

    <WebMethod()>
    Public Function validarDNI(dni As String) As Boolean
        Try
            Return objPersonal.validarDNI(dni)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function iniciarSesion(dni As String, contraseña As String) As Boolean
        Try
            Return objPersonal.iniciarSesion(dni, contraseña)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function generarIDPersonal() As Integer
        Try
            Return objPersonal.generarIDPersonal()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub registrarPersonal(dni As String, nombres As String, apellidos As String, telefono As String, correo As String, contraseña As String, tipo_usuario As String, area As String, vigente As Boolean)
        Try
            objPersonal.registrarPersonal(dni, nombres, apellidos, telefono, correo, contraseña, tipo_usuario, area, vigente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub modificarPersonal(id As Integer, dni As String, nombres As String, apellidos As String, telefono As String, correo As String, contraseña As String, tipo_usuario As String, area As String, vigente As Boolean)
        Try
            objPersonal.modificarPersonal(id, dni, nombres, apellidos, telefono, correo, contraseña, tipo_usuario, area, vigente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub eliminarPersonal(id As Integer)
        Try
            objPersonal.eliminarPersonal(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub darBajaPersonal(id As Integer)
        Try
            objPersonal.darBajaPersonal(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function buscarPersonal(dni As String) As DataTable
        Dim dt As New DataTable
        Try
            dt = objPersonal.buscarPersonal(dni)
            dt.TableName = "Personal"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarPersonal() As DataTable
        Dim dt As New DataTable
        Try
            dt = objPersonal.listarPersonal()
            dt.TableName = "Personal"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarOperariosCombo() As DataTable
        Dim dt As New DataTable
        Try
            dt = objPersonal.listarOperariosCombo()
            dt.TableName = "Personal"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarPersonalCombo() As DataTable
        Dim dt As New DataTable
        Try
            dt = objPersonal.listarPersonalCombo()
            dt.TableName = "Personal"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub cambiarContrasena(dni As String, nueva As String)
        Try
            objPersonal.cambiarContraseña(dni, nueva)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    ' ===== MAQUINARIA =====

    <WebMethod()>
    Public Function generarIDMaquinaria() As Integer
        Try
            Return objMaquinaria.generarIDMaquinaria()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub registrarMaquinaria(codigo As String, tipo As String, marca As String, modelo As String, area As String, estado As String, observaciones As String)
        Try
            objMaquinaria.registrarMaquinaria(codigo, tipo, marca, modelo, area, estado, observaciones)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub modificarMaquinaria(id As Integer, codigo As String, tipo As String, marca As String, modelo As String, area As String, estado As String, observaciones As String)
        Try
            objMaquinaria.modificarMaquinaria(id, codigo, tipo, marca, modelo, area, estado, observaciones)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub eliminarMaquinaria(id As Integer)
        Try
            objMaquinaria.eliminarMaquinaria(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub darBajaMaquinaria(id As Integer)
        Try
            objMaquinaria.darBajaMaquinaria(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function buscarMaquinaria(codigo As String) As DataTable
        Dim dt As New DataTable
        Try
            dt = objMaquinaria.buscarMaquinaria(codigo)
            dt.TableName = "Maquinaria"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarMaquinaria() As DataTable
        Dim dt As New DataTable
        Try
            dt = objMaquinaria.listarMaquinaria()
            dt.TableName = "Maquinaria"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarMaquinasCombo() As DataTable
        Dim dt As New DataTable
        Try
            dt = objMaquinaria.listarMaquinasCombo()
            dt.TableName = "Maquinaria"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarMaquinasDisponibles() As DataTable
        Dim dt As New DataTable
        Try
            dt = objMaquinaria.listarMaquinasDisponibles()
            dt.TableName = "Maquinaria"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarMaquinasEnMantenimiento() As DataTable
        Dim dt As New DataTable
        Try
            dt = objMaquinaria.listarMaquinasEnMantenimiento()
            dt.TableName = "Maquinaria"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ' ===== SOLICITUDES =====

    <WebMethod()>
    Public Function generarIDSolicitud() As Integer
        Try
            Return objSolicitud.generarIDSolicitud()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub registrarSolicitud(idPersonal As Integer, idMaquinaria As Integer, descripcion As String, area As String, prioridad As String)
        Try
            objSolicitud.registrarSolicitud(idPersonal, idMaquinaria, descripcion, area, prioridad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub modificarSolicitud(id As Integer, idMaquinaria As Integer, descripcion As String, area As String, prioridad As String, estado As String, comentario As String)
        Try
            objSolicitud.modificarSolicitud(id, idMaquinaria, descripcion, area, prioridad, estado, comentario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub eliminarSolicitud(id As Integer)
        Try
            objSolicitud.eliminarSolicitud(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function buscarSolicitud(id As Integer) As DataTable
        Dim dt As New DataTable
        Try
            dt = objSolicitud.buscarSolicitud(id)
            dt.TableName = "Solicitudes"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarSolicitudes() As DataTable
        Dim dt As New DataTable
        Try
            dt = objSolicitud.listarSolicitudes()
            dt.TableName = "Solicitudes"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarMisSolicitudes(idPersonal As Integer) As DataTable
        Dim dt As New DataTable
        Try
            dt = objSolicitud.listarMisSolicitudes(idPersonal)
            dt.TableName = "Solicitudes"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ' ===== ACTIVIDAD =====

    <WebMethod()>
    Public Function generarIDActividad() As Integer
        Try
            Return objActividad.generarIDActividad()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub registrarActividad(idMaquinaria As Integer, idPersonal As Integer, zona As String, combustibleInicial As String, horasEstimadas As String)
        Try
            objActividad.registrarActividad(idMaquinaria, idPersonal, zona, combustibleInicial, horasEstimadas)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub modificarActividad(id As Integer, zona As String, combustibleInicial As String, combustibleFinal As String, horasEstimadas As String, horasReales As String, motivoRetraso As String, observacionFalla As String, estado As String)
        Try
            objActividad.modificarActividad(id, zona, combustibleInicial, combustibleFinal, horasEstimadas, horasReales, motivoRetraso, observacionFalla, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub eliminarActividad(id As Integer)
        Try
            objActividad.eliminarActividad(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub finalizarActividad(id As Integer, combustibleFinal As String, horasReales As String, motivoRetraso As String)
        Try
            objActividad.finalizarActividad(id, combustibleFinal, horasReales, motivoRetraso)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function buscarActividad(id As Integer) As DataTable
        Dim dt As New DataTable
        Try
            dt = objActividad.buscarActividad(id)
            dt.TableName = "Actividad"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarActividad() As DataTable
        Dim dt As New DataTable
        Try
            dt = objActividad.listarActividad()
            dt.TableName = "Actividad"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarJornadasActivas() As DataTable
        Dim dt As New DataTable
        Try
            dt = objActividad.listarJornadasActivas()
            dt.TableName = "Actividad"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function reporteHorasPorMaquina(fechaInicio As String, fechaFin As String) As DataTable
        Dim dt As New DataTable
        Try
            dt = objActividad.reporteHorasPorMaquina(fechaInicio, fechaFin)
            dt.TableName = "Actividad"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ' ===== BITACORA =====

    <WebMethod()>
    Public Sub registrarBitacora(idUsuario As Integer, accion As String, numIntentos As Integer)
        Try
            objBitacora.registrar(idUsuario, accion, numIntentos)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function listarBitacora() As DataTable
        Dim dt As New DataTable
        Try
            dt = objBitacora.listar()
            dt.TableName = "Bitacora"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ' ===== ZONAS =====

    <WebMethod()>
    Public Function generarIDZona() As Integer
        Try
            Return objZona.generarIDZona()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub registrarZona(nombre As String, descripcion As String, vigente As Boolean)
        Try
            objZona.registrarZona(nombre, descripcion, vigente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub modificarZona(id As Integer, nombre As String, descripcion As String, vigente As Boolean)
        Try
            objZona.modificarZona(id, nombre, descripcion, vigente)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub eliminarZona(id As Integer)
        Try
            objZona.eliminarZona(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub darBajaZona(id As Integer)
        Try
            objZona.darBajaZona(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function buscarZona(nombre As String) As DataTable
        Dim dt As New DataTable
        Try
            dt = objZona.buscarZona(nombre)
            dt.TableName = "Zonas"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarZonas() As DataTable
        Dim dt As New DataTable
        Try
            dt = objZona.listarZonas()
            dt.TableName = "Zonas"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarZonasCombo() As DataTable
        Dim dt As New DataTable
        Try
            dt = objZona.listarZonasCombo()
            dt.TableName = "Zonas"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    ' ===== MANTENIMIENTOS =====

    <WebMethod()>
    Public Function generarIDMantenimiento() As Integer
        Try
            Return objMantenimiento.generarIDMantenimiento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Sub registrarMantenimiento(idMaquinaria As Integer, tipo As String, fecha As String, descripcion As String, costo As String, responsable As String)
        Try
            objMantenimiento.registrarMantenimiento(idMaquinaria, tipo, fecha, descripcion, costo, responsable)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub modificarMantenimiento(id As Integer, idMaquinaria As Integer, tipo As String, fecha As String, descripcion As String, costo As String, responsable As String)
        Try
            objMantenimiento.modificarMantenimiento(id, idMaquinaria, tipo, fecha, descripcion, costo, responsable)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Sub eliminarMantenimiento(id As Integer)
        Try
            objMantenimiento.eliminarMantenimiento(id)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    <WebMethod()>
    Public Function buscarMantenimiento(id As Integer) As DataTable
        Dim dt As New DataTable
        Try
            dt = objMantenimiento.buscarMantenimiento(id)
            dt.TableName = "Mantenimientos"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    <WebMethod()>
    Public Function listarMantenimientos() As DataTable
        Dim dt As New DataTable
        Try
            dt = objMantenimiento.listarMantenimientos()
            dt.TableName = "Mantenimientos"
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
