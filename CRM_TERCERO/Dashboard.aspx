<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dashboard.aspx.vb" Inherits="CRM_TERCERO.Dashboard" %>

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
        <link rel="stylesheet" href="assets/css/shared/iconly.css">
    </head>

    <body>
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
                                    <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink"
                                        aria-hidden="true" role="img" class="iconify iconify--system-uicons" width="20"
                                        height="20" preserveAspectRatio="xMidYMid meet" viewBox="0 0 21 21">
                                        <g fill="none" fill-rule="evenodd" stroke="currentColor" stroke-linecap="round"
                                            stroke-linejoin="round">
                                            <path
                                                d="M10.5 14.5c2.219 0 4-1.763 4-3.982a4.003 4.003 0 0 0-4-4.018c-2.219 0-4 1.781-4 4c0 2.219 1.781 4 4 4zM4.136 4.136L5.55 5.55m9.9 9.9l1.414 1.414M1.5 10.5h2m14 0h2M4.135 16.863L5.55 15.45m9.899-9.9l1.414-1.415M10.5 19.5v-2m0-14v-2"
                                                opacity=".3"></path>
                                            <g transform="translate(-210 -1)">
                                                <path d="M220.5 2.5v2m6.5.5l-1.5 1.5"></path>
                                                <circle cx="220.5" cy="11.5" r="4"></circle>
                                                <path
                                                    d="m214 5l1.5 1.5m5 14v-2m6.5-.5l-1.5-1.5M214 18l1.5-1.5m-4-5h2m14 0h2">
                                                </path>
                                            </g>
                                        </g>
                                    </svg>
                                    <div class="form-check form-switch fs-6">
                                        <input class="form-check-input  me-0" type="checkbox" id="toggle-dark" />
                                        <label class="form-check-label"></label>
                                    </div>
                                    <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink"
                                        aria-hidden="true" role="img" class="iconify iconify--mdi" width="20"
                                        height="20" preserveAspectRatio="xMidYMid meet" viewBox="0 0 24 24">
                                        <path fill="currentColor"
                                            d="m17.75 4.09l-2.53 1.94l.91 3.06l-2.63-1.81l-2.63 1.81l.91-3.06l-2.53-1.94L12.44 4l1.06-3l1.06 3l3.19.09m3.5 6.91l-1.64 1.25l.59 1.98l-1.7-1.17l-1.7 1.17l.59-1.98L15.75 11l2.06-.05L18.5 9l.69 1.95l2.06.05m-2.28 4.95c.83-.08 1.72 1.1 1.19 1.85c-.32.45-.66.87-1.08 1.27C15.17 23 8.84 23 4.94 19.07c-3.91-3.9-3.91-10.24 0-14.14c.4-.4.82-.76 1.27-1.08c.75-.53 1.93.36 1.85 1.19c-.27 2.86.69 5.83 2.89 8.02a9.96 9.96 0 0 0 8.02 2.89m-1.64 2.02a12.08 12.08 0 0 1-7.8-3.47c-2.17-2.19-3.33-5-3.49-7.82c-2.81 3.14-2.7 7.96.31 10.98c3.02 3.01 7.84 3.12 10.98.31Z">
                                        </path>
                                    </svg>
                                </div>
                                <div class="sidebar-toggler  x">
                                    <a href="#" class="sidebar-hide d-xl-none d-block"><i
                                            class="bi bi-x bi-middle"></i></a>
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
                                            <a class="nav-link active dropdown-toggle text-gray-600" href="#"
                                                data-bs-toggle="dropdown" aria-expanded="false">
                                                <i class='bi bi-envelope bi-sub fs-4'></i>
                                            </a>
                                            <ul class="dropdown-menu dropdown-menu-end"
                                                aria-labelledby="dropdownMenuButton">
                                                <li>
                                                    <h6 class="dropdown-header">Mail</h6>
                                                </li>
                                                <li><a class="dropdown-item" href="#">No new mail</a></li>
                                            </ul>
                                        </li>
                                        <li class="nav-item dropdown me-3">
                                            <a class="nav-link active dropdown-toggle text-gray-600" href="#"
                                                data-bs-toggle="dropdown" aria-expanded="false">
                                                <i class='bi bi-bell bi-sub fs-4'></i>
                                            </a>
                                            <ul class="dropdown-menu dropdown-menu-end"
                                                aria-labelledby="dropdownMenuButton">
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
                                        <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="dropdownMenuButton"
                                            style="min-width: 11rem;">
                                            <li>
                                                <h6 class="dropdown-header">Hello, John!</h6>
                                            </li>
                                            <li><a class="dropdown-item" href="#"><i
                                                        class="icon-mid bi bi-person me-2"></i>
                                                    Mi Perfil</a></li>
                                            <li><a class="dropdown-item" href="#"><i
                                                        class="icon-mid bi bi-gear me-2"></i>
                                                    Configuración</a></li>
                                            <li><a class="dropdown-item" href="#"><i
                                                        class="icon-mid bi bi-wallet me-2"></i>
                                                    Wallet</a></li>
                                            <li>
                                                <hr class="dropdown-divider" />
                                            </li>
                                            <%--<li><a class="dropdown-item" href="#"><i class="icon-mid bi bi-box-arrow-left me-2"></i>Salir</a></li>--%>
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
                            <!-- Tíitulo de la páagina}} -->
                            <div class="page-title">
                                <div class="row">
                                    <div class="col-12 col-md-6 order-md-1 order-last">
                                        <h3>Dashboard</h3>
                                        <!-- <p class="text-subtitle text-muted">Este es un ejemplo de abm con dos columnas.</p> -->
                                    </div>
                                    <div class="col-12 col-md-6 order-md-2 order-first">
                                        <nav aria-label="breadcrumb" class="breadcrumb-header float-start float-lg-end">
                                            <ol class="breadcrumb">
                                                <li class="breadcrumb-item"><a href="#">Inicio</a></li>
                                                <li class="breadcrumb-item active" aria-current="page">Dashboard</li>
                                            </ol>
                                        </nav>
                                    </div>
                                </div>
                            </div>
                            <!-- Contenido -->
                            <div class="row">
                                <div class="col-12 col-xs-6 col-sm-6 col-md-6 col-lg-3">
                                    <div class="card">
                                      <div class="card-body px-4 py-4-5">
                                        <div class="row">
                                          <div class="col-6 d-flex justify-content-start">
                                            <div class="stats-icon blue mb-2">
                                              <i class="iconly-boldProfile"></i>
                                            </div>
                                          </div>
                                        <div class="col-6">
                                        <h6 class="text-muted font-semibold">Leads</h6>
                                        <h6 class="font-extrabold mb-0" id="leads-number">0</h6>
                                        </div>
                                    </div>
                                    </div>
                                </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="card">
                                        <div class="card-header">
                                            <h4>Prospectos Por Mes</h4>
                                        </div>
                                        <div class="card-body">
                                            <div id="line"></div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="card">
                                        <div class="card-header">
                                            <h4>Prospectos Por Canal</h4>
                                        </div>
                                        <div class="card-body">
                                            <div id="donut"></div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="card">
                                        <div class="card-header">
                                            <h4>Prospectos Por Canal Por Mes</h4>
                                        </div>
                                        <div class="card-body">
                                            <div id="bar"></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
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
        <script src="https://cdn.jsdelivr.net/npm/apexcharts"></script>
        <script>
            $(document).ready(function () {
                grafico1()
                grafico2()
                grafico3()
            });


            function grafico1() {

                $.ajax({
                    "type": "POST",
                    "url": "Dashboard.aspx/LeadsPorMes",
                    "contentType": "application/json; charset=utf-8",
                    "dataType": "json",
                    success: function (data) {
                        var json = $.parseJSON(data.d);
                        console.log(json)
                        if (json.Data.length > 0) {
                            let meses = new Array();
                            let cantidad_leads = new Array();
                            let total_leads = 0;
                            for (var i = 0; i < json.Data.length; i++) {
                                meses.push(json.Data[i].Mes)
                                //console.log(json.Data[i].Mes)
                                cantidad_leads.push(json.Data[i].Cantidad)
                                total_leads += json.Data[i].Cantidad
                            }
                            document.getElementById("leads-number").textContent = total_leads;
                            var options = {
                                series: [{
                                    name: "Leads",
                                    //cantidad por mes
                                    data: cantidad_leads//[10, 41, 35, 51, 49, 62, 69, 91, 148]
                                }],
                                chart: {
                                    height: 350,
                                    type: 'line',
                                    zoom: {
                                        enabled: true
                                    }
                                },
                                dataLabels: {
                                    enabled: false
                                },
                                stroke: {
                                    curve: 'straight'
                                },
                                title: {
                                    text: '',
                                    align: 'left'
                                },
                                grid: {
                                    // row: {
                                    //     colors: ['#f3f3f3', 'transparent'], // takes an array which will be repeated on columns
                                    //     opacity: 0.5
                                    // },
                                },
                                xaxis: {
                                    categories: meses // ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep'],
                                }
                            };

                            var chart = new ApexCharts(document.querySelector("#line"), options);
                            chart.render();

                        } else {
                            Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                        }
                    }
                });

            }

            function grafico2() {
                $.ajax({
                    "type": "POST",
                    "url": "Dashboard.aspx/LeadsPorCanal",
                    "contentType": "application/json; charset=utf-8",
                    "dataType": "json",
                    success: function (data) {
                        var json = $.parseJSON(data.d);
                        if (json.Status.length > 0) {

                            var options = {
                                series: json.Cantidad,
                                labels: json.Canales,
                                chart: {
                                    height: 365,
                                    type: 'donut',
                                    toolbar: {
                                        show: true,
                                        tools: {
                                        download: true}
                                    }
                                }
                            };
                            var chart = new ApexCharts(document.querySelector("#donut"), options);
                            chart.render();

                        } else {
                            Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                        }
                    }
                });
            }

            function grafico3() {

                $.ajax({
                    "type": "POST",
                    "url": "Dashboard.aspx/LeadsPorCanalPorMes",
                    "contentType": "application/json; charset=utf-8",
                    "dataType": "json",
                    success: function (data) {
                        var json = $.parseJSON(data.d);
                        console.log(json)
                        if (json.Status.length > 0) {

                            console.log(json.Canales)

                            var options = {
                                series: [],
                                // [{
                                // name: 'Facebook',
                                // data: [44, 55, 41, 37, 22, 43, 21]
                                // }, {
                                // name: 'Correo',
                                // data: [53, 32, 33, 52, 13, 43, 32]
                                // }, {
                                // name: 'Referidos',
                                // data: [12, 17, 11, 9, 15, 11, 20]
                                // }, {
                                // name: 'Instagram',
                                // data: [9, 7, 5, 8, 6, 9, 4]
                                // }, {
                                // name: 'Publicidad',
                                // data: [25, 12, 19, 32, 25, 24, 10]
                                // }],
                                chart: {
                                    type: 'bar',
                                    height: 350,
                                    stacked: true,
                                    stackType: '100%'
                                },
                                plotOptions: {
                                    bar: {
                                        horizontal: true,
                                    },
                                },
                                stroke: {
                                    width: 1,
                                    colors: ['#fff']
                                },
                                title: {
                                    text: ''
                                },
                                xaxis: '',
                                //  {
                                //     categories: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep'],
                                // },
                                tooltip: {
                                    y: {
                                        formatter: function (val) {
                                            return val + " Leads"
                                        }
                                    }
                                },
                                fill: {
                                    opacity: 1

                                },
                                legend: {
                                    position: 'top',
                                    horizontalAlign: 'left',
                                    offsetX: 40
                                }
                            };

                            for (let i = 0; i < json.Canales.length; i++) {
                                var serie = { name: json.Canales[i], data: json.Cantidad[i] }
                                options.series.push(serie)
                            }
                            options.xaxis = { categories: json.Meses }

                            json.Canales.forEach(canal => {

                            });

                            var chart = new ApexCharts(document.querySelector("#bar"), options);
                            chart.render();

                        } else {
                            Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                        }
                    }
                });

            }

       </script>
    </body>
    </html>