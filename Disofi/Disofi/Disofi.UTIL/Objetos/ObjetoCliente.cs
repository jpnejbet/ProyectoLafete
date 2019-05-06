using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoCliente
    {

        private string _CodigoCliente;
        private string _NombreCliente;
        private int _Id;


                   public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string codigoCliente
        {
            get { return _CodigoCliente; }
            set { _CodigoCliente = value; }
        }

        public string NombreCliente
        {
            get { return _NombreCliente; }
            set { _NombreCliente = value; }
        }
    }
}
