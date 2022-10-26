const contactoValor = document.getElementById('txtValorContactoTipo');
const contactoCargo = document.getElementById('txtCargoContactoTipo');
const contactoEstado = document.getElementById('selectContactoEstado');
const addContactoBtn = document.getElementById('addContactoBtn');
const divFormasContacto = document.getElementById('FormasContacto')
const agregarContactoTipo = document.getElementById('agregarContactoTipo')
const selectContactoTipo = document.getElementById('selectContactoTipo');
let contactoCount = 0;
let contactoList = []

agregarContactoTipo.addEventListener('click', agregarContacto);
addContactoBtn.addEventListener('click', addContacto);

function agregarContacto(){
    if(selectContactoTipo.value != 'Seleccione'){
        $('#modalContactoTipo').modal('show');
    }else{
        alert('error');
    }
}

function addContacto(){
    let Valor= contactoValor.value;
    let Cargo = contactoCargo.value;
    let Estado = contactoEstado.value;
    let Id = selectContactoTipo.value;

    if (Valor != '' && Cargo != '' && Estado != 'Seleccione') {
        //let pathImagen = json.Imagen
        let formaContacto = document.createElement("div")
        formaContacto.className= 'col-1 img-wrap';

        let imagenContacto = document.createElement("img")
        imagenContacto.src= contactoTipoBuscarImg(Id)//"./ImagenesEmpresas/20228101097,34734655167ORi.png"//pathImagen
        imagenContacto.width = 50

        // let btnDelete = document.createElement('span')
        // btnDelete.className= 'close';
        // btnDelete.value = 'x';

        divFormasContacto.appendChild(formaContacto);
        formaContacto.innerHTML = "<span class='close'>&times;</span>"
        formaContacto.innerHTML += "<input type='text' hidden='hidden' value=" + contactoCount + " />"
        formaContacto.appendChild(imagenContacto)

        contactoValor.value = '';
        contactoCargo.value = '';
        contactoEstado.value = 'Seleccione';
        let contacto = {
            "IdConactoTipo":Id,
            "Valor": Valor,
            "Cargo": Cargo,
            "Activo": Estado
        }

        contactoList.push(contacto);

        contactoCount++;
    }else{
        //mensaje error
        alert('error')
    }

    const btnDelete = document.querySelectorAll('.img-wrap .close');
    btnDelete.forEach((btnDelete) =>{
        btnDelete.addEventListener('click',removeContacto)
    });

    function removeContacto(){
        this.parentNode.remove();
        console.log(this.nextSibling.value)
        delete contactoList[this.nextSibling.value]
    }

}


function contactoTipoBuscarImg(id){
    //let IdContactoTipo = document.getElementById('selectContactoTipo').value;
    let Valor = document.getElementById('txtValorContactoTipo').value;
    // let Cargo = document.getElementById('txtCargoContactoTipo').value;
    // let Estado = document.getElementById('selectEstadoContactoTipo').value;

    var cadena = {
        IdContactoTipo: id
    }

    var payload = {
        cadena: JSON.stringify(cadena)
    }

    $.ajax({
        type: "POST",
        url: "Empresas.aspx/ContactoTiposBuscarPorId",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;
            console.log(json)
            if (status == 200) {
                console.log(json.Imagen)
                let pathImagen = json.Imagen
                return pathImagen
            }
        }
    });
}

