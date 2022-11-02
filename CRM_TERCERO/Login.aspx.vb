Public Class Login
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Dim FText As Label = Login1.FindControl("FailureText")
            FText.Visible = False
        End If
    End Sub


    Private Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate

        If Login1.UserName = "admin" And Login1.Password = "admin" Then
            e.Authenticated = True
        Else
            e.Authenticated = False
        End If
    End Sub

    Private Sub Login1_LoggedIn(sender As Object, e As EventArgs) Handles Login1.LoggedIn
        'Si el usuario está autenticado?
        'Obtiene un string con todos los roles
        ' TOMAR ROLES DE LA BASE DE DATOS
        Dim roles As String = "ADMIN"

        Dim TimeoutLogin As DateTime = DateTime.Now.AddMinutes(Session.Timeout)

        If Login1.RememberMeSet Then
            TimeoutLogin = DateTime.Now.AddYears(100)
        End If

        'Crear un ticket de autenticación
        Dim autTicket As New FormsAuthenticationTicket(1, Login1.UserName, DateTime.Now, TimeoutLogin, False, roles)
        'Encriptar el ticket
        Dim encrTicket As String = FormsAuthentication.Encrypt(autTicket)
        ' Crea una cookie con el ticket encriptado
        Dim autCookie As New HttpCookie("LoginArecubia", encrTicket)
        ' Agrega la cookie a la Response
        Response.Cookies.Add(autCookie)

    End Sub

    Private Sub Login1_LoginError(sender As Object, e As EventArgs) Handles Login1.LoginError
        Login1.FailureText = "Error de Usuario y/o Contraseña"
        Dim FText As Label = Login1.FindControl("FailureText")
        FText.Visible = True
        'FText.CssClass = FText.CssClass.Replace("visually-hidden", "")
    End Sub

End Class