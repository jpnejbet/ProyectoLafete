
$(document).ready(function () {



    $(".ConsultaContratos").change(
        function (e) {

            $.ajax(
                {
                    url: "ConsultaContratoCliente",
                    type: "POST",
                    data: {
                        _clienteCotrato: $("#Cliente").val()
                    },
                    success: function (datoValorComuna) {

                        $.each(datoValorComuna, function (i, datoComuna) {

                            $("#inputSuccess2").val(datoComuna.Nombre);
                            $("#inputSuccess4").val(datoComuna.Rut);
                            $("#inputSuccess6").val(datoComuna.Email);

                        });
                    },
                    async: true
                });
        });




    $(".ConsultaProductos").change(

        function (e) {
            $.ajax(
                {
                    url: "ConsultaProductosId",
                    type: "POST",
                    data: {
                        _IdProductos: $("#cmdProdutos").val()
                    },
                    success: function (datoValorComuna) {
                        $.each(datoValorComuna, function (i, datoComuna) {
                            $("#txtUnidadMedida").val(datoComuna.UnidadMedida);
                            $("#txtValorServicio").val(datoComuna.PrecioUnitario);

                        });
                    },
                    async: true
                });
        });



    $(".ConsultarCantidadToneladas").change(

        function (e) {
            $.ajax(
                {
                    url: "ConsultaContratos",
                    type: "GET",
                    data: {
                        _IdContrato: $("#CmbCliente").val()
                    },
                    success: function (datoValorComuna) {

                        var table = $("#tbladeproductos");
                        var html = "<thead><tr><th>Nro Contrato</th><th>Nro Servicio</th><th>Cliente</th><th>Servicio</th><th>Tipo Carga</th><th>Unidad Medida</th><th>Cantidad</th><th>Valor</th><th>Seleccionar</th></thead>";

                        $.each(datoValorComuna, function (index, value) {

                            $.each(this, function (name, value) {
                                html += "<tr><td>" + value.IdContrato + "</td><td>" + value.IdPedido + "</td><td>" + value.Cliente + "</td><td>" + value.Servicio + "</td><td>" + value.TipoCarga + "</td><td>" + value.UnidadMedida + "</td><td>" + value.Cantidad + "</td><td>" + value.Valor + "</td>" + "<td><button  class='btn btn - success' type='button' data-toggle='modal' data-target='#ModalRuta' onclick='BuscarDatosProyeccion(" + value.IdPedido + ")' >Seleccionar</button></td></td></tr>";
                            });
                        });

                        table.html(html);
                    },
                    async: true
                });
        });







    $("#btnGrabarCliemteContrato").click(function () {
        var ID = $("#txtIdCliente").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaTamarugalClienteContrato",
            type: "POST",
            data: {
                _Id: ID,
                _Cliente: $("#CmbCliente").val(),
                _Fecha: $("#single_cal2").val(),
                _Encargado: $("#txtEncargado").val(),
                _Comentario: $("#txtComentario").val(),
                _IdDestino: $("#cmbDestino").val(),
                _Servicio: $("#txtServicio").val(),
                _Valor: $("#txtValorServicio").val(),
                _IdTipoCamion: 0,
                _IdTipoCarga: $("#cmdProdutos").val(),
                _UnidadMedida: $("#txtUnidadMedida").val(),
                _Cantidad: $("#txtCantidad").val(),
                _FechaCreacionSistema: $("#single_cal2").val(),
                _FechaServicio: $("#single_cal2").val()

            },
            async: true,
            success: function (data) {
                if (data == 1) {
                    $("#btnCerrarModal").click();
                    alert("El Ingreso se ha realizado sin problemas.");
                }
                if (data == 2) {
                    alert("No se puede grabar el dato en la BD, intentalo nuevamente.");
                }
                if (data == 3) {
                    alert("El nombre del parametro no puede estar vacio, no se ha realizado la operación.");
                }
                if (data == -1) {
                    top.location.href = 'ErrorPage?error=101';
                }
                if (data == 0) {
                    alert("Hay un problema con el metodo de grabación, reinicia la sesión e intentalo nuevamente.");
                }
            }
        });
    });




    $("#btnGrabarDetalleContrato").click(function () {

        var ID = $("#txtIdContrato").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }

        $.ajax({
            url: "GrabaTamarugalDetalleContrato",
            type: "POST",
            data: {
                _Id: -1,
                _IdContrato: $("#txtIdContrato").val(),
                _IdDestino: $("#cmbDestino").val(),
                _Servicio: $("#txtServicio").val(),
                _Valor: $("#txtValorServicio").val(),
                _IdTipoCamion: 0,
                _IdTipoCarga: $("#cmdProdutos").val(),
                _UnidadMedida: $("#txtUnidadMedida").val(),
                _Cantidad: $("#txtCantidad").val(),
                _FechaCreacionSistema: $("#single_cal2").val(),
                _FechaServicio: $("#single_cal2").val()
            },
            async: true,
            success: function (data) {
                if (data == 1) {
                    $("#btnCerrarModal").click();
                    alert("El Ingreso se ha realizado sin problemas.");
                }
                if (data == 2) {
                    alert("No se puede grabar el dato en la BD, intentalo nuevamente.");
                }
                if (data == 3) {
                    alert("El nombre del parametro no puede estar vacio, no se ha realizado la operación.");
                }
                if (data == -1) {
                    top.location.href = 'ErrorPage?error=101';
                }
                if (data == 0) {
                    alert("Hay un problema con el metodo de grabación, reinicia la sesión e intentalo nuevamente.");
                }
            }
        });
    });






    $("#btnGrabarDatosGE").click(function () {
        var ID = -1;// $("#txtIdGE").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaDatosGuiaExpedicion",
            type: "POST",
            data: {
                _Id: ID,
                _IdContrato: $("#txtIdcontrato").val(),
                _idServicio: $("#txtIdServicio").val(),
                _CantidadCiclos: $("#txtCantidadDespachos").val()
            },
            async: true,
            success: function (data) {
                if (data == 1) {
                    $("#btnCerrarModal").click();
                    alert("El Ingreso se ha realizado sin problemas.");
                }
                if (data == 2) {
                    alert("No se puede grabar el dato en la BD, intentalo nuevamente.");
                }
                if (data == 3) {
                    alert("El nombre del parametro no puede estar vacio, no se ha realizado la operación.");
                }
                if (data == -1) {
                    top.location.href = 'ErrorPage?error=101';
                }
                if (data == 0) {
                    alert("Hay un problema con el metodo de grabación, reinicia la sesión e intentalo nuevamente.");
                }
            }
        });
    });




    $("#GenerarguimientoPedido").click(function () {
        var ID = $("#txtIdPedido").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GenerarSeguimientoPedido",
            type: "POST",
            data: {
                _Id: ID,
                _CodigoLocal: $("#txtLocal").val(),
                _NombreLocal: $("#txtNombreLocal").val()

            },
            async: true,
            success: function (data) {
                if (data == 1) {
                    $("#btnCerrarModal").click();
                    alert("El Ingreso se ha realizado sin problemas.");
                }
                if (data == 2) {
                    alert("No se puede grabar el dato en la BD, intentalo nuevamente.");
                }
                if (data == 3) {
                    alert("El nombre del parametro no puede estar vacio, no se ha realizado la operación.");
                }
                if (data == -1) {
                    top.location.href = 'ErrorPage?error=101';
                }
                if (data == 0) {
                    alert("Hay un problema con el metodo de grabación, reinicia la sesión e intentalo nuevamente.");
                }
            }
        });
    });



    $("#btnGrabaConductor").click(function () {

        $.ajax({
            url: "GrabaDatosActualizaConductor",
            type: "POST",
            data: {
                _Id: $("#txtidguia").val(),
                _IdConductor: $("#cmbConductor").val()
            },
            async: true,
            success: function (data) {
                if (data == 1) {
                    $("#btnCerrarModal").click();
                    alert("El Ingreso se ha realizado sin problemas.");
                }
                if (data == 2) {
                    alert("No se puede grabar el dato en la BD, intentalo nuevamente.");
                }
                if (data == 3) {
                    alert("El nombre del parametro no puede estar vacio, no se ha realizado la operación.");
                }
                if (data == -1) {
                    top.location.href = 'ErrorPage?error=101';
                }
                if (data == 0) {
                    alert("Hay un problema con el metodo de grabación, reinicia la sesión e intentalo nuevamente.");
                }
            }
        });
    });





    $("#tblContrato").DataTable({
        paging: true,
        retrieve: true,
        searching: true,
        responsive: true,
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.11/i18n/Spanish.json",
            "lengthMenu": "Mostrar _MENU_ filas por Página",
            "zeroRecords": "No existen Registros en el sistema",
            "info": "Mostrando página _PAGE_ de _PAGES_",
            "infoEmpty": "No se han encontrado registros",
            "infoFiltered": "(Filtrando de un total de  _MAX_ registros)"
        }
    });

});







function BuscarDatosProyeccion(
    _id
) {



    $.ajax({
        type: 'GET',
        url: "DetalleServicioTamarugalId",
        data: {
            _IdContrato: _id
        },
        success: function (data) {

            $.each(data, function (index, value) {

                $.each(this, function (name, value) {


                    $("#txtIdContrato").val(value.IdContrato);
                    $("#txtCliente").val(value.Cliente);
                    $("#txtRuta").val(value.Ruta);
                    $("#txtFechaServicio").val(value.FechaServicioTexto);
                    $("#txtNombreServicio").val(value.Servicio);
                    $("#txtProducto").val(value.TipoCarga);
                    $("#txtUnidadMedidad").val(value.UnidadMedida);
                    $("#txtValor").val(value.Valor);
                    $("#txtCantidad").val(value.Cantidad);
                    $("#txtIdcontrato").val(value.IdContrato);
                    $("#txtIdServicio").val(value.IdServicio);

                });
            });




        }
    });


}



function getProductDetails(id, cliente) {


    $.ajax({
        type: 'GET',
        url: "ConsultaContratos",
        data: {
            _IdContrato: id
        },
        success: function (data) {

            var table = $("#tbladeproductos");
            var html = "<thead><tr><th>Nro Contrato</th><th>Nro  Servicio</th><th>Cliente</th><th>Servicio</th><th>Tipo Carga</th><th>Unidad Medida</th><th>Cantidad</th><th>Valor</th><th>Editar</th></thead>";


            $.each(data, function (index, value) {

                $.each(this, function (name, value) {
                    html += "<tr>><td>" + value.IdContrato + "</td><td>" + value.IdPedido + "</td><td>" + value.Cliente + "</td><td>" + value.Servicio + "</td><td>" + value.TipoCarga + "</td><td>" + value.UnidadMedida + "</td><td>" + value.Cantidad + "</td><td>" + value.Valor + "</td>" + "<td><button class='btn btn - success' type='button' data-toggle='modal' data-target='#ModalRuta'>Editar</button></td></td></tr>";
                });
            });


            table.html(html);
            $("#txtIdContrato").val(id);
            $("#txtCliente").val(cliente);



        }
    });
}





function AsignaConductor(
    _Guia
) {
    $("#txtidguia").val(_Guia)
}