Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD
Public Class Informaciones
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function InformacionesBuscarTodos() As String
        Try
            Dim oDs As New DataSet

            Dim oobjeto As New Informacion

            oDs = oobjeto.BuscarTodos
            Dim IdTabla As Integer = 0

            Dim e As InformacionWS() = New InformacionWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New InformacionWS With {
                    .IdInformacion = oDs.Tables(IdTabla).Rows(i).Item("IdInformacion").ToString(),
                    .IdEmpresa = oDs.Tables(IdTabla).Rows(i).Item("IdEmpresa").ToString(),
                    .Observaciones = oDs.Tables(IdTabla).Rows(i).Item("Observaciones").ToString(),
                    .Prioridad = oDs.Tables(IdTabla).Rows(i).Item("Prioridad").ToString(),
                    .Estado = oDs.Tables(IdTabla).Rows(i).Item("Estado").ToString()
                }
            Next

            Dim data = New With {
                Key .Status = "200",
                Key .Data = e
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function InformacionesBuscarPorId(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of InformacionWS))("[" & cadena & "]")

            Dim IdInformacion = dict(0).IdInformacion.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Informacion

            oDs = oobjeto.BuscarPorId(IdInformacion)

            Dim IdTabla As Integer = 0


            Dim data = New With {
                Key .Status = "200",
                Key .IdInformacion = oDs.Tables(IdTabla).Rows(0).Item("IdInformacion").ToString(),
                    .IdEmpresa = oDs.Tables(IdTabla).Rows(0).Item("IdEmpresa").ToString(),
                    .Observaciones = oDs.Tables(IdTabla).Rows(0).Item("Observaciones").ToString(),
                    .Prioridad = oDs.Tables(IdTabla).Rows(0).Item("Prioridad").ToString(),
                    .Estado = oDs.Tables(IdTabla).Rows(0).Item("Estado").ToString()
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try

    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function InformacionesAgregar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of InformacionWS))("[" & cadena & "]")

            Dim IdEmpresa = dict(0).IdEmpresa.ToString
            Dim Observaciones = dict(0).Observaciones.ToString
            Dim Prioridad = dict(0).Prioridad.ToString
            Dim Estado = dict(0).Estado.ToString

            Dim oobjeto As New Informacion

            oobjeto.Agregar(IdEmpresa, Observaciones, Prioridad, Estado)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function InformacionesModificar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of InformacionWS))("[" & cadena & "]")

            Dim IdInformacion = dict(0).IdInformacion.ToString
            Dim IdEmpresa = dict(0).IdEmpresa.ToString
            Dim Observaciones = dict(0).Observaciones.ToString
            Dim Prioridad = dict(0).Prioridad.ToString
            Dim Estado = dict(0).Estado.ToString


            Dim oobjeto As New Informacion

            oobjeto.Modificar(IdInformacion, IdEmpresa, Observaciones, Prioridad, Estado)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function InformacionesEliminar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of InformacionWS))("[" & cadena & "]")

            Dim IdInformacion = dict(0).IdInformacion.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Informacion

            oDs = oobjeto.Eliminar(IdInformacion)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    Public Shared Function Error401()
        Dim data = New With {
                         Key .Status = "401"
                     }
        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)

        Return New JavaScriptSerializer().Serialize(data)
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function InformacionesCboEmpresas() As String
        Try
            Dim oDs As New DataSet

            Dim oobjeto As New Informacion

            oDs = oobjeto.CboEmpresa
            Dim IdTabla As Integer = 0

            Dim e As InformacionWS() = New InformacionWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New InformacionWS With {
                    .IdEmpresa = oDs.Tables(IdTabla).Rows(i).Item("IdEmpresa").ToString(),
                    .RazonSocial = oDs.Tables(IdTabla).Rows(i).Item("RazonSocial").ToString()
                }
            Next

            Dim data = New With {
                Key .Status = "200",
                Key .Data = e
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function InformacionesCambiarEstado(ByVal cadena As String) As String
        Try
            Dim dict = New JavaScriptSerializer().Deserialize(Of List(Of InformacionWS))("[" & cadena & "]")

            Dim IdInformacion = dict(0).IdInformacion.ToString

            Dim oobjeto As New Informacion
            oobjeto.CambiarEstado(IdInformacion)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return jsondatos
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

End Class