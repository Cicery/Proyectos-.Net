$(document).ready(function () {
    $('.alert').show().delay(2000).fadeOut("fast");
});




/**
 * funcion para listar las tareas en una tabla,  la cual obtiene los datos desde el ctrlRESTfullTareas
 * enviandole el parametro requerido 
 * */
function listarTareas() {

    var paramentros = {
        "idPersona": $('#c1_txtIdPersona').val()

    };

    idPersona = JSON.stringify(paramentros);
    $.ajax({

        url: '../../Controlador/ctrlRESTfulTareas.aspx/listarTareas',
        data: idPersona,
        dataType: 'json',
        type: 'post',
        contentType: "application/json; charset=utf-8",
        success: function (respuesta) {

            $.each(respuesta.d,
                /**
                 * funcion en la que se procesa los datos que vienen desde el controlador
                 * para mostrarlos en la vista en este caso en una tabla
                 * @param {any} i
                 * @param {any} detalle parametro con los datos a procesar
                 */
                function (i, detalle) {

                    $("#tDescripcion").html(detalle.Descripcion);
                    $("#tEstado").html(detalle.Estado);
                    var idTarea = detalle.IdTarea;

                    $("#tAccion").html
                        ("<a href='frmListarActividades.aspx?idTarea=" + idTarea + "'><img id='fotoAccion' src='../../Recursos/Imagenes/lgLista.png'></a>");

                    $("#tblTareas tbody").append($("#tFila").clone(true));


                });

         

                $('#tblTareas').DataTable({
                    'ordering': true,
                    'order': [[0, 'desc']],
                    'language': {
                        'url': 'https://cdn.datatables.net/plug-ins/1.10.19/i18n/Spanish.json',
                    }
                });
       
            //$("#tblTareas tbody tr").first().hide();

        }

    });

}

/**
 * funcion para listar las actividades en una tabla,  la cual obtiene los datos desde el ctrlRESTfullTareas
 * enviandole el parametro requerido 
 * */

function listarActividades() {

    var paramentros = {
        "idTarea": $('#c1_txtIdTarea').val()

    };

    idTarea = JSON.stringify(paramentros);
    $.ajax({

        url: '../../Controlador/ctrlRESTfulTareas.aspx/listarActividades',
        data: idTarea,
        dataType: 'json',
        type: 'post',
        contentType: "application/json; charset=utf-8",
        success: function (respuesta) {

            $.each(respuesta.d,
                /**
                 * funcion en la que se procesa los datos que vienen desde el controlador
                 * para mostrarlos en la vista en este caso en una tabla
                 * @param {any} i
                 * @param {any} detalle parametro con los datos a procesar
                 */
                function (i, detalle) {

                    var fecha = detalle.Actividades.Fecha;
                    var nuevaFecha = new Date(parseInt(fecha.match(/\d+/)[0]));
                    nuevaFecha = nuevaFecha.getDate() + '/' + (nuevaFecha.getMonth() + 1) + '/' + nuevaFecha.getFullYear();

                    $("#aFecha").html(nuevaFecha);
                    $("#aDuracion").html(detalle.Actividades.Duracion);
                    $("#aDescripcion").html(detalle.Actividades.Descripcion);
                    $("#aEstado").html(detalle.Actividades.Estado);
                    $("#c1_lblDesTarea").text(detalle.Descripcion);

                    $("#tblActividades tbody").append($("#aFila").clone(true));


                });

            $('#tblActividades').DataTable({
                'ordering': true,
                'order': [[0, 'desc']],
                'language': {
                    'url': 'https://cdn.datatables.net/plug-ins/1.10.19/i18n/Spanish.json',
                }
            });

            $("#tblActividades tbody tr").first().hide();

        }

    });

}

$(document).on('click', '#btnNuevaActividad', function () {

    $("#contAggActividad").css("display", "inline");
})





