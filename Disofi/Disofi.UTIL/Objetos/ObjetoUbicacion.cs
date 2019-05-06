using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoUbicacion
    {

        private int _Id;
        private string _Cliente; 
        private string _Ubicacion;

        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }



        public string Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }


    }
}
