
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoUnidadMedida
    {

        private int _Id;
        private string _UnidadMedida; 
        private bool _Estado;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }
        }
         


        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }



    }
}
