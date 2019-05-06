

function EditarLinea(
    _id,
    _Codigo,
    _Nombre
) {
    $("#txtIdLinea").val(_id),
        $("#txtCodigo").val(_Codigo),
        $("#txtNombre").val(_Nombre)
}


function calc() {
    var ValorCredito = parseFloat(document.querySelector("#txtCValorCredito").value);
    var ValorAhorro = parseFloat(document.querySelector("#txtValorAhorro").value);
    var ValorVivienda = parseFloat(document.querySelector("#txtValorVivenda").value);
    var ValorSubSidio = parseFloat(document.querySelector("#txtSubsidioCVC").value);


    var sum = ValorVivienda - (ValorCredito + ValorAhorro + ValorSubSidio);
    document.getElementById("txtContadoCVC").value = sum;

}



function calcAgno() {
    var ValorAgno = parseFloat(document.querySelector("#txtPlazoCVC").value);


    var valor = ValorAgno * 12 - 1;
    var valor1 = ValorAgno * 12;

    document.getElementById("txtDividiendo1").value = 1;
    document.getElementById("txtDividiendo1Hasta").value = valor;
    document.getElementById("txtDividiendo2").value = valor1;



}


function EditarProyecto(
    _IdProyecto,
    _NombreProyecto,
    _IdComuna,
    _RutVendedor,
    _NombreVendedor,
    _Direccion,
    _Numero,
    IdEstadoCivl,
    IdProfesion

) {
    $("#txtIdProyecto").val(_IdProyecto),
        $("#txtNombre").val(_NombreProyecto),
        $("#cmbComuna").val(_IdComuna),
        $("#txtRutVendedor").val(_RutVendedor),
        $("#txtNombreVendedor").val(_NombreVendedor),
        $("#txtDirccionParticular").val(_Direccion),
        $("#txtNumeroDirec").val(_Numero),
        $("#cmbEstadoCivil").val(IdEstadoCivl),
        $("#cmbProfesion").val(IdProfesion)
}




function EditarMAlla(
    _id,
    _Codigo,
    _Nombre
) {
    $("#txtIdMalla").val(_id);
    $("#txtCodigo").val(_Codigo);
    $("#txtNombre").val(_Nombre);
}



function EditarRuta(
    _Descripcion
) {
    $("#txtCodigo").val(_Descripcion);

}




function EditarProceso(
    _Id,
    _Nombre,
    _IdTipoProceso,
    _IdTipoMalla,
    _IdLinea,
    _Indice,
    _Abrevicacion,
    _Dias
) {
    $("#txtIdProceso").val(_Id),
        $("#txtNombre").val(_Nombre),
        $("#cmbTipoProceso").val(_IdTipoProceso),
        $("#cmbMallas").val(_IdTipoMalla),
        $("#cmbLineas").val(_IdLinea),
        $("#txtIndice").val(_Indice),
        $("#txtAbrevicacion").val(_Abrevicacion),
        $("#txtDias").val(_Dias)
}


function SeleccionCliente(
    _IdCliente,
    _RutNomnre,
    _NombreCliente,
    _AppP,
    _AppMat
) {

    $("#txtIdClienteSolcitud").val(_IdCliente),
        $("#txtNombre").val(_RutNomnre),
        $("#txtCompradorCVC").val(_RutNomnre + " " + _NombreCliente + " " + _AppP + " " + _AppMat)

}





function EditarTipoCamion(
    _IdTipoCamion,
    _TipoCamion
) {
    $("#txtIdCamion").val(_IdTipoCamion),
        $("#txtTipoCamion").val(_TipoCamion)
}






function EditarPeaje(
    _id,
    _nombre,
    _Valor
) {
    $("#TxtIdPeaje").val(_id),
        $("#txtNombrePeaje").val(_nombre),
        $("#txtValor").val(_Valor)
}



function EditarSucursal(
    _Id,
    _Nombre
) {
    $("#txtIdSucursal").val(_Id),
        $("#txtSucursal").val(_Nombre)
}








function getRutaPeaje(Ruta) {


    $.ajax({
        type: 'GET',
        url: "ListadoRutaPeaje",
        data: {
            _Ruta: Ruta
        },
        success: function (data) {

            var table = $("#tbladeproductos");
            var html = "<thead><tr><th>Ruta</th><th>Plaza</th><th>Valor</th><th>Editar</th></thead>";


            $.each(data, function (index, value) {

                $.each(this, function (name, value) {
                    html += "<tr><td>" + value.Ruta + "</td><td>" + value.Plaza + "</td><td>" + value.Valor + "</td><td>" + "<td><button class='btn btn - success' type='button' data-toggle='modal' data-target='#ModalRuta'>Editar</button></td></td></tr>";
                });
            });

            table.html(html);

        }
    });
}




$(document).ready(function () {

    $(".ConsultaComuna").change(
        function (e) {

            $("#txtCiudad").empty(0);
            $("#txtRegion").empty(0);
            $.ajax(
                {
                    url: "selecionaDatoComuna",
                    type: "POST",
                    data: {
                        _IdComuna: $("#cmbComuna").val()
                    },
                    success: function (datoValorComuna) {

                        $.each(datoValorComuna, function (i, datoComuna) {

                            $("#txtCiudad").val(datoComuna.NombreCiudad);
                            $("#txtRegion").val(datoComuna.NombreRegion);
                        });
                    },
                    async: true
                });
        });






    $(".ConsultaComunaVendedor").change(
        function (e) {

            $("#txtCiudadVendedor").empty(0);
            $("#txtRegionVendedor").empty(0);
            $.ajax(
                {
                    url: "selecionaDatoComuna",
                    type: "POST",
                    data: {
                        _IdComuna: $("#cmbComuna").val()
                    },
                    success: function (datoValorComuna) {

                        $.each(datoValorComuna, function (i, datoComuna) {

                            $("#txtCiudadVendedor").val(datoComuna.NombreCiudad);
                            $("#txtRegionVendedor").val(datoComuna.NombreRegion);
                        });
                    },
                    async: true
                });
        });




    $("#TblClientes").DataTable({
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


    $("#tblRutas").DataTable({
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


    $("#TblMaestros").DataTable({
        paging: true,
        retrieve: true,
        dom: 'Bfrtip',
        buttons: [{
            text: 'Excel',
            extend: 'excel'
        },
        {
            text: 'PDF',
            extend: 'pdf'
        }
        ],
        searching: true,
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.10.11/i18n/Spanish.json",
            "lengthMenu": "Mostrar _MENU_ filas por Página",
            "zeroRecords": "Sin Resultados",
            "info": "Mostrando página _PAGE_ de _PAGES_",
            "infoEmpty": "No se han encontrado registros",
            "infoFiltered": "(Filtrando de un total de  _MAX_ registros)"
        }
    });
    $("#TblPersona").DataTable({
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


    $("#btnGrabarTipoProceso").click(function () {
        var ID = $("#txtIdTipoProceso").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaTipoProceso",
            type: "POST",
            data: { _IdTipoProceso: ID, _Nombre: $("#inputSuccess2").val() },
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



    $("#btnGrabatipoCamion").click(function () {
        var ID = $("#txtIdCamion").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaTipoCamion",
            type: "POST",
            data: { IdTipoCamion: ID, NombreTipoCamion: $("#txtTipoCamion").val() },
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




    $("#btnGrabarRutas").click(function () {
        var ID = $("#txtIdRuta").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabarRuta",
            type: "POST",
            data: {
                Id: ID,
                _Ruta: $("#txtCodigo").val(),
                _plaza: $("#cmbPlazaPaje").val(),
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

    $("#btnGrabaPlazaPeaje").click(function () {
        var ID = $("#TxtIdPeaje").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaPlazaPeaje",
            type: "POST",
            data: { idPlaza: ID, nombre: $("#txtNombrePeaje").val(), Valor: $("#txtValor").val() },
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



    $("#btnGrabaSucursal").click(function () {
        var ID = $("#txtIdSucursal").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabaSucursal",
            type: "POST",
            data: { _IdSucursal: ID, _Nombre: $("#txtSucursal").val() },
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







    $("#btnGrabarTipoPagos").click(function () {
        var ID = $("#txtIdTipoPago").val();
        if (ID != null && ID != "") {
            ID = ID;
        }
        else {
            ID = -1;
        }
        $.ajax({
            url: "GrabarTipoPago",
            type: "POST",
            data: {
                _Id: ID,
                _Nombre: $("#txtNombreTipoPago").val(),
                _Estado: 1,
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




});