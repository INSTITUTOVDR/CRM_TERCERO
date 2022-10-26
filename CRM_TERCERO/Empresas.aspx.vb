Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD
Imports Newtonsoft.Json.Linq

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
                    .IdLocalidad = LocalidadBuscarNombre(oDs.Tables(IdTabla).Rows(i).Item("IdLocalidad").ToString()).ToString(),
                    .Domicilio = oDs.Tables(IdTabla).Rows(i).Item("Domicilio").ToString(),
                    .Lat = oDs.Tables(IdTabla).Rows(i).Item("Lat").ToString(),
                    .Lng = oDs.Tables(IdTabla).Rows(i).Item("Lng").ToString(),
                    .Imagen = oDs.Tables(IdTabla).Rows(i).Item("Imagen").ToString(),
                    .EmpresaTipo = oDs.Tables(IdTabla).Rows(i).Item("EmpresaTipo").ToString(),
                    .Observaciones = oDs.Tables(IdTabla).Rows(i).Item("Observaciones").ToString(),
                    .Prioridad = oDs.Tables(IdTabla).Rows(i).Item("Prioridad").ToString(),
                    .FechaInicioActividad = oDs.Tables(IdTabla).Rows(i).Item("Fecha").ToString(),
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
            'Dim jss As New JavaScriptSerializer()
            Dim dict = New JavaScriptSerializer().Deserialize(Of List(Of EmpresaWS))("[" & cadena & "]")

            Dim ContactoTipos = New List(Of EmpresaContactoTipoWS)
            ContactoTipos = dict(0).FormasContacto

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
            Dim rutaAbsoluta As String = New Img().Guardar("ImagenesEmpresas", Imagen)

            Dim oobjeto = New Empresa()
            'oobjeto.Agregar(dict)
            Dim IdEmpresa = oobjeto.Agregar(RazonSocial, Fantasia, NroCuit, IdLocalidad, Domicilio, Lat, Lng, rutaAbsoluta, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)

            Dim oobjeto2 = New EmpresaContactoTipos
            oobjeto2.Agregar(ContactoTipos, IdEmpresa)

            Dim data = New With {
                Key .Status = "200"
            }


            'Dim serializer = New JavaScriptSerializer()
            'Dim json = New JavaScriptSerializer().Serialize(data)

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return jsondatos
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
            Dim Imagen = dict(0).Imagen
            Dim EmpresaTipo = dict(0).EmpresaTipo.ToString
            Dim Observaciones = dict(0).Observaciones.ToString
            Dim Prioridad = dict(0).Prioridad.ToString
            Dim FechaInicioActividad = dict(0).FechaInicioActividad.ToString
            Dim Estado = dict(0).Estado.ToString
            Dim rutaAbsoluta As String

            'Si se modifica la imagen guarda la nueva, sino busca la ruta absoluta de la que ya tenia
            If Imagen <> Nothing Then
                rutaAbsoluta = New Img().Guardar("ImagenesEmpresas", Imagen.ToString)
            Else
                rutaAbsoluta = New Empresa().BuscarPorId(IdEmpresa).Tables(0).Rows(0).Item("Imagen").ToString()
            End If

            Dim oobjeto As New Empresa

            oobjeto.Modificar(IdEmpresa, RazonSocial, Fantasia, NroCuit, IdLocalidad, Domicilio, Lat, Lng, rutaAbsoluta, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)

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

            Dim oDs As New DataSet, oobjeto As New Empresa
            oDs = oobjeto.BuscarPorId(IdEmpresa)

            Dim IdTabla As Integer = 0

            Dim IdProvincia = LocalidadBuscarIdProvincia(oDs.Tables(IdTabla).Rows(0).Item("IdLocalidad").ToString())
            Dim fecha As Date = oDs.Tables(IdTabla).Rows(0).Item("FechaInicioActividad").ToString()

            Dim data = New With {
                Key .Status = "200",
                Key .IdEmpresa = oDs.Tables(IdTabla).Rows(0).Item("IdEmpresa").ToString(),
                    .RazonSocial = oDs.Tables(IdTabla).Rows(0).Item("RazonSocial").ToString(),
                    .Fantasia = oDs.Tables(IdTabla).Rows(0).Item("Fantasia").ToString(),
                    .NroCuit = oDs.Tables(IdTabla).Rows(0).Item("NroCuit").ToString(),
                    .IdProvincia = IdProvincia.ToString(),
                    .IdLocalidad = oDs.Tables(IdTabla).Rows(0).Item("IdLocalidad").ToString(),
                    .Domicilio = oDs.Tables(IdTabla).Rows(0).Item("Domicilio").ToString(),
                    .Lat = oDs.Tables(IdTabla).Rows(0).Item("Lat").ToString(),
                    .Lng = oDs.Tables(IdTabla).Rows(0).Item("Lng").ToString(),
                    .Imagen = oDs.Tables(IdTabla).Rows(0).Item("Imagen").ToString(),
                    .EmpresaTipo = oDs.Tables(IdTabla).Rows(0).Item("EmpresaTipo").ToString(),
                    .Observaciones = oDs.Tables(IdTabla).Rows(0).Item("Observaciones").ToString(),
                    .Prioridad = oDs.Tables(IdTabla).Rows(0).Item("Prioridad").ToString(),
                    .FechaInicioActividad = fecha.ToShortDateString(),
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
            'Dim Nombre As String = ""
            'Dim IdProvincia As Integer = 0

            Dim json2 As JObject = JObject.Parse(resp)

            'For Each Row In json2("data")
            '    Nombre = Row("Nombre")
            '    IdProvincia = Row("Id_Provincia")

            'Next

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


    Public Shared Function Error401()
        Dim data = New With {
                         Key .Status = "401"
                     }
        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)
        Return New JavaScriptSerializer().Serialize(data)
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

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function ContactoTiposBuscarTodos() As String
        Try
            Dim oDs As New DataSet

            Dim oobjeto As New Contacto_Tipos

            oDs = oobjeto.ContactoTiposBuscarTodos
            Dim IdTabla As Integer = 0

            Dim e As ContactoTiposWS() = New ContactoTiposWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New ContactoTiposWS With {
                    .IdContactoTipo = oDs.Tables(IdTabla).Rows(i).Item("IdContactoTipo").ToString(),
                    .Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString(),
                    .Imagen = oDs.Tables(IdTabla).Rows(i).Item("Imagen").ToString(),
                    .Activo = oDs.Tables(IdTabla).Rows(i).Item("Activo").ToString()
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
    Public Shared Function ContactoTiposBuscarPorId(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ContactoTiposWS))("[" & cadena & "]")

            Dim IdContactoTipo = dict(0).IdContactoTipo.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Contacto_Tipos

            oDs = oobjeto.ContactoTiposBuscarPorId(IdContactoTipo)

            Dim IdTabla As Integer = 0

            Dim data = New With {
                Key .Status = "200",
                Key .IdContactoTipo = oDs.Tables(IdTabla).Rows(0).Item("IdContactoTipo").ToString(),
                    .Nombre = oDs.Tables(IdTabla).Rows(0).Item("Nombre").ToString(),
                    .Imagen = oDs.Tables(IdTabla).Rows(0).Item("Imagen").ToString(),
                    .Activo = oDs.Tables(IdTabla).Rows(0).Item("Activo").ToString()
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
    Public Shared Function EmpresaTiposBuscarTodo() As String
        Try
            Dim e As EmpresaTipoWS() = New EmpresaTipo().BuscarTodos

            Dim data = New With {
                Key .Status = "200",
                Key .Data = e
            }

            Dim jsondatos = New JavaScriptSerializer().Serialize(data)

            Return jsondatos
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function EmpresasCambiarEstado(ByVal cadena As String) As String
        Try
            Dim dict = New JavaScriptSerializer().Deserialize(Of List(Of EmpresaWS))("[" & cadena & "]")

            Dim IdEmpresa = dict(0).IdEmpresa.ToString

            Dim oobjeto As New Empresa
            oobjeto.CambiarEstado(IdEmpresa)

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