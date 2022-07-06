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
                    .IdProvincia = oDs.Tables(IdTabla).Rows(i).Item("IdProvincia").ToString(),
                    .IdLocalidad = oDs.Tables(IdTabla).Rows(i).Item("IdLocalidad").ToString(),
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
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of EmpresaWS))("[" & cadena & "]")

            Dim RazonSocial = dict(0).RazonSocial.ToString
            Dim Fantasia = dict(0).Fantasia.ToString
            Dim NroCuit = dict(0).NroCuit.ToString
            Dim IdProvincia = dict(0).IdProvincia.ToString
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


            Dim obj As New Random()
            Dim posibles As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
            Dim longitud As Integer = posibles.Length
            Dim letra As Char
            Dim longitudnuevacadena As Integer = 3
            Dim nuevacadena As String = ""
            For i As Integer = 0 To longitudnuevacadena - 1
                letra = posibles(obj.[Next](longitud))
                nuevacadena += letra.ToString()
            Next

            Dim fecha As String
            fecha = Date.Now.Year.ToString + Date.Now.Month.ToString + Date.Now.Day.ToString + Date.Now.TimeOfDay.TotalMinutes.ToString


            Dim nombre As String
            nombre = fecha & nuevacadena

            Dim rutaServidor As String = "C:\Users\Guille-ASUS\Desktop\TSDS\PP2\Proyecto\CRM_TERCERO\CRM_TERCERO\ImagenesEmpresas\"

            ' Dim rutaServidor As String = "G:\FerozoWebHosting\alladioseguridad.com.ar\public_html\Admin\Frontend\ArchivosCapacitacion\"
            Dim urlBD As String = rutaServidor & nombre & "." & "png"

            ''aca convertir el base 64 a url absoluta
            'Dim fileContents As Byte() = Convert.FromBase64String(Excel.ToString())
            'Dim filename As String = Path.Combine(Path.GetTempPath(), Path.ChangeExtension(Guid.NewGuid().ToString(), ".xlsx"))
            'File.WriteAllBytes(filename, fileContents)


            'ExceltoDT(filename)
            ''aca convertir el base 64 a url absoluta
            Dim fileContents As Byte() = Convert.FromBase64String(Imagen.ToString()),
                        ruta As String = urlBD
            'ruta as String = "G:\FerozoWebHosting\alladioseguridad.com.ar\public_html\Admin\Frontend\PdfPermisos"



            Dim fs As IO.FileStream
            fs = IO.File.Create(ruta)
            fs.Write(fileContents, 0, fileContents.Length)
            fs.Close()



            Dim rutaAbsoluta As String = "/ImagenesEmpresas/" & nombre & "." & "png"




            Dim oobjeto As New Empresa
            oobjeto.Agregar(RazonSocial, Fantasia, NroCuit, IdProvincia, IdLocalidad, Domicilio, Lat, Lng, rutaAbsoluta, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)

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
            Dim IdProvincia = dict(0).IdProvincia.ToString
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

            oobjeto.Modificar(IdEmpresa, RazonSocial, Fantasia, NroCuit, IdProvincia, IdLocalidad, Domicilio, Lat, Lng, Imagen, EmpresaTipo, Observaciones, Prioridad, FechaInicioActividad, Estado)

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
                    .IdProvincia = oDs.Tables(IdTabla).Rows(0).Item("IdProvincia").ToString(),
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
End Class