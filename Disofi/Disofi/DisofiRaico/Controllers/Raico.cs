using Disofi.BLL;
using Disofi.UTIL.Objetos;
using Disofi.Models.Filters;
using DisofiRaico.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Web.Helpers;

namespace DisofiRaico.Controllers
{
    public class RaicoController : Controller
    {
        ControlDisofi _control = new ControlDisofi();
        public ActionResult Cuentas()
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



                
        public ActionResult ErrorPage(int error)
        {
            return Redirect(Url.Content("~/Error/Index?error=" + error));
        }



    }
}