using Disofi.BLL;
using Disofi.UTIL.Objetos;
using Disofi.Models.Filters;
using Disofi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Web.Helpers;

namespace Disofi.Controllers
{
    public class TamarugalMaestrosController : Controller
    {
        ControlDisofi _control = new ControlDisofi();
        public ActionResult Rutas()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                IEnumerable<ObjetoProductos> Model = _control.ListadoProductosSoftland("15");

                IEnumerable<SelectListItem> PlazaPaje = _control.ListadoProductosSoftland("16").Select(c => new SelectListItem()
                {
                    Text = c.Descripcion,
                    Value = c.Descripcion.ToString()
                }).ToList();
                ViewBag.cmbPlazaPaje = PlazaPaje;




                return View(Model);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }



        [HttpGet()]
        public ActionResult ListadoRutaPeaje(string _Ruta)
        {
            try
            {

                List<ObjetoRutaPeaje> listarclientes = _control.ListadoRutaPeaje(_Ruta);

                ViewBag.listadoRuta = listarclientes;


                return Json(new { list = listarclientes }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }

        public ActionResult TipoCamion()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                IEnumerable<ObjetoTipoCamion> model = _control.ListadoTipoCamion();


                return View(model);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }

        public ActionResult Peaje()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                IEnumerable<ObjetoTamarugalPeaje> model = _control.ListadoPeajes();


                return View(model);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }




        public ActionResult Sucursales()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                IEnumerable<ObjetoSucursal> model = _control.ListadoSucursal();


                return View(model);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }




        public ActionResult Conductor()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                IEnumerable<ObjetoConductor> model = _control.ListadoConductores();


                return View(model);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }




        public ActionResult Productos()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;

                IEnumerable<ObjetoProductos> model = _control.ListadoProductos();

                SoftLandMaestros.MaestrosSoapClient maestrosLocales = new SoftLandMaestros.MaestrosSoapClient();


                //DataSet dsProducto = new DataSet();
                //dsProducto = maestrosLocales.ListadoPorProductoAgrupado();
                //ObjetoProductoAgrupado productos = new ObjetoProductoAgrupado();
                //var _ListadoProductos = new List<ObjetoProductoAgrupado>();

                //List<WebGridColumn> columns = new List<WebGridColumn>();

                //foreach (DataTable table1 in dsProducto.Tables)
                //{


                //    foreach (DataRow dr1 in table1.Rows)
                //    {
                //        var resultadoListadoProd = new ObjetoProductoAgrupado();

                //        resultadoListadoProd.CodigoGrupo = Convert.ToString(dr1["CodSubGr"]);
                //        resultadoListadoProd.Codigo = Convert.ToString(dr1["codprod"]);
                //        resultadoListadoProd.Descripcion = Convert.ToString(dr1["desprod"]);
                //        resultadoListadoProd.Stock = Convert.ToString(dr1["stock"]);
                //        resultadoListadoProd.StockMinimo = Convert.ToString(dr1["NivMin"]);
                //        resultadoListadoProd.StockMaximo = Convert.ToString(dr1["NivMax"]);



                //        _ListadoProductos.Add(resultadoListadoProd);
                //    }
                //}
                //ViewBag.ListadoProductos = _ListadoProductos;

                return View(model);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }


        public JsonResult GrabaTipoCamion(string IdTipoCamion, string NombreTipoCamion)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(NombreTipoCamion))
                {
                    var tipocamion = new ObjetoTipoCamion()
                    {
                        Id = int.Parse(IdTipoCamion.ToString()),
                        TipoCamion = NombreTipoCamion,
                        Estado = true
                    };
                    //if (_control.SetGrabaTipoCamion(tipocamion))
                    //{
                    //    validador = 1;
                    //}
                    //else
                    //{
                    //    validador = 2;
                    //}
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




        public JsonResult GrabarRuta(string Id, string _Ruta, string _plaza)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(_Ruta))
                {
                    var destinos = new ObjetoDestinos()
                    {
                        Id = int.Parse(Id.ToString()),
                        Ruta = _Ruta,
                        Plaza = _plaza,
                        Estado = true
                    };
                    if (_control.SetGrabaRuta(destinos))
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


        public JsonResult GrabaPlazaPeaje(string idPlaza, string nombre, string Valor)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(nombre))
                {
                    var peaje = new ObjetoTamarugalPeaje()
                    {
                        Id = int.Parse(idPlaza.ToString()),
                        Nombre = nombre,
                        Valor = int.Parse(Valor),
                        Estado = true
                    };
                    if (_control.SetGrabaTamarugalPeaje(peaje))
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




        public JsonResult GrabaSucursal(string _IdSucursal, string _Nombre)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(_Nombre))
                {
                    var sucursal = new ObjetoSucursal()
                    {
                        Id = int.Parse(_IdSucursal.ToString()),
                        Nombre = _Nombre,
                        Estado = true
                    };
                    if (_control.SetGrabaTamarugalSucursal(sucursal))
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






        public ActionResult ErrorPage(int error)
        {
            return Redirect(Url.Content("~/Error/Index?error=" + error));
        }



    }
}