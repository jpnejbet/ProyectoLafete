using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Disofi.ServicioSoftland
{
    /// <summary>
    /// Descripción breve de Maestros
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Maestros : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet ListadoBodega()
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetLocales", new System.Collections.Hashtable());
            return data;
        }


        [WebMethod]
        public DataSet ListadoProductos()
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetProductos", new System.Collections.Hashtable());
            return data;
        }




        [WebMethod]
        public DataSet ListadoUsuarios()
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetUsuarios", new System.Collections.Hashtable());
            return data;
        }



        [WebMethod]
        public DataSet ListadoUsuariosNombre(string nombre)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetUsuariosNombre", new System.Collections.Hashtable()  {
                                                                                                {"nombre", nombre}
                                                                                            });

            return data;
        }



        [WebMethod]
        public DataSet ListadoLocalesProductos()
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetLocalesProductos", new System.Collections.Hashtable());
            return data;
        }



        [WebMethod]
        public DataSet ListadoProductoPorLocales(string Locales)
        {
            try
            {
                DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetLocalesProductos", new System.Collections.Hashtable());
                return data;
            }

            catch (Exception)
            {

                throw;
            }
        }

        [WebMethod]
        public DataSet ListadoClientes()
        {
            try
            {
                DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetCliente", new System.Collections.Hashtable());
                return data;
            }

            catch (Exception)
            {

                throw;
            }
        }




        [WebMethod]
        public DataSet ListadoPorProducto(string productos)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetLocalesProductos", new System.Collections.Hashtable());
            return data;
        }


        [WebMethod]
        public DataSet ListadoPorProductoAgrupado(string codigoBodega)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado("Disofi_GetProductosAgrupado", new System.Collections.Hashtable() { { "bodega", codigoBodega }  }
              
            );
            return data;
        }





    }
}
