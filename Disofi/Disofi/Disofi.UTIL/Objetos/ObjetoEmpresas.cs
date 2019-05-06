using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{
    public class ObjetoEmpresas
    {

        private int _idEmpresa;
        private string _nombre;
        private bool _activo;


        public int IdEmpresa
        {
            get { return _idEmpresa; }
            set { _idEmpresa = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
    }


}
