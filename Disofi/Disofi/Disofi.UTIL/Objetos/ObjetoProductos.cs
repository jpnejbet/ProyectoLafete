using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoProductos
    {

        private int _Id;
        private string _Codigo;
        private string _Descripcion;
        private string _UnidadMedida;
        private decimal _Cantidad;
        private decimal _PrecioUnitario;
        private bool _Estado;
        private double _PrecioVenta;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
         

        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }
        }



        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public decimal PrecioUnitario
        {
            get { return _PrecioUnitario; }
            set { _PrecioUnitario = value; }
        }



        public double PrecioVenta
        {
            get { return _PrecioVenta; }
            set { _PrecioVenta = value; }
        }




        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
    }
}
