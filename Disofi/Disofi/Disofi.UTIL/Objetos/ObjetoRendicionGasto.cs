using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoRendicionGasto
    {

        private int _Id;
        private string _Contrato;
        private int _IdGuia;
        private int _IdPedido;
        private string _Gasto;
        private string _Valor;
        private string _NroTicket;
        private string _Fecha;

        private string _NombreGasto;

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

        public int IdPedido
        {
            get { return _IdPedido; }
            set { _IdPedido = value; }
        }


        public string Gasto
        {
            get { return _Gasto; }
            set { _Gasto = value; }
        }



        public string NombreGasto
        {
            get { return _NombreGasto; }
            set { _NombreGasto = value; }
        }

        public string Contrato
        {
            get { return _Contrato; }
            set { _Contrato = value; }
        }


        public string Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        public string NroTicket
        {
            get { return _NroTicket; }
            set { _NroTicket = value; }
        }


        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }


    }
}
