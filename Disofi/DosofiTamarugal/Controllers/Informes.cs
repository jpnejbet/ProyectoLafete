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

namespace Disofi.Controllers
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


                SoftLandMaestros.MaestrosSoapClient maestrosLocales = new SoftLandMaestros.MaestrosSoapClient();

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