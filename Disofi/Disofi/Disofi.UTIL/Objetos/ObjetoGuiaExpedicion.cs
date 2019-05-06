using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoGuiaExpedicion
    {

        private int _Id;
        private int _IdCliente;
        private int _IdContrato;
        private int _IdServicio;
        private int _CantidadCiclos;
        private bool _Estado;
        private int _IdConductor;
        private int _NroPedido;
        private int _IdPedido;


        





        public int IdPedido
        {
            get { return _IdPedido; }
            set { _IdPedido = value; }
        }


        public int NroPedido
        {
            get { return _NroPedido; }
            set { _NroPedido = value; }
        }


        public int IdConductor
        {
            get { return _IdConductor; }
            set { _IdConductor = value; }
        }





        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
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

        public int IdServicio
        {
            get { return _IdServicio; }
            set { _IdServicio = value; }
        }
        public int CantidadCiclos
        {
            get { return _CantidadCiclos; }
            set { _CantidadCiclos = value; }
        }



        
        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


    }
}
