<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="CRM_TERCERO.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Login - Arecubia</title>
    <link rel="stylesheet" href="assets/css/main/app.css" />
    <link rel="stylesheet" href="assets/css/pages/auth.css" />
    <link rel="shortcut icon" href="assets/images/logo/favicon.svg" type="image/x-icon" />
    <link rel="shortcut icon" href="assets/images/logo/favicon.png" type="image/png" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="auth">
            <div class="row h-100">
                <div class="col-lg-5 col-12">
                    <div id="auth-left">
                        <div class="auth-logo">
                            <a href="Landings.aspx">
                                <img src="assets/images/logo/logo.svg" alt="Logo"/></a>
                        </div>
                        <h1 class="auth-title">Log in.</h1>
                        <%--<p class="auth-subtitle mb-5">Log in with your data that you entered during registration.</p>--%>
                        <asp:Login ID="Login1" runat="server">
                            <LayoutTemplate>
                        <%--<form action="index.html">--%>
                            <div class="form-group position-relative has-icon-left mb-4">
                                <asp:TextBox ID="UserName" runat="server" type="text" class="form-control form-control-xl" placeholder="Usuario"/>
                                <div class="form-control-icon">
                                    <i class="bi bi-person"></i>
                                </div>
                            </div>
                            <div class="form-group position-relative has-icon-left mb-4">
                                <asp:Textbox ID="Password" runat="server" type="password" class="form-control form-control-xl" placeholder="Contraseña"/>
                                <div class="form-control-icon">
                                    <i class="bi bi-shield-lock"></i>
                                </div>
                            </div>
                            <div class="form-check form-check-lg d-flex align-items-end">
                                <input id="RememberMe" runat="server" class="form-check-input me-2" type="checkbox" value="" />
                                <label class="form-check-label text-gray-600" for="flexCheckDefault">
                                     Mantenerme conectado
                                </label>
                            </div>
                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log in" class="btn btn-primary btn-block btn-lg shadow-lg mt-5"/>
                            </LayoutTemplate>
                        </asp:Login>
                       <%-- </form>--%>
                       <%-- <div class="text-center mt-5 text-lg fs-4">
                            <p class="text-gray-600">
                                Don't have an account? <a href="auth-register.html" class="font-bold">Sign up</a>.
                            </p>
                            <p><a class="font-bold" href="auth-forgot-password.html">Forgot password?</a>.</p>
                        </div>--%>
                    </div>
                </div>
                <div class="col-lg-7 d-none d-lg-block">
                    <div id="auth-right">
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
