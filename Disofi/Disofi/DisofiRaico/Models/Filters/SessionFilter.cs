﻿using DisofiRaico.Utils; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Disofi.Models.Filters
{
    public class SessionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                if ((HttpContext.Current.Session["PermisoUsuario"].ToString() == "Ingreso" || HttpContext.Current.Session["PermisoUsuario"].ToString() == "Lectura"))
                {
                    var redirectTargetDictionary = new RouteValueDictionary
                                                                    {
                                                                        {"action", "Index"},
                                                                        {"controller", "Error"},
                                                                        {"error", 403}
                                                                    };

                    filterContext.Result = new RedirectToRouteResult(redirectTargetDictionary);
                }
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                var redirectTargetDictionary = new RouteValueDictionary
                                                                    {
                                                                        {"action", "Index"},
                                                                        {"controller", "Login"}
                                                                    };

                filterContext.Result = new RedirectToRouteResult(redirectTargetDictionary);
            }
            base.OnActionExecuting(filterContext);
        }
    }
}