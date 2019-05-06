using Disofi.BLL;
using Disofi.UTIL.Objetos;  
using DisofiSC.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using DisofiSC.Models.Filters;

namespace DisofiSC.Controllers
{
    public class HomeController : Controller
    {
        ControlDisofi _control = new ControlDisofi();
        public ActionResult Index()
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



                IEnumerable<SelectListItem> datosSucursales = _control.ListadoSucursal().Select(c => new SelectListItem()
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString(),
                }).ToList();

                ViewBag.cmbSucursal = datosSucursales;



                 
                 

                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }



//        [SessionFilter]
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

        public JsonResult GrabaDatos(string rut, string pass, string nombreUsuario, string apellidoUsuario, int idPerfil, string Email, string IdEmpresa, string IdSucursal)
        {

            var datosUsuario = new ObjetoLogin();
            datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
             
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
                    usuario.Email = Email;
                    usuario.idEmpresa =6;
                    usuario.idSucursal = int.Parse(IdSucursal.ToString());


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
            return (Json(validador));
        }

        public JsonResult AutorizaUsuario(int idUsuario)
        {

            var validador = 0;

            if (_control.SetAutorizaUsuario(idUsuario))
            {
                validador = 1;
            }

            return (Json(validador));
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