using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoGuiaExpedicionGrid
    {

        private int _IdGuia;
        private int _IdCliente;
        private int _IdContrato;
        private int _IdServicio;
        private int _IdConductor;
        private int _NCiclos;
        private bool _Estado;
        private string _Cliente;
        private string _Servicio;
        private string _Conductor;
        private DateTime _FechaInicio;
        private DateTime _FechaFin;
        private DateTime _FechaCreacionPedido;
        private string _Ruta;
        private int _CantidadCiclos;
        private string _NroContrato;
        private int _NroPedido;
		private string _Patente;
		private string _Vueltas;
		private string _TipoCamion;
        private int _Pedido;
        private string _Cantidad;
        private string _Remolque;
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        public string Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }



        public int Pedido
        {
            get { return _Pedido; }
            set { _Pedido = value; }
        }

        public string TipoCamion
		{
			get { return _TipoCamion; }
			set { _TipoCamion = value; }

		}

		public string Patente
		{
			get { return _Patente; }
			set { _Patente = value; }

		}

        public string Remolque
        {
            get { return _Remolque; }
            set { _Remolque = value; }

        }
        public string  Vueltas
		{
			get { return _Vueltas; }
			set { _Vueltas = value; }
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

        public int CantidadCiclos
        {
            get { return _CantidadCiclos; }
            set { _CantidadCiclos = value; }
        }


        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }



         
        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }

        public DateTime FechaCreacionPedido
        {
            get { return _FechaCreacionPedido; }
            set { _FechaCreacionPedido = value; }
        }


        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        public string Servicio
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }

        public string Conductor
        {
            get { return _Conductor; }
            set { _Conductor = value; }
        }

        public int IdGuia
        {
            get { return _IdGuia; }
            set { _IdGuia = value; }
        }


        public int IdServicio
        {
            get { return _IdServicio; }
            set { _IdServicio = value; }
        }



        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public int IdContrato
        {
            get { return _IdContrato; }
            set { _IdContrato = value; }
        }

        public int IdConductor
        {
            get { return _IdConductor; }
            set { _IdConductor = value; }
        }
   

        public int NCiclos
        {
            get { return _NCiclos; }
            set { _NCiclos = value; }
        }



        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


    }
}
