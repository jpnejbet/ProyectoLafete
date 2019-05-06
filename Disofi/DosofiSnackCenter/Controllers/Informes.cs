using Disofi.BLL;
using Disofi.UTIL.Objetos; 
using DisofiSC.Models.Filters;
using DisofiSC.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace DisofiSC.Controllers
{
    public class InformesController : Controller
    {
        ControlDisofi _control = new ControlDisofi();



        public ActionResult InformeSeguimiento()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoSeguimientoPedido> model = _control.ListadoSeguimientoPeidido();


                 


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