<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Empresas.aspx.vb" Inherits="CRM_TERCERO.Empresas" %>

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
<body onload="">
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
                                <a href="index.html" class='sidebar-link'>
                                    <i class="bi bi-grid-fill"></i>
                                    <span>Dashboard</span>
                                </a>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-stack"></i>
                                    <span>Components</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-collection-fill"></i>
                                    <span>Extra Components</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-item has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-grid-1x2-fill"></i>
                                    <span>Layouts</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-title">Forms &amp; Tables</li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-hexagon-fill"></i>
                                    <span>Form Elements</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-item">
                                <a href="form-layout.html" class='sidebar-link'>
                                    <i class="bi bi-file-earmark-medical-fill"></i>
                                    <span>Form Layout</span>
                                </a>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-pen-fill"></i>
                                    <span>Form Editor</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-item">
                                <a href="table.html" class='sidebar-link'>
                                    <i class="bi bi-grid-1x2-fill"></i>
                                    <span>Table</span>
                                </a>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-file-earmark-spreadsheet-fill"></i>
                                    <span>Datatables</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-title">Extra UI</li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-pentagon-fill"></i>
                                    <span>Widgets</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-egg-fill"></i>
                                    <span>Icons</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-bar-chart-fill"></i>
                                    <span>Charts</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-item">
                                <a href="ui-file-uploader.html" class='sidebar-link'>
                                    <i class="bi bi-cloud-arrow-up-fill"></i>
                                    <span>File Uploader</span>
                                </a>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-map-fill"></i>
                                    <span>Maps</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-title">Pages</li>

                            <li class="sidebar-item  ">
                                <a href="application-email.html" class='sidebar-link'>
                                    <i class="bi bi-envelope-fill"></i>
                                    <span>Email Application</span>
                                </a>
                            </li>

                            <li class="sidebar-item  ">
                                <a href="application-chat.html" class='sidebar-link'>
                                    <i class="bi bi-chat-dots-fill"></i>
                                    <span>Chat Application</span>
                                </a>
                            </li>

                            <li class="sidebar-item  ">
                                <a href="application-gallery.html" class='sidebar-link'>
                                    <i class="bi bi-image-fill"></i>
                                    <span>Photo Gallery</span>
                                </a>
                            </li>

                            <li class="sidebar-item  ">
                                <a href="application-checkout.html" class='sidebar-link'>
                                    <i class="bi bi-basket-fill"></i>
                                    <span>Checkout Page</span>
                                </a>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-person-badge-fill"></i>
                                    <span>Authentication</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="sidebar-item  has-sub">
                                <a href="#" class='sidebar-link'>
                                    <i class="bi bi-x-octagon-fill"></i>
                                    <span>Errors</span>
                                </a>
                                <ul class="submenu">
                                    <li class="submenu-item">
                                        <a href="#">Item1</a>
                                    </li>
                                    <li class="submenu-item">
                                        <a href="#">Item2</a>
                                    </li>
                                </ul>
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
                                                <h6 class="mb-0 text-gray-600">John Ducky</h6>
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
                                        <li><a class="dropdown-item" href="#"><i
                                            class="icon-mid bi bi-box-arrow-left me-2"></i>Salir</a></li>
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
                                    <h3>Empresas</h3>
                                    <p class="text-subtitle text-muted">Este es un ejemplo de abm con dos columnas.</p>
                                </div>
                                <div class="col-12 col-md-6 order-md-2 order-first">
                                    <nav aria-label="breadcrumb" class="breadcrumb-header float-start float-lg-end">
                                        <ol class="breadcrumb">
                                            <li class="breadcrumb-item"><a href="#">Inicio</a></li>
                                            <li class="breadcrumb-item active" aria-current="page">Empresas</li>
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
                                            <h4 class="card-title">Agregar Empresa</h4>
                                        </div>
                                        <div class="card-content">
                                            <div class="card-body">
                                                <div class="form">
                                                    <div class="row">
                                                        <div class="col-12">
                                                            <h5 class="card-title text-muted">Información Básica</h5>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtRazonSocial">Razón Social</label>
                                                                <input type="text" id="txtRazonSocial" class="form-control" placeholder="Razón Social" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtFantasia">Fantasia</label>
                                                                <input type="text" id="txtFantasia" class="form-control" placeholder="Fantasia" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtNroCuit">Número de CUIT</label>
                                                                <input type="text" id="txtNroCuit" class="form-control" placeholder="CUIT" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtFechaInicioActividad">Fecha de Inicio de Actividad</label>
                                                                <input type="date" id="txtFechaInicioActividad" class="form-control" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="selectEmpresaTipo">Tipo de Empresa</label>
                                                                <fieldset class="form-group">
                                                                    <select class="form-select" id="selectEmpresaTipo">
                                                                        <option selected="selected" disabled="disabled">Seleccione</option>
                                                                    </select>
                                                                </fieldset>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
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
                                                                <!--Aqui se desplegará el fichero-->
                                                            </div>
                                                            <span style="display: none" id="cadena"></span>
                                                        </div>
                                                        <div class="col-12">
                                                            <hr />
                                                            <h5 class="card-title text-muted mt-2">Información de Contacto</h5>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="selectContactoTipo">Contacto</label>
                                                                <fieldset class="form-group">
                                                                    <select class="form-select" id="selectContactoTipo">
                                                                        <option value="1">Opción 1</option>
                                                                        <option value="2">Opción 2</option>
                                                                        <option value="3">Opción 3</option>
                                                                    </select>
                                                                </fieldset>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group mt-4">
                                                                <a href="#" class="btn icon btn-outline-secondary"><i data-feather="plus"></i></a>
                                                            </div>
                                                        </div>
                                                        <div class="col-12">
                                                            <hr />
                                                            <h5 class="card-title text-muted mt-2">Información Geográfica</h5>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="selectIdProvincia">Provincia</label>
                                                                <fieldset class="form-group">
                                                                    <select class="form-select" id="selectIdProvincia" onchange="localidadesBuscarPorProvincia(this)">
                                                                        <option selected="selected" disabled="disabled">Seleccione una provincia</option>
                                                                    </select>
                                                                </fieldset>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="selectIdLocalidad">Localidad</label>
                                                                <fieldset class="form-group">
                                                                    <select class="form-select" id="selectIdLocalidad" disabled="disabled">
                                                                        <option selected="selected" disabled="disabled">Seleccione una Localidad</option>
                                                                    </select>
                                                                </fieldset>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtDomicilio">Domicilio</label>
                                                                <input type="text" id="txtDomicilio" class="form-control" placeholder="Domicilio" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtLat">Latitud</label>
                                                                <input type="text" id="txtLat" class="form-control" placeholder="Latitud" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtLng">Longitud</label>
                                                                <input type="text" id="txtLng" class="form-control" placeholder="Longitud" />
                                                            </div>
                                                        </div>
                                                        <div class="col-12">
                                                            <hr />
                                                            <h5 class="card-title text-muted mt-2">Otra Información</h5>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="selectEstado">Estado</label>
                                                                <fieldset class="form-group">
                                                                    <select class="form-select" id="selectEstado">
                                                                        <option selected="selected" disabled="disabled">Seleccione</option>
                                                                        <option value="1">Habilitado</option>
                                                                        <option value="0">Deshabilitado</option>
                                                                    </select>
                                                                </fieldset>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-group">
                                                                <label for="txtPrioridad">Prioridad</label>
                                                                <input type="text" id="txtPrioridad" class="form-control" placeholder="Prioridad" />
                                                            </div>
                                                        </div>
                                                        <div class="col-md-6 col-12">
                                                            <div class="form-floating">
                                                                <textarea class="form-control" placeholder="Observaciones" id="txtObservaciones"></textarea>
                                                                <label for="txtObservaciones">Observaciones</label>
                                                            </div>
                                                        </div>
                                                        <div class="col-12 d-flex justify-content-end">
                                                            <button type="button" class="btn btn-secondary me-1 mb-1">Cancelar</button>
                                                            <button type="button" class="btn btn-primary me-1 mb-1" onclick="empresaAgregar()">Enviar</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>
                        <!-- Modal Editar-->
                        <div class="modal fade text-left w-100" id="modalEditarEmpresa" tabindex="-1" role="dialog" aria-labelledby="myModalLabel16" aria-hidden="true">
                            <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable modal-xl" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h4 class="modal-title" id="myModalLabel16">Título Modal</h4>
                                        <button type="button" class="close" data-bs-dismiss="modal" aria-label="Close">
                                            <i data-feather="x"></i>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <div class="form">
                                            <div class="row">
                                                <div class="col-12">
                                                    <h5 class="card-title text-muted">Información Básica</h5>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <input type="text" id="txtEditEmpresa" hidden="hidden" />
                                                        <label for="txtEditRazonSocial">Razón Social</label>
                                                        <input type="text" id="txtEditRazonSocial" class="form-control" placeholder="Razón Social" />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="txtEditFantasia">Fantasia</label>
                                                        <input type="text" id="txtEditFantasia" class="form-control" placeholder="Fantasia" />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="txtEditNroCuit">Número de CUIT</label>
                                                        <input type="text" id="txtEditNroCuit" class="form-control" placeholder="CUIT" />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="txtEditFechaInicioActividad">Fecha de Inicio de Actividad</label>
                                                        <input type="date" id="txtEditFechaInicioActividad" class="form-control" />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="selectEditEmpresaTipo">Tipo de Empresa</label>
                                                        <fieldset class="form-group">
                                                            <select class="form-select" id="selectEditEmpresaTipo">
                                                                <option selected="selected" disabled="disabled">Seleccione</option>
                                                            </select>
                                                        </fieldset>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12"></div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="btnEditImagen">Imagen</label>
                                                        <input class="form-control" type="file" id="btnEditImagen" onchange="return validarExt('btnEditImagen','visorEditImagen','cadena2')" accept="image/*" />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12"></div>
                                                <div class="col-md-6 col-12">
                                                    <div id="visorEditImagen">
                                                        <!-- Imagen acá -->
                                                    </div>
                                                    <span style="display: none" id="cadena2"></span>
                                                </div>
                                                <div class="col-12">
                                                    <hr />
                                                    <h5 class="card-title text-muted mt-2">Información de Contacto</h5>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="selectEditContactoTipo">Contacto</label>
                                                        <fieldset class="form-group">
                                                            <select class="form-select" id="selectEditContactoTipo">
                                                                <option value="1">Opción 1</option>
                                                                <option value="2">Opción 2</option>
                                                                <option value="3">Opción 3</option>
                                                            </select>
                                                        </fieldset>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group mt-4">
                                                        <a href="#" class="btn icon btn-outline-secondary"><i data-feather="plus"></i></a>
                                                    </div>
                                                </div>
                                                <div class="col-12">
                                                    <hr />
                                                    <h5 class="card-title text-muted mt-2">Información Geográfica</h5>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="selectEditIdProvincia">Provincia</label>
                                                        <fieldset class="form-group">
                                                            <select class="form-select" id="selectEditIdProvincia" onchange="localidadesBuscarPorProvinciaEdit(this,0)">
                                                                <option selected="selected" disabled="disabled">Seleccione una provincia</option>
                                                            </select>
                                                        </fieldset>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="selectEditIdLocalidad">Localidad</label>
                                                        <fieldset class="form-group">
                                                            <select class="form-select" id="selectEditIdLocalidad">
                                                            </select>
                                                        </fieldset>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="txtEditDomicilio">Domicilio</label>
                                                        <input type="text" id="txtEditDomicilio" class="form-control" placeholder="Domicilio" />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="txtEditLat">Latitud</label>
                                                        <input type="text" id="txtEditLat" class="form-control" placeholder="Latitud" />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="txtEditLng">Longitud</label>
                                                        <input type="text" id="txtEditLng" class="form-control" placeholder="Longitud" />
                                                    </div>
                                                </div>
                                                <div class="col-12">
                                                    <hr />
                                                    <h5 class="card-title text-muted mt-2">Otra Información</h5>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="selectEditEstado">Estado</label>
                                                        <fieldset class="form-group">
                                                            <select class="form-select" id="selectEditEstado">
                                                                <option selected="selected" disabled="disabled">Seleccione</option>
                                                                <option value="1">Habilitado</option>
                                                                <option value="0">Deshabilitado</option>
                                                            </select>
                                                        </fieldset>
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-group">
                                                        <label for="txtEditPrioridad">Prioridad</label>
                                                        <input type="text" id="txtEditPrioridad" class="form-control" placeholder="Prioridad" />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-12">
                                                    <div class="form-floating">
                                                        <textarea class="form-control" placeholder="Observaciones" id="txtEditObservaciones"></textarea>
                                                        <label for="txtEditObservaciones">Observaciones</label>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <input type="text" id="txtEditIdEmpresa" hidden="hidden" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">
                                            <i class="bx bx-x d-block d-sm-none"></i>
                                            <span class="d-none d-sm-block">Cancelar</span>
                                        </button>
                                        <button type="button" class="btn btn-primary ml-1" data-bs-dismiss="modal">
                                            <i class="bx bx-check d-block d-sm-none"></i>
                                            <span class="d-none d-sm-block" onclick="empresaModificar()">Modificar</span>
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!--Tabla -->
                        <section class="section">
                            <div class="card">
                                <div class="card-header">Simple Datatable</div>
                                <div class="card-body">
                                    <table class="table table-hover" id="tablaEmpresas">
                                        <thead>
                                            <tr>
                                                <th scope="col">Razon Social</th>
                                                <th scope="col">Fantasia</th>
                                                <th scope="col">CUIT</th>
                                                <th scope="col">Localidad</th>
                                                <th scope="col">Domicilio</th>
                                                <th scope="col">Tipo</th>
                                                <th scope="col">Observaciones</th>
                                                <th scope="col">Prioridad</th>
                                                <th scope="col">Fecha de Inicio de Actividad</th>
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
                        </section>

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

    <script>
        $(document).ready(function () {
            llenarTabla();
            provinciasLlenarCbo('selectIdProvincia');
            provinciasLlenarCbo('selectEditIdProvincia');
            empresaTiposLlenarCbo('selectEmpresaTipo');
            empresaTiposLlenarCbo('selectEditEmpresaTipo');
        });

        function validarCampos() {
            let listaValoresInputs = generarListaDeInputs("txtRazonSocial", "txtFantasia", "txtNroCuit", "selectIdLocalidad", "txtDomicilio", "txtLat", "txtLng", "txtImagen", "selectEmpresaTipo", "txtObservaciones", "txtPrioridad", "txtFechaInicioActividad")

            let esValido = true

            for (var i = 0; i < listaValoresInputs.length; i++) {
                let input = listaValoresInputs[i]
                if (input.value == "") {
                    input.classList.add("is-invalid");
                    esValido = false;
                    alertaError();
                } else {
                    input.classList.remove("is-invalid");
                }
            }

            esValido ? empresaAgregar() : alertaError();
        }

        function validarCamposEdit() {
            let listaValoresInputs = generarListaDeInputs("txtEditRazonSocial", "txtEditFantasia", "txtEditNroCuit", "selectIdLocalidad", "txtEditDomicilio", "txtEditLat", "txtEditLng", "txtEditImagen", "selectEmpresaTipo", "txtEditObservaciones", "txtEditPrioridad", "txtEditFechaInicioActividad")
            let esValido = true

            for (var i = 0; i < listaValoresInputs.length; i++) {
                let input = listaValoresInputs[i]
                if (input.value == "") {
                    input.classList.add("is-invalid");
                    esValido = false;
                    alertaError();
                } else {
                    input.classList.remove("is-invalid");
                }
            }

            esValido ? empresaModificar() : alertaError();
        }

        function empresaModificar() {

            var archivoInput = document.getElementById('btnEditImagen');
            var archivoRuta = archivoInput.value;

            let cadena = document.getElementById("cadena2").innerHTML;

            if (cadena.includes("data:image/png;base64,")) {
                var res = cadena.split("data:image/png;base64,");
                var cadenaFinalImagen = res[1];
            } else if (cadena.includes("data:image/jpg;base64,")) {
                var res = cadena.split("data:image/jpg;base64,");
                var cadenaFinalImagen = res[1];
            } else if (cadena.includes("data:image/jpeg;base64,")) {
                var res = cadena.split("data:image/jpeg;base64,");
                var cadenaFinalImagen = res[1];
            }

            let IdEmpresa = document.getElementById('txtEditIdEmpresa').value
            let RazonSocial = document.getElementById('txtEditRazonSocial').value
            let Fantasia = document.getElementById('txtEditFantasia').value
            let NroCuit = document.getElementById('txtEditNroCuit').value
            let IdLocalidad = document.getElementById('selectEditIdLocalidad').value
            let Domicilio = document.getElementById('txtEditDomicilio').value
            let Lat = document.getElementById('txtEditLat').value
            let Lng = document.getElementById('txtEditLng').value
            let Imagen = document.getElementById('btnEditImagen').value
            let EmpresaTipo = document.getElementById('selectEditEmpresaTipo').value
            let Observaciones = document.getElementById('txtEditObservaciones').value
            let Prioridad = document.getElementById('txtEditPrioridad').value
            let FechaInicioActividad = document.getElementById('txtEditFechaInicioActividad').value
            let Estado = document.getElementById('selectEditEstado').value

            var cadenaJson = {
                IdEmpresa: IdEmpresa,
                RazonSocial: RazonSocial,
                Fantasia: Fantasia,
                NroCuit: NroCuit,
                IdLocalidad: IdLocalidad,
                Domicilio: Domicilio,
                Lat: Lat,
                Lng: Lng,
                Imagen: cadenaFinalImagen,
                EmpresaTipo: EmpresaTipo,
                Observaciones: Observaciones,
                Prioridad: Prioridad,
                FechaInicioActividad: FechaInicioActividad,
                Estado: Estado
            }

            var payload = {
                cadena: JSON.stringify(cadenaJson)
            };

            $.ajax({
                type: "POST",
                url: "Empresas.aspx/EmpresasModificar",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(payload),
                dataType: "json",
                success: function (data) {
                    var json = $.parseJSON(data.d);
                    var status = json.Status;

                    if (status == 200) {
                        Swal.fire({
                            title: "Éxito",
                            html: "Datos modificados correctamente",
                            icon: "success"
                        });
                        //txtLimpiar("txtRazonSocial", "txtFantasia", "txtNroCuit", "selectIdLocalidad", "txtDomicilio", "txtLat", "txtLng", "txtImagen", "selectEmpresaTipo", "txtObservaciones", "txtPrioridad", "txtFechaInicioActividad");
                        llenarTabla();
                    } else {
                        Swal.fire({
                            title: "LO SIENTO ALGO SALIO MAL",
                            text: "Verifica los datos ingresados",
                            icon: "error"
                        });
                    }
                }
            });
        }

        function empresaBuscarPorIdModal(id) {
            Swal.fire({
                title: 'Por favor espere',
                text: "Cargando...",
                html: `<img src="assets/images/svg-loaders/oval.svg" class="me-4" style="width: 3rem" alt="audio">`,
                allowOutsideClick: false,
                showConfirmButton: false,
            });


            let IdEmpresa = document.getElementById('txtEditIdEmpresa')
            IdEmpresa.value = id
            let RazonSocial = document.getElementById('txtEditRazonSocial')
            let Fantasia = document.getElementById('txtEditFantasia')
            let NroCuit = document.getElementById('txtEditNroCuit')
            let IdProvincia = document.getElementById('selectEditIdProvincia')
            let IdLocalidad = document.getElementById('selectEditIdLocalidad')
            let Domicilio = document.getElementById('txtEditDomicilio')
            let Lat = document.getElementById('txtEditLat')
            let Lng = document.getElementById('txtEditLng')
            let Imagen = document.getElementById('visorEditImagen')
            let EmpresaTipo = document.getElementById('selectEditEmpresaTipo')
            let Observaciones = document.getElementById('txtEditObservaciones')
            let Prioridad = document.getElementById('txtEditPrioridad')
            let FechaInicioActividad = document.getElementById('txtEditFechaInicioActividad')
            let Estado = document.getElementById('selectEditEstado')

            var cadena = {
                IdEmpresa: id
            }
            var payload = {
                cadena: JSON.stringify(cadena)
            }

            $.ajax({
                type: "POST",
                url: "Empresas.aspx/EmpresasBuscarPorId",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(payload),
                dataType: "json",
                success: function (data) {
                    var json = $.parseJSON(data.d);
                    var status = json.Status;
                    if (status == 200) {
                        //IdEmpresa.value = json.IdEmpresa
                        RazonSocial.value = json.RazonSocial
                        Fantasia.value = json.Fantasia
                        NroCuit.value = json.NroCuit
                        IdProvincia.value = json.IdProvincia
                        localidadesBuscarPorProvinciaEdit(IdProvincia, json.IdLocalidad)
                        //IdLocalidad.value = json.IdLocalidad
                        Domicilio.value = json.Domicilio
                        Lat.value = json.Lat
                        Lng.value = json.Lng
                        Imagen.innerHTML = ""
                        Imagen.innerHTML += '<img src="' + json.Imagen + '" width="200" alt="Imagen de la Empresa"/>';
                        // Imagen.src = json.Imagen
                        EmpresaTipo.value = json.EmpresaTipo
                        Observaciones.value = json.Observaciones
                        Prioridad.value = json.Prioridad
                        FechaInicioActividad.value = new Date((json.FechaInicioActividad).split("/").reverse().join("-")).toISOString().split('T')[0]
                        Estado.value = json.Estado
                        $('#modalEditarEmpresa').modal('show')
                    } else {
                        Swal.fire({
                            title: "LO SIENTO ALGO SALIO MAL",
                            html: "Verifica los datos ingresados",
                            type: "warning",
                            showCancelButton: false,
                            showConfirmButton: true,
                            cancelButtonColor: "#DD6B55",
                            confirmButtonColor: "#DD6B55",
                        });
                    }
                }
            });
        }

        function llenarTabla() {

            var tabla = $('#tablaEmpresas').DataTable();
            tabla.destroy();

            $('#tablaEmpresas').DataTable({
                language: {
                    url: "//cdn.datatables.net/plug-ins/1.12.1/i18n/es-ES.json"
                },

                ajax: {
                    "type": "POST",
                    "url": "Empresas.aspx/EmpresasBuscarTodo",
                    "contentType": "application/json; charset=utf-8",
                    "dataType": "json",
                    "dataSrc": function (data) {
                        var json = $.parseJSON(data.d);

                        if (json.Data.length > 0) {
                            var return_data = new Array();
                            for (var i = 0; i < json.Data.length; i++) {
                                return_data.push({
                                    'IdEmpresa': json.Data[i].IdEmpresa,
                                    'RazonSocial': json.Data[i].RazonSocial,
                                    'Fantasia': json.Data[i].Fantasia,
                                    'NroCuit': json.Data[i].NroCuit,
                                    'IdLocalidad': json.Data[i].IdLocalidad,
                                    'Domicilio': json.Data[i].Domicilio,
                                    'Lat': json.Data[i].Lat,
                                    'Lng': json.Data[i].Lng,
                                    'Imagen': json.Data[i].Imagen,
                                    'EmpresaTipo': json.Data[i].EmpresaTipo,
                                    'Observaciones': json.Data[i].Observaciones,
                                    'Prioridad': json.Data[i].Prioridad,
                                    'FechaInicioActividad': json.Data[i].FechaInicioActividad,
                                    'Estado': json.Data[i].Estado
                                })
                            }
                            return return_data;
                        } else {
                            Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                        }
                    }
                },
                columns: [
                    { 'data': 'RazonSocial' },
                    { 'data': 'Fantasia' },
                    { 'data': 'NroCuit' },
                    { 'data': 'IdLocalidad' },
                    { 'data': 'Domicilio' },
                    { 'data': 'EmpresaTipo' },
                    { 'data': 'Observaciones' },
                    { 'data': 'Prioridad' },
                    { 'data': 'FechaInicioActividad' },
                    { 'data': 'Estado' },
                    {
                        'data': 'IdEmpresa', orderable: false,
                        'render': function (data, type, row) {
                            return '<a onclick="empresaBuscarPorIdModal(' + row.IdEmpresa + ')"><i class="material-icons" role="button">edit</i></a>'
                        }
                    },
                    {
                        'data': 'IdCliente', orderable: false,
                        'render': function (data, type, row) {
                            return '<a onclick="clienteEliminar(' + row.IdEmpresa + ')"><i class="material-icons" role="button">delete</i></a> '
                        }
                    },
                ],
            });
        }

        function validarExt(imagen, visorImagen, cadenaImagen) {
            var archivoInput = document.getElementById(imagen);
            var archivoRuta = archivoInput.value;
            document.getElementById(visorImagen).innerHTML = ""

            var extPermitidas = /(.png|.jpg|.jpeg)$/i;
            if (!extPermitidas.exec(archivoRuta)) {
                Swal.fire({
                    title: "LO SIENTO ALGO SALIO MAL",
                    text: "Verifica el archivo ingresado",
                    icon: "error"
                });
                archivoInput.value = '';
                return false;
            } else {
                if (archivoInput.files.length) {
                    for (let i = 0; i < archivoInput.files.length; i++) {
                        let visor = new FileReader();
                        visor.onload = function (e) {
                            document.getElementById(visorImagen).innerHTML +=
                                '<embed src="' + e.target.result + '" width="200"/>';
                            // console.log(e.target.result);
                            let cadena = document.getElementById(cadenaImagen);
                            cadena.innerHTML = "";
                            cadena.innerHTML = e.target.result;
                        };
                        visor.readAsDataURL(archivoInput.files[i]);
                    }
                }
                /// document.getElementById("nombreArchivo2").style = "display:none;margin-left:-100px";
                //document.getElementById("nombreArchivo2").innerHTML = archivoRuta;
            }
        }

        //reemplaza a la función "empresaAgregar"
        function empresaAgregar() {

            var archivoInput = document.getElementById('btnImagen');
            var archivoRuta = archivoInput.value;

            let cadena = document.getElementById("cadena").innerHTML;

            if (cadena.includes("data:image/png;base64,")) {
                var res = cadena.split("data:image/png;base64,");
                var cadenaFinalImagen = res[1];
            } else if (cadena.includes("data:image/jpg;base64,")) {
                var res = cadena.split("data:image/jpg;base64,");
                var cadenaFinalImagen = res[1];
            } else if (cadena.includes("data:image/jpeg;base64,")) {
                var res = cadena.split("data:image/jpeg;base64,");
                var cadenaFinalImagen = res[1];
            }

            //Swal.fire({
            //    title: "Espere...",
            //    html: "<br><img src='https://crear.net.ar/CLIENTES/loader.gif'>",
            //    type: "warning",
            //    showCancelButton: false,
            //    showConfirmButton: false,
            //    cancelButtonColor: "#DD6B55",
            //    confirmButtonColor: "#DD6B55",
            //    didOpen: () => {
            //        Swal.showLoading()
            //    }
            //});

            Swal.fire({
                title: 'Por favor espere',
                text: "Cargando...",
                html: `<img src="assets/images/svg-loaders/oval.svg" class="me-4" style="width: 3rem" alt="audio">`,
                allowOutsideClick: false,
                showConfirmButton: false,
            });

            let RazonSocial = document.getElementById('txtRazonSocial').value
            let Fantasia = document.getElementById('txtFantasia').value
            let NroCuit = document.getElementById('txtNroCuit').value
            let IdLocalidad = document.getElementById('selectIdLocalidad').value
            let Domicilio = document.getElementById('txtDomicilio').value
            let Lat = document.getElementById('txtLat').value
            let Lng = document.getElementById('txtLng').value
            let Imagen = document.getElementById('btnImagen').value
            let EmpresaTipo = document.getElementById('selectEmpresaTipo').value
            let Observaciones = document.getElementById('txtObservaciones').value
            let Prioridad = document.getElementById('txtPrioridad').value
            let FechaInicioActividad = document.getElementById('txtFechaInicioActividad').value
            let Estado = document.getElementById('selectEstado').value

            var cadenaJson = {
                RazonSocial: RazonSocial,
                Fantasia: Fantasia,
                NroCuit: NroCuit,
                IdLocalidad: IdLocalidad,
                Domicilio: Domicilio,
                Lat: Lat,
                Lng: Lng,
                Imagen: cadenaFinalImagen,
                EmpresaTipo: EmpresaTipo,
                Observaciones: Observaciones,
                Prioridad: Prioridad,
                FechaInicioActividad: FechaInicioActividad,
                Estado: Estado
            }

            let jsonPush = { cadena: JSON.stringify(cadenaJson) };

            $.ajax({
                type: "POST",
                url: "Empresas.aspx/EmpresasAgregar",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(jsonPush),
                dataType: "json",
                success: function (data) {
                    swal.close();
                    var json = $.parseJSON(data.d);

                    var status = json.Status;
                    if (status == 200) {
                        Swal.fire({
                            title: "Éxito",
                            html: "Datos agregados correctamente",
                            icon: "success"
                        });
                        llenarTabla();
                        txtLimpiar("txtRazonSocial", "txtFantasia", "txtNroCuit", "selectIdProvincia", "selectIdLocalidad", "txtDomicilio", "txtLat", "txtLng", "txtImagen", "selectEmpresaTipo", "txtObservaciones", "txtPrioridad", "txtFechaInicioActividad");
                    } else {
                        Swal.fire({
                            title: "LO SIENTO ALGO SALIO MAL",
                            text: "Verifica los datos ingresados",
                            icon: "error"
                        });
                    }
                }
            });
        }

        function provinciasLlenarCbo(idSelect) {
            $.ajax({
                type: "POST",
                url: "Empresas.aspx/ProvinciasBuscarTodo",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    var json = $.parseJSON(data.d);
                    if (json.Data.length > 0) {
                        var lista_de_provincias = json.Data
                        const select = document.getElementById(idSelect);
                        for (let provincia of lista_de_provincias) {
                            let nuevaOpcion = document.createElement("option");
                            nuevaOpcion.value = provincia.IdProvincia;
                            nuevaOpcion.text = provincia.Nombre;
                            select.add(nuevaOpcion);
                            // select.appendChild(nuevaOpcion); <-- Así tambien funciona
                        }
                    } else {
                        Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                    }
                }
            });
        }

        function localidadesBuscarPorProvincia(selectProvincia) {
            let idProvincia = selectProvincia.value
            document.getElementById("selectIdLocalidad").options.length = 0;
            document.getElementById("selectIdLocalidad").disabled = false
            var cadena = {
                idProvincia: idProvincia
            }
            var payload = {
                cadena: JSON.stringify(cadena)
            }

            Swal.fire({
                title: 'Por favor espere',
                text: "Cargando...",
                html: `<img src="assets/images/svg-loaders/oval.svg" class="me-4" style="width: 3rem" alt="audio">`,
                allowOutsideClick: false,
                showConfirmButton: false,
            });

            $.ajax({
                type: "POST",
                url: "Empresas.aspx/LocalidadesBuscarPorProvincia",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(payload),
                dataType: "json",
                success: function (data) {
                    swal.close();
                    var json = $.parseJSON(data.d);
                    if (json.Data.length > 0) {
                        var lista_de_localidades = json.Data
                        const select = document.getElementById('selectIdLocalidad');
                        let primeraOpcion = document.createElement("option");
                        primeraOpcion.text = "Seleccione una localidad"
                        primeraOpcion.selected = "selected"
                        primeraOpcion.disabled = "disabled"
                        select.add(primeraOpcion)
                        for (let localidad of lista_de_localidades) {
                            let nuevaOpcion = document.createElement("option");
                            nuevaOpcion.value = localidad.IdLocalidad;
                            nuevaOpcion.text = localidad.Nombre;
                            select.add(nuevaOpcion);
                            // select.appendChild(nuevaOpcion); <-- Así tambien funciona
                        }
                    } else {
                        Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                    }
                }
            });
        }

        function localidadesBuscarPorProvinciaEdit(selectProvincia, idLocalidad) {
            let idProvincia = selectProvincia.value
            document.getElementById("selectEditIdLocalidad").options.length = 0;
            document.getElementById("selectEditIdLocalidad").disabled = false
            var cadena = {
                idProvincia: idProvincia
            }
            var payload = {
                cadena: JSON.stringify(cadena)
            }

            Swal.fire({
                title: 'Por favor espere',
                text: "Cargando...",
                html: `<img src="assets/images/svg-loaders/oval.svg" class="me-4" style="width: 3rem" alt="audio">`,
                allowOutsideClick: false,
                showConfirmButton: false,
            });

            $.ajax({
                type: "POST",
                url: "Empresas.aspx/LocalidadesBuscarPorProvincia",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(payload),
                dataType: "json",
                success: function (data) {
                    swal.close();
                    var json = $.parseJSON(data.d);
                    if (json.Data.length > 0) {
                        var lista_de_localidades = json.Data
                        let select = document.getElementById('selectEditIdLocalidad');
                        let primeraOpcion = document.createElement("option");
                        primeraOpcion.text = "Seleccione una localidad"
                        primeraOpcion.selected = "selected"
                        primeraOpcion.disabled = "disabled"
                        select.add(primeraOpcion)
                        for (let localidad of lista_de_localidades) {
                            let nuevaOpcion = document.createElement("option");
                            nuevaOpcion.value = localidad.IdLocalidad;
                            nuevaOpcion.text = localidad.Nombre;
                            select.add(nuevaOpcion);
                            // select.appendChild(nuevaOpcion); <-- Así tambien funciona
                        }
                        if (idLocalidad != 0) {
                            select.value = idLocalidad
                        }

                    } else {
                        Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                    }
                }
            });
        }

        //recibe el id de los inputs y devuelve un array de los elementos
        function generarListaDeInputs() {
            const listaId = []
            for (let i = 0; i < arguments.length; i++) {
                const id = arguments[i];
                listaId.push(document.getElementById(id));
            }
            return listaId
        }

        function alertaError() {
            Swal.fire({
                title: "Error al agregar cliente",
                text: "Complete todos los campos solicitados",
                icon: "error"
            });
        }

        function txtLimpiar() {
            for (let i = 0; i < arguments.length; i++) {
                const element = arguments[i];
                document.getElementById(element).value = null
            }
        }

        function empresaTiposLlenarCbo(idSelect) {
            $.ajax({
                type: "POST",
                url: "Empresas.aspx/EmpresaTiposBuscarTodo",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    var json = $.parseJSON(data.d);
                    if (json.Data.length > 0) {
                        var lista_empresa_tipos = json.Data
                        const select = document.getElementById(idSelect);
                        for(let tipo of lista_empresa_tipos) {
                            if (tipo.Activo){
                                let nuevaOpcion = document.createElement("option");
                                nuevaOpcion.value = tipo.IdEmpresaTipo;
                                nuevaOpcion.text = tipo.Nombre;
                                select.add(nuevaOpcion);
                                // select.appendChild(nuevaOpcion); <-- Así tambien funciona
                            }
                        }
                    } else {
                        Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                    }
                }
            });
        }
    </script>
</body>
</html>


