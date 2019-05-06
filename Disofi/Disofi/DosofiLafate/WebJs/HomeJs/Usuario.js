$(document).ready(function () {

    

     

    $(".ListadoUbicacion").change(
        function (e) {
            $("#CmbRuta").empty();
            $.ajax(
                {
                    url: "ListadoUbicacion",
                    type: "POST",
                    data: {
                        clientes: $("#CmbCliente").val()
                    },
                    success: function (datoValorComuna) {
                        $.each(datoValorComuna, function (i, datoComuna) {


                            $("#CmbRuta").append('<option value="' + datoComuna.Ubicacion + '">' +
                                datoComuna.Ubicacion + '</option>');
 

                        });
                    },
                    async: true
                });
        });








    $("#Grabar").click(function () {



        var ID = $("#txtIdOt").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }

     


        $.ajax({
            url: "GrabarOrdenAtencion",
            type: "POST",
            data: {
                _Id: ID,
                _TipoAtencion: $("#cmbTipoAtencion").val(),
                _Requemiento: $('input:radio[name=optradioR]:checked').val(),
                _TipoCliente: $('input:radio[name=optradioT]:checked').val(),
                _NombreCliente: $("#CmbCliente").val(),
                _NombreCliente1: $("#txtNombreCliente").val(),
                _NumeroContacto: $("#txtNumeroContactoCliente").val(),
                _Descripcion: $("#comment").val(),
                _UbicacionFisica: $("#txtUbicacion").val(),
                _UbicacionFisica2: $("#CmbRuta").val(),
                _Diganostico: $("#cmbDiagnostico").val(),
                _Solucion: $("#cmbSolucion").val(),
                _Responsable: $("#cmdResponsable").val(),
                _DescripcionSolucion: $("#DescriSolucion").val(),
                _FechaCierre: '',
                _Ruta: $("#CmbRuta").val(),
                _Maquina: $("#cmdMaquina").val(),
                _Modelo: $("#cmdModeloMaquina").val(),
                _TipoMaquina: $("#cmbTipoMaquina").val(),
                _Supervisor: $("#CmbSupervisor").val()


            },
            async: true,
            success: function (data) {
                if (data > 0) {

                    alert("Ha grabado correctament numero atención : " + data);

                    $("#txtIdOt").val(data);

                }
                if (data == 2) {
               //   alert("No se puede grabar el dato en la BD, intentalo nuevamente.");
                }
                if (data == 3) {
               //     alert("El nombre del parametro no puede estar vacio, no se ha realizado la operación.");
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

    $("#tblPropuestaDespacho").DataTable({
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



    $("#tblTrasapso").DataTable({
        paging: true,
        retrieve: true,
        searching: true,
        responsive: true,
        dom: 'Bfrtip',
        buttons: [
            'excel', 'csv'
        ],
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
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.11/i18n/Spanish.json",
            "lengthMenu": "Mostrar _MENU_ filas por Página",
            "zeroRecords": "No existen Registros en el sistema",
            "info": "Mostrando página _PAGE_ de _PAGES_",
            "infoEmpty": "No se han encontrado registros",
            "infoFiltered": "(Filtrando de un total de  _MAX_ registros)"
        }
    });

    $("#Maestros").DataTable({
        paging: true,
        retrieve: true,
        searching: true,
        responsive: true ,
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.11/i18n/Spanish.json",
            "lengthMenu": "Mostrar _MENU_ filas por Página",
            "zeroRecords": "No existen Registros en el sistema",
            "info": "Mostrando página _PAGE_ de _PAGES_",
            "infoEmpty": "No se han encontrado registros",
            "infoFiltered": "(Filtrando de un total de  _MAX_ registros)"
        }
    });




    $("#tblSeguimientoM").DataTable({
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
            data: { rut: $("#inputSuccess4").val(), pass: $("#inputSuccess5").val(), nombreUsuario: $("#inputSuccess2").val(), apellidoUsuario: $("#inputSuccess3").val(), idPerfil: $("#selectPerfil").val(), Email: $("#inputSuccess6").val() },
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
    $("#txtId").val(_Id),
        $("#cmbUsuarioSoftland").val(_Operador),
        $("#cmdEstado").val(_Estado),
        $("#txtNombreLocal2").val(_NombreLocal)
}



function TipoCliente(TipoCliente

) {
    var tipoC = $('input:radio[name=optradioR]:checked').val();

    var valor = TipoCliente;

    if (valor == '1') {
        $("#nombreCliente").css("display", "block");
        $("#nombreClienteUbicacion").css("display", "block");

        $("#SelCliente").css("display", "none");
        $("#SelClienteUbicacion").css("display", "none"); 



        $("#SelClienteUbicacion").val("");
        $("#nombreClienteUbicacion").val("");
        $("#CmbCliente").val("");
        $("#txtNombreCliente").val("");
 

    } else {
        $("#nombreCliente").css("display", "none"); 
        $("#nombreClienteUbicacion").css("display", "none");
        $("#SelCliente").css("display", "block"); 
        $("#SelClienteUbicacion").css("display", "block"); 


        $("#SelClienteUbicacion").val("");
        $("#nombreClienteUbicacion").val("");
        $("#CmbCliente").val("");
        $("#txtNombreCliente").val("");
    }
     


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