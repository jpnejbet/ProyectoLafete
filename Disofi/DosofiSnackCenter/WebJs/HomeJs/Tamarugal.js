
$(document).ready(function () {


    $("#cmbConductor").change(function () {
        // alert("Item " + $(this)[0].options[$(this)[0].selectedIndex].text + "(valor es:" + $(this).val() + ")");

        $("#txtIdConductor").val($(this).val());
        $("#txtNombreConductor").val($(this)[0].options[$(this)[0].selectedIndex].text);

    });


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


    $("#txtValorContrato").on({
        "focus": function (event) {
            $(event.target).select();
        },
        "keyup": function (event) {
            $(event.target).val(function (index, value) {
                return value.replace(/\D/g, "")
                    .replace(/([0-9])([0-9]{2})$/, '$1,$2')
                    .replace(/\B(?=(\d{3})+(?!\d)\.?)/g, ".");
            });
        }
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
                        });
                    },
                    async: true
                });
        });





    $(".ConsultaRutasCliente").change(
        function (e) {
            $("#CmbRuta").empty();
            $.ajax(
                {
                    url: "BuscarRutasCliente",
                    type: "POST",
                    data: {
                        _cliente: $("#CmbCliente").val()
                    },
                    success: function (datoValorComuna) {
                        $.each(datoValorComuna, function (i, datoComuna) {


                            $("#CmbRuta").append('<option value="' + datoComuna.Id + '">' +
                                datoComuna.Ruta + '</option>');

                            $("#CmbRuta2").append('<option value="' + datoComuna.Id + '">' +
                                datoComuna.Ruta + '</option>');


                        });
                    },
                    async: true
                });
        });





    $(".ConsultaProductos2").change(

        function (e) {
            $.ajax(
                {
                    url: "ConsultaProductosId",
                    type: "POST",
                    data: {
                        _IdProductos: $("#cmdProdutosSoft").val()
                    },
                    success: function (datoValorComuna) {
                        $.each(datoValorComuna, function (i, datoComuna) {
                            $("#txtUnidadMedidaServ").val(datoComuna.UnidadMedida);
                        });
                    },
                    async: true
                });
        });



    $(".ConsultaSucursalUsuario").change(

        function (e) {
            $.ajax(
                {
                    url: "ConsultaSucursalUsuarioId",
                    type: "POST",
                    data: {
                        _IdUsuario: $("#cmbUsuario").val()
                    },
                    success: function (datoValorComuna) {
                        $.each(datoValorComuna, function (i, datoComuna) {
                            $("#txtSucursalUsuario").val(datoComuna.Nombre);
                        });
                    },
                    async: true
                });
        });






    $(".DespachoConductor").change(

        function (e) {
            $.ajax(
                {
                    url: "ConsultarConductorDespacho",
                    type: "GET",
                    data: {
                        _IdConductor: $("#cmbConductor").val()
                    },
                    success: function (datoValorComuna) {

                        var table = $("#tblDespachoConductor");
                        var html = "<thead><tr><th>Nro Guia</th><th>Nro Contrato</th><th>Cliente</th><th>N°Pedido</th><th>Patente</th><th>Servicio</th><th>Vueltas</th><th>Cantidad</th><th>Camión</th><th>Seleccionar</th></thead>";

                        $.each(datoValorComuna, function (index, value) {

                            $.each(this, function (name, value) {
                                html += "<tr><td>" + value.IdGuia + "</td><td>" + value.NroContrato + "</td><td>" + value.Cliente + "</td><td>" + value.NroPedido + "</td><td>" + value.Patente + "</td><td>" + value.Servicio + "</td>" + "<td>" + value.Vueltas + "</td><td>" + value.Pedido + "</td><td>" + value.TipoCamion + "</td>" + "<td><button  class='btn btn - success' type='button' data-toggle='modal' data-target='#ModalRuta' onclick='BuscarDatosProyeccion(" + value.IdGuia + "," + value.NroPedido + ")' >Despachar</button></td></td></tr>";
                            });

                        });

                        table.html(html);
                    },
                    async: true
                });
        });



    $("#btnGrabarCliemteContrato").click(function () {

        var ID = $("#TxtIdContrato").val();
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
                _NumeroContrato: $("#TxtNroContrato").val(),
                _Cliente: $("#CmbCliente").val(),
                _FechaInicio: $("#single_cal3").val(),
                _FechaTermino: $("#single_cal4").val(),
                _Comentario: $("#txtComentario").val(),
                _IdSucursal: $("#cmbSucursal").val(),
                _ValorContrato: $("#txtValorContrato").val(),
                _Moneda: $("#cmdMoneda").val(),
                _Servicio: $("#txtServicio").val(),
                _Ruta: $("#txtRuta").val(),
                _IdUnidadMedida: $("#UnidadMedida").val(),
                _Cantidad: $("#txtCantidad").val(),
                _ValorServicio: $("#txtValor").val(),
                _Detalle: $("#txtDetalle").val(),
            },
            async: true,
            success: function (data) {
                if (data > 1) {

                    DetalleContrato(data);

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
                _Ruta: $("#CmbRuta2").val(),
                _Servicio: $("#txtServicioD").val(),
                _Valor: 0,
                _IdTipoCamion: 0,
                _IdTipoCarga: $("#cmdProdutosSoft").val(),
                _UnidadMedida: $("#txtUnidadMedidaServ").val(),
                _Cantidad: $("#txtCantidadServ").val(),
                _FechaInicio: $("#txtFechaInicioS").val(),
                _FechaFin: $("#txtFechaTerminoS").val()
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







    $("#btnGrabarDatosDespacho").click(function () {
        var ID = $("#txtIdDespcho").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabarDespacho",
            type: "POST",
            data: {
                _Id: ID,
                _IdGuiaExpedicion: $("#txtidguia").val(),
                _NumeroPedido: $("#txtNroPedido").val(),
                _NroContrato: $("#txtContrato").val(),
                _IdConductor: $("#txtIdConductor").val(),
                _Cliente: $("#txtClienteDespacho").val(),
                _Servicio: $("#txtServicio").val(),
                _Ruta: $("#CmbRuta").val(),
                _Cantidad: $("#txtCantidad").val(),
                _Vueltas: $("#txtVuelta").val(),
                _Patente: $("#txtPatente").val(),
                _NroRemolque: $("#txtPlacaNroRemolque").val()


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




    $("#btnGrabarDatosPedido").click(function () {
        var ID = $("#txtIdPedido").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaDatosPedido",
            type: "POST",
            data: {
                _Id: ID,
                _IdContrato: $("#txtIdContrato").val(),
                _IdServicio: $("#txtIdServicio").val(),
                _Cliente: $("#txtCliente").val(),
                _Ruta: $("#CmbRuta").val(),
                _FechaInicio: $("#single_cal3").val(),
                _FechaFin: $("#single_cal4").val(),
                _Cantidad: $("#txtCantidadDespachos").val(),
                _UnidadMedida: $("#UnidadMedida").val()

            },
            async: true,
            success: function (data) {
                if (data > 1) {
                    $("#btnCerrarModal").click();
                    alert("Se creado pedido N°." + data);
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
                _IdContrato: $("#txtIdContrato").val(),
                _idServicio: $("#txtIdServicio").val(),
                _IdConductor: $("#txtIdConductor").val(),
                _NumeroPedido: $("#txtNroPedido").val(),
                _IdPedido: $("#txtIdPedido").val(),
            },
            async: true,
            success: function (data) {
                if (data >= 1) {
                    $("#btnCerrarModal").click();
                    alert("Se ha creado una nueva guia expedición, Nro Guía :" + data);
                }
                if (data == -1) {
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





    $("#btnGrabarRendicionGasto").click(function () {
        var ID = 0;
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaGasto",
            type: "POST",
            data: {
                _Id: ID,
                _IdContrato: $("#txtNroCliente").val(),
                _idGuia: $("#txtNroGuia").val(),
                _Idpedido: $("#txtNroPedido").val(),
                _IdGasto: $("#CmbRuta").val(),
                _valor: $("#txtValorGasto").val(),
                _nummeroTicket: $("#txtNroTicket").val(),
                _fecha: $("#single_cal4").val()
            },
            async: true,
            success: function (data) {
                if (data == 1) {
                    $("#btnCerrarModal").click();
                    alert("El Gasto se ha registrado sin problemas.");
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
                idguia: $("#txtidguia").val(),
                idconductor: $("#cmbConductor").val(),
                Ruta: $("#txtRuta").val(),
                IdCamion: $("#cmbCamion").val(),
                Vueltas: $("#TxtCantidadVueltas").val(),
                Patente: $("#txtPatente").val(),
                PlacaNroRemolque: $("#txtNroRemolque").val(),
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



    $("#btnGrabarRecepcionGuia").click(function () {

        $.ajax({
            url: "GrabarRecepcionGuia",
            type: "POST",
            data: {
                _Id: $("#txtNroGuia").val(),
                _Patente: $("#txtPatente").val(),
                _PlacaNroRemolque: $("#txtPlacaNroRemolque").val(),
                _RutEmisor: $("#txtRutEmisor").val(),
                _NroGuiaDespachoCliente: $("#txtGuiaDespacho").val(),
                _FechaEmision: $("#single_cal3").val(),
                _Toneladas: $("#txtToneladas").val(),
                _FechaTimbre: $("#single_cal1").val(),
                _Comentario: $("#txtComentario").val(),
                _NumeroPedido: $("#txtNroPedido").val(),
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



    $("#tblDetalleContrato").DataTable({
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


    $("#tblConductores").DataTable({
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



    $("#tblServicio").DataTable({
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


    $("#tblRuta").DataTable({
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




    $("#TblInforme").DataTable({
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
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





    $("#tblConsultaGasto").DataTable({
        dom: 'Bfrtip',
        buttons: [
            'print'
        ],
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
    _idGuia, _NroPedido
) {

    $.ajax({
        type: 'GET',
        url: "DetalleServicioTamarugalId",
        data: {
            _idguia: _idGuia,
            _numeroPedido: _NroPedido,
        },
        success: function (data) {

            $.each(data, function (index, value) {

                $.each(this, function (name, value) {

                    $("#txtidguia").val(value.NroGuia);
                    $("#txtNroPedido").val(value.NroPedido);
                    $("#txtContrato").val(value.NroContrato);
                    $("#txtClienteDespacho").val(value.Cliente);
                    $("#txtServicio").val(value.Servicio);
                    $("#txtIdConductor").val(value.IdConductor);
                    $("#txtConductor").val(value.Conductor);


                    ConsultaRutasClienteDespacho(value.NroContrato);
                });
            });





        }
    });


}

function ConsultaRutasClienteDespacho(
    _Cliente
) {
    $("#CmbRuta").empty();
    $.ajax(
        {
            url: "BuscarRutasCliente",
            type: "POST",
            data: {
                _Contrato: _Cliente
            },
            success: function (datoValorComuna) {
                $.each(datoValorComuna, function (i, datoComuna) {


                    $("#CmbRuta").append('<option value="' + datoComuna.Ruta + '">' +
                        datoComuna.Ruta + '</option>');

                });
            },
            async: true
        });
}


function ConsultaRutasServicio(
    _Cliente
) {
    $("#CmbRuta2").empty();
    $.ajax(
        {
            url: "BuscarRutasCliente",
            type: "POST",
            data: {
                _cliente: _Cliente
            },
            success: function (datoValorComuna) {
                $.each(datoValorComuna, function (i, datoComuna) {


                    $("#CmbRuta2").append('<option value="' + datoComuna.Id + '">' +
                        datoComuna.Ruta + '</option>');

                });
            },
            async: true
        });
}

function BuscarDatosPedido(
    _id
) {
    $("#CmbRuta").empty();

    $.ajax({
        type: 'GET',
        url: "DetalleServicioTamarugalSoloId",
        data: {
            _IdContrato: _id
        },
        success: function (data) {

            $.each(data, function (index, value) {

                $.each(this, function (name, value) {



                    $("#TxtNroContrato").val(value.NroContrato);
                    $("#txtIdServicio").val(value.IdServicio);
                    $("#txtIdContrato").val(value.IdContrato);
                    $("#txtCliente").val(value.Cliente);
                    $("#txtRuta").val(value.Ruta);
                    $("#txtFechaServicio").val(value.FechaServicioTexto);
                    $("#txtNombreServicio").val(value.Servicio);
                    $("#txtProducto").val(value.TipoCarga);
                    $("#txtUnidadMedidad").val(value.UnidadMedida);
                    $("#txtValor").val(value.Valor);
                    $("#txtCantidad").val(value.Cantidad);



                    $("#CmbRuta").append('<option value="' + value.Ruta + '">' +
                        value.Ruta + '</option>');


                });
            });




        }
    });


}








function getProductDetails2(id, cliente, FechaInicio, FechaTermino) {


    $.ajax({
        type: 'GET',
        url: "ConsultaContratos2",
        data: {
            _IdContrato: id
        },
        success: function (data) {

            var table = $("#tbladeproductos");
            var html = "<thead><tr><th>Nro Contrato</th><th>Nro  Servicio</th><th>Cliente</th><th>Servicio</th><th>Tipo Carga</th><th>Unidad Medida</th><th>Cantidad</th><th>Editar</th></thead>";


            $.each(data, function (index, value) {

                $.each(this, function (name, value) {
                    html += "<tr><td>" + value.NroContrato + "</td><td>" + value.IdPedido + "</td><td>" + value.Cliente + "</td><td>" + value.Servicio + "</td><td>" + value.TipoCarga + "</td><td>" + value.UnidadMedida + "</td><td>" + value.Cantidad + "<td><button class='btn btn - success' type='button' data-toggle='modal' data-target='#ModalRuta'>Editar</button></td></td></tr>";
                });
            });

            table.html(html);
            $("#txtIdContrato").val(id);
            $("#txtCliente").val(cliente);
            $("#txtFechaInicioS").val(FechaInicio);
            $("#txtFechaTerminoS").val(FechaTermino);


            ConsultaRutasServicio(cliente);
        }
    });
}




function DetalleContrato(idContrato) {


    $.ajax({
        type: 'GET',
        url: "ConsultaContratos2",
        data: {
            _IdContrato: idContrato
        },
        success: function (data) {

            var table = $("#tbladeproductos");
            var html = "<thead><tr><th>Nro Servicio</th><th>Servicio</th><th>Ruta</th><th>Unidad Medida</th><th>Cantiad</th><th>Valor</th><th>Editar</th></thead>";


            $.each(data, function (index, value) {

                $.each(this, function (name, value) {
                    html += "<tr><td>" + value.IdServicio + "</td><td>" + value.Servicio + "</td><td>" + value.Ruta + "</td><td>" + value.UnidadMedida + "</td><td>" + value.Cantidad + "</td><td>" + value.Valor + "<td><button class='btn btn - success' type='button' data-toggle='modal' data-target='#ModaServicio'>Editar</button></td></td></tr>";
                });
            });

            table.html(html);
            $("#txtRuta").val("");
            $("#txtCantidad").val("");
            $("#txtValor").val("");
            $("#txtDetalle").val("");
            $("#UnidadMedida").val("");
            $("#TxtIdContrato").val(idContrato);

        }
    });
}












function GetBuscarDatosConductores(id, cliente, FechaInicio, FechaTermino) {


    $.ajax({
        type: 'GET',
        url: "ConsultaContratos2",
        data: {
            _IdContrato: id
        },
        success: function (data) {

            var table = $("#tbladeproductos");
            var html = "<thead><tr><th>Nro Contrato</th><th>Nro  Servicio</th><th>Cliente</th><th>Servicio</th><th>Tipo Carga</th><th>Unidad Medida</th><th>Cantidad</th></thead>";


            $.each(data, function (index, value) {

                $.each(this, function (name, value) {
                    html += "<tr><td>" + value.NroContrato + "</td><td>" + value.IdPedido + "</td><td>" + value.Cliente + "</td><td>" + value.Servicio + "</td><td>" + value.TipoCarga + "</td><td>" + value.UnidadMedida + "</td><td>" + value.Cantidad + "</td></tr>";
                });
            });

            table.html(html);
            $("#txtIdContrato").val(id);
            $("#txtCliente").val(cliente);
            $("#txtFechaInicioS").val(FechaInicio);
            $("#txtFechaTerminoS").val(FechaTermino);



        }
    });
}



function getProductDetails3(id, cliente, FechaInicio, FechaTermino) {


    $.ajax({
        type: 'GET',
        url: "ConsultaContratos2",
        data: {
            _IdContrato: id
        },
        success: function (data) {

            var table = $("#tbladeproductos");
            var html = "<thead><tr><th>Nro Contrato</th><th>Nro  Servicio</th><th>Cliente</th><th>Servicio</th><th>Tipo Carga</th><th>Unidad Medida</th><th>Cantidad</th></thead>";


            $.each(data, function (index, value) {

                $.each(this, function (name, value) {
                    html += "<tr><td>" + value.NroContrato + "</td><td>" + value.IdPedido + "</td><td>" + value.Cliente + "</td><td>" + value.Servicio + "</td><td>" + value.TipoCarga + "</td><td>" + value.UnidadMedida + "</td><td>" + value.Cantidad + "</td></tr>";
                });
            });

            table.html(html);
            $("#txtIdContrato").val(id);
            $("#txtCliente").val(cliente);
            $("#txtFechaInicioS").val(FechaInicio);
            $("#txtFechaTerminoS").val(FechaTermino);



        }
    });
}



function ModificarContrato(
    _Id,
    _NumeroContrato,
    _Cliente,
    _FechaInicio,
    _FechaTermino,
    _IdEncargado,
    _Comentario,
    _Servicio,
    _IdTipoCarga,
    _IdUnidadMedida,
    _Cantidad,
    _IdSucursal,
    _ValorContrato,
    _Ruta
) {

    $("#txtidguia").val(_Guia);
    $("#txtContrato").val(_NroContrato);
    $("#txtCliente").val(Cliente);
    $("#txtServicio").val(Servicio);
    $("#txtProyeccion").val(_proyeccion);
    $("#txtFechaInicio").val(_fechaInicio);
    $("#txtFechaFin").val(_fechaFin);
    $("#txtRuta").val(_Ruta);

}



function SeleccionarServicio(
    _Servicio,
) {

    $("#txtServicio").val(_Servicio);
}




function seleccionarRuta(
    _Ruta,
    _Valor,
) {

    $("#txtRuta").val(_Ruta);
    $("#txtValor").val(_Valor);

}







function DatosGuia(
    _NroContrato, Cliente, Servicio, _proyeccion, _fechaInicio, _fechaFin, _Ruta
) {

    $("#txtidguia").val(_Guia);
    $("#txtContrato").val(_NroContrato);
    $("#txtCliente").val(Cliente);
    $("#txtServicio").val(Servicio);

}


function AsignaConductor(
    _Guia
) {
    $("#txtidguia").val(_Guia);


}




function GetBuscarDatosGasto(NroContrato, IdGuia, NumeroPedido) {


    $.ajax({
        type: 'GET',
        url: "ConsultaGasto",
        data: {
            _Contrato: NroContrato,
            _idguia: IdGuia,
            _idpedido: NumeroPedido,
        },
        success: function (data) {

            var table = $("#tblConsultaGasto");
            var html = "<thead><tr><th>Nro Contrato</th><th>Nro Guia</th><th>Nro Pedido</th><th>Nombre Gasto</th><th>N° Ticket</th><th>Fecha</th><th>Valor</th></thead>";


            $.each(data, function (index, value) {

                $.each(this, function (name, value) {
                    html += "<tr><td>" + value.Contrato + "</td><td>" + value.IdGuia + "</td><td>" + value.IdPedido + "</td><td>" + value.NombreGasto + "</td><td>" + value.NroTicket + "</td><td>" + value.Fecha + "</td><td>" + value.Valor + "</td></tr>";
                });
            });

            table.html(html);



        }
    });
}




function SeleccionarConductorGuia(
    _Id,
    _Rut,
    _Nombre
) {

    $("#txtIdConductor").val(_Id);
    $("#txtConductor").val(_Rut + " " + _Nombre);




}





function SeleccionarConductor(
    _Id,
    _Rut,
    _Nombre
) {

    $("#txtIdConductor").val(_Id);
    $("#txtConductor").val(_Rut + " " + _Nombre);


    $.ajax(
        {
            url: "ConsultarConductorDespacho",
            type: "GET",
            data: {
                _IdConductor: $("#txtIdConductor").val()
            },
            success: function (datoValorComuna) {

                var table = $("#tblDespachoConductor");
                var html = "<thead><tr><th>Nro Guia</th><th>Nro Contrato</th><th>Cliente</th><th>N°Pedido</th><th>Patente</th><th>Servicio</th><th>Vueltas</th><th>Cantidad</th><th>Camión</th><th>Seleccionar</th></thead>";

                $.each(datoValorComuna, function (index, value) {

                    $.each(this, function (name, value) {
                        html += "<tr><td>" + value.IdGuia + "</td><td>" + value.NroContrato + "</td><td>" + value.Cliente + "</td><td>" + value.NroPedido + "</td><td>" + value.Patente + "</td><td>" + value.Servicio + "</td>" + "<td>" + value.Vueltas + "</td><td>" + value.Pedido + "</td><td>" + value.TipoCamion + "</td>" + "<td><button  class='btn btn - success' type='button' data-toggle='modal' data-target='#ModalRuta' onclick='BuscarDatosProyeccion(" + value.IdGuia + "," + value.NroPedido + ")' >Despachar</button></td></td></tr>";
                    });

                });

                table.html(html);
            },
            async: true
        });

}





function RecepcionGuieExp(
    _NroContrato,
    _Guia,
    _Pedido,
    _Cliente,
    _Servicio,
    _Patente,
    PlacaNroRemolque) {
    $("#txtNroCliente").val(_NroContrato);
    $("#txtNroGuia").val(_Guia);
    $("#txtNroPedido").val(_Pedido);
    $("#txtCliente").val(_Cliente);
    $("#txtServicio").val(_Servicio);
    $("#txtPatente").val(_Patente);
    $("#txtPlacaNroRemolque").val(PlacaNroRemolque);

    ConsultaRutasClienteDespacho(_NroContrato);
}


function RendicionGuieExp(
    _NroContrato,
    _IdGuia,
    _NumeroPedido,
    _Servicio,
    _Patente,
    _PlacaNroRemolque,
    _Cliente,
    _Ruta
) {
    $("#txtNroCliente").val(_NroContrato);
    $("#txtNroGuia").val(_IdGuia);
    $("#txtNroPedido").val(_NumeroPedido);
    $("#txtServicio").val(_Servicio);
    $("#txtPatente").val(_Patente);
    $("#txtPlacaNroRemolque").val(_PlacaNroRemolque);
    $("#txtCliente").val(_Cliente);
    $("#TxtRuta").val(_Ruta);

    ConsultaRutasRendicion(_Ruta);

}




function ConsultaRutasRendicion(
    _Ruta
) {
    $("#CmbRuta").empty();
    $.ajax(
        {
            url: "BuscarGastoRutas",
            type: "POST",
            data: {
                _Ruta: _Ruta
            },
            success: function (datoValorComuna) {
                $.each(datoValorComuna, function (i, datoComuna) {


                    $("#CmbRuta").append('<option value="' + datoComuna.Plaza + '">' +
                        datoComuna.Plaza + '</option>');

                });
            },
            async: true
        });
}





function SeleccionarServicio(
    _Servicio

) {

    $("#txtServicio").val(_Servicio);

}

