using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoTipoCarga
    {

        private int _Id;
        private string _TipoCarga;
        private bool _Estado;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string TipoCarga
        {
            get { return _TipoCarga; }
            set { _TipoCarga = value; }
        }


        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }



    }
}
