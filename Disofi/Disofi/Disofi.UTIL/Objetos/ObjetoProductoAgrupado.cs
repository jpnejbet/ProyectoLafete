﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoProductoAgrupado
    {

        private string _CodigoGrupo;
        private string _Codigo;
        private string _Descripcion;
        private string _Stock;
        private string _StockMinimo;
        private string _StockMaximo;

        public string CodigoGrupo
        {
            get { return _CodigoGrupo; }
            set { _CodigoGrupo = value; }
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
        public string Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }

        public string StockMaximo
        {
            get { return _StockMaximo; }
            set { _StockMaximo = value; }
        }
        public string StockMinimo
        {
            get { return _StockMinimo; }
            set { _StockMinimo = value; }
        }



    }
}