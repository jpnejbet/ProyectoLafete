using Disofi.DAL;
using Disofi.UTIL.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.BLL
{
    internal class FactoryAccesos
    {

        /// <summary>
        /// Datos del usuario del sistema
        /// </summary>
        /// <param name="rut">RUT del usuario</param>
        /// <param name="pass">Password de usuario debe ir con HashMD5</param>
        /// <returns>Listado con los datos, para obtener el perfil y el nombre</returns>
        public List<ObjetoLogin> LoginUsuario(string rut, string pass)
        {
            var DatosLogin = new List<ObjetoLogin>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_LOGIN", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"rut", rut},
                                                                                                {"pass", pass }
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoLogin();

                    validador = data.Rows[i].Field<object>("id_Usuario");
                    resultadoListado.IdUsuario = validador != null ? data.Rows[i].Field<int>("id_Usuario") : -1;


                    validador = data.Rows[i].Field<object>("IdSucursal");
                    resultadoListado.IdSucursal = validador != null ? data.Rows[i].Field<int>("IdSucursal") : -1;


                    validador = data.Rows[i].Field<object>("id_Perfil");
                    resultadoListado.IdPerfil = validador != null ? data.Rows[i].Field<int>("id_Perfil") : -1;

                    validador = data.Rows[i].Field<object>("Nombre");
                    resultadoListado.Nombre = validador != null ? data.Rows[i].Field<string>("Nombre") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("RUT");
                    resultadoListado.Rut = validador != null ? data.Rows[i].Field<string>("RUT") : "NO ASIGNADO";


                    //validador = data.Rows[i].Field<object>("email");
                    //resultadoListado.correo = validador != null ? data.Rows[i].Field<string>("email") : "NO ASIGNADO";




                    validador = data.Rows[i].Field<object>("AutorizaModificacion");
                    resultadoListado.AutorizaModificacion = validador != null ? data.Rows[i].Field<bool>("AutorizaModificacion") : false;

                    validador = data.Rows[i].Field<object>("Activo");
                    resultadoListado.Activo = validador != null ? data.Rows[i].Field<bool>("Activo") : false;

                    DatosLogin.Add(resultadoListado);
                }
            }
            return DatosLogin;
        }



        /// <summary>
        /// Listado de Perfiles del sistema
        /// </summary>
        /// <returns>lista con los perfiles del sistema.</returns>
        public List<ObjetoPerfil> ListadoPerfiles()
        {
            var ListadoPerfil = new List<ObjetoPerfil>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_LISTADOPERFILES", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoPerfil();
                    validador = data.Rows[i].Field<object>("id_Perfil");
                    resultadoListado.IdPerfil = validador != null ? data.Rows[i].Field<int>("id_Perfil") : -1;

                    validador = data.Rows[i].Field<object>("NombrePerfil");
                    resultadoListado.NombrePerfil = validador != null ? data.Rows[i].Field<string>("NombrePerfil") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.DescripcionPerfil = validador != null ? data.Rows[i].Field<string>("Descripcion") : "NO ASIGNADO";

                    ListadoPerfil.Add(resultadoListado);
                }
            }
            return ListadoPerfil;
        }



        public List<ObjetoUnidadMedida> ListadoUnidadMedida()
        {
            var ListadoUnidadMedida = new List<ObjetoUnidadMedida>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_UnidadMedida", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoUnidadMedida();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    ListadoUnidadMedida.Add(resultadoListado);
                }
            }
            return ListadoUnidadMedida;
        }


        public List<ObjetoTipoCamion> ListadoTipoCamion()
        {
            var ListadoTipoCamion = new List<ObjetoTipoCamion>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TipoCamion", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoTipoCamion();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("TipoCamion");
                    resultadoListado.TipoCamion = validador != null ? data.Rows[i].Field<string>("TipoCamion") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    ListadoTipoCamion.Add(resultadoListado);
                }
            }
            return ListadoTipoCamion;
        }




        public List<ObjetoTamarugalPeaje> ListadoPeajes()
        {
            var ListadoTipoCamion = new List<ObjetoTamarugalPeaje>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalPeaje", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoTamarugalPeaje();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Nombre");
                    resultadoListado.Nombre = validador != null ? data.Rows[i].Field<string>("Nombre") : "NO Nombre";


                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<int>("Valor") : -1;


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    ListadoTipoCamion.Add(resultadoListado);
                }
            }
            return ListadoTipoCamion;
        }


        public List<ObjetoRecepcionGuia> ListadoGuiaRecepcion(int id)
        {
            var ListadoGuiaE = new List<ObjetoRecepcionGuia>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Recepcion", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"id", id}
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoRecepcionGuia();


                    validador = data.Rows[i].Field<object>("IdGuia");
                    resultadoListado.IdGuia = validador != null ? data.Rows[i].Field<int>("IdGuia") : 0;

                    validador = data.Rows[i].Field<object>("IdConductor");
                    resultadoListado.IdConductor = validador != null ? data.Rows[i].Field<int>("IdConductor") : -1;

                    validador = data.Rows[i].Field<object>("NumeroPedido");
                    resultadoListado.NumeroPedido = validador != null ? data.Rows[i].Field<int>("NumeroPedido") : 0;



                    validador = data.Rows[i].Field<object>("PlacaNroRemolque");
                    resultadoListado.PlacaNroRemolque = validador != null ? data.Rows[i].Field<string>("PlacaNroRemolque") : "Sin información";


                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "Sin información";


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";



                    validador = data.Rows[i].Field<object>("Conductor");
                    resultadoListado.Conductor = validador != null ? data.Rows[i].Field<string>("Conductor") : "Sin información";

                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "Sin información";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "Sin información";


                    validador = data.Rows[i].Field<object>("Patente");
                    resultadoListado.Patente = validador != null ? data.Rows[i].Field<string>("Patente") : "";


                    validador = data.Rows[i].Field<object>("PlacaNroRemolque");
                    resultadoListado.PlacaNroRemolque = validador != null ? data.Rows[i].Field<string>("PlacaNroRemolque") : "";



                    validador = data.Rows[i].Field<object>("IdDespacho");
                    resultadoListado.IdDespacho = validador != null ? data.Rows[i].Field<int>("IdDespacho") : 0;



                    validador = data.Rows[i].Field<object>("Vueltas");
                    resultadoListado.Vuelta = validador != null ? data.Rows[i].Field<string>("Vueltas") : "0";

                    validador = data.Rows[i].Field<object>("VueltasCompletadas");
                    resultadoListado.VueltaCompletadas = validador != null ? data.Rows[i].Field<string>("VueltasCompletadas") : "0";





                    ListadoGuiaE.Add(resultadoListado);
                }
            }
            return ListadoGuiaE;
        }


        public List<ObjetoRecepcionGuia> ListadoRendicion(int id)
        {
            var ListadoGuiaE = new List<ObjetoRecepcionGuia>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Rendicion", new System.Collections.Hashtable()  {
                                                                                                {"id", id}
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoRecepcionGuia();



                    validador = data.Rows[i].Field<object>("NroGuia");
                    resultadoListado.IdGuia = validador != null ? data.Rows[i].Field<int>("NroGuia") : 0;

                    validador = data.Rows[i].Field<object>("IdConductor");
                    resultadoListado.IdConductor = validador != null ? data.Rows[i].Field<int>("IdConductor") : -1;

                    validador = data.Rows[i].Field<object>("NumeroPedido");
                    resultadoListado.NumeroPedido = validador != null ? data.Rows[i].Field<int>("NumeroPedido") : 0;



                    validador = data.Rows[i].Field<object>("PlacaNroRemolque");
                    resultadoListado.PlacaNroRemolque = validador != null ? data.Rows[i].Field<string>("PlacaNroRemolque") : "Sin información";


                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "Sin información";


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";


                    validador = data.Rows[i].Field<object>("Conductor");
                    resultadoListado.Conductor = validador != null ? data.Rows[i].Field<string>("Conductor") : "Sin información";

                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "Sin información";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "Sin información";

                    validador = data.Rows[i].Field<object>("Patente");
                    resultadoListado.Patente = validador != null ? data.Rows[i].Field<string>("Patente") : "";

                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "";


                    ListadoGuiaE.Add(resultadoListado);
                }
            }
            return ListadoGuiaE;
        }


        public List<ObjetoSucursal> ListadoSucursal()
        {
            var Listado = new List<ObjetoSucursal>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalSucursal", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSucursal();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Nombre");
                    resultadoListado.Nombre = validador != null ? data.Rows[i].Field<string>("Nombre") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    Listado.Add(resultadoListado);
                }
            }
            return Listado;
        }


        public List<ObjetoSucursal> ListadoUsuariosSucursalId(string id)
        {
            var Listado = new List<ObjetoSucursal>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_UsuariosSucursalId", new System.Collections.Hashtable()

                );
            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSucursal();
                    validador = data.Rows[i].Field<object>("id_Usuario");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("id_Usuario") : -1;

                    validador = data.Rows[i].Field<object>("Nombre");
                    resultadoListado.Nombre = validador != null ? data.Rows[i].Field<string>("Nombre") : "NO ASIGNADO";


                    Listado.Add(resultadoListado);
                }
            }
            return Listado;
        }



        public List<ObjetoUbicacion> ListadoUbicacion(string cliente)
        {
            var Listado = new List<ObjetoUbicacion>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_UbicacionCliente", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"cliente", cliente}
                                                                                            });
            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoUbicacion();

                    validador = data.Rows[i].Field<object>("cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Ubicacion");
                    resultadoListado.Ubicacion = validador != null ? data.Rows[i].Field<string>("Ubicacion") : "NO ASIGNADO";



                    Listado.Add(resultadoListado);
                }
            }
            return Listado;
        }


        public List<ObjetoUbicacion> ListadoSnSolo()
        {
            var Listado = new List<ObjetoUbicacion>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_UbicacionClienteSolo", new System.Collections.Hashtable()

                );
            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoUbicacion();

                    validador = data.Rows[i].Field<object>("cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Ubicacion");
                    resultadoListado.Ubicacion = validador != null ? data.Rows[i].Field<string>("Ubicacion") : "NO ASIGNADO";



                    Listado.Add(resultadoListado);
                }
            }
            return Listado;
        }







        public List<ObjetoDestinos> BuscarRutaPorCliente(string Cliente)
        {
            var Listado = new List<ObjetoDestinos>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_DestinosNombre", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"NroContrato", Cliente}
                                                                                            });
            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoDestinos();





                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";


                    Listado.Add(resultadoListado);
                }
            }
            return Listado;
        }



        public List<ObjetoDestinos> Listado_RutasGasto(string ruta)
        {
            var Listado = new List<ObjetoDestinos>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_RutasGasto", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"ruta", ruta}
                                                                                            });
            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoDestinos();


                    validador = data.Rows[i].Field<object>("plaza");
                    resultadoListado.Plaza = validador != null ? data.Rows[i].Field<string>("plaza") : "NO ASIGNADO";


                    Listado.Add(resultadoListado);
                }
            }
            return Listado;
        }





        public List<ObjetoGuiaExpedicionGrid> ListadoGuiaExpedicion(string idusuario)
        {
            var listado = new List<ObjetoGuiaExpedicionGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_GuiaExpdicion", new System.Collections.Hashtable()  {
                                                                                                {"idusuario", int.Parse(idusuario.ToString())}
                                                                                            }
                );

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoGuiaExpedicionGrid();

                    validador = data.Rows[i].Field<object>("IdGuia");
                    resultadoListado.IdGuia = validador != null ? data.Rows[i].Field<int>("IdGuia") : -1;
                    validador = data.Rows[i].Field<object>("IdGuia");
                    resultadoListado.IdGuia = validador != null ? data.Rows[i].Field<int>("IdGuia") : -1;


                    validador = data.Rows[i].Field<object>("NumeroPedido");
                    resultadoListado.NroPedido = validador != null ? data.Rows[i].Field<int>("NumeroPedido") : -1;


                    validador = data.Rows[i].Field<object>("IdServicio");
                    resultadoListado.IdServicio = validador != null ? data.Rows[i].Field<int>("IdServicio") : -1;


                    validador = data.Rows[i].Field<object>("IdContrato");
                    resultadoListado.IdContrato = validador != null ? data.Rows[i].Field<int>("IdContrato") : -1;

                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("Conductor");
                    resultadoListado.Conductor = validador != null ? data.Rows[i].Field<string>("Conductor") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";

                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }




        public List<ObjetoPedido> ListadoPedidoId(string IdPedido)
        {
            var listado = new List<ObjetoPedido>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetallePedidoId", new System.Collections.Hashtable() {
                                                                                                {"id", int.Parse(IdPedido.ToString())}
                                                                                            }
                );

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoPedido();


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("NroPedido");
                    resultadoListado.NroPedido = validador != null ? data.Rows[i].Field<int>("NroPedido") : 0;


                    validador = data.Rows[i].Field<object>("FechaInicio");
                    resultadoListado.FechaInicio = validador != null ? data.Rows[i].Field<DateTime>("FechaInicio") : DateTime.Parse("01-01-2100");

                    validador = data.Rows[i].Field<object>("FechaFin");
                    resultadoListado.FechaFin = validador != null ? data.Rows[i].Field<DateTime>("FechaFin") : DateTime.Parse("01-01-2100");


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";

                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "";

                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "";

                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : 0;


                    validador = data.Rows[i].Field<object>("IdContrato");
                    resultadoListado.IdContrato = validador != null ? data.Rows[i].Field<int>("IdContrato") : 0;

                    validador = data.Rows[i].Field<object>("IdServicio");
                    resultadoListado.IdServicio = validador != null ? data.Rows[i].Field<int>("IdServicio") : 0;

                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }



        public List<ObjetoPedido> ListadoPedido(string idusuario)
        {
            var listado = new List<ObjetoPedido>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetallePedido", new System.Collections.Hashtable()
                );

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoPedido();


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";





                    validador = data.Rows[i].Field<object>("NroPedido");
                    resultadoListado.NroPedido = validador != null ? data.Rows[i].Field<int>("NroPedido") : 0;


                    validador = data.Rows[i].Field<object>("FechaInicio");
                    resultadoListado.FechaInicio = validador != null ? data.Rows[i].Field<DateTime>("FechaInicio") : DateTime.Parse("01-01-2100");

                    validador = data.Rows[i].Field<object>("FechaFin");
                    resultadoListado.FechaFin = validador != null ? data.Rows[i].Field<DateTime>("FechaFin") : DateTime.Parse("01-01-2100");


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";

                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "";

                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "";

                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : 0;


                    validador = data.Rows[i].Field<object>("IdContrato");
                    resultadoListado.IdContrato = validador != null ? data.Rows[i].Field<int>("IdContrato") : 0;

                    validador = data.Rows[i].Field<object>("IdServicio");
                    resultadoListado.IdServicio = validador != null ? data.Rows[i].Field<int>("IdServicio") : 0;

                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }





        public List<ObjetoGuiaExpedicionGrid> ListadoGuiaExpedicionIdConductor(int IdConductor)
        {
            var listado = new List<ObjetoGuiaExpedicionGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalGuiaExIdConductor", new System.Collections.Hashtable()
                {
                                                                                                {"id", int.Parse(IdConductor.ToString())}
                                                                                            }
                );

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoGuiaExpedicionGrid();


                    validador = data.Rows[i].Field<object>("NroGuia");
                    resultadoListado.IdGuia = validador != null ? data.Rows[i].Field<int>("NroGuia") : -1;

                    validador = data.Rows[i].Field<object>("IdConductor");
                    resultadoListado.IdConductor = validador != null ? data.Rows[i].Field<int>("IdConductor") : -1;


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("NroPedido");
                    resultadoListado.NroPedido = validador != null ? data.Rows[i].Field<int>("NroPedido") : 0;


                    validador = data.Rows[i].Field<object>("FechaCreacionPedido");
                    resultadoListado.FechaCreacionPedido = validador != null ? data.Rows[i].Field<DateTime>("FechaCreacionPedido") : DateTime.Parse("01-01-2100");



                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }



        public List<ObjetoConductor> ListadoConductores()
        {
            var Listado = new List<ObjetoConductor>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Tamarugalconductor", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoConductor();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;



                    validador = data.Rows[i].Field<object>("Rut");
                    resultadoListado.Rut = validador != null ? data.Rows[i].Field<string>("Rut") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Conductor");
                    resultadoListado.Conductor = validador != null ? data.Rows[i].Field<string>("Conductor") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    Listado.Add(resultadoListado);
                }
            }
            return Listado;
        }





        public List<ObjetoProductos> ListadoProductos()
        {
            var ListadoProductos = new List<ObjetoProductos>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_S_BuscarProductoPorGrupo", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoProductos();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Codigo");
                    resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("Codigo") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<decimal>("Cantidad") : 0;

                    validador = data.Rows[i].Field<object>("PrecioUnitario");
                    resultadoListado.PrecioUnitario = validador != null ? data.Rows[i].Field<decimal>("PrecioUnitario") : 0;


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    ListadoProductos.Add(resultadoListado);
                }
            }
            return ListadoProductos;
        }






        public List<ObjetoProductoAgrupado> ListadoPedidoPicking(string idpedido)
        {
            var ListadoProductos = new List<ObjetoProductoAgrupado>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_DetalleSeguimientoPedidoId", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"@idPedido",idpedido}
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoProductoAgrupado();


                    //validador = data.Rows[i].Field<object>("CodigoProducto");
                    //resultadoListado.CodigoGrupo = validador != null ? data.Rows[i].Field<string>("CodigoProducto") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : 0;

                     

                    validador = data.Rows[i].Field<object>("CodigoProducto");
                    resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("CodigoProducto") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("NombreProducto");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("NombreProducto") : "";


                    validador = data.Rows[i].Field<object>("StockMinimo");
                    resultadoListado.StockMinimo = validador != null ? data.Rows[i].Field<string>("StockMinimo").ToString() : "";


                    validador = data.Rows[i].Field<object>("StockMaximo");
                    resultadoListado.StockMaximo = validador != null ? data.Rows[i].Field<string>("StockMaximo").ToString() : "";


                    validador = data.Rows[i].Field<object>("StockReposicion");
                    resultadoListado.Stock= validador != null ? data.Rows[i].Field<object>("StockReposicion").ToString()  : "";

                    validador = data.Rows[i].Field<object>("stockCapturado");
                    resultadoListado.StockPickiado = validador != null ? data.Rows[i].Field<string>("stockCapturado").ToString() : "";







                    ListadoProductos.Add(resultadoListado);
                }
            }
            return ListadoProductos;
        }




        public List<ObjetoProductos> ListadoProductosSoftland(string grupo)
        {
            var ListadoProductos = new List<ObjetoProductos>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_S_BuscarProductoPorGrupo", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"@grupo",grupo}
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoProductos();


                    validador = data.Rows[i].Field<object>("CodProd");
                    resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("CodProd") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("DesProd");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("DesProd") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("PrecioVta");
                    resultadoListado.PrecioVenta = validador != null ? data.Rows[i].Field<double>("PrecioVta") : 0;


                    ListadoProductos.Add(resultadoListado);
                }
            }
            return ListadoProductos;
        }


        public List<ObjetoRuta> ListadoRutaContradoId(string id)
        {
            var ListadoRuta = new List<ObjetoRuta>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_ContratoRutaId ", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"id", int.Parse(id)}
                                                                                            });
            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoRuta();


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";

                    ListadoRuta.Add(resultadoListado);
                }
            }
            return ListadoRuta;
        }





        public List<ObjetoProductos> ListadoProductosId(string id)
        {
            var ListadoProductos = new List<ObjetoProductos>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalProductoId ", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"id", int.Parse(id)}
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoProductos();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Codigo");
                    resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("Codigo") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<decimal>("Cantidad") : 0;

                    validador = data.Rows[i].Field<object>("PrecioUnitario");
                    resultadoListado.PrecioUnitario = validador != null ? data.Rows[i].Field<decimal>("PrecioUnitario") : 0;



                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    ListadoProductos.Add(resultadoListado);
                }
            }
            return ListadoProductos;
        }



        public List<ObjetoDestinos> ListadoDestinoDestino()
        {
            var ListadoDestinos = new List<ObjetoDestinos>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_DestinosDestino", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoDestinos();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Codigo");
                    resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("Codigo") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    ListadoDestinos.Add(resultadoListado);
                }
            }
            return ListadoDestinos;
        }



        public List<ObjetoTipoCarga> ListadoCargas()
        {
            var ListadoTipoCargas = new List<ObjetoTipoCarga>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TipoCarga", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoTipoCarga();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("TipoCarga");
                    resultadoListado.TipoCarga = validador != null ? data.Rows[i].Field<string>("TipoCarga") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    ListadoTipoCargas.Add(resultadoListado);
                }
            }
            return ListadoTipoCargas;
        }




        //public List<ObjetoCuentas> ListadoCuentas()
        //{
        //    var ListadoTipoCargas = new List<ObjetoCuentas>();
        //    var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Cuentas", new System.Collections.Hashtable());

        //    if (data.Rows.Count > 0)
        //    {
        //        for (var i = 0; i < data.Rows.Count; i++)
        //        {
        //            var validador = new object();
        //            var resultadoListado = new ObjetoCuentas();
        //            validador = data.Rows[i].Field<object>("Id");
        //            resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

        //            validador = data.Rows[i].Field<object>("Codigo");
        //            resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("Codigo") : "";

        //            validador = data.Rows[i].Field<object>("Descripcion");
        //            resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "";

        //            validador = data.Rows[i].Field<object>("Cuenta");
        //            resultadoListado.Cuenta = validador != null ? data.Rows[i].Field<string>("Cuenta") : "";


        //            ListadoTipoCargas.Add(resultadoListado);
        //        }
        //    }
        //    return ListadoTipoCargas;
        //}


        public List<ObjetoCodigoSC> ListadoDiagnosticoSC()
        {
            var listado = new List<ObjetoCodigoSC>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Diagnostico", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoCodigoSC();

                    validador = data.Rows[i].Field<object>("Codigo");
                    resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("Codigo") : "";

                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "";

                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }


        public List<ObjetoCodigoSC> ListadoSolucionSC()
        {
            var listado = new List<ObjetoCodigoSC>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Solucion", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoCodigoSC();

                    validador = data.Rows[i].Field<object>("Codigo");
                    resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("Codigo") : "";

                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "";

                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }





        public List<ObjetoCliente> ListadoClienteContratoTamarugal()
        {
            var listado = new List<ObjetoCliente>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_ClientesTamarugal", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoCliente();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.NombreCliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";



                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }





        public List<ObjetoGuiaExpedicionGrid> ListadoProgramacionGE(string id)
        {
            var Listado = new List<ObjetoGuiaExpedicionGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetalleGuiaExpedicion", new System.Collections.Hashtable() {
                                                                                                {"id", int.Parse(id)}
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoGuiaExpedicionGrid();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;



                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("NumeroPedido");
                    resultadoListado.NroPedido = validador != null ? data.Rows[i].Field<int>("NumeroPedido") : 0;


                    validador = data.Rows[i].Field<object>("FechaGuia");
                    resultadoListado.FechaInicio = validador != null ? data.Rows[i].Field<DateTime>("FechaGuia") : DateTime.Parse("01-01-1900");




                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("IdGuiaExpedicion");
                    resultadoListado.IdGuia = validador != null ? data.Rows[i].Field<int>("IdGuiaExpedicion") : 0;


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";

                    validador = data.Rows[i].Field<object>("Vueltas");
                    resultadoListado.Vueltas = validador != null ? data.Rows[i].Field<string>("Vueltas") : "0";


                    validador = data.Rows[i].Field<object>("Patente");
                    resultadoListado.Patente = validador != null ? data.Rows[i].Field<string>("Patente") : "";


                    validador = data.Rows[i].Field<object>("NroRemolque");
                    resultadoListado.Remolque = validador != null ? data.Rows[i].Field<string>("NroRemolque") : "";




                    Listado.Add(resultadoListado);
                }
            }
            return Listado;
        }




        public List<ObjetoSeguimientoContrato> ListadoListadoSeguimientoContrato()
        {
            var ListadoSeguimientoContrato = new List<ObjetoSeguimientoContrato>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalClienteContrato", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoContrato();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Nombre");
                    resultadoListado.NombreSucursalEncargado = validador != null ? data.Rows[i].Field<string>("Nombre") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("FechaInicio");
                    resultadoListado.FechaInicio = validador != null ? data.Rows[i].Field<DateTime>("FechaInicio") : DateTime.Parse("01-01-1900"); ;

                    validador = data.Rows[i].Field<object>("FechaTermino");
                    resultadoListado.FechaTermino = validador != null ? data.Rows[i].Field<DateTime>("FechaTermino") : DateTime.Parse("01-01-1900"); ;

                    validador = data.Rows[i].Field<object>("Encargado");
                    resultadoListado.NombreEncargado = validador != null ? data.Rows[i].Field<string>("Encargado") : "";

                    validador = data.Rows[i].Field<object>("Comentario");
                    resultadoListado.Comentario = validador != null ? data.Rows[i].Field<string>("Comentario") : "";


                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<decimal>("Valor") : 0;


                    ListadoSeguimientoContrato.Add(resultadoListado);
                }
            }
            return ListadoSeguimientoContrato;
        }


        public List<ObjetoSeguimientoDetalleContratoGrid> DetalleContratoTamarugalId(string id)
        {
            var listado = new List<ObjetoSeguimientoDetalleContratoGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetalleContratoId", new System.Collections.Hashtable()   {
                                                                                                {"id", int.Parse(id)}
                                                                                            });


            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoDetalleContratoGrid();


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("IdContrato");
                    resultadoListado.IdContrato = validador != null ? data.Rows[i].Field<int>("IdContrato") : 0;



                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "NO ASIGNADO";




                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("IdServicio");
                    resultadoListado.IdServicio = validador != null ? data.Rows[i].Field<int>("IdServicio") : 0;





                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<decimal>("Valor") : 0;


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";



                    validador = data.Rows[i].Field<object>("FechaInicio");
                    resultadoListado.FechaInicio = validador != null ? data.Rows[i].Field<DateTime>("FechaInicio") : DateTime.Parse("01-01-2100");


                    validador = data.Rows[i].Field<object>("FechaTermino");
                    resultadoListado.FechaTermino = validador != null ? data.Rows[i].Field<DateTime>("FechaTermino") : DateTime.Parse("01-01-2100");


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";

                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }



        public List<ObjetoSeguimientoDetalleContratoGrid> DetalleContratoTamarugalId2(string id)
        {
            var listado = new List<ObjetoSeguimientoDetalleContratoGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetalleContratoId2", new System.Collections.Hashtable()   {
                                                                                                {"id", int.Parse(id)}
                                                                                            });


            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoDetalleContratoGrid();


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("IdContrato");
                    resultadoListado.IdContrato = validador != null ? data.Rows[i].Field<int>("IdContrato") : 0;





                    validador = data.Rows[i].Field<object>("IdTipoCamion");
                    resultadoListado.IdTipoCamion = validador != null ? data.Rows[i].Field<int>("IdTipoCamion") : 0;

                    validador = data.Rows[i].Field<object>("IdTipoCarga");
                    resultadoListado.IdTipoCarga = validador != null ? data.Rows[i].Field<int>("IdTipoCarga") : 0;



                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("TipoCarga");
                    resultadoListado.TipoCarga = validador != null ? data.Rows[i].Field<string>("TipoCarga") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("TipoCamion");
                    resultadoListado.TipoCamion = validador != null ? data.Rows[i].Field<string>("TipoCamion") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<decimal>("Valor") : 0;


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";




                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }



        public List<ObjetoSeguimientoDetalleContratoGrid> TamarugalDetalleContratos(string IdEncargado)
        {
            var listado = new List<ObjetoSeguimientoDetalleContratoGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetalleContratos", new System.Collections.Hashtable()
                 {
                                                                                                {"idEncargado", int.Parse(IdEncargado)}
                                                                                            });


            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoDetalleContratoGrid();


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("IdContrato");
                    resultadoListado.IdContrato = validador != null ? data.Rows[i].Field<int>("IdContrato") : 0;





                    //validador = data.Rows[i].Field<object>("IdUnidadMedida");
                    //resultadoListado.IdUnidadMedida = validador != null ? data.Rows[i].Field<int>("IdUnidadMedida") : 0;


                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<decimal>("Valor") : 0;


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";


                    validador = data.Rows[i].Field<object>("IdServicio");
                    resultadoListado.IdServicio = validador != null ? data.Rows[i].Field<int>("IdServicio") : 0;




                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }



        public List<ObjetoSeguimientoDetalleContratoGrid> TamarugalDetalleContratos2(string idContrato)
        {
            var listado = new List<ObjetoSeguimientoDetalleContratoGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetalleContratosv2", new System.Collections.Hashtable()
                 {
                                                                                                {"idContrato", int.Parse(idContrato)}
                                                                                            });


            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoDetalleContratoGrid();


                    validador = data.Rows[i].Field<object>("IdServicio");
                    resultadoListado.IdServicio = validador != null ? data.Rows[i].Field<int>("IdServicio") : 0;




                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "0";

                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<decimal>("Valor") : 0;



                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }



        public List<ObjetoRutaPeaje> ListadoRutaPeaje(string ruta)
        {
            var listado = new List<ObjetoRutaPeaje>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_RutaPeajes", new System.Collections.Hashtable()
                 {
                                                                                                {"ruta", ruta}
                                                                                            });


            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoRutaPeaje();





                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : 0;


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Plaza");
                    resultadoListado.Plaza = validador != null ? data.Rows[i].Field<string>("Plaza") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<string>("Valor") : "0";




                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }







        public List<ObjetoSeguimientoDetalleContratoGrid> DetalleServicioTamarugalId(string _idguia, string _numeroPedido)
        {
            var listado = new List<ObjetoSeguimientoDetalleContratoGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetalleServicioId", new System.Collections.Hashtable()   {
                                                                                                {"idguia", int.Parse(_idguia)},
                                                                                                { "numeroPedido", int.Parse(_numeroPedido)}
                                                                                            });


            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoDetalleContratoGrid();





                    validador = data.Rows[i].Field<object>("NroGuia");
                    resultadoListado.NroGuia = validador != null ? data.Rows[i].Field<int>("NroGuia") : 0;


                    validador = data.Rows[i].Field<object>("NumeroPedido");
                    resultadoListado.NroPedido = validador != null ? data.Rows[i].Field<int>("NumeroPedido") : 0;


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("Conductor");
                    resultadoListado.Conductor = validador != null ? data.Rows[i].Field<string>("Conductor") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("IdConductor");
                    resultadoListado.IdConductor = validador != null ? data.Rows[i].Field<int>("IdConductor") : 0;


                    validador = data.Rows[i].Field<object>("Patente");
                    resultadoListado.Patente = validador != null ? data.Rows[i].Field<string>("Patente") : "";


                    validador = data.Rows[i].Field<object>("PlacaRemolque");
                    resultadoListado.PlacaRemolque = validador != null ? data.Rows[i].Field<string>("PlacaRemolque") : "";

                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "";
                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }



        public List<ObjetoSeguimientoDetalleContratoGrid> DetalleServicioTamarugalId2(string _idguia, string _numeroPedido)
        {
            var listado = new List<ObjetoSeguimientoDetalleContratoGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetalleServicioId2", new System.Collections.Hashtable()   {
                                                                                                {"idguia", int.Parse(_idguia)},
                                                                                                { "numeroPedido", int.Parse(_numeroPedido)}
                                                                                            });


            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoDetalleContratoGrid();





                    validador = data.Rows[i].Field<object>("NroGuia");
                    resultadoListado.NroGuia = validador != null ? data.Rows[i].Field<int>("NroGuia") : 0;


                    validador = data.Rows[i].Field<object>("NumeroPedido");
                    resultadoListado.NroPedido = validador != null ? data.Rows[i].Field<int>("NumeroPedido") : 0;


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("Conductor");
                    resultadoListado.Conductor = validador != null ? data.Rows[i].Field<string>("Conductor") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("IdConductor");
                    resultadoListado.IdConductor = validador != null ? data.Rows[i].Field<int>("IdConductor") : 0;


                    validador = data.Rows[i].Field<object>("Patente");
                    resultadoListado.Patente = validador != null ? data.Rows[i].Field<string>("Patente") : "";


                    validador = data.Rows[i].Field<object>("PlacaRemolque");
                    resultadoListado.PlacaRemolque = validador != null ? data.Rows[i].Field<string>("PlacaRemolque") : "";

                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<string>("Cantidad") : "";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "";
                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }





        public List<ObjetoSeguimientoDetalleContratoGrid> DetalleServicioImprimirlId(string _idguia, string _numeroPedido)
        {
            var listado = new List<ObjetoSeguimientoDetalleContratoGrid>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_TamarugalDetalleServicioId", new System.Collections.Hashtable()   {
                                                                                                {"idguia", int.Parse(_idguia)},
                                                                                                { "numeroPedido", int.Parse(_numeroPedido)}
                                                                                            });


            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoDetalleContratoGrid();





                    validador = data.Rows[i].Field<object>("NroGuia");
                    resultadoListado.NroGuia = validador != null ? data.Rows[i].Field<int>("NroGuia") : 0;


                    validador = data.Rows[i].Field<object>("NumeroPedido");
                    resultadoListado.NroPedido = validador != null ? data.Rows[i].Field<int>("NumeroPedido") : 0;


                    validador = data.Rows[i].Field<object>("Patente");
                    resultadoListado.Patente = validador != null ? data.Rows[i].Field<string>("Patente") : "";


                    validador = data.Rows[i].Field<object>("PlacaNroRemolque");
                    resultadoListado.PlacaRemolque = validador != null ? data.Rows[i].Field<string>("PlacaNroRemolque") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Vueltas");
                    resultadoListado.Vueltas = validador != null ? data.Rows[i].Field<int>("Vueltas") : 0;

                    validador = data.Rows[i].Field<object>("Conductor");
                    resultadoListado.Conductor = validador != null ? data.Rows[i].Field<string>("Conductor") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("TipoCamion");
                    resultadoListado.TipoCamion = validador != null ? data.Rows[i].Field<string>("TipoCamion") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("pedido");
                    resultadoListado.CantidadPedido = validador != null ? data.Rows[i].Field<int>("pedido") : 0;


                    validador = data.Rows[i].Field<object>("IdConductor");
                    resultadoListado.IdConductor = validador != null ? data.Rows[i].Field<int>("IdConductor") : 0;


                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }





        public List<ObjetoRendicionGasto> ListadoGasto(string _Contrato, int _idguia, int _idpedido)
        {
            var listado = new List<ObjetoRendicionGasto>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Gastos", new System.Collections.Hashtable()   {
                                                                                                {"contrato", _Contrato},
                                                                                                { "idguia", _idguia},
                                                                                                { "idpedido", _idpedido},
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoRendicionGasto();


                    validador = data.Rows[i].Field<object>("Contrato");
                    resultadoListado.Contrato = validador != null ? data.Rows[i].Field<string>("Contrato") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("IdGuia");
                    resultadoListado.IdGuia = validador != null ? data.Rows[i].Field<int>("IdGuia") : 0;


                    validador = data.Rows[i].Field<object>("IdPedido");
                    resultadoListado.IdPedido = validador != null ? data.Rows[i].Field<int>("IdPedido") : 0;


                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<string>("Valor") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("NroTicket");
                    resultadoListado.NroTicket = validador != null ? data.Rows[i].Field<string>("NroTicket") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Fecha");
                    resultadoListado.Fecha = validador != null ? data.Rows[i].Field<string>("Fecha") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Nombre");
                    resultadoListado.NombreGasto = validador != null ? data.Rows[i].Field<string>("Nombre") : "NO ASIGNADO";

                    listado.Add(resultadoListado);
                }
            }
            return listado;
        }


        /// <summary>
        /// Listado de Usuarios
        /// </summary>
        /// <returns>listado de usuarios del sistema</returns>
        public List<ObjetoUsuarios> ListadoUsuarios()
        {
            var ListadoUsuarios = new List<ObjetoUsuarios>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_LISTADOUSUARIOS", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoUsuarios();
                    validador = data.Rows[i].Field<object>("id_Usuario");
                    resultadoListado.IdUsuario = validador != null ? data.Rows[i].Field<int>("id_Usuario") : -1;

                    validador = data.Rows[i].Field<object>("RUT");
                    resultadoListado.RutUsuario = validador != null ? data.Rows[i].Field<string>("RUT") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Nombre");
                    resultadoListado.NombreUsuario = validador != null ? data.Rows[i].Field<string>("Nombre") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("NombrePerfil");
                    resultadoListado.NombrePerfilUsuario = validador != null ? data.Rows[i].Field<string>("NombrePerfil") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("AutorizaModificacion");
                    resultadoListado.PuedeModificar = validador != null ? data.Rows[i].Field<bool>("AutorizaModificacion") : false;

                    validador = data.Rows[i].Field<object>("Activo");
                    resultadoListado.Activo = validador != null ? data.Rows[i].Field<bool>("Activo") : false;

                    validador = data.Rows[i].Field<object>("id_Perfil");
                    resultadoListado.IdPerfil = validador != null ? data.Rows[i].Field<int>("id_Perfil") : -1;


                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }



        public List<ObjetoUsuarios> Listado_UsuarioPicking()
        {
            var ListadoUsuarios = new List<ObjetoUsuarios>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_LafeteUsuarioPicking", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoUsuarios();
                    validador = data.Rows[i].Field<object>("id_Usuario");
                    resultadoListado.IdUsuario = validador != null ? data.Rows[i].Field<int>("id_Usuario") : -1;

                    validador = data.Rows[i].Field<object>("Nombre");
                    resultadoListado.NombreUsuario = validador != null ? data.Rows[i].Field<string>("Nombre") : "NO ASIGNADO";



                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }


        public List<ObjetoSeguimientoPedido> ListadoSeguimientoPreparacion()
        {
            var ListadoUsuarios = new List<ObjetoSeguimientoPedido>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_ListadoSeguimientoPreparacion", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoPedido();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("CodigoLocal");
                    resultadoListado.CodigoLocal = validador != null ? data.Rows[i].Field<string>("CodigoLocal") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("NombreLocal");
                    resultadoListado.NombreLocal = validador != null ? data.Rows[i].Field<string>("NombreLocal") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("FechaPicking");
                    resultadoListado.FechaPicking = validador != null ? data.Rows[i].Field<DateTime>("FechaPicking") : DateTime.Parse("01-01-2019");

                    validador = data.Rows[i].Field<object>("Operador");
                    resultadoListado.Operador = validador != null ? data.Rows[i].Field<string>("Operador") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<string>("Estado") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("HoraInicio");
                    resultadoListado.HoraInicio = validador != null ? data.Rows[i].Field<string>("HoraInicio") : "Sin Iniciar";

                    validador = data.Rows[i].Field<object>("HoraTermino");
                    resultadoListado.HoraTermino = validador != null ? data.Rows[i].Field<string>("HoraTermino") : "Sin Finalizar";

                    validador = data.Rows[i].Field<object>("Documento");
                    resultadoListado.Documento = validador != null ? data.Rows[i].Field<string>("Documento") : "NO ASIGNADO";

                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }


        public List<ObjetoSeguimientoPedido> ListadoSeguimientoModificacion()
        {
            var ListadoUsuarios = new List<ObjetoSeguimientoPedido>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_ListadoSeguimientoModificacion", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoPedido();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("CodigoLocal");
                    resultadoListado.CodigoLocal = validador != null ? data.Rows[i].Field<string>("CodigoLocal") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("NombreLocal");
                    resultadoListado.NombreLocal = validador != null ? data.Rows[i].Field<string>("NombreLocal") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("FechaPicking");
                    resultadoListado.FechaPicking = validador != null ? data.Rows[i].Field<DateTime>("FechaPicking") : DateTime.Parse("01-01-2019");

                    validador = data.Rows[i].Field<object>("Operador");
                    resultadoListado.Operador = validador != null ? data.Rows[i].Field<string>("Operador") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<string>("Estado") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("HoraInicio");
                    resultadoListado.HoraInicio = validador != null ? data.Rows[i].Field<string>("HoraInicio") : "Sin Iniciar";

                    validador = data.Rows[i].Field<object>("HoraTermino");
                    resultadoListado.HoraTermino = validador != null ? data.Rows[i].Field<string>("HoraTermino") : "Sin Finalizar";

                    validador = data.Rows[i].Field<object>("Documento");
                    resultadoListado.Documento = validador != null ? data.Rows[i].Field<string>("Documento") : "NO ASIGNADO";

                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }

        public List<ObjetoSeguimientoPedido> ListadoSeguimientoPeidido()
        {
            var ListadoUsuarios = new List<ObjetoSeguimientoPedido>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_ListadoSeguimientoPeidido", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoSeguimientoPedido();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("CodigoLocal");
                    resultadoListado.CodigoLocal = validador != null ? data.Rows[i].Field<string>("CodigoLocal") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("NombreLocal");
                    resultadoListado.NombreLocal = validador != null ? data.Rows[i].Field<string>("NombreLocal") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("FechaPicking");
                    resultadoListado.FechaPicking = validador != null ? data.Rows[i].Field<DateTime>("FechaPicking") : DateTime.Parse("01-01-2019");

                    validador = data.Rows[i].Field<object>("Operador");
                    resultadoListado.Operador = validador != null ? data.Rows[i].Field<string>("Operador") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<string>("Estado") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("HoraInicio");
                    resultadoListado.HoraInicio = validador != null ? data.Rows[i].Field<string>("HoraInicio") : "Sin Iniciar";

                    validador = data.Rows[i].Field<object>("HoraTermino");
                    resultadoListado.HoraTermino = validador != null ? data.Rows[i].Field<string>("HoraTermino") : "Sin Finalizar";

                    validador = data.Rows[i].Field<object>("Documento");
                    resultadoListado.Documento = validador != null ? data.Rows[i].Field<string>("Documento") : "NO ASIGNADO";

                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }





        public List<ObjetoOrdenAtencion> ListadoOrdenAtencionId(int id)
        {
            var ListadoUsuarios = new List<ObjetoOrdenAtencion>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_OT_ID", new System.Collections.Hashtable() {
                                                                                                {"id",  id }
                                                                                            }
                );

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoOrdenAtencion();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Usuario");
                    resultadoListado.Usuario = validador != null ? data.Rows[i].Field<string>("Usuario") : "";



                    validador = data.Rows[i].Field<object>("Fecha");
                    resultadoListado.FechaIngreso = validador != null ? data.Rows[i].Field<DateTime>("Fecha") : DateTime.Parse("01-01-2100");




                    validador = data.Rows[i].Field<object>("TipoAtencion");
                    resultadoListado.TipoAtencion = validador != null ? data.Rows[i].Field<string>("TipoAtencion") : "";


                    validador = data.Rows[i].Field<object>("Requemiento");
                    resultadoListado.Requemiento = validador != null ? data.Rows[i].Field<string>("Requemiento") : "";




                    validador = data.Rows[i].Field<object>("TipoCliente");
                    resultadoListado.TipoCliente = validador != null ? data.Rows[i].Field<string>("TipoCliente") : "";



                    validador = data.Rows[i].Field<object>("NombreCliente");
                    resultadoListado.NombreCliente = validador != null ? data.Rows[i].Field<string>("NombreCliente") : "";



                    validador = data.Rows[i].Field<object>("NumeroContacto");
                    resultadoListado.NumeroContacto = validador != null ? data.Rows[i].Field<string>("NumeroContacto") : "";




                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "";


                    validador = data.Rows[i].Field<object>("UbicacionFisica");
                    resultadoListado.UbicacionFisica = validador != null ? data.Rows[i].Field<string>("UbicacionFisica") : "";

                    validador = data.Rows[i].Field<object>("Diganostico");
                    resultadoListado.Diganostico = validador != null ? data.Rows[i].Field<string>("Diganostico") : "";

                    validador = data.Rows[i].Field<object>("Solucion");
                    resultadoListado.Solucion = validador != null ? data.Rows[i].Field<string>("Solucion") : "";


                    validador = data.Rows[i].Field<object>("Responsable");
                    resultadoListado.Responsable = validador != null ? data.Rows[i].Field<string>("Responsable") : "";

                    validador = data.Rows[i].Field<object>("DescripcionSolucion");
                    resultadoListado.DescripcionSolucion = validador != null ? data.Rows[i].Field<string>("DescripcionSolucion") : "";





                    validador = data.Rows[i].Field<object>("FechaCierre");
                    resultadoListado.FechaCierre = validador != null ? data.Rows[i].Field<DateTime>("FechaCierre") : DateTime.Parse("01-01-2100");



                    validador = data.Rows[i].Field<object>("UsuarioCierre");
                    resultadoListado.UsuarioCierre = validador != null ? data.Rows[i].Field<string>("UsuarioCierre") : "";


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<string>("Estado") : "";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "";


                    validador = data.Rows[i].Field<object>("Maquina");
                    resultadoListado.Maquina = validador != null ? data.Rows[i].Field<string>("Maquina") : "";


                    validador = data.Rows[i].Field<object>("Modelo");
                    resultadoListado.Modelo = validador != null ? data.Rows[i].Field<string>("Modelo") : "";


                    validador = data.Rows[i].Field<object>("TipoMaquina");
                    resultadoListado.TipoMaquina = validador != null ? data.Rows[i].Field<string>("TipoMaquina") : "";


                    validador = data.Rows[i].Field<object>("Supervisor");
                    resultadoListado.Supervisor = validador != null ? data.Rows[i].Field<string>("Supervisor") : "";


                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }






        public List<ObjetoOrdenAtencion> ListadoComercial()
        {
            var ListadoUsuarios = new List<ObjetoOrdenAtencion>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_OT_Comercial", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoOrdenAtencion();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Usuario");
                    resultadoListado.Usuario = validador != null ? data.Rows[i].Field<string>("Usuario") : "";



                    validador = data.Rows[i].Field<object>("Fecha");
                    resultadoListado.FechaIngreso = validador != null ? data.Rows[i].Field<DateTime>("Fecha") : DateTime.Parse("01-01-2100");




                    validador = data.Rows[i].Field<object>("TipoAtencion");
                    resultadoListado.TipoAtencion = validador != null ? data.Rows[i].Field<string>("TipoAtencion") : "";


                    validador = data.Rows[i].Field<object>("Requemiento");
                    resultadoListado.Requemiento = validador != null ? data.Rows[i].Field<string>("Requemiento") : "";




                    validador = data.Rows[i].Field<object>("TipoCliente");
                    resultadoListado.TipoCliente = validador != null ? data.Rows[i].Field<string>("TipoCliente") : "";



                    validador = data.Rows[i].Field<object>("NombreCliente");
                    resultadoListado.NombreCliente = validador != null ? data.Rows[i].Field<string>("NombreCliente") : "";



                    validador = data.Rows[i].Field<object>("NumeroContacto");
                    resultadoListado.NumeroContacto = validador != null ? data.Rows[i].Field<string>("NumeroContacto") : "";




                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "";


                    validador = data.Rows[i].Field<object>("UbicacionFisica");
                    resultadoListado.UbicacionFisica = validador != null ? data.Rows[i].Field<string>("UbicacionFisica") : "";

                    validador = data.Rows[i].Field<object>("Diganostico");
                    resultadoListado.Diganostico = validador != null ? data.Rows[i].Field<string>("Diganostico") : "";

                    validador = data.Rows[i].Field<object>("Solucion");
                    resultadoListado.Solucion = validador != null ? data.Rows[i].Field<string>("Solucion") : "";


                    validador = data.Rows[i].Field<object>("Responsable");
                    resultadoListado.Responsable = validador != null ? data.Rows[i].Field<string>("Responsable") : "";

                    validador = data.Rows[i].Field<object>("DescripcionSolucion");
                    resultadoListado.DescripcionSolucion = validador != null ? data.Rows[i].Field<string>("DescripcionSolucion") : "";



                    validador = data.Rows[i].Field<object>("FechaCierre");
                    resultadoListado.FechaCierre = validador != null ? data.Rows[i].Field<DateTime>("FechaCierre") : DateTime.Parse("01-01-2100");



                    validador = data.Rows[i].Field<object>("UsuarioCierre");
                    resultadoListado.UsuarioCierre = validador != null ? data.Rows[i].Field<string>("UsuarioCierre") : "";


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<string>("Estado") : "";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "";


                    validador = data.Rows[i].Field<object>("Maquina");
                    resultadoListado.Maquina = validador != null ? data.Rows[i].Field<string>("Maquina") : "";


                    validador = data.Rows[i].Field<object>("Modelo");
                    resultadoListado.Modelo = validador != null ? data.Rows[i].Field<string>("Modelo") : "";


                    validador = data.Rows[i].Field<object>("TipoMaquina");
                    resultadoListado.TipoMaquina = validador != null ? data.Rows[i].Field<string>("TipoMaquina") : "";


                    validador = data.Rows[i].Field<object>("Supervisor");
                    resultadoListado.Supervisor = validador != null ? data.Rows[i].Field<string>("Supervisor") : "";


                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }



        public List<ObjetoOrdenAtencion> ConsultaTecnico()
        {
            var ListadoUsuarios = new List<ObjetoOrdenAtencion>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_OT_TECNICO", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoOrdenAtencion();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Usuario");
                    resultadoListado.Usuario = validador != null ? data.Rows[i].Field<string>("Usuario") : "";



                    validador = data.Rows[i].Field<object>("Fecha");
                    resultadoListado.FechaIngreso = validador != null ? data.Rows[i].Field<DateTime>("Fecha") : DateTime.Parse("01-01-2100");




                    validador = data.Rows[i].Field<object>("TipoAtencion");
                    resultadoListado.TipoAtencion = validador != null ? data.Rows[i].Field<string>("TipoAtencion") : "";


                    validador = data.Rows[i].Field<object>("Requemiento");
                    resultadoListado.Requemiento = validador != null ? data.Rows[i].Field<string>("Requemiento") : "";




                    validador = data.Rows[i].Field<object>("TipoCliente");
                    resultadoListado.TipoCliente = validador != null ? data.Rows[i].Field<string>("TipoCliente") : "";



                    validador = data.Rows[i].Field<object>("NombreCliente");
                    resultadoListado.NombreCliente = validador != null ? data.Rows[i].Field<string>("NombreCliente") : "";



                    validador = data.Rows[i].Field<object>("NumeroContacto");
                    resultadoListado.NumeroContacto = validador != null ? data.Rows[i].Field<string>("NumeroContacto") : "";




                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "";


                    validador = data.Rows[i].Field<object>("UbicacionFisica");
                    resultadoListado.UbicacionFisica = validador != null ? data.Rows[i].Field<string>("UbicacionFisica") : "";

                    validador = data.Rows[i].Field<object>("Diganostico");
                    resultadoListado.Diganostico = validador != null ? data.Rows[i].Field<string>("Diganostico") : "";

                    validador = data.Rows[i].Field<object>("Solucion");
                    resultadoListado.Solucion = validador != null ? data.Rows[i].Field<string>("Solucion") : "";


                    validador = data.Rows[i].Field<object>("Responsable");
                    resultadoListado.Responsable = validador != null ? data.Rows[i].Field<string>("Responsable") : "";

                    validador = data.Rows[i].Field<object>("DescripcionSolucion");
                    resultadoListado.DescripcionSolucion = validador != null ? data.Rows[i].Field<string>("DescripcionSolucion") : "";

                    validador = data.Rows[i].Field<object>("FechaCierre");
                    resultadoListado.FechaCierre = validador != null ? data.Rows[i].Field<DateTime>("FechaCierre") : DateTime.Parse("01-01-2100");



                    validador = data.Rows[i].Field<object>("UsuarioCierre");
                    resultadoListado.UsuarioCierre = validador != null ? data.Rows[i].Field<string>("UsuarioCierre") : "";


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<string>("Estado") : "";



                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "";


                    validador = data.Rows[i].Field<object>("Maquina");
                    resultadoListado.Maquina = validador != null ? data.Rows[i].Field<string>("Maquina") : "";


                    validador = data.Rows[i].Field<object>("Modelo");
                    resultadoListado.Modelo = validador != null ? data.Rows[i].Field<string>("Modelo") : "";


                    validador = data.Rows[i].Field<object>("TipoMaquina");
                    resultadoListado.TipoMaquina = validador != null ? data.Rows[i].Field<string>("TipoMaquina") : "";


                    validador = data.Rows[i].Field<object>("Supervisor");
                    resultadoListado.Supervisor = validador != null ? data.Rows[i].Field<string>("Supervisor") : "";



                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }




        public List<ObjetoOrdenAtencion> ConsultaOperaciones()
        {
            var ListadoUsuarios = new List<ObjetoOrdenAtencion>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_OT_OPERACIONES", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoOrdenAtencion();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.Id = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Usuario");
                    resultadoListado.Usuario = validador != null ? data.Rows[i].Field<string>("Usuario") : "";



                    validador = data.Rows[i].Field<object>("Fecha");
                    resultadoListado.FechaIngreso = validador != null ? data.Rows[i].Field<DateTime>("Fecha") : DateTime.Parse("01-01-2100");




                    validador = data.Rows[i].Field<object>("TipoAtencion");
                    resultadoListado.TipoAtencion = validador != null ? data.Rows[i].Field<string>("TipoAtencion") : "";


                    validador = data.Rows[i].Field<object>("Requemiento");
                    resultadoListado.Requemiento = validador != null ? data.Rows[i].Field<string>("Requemiento") : "";




                    validador = data.Rows[i].Field<object>("TipoCliente");
                    resultadoListado.TipoCliente = validador != null ? data.Rows[i].Field<string>("TipoCliente") : "";



                    validador = data.Rows[i].Field<object>("NombreCliente");
                    resultadoListado.NombreCliente = validador != null ? data.Rows[i].Field<string>("NombreCliente") : "";



                    validador = data.Rows[i].Field<object>("NumeroContacto");
                    resultadoListado.NumeroContacto = validador != null ? data.Rows[i].Field<string>("NumeroContacto") : "";




                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "";


                    validador = data.Rows[i].Field<object>("UbicacionFisica");
                    resultadoListado.UbicacionFisica = validador != null ? data.Rows[i].Field<string>("UbicacionFisica") : "";

                    validador = data.Rows[i].Field<object>("Diganostico");
                    resultadoListado.Diganostico = validador != null ? data.Rows[i].Field<string>("Diganostico") : "";

                    validador = data.Rows[i].Field<object>("Solucion");
                    resultadoListado.Solucion = validador != null ? data.Rows[i].Field<string>("Solucion") : "";


                    validador = data.Rows[i].Field<object>("Responsable");
                    resultadoListado.Responsable = validador != null ? data.Rows[i].Field<string>("Responsable") : "";

                    validador = data.Rows[i].Field<object>("DescripcionSolucion");
                    resultadoListado.DescripcionSolucion = validador != null ? data.Rows[i].Field<string>("DescripcionSolucion") : "";





                    validador = data.Rows[i].Field<object>("FechaCierre");
                    resultadoListado.FechaCierre = validador != null ? data.Rows[i].Field<DateTime>("FechaCierre") : DateTime.Parse("01-01-2100");



                    validador = data.Rows[i].Field<object>("UsuarioCierre");
                    resultadoListado.UsuarioCierre = validador != null ? data.Rows[i].Field<string>("UsuarioCierre") : "";


                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Estado = validador != null ? data.Rows[i].Field<string>("Estado") : "";


                    validador = data.Rows[i].Field<object>("Ruta");
                    resultadoListado.Ruta = validador != null ? data.Rows[i].Field<string>("Ruta") : "";


                    validador = data.Rows[i].Field<object>("Maquina");
                    resultadoListado.Maquina = validador != null ? data.Rows[i].Field<string>("Maquina") : "";


                    validador = data.Rows[i].Field<object>("Modelo");
                    resultadoListado.Modelo = validador != null ? data.Rows[i].Field<string>("Modelo") : "";


                    validador = data.Rows[i].Field<object>("TipoMaquina");
                    resultadoListado.TipoMaquina = validador != null ? data.Rows[i].Field<string>("TipoMaquina") : "";


                    validador = data.Rows[i].Field<object>("Supervisor");
                    resultadoListado.Supervisor = validador != null ? data.Rows[i].Field<string>("Supervisor") : "";

                    ListadoUsuarios.Add(resultadoListado);
                }
            }
            return ListadoUsuarios;

        }





        /// <summary>
        /// Metodo para Quitar permisos de modificacion a usuarios
        /// </summary>
        /// <param name="idUsuario">Id del usuario al que quitara el permiso</param>
        /// <returns>true o false segun corresponda</returns>
        public bool SetQuitaPermisoUsuario(int idUsuario)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_QUITAPERMISOUSUARIO", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"idUsuario", idUsuario}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }

        /// <summary>
        /// Metodo que consume SP para autorizar usuario
        /// </summary>
        /// <param name="idUsuario">Id Usuario al que le dan la autorización</param>
        /// <returns>True o false</returns>
        public bool SetAutorizaUsuario(int idUsuario)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_AUTORIZAUSUARIO", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"idUsuario", idUsuario}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }





        public bool SetModificaPedido(int id, int stock)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_ModificaPedido", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"id", id},
                                                                                                {"stock", stock}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }




        public bool SetActualizaConductor(string idguia, string idconductor, string Ruta, string IdCamion, string Vueltas, string Patente, string PlacaNroRemolque)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_UPDATE_CONDUCTOR", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", int.Parse(idguia.ToString())},
                                                                                                {"IdConductor", int.Parse(idconductor.ToString()) },
                                                                                                {"Ruta", Ruta.ToString() },
                                                                                                {"IdCamion", int.Parse(IdCamion.ToString()) },
                                                                                                {"Vueltas", int.Parse(Vueltas.ToString()) },
                                                                                                {"Patente", Patente },
                                                                                                {"PlacaNroRemolque", PlacaNroRemolque }
                                                                                            });


                respuesta = true;

            }
            catch (SqlException ex)
            {
                respuesta = false;
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                respuesta = false;
                new CapturaExcepciones(ex);
            }
            return respuesta;

        }



        public bool SetActualizaGuia(string Id,
                        string Patente,
                        string PlacaNroRemolque,
                        string RutEmisor,
                        string NroGuiaDespachoCliente,
                        DateTime FechaEmision,
                        string Toneladas,
                        DateTime FechaTimbre,
                        string Comentario,
                        string NumeroPedido,
                        string VueltasCompletadas,
                        string _Estado,
                        string IdDespacho)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_UPDATE_GUIA", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", int.Parse(Id.ToString())},
                                                                                                {"Patente", Patente },
                                                                                                {"PlacaNroRemolque", PlacaNroRemolque },
                                                                                                {"RutEmisor", RutEmisor },
                                                                                                {"NroGuiaDespachoCliente", NroGuiaDespachoCliente },
                                                                                                {"FechaEmision", FechaEmision },
                                                                                                {"Toneladas", Toneladas },
                                                                                                {"FechaTimbre", FechaTimbre },
                                                                                                {"Comentario", Comentario},
                                                                                                {"NumeroPedido ", int.Parse(NumeroPedido)},
                                                                                                {"VueltasCompletedas", VueltasCompletadas },
                                                                                                {"Estado", _Estado},
                                                                                                {"IdDespacho", int.Parse(IdDespacho)}
                                                                                            });


                respuesta = true;

            }
            catch (SqlException ex)
            {
                respuesta = false;
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                respuesta = false;
                new CapturaExcepciones(ex);
            }
            return respuesta;

        }



        /// <summary>
        /// Metodo para verificar usuario y evitar el ingreso de un usuario duplicado por RUT
        /// </summary>
        /// <param name="rutUsuario">Rut del usuario</param>
        /// <returns>1 si existe, 0 si no</returns>
        public bool GetVerificaUsuario(string rutUsuario)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_VALIDAUSUARIOINGRESO", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"RUT", rutUsuario}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }



        /// <summary>
        /// Metodo de grabacion de parametros de Origen
        /// </summary>
        /// <param name="origen">Objeto tipo Origen con todos los datos</param>
        /// <returns>True o False según resultado en la BD</returns>
        public bool SetGrabaParametrosTipoSistema(ObjetoTipoSistema tipoSistema)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GRABATIPOSISTEMA", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"idTipoSistema", tipoSistema.IdTipoSistema },
                                                                                                {"nombreSistema", tipoSistema.NombreSistema }
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }



        /// <summary>
        /// Listado de empresas disponible para para pago en caja
        /// </summary>
        /// <returns>lista empresas del sistema.</returns>
        public List<ObjetoEmpresas> ListadoEmpresas()
        {
            var ListadoEmpresas = new List<ObjetoEmpresas>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Empresas", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoEmpresas();
                    validador = data.Rows[i].Field<object>("Id");
                    resultadoListado.IdEmpresa = validador != null ? data.Rows[i].Field<int>("Id") : -1;

                    validador = data.Rows[i].Field<object>("Empresas");
                    resultadoListado.Nombre = validador != null ? data.Rows[i].Field<string>("Empresas") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Estado");
                    resultadoListado.Activo = validador != null ? data.Rows[i].Field<bool>("Estado") : true;

                    ListadoEmpresas.Add(resultadoListado);
                }
            }
            return ListadoEmpresas;
        }



        public List<ObjetoTraspaso> ListadoTraspaso()
        {
            var ListadoEmpresas = new List<ObjetoTraspaso>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_Traspaso", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoTraspaso();


                    resultadoListado.CpbAno = validador != null ? data.Rows[i].Field<string>("CpbAno") : "";
                    resultadoListado.CpbNum = validador != null ? data.Rows[i].Field<string>("CpbNum") : "";
                    resultadoListado.MovNum = validador != null ? data.Rows[i].Field<string>("MovNum") : "";
                    resultadoListado.AreaCod = validador != null ? data.Rows[i].Field<string>("AreaCod") : "";
                    resultadoListado.PctCod = validador != null ? data.Rows[i].Field<string>("PctCod") : "";
                    resultadoListado.CpbFec = validador != null ? data.Rows[i].Field<string>("CpbFec") : "";
                    resultadoListado.CpbMes = validador != null ? data.Rows[i].Field<string>("CpbMes") : "";
                    resultadoListado.CvCod = validador != null ? data.Rows[i].Field<string>("CvCod") : "";
                    resultadoListado.VendCod = validador != null ? data.Rows[i].Field<string>("VendCod") : "";
                    resultadoListado.UbicCod = validador != null ? data.Rows[i].Field<string>("UbicCod") : "";
                    resultadoListado.CajCod = validador != null ? data.Rows[i].Field<string>("CajCod") : "";
                    resultadoListado.IfCod = validador != null ? data.Rows[i].Field<string>("IfCod") : "";
                    resultadoListado.MovIfCant = validador != null ? data.Rows[i].Field<string>("MovIfCant") : "";
                    resultadoListado.DgaCod = validador != null ? data.Rows[i].Field<string>("DgaCod") : "";
                    resultadoListado.MovDgCant = validador != null ? data.Rows[i].Field<string>("MovDgCant") : "";
                    resultadoListado.CcCod = validador != null ? data.Rows[i].Field<string>("CcCod") : "";
                    resultadoListado.TipDocCb = validador != null ? data.Rows[i].Field<string>("CpbAno") : "";
                    resultadoListado.NumDocCb = validador != null ? data.Rows[i].Field<string>("NumDocCb") : "";
                    resultadoListado.CodAux = validador != null ? data.Rows[i].Field<string>("CodAux") : "";
                    resultadoListado.TtdCod = validador != null ? data.Rows[i].Field<string>("TtdCod") : "";
                    resultadoListado.NumDoc = validador != null ? data.Rows[i].Field<string>("NumDoc") : "";
                    resultadoListado.MovFe = validador != null ? data.Rows[i].Field<string>("MovFe") : "";
                    resultadoListado.MovFv = validador != null ? data.Rows[i].Field<string>("MovFv") : "";
                    resultadoListado.MovTipDocRef = validador != null ? data.Rows[i].Field<string>("MovTipDocRef") : "";
                    resultadoListado.MovNumDocRef = validador != null ? data.Rows[i].Field<string>("MovNumDocRef") : "";
                    resultadoListado.MovDebe = validador != null ? data.Rows[i].Field<string>("MovDebe") : "";
                    resultadoListado.MovHaber = validador != null ? data.Rows[i].Field<string>("MovHaber") : "";
                    resultadoListado.MovGlosa = validador != null ? data.Rows[i].Field<string>("MovGlosa") : "";
                    resultadoListado.MonCod = validador != null ? data.Rows[i].Field<string>("MonCod") : "";
                    resultadoListado.MovEquiv = validador != null ? data.Rows[i].Field<string>("MovEquiv") : "";
                    resultadoListado.MovDebeMa = validador != null ? data.Rows[i].Field<string>("MovDebeMa") : "";
                    resultadoListado.MovHaberMa = validador != null ? data.Rows[i].Field<string>("MovHaberMa") : "";
                    resultadoListado.MovNumCar = validador != null ? data.Rows[i].Field<string>("MovNumCar") : "";
                    resultadoListado.MovTC = validador != null ? data.Rows[i].Field<string>("MovTC") : "";
                    resultadoListado.MovNC = validador != null ? data.Rows[i].Field<string>("MovNC") : "";
                    resultadoListado.MovIPr = validador != null ? data.Rows[i].Field<string>("MovIPr") : "";
                    resultadoListado.MovAEquiv = validador != null ? data.Rows[i].Field<string>("MovAEquiv") : "";
                    resultadoListado.FecPag = validador != null ? data.Rows[i].Field<string>("CpbAno") : "";
                    resultadoListado.CODCPAG = validador != null ? data.Rows[i].Field<string>("CODCPAG") : "";
                    resultadoListado.CbaNumMov = validador != null ? data.Rows[i].Field<string>("CpbAno") : "";
                    resultadoListado.CbaAnoC = validador != null ? data.Rows[i].Field<string>("CbaAnoC") : "";
                    resultadoListado.GrabaDLib = validador != null ? data.Rows[i].Field<string>("GrabaDLib") : "";
                    resultadoListado.CpbOri = validador != null ? data.Rows[i].Field<string>("CpbOri") : "";
                    resultadoListado.CodBanco = validador != null ? data.Rows[i].Field<string>("CodBanco") : "";
                    resultadoListado.CodCtaCte = validador != null ? data.Rows[i].Field<string>("CodCtaCte") : "";
                    resultadoListado.MtoTotal = validador != null ? data.Rows[i].Field<string>("MtoTotal") : "";
                    resultadoListado.Cuota = validador != null ? data.Rows[i].Field<string>("Cuota") : "";
                    resultadoListado.CuotaRef = validador != null ? data.Rows[i].Field<string>("CuotaRef") : "";
                    resultadoListado.Marca = validador != null ? data.Rows[i].Field<string>("Marca") : "";
                    resultadoListado.fecEmisionch = validador != null ? data.Rows[i].Field<string>("fecEmisionch") : "";
                    resultadoListado.paguesea = validador != null ? data.Rows[i].Field<string>("paguesea") : "";
                    resultadoListado.Impreso = validador != null ? data.Rows[i].Field<string>("Impreso") : "";
                    resultadoListado.dlicoint_aperturas = validador != null ? data.Rows[i].Field<string>("dlicoint_aperturas") : "";
                    resultadoListado.nro_operacion = validador != null ? data.Rows[i].Field<string>("nro_operacion") : "";
                    resultadoListado.FormadePag = validador != null ? data.Rows[i].Field<string>("FormadePag") : "";
                    resultadoListado.CpbNormaIFRS = validador != null ? data.Rows[i].Field<string>("CpbNormaIFRS") : "";
                    resultadoListado.CpbNormaTrib = validador != null ? data.Rows[i].Field<string>("CpbNormaTrib") : "";




                    ListadoEmpresas.Add(resultadoListado);
                }
            }
            return ListadoEmpresas;
        }








        /// <summary>
        /// Metodo para grabar un nuevo usuario
        /// </summary>
        /// <param name="usuario">Objeto del tipo usuario con todos los datos</param>
        /// <returns>valor mayor a 1 si el grabado resulta OK, 0 si hay error. </returns>
        public bool SetGrabaUsuario(ObjetoUsuarios usuario)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GRABAUSUARIO", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"rutUsuario", usuario.RutUsuario},
                                                                                                {"pass", usuario.Pass },
                                                                                                {"nombreUsuario", usuario.NombreUsuario },
                                                                                                {"idPerfil", usuario.IdPerfil },
                                                                                                {"Email", usuario.Email} 
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }

        public List<ObjetoInforme> ListadaoSabanaDatos()
        {
            var ListadoSeguimientoContrato = new List<ObjetoInforme>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_SABANA_TAMARUGAL", new System.Collections.Hashtable());

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoInforme();


                    validador = data.Rows[i].Field<object>("NroContrato");
                    resultadoListado.NroContrato = validador != null ? data.Rows[i].Field<string>("NroContrato") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Cliente");
                    resultadoListado.Cliente = validador != null ? data.Rows[i].Field<string>("Cliente") : "NO ASIGNADO";



                    validador = data.Rows[i].Field<object>("FechaInicio");
                    resultadoListado.FechaInicio = validador != null ? data.Rows[i].Field<DateTime>("FechaInicio") : DateTime.Parse("01-01-1900");


                    validador = data.Rows[i].Field<object>("FechaTermino");
                    resultadoListado.FechaTermino = validador != null ? data.Rows[i].Field<DateTime>("FechaTermino") : DateTime.Parse("01-01-1900");



                    validador = data.Rows[i].Field<object>("Servicio");
                    resultadoListado.Servicio = validador != null ? data.Rows[i].Field<string>("Servicio") : "NO ASIGNADO";
                    validador = data.Rows[i].Field<object>("Codigo");
                    resultadoListado.Codigo = validador != null ? data.Rows[i].Field<string>("Codigo") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Descripcion");
                    resultadoListado.Descripcion = validador != null ? data.Rows[i].Field<string>("Descripcion") : "NO ASIGNADO";
                    validador = data.Rows[i].Field<object>("UnidadMedida");
                    resultadoListado.UnidadMedida = validador != null ? data.Rows[i].Field<string>("UnidadMedida") : "NO ASIGNADO";


                    validador = data.Rows[i].Field<object>("Cantidad");
                    resultadoListado.Cantidad = validador != null ? data.Rows[i].Field<decimal>("Cantidad") : 0;

                    validador = data.Rows[i].Field<object>("Valor");
                    resultadoListado.Valor = validador != null ? data.Rows[i].Field<decimal>("Valor") : 0;


                    validador = data.Rows[i].Field<object>("Vueltas");
                    resultadoListado.Vueltas = validador != null ? data.Rows[i].Field<int>("Vueltas") : 0;


                    validador = data.Rows[i].Field<object>("Patente");
                    resultadoListado.Patente = validador != null ? data.Rows[i].Field<string>("Patente") : "";



                    validador = data.Rows[i].Field<object>("Conductor");
                    resultadoListado.Conductor = validador != null ? data.Rows[i].Field<string>("Conductor") : "";


                    ListadoSeguimientoContrato.Add(resultadoListado);
                }
            }
            return ListadoSeguimientoContrato;
        }


        public bool SetGrabaTamarugalRecepcionGuia(ObjetoGuiaRecepcion guia)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaTamarugalRecepcionGuia", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", guia.Id},
                                                                                                {"NroContrato", guia.NroContrato },
                                                                                                {"NroGuiaDespacho", guia.NroGuiaDespacho },
                                                                                                {"IdGuiaExpedicion", guia.IdGuiaExpedicion },
                                                                                                { "NroViajes", guia.NroViajes},
                                                                                                {"IdRuta", guia.IdRuta},
                                                                                                {"FechaRetiro", guia.FechaRetiro},
                                                                                                {"FechaEntrega", guia.FechaEntrega},
                                                                                                {"Toneladas", guia.Toneladas},
                                                                                                {"IdPeaje", guia.IdPeaje},
                                                                                                {"Valor", guia.Valor},
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }




        /// <returns>valor mayor a 1 si el grabado resulta OK, 0 si hay error. </returns>
        public int SetGrabaTamarugalGuiaExpedicion(ObjetoGuiaExpedicion guia)
        {
            int respuesta = 0;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaTamarugalGuiaExpedicion", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", guia.Id},
                                                                                                {"IdContrato", guia.IdContrato },
                                                                                                {"IdServicio", guia.IdServicio },
                                                                                                {"IdConductor", guia.IdConductor},
                                                                                                {"NumeroPedido", guia.NroPedido },
                                                                                                {"IdPedido", guia.IdPedido }
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = int.Parse(data.Rows[0][0].ToString());
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }



        public int SetGrabaTamarugalDetalleGuiaExpedicion(ObjetoGuiaDetalleExpedicion guia)
        {
            int respuesta = 0;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaTamarugalDetalleGuiaExpedicion", new System.Collections.Hashtable()
                                                                                            {
                                                                {"Id", guia.Id},
                                                                {"IdGuiaExpedicion", guia.IdGuia },
                                                                {"NumeroPedido", guia.NroPedido },
                                                                {"NroContrato", guia.NroContrato },
                                                                {"IdConductor", guia.IdConductor },
                                                                {"Cliente", guia.Cliente},
                                                                {"Servicio", guia.Servicio },
                                                                {"Ruta", guia.Ruta },
                                                                {"Cantidad", guia.Cantidad },
                                                                {"Vueltas", guia.Vueltas },
                                                                {"Patente", guia.Patente  },
                                                                {"NroRemolque", guia.Remolque },
                                                                {"Estado", guia.Estado }
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = int.Parse(data.Rows[0][0].ToString());
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }








        /// <returns>valor mayor a 1 si el grabado resulta OK, 0 si hay error. </returns>
        public int SetGrabaTamarugalPedido(ObjetoPedido pedido)
        {
            int respuesta = 0;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaTamarugalPedido", new System.Collections.Hashtable()
                                                                                            {
                                                                                            { "Id", pedido.Id},
                                                                                            { "IdContrato", pedido.IdContrato},
                                                                                            { "IdServicio", pedido.IdServicio},
                                                                                            { "Cliente", pedido.Cliente},
                                                                                            { "Ruta", pedido.Ruta},
                                                                                            { "FechaInicio", pedido.FechaInicio},
                                                                                            { "FechaFin", pedido.FechaFin},
                                                                                            { "Cantidad", pedido.Cantidad},
                                                                                            { "UnidadMedida", pedido.UnidadMedida},
                                                                                            { "Estado", pedido.Estado}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = int.Parse(data.Rows[0][0].ToString());
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }


        public int SetGrabaOrdenAtencion(ObjetoOrdenAtencion ordenAtencion)
        {
            int respuesta = 0;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_OrdenAtencion", new System.Collections.Hashtable()
                                                                                            {
                                                                                     { "Id", ordenAtencion.Id},
                                                                                     { "Usuario", ordenAtencion.Usuario},
                                                                                     { "TipoAtencion", ordenAtencion.TipoAtencion},
                                                                                     { "Requemiento", ordenAtencion.Requemiento},
                                                                                     { "TipoCliente", ordenAtencion.TipoCliente},
                                                                                     { "NombreCliente", ordenAtencion.NombreCliente},
                                                                                     { "NumeroContacto", ordenAtencion.NumeroContacto},
                                                                                     { "Descripcion", ordenAtencion.Descripcion},
                                                                                     { "UbicacionFisica", ordenAtencion.UbicacionFisica},
                                                                                     { "Diganostico", ordenAtencion.Diganostico},
                                                                                     { "Solucion", ordenAtencion.Solucion},
                                                                                     { "Responsable", ordenAtencion.Responsable},
                                                                                     { "DescripcionSolucion", ordenAtencion.DescripcionSolucion},
                                                                                     { "FechaCierre", ordenAtencion.FechaCierre},
                                                                                     { "UsuarioCierre", ordenAtencion.Usuario},
                                                                                     { "Estado", ordenAtencion.Estado},
                                                                                     { "Ruta", ordenAtencion.Ruta},
                                                                                     { "Maquina", ordenAtencion.Maquina},
                                                                                     { "Modelo", ordenAtencion.Modelo},
                                                                                     { "TipoMaquina", ordenAtencion.TipoMaquina},
                                                                                     { "Supervisor", ordenAtencion.Supervisor}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = int.Parse(data.Rows[0][0].ToString());
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }






        public bool SetGrabaTamarugalDetalleContrato(ObjetoSeguimientoDetalleContrato ClienteContratoDetalle)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaTamarugalDetalleContrato", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", ClienteContratoDetalle.Id},
                                                                                                {"IdContrato", ClienteContratoDetalle.IdContrato},
                                                                                                {"Servicio", ClienteContratoDetalle.Servicio},
                                                                                                {"Ruta", ClienteContratoDetalle.Ruta},
                                                                                                {"Valor", ClienteContratoDetalle.Valor},
                                                                                                {"UnidadMedida", ClienteContratoDetalle.UnidadMedida},
                                                                                                {"Cantidad", ClienteContratoDetalle.Cantidad},
                                                                                                {"Detalle", ClienteContratoDetalle.Detalle}
                });
                if (data.Rows.Count > 0)
                {

                    respuesta = true;

                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }


        public int SetGrabaTamarugalClienteContrato(ObjetoSeguimientoContrato ClienteContrato)
        {
            int respuesta = 0;
            try
            {

                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaTamarugalClienteContrato", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", ClienteContrato.Id},
                                                                                                {"Cliente", ClienteContrato.Cliente},
                                                                                                {"NroContrato", ClienteContrato.NroContrato},
                                                                                                {"FechaInicio", ClienteContrato.FechaInicio},
                                                                                                {"FechaTermino", ClienteContrato.FechaTermino},
                                                                                                {"IdSucursal", ClienteContrato.IdSucursal},
                                                                                                {"Valor", ClienteContrato.Valor},
                                                                                                {"Moneda", ClienteContrato.Moneda} ,
                                                                                                {"Comentario", ClienteContrato.Comentario}
                                                                                                                });
                if (data.Rows.Count > 0)
                {
                    respuesta = int.Parse(data.Rows[0][0].ToString());

                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }



        public bool setGrabaSeguimientoPedido(ObjetoSeguimientoPedido seguimientoPedido)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaSeguimientoPedido", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", seguimientoPedido.Id},
                                                                                                {"CodigoLocal", seguimientoPedido.CodigoLocal},
                                                                                                {"NombreLocal", seguimientoPedido.NombreLocal },
                                                                                                {"FechaPicking", seguimientoPedido.FechaPicking},
                                                                                                {"Operador", seguimientoPedido.Operador },
                                                                                                {"Estado", seguimientoPedido.Estado},
                                                                                                {"HoraInicio", seguimientoPedido.HoraInicio},
                                                                                                {"HoraTermino", seguimientoPedido.HoraTermino},
                                                                                                {"Documento", seguimientoPedido.Documento}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }



        public bool setGrabaModificaSeguimientoPedido(ObjetoSeguimientoPedido seguimientoPedido)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_ModificaSeguimientoPedido", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", seguimientoPedido.Id},
                                                                                                {"Operador", seguimientoPedido.Operador },
                                                                                                {"Estado", seguimientoPedido.Estado}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }




        public bool setGrabaDetalleSeguimientoPedido(ObjetoDetalleSeguimientoPedido DetalleSeguimientoPedido)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaDetalleSeguimientoPedido", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", DetalleSeguimientoPedido.Id},
                                                                                                {"IdSeguimientoPedido", DetalleSeguimientoPedido.IdSeguimientoPedido},
                                                                                                {"CodigoProducto", DetalleSeguimientoPedido.CodigoProducto},
                                                                                                {"NombreProducto", DetalleSeguimientoPedido.NombreProducto},
                                                                                                {"StockMinimo", DetalleSeguimientoPedido.StockMinimo},
                                                                                                {"StockMaximo", DetalleSeguimientoPedido.StockMaximo},
                                                                                                {"StockReposicion", DetalleSeguimientoPedido.StockReposicion}
                                                                                            });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }







        public bool SetGrabaRuta(ObjetoDestinos destinos)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaRutaPeaje", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", destinos.Id},
                                                                                                {"Ruta",destinos.Ruta },
                                                                                                {"Plaza", destinos.Plaza}
                });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }






        public bool SetGrabaGasto(ObjetoRendicionGasto gasto)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaGasto", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", gasto.Id},
                                                                                                {"Contrato",gasto.Contrato },
                                                                                                {"IdGuia", gasto.IdGuia},
                                                                                                {"IdPedido", gasto.IdPedido},
                                                                                                {"Gasto", gasto.Gasto},
                                                                                                {"Valor", gasto.Valor},
                                                                                                {"NroTicket", gasto.NroTicket},
                                                                                                {"Fecha", gasto.Fecha}
                });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }



        public bool SetGrabaTamarugalPeaje(ObjetoTamarugalPeaje peaje)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaTamarugalPeaje", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", peaje.Id},
                                                                                                {"Nombre", peaje.Nombre},
                                                                                                {"Valor", peaje.Valor},
                                                                                                {"Estado", peaje.Estado},
                });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }



        public bool SetGrabaTamarugalSucursal(ObjetoSucursal sucursal)
        {
            var respuesta = false;
            try
            {
                var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_SET_GrabaTamarugalSucursal", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"Id", sucursal.Id},
                                                                                                {"Nombre", sucursal.Nombre},
                                                                                                {"Estado", sucursal.Estado},
                });
                if (data.Rows.Count > 0)
                {
                    respuesta = true;
                }
            }
            catch (SqlException ex)
            {
                new CapturaExcepciones(ex);
            }
            catch (Exception ex)
            {
                new CapturaExcepciones(ex);
            }
            return respuesta;
        }







        /// <summary>
        /// Metodo Menu
        /// Segun el ID del usuario, carga el menu para la aplicacion, siendo Abogado o Receptor.
        /// </summary>
        /// <param name="idUsuario">ID del usuario Logueado</param>
        /// <returns>Lista de Menú a ser consumida por Helper Menú</returns>
        public List<ObjetoMenu> MenuUsuario(int idUsuario)
        {
            var listadoMenu = new List<ObjetoMenu>();
            var data = new DBConector().EjecutarProcedimientoAlmacenado("SP_GET_ListaMenu", new System.Collections.Hashtable()
                                                                                            {
                                                                                                {"idTipoRegistro", idUsuario}
                                                                                            });

            if (data.Rows.Count > 0)
            {
                for (var i = 0; i < data.Rows.Count; i++)
                {
                    var validador = new object();
                    var resultadoListado = new ObjetoMenu();
                    validador = data.Rows[i].Field<object>("id_Menu");
                    resultadoListado.IdMenu = validador != null ? data.Rows[i].Field<int>("id_Menu") : -1;

                    validador = data.Rows[i].Field<object>("Clase");
                    resultadoListado.Clase = validador != null ? data.Rows[i].Field<string>("Clase") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("PieMenu");
                    resultadoListado.PieMenu = validador != null ? data.Rows[i].Field<string>("PieMenu") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Titulo");
                    resultadoListado.Titulo = validador != null ? data.Rows[i].Field<string>("Titulo") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Action");
                    resultadoListado.Accion = validador != null ? data.Rows[i].Field<string>("Action") : "NO ASIGNADO";

                    validador = data.Rows[i].Field<object>("Controler");
                    resultadoListado.Controller = validador != null ? data.Rows[i].Field<string>("Controler") : "NO ASIGNADO";


                    listadoMenu.Add(resultadoListado);
                }
            }
            return listadoMenu;
        }

    }
}
