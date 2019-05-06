using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoSucursal
    {

        private int _Id;
        private string _Nombre;
        private bool _Estado;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }


        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }



    }
}
