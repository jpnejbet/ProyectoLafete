using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoGuiaDetalleExpedicion
    {

        private int _Id;
        private int _IdGuia;
        private int _NroPedido;
        private string _NroContrato;
        private int _IdConductor;
        private string _Cliente;
        private string _Servicio;
        private string _Ruta;
        private string _Cantidad;
        private int _Vueltas;
        private string _Patente;
        private string _Remolque;
        private string _Estado;


        public string NroContrato
        {
            get { return _NroContrato; }
            set { _NroContrato = value; }
        }



        public int IdConductor
        {
            get { return _IdConductor; }
            set { _IdConductor = value; }
        }


        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }


        public string Servicio
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }

        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }


        public int NroPedido
        {
            get { return _NroPedido; }
            set { _NroPedido = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
         

        public int IdGuia
        {
            get { return _IdGuia; }
            set { _IdGuia = value; }
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
        public string Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }


        public int Vueltas
        {
            get { return _Vueltas; }
            set { _Vueltas = value; }
        }


        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


    }
}
