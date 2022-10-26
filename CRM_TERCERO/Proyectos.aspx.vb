Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD

Public Class Proyectos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function ProyectosAgregar(ByVal cadena As String) As String

        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ProyectoWS))("[" & cadena & "]")

            Dim Nombre = dict(0).Nombre.ToString
            Dim Descripcion = dict(0).Descripcion.ToString
            Dim IdEmpresa = dict(0).IdEmpresa.ToString
            Dim IdSucursal = dict(0).IdSucursal.ToString
            Dim IdProyectoTipo = dict(0).IdProyectoTipo.ToString
            Dim IdEstado = dict(0).IdEstado.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Proyecto
            Dim IdProyecto As Integer
            IdProyecto = oobjeto.ProyectoAgregar(Nombre, Descripcion, IdEmpresa, IdSucursal, IdProyectoTipo, IdEstado)

            oDs = oobjeto.ProyectoEstadoAgregar(IdProyecto, 1)

            'oDs = oobjeto.BuscarTodosSistema

            'Dim newUser As MembershipUser = Membership.GetUser
            'Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)

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
    Public Shared Function ProyectosBuscarTodos() As String

        Try

            Dim oDs As New DataSet

            Dim oobjeto As New Proyecto

            oDs = oobjeto.ProyectoBuscarTodos

            'Dim newUser As MembershipUser = Membership.GetUser
            'Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)
            Dim IdTabla As Integer = 0



            Dim e As ProyectoWS() = New ProyectoWS(oDs.Tables(IdTabla).Rows.Count - 1) {}



            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1

                e(i) = New ProyectoWS()
                e(i).IdProyecto = oDs.Tables(IdTabla).Rows(i).Item("IdProyecto").ToString()
                e(i).Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString()
                e(i).Descripcion = oDs.Tables(IdTabla).Rows(i).Item("Descripcion").ToString()
                e(i).IdEmpresa = oDs.Tables(IdTabla).Rows(i).Item("IdEmpresa").ToString()
                'e(i).Sucursal = oDs.Tables(IdTabla).Rows(i).Item("Sucursal").ToString()
                'e(i).IdSucursal = oDs.Tables(IdTabla).Rows(i).Item("IdSucursal").ToString()
                'e(i).IdProyectoTipo = oDs.Tables(IdTabla).Rows(i).Item("IdProyectoTipo").ToString()
                e(i).Imagen = oDs.Tables(IdTabla).Rows(i).Item("Imagen").ToString()
                'e(i).IdEstado = oDs.Tables(IdTabla).Rows(i).Item("IdEstado").ToString()
                e(i).ImagenPTipo = oDs.Tables(IdTabla).Rows(i).Item("ImagenPTipo").ToString()



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
    Public Shared Function ProyectosBuscarPorID(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ProyectoWS))("[" & cadena & "]")

            Dim IdProyecto = dict(0).IdProyecto.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Proyecto

            oDs = oobjeto.ProyectoBuscarPorId(IdProyecto)

            Dim data = New With {
                Key .Status = "200",
                Key .Nombre = oDs.Tables(0).Rows(0).Item("Nombre").ToString(),
                Key .Descripcion = oDs.Tables(0).Rows(0).Item("Descripcion").ToString(),
                Key .IdEmpresa = oDs.Tables(0).Rows(0).Item("IdEmpresa").ToString(),
                Key .IdSucursal = oDs.Tables(0).Rows(0).Item("IdSucursal").ToString(),
                Key .IdProyectoTipo = oDs.Tables(0).Rows(0).Item("IdProyectoTipo").ToString(),
                Key .IdEstado = oDs.Tables(0).Rows(0).Item("IdEstado").ToString()
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
    Public Shared Function ProyectosModificar(ByVal cadena As String) As String

        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ProyectoWS))("[" & cadena & "]")

            Dim IdProyecto = dict(0).IdProyecto.ToString
            Dim Nombre = dict(0).Nombre.ToString
            Dim Descripcion = dict(0).Descripcion.ToString
            Dim IdEmpresa = dict(0).IdEmpresa.ToString
            Dim IdSucursal = dict(0).IdSucursal.ToString
            Dim IdProyectoTipo = dict(0).IdProyectoTipo.ToString
            Dim IdEstado = dict(0).IdEstado.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Proyecto


            oDs = oobjeto.ProyectoModificar(IdProyecto, Nombre, Descripcion, IdEmpresa, IdSucursal, IdProyectoTipo, "", IdEstado)

            'Dim newUser As MembershipUser = Membership.GetUser
            'Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)
            Dim IdTabla As Integer = 0

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
    Public Shared Function ProyectosEliminar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ProyectoWS))("[" & cadena & "]")

            Dim IdProyecto = dict(0).IdProyecto.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New Proyecto
            oDs = oobjeto.ProyectoEliminar(IdProyecto)


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
    Public Shared Function SucursalesBuscarPorIdEmpresa(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of SucursalWS))("[" & cadena & "]")

            Dim IdEmpresa = dict(0).IdEmpresa.ToString


            Dim oDs As New DataSet

            Dim oobjeto As New Sucursal

            oDs = oobjeto.BuscarPorIdEmpresa(IdEmpresa)
            Dim IdTabla As Integer = 0

            Dim e As SucursalWS() = New SucursalWS(oDs.Tables(IdTabla).Rows.Count - 1) {}

            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1
                e(i) = New SucursalWS With {
                    .IdSucursal = oDs.Tables(IdTabla).Rows(i).Item("IdSucursal").ToString(),
                    .Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString()
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
    Public Shared Function EmpresaBuscarTodos() As String

        Try

            Dim oDs As New DataSet

            Dim oobjeto As New Empresa

            oDs = oobjeto.BuscarTodos

            'Dim newUser As MembershipUser = Membership.GetUser
            'Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)
            Dim IdTabla As Integer = 0



            Dim e As EmpresaWS() = New EmpresaWS(oDs.Tables(IdTabla).Rows.Count - 1) {}



            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1

                e(i) = New EmpresaWS()
                e(i).RazonSocial = oDs.Tables(IdTabla).Rows(i).Item("RazonSocial").ToString()
                e(i).IdEmpresa = oDs.Tables(IdTabla).Rows(i).Item("IdEmpresa").ToString()



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
    Public Shared Function ProyectoTipoBuscarTodos() As String

        Try

            Dim oDs As New DataSet

            Dim oobjeto As New ProyectoTipo

            oDs = oobjeto.ProyectoTipoBuscarTodos

            'Dim newUser As MembershipUser = Membership.GetUser
            'Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)
            Dim IdTabla As Integer = 0



            Dim e As ProyectoWS() = New ProyectoWS(oDs.Tables(IdTabla).Rows.Count - 1) {}



            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1

                e(i) = New ProyectoWS()
                e(i).Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString()
                e(i).IdProyectoTipo = oDs.Tables(IdTabla).Rows(i).Item("IdProyectoTipo").ToString()



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
End Class