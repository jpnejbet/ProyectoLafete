using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoGuiaRecepcion
    {

        private int _Id;
        private int _NroGuiaDespacho;
        private string _NroContrato;
        private int _IdGuiaExpedicion;
        private int _NroViajes;
        private string _Servicio;
        private bool _Estado;
        private int _IdRuta; 
        private DateTime _FechaRetiro;
        private DateTime _FechaEntrega;
        private decimal _Toneladas;
        private int _IdPeaje;
        private decimal _Valor;




        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string NroContrato
        {
            get { return _NroContrato; }
            set { _NroContrato = value; }
        }

        public int NroGuiaDespacho
        {
            get { return _NroGuiaDespacho; }
            set { _NroGuiaDespacho = value; }
        }

        public int IdGuiaExpedicion
        {
            get { return _IdGuiaExpedicion; }
            set { _IdGuiaExpedicion = value; }
        }
        public int NroViajes
        {
            get { return _NroViajes; }
            set { _NroViajes = value; }
        }
        public int IdRuta
        {
            get { return _IdRuta; }
            set { _IdRuta = value; }
        }


        public string Servicio
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }



        public DateTime FechaRetiro
        {
            get { return _FechaRetiro; }
            set { _FechaRetiro = value; }
        }


        public DateTime FechaEntrega
        {
            get { return _FechaEntrega; }
            set { _FechaEntrega = value; }
        }

        public decimal Toneladas
        {
            get { return _Toneladas; }
            set { _Toneladas = value; }
        }


        public int IdPeaje
        {
            get { return _IdPeaje; }
            set { _IdPeaje = value; }
        }


        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }




        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }



    }
}
