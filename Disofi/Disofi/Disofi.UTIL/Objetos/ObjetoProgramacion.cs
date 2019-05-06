using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoProgramacion
    {

        private int _Ciclo;
        private string _Conductor;
        private string _Ruta;
        private string _Servicio;
        private int _Id;
        private DateTime _Fecha;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int Ciclo
        {
            get { return _Ciclo; }
            set { _Ciclo = value; }
        }

        public string Conductor
        {
            get { return _Conductor; }
            set { _Conductor = value; }
        }


        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }

        public string Servicio
        {
            get { return _Servicio; }
            set { _Servicio = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }





    }
}
