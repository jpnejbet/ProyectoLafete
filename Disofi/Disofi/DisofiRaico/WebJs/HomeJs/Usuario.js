$(document).ready(function () {

    $(".ConsultaUsuarioSoftalnd").change(
        function (e) {

            $.ajax(
                {
                    url: "ConsultaUsuarioSoftalnd",
                    type: "POST",
                    data: {
                        _usuario: $("#cmbUsuarioSoftland").val()
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




    $("#BtnGrabaPedido").click(function () {
        var ID = $("#txtIdPedido").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaProceso",
            type: "POST",
            data: {
                _Id: ID,
                _Nombre: $("#txtNombre").val(),
                _IdTipoProceso: $("#cmbTipoProceso").val(),
                _TiempoEstandar: $("#txtTiempoEstandar").val(),
                _IdTipoMalla: $("#cmbMallas").val(),
                _IdLinea: $("#cmbLineas").val(),
                _Indice: $("#txtIndice").val(),
                _Abrevicacion: $("#txtAbrevicacion").val(),
                _Dias: $("#txtDias").val(),
                _Estado: 1
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




    $("#BtnModificaGrabaPedido").click(function () {
        var ID = $("#txtId").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaModificacionPedido",
            type: "POST",
            data: {
                _Id: ID,
                _Operador: $("#cmbUsuarioSoftland2").val(),
                _Estado: $("#cmdEstado").val()
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




    $("#tblBodegas").DataTable({
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


    $("#tblUsuarios").DataTable({
        paging: false,
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



    $("#tblSeguimiento").DataTable({
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



    $("#tblProductosDespacho").DataTable({
        paging: true,
        retrieve: true,
        searching: true,
        scrollX: true,
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



    $("#tblProductos").DataTable({
        scrollY: "100%",
        scrollX: true,
        bPaginate: true,
        bLengthChange: true,
        bFilter: true,
        bSort: true,
        bInfo: true,
        paging: true,
        footer: true,
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.11/i18n/Spanish.json",
            "lengthMenu": "Mostrar _MENU_ filas por Página",
            "zeroRecords": "No existen Registros en el sistema",
            "info": "Mostrando página _PAGE_ de _PAGES_",
            "infoEmpty": "No se han encontrado registros",
            "infoFiltered": "(Filtrando de un total de  _MAX_ registros)"
        }
    });



    $("#divAlert").hide();
    $("#btnGrabarDatos").click(function () {
        $.ajax({
            url: "GrabaDatos",
            type: "POST",
            data: { rut: $("#inputSuccess4").val(), pass: $("#inputSuccess5").val(), nombreUsuario: $("#inputSuccess2").val(), apellidoUsuario: $("#inputSuccess3").val(), idPerfil: $("#selectPerfil").val(), Email: $("#inputSuccess6").val(), IdEmpresa: $("#Perfil").val(), IdSucursal: $("#cmbSucursal").val() },
            async: true,
            success: function (data) {
                if (data == 1) {
                    $("#btnCerrarModal").click();
                    alert("El Ingreso se ha realizado sin problemas.");
                }
                if (data == 2) {
                    alert("El usuario que intenta agregar, ya existe en la BD.");
                }
                if (data == 3) {
                    alert("El usuario que intenta agregar, ya existe en la BD.");
                }
                if (data == 4) {
                }
                if (data == 0) {
                    alert("El Rut ingresado no corresponde a un rut correcto, intentalo nuevamente.");
                }
            }
        });
    });
});

function EditaUsuarios(item) {
    $.ajax({
        url: "AutorizaUsuario",
        type: "POST",
        data: { idUsuario: item },
        async: true,
        success: function (data) {
            if (data == 0) {
                alert("No se ha podido realizar la autorización");
            }
            if (data == 1) {
                alert("Autorización realizada con exito...!!!");
                location.reload();
            }
        }
    });

}






function EditarSeguimientoPedido(
    _Id,
    _Operador,
    _Estado,
    _NombreLocal
) {
    $("#txtId").val(_Id),
        $("#cmbUsuarioSoftland").val(_Operador),
        $("#cmdEstado").val(_Estado),
        $("#txtnombreLocal").val(_NombreLocal)
}

function EditarSeguimientoPedido1(
    _Id,
    _Operador,
    _Estado,
    _NombreLocal
) {
    alert(_NombreLocal);
    $("#txtId").val(_Id),
        $("#cmbUsuarioSoftland").val(_Operador),
        $("#cmdEstado").val(_Estado),
        $("#txtNombreLocal2").val(_NombreLocal)
}







function QuitapermisoUsuarios(item) {
    $.ajax({
        url: "QuitapermisoUsuarios",
        type: "POST",
        data: { idUsuario: item },
        async: true,
        success: function (data) {
            if (data == 0) {
                alert("Error al realizar la solicitud en la BD.");
            }
            if (data == 1) {
                alert("Acción realizada con exito...!!!");
                location.reload();
            }
        }
    });
}