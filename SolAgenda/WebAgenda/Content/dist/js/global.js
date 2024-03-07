function creaFecha(fecha, hora = '') {
    //Crea objeto fecha a partir de fecha en dd/mm/yyyy y hora
    let anio = fecha.substring(6)
    let mes = fecha.substring(3, 5)
    let dia = fecha.substring(0, 2)
    let sFecha = `${anio}-${mes}-${dia} ${hora}`
    sFecha = sFecha.trim()
    if (new Date(sFecha).toString() == 'Invalid Date') return null
    fecha = `${anio}-${mes}-${dia}`
    if (hora != '')
        fecha += ' ' + hora
    return fecha
}

function formatFecha(formatoOriginal) {
    var partes = formatoOriginal.split('-')
    var fecha = new Date(partes[0], partes[1] - 1, partes[2])

    var dia = fecha.getDate()
    var mes = fecha.getMonth() + 1
    var anio = fecha.getFullYear()

    dia = dia < 10 ? '0' + dia : dia
    mes = mes < 10 ? '0' + mes : mes

    var formatoConvertido = dia + '/' + mes + '/' + anio
    return formatoConvertido
}

function muestraMensaje(icon, titulo, mensaje) {
    Swal.fire({
        icon: icon,
        title: titulo,
        text: mensaje,
        confirmButtonColor: '#F36F21'
    })
}

function muestraMensajeConfirmacion(mensaje, funcion) {
    Swal.fire({
        icon: 'question',
        title: 'Confirmación',
        text: mensaje,
        showCancelButton: true,
        confirmButtonText: 'Confirmar',
        cancelButtonText: 'Cancelar',
        confirmButtonColor: '#F36F21'
    }).then((result) => {
        if (result.isConfirmed) {
            funcion()
        }
    })
}

function soloNumeros(input) {
    let regex = /[^0-9]/gi;
    input.value = input.value.replace(regex, '');
}

function mayusculas(input) {
    input.value = input.value.toUpperCase()
}
function minusculas(input) {
    input.value = input.value.toLowerCase()
}

function ajaxPost(url, data, callback) {
    $('#loader').show()
    $.ajax({
        type: 'POST',
        url: url,
        dataType: "json",
        data: data,
        success: function (data) {
            $('#loader').hide()
            callback(data)
        },
        error: function (jqXHR) {
            muestraMensaje('error', 'Ocurrio un error', 'Contacte al administrador')
            console.log(jqXHR.responseText)
            $('#loader').hide()
        }
    })
}

function ajaxPostFiles(url, data, callback) {
    $('#loader').show()
    $.ajax({
        type: 'POST',
        url: url,
        dataType: "json",
        data: data,
        contentType: false,
        processData: false,
        success: function (data) {
            $('#loader').hide()
            callback(data)
        },
        error: function (jqXHR) {
            muestraMensaje('error', 'Ocurrio un error', 'Contacte al administrador')
            console.log(jqXHR.responseText)
            $('#loader').hide()
        }
    })
}