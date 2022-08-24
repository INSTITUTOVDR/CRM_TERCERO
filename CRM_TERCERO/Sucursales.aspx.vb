Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD
Imports Newtonsoft.Json.Linq

Public Class Sucursales
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function SucursalesBuscarTodos() As String
        Try
            Dim oDs As New DataSet

            Dim oobjeto As New Sucursal2

            oDs = oobjeto.BuscarTodos
            Dim IdTabla As Integer = 0

            Dim e As SucursalWS() = New SucursalWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New SucursalWS With {
                    .IdSucursal = oDs.Tables(IdTabla).Rows(i).Item("IdSucursal").ToString(),
                    .IdEmpresa = oDs.Tables(IdTabla).Rows(i).Item("IdEmpresa").ToString(),
                    .Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString(),
                    .Fantasia = oDs.Tables(IdTabla).Rows(i).Item("Fantasia").ToString(),
                    .IdProvincia = oDs.Tables(IdTabla).Rows(i).Item("IdProvincia").ToString(),
                    .IdLocalidad = LocalidadBuscarNombre(oDs.Tables(IdTabla).Rows(i).Item("IdLocalidad").ToString()).ToString(),
                    .Domicilio = oDs.Tables(IdTabla).Rows(i).Item("Domicilio").ToString(),
                    .Lat = oDs.Tables(IdTabla).Rows(i).Item("Lat").ToString(),
                    .Lng = oDs.Tables(IdTabla).Rows(i).Item("Lng").ToString(),
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
    Public Shared Function SucursalesBuscarPorId(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of SucursalWS))("[" & cadena & "]")

            Dim IdSucursal = dict(0).IdSucursal.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Sucursal2

            oDs = oobjeto.BuscarPorId(IdSucursal)

            Dim IdTabla As Integer = 0

            Dim IdProvincia = LocalidadBuscarIdProvincia(oDs.Tables(IdTabla).Rows(0).Item("IdLocalidad").ToString())

            Dim data = New With {
                Key .Status = "200",
                Key .IdSucursal = oDs.Tables(IdTabla).Rows(0).Item("IdSucursal").ToString(),
                    .IdEmpresa = oDs.Tables(IdTabla).Rows(0).Item("IdEmpresa").ToString(),
                    .Nombre = oDs.Tables(IdTabla).Rows(0).Item("Nombre").ToString(),
                    .Fantasia = oDs.Tables(IdTabla).Rows(0).Item("Fantasia").ToString(),
                    .IdProvincia = oDs.Tables(IdTabla).Rows(0).Item("IdProvincia").ToString(),
                    .IdLocalidad = oDs.Tables(IdTabla).Rows(0).Item("IdLocalidad").ToString(),
                    .Domicilio = oDs.Tables(IdTabla).Rows(0).Item("Domicilio").ToString(),
                    .Lat = oDs.Tables(IdTabla).Rows(0).Item("Lat").ToString(),
                    .Lng = oDs.Tables(IdTabla).Rows(0).Item("Lng").ToString(),
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
    Public Shared Function SucursalesAgregar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of SucursalWS))("[" & cadena & "]")

            Dim IdEmpresa = dict(0).IdEmpresa.ToString
            Dim Nombre = dict(0).Nombre.ToString
            Dim Fantasia = dict(0).Fantasia.ToString
            Dim IdProvincia = dict(0).IdProvincia.ToString
            Dim IdLocalidad = dict(0).IdLocalidad.ToString
            Dim Domicilio = dict(0).Domicilio.ToString
            Dim Lat = dict(0).Lat.ToString
            Dim Lng = dict(0).Lng.ToString
            Dim Observaciones = dict(0).Observaciones.ToString
            Dim Prioridad = dict(0).Prioridad.ToString
            Dim Estado = dict(0).Estado.ToString

            Dim oobjeto As New Sucursal2

            oobjeto.Agregar(IdEmpresa, Nombre, Fantasia, IdProvincia, IdLocalidad, Domicilio, Lat, Lng, Observaciones, Prioridad, Estado)

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
    Public Shared Function SucursalesModificar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of SucursalWS))("[" & cadena & "]")

            Dim IdSucursal = dict(0).IdSucursal.ToString
            Dim IdEmpresa = dict(0).IdEmpresa.ToString
            Dim Nombre = dict(0).Nombre.ToString
            Dim Fantasia = dict(0).Fantasia.ToString
            Dim IdProvincia = dict(0).IdProvincia.ToString
            Dim IdLocalidad = dict(0).IdLocalidad.ToString
            Dim Domicilio = dict(0).Domicilio.ToString
            Dim Lat = dict(0).Lat.ToString
            Dim Lng = dict(0).Lng.ToString
            Dim Observaciones = dict(0).Observaciones.ToString
            Dim Prioridad = dict(0).Prioridad.ToString
            Dim Estado = dict(0).Estado.ToString


            Dim oobjeto As New Sucursal2

            oobjeto.Modificar(IdSucursal, IdEmpresa, Nombre, Fantasia, IdProvincia, IdLocalidad, Domicilio, Lat, Lng, Observaciones, Prioridad, Estado)

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
    Public Shared Function SucursalesEliminar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of SucursalWS))("[" & cadena & "]")

            Dim IdSucursal = dict(0).IdSucursal.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Sucursal2

            oDs = oobjeto.Eliminar(IdSucursal)

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
    Public Shared Function SucursalesCboEmpresas() As String
        Try
            Dim oDs As New DataSet

            Dim oobjeto As New Sucursal2

            oDs = oobjeto.CboEmpresa
            Dim IdTabla As Integer = 0

            Dim e As SucursalWS() = New SucursalWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New SucursalWS With {
                    .IdEmpresa = oDs.Tables(IdTabla).Rows(i).Item("IdEmpresa").ToString(),
                    .Fantasia = oDs.Tables(IdTabla).Rows(i).Item("Fantasia").ToString()
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
    Public Shared Function ProvinciasBuscarTodo() As String
        Try
            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

            Dim request As HttpWebRequest = TryCast(WebRequest.Create("https://crear.net.ar/api/searchProvincesApi"), HttpWebRequest)
            request.Method = "GET"
            request.ContentType = "application/json"
            ' request.Headers.Add("Authorization: BEARER eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2MTEzMzA0NTgsInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJqb25hdGFuZXplMjMyM0BnbWFpbC5jb20ifQ.13SBgDeyPueRYBfcnk8UE5JDON6ov00_vCx2dvDUxcQLfRCKnU3lnI-kgjOTeOiyRsdMY5HmVFclZ3vJL3crsg")
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim resp As String = reader.ReadToEnd()

            Dim IdTabla As Integer = 0

            Dim json2 As JObject = JObject.Parse(resp)

            Dim e As ProvinciaWS() = New ProvinciaWS(json2("data").Count - 1) {}
            For i = 0 To json2("data").Count - 1
                e(i) = New ProvinciaWS With {
                    .IdProvincia = json2("data").Item(i).Item("Id_Provincia"),
                    .Nombre = json2("data").Item(i).Item("Nombre")
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
    Public Shared Function LocalidadesBuscarPorProvincia(ByVal cadena As String) As String
        Try
            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

            Dim jss As New JavaScriptSerializer()
            jss.MaxJsonLength = 500000000
            Dim dict = jss.Deserialize(Of List(Of ProvinciaWS))("[" & cadena & "]")
            Dim IdProvincia = dict(0).IdProvincia.ToString

            Dim request As HttpWebRequest = TryCast(WebRequest.Create("https://crear.net.ar/api/searchLocationByProvinceId?provinceId=" & IdProvincia), HttpWebRequest)
            request.Method = "GET"
            request.ContentType = "application/json"
            ' request.Headers.Add("Authorization: BEARER eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2MTEzMzA0NTgsInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJqb25hdGFuZXplMjMyM0BnbWFpbC5jb20ifQ.13SBgDeyPueRYBfcnk8UE5JDON6ov00_vCx2dvDUxcQLfRCKnU3lnI-kgjOTeOiyRsdMY5HmVFclZ3vJL3crsg")
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim resp As String = reader.ReadToEnd()

            Dim IdTabla As Integer = 0

            Dim json2 As JObject = JObject.Parse(resp)

            Dim e As LocalidadWS() = New LocalidadWS(json2("data").Count - 1) {}
            For i = 0 To json2("data").Count - 1
                e(i) = New LocalidadWS With {
                    .IdLocalidad = json2("data").Item(i).Item("Id_Localidad"),
                    .Nombre = json2("data").Item(i).Item("Nombre")
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

    Public Shared Function LocalidadBuscarIdProvincia(idLocalidad As String) As Integer
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
        Dim request As HttpWebRequest = TryCast(WebRequest.Create("https://crear.net.ar/api/searchLocationByIdLocation?idLocalidad=" & idLocalidad), HttpWebRequest)
        request.Method = "GET"
        request.ContentType = "application/json"
        Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
        Dim reader As New StreamReader(response.GetResponseStream())
        Dim resp As String = reader.ReadToEnd()
        Dim json2 As JObject = JObject.Parse(resp)
        Dim idProvincia As Integer = json2("data").Item(0).Item("Id_Provincia")
        Return idProvincia
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function SucursalesCambiarEstado(ByVal cadena As String) As String
        Try
            Dim dict = New JavaScriptSerializer().Deserialize(Of List(Of SucursalWS))("[" & cadena & "]")

            Dim IdSucursal = dict(0).IdSucursal.ToString

            Dim oobjeto As New Sucursal2
            oobjeto.CambiarEstado(IdSucursal)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return jsondatos
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
    Public Shared Function LocalidadBuscarNombre(idLocalidad As String) As String
        ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
        Dim request As HttpWebRequest = TryCast(WebRequest.Create("https://crear.net.ar/api/searchLocationByIdLocation?idLocalidad=" & idLocalidad), HttpWebRequest)
        request.Method = "GET"
        request.ContentType = "application/json"
        Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
        Dim reader As New StreamReader(response.GetResponseStream())
        Dim resp As String = reader.ReadToEnd()
        Dim json2 As JObject = JObject.Parse(resp)
        Dim Nombre As String = json2("data").Item(0).Item("Nombre")
        Return Nombre
    End Function
End Class