using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoInforme
    {

        private string _NroContrato;
        private string _Cliente;
        private DateTime _FechaInicio;
        private DateTime  _FechaTermino;
        private int _IdEncargado;
        private string _Servicio;
        private string _Codigo;
        private string _Descripcion;
        private string _UnidadMedida;
        private decimal _Cantidad;
        private decimal _Valor;
        private int _Vueltas;
        private string _Patente;
        private string _Conductor;
        private string _Camion;


        public int IdEncargado
        {
            get { return _IdEncargado; }
            set { _IdEncargado = value; }
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
         


        public string Servicio
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }



        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }



        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }



        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }

        }


        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }

        }



        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }

        }

        public int Vueltas
        {
            get { return _Vueltas; }
            set { _Vueltas = value; }

        }


        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }

        }


        public string Conductor
        {
            get { return _Conductor; }
            set { _Conductor = value; }

        }

        public string Camion
        {
            get { return _Camion; }
            set { _Camion = value; }

        }
    }
}
