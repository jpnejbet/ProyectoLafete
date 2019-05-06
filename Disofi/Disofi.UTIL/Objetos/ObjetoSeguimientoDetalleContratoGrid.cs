using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoSeguimientoDetalleContratoGrid
    {

        private int _IdContrato;
        private int _IdPedido;
        private int _IdServicio;
        private int _IdDetalleContrato;
        private int _IdDestino;
        private string _Servicio;
        private decimal _Valor;
        private int _IdTipoCamion;
        private int _IdTipoCarga;
        private string _Cantidad;
        private DateTime _FechaCreacionSistema;
        private DateTime _FechaServicio; 
        private string _FechaServicioTexto;
        private string _Cliente;
        private string _Ruta;
        private string _TipoCamion;
        private string _TipoCarga;
        private string _UnidadMedida;
        private int _IdUnidadMedida;
        private int _IdRuta;
        private DateTime _FechaInicio;
        private DateTime _FechaTermino;
        private string _NroContrato;
        private int _NroGuia;
        private int _NroPedido;
        private int _Vueltas;
        private string _Patente;
        private string _PlacaRemolque;
        private string _Conductor;
        private int _CantidadPedido;
        private int _IdConductor;


        public int IdConductor
        {
            get { return _IdConductor; }
            set { _IdConductor = value; }
        }



        public int CantidadPedido
        {
            get { return _CantidadPedido; }
            set { _CantidadPedido = value; }
        }



        public string Conductor
        {
            get { return _Conductor; }
            set { _Conductor = value; }
        }


        public int Vueltas
        {
            get { return _Vueltas; }
            set { _Vueltas = value; }
        }




        public string PlacaRemolque
        {
            get { return _PlacaRemolque; }
            set { _PlacaRemolque = value; }
        }




        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }




        public int NroGuia
        {
            get { return _NroGuia; }
            set { _NroGuia = value; }
        }




        public int NroPedido
        {
            get { return _NroPedido; }
            set { _NroPedido = value; }
        }



        public string NroContrato
        {
            get { return _NroContrato; }
            set { _NroContrato = value; }

        }
        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }

        public DateTime FechaTermino
        {
            get { return _FechaTermino; }
            set { _FechaTermino = value; }
        }



        public int IdRuta
        {
            get { return _IdRuta; }
            set { _IdRuta = value; }
        }

        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }
        }

        public int IdUnidadMedida
        {
            get { return _IdUnidadMedida; }
            set { _IdUnidadMedida = value; }
        }

        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }
        public string TipoCamion
        {
            get { return _TipoCamion; }
            set { _TipoCamion = value; }
        }
        public string TipoCarga
        {
            get { return _TipoCarga; }
            set { _TipoCarga = value; }
        }


        public int IdContrato
        {
            get { return _IdContrato; }
            set { _IdContrato = value; }
        }


        public int IdPedido
        {
            get { return _IdPedido; }
            set { _IdPedido = value; }
        }

        public int IdServicio
        {
            get { return _IdServicio; }
            set { _IdServicio = value; }
        }



        public int IdDetalleContrato
        {
            get { return _IdDetalleContrato; }
            set { _IdDetalleContrato = value; }
        }

        public int IdDestino
        {
            get { return _IdDestino; }
            set { _IdDestino = value; }
        }

        public string Servicio
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }

        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }


        public int IdTipoCarga
        {
            get { return _IdTipoCarga; }
            set { _IdTipoCarga = value; }
        }
        public int IdTipoCamion
        {
            get { return _IdTipoCamion; }
            set { _IdTipoCamion = value; }
        }

        public string Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public DateTime FechaCreacionSistema
        {
            get { return _FechaCreacionSistema; }
            set { _FechaCreacionSistema = value; }
        }


        public DateTime FechaServicio
        {
            get { return _FechaServicio; }
            set { _FechaServicio = value; }
        }



        public string FechaServicioTexto
        {
            get { return _FechaServicioTexto; }
            set { _FechaServicioTexto = value; }
        }

    }

}
