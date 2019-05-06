using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoCodigoSC
    {

        private int _Id;
        private string _Codigo;
        private string _Descripcion;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
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




    }
}
