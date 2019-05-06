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
using OfficeOpenXml;  
using Disofi.BLL;
using DisofiLafete.MaestrosSoapClient;

namespace Disofi.Controllers
{
    public class LafeteController : Controller
    {
        ControlDisofi _control = new ControlDisofi();
        public ActionResult PropuestaDespacho()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                MaestrosSoapClient maestrosLocales = new MaestrosSoapClient();

                DataSet ds = new DataSet();
                ds = maestrosLocales.ListadoBodega();

                ObjetoBodega bodega = new ObjetoBodega();
                var _ListadoBodega = new List<ObjetoBodega>();
                List<SelectListItem> list = new List<SelectListItem>();

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    { 
                        list.Add(new SelectListItem()
                        {
                            Text = Convert.ToString(dr["DesBode"]),
                            Value = Convert.ToString(dr["CodBode"])
                        });
                    }
                }
                ViewBag.cmbBodega = list;
                DataSet dsProducto = new DataSet();
                dsProducto = maestrosLocales.ListadoProductos();
                ObjetoProductoLocales productos = new ObjetoProductoLocales();
                var _ListadoProductos = new List<ObjetoProductoLocales>();
                double val1;
                foreach (DataTable table1 in dsProducto.Tables)
                {
                    foreach (DataRow dr1 in table1.Rows)
                    {
                        val1 = 0;
                        var resultadoListadoProd = new ObjetoProductoLocales();


                        resultadoListadoProd.Codigo = Convert.ToString(dr1["codprod"]);
                        resultadoListadoProd.Descripcion = Convert.ToString(dr1["Descripcion"]);
                        resultadoListadoProd.AEROPUERTO_INTERNACIONAL = Convert.ToString(dr1["AEROPUERTO INTERNACIONAL"]);
                        resultadoListadoProd.AEROPUERTO_NACIONAL = Convert.ToString(dr1["AEROPUERTO NACIONAL"]);
                        resultadoListadoProd.ALTO_LAS_CONDES = Convert.ToString(dr1["ALTO LAS CONDES"]);
                        resultadoListadoProd.ANGAMOS = Convert.ToString(dr1["ANGAMOS"]);
                        resultadoListadoProd.ANTOFAGASTA = Convert.ToString(dr1["ANTOFAGASTA"]);
                        resultadoListadoProd.ARICA = Convert.ToString(dr1["ARICA"]);
                        resultadoListadoProd.BIO_BIO = Convert.ToString(dr1["BIO-BIO"]);
                        resultadoListadoProd.CACHAGUA = Convert.ToString(dr1["CACHAGUA"]);
                        resultadoListadoProd.CALAMA = Convert.ToString(dr1["CALAMA"]);
                        resultadoListadoProd.CASA_COSTANERA = Convert.ToString(dr1["CASA COSTANERA"]);
                        resultadoListadoProd.COSTANERA_CENTER = Convert.ToString(dr1["COSTANERA CENTER"]);
                        resultadoListadoProd.EL_TREBOL = Convert.ToString(dr1["EL TREBOL"]);
                        resultadoListadoProd.EMPORIO_FALABELLA = Convert.ToString(dr1["EMPORIO FALABELLA"]);
                        resultadoListadoProd.FLORIDA_CENTER = Convert.ToString(dr1["FLORIDA CENTER"]);
                        resultadoListadoProd.ISIDORA_GOYENECHEA = Convert.ToString(dr1["ISIDORA GOYENECHEA"]);
                        resultadoListadoProd.LA_DEHESA = Convert.ToString(dr1["LA DEHESA"]);
                        resultadoListadoProd.LA_REINA = Convert.ToString(dr1["LA REINA"]);
                        resultadoListadoProd.LA_SERENA = Convert.ToString(dr1["LA SERENA"]);
                        resultadoListadoProd.LAS_BRISAS = Convert.ToString(dr1["LAS BRISAS"]);
                        resultadoListadoProd.LOS_DOMINICOS = Convert.ToString(dr1["LOS DOMINICOS"]);
                        resultadoListadoProd.LOS_TRAPENSES = Convert.ToString(dr1["LOS TRAPENSES"]);
                        resultadoListadoProd.MAITENCILLO = Convert.ToString(dr1["MAITENCILLO"]);
                        resultadoListadoProd.MONTEMAR = Convert.ToString(dr1["MONTEMAR"]);
                        resultadoListadoProd.NUEVA_YORK = Convert.ToString(dr1["NUEVA YORK"]);
                        resultadoListadoProd.PARQUE_ARAUCO = Convert.ToString(dr1["PARQUE ARAUCO"]);
                        resultadoListadoProd.PLAZA_EGANA = Convert.ToString(dr1["PLAZA EGAÑA"]);
                        resultadoListadoProd.PROVIDENCIA = Convert.ToString(dr1["PROVIDENCIA"]);
                        resultadoListadoProd.PUERTO_VARAS = Convert.ToString(dr1["PUERTO VARAS"]);
                        resultadoListadoProd.PUNTA_ARENAS = Convert.ToString(dr1["PUNTA ARENAS"]);
                        resultadoListadoProd.RANCAGUA = Convert.ToString(dr1["RANCAGUA"]);
                        resultadoListadoProd.SANTO_DOMINGO = Convert.ToString(dr1["SANTO DOMINGO"]);
                        resultadoListadoProd.TALCA = Convert.ToString(dr1["TALCA"]);
                        resultadoListadoProd.TEMUCO = Convert.ToString(dr1["TEMUCO"]);
                        resultadoListadoProd.VALDIVIA = Convert.ToString(dr1["VALDIVIA"]);
                        resultadoListadoProd.VINA_6_PONIENTE = Convert.ToString(dr1["VIÑA 6 PONIENTE"]);
                        resultadoListadoProd.VINA_DEL_MAR = Convert.ToString(dr1["VIÑA DEL MAR"]);
                        resultadoListadoProd.VITACURA = Convert.ToString(dr1["VITACURA"]);
                        resultadoListadoProd.ZAPALLAR = Convert.ToString(dr1["ZAPALLAR"]);





                        if (dr1["AEROPUERTO INTERNACIONAL"].ToString() == "")
                        {
                            val1 = 0;
                        }
                        else
                        {
                            val1 = val1 + double.Parse(dr1["AEROPUERTO INTERNACIONAL"].ToString());
                        }
                        if (dr1["AEROPUERTO NACIONAL"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["AEROPUERTO NACIONAL"].ToString()); }
                        if (dr1["ALTO LAS CONDES"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["ALTO LAS CONDES"].ToString()); }
                        if (dr1["ANGAMOS"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["ANGAMOS"].ToString()); }
                        if (dr1["ANTOFAGASTA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["ANTOFAGASTA"].ToString()); }
                        if (dr1["ARICA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["ARICA"].ToString()); }
                        if (dr1["BIO-BIO"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["BIO-BIO"].ToString()); }
                        if (dr1["CACHAGUA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["CACHAGUA"].ToString()); }
                        if (dr1["CALAMA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["CALAMA"].ToString()); }
                        if (dr1["CASA COSTANERA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["CASA COSTANERA"].ToString()); }
                        if (dr1["COSTANERA CENTER"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["COSTANERA CENTER"].ToString()); }
                        if (dr1["EL TREBOL"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["EL TREBOL"].ToString()); }
                        if (dr1["EMPORIO FALABELLA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["EMPORIO FALABELLA"].ToString()); }
                        if (dr1["FLORIDA CENTER"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["FLORIDA CENTER"].ToString()); }
                        if (dr1["ISIDORA GOYENECHEA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["ISIDORA GOYENECHEA"].ToString()); }
                        if (dr1["LA DEHESA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["LA DEHESA"].ToString()); }
                        if (dr1["LA REINA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["LA REINA"].ToString()); }
                        if (dr1["LA SERENA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["LA SERENA"].ToString()); }
                        if (dr1["LAS BRISAS"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["LAS BRISAS"].ToString()); }
                        if (dr1["LOS DOMINICOS"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["LOS DOMINICOS"].ToString()); }
                        if (dr1["LOS TRAPENSES"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["LOS TRAPENSES"].ToString()); }
                        if (dr1["MAITENCILLO"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["MAITENCILLO"].ToString()); }
                        if (dr1["MONTEMAR"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["MONTEMAR"].ToString()); }
                        if (dr1["NUEVA YORK"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["NUEVA YORK"].ToString()); }
                        if (dr1["PARQUE ARAUCO"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["PARQUE ARAUCO"].ToString()); }
                        if (dr1["PLAZA EGAÑA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["PLAZA EGAÑA"].ToString()); }
                        if (dr1["PROVIDENCIA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["PROVIDENCIA"].ToString()); }
                        if (dr1["PUERTO VARAS"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["PUERTO VARAS"].ToString()); }
                        if (dr1["PUNTA ARENAS"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["PUNTA ARENAS"].ToString()); }
                        if (dr1["RANCAGUA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["RANCAGUA"].ToString()); }
                        if (dr1["SANTO DOMINGO"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["SANTO DOMINGO"].ToString()); }
                        if (dr1["TALCA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["TALCA"].ToString()); }
                        if (dr1["TEMUCO"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["TEMUCO"].ToString()); }
                        if (dr1["VALDIVIA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["VALDIVIA"].ToString()); }
                        if (dr1["VIÑA 6 PONIENTE"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["VIÑA 6 PONIENTE"].ToString()); }
                        if (dr1["VIÑA DEL MAR"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["VIÑA DEL MAR"].ToString()); }
                        if (dr1["VITACURA"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["VITACURA"].ToString()); }
                        if (dr1["ZAPALLAR"].ToString() == "") { val1 = val1 + 0; }
                        else { val1 = val1 + double.Parse(dr1["ZAPALLAR"].ToString()); }




                        resultadoListadoProd.TotalStockGeneral = val1.ToString();

                        resultadoListadoProd.TotalStockFabrica = Convert.ToString(dr1["StockFabrica"]);

                        if (dr1["StockFabrica"].ToString() == "")

                        {
                            resultadoListadoProd.TotalStockFaltante = val1.ToString();
                        }
                        else
                        {
                            resultadoListadoProd.TotalStockFaltante = (double.Parse(dr1["StockFabrica"].ToString()) - double.Parse(val1.ToString())).ToString();

                        }

                        _ListadoProductos.Add(resultadoListadoProd);
                    }
                }
                ViewBag.ListadoProductos = _ListadoProductos;

                 



                return View();
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }



        public ActionResult PropuestaDespacho2(string _CodBodega) 
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;


                MaestrosSoapClient maestrosLocales = new MaestrosSoapClient();
                

                DataSet dsProducto = new DataSet();
                dsProducto = maestrosLocales.ListadoPorProductoAgrupado(_CodBodega);
                ObjetoProductoAgrupado productos = new ObjetoProductoAgrupado();
                var _ListadoProductos = new List<ObjetoProductoAgrupado>();

                List<WebGridColumn> columns = new List<WebGridColumn>();

                foreach (DataTable table1 in dsProducto.Tables)
                {


                    foreach (DataRow dr1 in table1.Rows)
                    {
                        var resultadoListadoProd = new ObjetoProductoAgrupado();
                        resultadoListadoProd.CodigoGrupo = Convert.ToString(dr1["CodSubGr"]);
                        resultadoListadoProd.Codigo = Convert.ToString(dr1["codprod"]);
                        resultadoListadoProd.Descripcion = Convert.ToString(dr1["desprod"]);
                        resultadoListadoProd.Stock = Convert.ToString(dr1["stock"]);
                        resultadoListadoProd.StockMinimo = Convert.ToString(dr1["NivMin"]);
                        resultadoListadoProd.StockMaximo = Convert.ToString(dr1["NivMax"]);

                   
                        ViewBag.NombreBodega = Convert.ToString(dr1["NombreBodega"]);

                        _ListadoProductos.Add(resultadoListadoProd);
                    }
                }
                ViewBag.ListadoProductos = _ListadoProductos;
                ViewBag.CodBodega = _CodBodega;

                IEnumerable<ObjetoProductoAgrupado> Model = _ListadoProductos.ToList();

                return View(Model);
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }


        public ActionResult Seguimiento()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoSeguimientoPedido> model = _control.ListadoSeguimientoPeidido();


                MaestrosSoapClient maestrosLocales = new MaestrosSoapClient();

                DataSet ds = new DataSet();
                ds = maestrosLocales.ListadoUsuarios();

                ObjetoBodega bodega = new ObjetoBodega();
                var _ListadoBodega = new List<ObjetoBodega>();
                List<SelectListItem> list = new List<SelectListItem>();

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        list.Add(new SelectListItem()
                        {
                            Text = Convert.ToString(dr["Nombre"]),
                            Value = Convert.ToString(dr["Nombre"])
                        });
                    }
                }
                ViewBag.cmbUsuarioSoftland = list;
                ViewBag.cmbUsuarioSoftland2 = list;






                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }



        public ActionResult AsignaPicking()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoSeguimientoPedido> model = _control.ListadoSeguimientoPreparacion();

 


                IEnumerable<SelectListItem> usuario1 = _control.Listado_UsuarioPicking().Select(c => new SelectListItem()
                {
                    Text = c.NombreUsuario,
                    Value = c.NombreUsuario.ToString()
                }).ToList();
                ViewBag.cmbUsuarioSoftland = usuario1;
                ViewBag.cmbUsuarioSoftland2 = usuario1;



                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }

        

        public JsonResult UploadFile()
        {
            if (Request.Files.Count > 0)
            {
                try
                {
                    object[,] obj = null;
                    int noOfCol = 0;
                    int noOfRow = 0;
                    HttpFileCollectionBase file = Request.Files;
                    if ((file != null) && (file.Count > 0))
                    {
                        //string fileName = file.FileName;
                        //string fileContentType = file.ContentType;
                        byte[] fileBytes = new byte[Request.ContentLength];
                        var data = Request.InputStream.Read(fileBytes, 0, Convert.ToInt32(Request.ContentLength));
                        // var usersList = new List<Users>();
                        //using (var package = new ExcelPackage())
                        using (var package = new ExcelPackage(Request.InputStream))
                        {
                            var currentSheet = package.Workbook.Worksheets;
                            var workSheet = currentSheet.First();
                            noOfCol = workSheet.Dimension.End.Column;
                            noOfRow = workSheet.Dimension.End.Row;
                            obj = new object[noOfRow, noOfCol];
                            obj = (object[,])workSheet.Cells.Value;
                        }
                    }
                    return Json(new { data = obj, row = noOfRow, col = noOfCol }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {

                }

            }
            return Json("", JsonRequestBehavior.AllowGet);
        }

         

        public JsonResult GenerarSeguimientoPedido(string _Id, string _CodigoLocal,string _NombreLocal)
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                var validador = 0;
                switch (datosUsuario.IdPerfil)
                {
                    case 3:
                        validador = 5;
                        break;
                    default:
                        if (!string.IsNullOrEmpty(_CodigoLocal) && !string.IsNullOrEmpty(_CodigoLocal))
                        {
                            var seguimiento = new ObjetoSeguimientoPedido()
                            {
                                Id = int.Parse(_Id.ToString()),
                                CodigoLocal = _CodigoLocal,
                                NombreLocal = _NombreLocal,
                                FechaPicking = DateTime.Parse(DateTime.Today.ToShortDateString()),
                                Estado = "PREPARACION"
                            };
                            if (int.Parse(_Id) != -1)
                            {
                                if (datosUsuario.AutorizaModificacion)
                                {
                                    if (_control.setGrabaSeguimientoPedido(seguimiento))
                                    {
                                        validador = 1;
                                    }
                                    else
                                    {
                                        validador = 3;
                                    }
                                }
                                else
                                {
                                    validador = 4;
                                    // EnvioMail correo = new EnvioMail();
                                    //correo.SendCorreoSolitaModificación(correo.ModificaMicroAlgas(idMicroAlga, datosUsuario.Nombre));
                                }
                            }
                            else
                            {
                                if (_control.setGrabaSeguimientoPedido(seguimiento))
                                {
                                    validador = 1;
                                }
                                else
                                {
                                    validador = 3;
                                }
                            }
                        }
                        else
                        {
                            validador = 2;
                        }
                        break;
                }
                return (Json(validador));
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                ErrorPage(100);
                throw;
            }
        }




        public JsonResult GrabaSeguimientoPedido(string _Id, string _CodigoLocal, string _NombreLocal, string _FechaPicking, string _Operador, string _Estado, string _HoraInicio, string _HoraTermino)
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                var validador = 0;
                switch (datosUsuario.IdPerfil)
                {
                    case 3:
                        validador = 5;
                        break;
                    default:
                        if (!string.IsNullOrEmpty(_CodigoLocal) && !string.IsNullOrEmpty(_NombreLocal))
                        {
                            var seguimiento = new ObjetoSeguimientoPedido()
                            {
                                Id = int.Parse(_Id.ToString()),
                                CodigoLocal = _CodigoLocal,
                                NombreLocal = _NombreLocal,
                                FechaPicking = DateTime.Parse(_FechaPicking.ToString()),
                                Operador = "",
                                Estado = _Estado,
                                HoraInicio = "",
                                HoraTermino = ""
                            };
                            if (int.Parse(_Id) != -1)
                            {
                                if (datosUsuario.AutorizaModificacion)
                                {
                                    if (_control.setGrabaSeguimientoPedido(seguimiento))
                                    {
                                        validador = 1;
                                    }
                                    else
                                    {
                                        validador = 3;
                                    }
                                }
                                else
                                {
                                    validador = 4;
                                    // EnvioMail correo = new EnvioMail();
                                    //correo.SendCorreoSolitaModificación(correo.ModificaMicroAlgas(idMicroAlga, datosUsuario.Nombre));
                                }
                            }
                            else
                            {
                                if (_control.setGrabaSeguimientoPedido(seguimiento))
                                {
                                    validador = 1;
                                }
                                else
                                {
                                    validador = 3;
                                }
                            }
                        }
                        else
                        {
                            validador = 2;
                        }
                        break;
                }
                return (Json(validador));
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                ErrorPage(100);
                throw;
            }
        }



        public JsonResult GrabaModificacionPedido(string _Id, string _Operador, string _Estado)
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                var validador = 0;
                switch (datosUsuario.IdPerfil)
                {
                    case 3:
                        validador = 5;
                        break;
                    default:
                        if (!string.IsNullOrEmpty(_Id) && !string.IsNullOrEmpty(_Estado))
                        {
                            var seguimiento = new ObjetoSeguimientoPedido()
                            {
                                Id = int.Parse(_Id.ToString()),
                                Operador = _Operador,
                                Estado = _Estado
                            };
                            if (int.Parse(_Id) != -1)
                            {
                                if (datosUsuario.AutorizaModificacion)
                                {
                                    if (_control.setGrabaModificaSeguimientoPedido(seguimiento))
                                    {
                                        validador = 1;
                                    }
                                    else
                                    {
                                        validador = 3;
                                    }
                                }
                                else
                                {
                                    validador = 1;  validador = 1;
                                    _control.setGrabaModificaSeguimientoPedido(seguimiento);
                                    // EnvioMail correo = new EnvioMail();
                                    //correo.SendCorreoSolitaModificación(correo.ModificaMicroAlgas(idMicroAlga, datosUsuario.Nombre));
                                }
                            }
                            else
                            {
                                if (_control.setGrabaModificaSeguimientoPedido(seguimiento))
                                {
                                    validador = 1;
                                }
                                else
                                {
                                    validador = 1;
                                }
                            }
                        }
                        else
                        {
                            validador = 2;
                        }
                        break;
                }
                return (Json(validador));
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                ErrorPage(100);
                throw;
            }
        }









        public JsonResult QuitapermisoUsuarios(int idUsuario)
        {

            var validador = 0;

            if (_control.SetQuitaPermisoUsuario(idUsuario))
            {
                validador = 1;
            }

            return (Json(validador));
        }




        public JsonResult GrabaPedido(int idTipoSistema, string nombreSistema)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(nombreSistema))
                {
                    var tipoSistema = new ObjetoTipoSistema()
                    {
                        IdTipoSistema = idTipoSistema,
                        NombreSistema = nombreSistema
                    };
                    if (_control.SetGrabaParametrosTipoSistema(tipoSistema))
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




        public JsonResult GrabaParametroTipoSistema(int idTipoSistema, string nombreSistema)
        {
            var validador = 0;
            try
            {
                if (!string.IsNullOrEmpty(nombreSistema))
                {
                    var tipoSistema = new ObjetoTipoSistema()
                    {
                        IdTipoSistema = idTipoSistema,
                        NombreSistema = nombreSistema
                    };
                    if (_control.SetGrabaParametrosTipoSistema(tipoSistema))
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




        [SessionFilter]
        public ActionResult Empresas()
        {
            try
            {
                var datosMedioPago = new ObjetoEmpresas();
                //    datosMedioPago = (ObjetoMedioPago)Session["DatoMedioPago"]; 
                ViewBag.Message = "Listado de Empresas";
                IEnumerable<ObjetoEmpresas> model = _control.ListadoEmpresas();
                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }

        }



      
        public ActionResult TraspasoRaico()
        {
            try
            { 
                //    datosMedioPago = (ObjetoMedioPago)Session["DatoMedioPago"]; 
                ViewBag.Message = "Listado de Traspaso";
                IEnumerable<ObjetoTraspaso> model = _control.ListadoTraspaso();
                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }

        }



        public ActionResult ErrorPage(int error)
        {
            return Redirect(Url.Content("~/Error/Index?error=" + error));
        }



    }
}