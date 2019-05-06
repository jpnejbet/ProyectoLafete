using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoUpdateConductor
    {

        private int _IdGuia; 

        public int IdGuia
        {
            get { return _IdGuia; }
            set { _IdGuia = value; }
        }



        private int _IdConductor;

        public int IdConductor
        {
            get { return _IdConductor; }
            set { _IdConductor = value; }

        }
    }
}
