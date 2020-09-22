
$(function () {

        $("#c1_txtSerial").change(function () {
           
            var paramentros = {
                "serial": $('#c1_txtSerial').val()
            };
            var serial = JSON.stringify(paramentros);
            $.ajax({

                url: 'FrmSolicitud.aspx/obtenerEquipo',
                data: serial,
                dataType: 'json',
                type: 'post',
                contentType: "application/json; charset=utf-8",
                success: function (resultado) {
                    console.log(resultado);
                    if (resultado.d == null) {
                        $("#c1_lblMensajeSerial").html("No existe equipo con el serial No: " + $('#c1_txtSerial').val());
                        $('#c1_txtSerial').val("");
                        $(this).focus();
                    } else {
                        $("#c1_lblMensajeSerial").html("");
                    }
                },
                error: function (result) {
                    console.log(result);
                }

            });
        });
    });

        function listarDetalleSolicitud() {
           
            var paramentros = {
                "idSolicitud": $('#c1_txtIdSolicitud').val()

            };
           
            idSolicitud = JSON.stringify(paramentros);
            $.ajax({             

                url: '../../Controlador/ctrlServicioWebSolicitud.aspx/listarDetalleSolicitud',
                data: idSolicitud,
                dataType: 'json',
                type: 'post',
                contentType: "application/json; charset=utf-8",
                success: function (respuesta) {

                    
                    
                    console.log(respuesta.d);
                    $.each(respuesta.d, function (i, detalle) {
                       
                       $("#dOficina").html(detalle.Equipo.Dependencia.NombreDependencia);
                        $("#dSerial").html(detalle.Equipo.Serial);
                        $("#dObservacion").html(detalle.Observaciones);                        
                        $("#tblDetalle tbody").append($("#fila").clone(true));


                    });
                    $("#tblDetalle tbody tr").first().hide();

                }

            });

        }

        function listarSolicitudesPorAtender() {
           
        
            $.ajax({
                url: '../../Controlador/ctrlServicioWebSolicitud.aspx/listarSolicitudPendientes',
                dataType: 'json',
                type: 'post',
                contentType: "application/json; charset=utf-8",
                success: function (respuesta) {
                    console.log(respuesta.d);
                    $.each(respuesta.d, function (i, solicitud) {
                        $("#sTicket").html(solicitud.Ticket);
                        $("#sFuncionario").html(solicitud.Empleado.Nombres + " " + solicitud.Empleado.Apellidos);
                        $("#sDependencia").html(solicitud.Empleado.Dependencia.NombreDependencia);
                        var fecha = solicitud.Fecha;
                        var nuevaFecha = new Date(parseInt(fecha.match(/\d+/)[0]));
                        nuevaFecha = nuevaFecha.getDate() + '/' + (nuevaFecha.getMonth() + 1) + '/' + nuevaFecha.getFullYear();
                        $("#sFecha").html(nuevaFecha);
                        $("#sEstado").html(solicitud.Estado);
                        
                        var id = solicitud.IdSolicitud;
                        $("#sFoto").html
                            ("<a href='frmDetalleSolicitud.aspx?idSolicitud=" + id + "'><img id='fotoAccion' src='../../Recursos/img/lgLista.png'></a>");


                        $("#tblSolicitudes tbody").append($("#fila").clone(true));
                    });
                
              
                    $("#tblSolicitudes tbody tr").first().hide();
                }
            });
        }



   