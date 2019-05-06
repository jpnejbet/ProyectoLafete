using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoConductor
    {

        private int _Id;
        private string _Rut;
        private string _Conductor;
        private bool _Estado;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        public string Rut
        {
            get { return _Rut; }
            set { _Rut = value; }
        }



        public string Conductor
        {
            get { return _Conductor; }
            set { _Conductor = value; }
        }


        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }




    }
}
