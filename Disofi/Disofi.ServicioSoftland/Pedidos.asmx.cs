using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Disofi.ServicioSoftland
{
    /// <summary>
    /// Descripción breve de Pedidos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Pedidos : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet ListadoPedidoPorOperador(string operador)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_GET_PedidoOperador", new System.Collections.Hashtable(){
                                                                                                {"Operador", operador}
                                                                                            });

            return data;
        }

        [WebMethod]
        public DataSet ListadoProductoPicking(string idPedido, string operador)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_GET_PedidoOperador", new System.Collections.Hashtable(){
                                                                                                {"Operador", operador}
                                                                                            });

            return data;
        }

        [WebMethod]
        public DataSet GuardarEstadoPicketo(string operador)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_GET_PedidoOperador", new System.Collections.Hashtable(){
                                                                                                {"Operador", operador}
                                                                                            });

            return data;
        }


        [WebMethod]
        public DataSet PedidoPorPickiador(string operador)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_GET_PedidoPorPickiador", new System.Collections.Hashtable(){
                                                                                                {"Operador", operador}
                                                                                            });

            return data;
        }

        
        [WebMethod]
        public DataSet ListaUsuarioPicking()
        { 

            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_GET_Login_Nombre", new System.Collections.Hashtable()
                                                                                           );


            return data;
        }



        [WebMethod]
        public DataSet DetallePedidoId(int idpedido)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_GET_DetalleSeguimientoPedidoId", new System.Collections.Hashtable(){
                                                                                                {"idPedido", idpedido}
                                                                                            });

            return data;
        }


        [WebMethod]
        public DataSet FinDetallePedidoId(int idpedido)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_FIN_Pedido", new System.Collections.Hashtable(){
                                                                                                {"idPedido", idpedido}
                                                                                            });

            return data;
        }






        


        [WebMethod]
        public DataSet FinalizarDetallePedidoId(int idpedido)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_SET_GrabaModSeguimientoPedido", new System.Collections.Hashtable(){
                                                                                                {"idPedido", idpedido}
                                                                                            });

            return data;
        }




        [WebMethod]
        public DataSet BuscarCodigo(string idpedido, string codigo)
        {
            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_GET_DetalleSeguimientoCodigo", new System.Collections.Hashtable(){
                                                                                                {"idPedido", int.Parse(idpedido)},
                                                                                                {"codigo", codigo}
                                                                                            });

            return data;
        }



        [WebMethod]
        public DataSet ActualizaEstadoPicking(string lote, string estado, string stockcapturado,string  codigo, int IdSeguimiento)
        {
 

            DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_SET_UpdateDetalleSeguimientoPedido", new System.Collections.Hashtable(){
                                                                {"@Lote", codigo},
                                                                {"@Estado", estado},
                                                                {"@stockCapturado", stockcapturado},
                                                                {"@Codigo", codigo},
                                                                {"@IdSeguimiento", IdSeguimiento }
                                                                                            });

            return data;
        }


    }
}
