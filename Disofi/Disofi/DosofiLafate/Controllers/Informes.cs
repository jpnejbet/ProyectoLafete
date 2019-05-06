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
using DisofiLafete.MaestrosSoapClient;

namespace Disofi.Controllers
{
    public class InformesController : Controller
    {
        ControlDisofi _control = new ControlDisofi();






        public ActionResult ErrorPage(int error)
        {
            return Redirect(Url.Content("~/Error/Index?error=" + error));
        }



    }
}