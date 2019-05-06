using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoSeguimientoContrato
    {

        private int _Id;
        private string _Cliente;
        private string _NroContrato;
        private DateTime _FechaInicio;
        private DateTime _FechaTermino;
        private int _IdEncargado;
        private string _Comentario;
        private bool _Estado;
        private string _NombreEncargado;
        private string _NombreSucursalEncargado;
        private int _IdSucursal;
        private decimal _Valor;
        private string _Moneda;


        public string Moneda
        {
            get { return _Moneda; }
            set { _Moneda = value; }
        }


        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }


        public int IdSucursal
        {
            get { return _IdSucursal; }
            set { _IdSucursal = value; }
        }



        public string NombreSucursalEncargado
        {
            get { return _NombreSucursalEncargado; }
            set { _NombreSucursalEncargado = value; }
        }



        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string NroContrato
        {
            get { return _NroContrato; }
            set { _NroContrato = value; }
        }


        public string Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
         
        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }

        public DateTime FechaTermino
        {
            get { return _FechaTermino; }
            set { _FechaTermino = value; }
        }

        public int IdEncargado
        {
            get { return _IdEncargado; }
            set { _IdEncargado = value; }
        }


        public string Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; }
        }

        public string NombreEncargado
        {
            get { return _NombreEncargado; }
            set { _NombreEncargado = value; }
        }


        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }

        }


    }

}
