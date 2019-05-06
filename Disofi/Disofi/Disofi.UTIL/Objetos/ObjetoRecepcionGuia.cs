using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoRecepcionGuia
    {
        private int _Id;

        private int _IdGuia;
        private int _IdConductor;
        private int _Proyeccion;
        private string  _Vuelta;
        private string _VueltaCompletadas;
        private DateTime _FechaIncioServicio;
        private DateTime _FechaFinServicio;
        private DateTime _FechaGuia;
        private string _Conductor;
        private string _Camion;
        private string _Patente;
        private string _Cliente;
        private string _NroContrato;
        private string _Servicio;
        private int _NumeroPedido;
        private string _PlacaNroRemolque;
        private string _Cantidad;
        private string _Ruta;
        private int _IdDespacho;


        public int IdDespacho
        {
            get { return _IdDespacho; }
            set { _IdDespacho = value; }
        }




        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }



        public string Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }




        public int NumeroPedido
        {
            get { return _NumeroPedido; }
            set { _NumeroPedido = value; }
        }


        public string PlacaNroRemolque
        {
            get { return _PlacaNroRemolque; }
            set { _PlacaNroRemolque = value; }
        }

        public int IdGuia
        {
            get { return _IdGuia; }
            set { _IdGuia = value; }
        }



        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }



        public int IdConductor
        {
            get { return _IdConductor; }
            set { _IdConductor = value; }
        }


        public int Proyeccion
        {
            get { return _Proyeccion; }
            set { _Proyeccion = value; }
        }
        public string Vuelta
        {
            get { return _Vuelta; }
            set { _Vuelta = value; }
        }

        public string VueltaCompletadas
        {
            get { return _VueltaCompletadas; }
            set { _VueltaCompletadas = value; }
        }



        public DateTime FechaGuia
        {
            get { return _FechaGuia; }
            set { _FechaGuia = value; }
        }

        public DateTime FechaIncioServicio
        {
            get { return _FechaIncioServicio; }
            set { _FechaIncioServicio = value; }
        }


        public DateTime FechaFinServicio
        {
            get { return _FechaFinServicio; }
            set { _FechaFinServicio = value; }
        }

        public string Conductor
        {
            get { return _Conductor; }
            set { _Conductor = value; }
        }


        public string NroContrato
        {
            get { return _NroContrato; }
            set { _NroContrato = value; }
        }

        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }
        public string Servicio
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }



        public string Camion
        {
            get { return _Camion; }
            set { _Camion = value; }
        }


    }
}
