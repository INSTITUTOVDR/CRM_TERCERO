Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD
Imports Newtonsoft.Json.Linq

Imports System.Net.Mail
Imports RestSharp



Public Class Landing
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function LandingsAgregar(ByVal cadena As String) As String

        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of LandingWS))("[" & cadena & "]")

            Dim Nombre = dict(0).Nombre.ToString
            Dim Apellido = dict(0).Apellido.ToString
            Dim CorreoElectronico = dict(0).Gmail.ToString
            Dim Telefono = dict(0).Telefono.ToString
            Dim IdCanal = dict(0).IdCanal.ToString
            Dim FechaIngreso As Date = Date.Now
            Dim AlgoMas = dict(0).AlgoMas.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New LandingClass

            oobjeto.LandingAgregar(Nombre, Apellido, CorreoElectronico, Telefono, IdCanal, FechaIngreso, AlgoMas)
            Dim name As String = Nombre & " " & Apellido
            SendEmailByApi(name, CorreoElectronico)


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

    Public Shared Function SendEmailByApi(name As String, email As String) As String

        Try

            '{"email": "jonataneze2323@gmail.com", "token": "12345hdfdfgg"}


            If name <> "" And email <> "" Then

                System.Net.ServicePointManager.SecurityProtocol = 3072

                Dim client = New RestClient("https://crear.net.ar/dev/emailISVDR")
                client.Timeout = -1
                Dim request = New RestRequest(Method.POST)
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded")
                request.AddParameter("email", email)
                request.AddParameter("name", name)
                request.AddParameter("emails", "algarra.pablo98@gmail.com, pablocugat.vdr@gmail.com, lucaspdia@gmail.com")
                Dim response As IRestResponse = client.Execute(request)
                Console.WriteLine(response.Content)

                Dim respuesta As String = response.Content

                Dim jsonString = respuesta
                Dim json2 As JObject = JObject.Parse(jsonString)
                Dim status = json2("data").First.First
                If status = "200" Then
                    Dim data = New With {
                  Key .Status = 200
                  }

                    Dim serializer = New JavaScriptSerializer()
                    serializer.MaxJsonLength = 500000000
                    Dim json = serializer.Serialize(data)

                    Return json
                Else
                    Return Error401()

                End If




            End If

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