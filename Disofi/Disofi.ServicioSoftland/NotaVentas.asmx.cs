using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Disofi.ServicioSoftland
{
    /// <summary>
    /// Descripción breve de NotaVentas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class NotaVentas : System.Web.Services.WebService
    { 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cabecera NotaVenta "></param>
        /// <returns>True</returns>
        /// <exception cref="Cuando grabo correctamente"
        /// 
        /// <summary>
        /// <pr>Cuando se grabar con error devuelve excpiontion del contralador error del framework</pr>
        /// </summary>


        [WebMethod]
        public bool GrabarNotaVenta(ObjetoWsdl.NotaVenta NotaVenta)
        {
            try
            {
                DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_SET_GrabaNotaVenta", new System.Collections.Hashtable(){
                                                                                                        {"NVNumero", NotaVenta.NVNumero },
                                                                                                        {"nvFem", NotaVenta.nvFem},
                                                                                                        {"nvEstado", NotaVenta.nvEstado},
                                                                                                        {"nvEstFact", NotaVenta.nvEstFact},
                                                                                                        {"nvEstDesp", NotaVenta.nvEstDesp},
                                                                                                        {"nvEstRese", NotaVenta.nvEstRese},
                                                                                                        {"nvEstConc", NotaVenta.nvEstConc},
                                                                                                        {"CotNum", NotaVenta.CotNum},
                                                                                                        {"NumOC", NotaVenta.NumOC},
                                                                                                        {"nvFeEnt", NotaVenta.nvFeEnt},
                                                                                                        {"CodAux", NotaVenta.CodAux},
                                                                                                        {"VenCod", NotaVenta.VenCod},
                                                                                                        {"CodMon", NotaVenta.CodMon},
                                                                                                        {"CodLista", NotaVenta.CodLista},
                                                                                                        {"nvObser", NotaVenta.nvObser},
                                                                                                        {"nvCanalNV", NotaVenta.nvCanalNV},
                                                                                                        {"CveCod", NotaVenta.CveCod},
                                                                                                        {"NomCon", NotaVenta.NomCon},
                                                                                                        {"CodiCC", NotaVenta.CodiCC},
                                                                                                        {"CodBode", NotaVenta.CodBode},
                                                                                                        {"nvSubTotal", NotaVenta.nvSubTotal},
                                                                                                        {"nvPorcDesc01", NotaVenta.nvPorcDesc01},
                                                                                                        {"nvDescto01", NotaVenta.nvDescto01},
                                                                                                        {"nvPorcDesc02", NotaVenta.nvPorcDesc02},
                                                                                                        {"nvDescto02", NotaVenta.nvDescto02},
                                                                                                        {"nvPorcDesc03", NotaVenta.nvPorcDesc03},
                                                                                                        {"nvDescto03", NotaVenta.nvDescto03},
                                                                                                        {"nvPorcDesc04", NotaVenta.nvPorcDesc04},
                                                                                                        {"nvDescto04", NotaVenta.nvDescto04},
                                                                                                        {"nvPorcDesc05", NotaVenta.nvPorcDesc05},
                                                                                                        {"nvDescto05", NotaVenta.nvDescto05},
                                                                                                        {"nvMonto", NotaVenta.nvMonto},
                                                                                                        {"nvFeAprob", NotaVenta.nvFeAprob},
                                                                                                        {"NumGuiaRes", NotaVenta.NumGuiaRes},
                                                                                                        {"nvPorcFlete", NotaVenta.nvPorcFlete},
                                                                                                        {"nvValflete", NotaVenta.nvValflete},
                                                                                                        {"nvPorcEmb", NotaVenta.nvPorcEmb},
                                                                                                        {"nvValEmb", NotaVenta.nvValEmb},
                                                                                                        {"nvEquiv", NotaVenta.nvEquiv},
                                                                                                        {"nvNetoExento", NotaVenta.nvNetoExento},
                                                                                                        {"nvNetoAfecto", NotaVenta.nvNetoAfecto},
                                                                                                        {"nvTotalDesc", NotaVenta.nvTotalDesc},
                                                                                                        {"ConcAuto", NotaVenta.ConcAuto},
                                                                                                        {"CodLugarDesp", NotaVenta.CodLugarDesp},
                                                                                                        {"SolicitadoPor", NotaVenta.SolicitadoPor},
                                                                                                        {"DespachadoPor", NotaVenta.DespachadoPor},
                                                                                                        {"Patente", NotaVenta.Patente},
                                                                                                        {"RetiradoPor", NotaVenta.RetiradoPor},
                                                                                                        {"CheckeoPorAlarmaVtas", NotaVenta.CheckeoPorAlarmaVtas},
                                                                                                        {"EnMantencion", NotaVenta.EnMantencion},
                                                                                                        {"Usuario", NotaVenta.Usuario},
                                                                                                        {"UsuarioGeneraDocto", NotaVenta.UsuarioGeneraDocto},
                                                                                                        {"FechaHoraCreacion", NotaVenta.FechaHoraCreacion},
                                                                                                        {"Sistema", NotaVenta.Sistema},
                                                                                                        {"ConcManual", NotaVenta.ConcManual},
                                                                                                        {"RutSolicitante", NotaVenta.RutSolicitante},
                                                                                                        {"proceso", NotaVenta.proceso},
                                                                                                        {"TotalBoleta", NotaVenta.TotalBoleta},
                                                                                                        {"NumReq", NotaVenta.NumReq},
                                                                                                        {"CodBodeWms", NotaVenta.CodBodeWms},
                                                                                                        {"CodLugarDocto", NotaVenta.CodLugarDocto},
                                                                                                        {"RutTransportista", NotaVenta.RutTransportista},
                                                                                                        {"Cod_Distrib", NotaVenta.Cod_Distrib},
                                                                                                        {"Nom_Distrib", NotaVenta.Nom_Distrib}
                    });

                return true;
            }
            catch (Exception ex)
            {
               
                return false;
                throw;
            }
            
        }

        [WebMethod]
        public bool GrabarDetalleNotaVenta(ObjetoWsdl.DetalleNotaVenta detalle)
        {
            try
            {
                DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("SP_SET_GrabaDetalleNotaVenta", new System.Collections.Hashtable(){
                                                                                                       {"nvFem", detalle.nvFem},
                                                                                                        {"nvEstado", detalle.nvEstado},
                                                                                                        {"nvEstFact", detalle.nvEstFact},
                                                                                                        {"nvEstDesp", detalle.nvEstDesp},
                                                                                                        {"nvEstRese", detalle.nvEstRese},
                                                                                                        {"nvEstConc", detalle.nvEstConc},
                                                                                                        {"CotNum", detalle.CotNum},
                                                                                                        {"NumOC", detalle.NumOC},
                                                                                                        {"nvFeEnt", detalle.nvFeEnt},
                                                                                                        {"CodAux", detalle.CodAux},
                                                                                                        {"VenCod", detalle.VenCod},
                                                                                                        {"CodMon", detalle.CodMon},
                                                                                                        {"CodLista", detalle.CodLista},
                                                                                                        {"nvObser", detalle.nvObser},
                                                                                                        {"nvCanalNV", detalle.nvCanalNV},
                                                                                                        {"CveCod", detalle.CveCod},
                                                                                                        {"NomCon", detalle.NomCon},
                                                                                                        {"CodiCC", detalle.CodiCC},
                                                                                                        {"CodBode", detalle.CodBode},
                                                                                                        {"nvSubTotal", detalle.nvSubTotal},
                                                                                                        {"nvPorcDesc01", detalle.nvPorcDesc01},
                                                                                                        {"nvDescto01", detalle.nvDescto01},
                                                                                                        {"nvPorcDesc02", detalle.nvPorcDesc02},
                                                                                                        {"nvDescto02", detalle.nvDescto02},
                                                                                                        {"nvPorcDesc03", detalle.nvPorcDesc03},
                                                                                                        {"nvDescto03", detalle.nvDescto03},
                                                                                                        {"nvPorcDesc04", detalle.nvPorcDesc04},
                                                                                                        {"nvDescto04", detalle.nvDescto04},
                                                                                                        {"nvPorcDesc05", detalle.nvPorcDesc05},
                                                                                                        {"nvDescto05", detalle.nvDescto05},
                                                                                                        {"nvMonto", detalle.nvMonto},
                                                                                                        {"nvFeAprob", detalle.nvFeAprob},
                                                                                                        {"NumGuiaRes", detalle.NumGuiaRes},
                                                                                                        {"nvEquiv", detalle.nvEquiv},
                                                                                                        {"nvNetoExento", detalle.nvNetoExento},
                                                                                                        {"nvNetoAfecto", detalle.nvNetoAfecto},
                                                                                                        {"nvTotalDesc", detalle.nvTotalDesc},
                                                                                                        {"ConcAuto", detalle.ConcAuto},
                                                                                                        {"CodLugarDesp", detalle.CodLugarDesp},
                                                                                                        {"SolicitadoPor", detalle.SolicitadoPor},
                                                                                                        {"DespachadoPor", detalle.DespachadoPor},
                                                                                                        {"Patente", detalle.Patente},
                                                                                                        {"RetiradoPor", detalle.RetiradoPor},
                                                                                                        {"CheckeoPorAlarmaVtas", detalle.CheckeoPorAlarmaVtas},
                                                                                                        {"EnMantencion", detalle.EnMantencion},
                                                                                                        {"Usuario", detalle.Usuario},
                                                                                                        {"UsuarioGeneraDocto", detalle.UsuarioGeneraDocto},
                                                                                                        {"FechaHoraCreacion", detalle.FechaHoraCreacion},
                                                                                                        {"Sistema", detalle.Sistema},
                                                                                                        {"proceso", detalle.proceso},
                                                                                                        {"TotalBoleta", detalle.TotalBoleta},
                                                                                                        {"NumReq", detalle.NumReq},
                                                                                                        {"CodBodeWms", detalle.CodBodeWms} });

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }

        }
        [WebMethod]
        public bool GrabarDetalle_nw_impto(ObjetoWsdl.nw_impto nw_impto)
        {
            try
            {
                DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("nw_impto", new System.Collections.Hashtable(){
                                                                                                       {"nvFem", nw_impto.nvFem},
                                                                                                        {"nvEstado", nw_impto.nvEstado},
                                                                                                        {"nvEstFact", nw_impto.nvEstFact},
                                                                                                        {"nvEstDesp", nw_impto.nvEstDesp},
                                                                                                   });

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }

        }

        [WebMethod]
        public bool Grabar_iw_timprod(ObjetoWsdl.iw_timprod iw_timprod)
        {
            try
            {
                DataSet data = new DBConector().EjecutarProcedimientoAlmacenado2("Graba_iw_timprod", new System.Collections.Hashtable(){
                                                                                                       {"nvFem", iw_timprod.nvFem},
                                                                                                        {"nvEstado", iw_timprod.nvEstado}, 
                                                                                                        {"CodBodeWms", iw_timprod.CodBodeWms} });

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }

        }


    }
}
