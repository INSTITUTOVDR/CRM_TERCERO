<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ProyectosTipo.aspx.vb" Inherits="CRM_TERCERO.ProyectosTipo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>CRM PP2</title>

    <link rel="stylesheet" href="assets/css/main/app.css" />
    <link rel="stylesheet" href="assets/css/main/app-dark.css" />
    <link rel="shortcut icon" href="assets/images/logo/favicon.svg" type="image/x-icon" />
    <link rel="shortcut icon" href="assets/images/logo/favicon.png" type="image/png" />

    <link rel="stylesheet" href="assets/css/pages/fontawesome.css" />
    <link rel="stylesheet" href="assets/css/pages/datatables.css" />
    <link rel="stylesheet" href="assets/css/pages/icon.css" />
</head>

<body onload="BuscarTodos2()">
    <form id="form2" runat="server">
        <div id="app">
            <!--Barra Lateral -->
            <div id="sidebar">
                <div class="sidebar-wrapper active">
                    <div class="sidebar-header position-relative">
                        <div class="d-flex justify-content-between align-items-center">
                            <div class="logo">
                                <a href="#">
                                    <img src="assets/images/logo/logo.svg" alt="Logo" srcset="" />
                                </a>
                            </div>
                            <div class="theme-toggle d-flex gap-2  align-items-center mt-2">
                                <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" role="img" class="iconify iconify--system-uicons" width="20" height="20" preserveAspectRatio="xMidYMid meet" viewBox="0 0 21 21">
                                    <g fill="none" fill-rule="evenodd" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round">
                                        <path d="M10.5 14.5c2.219 0 4-1.763 4-3.982a4.003 4.003 0 0 0-4-4.018c-2.219 0-4 1.781-4 4c0 2.219 1.781 4 4 4zM4.136 4.136L5.55 5.55m9.9 9.9l1.414 1.414M1.5 10.5h2m14 0h2M4.135 16.863L5.55 15.45m9.899-9.9l1.414-1.415M10.5 19.5v-2m0-14v-2" opacity=".3"></path>
                                        <g transform="translate(-210 -1)">
                                            <path d="M220.5 2.5v2m6.5.5l-1.5 1.5"></path>
                                            <circle cx="220.5" cy="11.5" r="4"></circle>
                                            <path d="m214 5l1.5 1.5m5 14v-2m6.5-.5l-1.5-1.5M214 18l1.5-1.5m-4-5h2m14 0h2"></path>
                                        </g>
                                    </g></svg>
                                <div class="form-check form-switch fs-6">
                                    <input class="form-check-input  me-0" type="checkbox" id="toggle-dark" />
                                    <label class="form-check-label"></label>
                                </div>
                                <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" aria-hidden="true" role="img" class="iconify iconify--mdi" width="20" height="20" preserveAspectRatio="xMidYMid meet" viewBox="0 0 24 24">
                                    <path fill="currentColor" d="m17.75 4.09l-2.53 1.94l.91 3.06l-2.63-1.81l-2.63 1.81l.91-3.06l-2.53-1.94L12.44 4l1.06-3l1.06 3l3.19.09m3.5 6.91l-1.64 1.25l.59 1.98l-1.7-1.17l-1.7 1.17l.59-1.98L15.75 11l2.06-.05L18.5 9l.69 1.95l2.06.05m-2.28 4.95c.83-.08 1.72 1.1 1.19 1.85c-.32.45-.66.87-1.08 1.27C15.17 23 8.84 23 4.94 19.07c-3.91-3.9-3.91-10.24 0-14.14c.4-.4.82-.76 1.27-1.08c.75-.53 1.93.36 1.85 1.19c-.27 2.86.69 5.83 2.89 8.02a9.96 9.96 0 0 0 8.02 2.89m-1.64 2.02a12.08 12.08 0 0 1-7.8-3.47c-2.17-2.19-3.33-5-3.49-7.82c-2.81 3.14-2.7 7.96.31 10.98c3.02 3.01 7.84 3.12 10.98.31Z"></path></svg>
                            </div>
                            <div class="sidebar-toggler  x">
                                <a href="#" class="sidebar-hide d-xl-none d-block"><i class="bi bi-x bi-middle"></i></a>
                            </div>
                        </div>
                    </div>
                   <div class="sidebar-menu">
                        <ul class="menu">
                            <li class="sidebar-title">Menu</li>
                             
                            <li class="sidebar-item  ">
                                <a href="ContactoTipos.aspx" class='sidebar-link'>
                                    <i class="bi bi-telephone-plus"></i>
                                      <span>Contactos Tipo</span>
                                </a>
                            </li>
                             <li class="sidebar-item  ">
                                <a href="Dashboard.aspx" class='sidebar-link'>
                                    <i class="bi bi-pie-chart-fill"></i>
                                      <span>Dashboard</span>
                                </a>
                            </li>
                             <li class="sidebar-item  ">
                                <a href="Empresas.aspx" class='sidebar-link'>
                                    <i class="bi bi-graph-up-arrow"></i>
                                      <span>Empresas</span>
                                </a>
                            </li>


                            <li class="sidebar-item">
                                <a href="Informaciones.aspx" class='sidebar-link'>
                                     <i class="bi bi-info-circle"></i>
                                    <span>Informaciones</span>

                                </a>
                                </li>
                            <li class="sidebar-item">
                                <a href="Landings.aspx" class='sidebar-link'>
                                     <i class="bi bi-ui-checks"></i>
                                    <span>Landing</span>
                                </a>
                                </li>

                            <li class="sidebar-item  has-sub">
                                <a href="Proyectos.aspx" class='sidebar-link'>
                                     <i class="bi bi-clipboard2-data"></i>
                                    <span>Proyectos</span>

                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="ProyectosTipo.aspx">
                                             <i class="bi bi-clipboard2-check"></i>
                                                <span>Tipos de Proyectos</span>
                                       </a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="Proyectos.aspx">
                                             <i class="bi bi-clipboard2-check"></i>
                                                <span>Proyectos</span>
                                       </a>
                                    </li>
                                    </ul>
                            </li>

                            <li class="sidebar-item  ">
                                <a href="Sucursales.aspx" class='sidebar-link'>
                                    <i class="bi bi-building"></i>
                                      <span>Sucursales</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>

            <div id="main" class='layout-navbar'>
                <header class='mb-3'>
                    <nav class="navbar navbar-expand navbar-light ">
                        <div class="container-fluid">
                            <a href="#" class="burger-btn d-block">
                                <i class="bi bi-justify fs-3"></i>
                            </a>
                            <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                                data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
                                aria-expanded="false" aria-label="Toggle navigation">
                                <span class="navbar-toggler-icon"></span>
                            </button>
                            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                                <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                                    <li class="nav-item dropdown me-1">
                                        <a class="nav-link active dropdown-toggle text-gray-600" href="#" data-bs-toggle="dropdown"
                                            aria-expanded="false">
                                            <i class='bi bi-envelope bi-sub fs-4'></i>
                                        </a>
                                        <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="dropdownMenuButton">
                                            <li>
                                                <h6 class="dropdown-header">Mail</h6>
                                            </li>
                                            <li><a class="dropdown-item" href="#">No new mail</a></li>
                                        </ul>
                                    </li>
                                    <li class="nav-item dropdown me-3">
                                        <a class="nav-link active dropdown-toggle text-gray-600" href="#" data-bs-toggle="dropdown"
                                            aria-expanded="false">
                                            <i class='bi bi-bell bi-sub fs-4'></i>
                                        </a>
                                        <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="dropdownMenuButton">
                                            <li>
                                                <h6 class="dropdown-header">Notificaciones</h6>
                                            </li>
                                            <li><a class="dropdown-item">No notification available</a></li>
                                        </ul>
                                    </li>
                                </ul>
                                <div class="dropdown">
                                    <a href="#" data-bs-toggle="dropdown" aria-expanded="false">
                                        <div class="user-menu d-flex">
                                            <div class="user-name text-end me-3">
                                                <h6 class="mb-0 text-gray-600">Admin</h6>
                                                <p class="mb-0 text-sm text-gray-600">Administrador</p>
                                            </div>
                                            <div class="user-img d-flex align-items-center">
                                                <div class="avatar avatar-md">
                                                    <img src="assets/images/faces/1.jpg" />
                                                </div>
                                            </div>
                                        </div>
                                    </a>
                                    <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="dropdownMenuButton" style="min-width: 11rem;">
                                        <li>
                                            <h6 class="dropdown-header">Hello, John!</h6>
                                        </li>
                                        <li><a class="dropdown-item" href="#"><i class="icon-mid bi bi-person me-2"></i>
                                            Mi Perfil</a></li>
                                        <li><a class="dropdown-item" href="#"><i class="icon-mid bi bi-gear me-2"></i>
                                            Configuración</a></li>
                                        <li><a class="dropdown-item" href="#"><i class="icon-mid bi bi-wallet me-2"></i>
                                            Wallet</a></li>
                                        <li>
                                            <hr class="dropdown-divider" />
                                        </li>
                                       <%-- <li><a class="dropdown-item" href="#"><i
                                            class="icon-mid bi bi-box-arrow-left me-2"></i>Salir</a></li>--%>
                                         <li>
                                                <asp:LoginStatus ID="HeadLoginStatus" runat="server" LogoutAction="Redirect" class='dropdown-item'
                                                LogoutText="<i class='icon-mid bi bi-box-arrow-left me-2'></i>Salir" LogoutPageUrl="~/Landings.aspx" />
                                            </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </nav>
                </header>
                    <div id="main-content">
                    <div class="page-heading">
                        <div class="page-title">
                            <div class="row">
                                <div class="col-12 col-md-6 order-md-1 order-last">
                                    <h3>Tipos de Proyectos</h3>
                                    <p class="text-subtitle text-muted"></p>
                                </div>
                                <div class="col-12 col-md-6 order-md-2 order-first">
                                    <nav aria-label="breadcrumb" class="breadcrumb-header float-start float-lg-end">
                                        <ol class="breadcrumb">
                                            <li class="breadcrumb-item"><a href="#">Inicio</a></li>
                                            <li class="breadcrumb-item active" aria-current="page">Proyectos</li>
                                        </ol>
                                    </nav>
                                </div>
                            </div>
                        </div>
                      

                        <section id="multiple-column-form">
                            <div class="row match-height">
                                <div class="col-12">
                                    <div class="card">
                                        <div class="card-header">
                                            <h4 class="card-title">Agregar tipos de proyectos</h4>
                                        </div>
                                        <div class="card-content">
                                            <div class="card-body">
                                                <div class="form">
                                                    <div class="row">
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="textBox1">Nombre</label>
                                                                <input type="text" id="txtNombre" class="form-control" placeholder="Nombre" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="textBox2">Descripcion</label>
                                                                <input type="text" id="txtDescripcion" class="form-control" placeholder="Descripcion" />
                                                            </div>
                                                        </div>
                                                       
                                                         <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="btnImagen">Imagen</label>
                                                                <input class="form-control" type="file" id="btnImagen" onchange="return validarExt('btnImagen', 'visorImagen','cadena')" accept="image/*" />
                                                            </div>
                                                        </div>
                                                          <div class="col-md-6 col-12">
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div id="visorImagen">
                                                        </div>
                                                     <span style="display: none" id="cadena"></span>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="selectIdEstado">IdEstado</label>
                                                                <fieldset class="form-group">
                                                                    <select class="form-select" id="selectIdEstado">
                                                                        <option value="1">Opción 1</option>
                                                                        <option value="2">Opción 2</option>
                                                                        <option value="3">Opción 3</option>
                                                                    </select>
                                                                </fieldset>
                                                            </div>
                                                        </div>
                                                        <div class="col-12 d-flex justify-content-end">
                                                            <button type="button" class="btn btn-secondary me-1 mb-1">Cancelar</button>
                                                            <button type="button" class="btn btn-primary me-1 mb-1" onclick="agregar()">Enviar</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                       <%-- <!-- Botón mostrar modal -->
                        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#modalEditar">Mostrar Modal(reemplazar por lápiz en la tabla)</button>--%>
                        <!-- Modal Editar-->
                        <div class="modal fade text-left w-100" id="modalEditar" tabindex="-1" role="dialog" aria-labelledby="myModalLabel16" aria-hidden="true">
                            <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable modal-xl" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h4 class="modal-title" id="myModalLabel16">Título Modal</h4>
                                        <button type="button" class="close" data-bs-dismiss="modal" aria-label="Close">
                                            <i data-feather="x"></i>
                                        </button>
                                    </div>
                                     <section id="multiple-column-form">
                            <div class="row match-height">
                                <div class="col-12">
                                    <div class="card">
                                        <div class="card-header">
                                            <h4 class="card-title">Proyectos Tipo</h4>
                                        </div>
                                        <div class="card-content">
                                            <div class="card-body">
                                                <div class="form">
                                                    <div class="row">
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtNombreEdit">Nombre</label>
                                                                <input type="text" id="txtNombreEdit" class="form-control" placeholder="Nombre" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtDescripcionEdit">Descripcion</label>
                                                                <input type="text" id="txtDescripcionEdit" class="form-control" placeholder="Descripcion" />
                                                            </div>
                                                        </div>
                                                       
                                                         <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="btnImagenEdit">Imagen</label>
                                                                <input class="form-control" type="file" id="btnImagenEdit" onchange="return validarExt('btnImagenEdit', 'visorImagenEdit','cadena2')" accept="image/*" />
                                                            </div>
                                                        </div>
                                                          <div class="col-md-6 col-12">
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div id="visorImagenEdit">
                                                            </div>
                                                            <span style="display: none" id="cadena2"></span>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="selectIdEstadoEdit">IdEstado</label>
                                                                <fieldset class="form-group">
                                                                    <select class="form-select" id="selectIdEstadoEdit">
                                                                        <option value="1">Opción 1</option>
                                                                        <option value="2">Opción 2</option>
                                                                        <option value="3">Opción 3</option>
                                                                    </select>
                                                                </fieldset>
                                                            </div>
                                                        </div>
                                                        <div class="col-12 d-flex justify-content-end">
                                                            <button type="button" class="btn btn-secondary me-1 mb-1">Cancelar</button>
                                                            <button type="button" class="btn btn-primary me-1 mb-1" onclick="agregar()">Enviar</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                                </div>
                            </div>
                        </div>

                                     <div class="row" id="divTarjetas" style="cursor:pointer">

                                     </div>
                                   <%-- <table class="table table-hover" id="tablaProyectosTipo" style="display:none">
                                        <thead>
                                            <tr>
                                                <th scope="col">Nombre</th>
                                                <th scope="col">Descripcion</th>
                                                <th scope="col">Imagen</th>
                                                <th scope="col">Estado</th>
                                                <th scope="col">Editar</th>
                                                <th scope="col">Eliminar</th>
                                         </tr>
                                        </thead>
                                        <tbody>
                                         
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </section>--%>

                    </div>

                    <footer>
                        <div class="footer clearfix mb-0 text-muted">
                            <div class="float-start">
                                <p>2022 &copy; ISVDR</p>
                            </div>
                            <div class="float-end">
                                <p>
                                    Fusce vel sapien elit in malesuada semper mi.
                                </p>
                            </div>
                        </div>
                    </footer>
                </div>
            </div>
        </div>
    </form>
    <script src="assets/js/app.js"></script>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script src="assets/js/jquery.dataTables.min.js"></script>
    <script src="assets/js/extensions/datatables.js"></script>

  <script src="Scripts/proyectostipo.js"></script>



</body>
</html>

