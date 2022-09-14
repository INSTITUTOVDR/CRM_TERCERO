<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IndexPrueba.aspx.vb" Inherits="CRM_TERCERO.IndexPrueba" %>

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
<body onload="SucursalLlenarTabla(); SucursalesCboEmpresa(); provinciasLlenarCbo('selectProvincia'); provinciasLlenarCbo('editselectProvincia')" >
    <form id="form1" runat="server">
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
                                <a href="Empresas.aspx" class='sidebar-link'>
                                    <i class="bi bi-graph-up-arrow"></i>
                                      <span>Empresas</span>
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
                                                <h6 class="mb-6 text-gray-600">Arecubia</h6>
                                                <p class="mb-0 text-sm text-gray-600">Administrador</p>
                                            </div>
                                            <div class="user-img d-flex align-items-center">
                                                <div class="avatar avatar-md">
                                                    <img src="assets/images/faces/1.jpg" />
                                                </div>
                                            </div>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </nav>
                </header>

                <div id="main-content">
                    <div class="page-heading">
                        <div class="page-title">
                            <div class="row">
                                <div class="col-12 order-md-1 order-last" align="center">
                                    <h3>ARECUBIA CRM</h3>
                                </div>
                            </div>
                            <div class="row">
                                
                                <div class="col-12 col-md-12 order-md-2 order-first">
                                    <nav aria-label="breadcrumb" class="breadcrumb-header float-start float-lg-end">
                                        <ol class="breadcrumb">
                                            <li class="breadcrumb-item"><a href="#">Inicio</a></li>
                                            <li class="breadcrumb-item active" aria-current="page">Inicio</li>
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
                                            <h4 class="card-title">Sucursales</h4>
                                           <div class="page-heading">
                                               </div>
                                            </div>
    <div class="page-title">
        <div class="row">
            <div class="col-12 col-md-6 order-md-1 order-last">
            </div>
            <div class="col-12 col-md-6 order-md-2 order-first">
                <nav aria-label="breadcrumb" class="breadcrumb-header float-start float-lg-end">
                </nav>
            </div>
        </div>
    </div>

    <!-- Task App Widget Starts -->
    <section class="tasks">
        <div class="row">
            <div class="col-lg-7">
                <div class="card widget-todo">
                    <div class="card-header border-bottom d-flex justify-content-between align-items-center">
                        <h4 class="card-title d-flex">
                            <i class="bx bx-check font-medium-5 pl-25 pr-75"></i>Tasks
                        </h4>
                        <ul class="list-inline d-flex mb-0">
                            <li class="d-flex align-items-center">
                                <i class="bx bx-check-circle font-medium-3 me-50"></i>
                                <div class="dropdown">
                                    <div class="dropdown-toggle me-1" role="button" id="dropdownMenuButton"
                                        data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false">All Task
                                    </div>
                                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                                        <a class="dropdown-item" href="#">Option 1</a>
                                        <a class="dropdown-item" href="#">Option 2</a>
                                        <a class="dropdown-item" href="#">Option 3</a>
                                    </div>
                                </div>
                            </li>
                            <li class="d-flex align-items-center">
                                <i class="bx bx-sort me-50 font-medium-3"></i>
                                <div class="dropdown">
                                    <div class="dropdown-toggle" role="button" id="dropdownMenuButton2"
                                        data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false">All Task
                                    </div>
                                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton2">
                                        <a class="dropdown-item" href="#">Option 1</a>
                                        <a class="dropdown-item" href="#">Option 2</a>
                                        <a class="dropdown-item" href="#">Option 3</a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="card-body px-0 py-1">
                        <ul class="widget-todo-list-wrapper" id="widget-todo-list">
                            <li class="widget-todo-item">
                                <div
                                    class="widget-todo-title-wrapper d-flex justify-content-between align-items-center mb-50">
                                    <div class="widget-todo-title-area d-flex align-items-center">
                                        <i data-feather="list" class="cursor-move"></i>
                                        <div class="checkbox checkbox-shadow">
                                            <input type="checkbox" class="form-check-input" id="checkbox1">
                                            <label for="checkbox1"></label>
                                        </div>
                                        <span class="widget-todo-title ml-50">Add SCSS and JS files if
                                            required</span>
                                    </div>
                                    <div class="widget-todo-item-action d-flex align-items-center">
                                        <div class="badge badge-pill bg-light-success me-1">frontend</div>
                                        <div class="avatar bg-warning">
                                            <img src="assets/images/faces/1.jpg" alt="" srcset="">
                                        </div>
                                        <i class="bx bx-dots-vertical-rounded font-medium-3 cursor-pointer"></i>
                                    </div>
                                </div>
                            </li>
                            <li class="widget-todo-item">
                                <div
                                    class="widget-todo-title-wrapper d-flex justify-content-between align-items-center mb-50">
                                    <div class="widget-todo-title-area d-flex align-items-center">
                                        <i data-feather="list" class="cursor-move"></i>
                                        <div class="checkbox checkbox-shadow">
                                            <input type="checkbox" class="form-check-input" id="checkbox2">
                                            <label for="checkbox2"></label>
                                        </div>
                                        <span class="widget-todo-title ml-50">Check all the changes that you did,
                                            before you commit</span>
                                    </div>
                                    <div class="widget-todo-item-action d-flex align-items-center">
                                        <div class="badge badge-pill bg-light-danger me-1">backend</div>
                                        <div class="avatar bg-warning">
                                            <img src="assets/images/faces/2.jpg" alt="" srcset="">
                                        </div>
                                        <i class="bx bx-dots-vertical-rounded font-medium-3 cursor-pointer"></i>
                                    </div>
                                </div>
                            </li>
                            <li class="widget-todo-item completed">
                                <div
                                    class="widget-todo-title-wrapper d-flex justify-content-between align-items-center mb-50">
                                    <div class="widget-todo-title-area d-flex align-items-center">
                                        <i data-feather="list" class="cursor-move"></i>
                                        <div class="checkbox checkbox-shadow">
                                            <input type="checkbox" class="form-check-input" id="checkbox3" checked>
                                            <label for="checkbox3"></label>
                                        </div>
                                        <span class="widget-todo-title ml-50">Dribble, Behance, UpLabs & Pinterest
                                            Post</span>
                                    </div>
                                    <div class="widget-todo-item-action d-flex align-items-center">
                                        <div class="badge badge-pill bg-light-primary me-1">UI/UX</div>
                                        <div class="avatar bg-rgba-primary m-0 me-50">
                                            <img src="assets/images/faces/3.jpg" alt="" srcset="">
                                        </div>
                                        <i class="bx bx-dots-vertical-rounded font-medium-3 cursor-pointer"></i>
                                    </div>
                                </div>
                            </li>
                            <li class="widget-todo-item">
                                <div
                                    class="widget-todo-title-wrapper d-flex justify-content-between align-items-center mb-50">
                                    <div class="widget-todo-title-area d-flex align-items-center">
                                        <i data-feather="list" class="cursor-move"></i>
                                        <div class="checkbox checkbox-shadow">
                                            <input type="checkbox" class="form-check-input" id="checkbox4">
                                            <label for="checkbox4"></label>
                                        </div>
                                        <span class="widget-todo-title ml-50">Fresh Design Web & Responsive
                                            Miracle</span>
                                    </div>
                                    <div class="widget-todo-item-action d-flex align-items-center">
                                        <div class="badge badge-pill bg-light-info me-1">Design</div>
                                        <div class="avatar bg-warning">
                                            <img src="assets/images/faces/4.jpg" alt="" srcset="">
                                        </div>
                                        <i class="bx bx-dots-vertical-rounded font-medium-3 cursor-pointer"></i>
                                    </div>
                                </div>
                            </li>
                            <li class="widget-todo-item">
                                <div
                                    class="widget-todo-title-wrapper d-flex justify-content-between align-items-center mb-50">
                                    <div class="widget-todo-title-area d-flex align-items-center">
                                        <i data-feather="list" class="cursor-move"></i>
                                        <div class="checkbox checkbox-shadow">
                                            <input type="checkbox" class="form-check-input" id="checkbox5">
                                            <label for="checkbox5"></label>
                                        </div>
                                        <span class="widget-todo-title ml-50">Add Calendar page and source and
                                            credit page in
                                            documentation</span>
                                    </div>
                                    <div class="widget-todo-item-action d-flex align-items-center">
                                        <div class="badge badge-pill bg-light-warning me-1">Javascript</div>
                                        <div class="avatar bg-warning">
                                            <img src="assets/images/faces/5.jpg" alt="" srcset="">
                                        </div>
                                        <i class="bx bx-dots-vertical-rounded font-medium-3 cursor-pointer"></i>
                                    </div>
                                </div>
                            </li>
                            <li class="widget-todo-item">
                                <div
                                    class="widget-todo-title-wrapper d-flex justify-content-between align-items-center mb-50">
                                    <div class="widget-todo-title-area d-flex align-items-center">
                                        <i data-feather="list" class="cursor-move"></i>
                                        <div class="checkbox checkbox-shadow">
                                            <input type="checkbox" class="form-check-input" id="checkbox6">
                                            <label for="checkbox6"></label>
                                        </div>
                                        <span class="widget-todo-title ml-50">Add Angular Starter-kit</span>
                                    </div>
                                    <div class="widget-todo-item-action d-flex align-items-center">
                                        <div class="badge badge-pill bg-light-primary me-1">UI/UX</div>
                                        <div class="avatar bg-warning">
                                            <img src="assets/images/faces/1.jpg" alt="" srcset="">
                                        </div>
                                        <i class="bx bx-dots-vertical-rounded font-medium-3 cursor-pointer"></i>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>
                    <section class="section">
                            <div class="card">
                                <div class="card-header">Información</div>
                                <div class="card-body">
                                    <table class="table table-hover" id="tablaInicio">
                                        <thead>
                                            <tr>
                                                <th scope="col">Razon Social</th>
                                                <th scope="col">Fantasia</th>
                                                <th scope="col">Observaciones</th>
                                                <th scope="col">Prioridad</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </section>
                       
    </form>
    <script src="assets/js/app.js"></script>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script src="assets/js/jquery.dataTables.min.js"></script>
    <script src="assets/js/extensions/datatables.js"></script>

</body>
</html>

