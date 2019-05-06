using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoSeguimientoDetalleContrato
    {

        private int _Id;
        private int _IdContrato;
        private string _Ruta;
        private string _Servicio;
        private decimal _Valor;
        private decimal _Cantidad;
        private int _IdTipoCamion;
        private int _IdTipoCarga;
        private DateTime _FechaInicio;
        private DateTime _FechaTermino;

        private string _UnidadMedida;
        private string _Detalle;



        public string Detalle
        {
            get { return _Detalle; }
            set { _Detalle = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
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


        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }
        }

        public int IdContrato
        {
            get { return _IdContrato; }
            set { _IdContrato = value; }
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

        public decimal Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }

        public decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }


        public int IdTipoCarga
        {
            get { return _IdTipoCarga; }
            set { _IdTipoCarga = value; }
        }
        public int IdTipoCamion
        {
            get { return _IdTipoCamion; }
            set { _IdTipoCamion = value; }
        }

       

        


    }

}
