using Disofi.UTIL.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.BLL
{
    public class ControlDisofi
    {
        private FactoryAccesos _dtFac = new FactoryAccesos();


        public List<ObjetoLogin> Login(string rut, string pass)
        {
            return _dtFac.LoginUsuario(rut, pass);
        }


        public List<ObjetoUsuarios> ListadoUsuarios()
        {
            return _dtFac.ListadoUsuarios();
        }


        public List<ObjetoTraspaso> ListadoTraspaso()
        {
            return _dtFac.ListadoTraspaso();
        }



        public List<ObjetoCodigoSC> ListadoDiagnosticoSC()
        {
            return _dtFac.ListadoDiagnosticoSC();
        }
        public List<ObjetoCodigoSC> ListadoSolucionSC()
        {
            return _dtFac.ListadoSolucionSC();
        }


        public List<ObjetoSeguimientoPedido> ListadoSeguimientoPreparacion()
        {
            return _dtFac.ListadoSeguimientoPreparacion();
        }



        public List<ObjetoSeguimientoPedido> ListadoSeguimientoPeidido()
        {
            return _dtFac.ListadoSeguimientoPeidido();
        }


        public List<ObjetoOrdenAtencion> ListadoComercial()
        {
            return _dtFac.ListadoComercial();
        }


        public List<ObjetoOrdenAtencion> ConsultaTecnico()
        {
            return _dtFac.ConsultaTecnico();
        }


        public List<ObjetoOrdenAtencion> ConsultaOperaciones()
        {
            return _dtFac.ConsultaOperaciones();
        }



        public List<ObjetoOrdenAtencion> ListadoOrdenAtencionId(int id)
        {
            return _dtFac.ListadoOrdenAtencionId(id);
        }






        public List<ObjetoProductos> ListadoProductos()
        {
            return _dtFac.ListadoProductos();
        }

        public List<ObjetoProductos> ListadoProductosSoftland(string grupo)
        {
            return _dtFac.ListadoProductosSoftland(grupo);
        }



        public List<ObjetoProductos> ListadoProductosId(string id)
        {
            return _dtFac.ListadoProductosId(id);
        }



        public List<ObjetoRuta> ListadoRutaContradoId(string id)
        {
            return _dtFac.ListadoRutaContradoId(id);
        }



        public List<ObjetoDestinos> BuscarRutaPorCliente(string cliente)
        {
            return _dtFac.BuscarRutaPorCliente(cliente);
        }


        public List<ObjetoDestinos> Listado_RutasGasto(string ruta)
        {
            return _dtFac.Listado_RutasGasto(ruta);
        }



        


        public List<ObjetoConductor> ListadoConductores()
        {
            return _dtFac.ListadoConductores();
        }


         

        public List<ObjetoGuiaExpedicionGrid> ListadoGuiaExpedicion(string idusuario)
        {
            return _dtFac.ListadoGuiaExpedicion(idusuario);
        }


        public List<ObjetoPedido> ListadoPedido(string idusuario)
        {
            return _dtFac.ListadoPedido(idusuario);
        }


        public List<ObjetoPedido> ListadoPedidoId(string IdPedido)
        {
            return _dtFac.ListadoPedidoId(IdPedido);
        }





        public List<ObjetoCliente> ListadoClienteContratoTamarugal()
        {
            return _dtFac.ListadoClienteContratoTamarugal();
        }

        public List<ObjetoUnidadMedida> ListadoUnidadMedida()
        {
            return _dtFac.ListadoUnidadMedida();
        }
        public List<ObjetoTipoCamion> ListadoTipoCamion()
        {
            return _dtFac.ListadoTipoCamion();
        }


        public List<ObjetoSucursal> ListadoSucursal()
        {
            return _dtFac.ListadoSucursal();
        }



        public List<ObjetoSucursal> ListadoUsuariosSucursalId(string id)
        {
            return _dtFac.ListadoUsuariosSucursalId(id);
        }


        public List<ObjetoUbicacion> ListadoUbicacion(string cliente)
        {
            return _dtFac.ListadoUbicacion(cliente);
        }

        public List<ObjetoUbicacion> ListadoSnSolo()
        {
            return _dtFac.ListadoSnSolo();
        }

        


        public List<ObjetoDestinos> ListadoDestinoDestino()
        {
            return _dtFac.ListadoDestinoDestino();
        }
        public List<ObjetoTipoCarga> ListadoCargas()
        {
            return _dtFac.ListadoCargas();
        }



        public List<ObjetoSeguimientoContrato> ListadoListadoSeguimientoContrato()
        {
            return _dtFac.ListadoListadoSeguimientoContrato();
        }



        public List<ObjetoInforme> ListadaoSabanaDatos()
        {
            return _dtFac.ListadaoSabanaDatos();
        }






        public List<ObjetoGuiaExpedicionGrid> ListadoProgramacionGE(string id)
        {
            return _dtFac.ListadoProgramacionGE(id);
        }


        public List<ObjetoTamarugalPeaje> ListadoPeajes()
        {
            return _dtFac.ListadoPeajes();
        }

        public List<ObjetoRecepcionGuia> ListadoGuiaRecepcion(int id)
        {
            return _dtFac.ListadoGuiaRecepcion(id);
        }

        public List<ObjetoRecepcionGuia> ListadoRendicion(int id)
        {
            return _dtFac.ListadoRendicion(id);
        }



        public List<ObjetoSeguimientoDetalleContratoGrid> ListadoListadoSeguimientoContratoID(string id)
        {
            return _dtFac.DetalleContratoTamarugalId(id);
        }


        public List<ObjetoSeguimientoDetalleContratoGrid> ListadoListadoSeguimientoContratoID2(string id)
        {
            return _dtFac.DetalleContratoTamarugalId2(id);
        }


        public List<ObjetoSeguimientoDetalleContratoGrid> TamarugalDetalleContratos(string IdEncargado)
        {
            return _dtFac.TamarugalDetalleContratos(IdEncargado);
        }


        public List<ObjetoSeguimientoDetalleContratoGrid> TamarugalDetalleContratos2(string IdContrato)
        {
            return _dtFac.TamarugalDetalleContratos2(IdContrato);
        }


        public List<ObjetoRutaPeaje> ListadoRutaPeaje(string ruta)
        {
            return _dtFac.ListadoRutaPeaje(ruta);
        }




        public List<ObjetoGuiaExpedicionGrid> ListadoGuiaExpedicionIdConductor(int idConductor)
        {
            return _dtFac.ListadoGuiaExpedicionIdConductor(idConductor);
        }


        

        public List<ObjetoRendicionGasto> ListadoGasto(string _Contrato, int _idguia, int _idpedido)
        {
            return _dtFac.ListadoGasto(_Contrato, _idguia, _idpedido);
        }

        public List<ObjetoSeguimientoDetalleContratoGrid> DetalleServicioTamarugalId(string _idguia, string _numeroPedido)
        {
            return _dtFac.DetalleServicioTamarugalId(_idguia, _numeroPedido);
        }



        public List<ObjetoSeguimientoDetalleContratoGrid> DetalleServicioTamarugalId2(string _idguia, string _numeroPedido)
        {
            return _dtFac.DetalleServicioTamarugalId2(_idguia, _numeroPedido);
        }


        public int SetGrabaTamarugalGuiaExpedicion(ObjetoGuiaExpedicion guia)
        {
            return _dtFac.SetGrabaTamarugalGuiaExpedicion(guia);
        }


        public int SetGrabaTamarugalDetalleGuiaExpedicion(ObjetoGuiaDetalleExpedicion guia)
        {
            return _dtFac.SetGrabaTamarugalDetalleGuiaExpedicion(guia);
        }


        


        public int  SetGrabaTamarugalPedido(ObjetoPedido pedido)
        {
            return _dtFac.SetGrabaTamarugalPedido(pedido);
        }

        public int SetGrabaOrdenAtencion(ObjetoOrdenAtencion pedido)
        {
            return _dtFac.SetGrabaOrdenAtencion(pedido);
        }


        

        public bool setGrabaSeguimientoPedido(ObjetoSeguimientoPedido pedido)
        {
            return _dtFac.setGrabaSeguimientoPedido(pedido);
        }



        public bool setGrabaModificaSeguimientoPedido(ObjetoSeguimientoPedido pedido)
        {
            return _dtFac.setGrabaModificaSeguimientoPedido(pedido);
        }


        public bool setGrabaDetalleSeguimientoPedido(ObjetoSeguimientoPedido pedido)
        {
            return _dtFac.setGrabaModificaSeguimientoPedido(pedido);
        }

          
        public bool SetGrabaRuta(ObjetoDestinos  ruta)
        {
            return _dtFac.SetGrabaRuta(ruta);
        }


        public bool SetGrabaGasto(ObjetoRendicionGasto gasto)
        {
            return _dtFac.SetGrabaGasto(gasto);
        }



        public bool SetGrabaTamarugalPeaje(ObjetoTamarugalPeaje tipocamion)
        {
            return _dtFac.SetGrabaTamarugalPeaje(tipocamion);
        }



        public bool SetGrabaTamarugalSucursal(ObjetoSucursal tipocamion)
        {
            return _dtFac.SetGrabaTamarugalSucursal(tipocamion);
        }


        public bool GetVerificaUsuario(string rutUsuario)
        {
            return _dtFac.GetVerificaUsuario(rutUsuario);
        }

        public bool SetAutorizaUsuario(int idUsuario)
        {
            return _dtFac.SetAutorizaUsuario(idUsuario);
        }


        public bool SetActualizaConductor(string idguia, string idconductor, string IdRuta, string IdCamion, string Vueltas, string Patente, string PlacaNroRemolque)
        {
            return _dtFac.SetActualizaConductor(idguia, idconductor, IdRuta, IdCamion, Vueltas, Patente, PlacaNroRemolque);
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
                        string _IdDespacho)
        {
            return _dtFac.SetActualizaGuia(Id,
                         Patente,
                         PlacaNroRemolque,
                         RutEmisor,
                         NroGuiaDespachoCliente,
                         FechaEmision,
                         Toneladas,
                         FechaTimbre,
                         Comentario,
                         NumeroPedido,
                         VueltasCompletadas,
                         _Estado,
                         _IdDespacho);
        }




        public bool SetGrabaTamarugalRecepcionGuia(ObjetoGuiaRecepcion guia)
        {
            return _dtFac.SetGrabaTamarugalRecepcionGuia(guia);
        }


        public bool SetQuitaPermisoUsuario(int idUsuario)
        {
            return _dtFac.SetQuitaPermisoUsuario(idUsuario);
        }

        public bool SetGrabaParametrosTipoSistema(ObjetoTipoSistema tipoSistema)
        {
            return _dtFac.SetGrabaParametrosTipoSistema(tipoSistema);
        }

        public bool SetGrabaTamarugalDetalleContrato(ObjetoSeguimientoDetalleContrato ClienteContratoDetalle)
        {
            return _dtFac.SetGrabaTamarugalDetalleContrato(ClienteContratoDetalle);
        }

        public int SetGrabaTamarugalClienteContrato(ObjetoSeguimientoContrato ClienteContrato)
        {
            return _dtFac.SetGrabaTamarugalClienteContrato(ClienteContrato);
        }

     


        public List<ObjetoPerfil> ListadoPerfiles()
        {
            return _dtFac.ListadoPerfiles();
        }


        public List<ObjetoUsuarios> Listado_UsuarioPicking()
        {
            return _dtFac.Listado_UsuarioPicking();
        }

        public List<ObjetoEmpresas> ListadoEmpresas()
        {
            return _dtFac.ListadoEmpresas();
        }

        public bool SetGrabaUsuario(ObjetoUsuarios usuario)
        {
            return _dtFac.SetGrabaUsuario(usuario);
        }

        public List<ObjetoMenu> MenuUsuario(int idUsuario)
        {
            return _dtFac.MenuUsuario(idUsuario);
        }



    }
}
