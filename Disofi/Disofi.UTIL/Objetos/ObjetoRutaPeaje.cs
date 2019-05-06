using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoRutaPeaje
    {

        private int _Id;
        private string _Ruta;
        private string _Plaza;
        private string _Valor;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }


        public string Plaza
        {
            get { return _Plaza; }
            set { _Plaza = value; }
        }

        public string Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }
    }
}
