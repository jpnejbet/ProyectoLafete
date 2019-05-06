using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoBodega
    {

        private string _CodBodega;
        private string _NombreBodega;
        private string _Fono1;
        private string _Direccion;


        public string CodBodega
        {
            get { return _CodBodega; }
            set { _CodBodega = value; }
        }

        public string NombreBodega
        {
            get { return _NombreBodega; }
            set { _NombreBodega = value; }
        }

        public string Fono1
        {
            get { return _Fono1; }
            set { _Fono1 = value; }
        }
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
    }
}
