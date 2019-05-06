using Disofi.BLL;
using Disofi.UTIL.Objetos; 
using Disofi.Models.Filters;
using Disofi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Disofi.Controllers
{
    public class TamarugalController : Controller
    {
        ControlDisofi _control = new ControlDisofi();
        public ActionResult CreacionClienteContrato()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                return View();
            }
            catch (Exception ex)
            {             
                throw (new CapturaExcepciones(ex));
            }
        }


        public ActionResult ConsultaOT()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                return View();
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }

        public ActionResult AdmOT()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                return View();
            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }



        [SessionFilter]
        public ActionResult Usuarios()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoUsuarios> model = _control.ListadoUsuarios();
                IEnumerable<SelectListItem> items = _control.ListadoPerfiles().Select(c => new SelectListItem() {
                                                                            Text = c.NombrePerfil,
                                                                            Value = c.IdPerfil.ToString()
                                                }).ToList();
                ViewBag.Perfil = items;




                IEnumerable<SelectListItem> datoEmpresas = _control.ListadoEmpresas().Select(c => new SelectListItem()
                {
                    Text = c.Nombre,
                    Value = c.IdEmpresa.ToString(),
                }).ToList();




                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }



        [SessionFilter]
        public ActionResult Perfiles()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoPerfil> model = _control.ListadoPerfiles();



                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
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


 
         

        public ActionResult ErrorPage(int error)
        {
            return Redirect(Url.Content("~/Error/Index?error=" + error));
        }



    }
}