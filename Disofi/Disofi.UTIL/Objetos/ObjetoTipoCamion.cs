using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoTipoCamion
    {

        private int _Id;
        private string _TipoCamion;
        private bool _Estado;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string TipoCamion
        {
            get { return _TipoCamion; }
            set { _TipoCamion = value; }
        }


        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }



    }
}
