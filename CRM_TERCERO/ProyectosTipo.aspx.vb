Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD


Public Class ProyectosTipo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function ProyectosTipoAgregar(ByVal cadena As String) As String

        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ProyectoTipoWS))("[" & cadena & "]")

            Dim Nombre = dict(0).Nombre.ToString
            Dim Descripcion = dict(0).Descripcion.ToString
            Dim IdEstado = dict(0).IdEstado.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New ProyectoTipo

            oDs = oobjeto.ProyectoTipoAgregar(Nombre, Descripcion, "", IdEstado)

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
    Public Shared Function ProyectosTipoBuscarTodos() As String

        Try

            Dim oDs As New DataSet

            Dim oobjeto As New ProyectoTipo

            oDs = oobjeto.ProyectoTipoBuscarTodos

            'Dim newUser As MembershipUser = Membership.GetUser
            'Dim newUserId As Guid = DirectCast(newUser.ProviderUserKey, Guid)
            Dim IdTabla As Integer = 0



            Dim e As ProyectoTipoWS() = New ProyectoTipoWS(oDs.Tables(IdTabla).Rows.Count - 1) {}



            For i = 0 To oDs.Tables(IdTabla).Rows.Count - 1

                e(i) = New ProyectoTipoWS()
                e(i).IdProyectoTipo = oDs.Tables(IdTabla).Rows(i).Item("IdProyectoTipo").ToString()
                e(i).Nombre = oDs.Tables(IdTabla).Rows(i).Item("Nombre").ToString()
                e(i).Descripcion = oDs.Tables(IdTabla).Rows(i).Item("Descripcion").ToString()
                e(i).IdEstado = oDs.Tables(IdTabla).Rows(i).Item("IdEstado").ToString()


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
    Public Shared Function ProyectosTipoBuscarPorID(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ProyectoTipoWS))("[" & cadena & "]")

            Dim IdProyectoTipo = dict(0).IdProyectoTipo.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New ProyectoTipo

            oDs = oobjeto.ProyectoTipoBuscarPorId(IdProyectoTipo)

            Dim data = New With {
                Key .Status = "200",
                Key .Nombre = oDs.Tables(0).Rows(0).Item("Nombre").ToString(),
                Key .Descripcion = oDs.Tables(0).Rows(0).Item("Descripcion").ToString(),
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
    Public Shared Function ProyectosTipoModificar(ByVal cadena As String) As String

        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ProyectoTipoWS))("[" & cadena & "]")

            Dim IdProyectoTipo = dict(0).IdProyectoTipo.ToString
            Dim Nombre = dict(0).Nombre.ToString
            Dim Descripcion = dict(0).Descripcion.ToString
            Dim IdEstado = dict(0).IdEstado.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New ProyectoTipo


            oDs = oobjeto.ProyectoTipoModificar(IdProyectoTipo, Nombre, Descripcion, "", IdEstado)

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
    Public Shared Function ProyectosTipoEliminar(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ProyectoTipoWS))("[" & cadena & "]")

            Dim IdProyectoTipo = dict(0).IdProyectoTipo.ToString

            Dim oDs As New DataSet

            Dim oobjeto As New ProyectoTipo
            oDs = oobjeto.ProyectoTipoEliminar(IdProyectoTipo)


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
End Class