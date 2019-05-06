
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoDestinos
    {

        private int _Id;
        private string _Cliente;
        private string _Ruta;
        private string _Codigo;
        private bool _Estado;
        private string _Plaza;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }

        }
        public string Plaza
        {
            get { return _Plaza; }
            set { _Plaza = value; }
        }



        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }



        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        } 


        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }



    }
}
