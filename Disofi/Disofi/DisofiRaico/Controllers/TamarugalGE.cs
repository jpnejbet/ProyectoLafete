using Disofi.BLL;
using Disofi.UTIL.Objetos;
using Disofi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Disofi.Controllers
{
    public class TamarugalGEController : Controller
    {
        ControlDisofi _control = new ControlDisofi();
        public ActionResult CreacionContrato()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                 





                IEnumerable<SelectListItem> sucursal = _control.ListadoSucursal().Select(c => new SelectListItem()
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbSucursal = sucursal;






                IEnumerable<SelectListItem> usuario = _control.ListadoUsuarios().Select(c => new SelectListItem()
                {
                    Text = c.NombreUsuario,
                    Value = c.IdUsuario.ToString()
                }).ToList();
                ViewBag.cmbUsuario = usuario;


                IEnumerable<ObjetoProductos> Model = _control.ListadoProductosSoftland("14");
                IEnumerable<ObjetoProductos> ModelRuta1 = _control.ListadoProductosSoftland("15");

                ViewBag.ModelRuta = ModelRuta1;

                return View(Model);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }

        [HttpPost]
        public JsonResult ConsultaProductosId(string _IdProductos)
        {
            try
            {
                List<ObjetoProductos> datoValorComuna = _control.ListadoProductosId(_IdProductos).ToList();
                return Json(datoValorComuna);

            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }



        [HttpPost]
        public JsonResult BuscarRutasCliente(string _Contrato)
        {
            try
            {
                List<ObjetoDestinos> datoValorComuna = _control.BuscarRutaPorCliente(_Contrato).ToList();
                return Json(datoValorComuna);

            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }




        [HttpPost]
        public JsonResult BuscarGastoRutas(string _Ruta)
        {
            try
            {
                List<ObjetoDestinos> datoValorComuna = _control.Listado_RutasGasto(_Ruta).ToList();
                return Json(datoValorComuna);

            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }



        [HttpPost]
        public JsonResult ConsultaSucursalUsuarioId(string _IdUsuario)
        {
            try
            {
                List<ObjetoSucursal> datoValorComuna = _control.ListadoUsuariosSucursalId(_IdUsuario).ToList();
                return Json(datoValorComuna);

            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }



        [HttpGet()]
        public ActionResult ConsultaContratos(string _IdContrato)
        {
            try
            {

                List<ObjetoSeguimientoDetalleContratoGrid> listarclientes = _control.ListadoListadoSeguimientoContratoID(_IdContrato);

                ViewBag.listarclientes = listarclientes;


                return Json(new { list = listarclientes }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }









        [HttpGet()]
        public ActionResult ConsultaContratos2(string _IdContrato)
        {
            try
            {

                List<ObjetoSeguimientoDetalleContratoGrid> listarclientes = _control.TamarugalDetalleContratos2(_IdContrato);

                ViewBag.listarclientes = listarclientes;


                return Json(new { list = listarclientes }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }



        [HttpGet()]
        public ActionResult DetalleContrao(string _IdContrato)
        {
            try
            {

                List<ObjetoSeguimientoDetalleContratoGrid> listarclientes = _control.ListadoListadoSeguimientoContratoID2(_IdContrato);

                ViewBag.listarclientes = listarclientes;


                return Json(new { list = listarclientes }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }







        [HttpGet()]
        public ActionResult ConsultaGasto(string _Contrato, int _idguia, int _idpedido)
        {
            try
            {

                List<ObjetoRendicionGasto> listarclientes = _control.ListadoGasto(_Contrato, int.Parse(_idguia.ToString()), int.Parse(_idpedido.ToString()));

                ViewBag.listarclientes = listarclientes;


                return Json(new { list = listarclientes }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }







        [HttpGet()]
        public ActionResult DetalleServicioTamarugalSoloId(string _IdContrato)
        {
            try
            {

                List<ObjetoSeguimientoDetalleContratoGrid> listarDetalleServicio = _control.ListadoListadoSeguimientoContratoID(_IdContrato);

                ViewBag.listarclientes = listarDetalleServicio;


                return Json(new { list = listarDetalleServicio }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }


        [HttpGet()]
        public ActionResult DetalleServicioTamarugalId(string _idguia, string _numeroPedido)
        {
            try
            {
                Session["_idguiaExpedicion"] = _idguia;
                Session["_numeroPedidoExpe"] = _numeroPedido;


                List<ObjetoSeguimientoDetalleContratoGrid> listarDetalleServicio = _control.DetalleServicioTamarugalId(_idguia, _numeroPedido);

                ViewBag.listarclientes = listarDetalleServicio;


                return Json(new { list = listarDetalleServicio }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }


        public ActionResult SeguimientoContrato()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoSeguimientoContrato> model = _control.ListadoListadoSeguimientoContrato();



                IEnumerable<SelectListItem> destino = _control.ListadoDestinoDestino().Select(c => new SelectListItem()
                {
                    Text = c.Ruta,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbDestino = destino;

                IEnumerable<SelectListItem> cargas = _control.ListadoCargas().Select(c => new SelectListItem()
                {
                    Text = c.TipoCarga,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbcargas = cargas;


                IEnumerable<SelectListItem> cliente = _control.ListadoClienteContratoTamarugal().Select(c => new SelectListItem()
                {
                    Text = c.NombreCliente,
                    Value = c.Id.ToString()
                }).ToList();


                ViewBag.CmbCliente = cliente;



                IEnumerable<SelectListItem> productos = _control.ListadoProductos().Select(c => new SelectListItem()
                {
                    Text = c.Descripcion,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmdProdutos = productos;


                IEnumerable<SelectListItem> usuario = _control.ListadoUsuarios().Select(c => new SelectListItem()
                {
                    Text = c.NombreUsuario,
                    Value = c.IdUsuario.ToString()
                }).ToList();
                ViewBag.cmbUsuario = usuario;


                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }


        public ActionResult CreacionPedido()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;



                IEnumerable<SelectListItem> cliente = _control.ListadoClienteContratoTamarugal().Select(c => new SelectListItem()
                {
                    Text = c.NombreCliente,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.CmbCliente = cliente;



                IEnumerable<SelectListItem> conductor = _control.ListadoConductores().Select(c => new SelectListItem()
                {
                    Text = c.Conductor,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbConductor = conductor;



                IEnumerable<SelectListItem> camion = _control.ListadoTipoCamion().Select(c => new SelectListItem()
                {
                    Text = c.TipoCamion,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbCamion = camion;


                DateTime fechatemp = DateTime.Today;



                DateTime fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
                DateTime fecha2;

                if (fechatemp.Month + 1 < 13)
                { fecha2 = new DateTime(fechatemp.Year, fechatemp.Month + 1, 1).AddDays(-1); }
                else
                { fecha2 = new DateTime(fechatemp.Year + 1, 1, 1).AddDays(-1); }


                ViewBag.FechaIni = fecha1.ToShortDateString();
                ViewBag.FechaFin = fecha2.ToShortDateString();



                IEnumerable<ObjetoSeguimientoDetalleContratoGrid> model = _control.TamarugalDetalleContratos(datosUsuario.IdUsuario.ToString());


                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }


        public ActionResult GuiaExpe()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                IEnumerable<SelectListItem> destino = _control.ListadoDestinoDestino().Select(c => new SelectListItem()
                {
                    Text = c.Ruta,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbDestino = destino;


                IEnumerable<SelectListItem> cliente = _control.ListadoClienteContratoTamarugal().Select(c => new SelectListItem()
                {
                    Text = c.NombreCliente,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.CmbCliente = cliente;



                IEnumerable<SelectListItem> conductor = _control.ListadoConductores().Select(c => new SelectListItem()
                {
                    Text = c.Conductor,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbConductor = conductor;



                IEnumerable<SelectListItem> camion = _control.ListadoTipoCamion().Select(c => new SelectListItem()
                {
                    Text = c.TipoCamion,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbCamion = camion;

                IEnumerable<ObjetoSeguimientoDetalleContratoGrid> model = _control.TamarugalDetalleContratos(datosUsuario.IdUsuario.ToString());


                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }



        public ActionResult Planificacion()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoPedido> model = _control.ListadoPedido(datosUsuario.IdUsuario.ToString());




                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }





        public ActionResult GuiaExpedicion(string IdPedido)
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoPedido> model = _control.ListadoPedidoId(IdPedido);

                foreach (ObjetoPedido ot in model)
                {

                    ViewBag.Contrato = ot.NroContrato;
                    ViewBag.Pedido = ot.NroPedido;
                    ViewBag.Cliente = ot.Cliente;
                    ViewBag.Servicio = ot.Servicio;
                    ViewBag.FechaInicio = ot.FechaInicio.ToShortDateString();
                    ViewBag.FechaFin = ot.FechaFin.ToShortDateString();
                    ViewBag.IdContrato = ot.IdContrato;
                    ViewBag.IdServicio = ot.IdServicio;
                    ViewBag.NroPedido = ot.NroPedido;
                    ViewBag.IdPedido = ot.Id;

                }


                IEnumerable<ObjetoConductor> _conductores = _control.ListadoConductores();
                ViewBag.ListadoConductores = _conductores;



                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }



        public ActionResult DespachoConductor()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                IEnumerable<SelectListItem> conductor = _control.ListadoConductores().Select(c => new SelectListItem()
                {
                    Text = c.Conductor,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbConductor = conductor;


                IEnumerable<SelectListItem> cmdruta = _control.BuscarRutaPorCliente("11").Select(c => new SelectListItem()
                {
                    Text = c.Ruta.ToString(),
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.CmbRuta = cmdruta;


                IEnumerable<ObjetoConductor> _conductores = _control.ListadoConductores();
                ViewBag.ListadoConductores = _conductores;





                return View();
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }





        public ActionResult Despacho(string _IdConductor, string _Conductor)
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                IEnumerable<SelectListItem> conductor = _control.ListadoConductores().Select(c => new SelectListItem()
                {
                    Text = c.Conductor,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbConductor = conductor;


                IEnumerable<SelectListItem> cmdruta = _control.BuscarRutaPorCliente("11").Select(c => new SelectListItem()
                {
                    Text = c.Ruta.ToString(),
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.CmbRuta = cmdruta;


                IEnumerable<ObjetoConductor> _conductores = _control.ListadoConductores();
                ViewBag.ListadoConductores = _conductores;

                ViewBag.Conductor = _Conductor;


                IEnumerable<ObjetoGuiaExpedicionGrid> ListaDespacho = _control.ListadoProgramacionGE(_IdConductor);

                ViewBag.ListadoDespachos = ListaDespacho;


                List<ObjetoGuiaExpedicionGrid> Model = _control.ListadoGuiaExpedicionIdConductor(int.Parse(_IdConductor.ToString()));


                return View(Model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }




        //public ActionResult Programacion()
        //{
        //    try
        //    {
        //        var datosUsuario = new ObjetoLogin();
        //        datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
        //        ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;

        //        IEnumerable<SelectListItem> camion = _control.ListadoTipoCamion().Select(c => new SelectListItem()
        //        {
        //            Text = c.TipoCamion,
        //            Value = c.Id.ToString()
        //        }).ToList();
        //        ViewBag.cmbCamion = camion;



        //        return View();
        //    }
        //    catch (Exception ex)
        //    {
        //        new CapturaExcepciones(ex);
        //        return ErrorPage(1001);
        //        throw;
        //    }
        //}




        public ActionResult Rendicion()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoRecepcionGuia> model = _control.ListadoRendicion();

                IEnumerable<SelectListItem> peaje = _control.ListadoPeajes().Select(c => new SelectListItem()
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbPeaje = peaje;



                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }






        public ActionResult RecepcionConductor()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;



                IEnumerable<ObjetoConductor> _conductores = _control.ListadoConductores();
                ViewBag.ListadoConductores = _conductores;




                return View();
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }


        public ActionResult RendicionConductor()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;



                IEnumerable<ObjetoConductor> _conductores = _control.ListadoConductores();
                ViewBag.ListadoConductores = _conductores;




                return View();
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }





        public ActionResult Recepcion()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoRecepcionGuia> model = _control.ListadoGuiaRecepcion();

                IEnumerable<SelectListItem> peaje = _control.ListadoPeajes().Select(c => new SelectListItem()
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString()
                }).ToList();
                ViewBag.cmbPeaje = peaje;



                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }




        public ActionResult InformesContratos()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoInforme> model = _control.ListadaoSabanaDatos();


                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }






        public ActionResult GrabaTamarugalClienteContrato(
                    string _Id,
                    string _NumeroContrato,
                    string _Cliente,
                    string _FechaInicio,
                    string _FechaTermino,
                    string _Comentario,
                    string _IdSucursal,
                    string _ValorContrato,
                    string _Moneda,
                    string _Servicio,
                    string _Ruta,
                    string _IdUnidadMedida,
                    string _Cantidad,
                    string _ValorServicio,
                    string _Detalle)

        {
            int validador = 0;
            int idcontratoc = 0;
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];


                DateTime FechaInicio = DateTime.Parse((_FechaInicio.Split('/')[1].ToString() + "-" + _FechaInicio.Split('/')[0].ToString() + "-" + _FechaInicio.Split('/')[2]).ToString());
                DateTime FechaTermino = DateTime.Parse((_FechaTermino.Split('/')[1].ToString() + "-" + _FechaTermino.Split('/')[0].ToString() + "-" + _FechaTermino.Split('/')[2]).ToString());

                if (!string.IsNullOrEmpty(_Cliente))
                {
                    var clienteContrato = new ObjetoSeguimientoContrato()
                    {
                        Id = int.Parse(_Id.ToString()),
                        Cliente = _Cliente,
                        NroContrato = _NumeroContrato,
                        FechaInicio = FechaInicio,
                        FechaTermino = FechaTermino,
                        IdEncargado = int.Parse(datosUsuario.IdUsuario.ToString()),
                        Comentario = _Comentario,
                        IdSucursal = int.Parse(_IdSucursal),
                        Moneda = _Moneda,
                        Valor = decimal.Parse(_ValorContrato)
                    };

                    idcontratoc = _control.SetGrabaTamarugalClienteContrato(clienteContrato);
                    if (_Cantidad == "")
                    {
                        _Cantidad = "0";
                    }
                    if (idcontratoc >= 0)
                    {
                        GrabaTamarugalDetalleContrato("-1",
                                                       idcontratoc.ToString(),
                                                      _Ruta,
                                                     _Servicio,
                                                     _ValorServicio,
                                                     _IdUnidadMedida,
                                                     _Cantidad,
                                                     _Detalle
                            );

                        validador = 1;
                    }
                    else
                    {
                        validador = 2;
                    }
                }
                else
                {
                    validador = 3;
                }


            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                validador = -1;
                throw;
            }

            return (ActionResult)this.Json((object)idcontratoc);
        }



        public JsonResult GrabaTamarugalDetalleContrato(string _Id,
                    string _IdContrato,
                    string _Ruta,
                    string _Servicio,
                    string _Valor,
                    string _UnidadMedida,
                    string _Cantidad,
                    string _Detalle)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(_IdContrato))
                {
                    var clienteContrato = new ObjetoSeguimientoDetalleContrato()
                    {
                        Id = int.Parse(_Id.ToString()),
                        IdContrato = int.Parse(_IdContrato.ToString()),
                        Ruta = _Ruta.ToString(),
                        Servicio = _Servicio,
                        Valor = decimal.Parse(_Valor.ToString()),
                        UnidadMedida = _UnidadMedida,
                        Cantidad = decimal.Parse(_Cantidad.ToString()),
                        Detalle = _Detalle
                    };
                    if (_control.SetGrabaTamarugalDetalleContrato(clienteContrato))
                    {
                        validador = 1;
                    }
                    else
                    {
                        validador = 2;
                    }
                }
                else
                {
                    validador = 3;
                }
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                validador = -1;
                throw;
            }

            return (Json(validador));
        }



        public ActionResult GrabaDatosGuiaExpedicion(string _Id, string _IdContrato, string _idServicio, string _IdConductor, string _NumeroPedido, string _IdPedido)
        {
            var validador = 0;
            int idcontratoc = 0;
            try
            {

                var guia = new ObjetoGuiaExpedicion()
                {
                    Id = int.Parse(_Id),
                    IdContrato = int.Parse(_IdContrato),
                    IdServicio = int.Parse(_idServicio),
                    IdConductor = int.Parse(_IdConductor),
                    NroPedido = int.Parse(_NumeroPedido),
                    IdPedido = int.Parse(_IdPedido)
                };


                idcontratoc = _control.SetGrabaTamarugalGuiaExpedicion(guia);




                return (ActionResult)this.Json((object)idcontratoc);


                ///  Pdf();
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                validador = -1;
                throw;
            }

            return (Json(validador));
        }


        public ActionResult GrabaDatosPedido(string _Id,
            string _IdContrato,
            string _IdServicio,
            string _NroPedido,
            string _Cliente,
            string _Ruta,
            string _FechaInicio,
            string _FechaFin,
            string _Cantidad,
            string _UnidadMedida,
            string _Estado)
        {


            //_FechaInicio = "21-01-2019";
            //_FechaFin = "31-01-2019";



            DateTime FechaInicio = DateTime.Parse((_FechaInicio.Split('/')[1].ToString() + "-" + _FechaInicio.Split('/')[0].ToString() + "-" + _FechaInicio.Split('/')[2]).ToString());
            DateTime FechaTermino = DateTime.Parse((_FechaFin.Split('/')[1].ToString() + "-" + _FechaFin.Split('/')[0].ToString() + "-" + _FechaFin.Split('/')[2]).ToString());


            var validador = 0;
            int idpedido = 0;
            try
            {
                if (!string.IsNullOrEmpty(_IdContrato.ToString()))
                {
                    var pedido = new ObjetoPedido()
                    {
                        Id = int.Parse(_Id),
                        IdContrato = int.Parse(_IdContrato),
                        IdServicio = int.Parse(_IdServicio),
                        Cliente = _Cliente,
                        Ruta = _Ruta,
                        FechaInicio = FechaInicio,
                        FechaFin = FechaTermino,
                        Cantidad = _Cantidad,
                        UnidadMedida = _UnidadMedida,
                        Estado = "Activo"
                    };


                    idpedido = _control.SetGrabaTamarugalPedido(pedido);



                }
                else
                {
                    validador = 3;
                }
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                validador = -1;
                throw;
            }

            return (ActionResult)this.Json((object)idpedido);
        }



        public JsonResult GrabarRecepcionGuia(
                        string _Id,
                        string _Patente,
                        string _PlacaNroRemolque,
                        string _RutEmisor,
                        string _NroGuiaDespachoCliente,
                        string _FechaEmision,
                        string _Toneladas,
                        string _FechaTimbre,
                        string _Comentario,
                        string _NumeroPedido)
        {
            var validador = 0;
            try

            {
                DateTime FechaInicio = DateTime.Parse((_FechaEmision.Split('/')[1].ToString() + "-" + _FechaEmision.Split('/')[0].ToString() + "-" + _FechaEmision.Split('/')[2]).ToString());
                DateTime FechaTermino = DateTime.Parse((_FechaTimbre.Split('/')[1].ToString() + "-" + _FechaTimbre.Split('/')[0].ToString() + "-" + _FechaTimbre.Split('/')[2]).ToString());




                _control.SetActualizaGuia(
                         _Id,
                         _Patente,
                         _PlacaNroRemolque,
                         _RutEmisor,
                         _NroGuiaDespachoCliente,
                         FechaInicio,
                         _Toneladas,
                         FechaTermino,
                         _Comentario,
                         _NumeroPedido);


                validador = 1;

            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                validador = -1;
                throw;
            }

            return (Json(validador));
        }




        public JsonResult GrabarDespacho(
                                string _Id,
                                string _IdGuiaExpedicion,
                                string _NumeroPedido,
                                string _NroContrato,
                                string _IdConductor,
                                string _Cliente,
                                string _Servicio,
                                string _Ruta,
                                string _Cantidad,
                                string _Vueltas,
                                string _Patente,
                                string _NroRemolque,
                                string _Estado)
        {
            var validador = 0;
            try

            {

                var guia = new ObjetoGuiaDetalleExpedicion()
                {
                    Id = int.Parse(_Id),
                    IdGuia = int.Parse(_IdGuiaExpedicion),
                    NroPedido = int.Parse(_NumeroPedido),
                    NroContrato = _NroContrato,
                    IdConductor = int.Parse(_IdConductor),
                    Cliente = _Cliente,
                    Servicio = _Servicio,
                    Ruta = _Ruta,
                    Cantidad = _Cantidad,
                    Vueltas = int.Parse(_Vueltas),
                    Patente = _Patente,
                    Remolque = _NroRemolque,
                    Estado = "Despachado"
                };


                _control.SetGrabaTamarugalDetalleGuiaExpedicion(guia);
                validador = 1;

            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                validador = -1;
                throw;
            }

            return (Json(validador));
        }



        public JsonResult GrabaGasto(string _Id, string _IdContrato, string _idGuia, string _Idpedido, string _IdGasto, string _valor, string _nummeroTicket, string _fecha)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(_IdContrato.ToString()))
                {
                    var gasto = new ObjetoRendicionGasto()
                    {
                        Id = int.Parse(_Id),
                        Contrato = _IdContrato,
                        IdGuia = int.Parse(_idGuia),
                        IdPedido = int.Parse(_Idpedido),
                        Gasto = _IdGasto,
                        Valor = _valor,
                        NroTicket = _nummeroTicket,
                        Fecha = _fecha
                    };
                    if (_control.SetGrabaGasto(gasto))
                    {
                        validador = 1;
                    }
                    else
                    {
                        validador = 2;
                    }
                }
                else
                {
                    validador = 3;
                }
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                validador = -1;
                throw;
            }

            return (Json(validador));
        }






        public ActionResult Pdf(string idguia, string _numeroPedido)
        {
            ControllerContext context = this.ControllerContext;
            string partialViewName = "PDF";

            //   SendCorreoSolitaModificación


            //EnvioMail correo = new EnvioMail();
            //correo.SendCorreoSolitaModificación("Esto demo productos pendientes");

            //     List<ObjetoOrdenTrabajoImprimir> listadoOrden = _control.ListadoImprimeOT(int.Parse(numeroOrden.ToString()));

            //string idguia = Session["_idguiaExpedicion"].ToString();
            //string _numeroPedido = Session["_numeroPedidoExpe"].ToString();


            List<ObjetoSeguimientoDetalleContratoGrid> listado = _control.DetalleServicioTamarugalId(idguia, _numeroPedido);

            string NroGuia = "";
            string NumeroPedido = "";
            string NumeroContrato = "";
            string Cliente = "";
            string Servicio = "";
            string Conductor = "";
            string Camion = "";
            string Patente = "";
            string PlacaRemolque = "";
            string Ruta = "";
            string Cantidad = "";
            string Vueltas = "";
            string IdConductor = "";



            foreach (var item in listado)
            {

                NroGuia = item.NroGuia.ToString();
                NumeroPedido = item.NroPedido.ToString();
                NumeroContrato = item.NroContrato.ToString();
                Cliente = item.Cliente.ToString();
                Servicio = item.Servicio.ToString();
                Conductor = item.Conductor.ToString();

                Patente = item.Patente.ToString();
                PlacaRemolque = item.PlacaRemolque.ToString();
                Ruta = item.Ruta.ToString();
                Cantidad = item.CantidadPedido.ToString();

                //   IdConductor = item.IdConductor.ToString();
            }


            //var DetalleGuia = new ObjetoGuiaDetalleExpedicion()
            //{
            //    Id = -1,
            //    IdGuia = int.Parse(NroGuia),
            //    NroPedido = int.Parse(NumeroPedido),
            //    IdConductor = int.Parse(IdConductor),
            //    Ruta = Ruta,
            //    Servicio = Servicio,
            //    Cliente = Cliente
            //};


            //_control.SetGrabaTamarugalDetalleGuiaExpedicion(DetalleGuia);


            //byte[] buf = null;
            //MemoryStream pdfTemp = new MemoryStream();
            //ViewEngineResult result = ViewEngines.Engines.FindPartialView
            // (context, partialViewName);

            //if (result.View != null)
            //{



            string filePath = null;
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF");
            //   filePath = "D:\\pdf\\File\\";
            filePath = "E:\\pdf\\File\\";
            var doc = new Document(new iTextSharp.text.Rectangle(595f, 842f));
            string filename = filePath + NroGuia + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString() + DateTime.Today.Minute.ToString() + DateTime.Today.Hour.ToString() + DateTime.Today.Second.ToString() + DateTime.Today.Millisecond.ToString() + ".pdf";
            string nombreArchivo = NroGuia + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString() + DateTime.Today.Minute.ToString() + DateTime.Today.Hour.ToString() + DateTime.Today.Second.ToString() + DateTime.Today.Millisecond.ToString() + ".pdf";
            PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));




          ////  Document doc = new Document();
          //  iTextSharp.text.pdf.PdfWriter writer =
          //    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, pdfTemp);
          //  writer.CloseStream = false;
            doc.Open();



            //Image gif = Image.GetInstance("D:\\pdf\\IMAGENES\\home_11_logo.png");
            Image gif = Image.GetInstance("E:\\pdf\\IMAGENES\\home_11_logo.png");
            gif.Alignment = Element.ALIGN_LEFT;


            Rectangle fondo1 = new Rectangle(20, 705, 580, 705);
            fondo1.BorderWidthLeft = 0.1f;
            fondo1.BorderWidthRight = 0.1f;
            fondo1.BorderWidthTop = 0.1f;
            fondo1.BorderWidthBottom = 0.1f;


            Paragraph titulo = new Paragraph("GUIA DE EXPEDICIÓN N° : " + NroGuia.ToString());
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Font.Size = 14;

            Rectangle fondo2 = new Rectangle(20, 680, 580, 300);
            fondo2.BorderWidthLeft = 0.1f;
            fondo2.BorderWidthRight = 0.1f;
            fondo2.BorderWidthTop = 0.1f;
            fondo2.BorderWidthBottom = 0.1f;


            doc.Add(gif);
            doc.Add(titulo);

            doc.Add(fondo1);
            doc.Add(fondo2);



            doc.Add(new Paragraph(Environment.NewLine + Environment.NewLine));



            Paragraph linea0 = new Paragraph("Número Pedido : " + NumeroPedido.ToString(), FontFactory.GetFont("Calibri", 10, 1));
            Paragraph linea1 = new Paragraph("Número Contrato : " + NumeroContrato.ToString(), FontFactory.GetFont("Calibri", 10, 1));
            Paragraph linea2 = new Paragraph("Cliente : " + Cliente.ToString(), FontFactory.GetFont("Calibri", 10, 1));
            Paragraph linea3 = new Paragraph("Servicio : " + Servicio.ToString(), FontFactory.GetFont("Calibri", 10, 1));
            Paragraph linea4 = new Paragraph("Conductor : " + Conductor.ToString(), FontFactory.GetFont("Calibri", 10, 1));
            Paragraph linea5 = new Paragraph("Patente : " + Patente.ToString(), FontFactory.GetFont("Calibri", 10, 1));
            Paragraph linea6 = new Paragraph("Placa  Nro Remolque: " + PlacaRemolque.ToString(), FontFactory.GetFont("Calibri", 10, 1));
            Paragraph linea7 = new Paragraph("Ruta : " + Ruta.ToString(), FontFactory.GetFont("Calibri", 10, 1));
            Paragraph linea8 = new Paragraph("Cantidad Transportar : " + Cantidad.ToString() + "                 N°Vuelta  : " + Vueltas.ToString(), FontFactory.GetFont("Calibri", 10, 1));



            doc.Add(linea0);

            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(linea1);

            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(linea2);

            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(linea3);

            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(linea4);

            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(linea5);

            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(linea6);

            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(linea7);

            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(linea8);


            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(new Paragraph(Environment.NewLine));




            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(new Paragraph(Environment.NewLine));
            doc.Add(new Paragraph(Environment.NewLine));



            doc.Close();

            try
            {

                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                return File(fs, "application/pdf");

             }
            catch (Exception ex)
            {

                ex.ToString();

          
                throw;
            }

         }




        public JsonResult GrabaDatosActualizaConductor(string idguia, string idconductor, string Ruta, string IdCamion, string Vueltas, string Patente, string PlacaNroRemolque)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(Patente.ToString()))
                {

                    if (_control.SetActualizaConductor(idguia, idconductor, "", IdCamion, Vueltas, Patente, PlacaNroRemolque))
                    {
                        validador = 1;
                        //       ReportSample();
                    }
                    else
                    {
                        validador = 2;
                    }

                }



                return (Json(validador));



            }
            catch (Exception ex)
            {

                new CapturaExcepciones(ex);
                validador = -1;
                throw;
            }


        }


        public JsonResult GrabaDatos(string rut, string pass, string nombreUsuario, string apellidoUsuario, int idPerfil, string servidor, string dominio, string alias, string empresa)
        {
            var usuario = new ObjetoUsuarios();
            var validador = 0;
            if (!string.IsNullOrEmpty(rut))
            {
                if (ValidaRut.DigitoVerificador(rut))
                {
                    usuario.RutUsuario = rut;
                    usuario.Pass = HashMd5.GetMD5(pass);
                    usuario.NombreUsuario = string.Concat(nombreUsuario, " ", apellidoUsuario);
                    usuario.IdPerfil = idPerfil;
                    usuario.Servidor = servidor;
                    usuario.Dominio = dominio;
                    usuario.Alias = alias;
                    usuario.Empresa = empresa;

                    if (_control.GetVerificaUsuario(rut))
                    {
                        validador = 2;
                    }
                    else
                    {
                        if (_control.SetGrabaUsuario(usuario))
                        {
                            validador = 1;
                        }
                    }
                }
                else
                {
                    validador = 3;
                }
            }
            else
            {
                validador = 4;
            }
            //, JsonRequestBehavior.AllowGet --- solo si se usa metodo GET
            return (Json(validador));
        }



        public ActionResult ErrorPage(int error)
        {
            return Redirect(Url.Content("~/Error/Index?error=" + error));
        }



    }
}