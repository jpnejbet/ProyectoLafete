using Disofi.UTIL.Objetos; 
using Disofi.Utils;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Web.Mvc;
using System.Data; 
using Disofi.BLL; 
 
namespace Disofi.Controllers
{
    public class SanckCenterController : Controller
    {
        ControlDisofi _control = new ControlDisofi();




        public ActionResult OrdenAtencion()
        {
            try
            {

                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Usuario: " + datosUsuario.Nombre;
                 
                  

                IEnumerable<SelectListItem> cliente = _control.ListadoSnSolo().Select(c => new SelectListItem()
                {
                    Text = c.Cliente,
                    Value = c.Cliente.ToString()
                }).ToList();
                ViewBag.CmbCliente = cliente;



                return View();
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }

        }
        



        public ActionResult AdmOrdenAtencionMovil(int id)
        {
            try
            {

                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Usuario: " + datosUsuario.Nombre;



                List<ObjetoOrdenAtencion> ordenTrabajo = this._control.ListadoOrdenAtencionId(id);

                foreach (ObjetoOrdenAtencion ot in ordenTrabajo)
                {

                    ViewBag.Id = ot.Id;
                    ViewBag.Usuario = ot.Usuario;
                    //  ViewBag.Fecha = ot.Fecha.to;
                    ViewBag.TipoAtencion = ot.TipoAtencion;
                    ViewBag.Requemiento = ot.Requemiento;
                    ViewBag.TipoCliente = ot.TipoCliente;
                    ViewBag.NombreCliente = ot.NombreCliente;
                    ViewBag.NumeroContacto = ot.NumeroContacto;
                    ViewBag.Descripcion = ot.Descripcion;
                    ViewBag.UbicacionFisica = ot.UbicacionFisica;
                    ViewBag.Diganostico = ot.Diganostico;
                    ViewBag.Solucion = ot.Solucion;
                    ViewBag.Responsable = ot.Responsable;
                    ViewBag.DescripcionSolucion = ot.DescripcionSolucion;
                    //   ViewBag.FechaCierre = ot.Id;
                    ViewBag.UsuarioCierre = ot.UsuarioCierre;
                    ViewBag.Estado = ot.Estado;
                    ViewBag.Supervisor = ot.Supervisor;
                    ViewBag.TipoMaquina = ot.TipoMaquina;
                    ViewBag.Modelo = ot.Modelo;
                    ViewBag.Maquina = ot.Maquina;
                    ViewBag.Ruta = ot.Ruta;


                }


                return View();
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }

        }

        public ActionResult AdmOrdenAtencion(int id)
        {
            try
            {

                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Usuario: " + datosUsuario.Nombre;



                List<ObjetoOrdenAtencion> ordenTrabajo = this._control.ListadoOrdenAtencionId(id);

                foreach (ObjetoOrdenAtencion ot in ordenTrabajo)
                {

                    ViewBag.Id = ot.Id;
                    ViewBag.Usuario = ot.Usuario;
                    //  ViewBag.Fecha = ot.Fecha.to;
                    ViewBag.TipoAtencion = ot.TipoAtencion;
                    ViewBag.Requemiento = ot.Requemiento;
                    ViewBag.TipoCliente = ot.TipoCliente;
                    ViewBag.NombreCliente = ot.NombreCliente;
                    ViewBag.NumeroContacto = ot.NumeroContacto;
                    ViewBag.Descripcion = ot.Descripcion;
                    ViewBag.UbicacionFisica = ot.UbicacionFisica;
                    ViewBag.Diganostico = ot.Diganostico;
                    ViewBag.Solucion = ot.Solucion;
                    ViewBag.Responsable = ot.Responsable;
                    ViewBag.DescripcionSolucion = ot.DescripcionSolucion;
                    //   ViewBag.FechaCierre = ot.Id;
                    ViewBag.UsuarioCierre = ot.UsuarioCierre;
                    ViewBag.Estado = ot.Estado;
                    ViewBag.Supervisor = ot.Supervisor;
                    ViewBag.TipoMaquina = ot.TipoMaquina;
                    ViewBag.Modelo = ot.Modelo;
                    ViewBag.Maquina = ot.Maquina;
                    ViewBag.Ruta = ot.Ruta;


                }


                return View();
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }

        }


        // estado: $('input:radio[name=optradio]:checked').val() ,




        [HttpPost]
        public JsonResult ListadoUbicacion(string clientes)
        {
            try
            {
                List<ObjetoUbicacion> datoValorComuna = _control.ListadoUbicacion(clientes).ToList();
                return Json(datoValorComuna);

            }
            catch (Exception ex)
            {
                throw (new CapturaExcepciones(ex));
            }
        }

        public ActionResult GrabarOrdenAtencion(string _Id,
                                            string _TipoAtencion,
                                            string _Requemiento,
                                            string _TipoCliente,
                                            string _NombreCliente,
                                            string _NombreCliente1,
                                            string _NumeroContacto,
                                            string _Descripcion,
                                            string _UbicacionFisica,
                                            string _UbicacionFisica2,
                                            string _Diganostico,
                                            string _Solucion,
                                            string _Responsable,
                                            string _DescripcionSolucion,
                                            string _FechaCierre,
                                            string _Ruta,
                                            string _Maquina,
                                            string _Modelo,
                                            string _TipoMaquina,
                                            string _Supervisor)
        {




            var validador = 0;
            int idpedido = 0;
            string cliente = _NombreCliente;

            if (cliente == "")
            {
                cliente = _NombreCliente1;
            }



            string ubica = _UbicacionFisica;

            if (ubica == "")
            {
                ubica = _UbicacionFisica2;
            }

            try
            {

                DateTime FechaCierred;

                if (_FechaCierre.ToString() == "")
                {
                    FechaCierred = DateTime.Parse("01/01/2025");
                }
                else
                {
                    FechaCierred = DateTime.Parse((_FechaCierre.Split('/')[1].ToString() + "-" + _FechaCierre.Split('/')[0].ToString() + "-" + _FechaCierre.Split('/')[2]).ToString());

                }
                 


                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];


                if (!string.IsNullOrEmpty(_Id.ToString()))
                {
                    var pedido = new ObjetoOrdenAtencion()
                    {
                        Id = int.Parse(_Id),
                        Usuario = datosUsuario.Nombre,
                        TipoAtencion = _TipoAtencion,
                        Requemiento = _Requemiento,
                        TipoCliente = _TipoCliente,
                        NombreCliente = cliente,
                        NumeroContacto = _NumeroContacto,
                        Descripcion = _Descripcion,
                        UbicacionFisica = ubica,
                        Diganostico = _Diganostico,
                        Solucion = _Solucion,
                        Responsable = _Responsable,
                        DescripcionSolucion = _DescripcionSolucion,
                        FechaCierre = FechaCierred,
                        Estado = "En Proceso",
                        Ruta = _Ruta,
                        Maquina = _Maquina,
                        Modelo = _Modelo,
                        TipoMaquina = _TipoMaquina,
                        Supervisor = _Supervisor
                    };

                    idpedido = _control.SetGrabaOrdenAtencion(pedido);

                    //EnvioMail correo = new EnvioMail();
                    //correo.SendCorreoSolitaModificación("");

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




        public ActionResult ConsultaComercial()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoOrdenAtencion> model = _control.ListadoComercial();




                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }




        public ActionResult ConsultaTecnico()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoOrdenAtencion> model = _control.ConsultaTecnico();



                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }




        public ActionResult Diagnostico()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoCodigoSC> model = _control.ListadoDiagnosticoSC();
                  
                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }


        public ActionResult Solucion()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoCodigoSC> model = _control.ListadoSolucionSC();

                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }




        public ActionResult ConsultaMovil()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoOrdenAtencion> model = _control.ConsultaTecnico();



                return View(model);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
                return ErrorPage(1001);
                throw;
            }
        }





        public ActionResult ConsultaOperaciones()
        {
            try
            {
                var datosUsuario = new ObjetoLogin();
                datosUsuario = (ObjetoLogin)Session["DatosUsuario"];
                ViewBag.Message = "Bienvenido: " + datosUsuario.Nombre;
                IEnumerable<ObjetoOrdenAtencion> model = _control.ConsultaOperaciones();



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