﻿Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD

Public Class Clientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function ClientesBuscarTodos() As String
        Try
            Dim oDs As New DataSet

            Dim oobjeto As New Clientes

            oDs = oobjeto.BuscarTodos
            Dim IdTabla As Integer = 0

            Dim e As UserWS() = New UserWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New UserWS With {
                    .IdCliente = oDs.Tables(IdTabla).Rows(i).Item("IdCliente").ToString(),
                    .Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString(),
                    .Apellido = oDs.Tables(IdTabla).Rows(i).Item("Apellido").ToString(),
                    .IdPais = oDs.Tables(IdTabla).Rows(i).Item("IdPais").ToString(),
                    .IdProvincia = oDs.Tables(IdTabla).Rows(i).Item("IdProvincia").ToString(),
                    .IdCiudad = oDs.Tables(IdTabla).Rows(i).Item("IdCiudad").ToString(),
                    .Direccion = oDs.Tables(IdTabla).Rows(i).Item("Direccion").ToString(),
                    .CodPostal = oDs.Tables(IdTabla).Rows(i).Item("CodPostal").ToString(),
                    .FechaNacimiento = oDs.Tables(IdTabla).Rows(i).Item("FechaNacimiento").ToString(),
                    .Correo = oDs.Tables(IdTabla).Rows(i).Item("Correo").ToString(),
                    .Telefono = oDs.Tables(IdTabla).Rows(i).Item("Telefono").ToString(),
                    .IdOrganizacion = oDs.Tables(IdTabla).Rows(i).Item("IdOrganizacion").ToString(),
                    .IdCargo = oDs.Tables(IdTabla).Rows(i).Item("IdCargo").ToString(),
                    .FechaIngreso = oDs.Tables(IdTabla).Rows(i).Item("FechaIngreso").ToString(),
                    .IdEstado = oDs.Tables(IdTabla).Rows(i).Item("IdEstado").ToString(),
                
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
    Public Shared Function ClientesAgregar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of UserWS))("[" & cadena & "]")

            Dim Nombre = dict(0).Nombre.ToString
            Dim Apellido = dict(0).Apellido.ToString
            Dim IdPais = dict(0).IdPais.ToString
            Dim IdProvincia = dict(0).IdProvincia.ToString
            Dim IdCiudad = dict(0).IdCiudad.ToString
            Dim Direccion = dict(0).Direccion.ToString
            Dim CodPostal = dict(0).CodPostal.ToString
            Dim FechaNacimiento = dict(0).FechaNacimiento.ToString
            Dim Correo = dict(0).Correo.ToString
            Dim Telefono = dict(0).Telefono.ToString
            Dim IdOrganizacion = dict(0).IdOrganizacion.ToString
            Dim IdCargo = dict(0).IdCargo.ToString
            Dim FechaIngreso = dict(0).FechaIngreso.ToString
            Dim IdEstado = dict(0).IdEstado.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Clientes

            oDs = oobjeto.Agregar(Nombre, Apellido, IdPais, IdProvincia, IdCiudad, Direccion, CodPostal, FechaNacimiento, Correo, Telefono, IdOrganizacion, IdCargo, FechaIngreso, IdEstado)

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
    Public Shared Function ClientesModificar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of UserWS))("[" & cadena & "]")

            Dim IdCliente = dict(0).IdCliente.ToString
            Dim Nombre = dict(0).Nombre.ToString
            Dim Apellido = dict(0).Apellido.ToString
            Dim IdPais = dict(0).IdPais.ToString
            Dim IdProvincia = dict(0).IdProvincia.ToString
            Dim IdCiudad = dict(0).IdCiudad.ToString
            Dim Direccion = dict(0).Direccion.ToString
            Dim CodPostal = dict(0).CodPostal.ToString
            Dim FechaNacimiento = dict(0).FechaNacimiento.ToString
            Dim Correo = dict(0).Correo.ToString
            Dim Telefono = dict(0).Telefono.ToString
            Dim IdOrganizacion = dict(0).IdOrganizacion.ToString
            Dim IdCargo = dict(0).IdCargo.ToString
            Dim FechaIngreso = dict(0).FechaIngreso.ToString
            Dim IdEstado = dict(0).IdEstado.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Clientes

            oDs = oobjeto.Modificar(IdCliente, Nombre, Apellido, IdPais, IdProvincia, IdCiudad, Direccion, CodPostal, FechaNacimiento, Correo, Telefono, IdOrganizacion, IdCargo, FechaIngreso, IdEstado)

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
    Public Shared Function ClientesEliminar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of UserWS))("[" & cadena & "]")

            Dim IdLegajo = dict(0).IdCliente.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Clientes

            oDs = oobjeto.Eliminar(IdCliente)

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