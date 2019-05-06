using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{
    public class ObjetoSeguimientoPedido
    {
        private int _Id;
        private string _CodigoLocal;
        private string _NombreLocal;
        private DateTime _FechaPicking;
        private string _Operador;
        private string _Estado;
        private string _HoraInicio;
        private string _HoraTermino;
        private string _Documento;
        private string _Softland;


        public string Softland
        {
            get { return _Softland; }
            set { _Softland = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        public string CodigoLocal
        {
            get { return _CodigoLocal; }
            set { _CodigoLocal = value; }
        }


        public string NombreLocal
        {
            get { return _NombreLocal; }
            set { _NombreLocal = value; }
        }


        public DateTime FechaPicking
        {
            get { return _FechaPicking; }
            set { _FechaPicking = value; }
        }


        public string Operador
        {
            get { return _Operador; }
            set { _Operador = value; }
        }


        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


        public string HoraInicio
        {
            get { return _HoraInicio; }
            set { _HoraInicio = value; }
        }


        public string HoraTermino
        {
            get { return _HoraTermino; }
            set { _HoraTermino = value; }
        }


        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }




    }

}
