using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoPedido
    {

        private int _Id;
        private int _IdContrato;
        private int _IdServicio;
        private int _NroPedido;
        private string _Cliente;
        private string _Ruta;
        private string _Mes;
        private DateTime _FechaInicio;
        private DateTime _FechaFin;
        private string _Cantidad;
        private string _UnidadMedida;
        private string _Estado;
        private string _Servicio;
        private string _NroContrato
            ;


        public string NroContrato
        {
            get { return _NroContrato; }
            set { _NroContrato = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        public int IdContrato
        {
            get { return _IdContrato; }
            set { _IdContrato = value; }
        }

        public int NroPedido
        {
            get { return _NroPedido; }
            set { _NroPedido = value; }
        }

        public int IdServicio
        {
            get { return _IdServicio; }
            set { _IdServicio = value; }
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


        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }



        public string Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
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

          
        public string Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }


        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }
        }



        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
