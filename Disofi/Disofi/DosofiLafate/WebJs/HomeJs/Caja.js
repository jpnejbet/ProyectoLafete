

function BuscarCliente(item) {

    $.ajax({
        url: "BuscarClientePorRut",
        type: 'GET',
        data: { rutCiente: $("#idRutCliente").val() },
        success: function (data) {

            $("#IdNombreCliente").val(data[0].Text);
            $("IdClinte").val(data[0].Value);

        }
    });
}

$(document).ready(function () {


    $("#btnPagoCaja").click(function () {
        $.ajax({
            url: "GrabaPago",
            type: "POST",
            data: { _rut: $("#idRutCliente").val(), _cliente: $("#IdNombreCliente").val(), _fecha: $("#single_cal1").val(), _TipoPago: $("#medioPago").val(), _Numero: $("#ListadoEmpresas").val(), _ValorNeto: $("#IdMonto").val() },
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


    $("#btnAbrirCaja").click(function () {



        $.ajax({
            url: "GrabaAperturaCaja",
            type: "POST",
            data: { IdUsuario: $("#IdUsuario").val(), empresa: $("#ListadoEmpresas21").val(), sucursal: $("#ListadoSucursales").val() },
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




    $("#btnCerrarCaja").click(function () {
        alert(2);
        $.ajax({
            url: "GrabaCerrarCaja",
            type: "POST",
            data: { IdUsuario: $("#IdUsuario").val() },
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
