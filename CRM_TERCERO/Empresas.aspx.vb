Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD

Public Class Empresas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function EmpresasBuscarTodo() As String
        Try
            Dim oDs As New DataSet
            Dim oobjeto As New Empresa
            oDs = oobjeto.BuscarTodos
            Dim IdTabla As Integer = 0

            Dim e As EmpresaWS() = New EmpresaWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New EmpresaWS With {
                    .IdEmpresa = oDs.Tables(IdTabla).Rows(i).Item("IdEmpresa").ToString(),
                    .RazonSocial = oDs.Tables(IdTabla).Rows(i).Item("RazonSocial").ToString(),
                    .Fantasia = oDs.Tables(IdTabla).Rows(i).Item("Fantasia").ToString(),
                    .NroCuit = oDs.Tables(IdTabla).Rows(i).Item("NroCuit").ToString(),
                    .IdLocalidad = oDs.Tables(IdTabla).Rows(i).Item("IdLocalidad").ToString(),
                    .Domicilio = oDs.Tables(IdTabla).Rows(i).Item("Domicilio").ToString(),
                    .Lat = oDs.Tables(IdTabla).Rows(i).Item("Lat").ToString(),
                    .Lng = oDs.Tables(IdTabla).Rows(i).Item("Lng").ToString(),
                    .Imagen = oDs.Tables(IdTabla).Rows(i).Item("Imagen").ToString(),
                    .EmpresaTipo = oDs.Tables(IdTabla).Rows(i).Item("EmpresaTipo").ToString(),
                    .Observaciones = oDs.Tables(IdTabla).Rows(i).Item("Observaciones").ToString(),
                    .Prioridad = oDs.Tables(IdTabla).Rows(i).Item("Prioridad").ToString(),
                    .FechaInicioActividad = oDs.Tables(IdTabla).Rows(i).Item("FechaInicioActividad").ToString(),
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
    Public Shared Function EmpresasAgregar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of EmpresaWS))("[" & cadena & "]")

            Dim RazonSocial = dict(0).RazonSocial.ToString
            Dim Fantasia = dict(0).Fantasia.ToString
            Dim NroCuit = dict(0).NroCuit.ToString
            Dim IdLocalidad = dict(0).IdLocalidad.ToString
            Dim Domicilio = dict(0).Domicilio.ToString
            Dim Lat = dict(0).Lat.ToString
            Dim Lng = dict(0).Lng.ToString
            Dim Imagen = dict(0).Imagen.ToString
            Dim EmpresaTipo = dict(0).EmpresaTipo.ToString
            Dim Observaciones = dict(0).Observaciones.ToString
            Dim Prioridad = dict(0).Prioridad.ToString
            Dim FechaInicioActividad = dict(0).FechaInicioActividad.ToString
            Dim Estado = dict(0).Estado.ToString

            Dim oobjeto As New Empresa
            oobjeto.Agregar(RazonSocial, Fantasia, NroCuit, IdLocalidad, Domicilio, Lat, Lng, Imagen, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)

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
    Public Shared Function EmpresasModificar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of EmpresaWS))("[" & cadena & "]")

            Dim IdEmpresa = dict(0).IdEmpresa.ToString
            Dim RazonSocial = dict(0).RazonSocial.ToString
            Dim Fantasia = dict(0).Fantasia.ToString
            Dim NroCuit = dict(0).NroCuit.ToString
            Dim IdLocalidad = dict(0).IdLocalidad.ToString
            Dim Domicilio = dict(0).Domicilio.ToString
            Dim Lat = dict(0).Lat.ToString
            Dim Lng = dict(0).Lng.ToString
            Dim Imagen = dict(0).Imagen.ToString
            Dim EmpresaTipo = dict(0).EmpresaTipo.ToString
            Dim Observaciones = dict(0).Observaciones.ToString
            Dim Prioridad = dict(0).Prioridad.ToString
            Dim FechaInicioActividad = dict(0).FechaInicioActividad.ToString
            Dim Estado = dict(0).Estado.ToString

            Dim oobjeto As New Empresa

            oobjeto.Modificar(IdEmpresa, RazonSocial, Fantasia, NroCuit, IdLocalidad, Domicilio, Lat, Lng, Imagen, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)

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
    Public Shared Function EmpresasBuscarPorId(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of EmpresaWS))("[" & cadena & "]")

            Dim IdEmpresa = dict(0).IdEmpresa.ToString

            Dim oDs As New DataSet
            Dim oobjeto As New Empresa
            oDs = oobjeto.BuscarPorId(IdEmpresa)

            Dim IdTabla As Integer = 0

            Dim data = New With {
                Key .Status = "200",
                Key .IdEmpresa = oDs.Tables(IdTabla).Rows(0).Item("IdEmpresa").ToString(),
                    .RazonSocial = oDs.Tables(IdTabla).Rows(0).Item("RazonSocial").ToString(),
                    .Fantasia = oDs.Tables(IdTabla).Rows(0).Item("Fantasia").ToString(),
                    .NroCuit = oDs.Tables(IdTabla).Rows(0).Item("NroCuit").ToString(),
                    .IdLocalidad = oDs.Tables(IdTabla).Rows(0).Item("IdLocalidad").ToString(),
                    .Domicilio = oDs.Tables(IdTabla).Rows(0).Item("Domicilio").ToString(),
                    .Lat = oDs.Tables(IdTabla).Rows(0).Item("Lat").ToString(),
                    .Lng = oDs.Tables(IdTabla).Rows(0).Item("Lng").ToString(),
                    .Imagen = oDs.Tables(IdTabla).Rows(0).Item("Imagen").ToString(),
                    .EmpresaTipo = oDs.Tables(IdTabla).Rows(0).Item("EmpresaTipo").ToString(),
                    .Observaciones = oDs.Tables(IdTabla).Rows(0).Item("Observaciones").ToString(),
                    .Prioridad = oDs.Tables(IdTabla).Rows(0).Item("Prioridad").ToString(),
                    .FechaInicioActividad = oDs.Tables(IdTabla).Rows(0).Item("FechaInicioActividad").ToString(),
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

    Public Shared Function Error401()
        Dim data = New With {
                         Key .Status = "401"
                     }
        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)
        Return New JavaScriptSerializer().Serialize(data)
    End Function
End Class