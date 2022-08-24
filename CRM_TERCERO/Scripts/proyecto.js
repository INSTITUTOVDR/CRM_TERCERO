function llenarTabla() {
    var tabla = $('#tabla1').DataTable();
    tabla.destroy();

    $('#tabla1').DataTable({
        language: {
            url: "//cdn.datatables.net/plug-ins/1.12.1/i18n/es-ES.json"
        }
    });
}

function validar() {
    let nombre = document.getElementById('txtNombre').value
    let descripcion = document.getElementById('txtDescripcion').value
    if (nombre == "" || descripcion == "") {
        alerta();
    } else {
        agregar();
    }
}

function agregar() {
    let nombre = document.getElementById('txtNombre').value
    let descripcion = document.getElementById('txtDescripcion').value
    let idEmpresa = document.getElementById('selectIdEmpresa').value
    let idSucursal = document.getElementById('selectIdSucursal').value
    let idProyectoTipo = document.getElementById('selectIdProyectoTipo').value
    let imagen = document.getElementById('ImagenEmpresa').value



    var cadena = {
        Nombre: nombre,
        Descripcion: descripcion,
        IdEmpresa: idEmpresa,
        IdSucursal: idSucursal,
        IdProyectoTipo: idProyectoTipo,
        Imagen: imagen,
        IdEstado: 1

    };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "Proyectos.aspx/ProyectosAgregar",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {
            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                Swal.fire({
                    title: "OK",
                    html: "Datos agregados correctamente",
                    type: "success",
                    showCancelButton: false,
                    showConfirmButton: true,
                    cancelButtonColor: "#DD6B55",
                    confirmButtonColor: "#DD6B55",
                })

                txtNombre.value = "";
                txtDescripcion.value = "";

                BuscarTodos2();

                


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
function alerta() {
    Swal.fire({
        title: "Error al agregar cliente",
        text: "Complete todos los campos solicitados",
        icon: "error"
    });
}

function ProyectosBuscarTodos() {


    var table = $('#tablaProyectos').DataTable();
    table.destroy();


    //tablaUsuarios Descripcion Rubro Stock Pedidos Disponibles Editar

    $('#tablaProyectos').DataTable({
        pageLength: 10,
        "order": [[3, "desc"]],
        responsive: true,
        //"dom": '<"top">B<"bottom"f>ltip<"clear">',
        // dom: 'Bfrtip',
        dom: 'Blfrtip',

        searching: true,
        paging: true,
        info: true,
        language: {
            url: "//cdn.datatables.net/plug-ins/1.12.1/i18n/es-ES.json"
            //"lengthMenu": "Mostrar MENU registros",
            //"zeroRecords": "<p style='font- family: 'Lato', sans-serif; color:#000; font-weight:bold;'>Espere...</p>",
            //"info": "Registros del START al END de un total de TOTAL registros ",
            //"infoEmpty": "Registros del 0 al 0 de un total de 0 registros",
            //"infoFiltered": "(filtrado de un total de MAX registros)",
            //"sSearch": "Buscar:",
            //"oPaginate": {
            //    "sFirst": "Primero",
            //    "sLast": "Último",
            //    "sNext": "Siguiente",
            //    "sPrevious": "Anterior"
            //},
            //"sProcessing": "Procesando...",
        },
        //para usar los botones   


        ajax: {
            "type": "POST",
            "url": "Proyectos.aspx/ProyectosBuscarTodos",
            "contentType": "application/json; charset=utf-8",
            "dataType": "json",
            "dataSrc": function (data) {

                var json = $.parseJSON(data.d);

                if (json.Data.length > 0) {

                    //Descripcion  Stock  Pedidos  Disponibles  ID_Item
                    var return_data = new Array();
                    for (var i = 0; i < json.Data.length; i++) {
                        return_data.push({
                            'IdProyecto': json.Data[i].IdProyecto,
                            'Nombre': json.Data[i].Nombre,
                            'Descripcion': json.Data[i].Descripcion,
                            'IdEmpresa': json.Data[i].IdEmpresa,
                            'IdSucursal': json.Data[i].IdSucursal,
                            'IdProyectoTipo': json.Data[i].IdProyectoTipo,
                            'Imagen': json.Data[i].Imagen,
                            'IdEstado': json.Data[i].IdEstado

                        })
                    }
                    return return_data;
                } else {

                    Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
                }

            }
        },
        columns: [
            //{ 'data' : 'Estilo'},

            { 'data': 'Nombre' },
            { 'data': 'Descripcion' },
            { 'data': 'IdEmpresa' },
            { 'data': 'IdSucursal' },
            { 'data': 'IdProyectoTipo' },
            { 'data': 'Imagen' },
            { 'data': 'IdEstado' },

            {
                'data': 'IdProyecto',
                orderable: false,
                'render': function (data, type, row) {
                    return '<a onclick="BuscarxID(' + row.IdProyecto + ')" data-bs-toggle="modal" data-bs-target="#modalEditar"><i class="material-icons" role="button">edit</i></a> '

                }
            },
            {
                'data': 'Eliminar',
                orderable: false,

                'render': function (data, type, row) {
                    return '<a onclick="Eliminar(' + row.IdProyecto + ')"><i class="material-icons" role="button">delete</i></a> '

                }
            }



            //{

            //    orderable: false,
            //    'render': function (data, type, row) {
            //        return '<i class="material-icons" style="color:#000;cursor:pointer;font-size:30px;margin-left:35px" onclick="searchUserById('+ row.IdUsuario + ')"  data-toggle="modal" data-target="#full-width-modal_edit" data - backdrop="static" data - keyboard="false" > edit</i > '
            //    }
            //},

            //{
            //    'data': 'Id_Legajo',
            //    orderable: false,
            //    'render': function (data, type, row) {
            //        return '<i class="material-icons" style="color:red;cursor:pointer;font-size:30px;margin-left:35px" onclick="deleteById(' + row.IdUsuario + ')"  data-toggle="modal" data-target="#full-width-modal_delete" data - backdrop="static" data - keyboard="false" > delete</i > '
            //    }
            //},
        ],
        "createdRow": function (row, data, dataIndex) {
            //$(row).css('background-color', '#F39B9B');
            //console.log(row);
            //var tos = data.tos;
            //var temperatura = data.Temperatura;
            //var faltaAire = data.faltaAire;
            //var olfato = data.Olfato;
            //var contacto = data.Contacto;
            //var cefalea = data.Cefalea;

            ////console.log(data.Tos);

            //if (tos == "1" || temperatura > "37.5" || faltaAire == "1" || olfato == "1" || contacto == "1" || cefalea == "1") {
            //    $(row).css('background-color', '#e65858');
            //    $(row).css('color', '#ffffff');
            //}

            //else {
            //    $(row).css('background-color', '#cccccc');
            //    $(row).css('font-family', 'Lato, sans-serif' );
            //    $(row).css('color', 'color:#000');
            //    $(row).css('font-weight', 'bold');
            //}

        }



    });




}

function BuscarxID(IdProyecto) {
    alert(IdProyecto)

    var cadena = {
        IdProyecto: IdProyecto
    };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "Proyectos.aspx/ProyectosBuscarPorID",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {
            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                var nombre = json.Nombre;
                var descripcion = json.Descripcion;


                document.getElementById('txtNombreModificar').value = nombre
                document.getElementById('txtDescripcionModificar').value = descripcion
                document.getElementById('selectIdEmpresaModificar').value = idEmpresa
                document.getElementById('selectIdSucursalModificar').value = idSucursal
                document.getElementById('selectIdProyectoTipoModificar').value = idProyectoTipo
                document.getElementById('txtImagenModificar').value = imagen
                document.getElementById('selectIdEstadoModificar').value = idEstado


                document.getElementById('IdProyecto').innerHTML = IdProyecto

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

function Eliminar(IdProyecto) {

    var cadena = { IdProyecto: IdProyecto };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "Proyectos.aspx/ProyectosEliminar",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {
            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {
                Swal.fire({
                    title: "OK",
                    html: "Datos eliminados correctamente",
                    type: "success",
                    showCancelButton: false,
                    showConfirmButton: true,
                    cancelButtonColor: "#DD6B55",
                    confirmButtonColor: "#DD6B55",
                })

                txtNombre.value = "";
                txtDescripcion.value = "";


                ProyectosBuscarTodos();

            } else {
                Swal.fire({
                    title: "LO SIENTO ALGO SALIO MAL",
                    html: "Verifica los datos ingresados",
                    type: "warning",
                    showCancelButton: false,
                    showConfirmButton: true,
                    cancelButtonColor: "#DD6B55",
                    confirmButtonColor: "#DD6B55",

                })
            }


        }

    });

}

function modificar() {
    let IdProyecto = document.getElementById('IdProyecto').innerHTML
    let nombre = document.getElementById('txtNombreModificar').value
    let descripcion = document.getElementById('txtDescripcionModificar').value
    let idEmpresa = document.getElementById('selectIdEmpresaModificar').value
    let idSucursal = document.getElementById('selectIdSucursalModificar').value
    let idProyectoTipo = document.getElementById('selectIdProyectoTipoModificar').value
    let imagen = document.getElementById('txtImagenModificar').value
    let idEstado = document.getElementById('selectIdEstadoModificar').value


    var cadena = {
        IdProyecto: IdProyecto,
        Nombre: nombre,
        Descripcion: descripcion,
        IdEmpresa: idEmpresa,
        IdSucursal: idSucursal,
        IdProyectoTipo: idProyectoTipo,
        Imagen: imagen,
        IdEstado: idEstado


    };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "Proyectos.aspx/ProyectosModificar",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {
            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                Swal.fire({
                    title: "OK",
                    html: "Datos modificados correctamente",
                    type: "success",
                    showCancelButton: false,
                    showConfirmButton: true,
                    cancelButtonColor: "#DD6B55",
                    confirmButtonColor: "#DD6B55",
                })

                txtNombre.value = "";
                txtDescripcion.value = "";


                ProyectosBuscarTodos();


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

//  function ProyectoLlenarTabla() {
//    var tabla = $('#tablaProyectosTipo').DataTable();
//    tabla.destroy();
//    $('#tablaProyectosTipo').DataTable({
//        language: {
//            url: "//cdn.datatables.net/plug-ins/1.12.1/i18n/es-ES.json"
//        },

//        ajax: {
//             "type": "POST",
//             "url": "ProyectosTipo.aspx/ProyectosBuscarTodos",
//             "contentType": "application/json; charset=utf-8",
//             "dataType": "json",
//             "dataSrc": function (data) {

//                 var json = $.parseJSON(data.d);

//                 if (json.Data.length > 0) {
//                     var return_data = new Array();
//                     for (var i = 0; i < json.Data.length; i++) {
//                         return_data.push({
//                             'IdProyectoTipo': json.Data[i].IdProyectoTipo,
//                             'Nombre': json.Data[i].Nombre,
//                             'Descripcion': json.Data[i].Descripcion,
//                             'IdEmpresa' : json.data[i].IdEmpresa,
//                             'IdSucursal' : json.data[i].IdSucursal,
//                             'Imagen': json.Data[i].Imagen,
//                             'IdEstado': json.Data[i].IdEstado
//                         })
//                     }
//                     return return_data;
//                 } else {
//                     Swal.fire("NO HAY REGISTROS CARGADOS", "Gracias por consultar", "success");
//                 }
//             }
//         },
//        columns: [
//            { 'data': 'Nombre' },
//            { 'data': 'Descripcion' },
//            { 'data': 'IdEmpresa' },
//            { 'data' : 'IdSucursal'},
//            {'data' : 'IdProyetoTipo'},
//            { 'data': 'Imagen' },
//            { 'data': 'IdEstado' },
//            {
//                'data': 'IdProyectoTipo',
//                orderable: false,
//                'render': function (data, type, row) {
//                    return '<a onclick="BuscarxID(' + row.IdProyecto + ')" data-bs-toggle="modal" data-bs-target="#modalEditarProyectoTipo"><i class="material-icons" role="button">edit</i></a> '
//                }
//            },
//            {
//                'data': 'IdProyectoTipo',
//                orderable: false,
//                'render': function (data, type, row) {
//                    return '<a onclick="Eliminar(' + row.IdProyecto + ')"><i class="material-icons" role="button">delete</i></a> '
//                }
//            },
//        ],
//    });

//}


function BuscarTodos2() {


    $.ajax({
        type: "POST",
        url: "Proyectos.aspx/ProyectosBuscarTodos",
        contentType: "application/json; charset=utf-8",
        //data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {
            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                for (var i = 0; i < json.Data.length; i++) {
                    var counter = json.Data[i];

                    const array1 = json.Data;
                    let template = '';
                    array1.forEach(element => {
                        template += `
<div class="col-md-4">
        <div class="card">
            <div class="card-content">
                    <img src="${element.Imagen}" class="card-img-top" style="width:50px; height:50px">
                <div class="card-body">
                            <h4 class="card-title">${element.Nombre}</h4>
                            <p class="card-text">
                               ${element.Descripcion}
                            </p>
                        <div style="display:flex;justify-content:flex-end" >
                        <img src="${element.ImagenPTipo}" style="width:10px; height:10px">
                        </div>
                    <div class="card-footer d-flex justify-content-between">
                        <span>Card Footer</span>
                        <button class="btn btn-light-primary">${element.Sucursal}</button>
                    </div>
                </div>
            </div>
        </div>
 </div>


                                            `

                    });

                    $('#divTarjetas').html(template);


                }

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


function EmpresasBuscarTodos() {
    let lista_empresa = []
    $.ajax({
        type: "POST",
        url: "Proyectos.aspx/EmpresaBuscarTodos",
        contentType: "application/json; charset=utf-8",
        //data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            console.log(json)
            $("#selectIdEmpresa").append('<option value="0" class="form-control">Seleccione</option>');

            for (var i = 0; i < json.Data.length; i++) {
                var datosJson = json.Data[i];
                // searchMotivoEdit(datosJson.Id);
                $("#selectIdEmpresa").append('<option value="' + datosJson.IdEmpresa + '" class="form-control">' + datosJson.RazonSocial + '</option>');
            }
        }

    });



}

function sucursalesBuscarPorIdEmpresa(empresa) {

    document.getElementById("selectIdSucursal").options.length = 0;

    var cadena = {
        IdEmpresa: empresa.value

    };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "Proyectos.aspx/SucursalesBuscarPorIdEmpresa",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {



            var json = $.parseJSON(data.d);
            console.log(json)


            for (var i = 0; i < json.Data.length; i++) {
                var datosJson = json.Data[i];
                // searchMotivoEdit(datosJson.Id);
                $("#selectIdSucursal").append('<option value="' + datosJson.IdSucursal + '" class="form-control">' + datosJson.Nombre + '</option>');
            }
        }
    });



}


function ProyectosTipoBuscarTodos() {

    $.ajax({
        type: "POST",
        url: "Proyectos.aspx/ProyectoTipoBuscarTodos",
        contentType: "application/json; charset=utf-8",
        //data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            console.log(json)
            $("#selectIdProyectoTipo").append('<option value="0" class="form-control">Seleccione</option>');

            for (var i = 0; i < json.Data.length; i++) {
                var datosJson = json.Data[i];
                // searchMotivoEdit(datosJson.Id);
                $("#selectIdProyectoTipo").append('<option value="' + datosJson.IdProyectoTipo + '" class="form-control">' + datosJson.Nombre + '</option>');
            }
        }

    });
}