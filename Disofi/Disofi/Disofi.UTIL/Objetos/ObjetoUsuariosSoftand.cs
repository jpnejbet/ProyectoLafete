using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{
    public class ObjetoUsuariosSoftand
    {
      
        private string _rut;
        private string _nombre;
        private string _email;
        private string _usuario; 
 


        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
 

    }

}
