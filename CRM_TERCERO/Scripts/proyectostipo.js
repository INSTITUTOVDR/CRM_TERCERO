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
    let imagen = document.getElementById('btnImagen').value
    let idEstado = document.getElementById('selectIdEstado').value


    var cadena = {
        Nombre: nombre,
        Descripcion: descripcion,
        Imagen: imagen,
        IdEstado: idEstado

    };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "ProyectosTipo.aspx/ProyectosTipoAgregar",
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

                ProyectosTipoBuscarTodos();


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

function ProyectosTipoBuscarTodos() {



    var table = $('#tablaProyectosTipo').DataTable();
    table.destroy();


    //tablaUsuarios Descripcion Rubro Stock Pedidos Disponibles Editar

    $('#tablaProyectosTipo').DataTable({
        language: {
            url: "//cdn.datatables.net/plug-ins/1.12.1/i18n/es-ES.json"
        },
        //para usar los botones   


        ajax: {
            "type": "POST",
            "url": "ProyectosTipo.aspx/ProyectosTipoBuscarTodos",
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
            { 'data': 'Imagen' },
            { 'data': 'IdEstado' },

            {
                'data': 'IdProyectoTipo',
                orderable: false,
                'render': function (data, type, row) {

                    //return '<a onclick="ProyectosTipoBuscarPorIdModal(' + row.IdProyectoTipo + ')" data-bs-toggle="modal" data-bs-target="#modalEditarProyectoTipo"><i class="material-icons" role="button">edit</i></a> '
                    return '<a onclick="BuscarxID(' + row.IdProyectoTipo + ')" data-bs-toggle="modal" data-bs-target="#modalEditar"><i class="material-icons" role="button">edit</i></a> '
                },
            },
            {
                'data': 'Eliminar',
                orderable: false,

                'render': function (data, type, row) {
                    //return '<a onclick="ProyectosTipoEliminar(' + row.IdProyectoTipo + ')"><i class="material-icons" role="button">delete</i></a> '
                    return '<a onclick="Eliminar(' + row.IdProyectoTipo + ')"><i class="material-icons" role="button">delete</i></a> '
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

function BuscarxID(IdProyectoTipo) {
    alert(IdProyectoTipo)

    var cadena = {
        IdProyectoTipo: IdProyectoTipo
    };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "ProyectosTipo.aspx/ProyectosTipoBuscarPorId",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {
            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                var nombre = json.Nombre;
                var descripcion = json.Descripcion;
                var imagen = json.Imagen;
                var idEstado = json.IdEstado;


                document.getElementById('txtNombreModificar').value = nombre
                document.getElementById('txtDescripcionModificar').value = descripcion
                document.getElementById('txtImagenModificar').value = imagen
                document.getElementById('selectIdEstadoModificar').value = idEstado


                document.getElementById('IdProyectoTipo').innerHTML = IdProyecto

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

function Eliminar(IdProyectoTipo) {

    var cadena = { IdProyectoTipo: IdProyectoTipo };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "ProyectosTipo.aspx/ProyectosTipoEliminar",
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


                ProyectosTipoBuscarTodos();


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
    let imagen = document.getElementById('txtImagenModificar').value
    let idEstado = document.getElementById('selectIdEstadoModificar').value


    var cadena = {
        IdProyecto: IdProyecto,
        Nombre: nombre,
        Descripcion: descripcion,
        Imagen: imagen,
        IdEstado: idEstado


    };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "ProyectosTipo.aspx/ProyectosTipoModificar",
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


                ProyectosTipoBuscarTodos();


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


function BuscarTodos2() {


    $.ajax({
        type: "POST",
        url: "ProyectosTipo.aspx/ProyectosTipoBuscarTodos",
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
                        <div class="card-body">
                            <h4 class="card-title">${element.Nombre}</h4>
                            <p class="card-text">
                               ${element.Descripcion}
                            </p>
                        </div>
                        <img class="img-fluid w-100" src="${element.Imagen}"  style="height:150px !important" alt="Card image cap">
                    </div>
                    <div class="card-footer d-flex justify-content-between">
                        <span>Card Footer</span>
                        <button class="btn btn-light-primary">${element.IdEstado}</button>
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
        url: "ProyectosTipo.aspx/EmpresaBuscarTodos",
        contentType: "application/json; charset=utf-8",
        //data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            console.log(json)
            $("#selectIdEmpresa").append('<option value="0" class="form-control" style="font-family: Lato, sans-serif;font-weight:bold;text-transform: uppercase;">Seleccione</option>');

            for (var i = 0; i < json.Data.length; i++) {
                var datosJson = json.Data[i];
                // searchMotivoEdit(datosJson.Id);
                $("#selectIdEmpresa").append('<option value="' + datosJson.IdEmpresa + '" class="form-control" style="font-family: Lato, sans-serif;font-weight:bold;text-transform: uppercase;">' + datosJson.RazonSocial + '</option>');
            }
        }

    });



}

function sucursalesBuscarPorIdEmpresa(empresa) {

    document.getElementById("selectIdSucursal").value = ""

    var cadena = {
        IdEmpresa: empresa.value

    };
    var payload = { cadena: JSON.stringify(cadena) };
    $.ajax({
        type: "POST",
        url: "ProyectosTipo.aspx/SucursalesBuscarPorIdEmpresa",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {



            var json = $.parseJSON(data.d);
            console.log(json)


            for (var i = 0; i < json.Data.length; i++) {
                var datosJson = json.Data[i];
                // searchMotivoEdit(datosJson.Id);
                $("#selectIdSucursal").append('<option value="' + datosJson.IdSucursal + '" class="form-control" style="font-family: Lato, sans-serif;font-weight:bold;text-transform: uppercase;">' + datosJson.Nombre + '</option>');
            }
        }
    });



}

