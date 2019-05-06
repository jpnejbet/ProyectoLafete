using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{
    public class ObjetoDetalleSeguimientoPedido
    {

        private int _Id;
        private int _IdSeguimientoPedido;
        private string _CodigoProducto;
        private string _NombreProducto;
        private string _StockMinimo;
        private string _StockMaximo;
        private string _StockReposicion;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int IdSeguimientoPedido
        {
            get { return _IdSeguimientoPedido; }
            set { _IdSeguimientoPedido = value; }
        }

        public string CodigoProducto
        {
            get { return _CodigoProducto; }
            set { _CodigoProducto = value; }
        }

        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }


        public string StockMinimo
        {
            get { return _StockMinimo; }
            set { _StockMinimo = value; }
        }




        public string StockMaximo
        {
            get { return _StockMaximo; }
            set { _StockMaximo = value; }
        }

        public string StockReposicion
        {
            get { return _StockReposicion; }
            set { _StockReposicion = value; }
        }




    }

}
