using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoOrdenAtencion
    {

        private int _Id;
        private string _Usuario;
        private string _TipoAtencion;
        private string _Requemiento;
        private string _TipoCliente;
        private string _NombreCliente;
        private string _NumeroContacto;
        private string _Descripcion;
        private string _UbicacionFisica;
        private string _Diganostico;
        private string _Solucion;
        private string _Responsable;
        private string _DescripcionSolucion;
        private DateTime _FechaCierre;
        private DateTime _FechaIngreso;
        private string _UsuarioCierre;
        private string _Estado;
        private string _Ruta;
        private string _Maquina;
        private string _Modelo;
        private string _TipoMaquina;
        private string _Supervisor;




        public string Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }



        public string Maquina
        {
            get { return _Maquina; }
            set { _Maquina = value; }
        }



        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }



        public string TipoMaquina
        {
            get { return _TipoMaquina; }
            set { _TipoMaquina = value; }
        }



        public string Supervisor
        {
            get { return _Supervisor; }
            set { _Supervisor = value; }
        }




        public string UsuarioCierre
        {
            get { return _UsuarioCierre; }
            set { _UsuarioCierre = value; }
        }




        public string DescripcionSolucion
        {
            get { return _DescripcionSolucion; }
            set { _DescripcionSolucion = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string TipoAtencion
        {
            get { return _TipoAtencion; }
            set { _TipoAtencion = value; }
        }

        public string Requemiento
        {
            get { return _Requemiento; }
            set { _Requemiento = value; }
        }

        public string TipoCliente
        {
            get { return _TipoCliente; }
            set { _TipoCliente = value; }
        }

        public string NombreCliente
        {
            get { return _NombreCliente; }
            set { _NombreCliente = value; }
        }

        public string NumeroContacto
        {
            get { return _NumeroContacto; }
            set { _NumeroContacto = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string UbicacionFisica
        {
            get { return _UbicacionFisica; }
            set { _UbicacionFisica = value; }
        }
        public string Diganostico
        {
            get { return _Diganostico; }
            set { _Diganostico = value; }
        }

        public string Solucion
        {
            get { return _Solucion; }
            set { _Solucion = value; }
        }




        public string Responsable
        {
            get { return _Responsable; }
            set { _Responsable = value; }
        }

        public DateTime FechaCierre
        {
            get { return _FechaCierre; }
            set { _FechaCierre = value; }
        }
        public DateTime FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }





    }
}
