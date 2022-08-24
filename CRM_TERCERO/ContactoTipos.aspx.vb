﻿Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD
Public Class ContactoTipos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

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
    Public Shared Function ContactoTiposAgregar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ContactoTiposWS))("[" & cadena & "]")

            Dim Nombre = dict(0).Nombre.ToString
            Dim Imagen = dict(0).Imagen.ToString
            Dim Activo = dict(0).Activo.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Contacto_Tipos

            oDs = oobjeto.ContactoTiposAgregar(Nombre, Imagen, Activo)

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
    Public Shared Function ContactoTiposModificar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ContactoTiposWS))("[" & cadena & "]")

            Dim IdContactoTipo = dict(0).IdContactoTipo.ToString
            Dim Nombre = dict(0).Nombre.ToString
            Dim Imagen = dict(0).Imagen.ToString
            Dim Activo = dict(0).Activo.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Contacto_Tipos

            oDs = oobjeto.ContactoTiposModificar(IdContactoTipo, Nombre, Imagen, Activo)

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
    Public Shared Function ContactoTiposEliminar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ContactoTiposWS))("[" & cadena & "]")

            Dim IdContactoTipo = dict(0).IdContactoTipo.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Contacto_Tipos

            oDs = oobjeto.ContactoTiposEliminar(IdContactoTipo)

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
End Class