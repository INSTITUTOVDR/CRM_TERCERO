Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD
Imports Newtonsoft.Json.Linq

Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function ProspectosBuscarTodo() As String
        Try
            Dim oDs As New DataSet
            Dim oobjeto As New Lead
            oDs = oobjeto.BuscarTodos
            Dim IdTabla As Integer = 0

            Dim e As LandingWS() = New LandingWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New LandingWS With {
                    .IdLanding = oDs.Tables(IdTabla).Rows(i).Item("IdLanding").ToString(),
                    .Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString(),
                    .Apellido = oDs.Tables(IdTabla).Rows(i).Item("Apellido").ToString(),
                    .Gmail = oDs.Tables(IdTabla).Rows(i).Item("CorreoElectronico").ToString(),
                    .Telefono = oDs.Tables(IdTabla).Rows(i).Item("Telefono").ToString(),
                    .IdCanal = oDs.Tables(IdTabla).Rows(i).Item("Canal").ToString(),
                    .FechaIngreso = oDs.Tables(IdTabla).Rows(i).Item("FechaIngreso").ToString(),
                    .AlgoMas = oDs.Tables(IdTabla).Rows(i).Item("AlgoMas").ToString()
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
    Public Shared Function LeadsPorMes() As String
        Try
            Dim oDs As DataSet = New Lead().BuscarPorMes
            Dim IdTabla As Integer = 0

            Dim e As Lead() = New Lead(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New Lead With {
                    .Mes = oDs.Tables(IdTabla).Rows(i).Item("Mes").ToString(),
                    .Cantidad = oDs.Tables(IdTabla).Rows(i).Item("Cantidad").ToString()
                }
            Next

            Dim data = New With {
                Key .Status = "200",
                Key .Data = e
            }

            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function LeadsPorCanal() As String
        Try
            Dim oDs As DataSet = New Lead().BuscarPorCanal
            Dim listaCanales As New List(Of String)()
            Dim listaCantidades As New List(Of Integer)

            For Each dr As DataRow In oDs.Tables(0).Rows
                listaCanales.Add(dr.Item("Nombre"))
                listaCantidades.Add(dr.Item("Cantidad"))
            Next

            Dim data = New With {
                Key .Status = "200",
                Key .Canales = listaCanales,
                Key .Cantidad = listaCantidades
            }

            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function


    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function LeadsPorCanalPorMes() As String
        Try
            Dim oDs As DataSet = New Lead().BuscarPorCanalPorMes
            Dim listaCanales As New List(Of String)()
            Dim listaMeses As New List(Of String)()
            Dim listaCantidades As New List(Of List(Of Integer))()

            For Each dr As DataRow In oDs.Tables(1).Rows
                listaCanales.Add(dr.Item("Nombre"))
                Dim tempList As New List(Of Integer)()
                Dim Cantidad() As DataRow
                For Each dr2 As DataRow In oDs.Tables(2).Rows
                    Cantidad = oDs.Tables(0).Select("Canal = '" + dr.Item("Nombre") + "' AND NumMes = " + dr2.Item("NumMes").ToString)
                    If Cantidad.Length > 0 Then
                        tempList.Add(Cantidad(0).Item(3))
                    Else
                        tempList.Add(0)
                    End If
                Next
                listaCantidades.Add(tempList)
            Next

            For Each dr As DataRow In oDs.Tables(2).Rows
                listaMeses.Add(dr.Item("Mes"))
            Next


            Dim data = New With {
                Key .Status = "200",
                Key .Canales = listaCanales,
                Key .Meses = listaMeses,
                Key .Cantidad = listaCantidades
            }

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