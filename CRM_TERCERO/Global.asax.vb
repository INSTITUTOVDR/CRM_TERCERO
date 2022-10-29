Imports System.Security.Principal
Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la aplicación
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la sesión
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al comienzo de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso

        ' Recupera la cookie
        Dim authCookie As HttpCookie = Context.Request.Cookies("LoginArecubia")
        If authCookie Is Nothing Then
            ' Si no existe termina
            Return
        End If
        Dim autTicket As FormsAuthenticationTicket = Nothing
        Try
            autTicket = FormsAuthentication.Decrypt(authCookie.Value)
        Catch ex As Exception
            Return
        End Try
        If autTicket Is Nothing Then
            ' No se pudo desencriptar
            Return
        End If

        ' Separo los roles
        Dim roles As [String]() = autTicket.UserData.Split(New Char() {";"c})
        ' Creo un objeto Identity y lo vinculo al Context
        Dim id As New GenericIdentity(autTicket.Name, "LoginArecubia")
        Dim principal As New GenericPrincipal(id, roles)
        Context.User = principal
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se produce un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la sesión
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la aplicación
    End Sub

End Class