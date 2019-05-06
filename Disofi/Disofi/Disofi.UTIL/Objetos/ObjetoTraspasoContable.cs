using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoTraspasoContable
    {
        private string _CodPlanCodCuenta;
        private string _Monto_Debe_Moneda_Base;
        private string _Monto_Haber_Moneda_Base;
        private string _Descripcion_Movimiento;
        private string _Equivalencia_Moneda;
        private string _Monto_Debe_Moneda_Adicional;
        private string _Monto_Haber_Moneda_Adicional;
        private string _CodCondicionCodVenta;
        private string _CodVendedor;
        private string _CodUbicacion;
        private string _CodConceptoCodCaja;
        private string _CodInstrumento_Financiero;
        private string _Cantidad_Instrumento_Financiero;
        private string _CodDetalleCodGasto;
        private string _Cantidad_ConceptoCodGasto;
        private string _CodCentroCodCosto;
        private string _Tipo_DoctoConciliacion;
        private string _Nro_Docto_Conciliacion;
        private string _CodAuxiliar;
        private string _Tipo_Documento;
        private string _Nro_Documento;
        private string _Fecha_Emision_Docto;
        private string _Fecha_Vencimiento_Docto;
        private string _Tipo_Docto_Referencia;
        private string _Nro_Docto_Referencia;
        private string _Nro_Correlativo_Interno;
        private string _Monto_1_Detalle_Libro;
        private string _Monto_2_Detalle_Libro;
        private string _Monto_3_Detalle_Libro;
        private string _Monto_4_Detalle_Libro;
        private string _Monto_5_Detalle_Libro;
        private string _Monto_6_Detalle_Libro;
        private string _Monto_7_Detalle_Libro;
        private string _Monto_8_Detalle_Libro;
        private string _Monto_9_Detalle_Libro;
        private string _Monto_Suma_Detalle_Libro;
        private string _Graba_el_detalleCodlibro;
        private string _Documento_Nulo;
        private string _Codflujo_efectivo_1;
        private string _Monto_flujo_1;
        private string _Codflujo_efectivo_2;
        private string _Monto_flujo_2;
        private string _Codflujo_efectivo_3;
        private string _Monto_flujo_3;
        private string _Codflujo_efectivo_4;
        private string _Monto_flujo_4;
        private string _Codflujo_efectivo_5;
        private string _Monto_flujo_5;
        private string _Codflujo_efectivo_6;
        private string _Monto_flujo_6;
        private string _Codflujo_efectivo_7;
        private string _Monto_flujo_7;
        private string _Codflujo_efectivo_8;
        private string _Monto_flujo_8;
        private string _Codflujo_efectivo_9;
        private string _Monto_flujo_9;
        private string _Codflujo_efectivo_10;
        private string _Monto_flujo_10;
        private string _Numero_CuotaCodPago;
        private string _Numero_Documento_Desde;
        private string _Numero_Documento_Hasta;


        public string CodPlanCodCuenta { get { return _CodPlanCodCuenta; } set { _CodPlanCodCuenta = value; } }
        public string Monto_Debe_Moneda_Base { get { return _Monto_Debe_Moneda_Base; } set { _Monto_Debe_Moneda_Base = value; } }
        public string Monto_Haber_Moneda_Base { get { return _Monto_Haber_Moneda_Base; } set { _Monto_Haber_Moneda_Base = value; } }
        public string Descripcion_Movimiento { get { return _Descripcion_Movimiento; } set { _Descripcion_Movimiento = value; } }
        public string Equivalencia_Moneda { get { return _Equivalencia_Moneda; } set { _Equivalencia_Moneda = value; } }
        public string Monto_Debe_Moneda_Adicional { get { return _Monto_Debe_Moneda_Adicional; } set { _Monto_Debe_Moneda_Adicional = value; } }
        public string Monto_Haber_Moneda_Adicional { get { return _Monto_Haber_Moneda_Adicional; } set { _Monto_Haber_Moneda_Adicional = value; } }
        public string CodCondicionCodVenta { get { return _CodCondicionCodVenta; } set { _CodCondicionCodVenta = value; } }
        public string CodVendedor { get { return _CodVendedor; } set { _CodVendedor = value; } }
        public string CodUbicacion { get { return _CodUbicacion; } set { _CodUbicacion = value; } }
        public string CodConceptoCodCaja { get { return _CodConceptoCodCaja; } set { _CodConceptoCodCaja = value; } }
        public string CodInstrumento_Financiero { get { return _CodInstrumento_Financiero; } set { _CodInstrumento_Financiero = value; } }
        public string Cantidad_Instrumento_Financiero { get { return _Cantidad_Instrumento_Financiero; } set { _Cantidad_Instrumento_Financiero = value; } }
        public string CodDetalleCodGasto { get { return _CodDetalleCodGasto; } set { _CodDetalleCodGasto = value; } }
        public string Cantidad_ConceptoCodGasto { get { return _Cantidad_ConceptoCodGasto; } set { _Cantidad_ConceptoCodGasto = value; } }
        public string CodCentroCodCosto { get { return _CodCentroCodCosto; } set { _CodCentroCodCosto = value; } }
        public string Tipo_DoctoConciliacion { get { return _Tipo_DoctoConciliacion; } set { _Tipo_DoctoConciliacion = value; } }
        public string Nro_Docto_Conciliacion { get { return _Nro_Docto_Conciliacion; } set { _Nro_Docto_Conciliacion = value; } }
        public string CodAuxiliar { get { return _CodAuxiliar; } set { _CodAuxiliar = value; } }
        public string Tipo_Documento { get { return _Tipo_Documento; } set { _Tipo_Documento = value; } }
        public string Nro_Documento { get { return _Nro_Documento; } set { _Nro_Documento = value; } }
        public string Fecha_Emision_Docto { get { return _Fecha_Emision_Docto; } set { _Fecha_Emision_Docto = value; } }
        public string Fecha_Vencimiento_Docto { get { return _Fecha_Vencimiento_Docto; } set { _Fecha_Vencimiento_Docto = value; } }
        public string Tipo_Docto_Referencia { get { return _Tipo_Docto_Referencia; } set { _Tipo_Docto_Referencia = value; } }
        public string Nro_Docto_Referencia { get { return _Nro_Docto_Referencia; } set { _Nro_Docto_Referencia = value; } }
        public string Nro_Correlativo_Interno { get { return _Nro_Correlativo_Interno; } set { _Nro_Correlativo_Interno = value; } }
        public string Monto_1_Detalle_Libro { get { return _Monto_1_Detalle_Libro; } set { _Monto_1_Detalle_Libro = value; } }
        public string Monto_2_Detalle_Libro { get { return _Monto_2_Detalle_Libro; } set { _Monto_2_Detalle_Libro = value; } }
        public string Monto_3_Detalle_Libro { get { return _Monto_3_Detalle_Libro; } set { _Monto_3_Detalle_Libro = value; } }
        public string Monto_4_Detalle_Libro { get { return _Monto_4_Detalle_Libro; } set { _Monto_4_Detalle_Libro = value; } }
        public string Monto_5_Detalle_Libro { get { return _Monto_5_Detalle_Libro; } set { _Monto_5_Detalle_Libro = value; } }
        public string Monto_6_Detalle_Libro { get { return _Monto_6_Detalle_Libro; } set { _Monto_6_Detalle_Libro = value; } }
        public string Monto_7_Detalle_Libro { get { return _Monto_7_Detalle_Libro; } set { _Monto_7_Detalle_Libro = value; } }
        public string Monto_8_Detalle_Libro { get { return _Monto_8_Detalle_Libro; } set { _Monto_8_Detalle_Libro = value; } }
        public string Monto_9_Detalle_Libro { get { return _Monto_9_Detalle_Libro; } set { _Monto_9_Detalle_Libro = value; } }
        public string Monto_Suma_Detalle_Libro { get { return _Monto_Suma_Detalle_Libro; } set { _Monto_Suma_Detalle_Libro = value; } }
        public string Graba_el_detalleCodlibro { get { return _Graba_el_detalleCodlibro; } set { _Graba_el_detalleCodlibro = value; } }
        public string Documento_Nulo { get { return _Documento_Nulo; } set { _Documento_Nulo = value; } }
        public string Codflujo_efectivo_1 { get { return _Codflujo_efectivo_1; } set { _Codflujo_efectivo_1 = value; } }
        public string Monto_flujo_1 { get { return _Monto_flujo_1; } set { _Monto_flujo_1 = value; } }
        public string Codflujo_efectivo_2 { get { return _Codflujo_efectivo_2; } set { _Codflujo_efectivo_2 = value; } }
        public string Monto_flujo_2 { get { return _Monto_flujo_2; } set { _Monto_flujo_2 = value; } }
        public string Codflujo_efectivo_3 { get { return _Codflujo_efectivo_3; } set { _Codflujo_efectivo_3 = value; } }
        public string Monto_flujo_3 { get { return _Monto_flujo_3; } set { _Monto_flujo_3 = value; } }
        public string Codflujo_efectivo_4 { get { return _Codflujo_efectivo_4; } set { _Codflujo_efectivo_4 = value; } }
        public string Monto_flujo_4 { get { return _Monto_flujo_4; } set { _Monto_flujo_4 = value; } }
        public string Codflujo_efectivo_5 { get { return _Codflujo_efectivo_5; } set { _Codflujo_efectivo_5 = value; } }
        public string Monto_flujo_5 { get { return _Monto_flujo_5; } set { _Monto_flujo_5 = value; } }
        public string Codflujo_efectivo_6 { get { return _Codflujo_efectivo_6; } set { _Codflujo_efectivo_6 = value; } }
        public string Monto_flujo_6 { get { return _Monto_flujo_6; } set { _Monto_flujo_6 = value; } }
        public string Codflujo_efectivo_7 { get { return _Codflujo_efectivo_7; } set { _Codflujo_efectivo_7 = value; } }
        public string Monto_flujo_7 { get { return _Monto_flujo_7; } set { _Monto_flujo_7 = value; } }
        public string Codflujo_efectivo_8 { get { return _Codflujo_efectivo_8; } set { _Codflujo_efectivo_8 = value; } }
        public string Monto_flujo_8 { get { return _Monto_flujo_8; } set { _Monto_flujo_8 = value; } }
        public string Codflujo_efectivo_9 { get { return _Codflujo_efectivo_9; } set { _Codflujo_efectivo_9 = value; } }
        public string Monto_flujo_9 { get { return _Monto_flujo_9; } set { _Monto_flujo_9 = value; } }
        public string Codflujo_efectivo_10 { get { return _Codflujo_efectivo_10; } set { _Codflujo_efectivo_10 = value; } }
        public string Monto_flujo_10 { get { return _Monto_flujo_10; } set { _Monto_flujo_10 = value; } }
        public string Numero_CuotaCodPago { get { return _Numero_CuotaCodPago; } set { _Numero_CuotaCodPago = value; } }
        public string Numero_Documento_Desde { get { return _Numero_Documento_Desde; } set { _Numero_Documento_Desde = value; } }
        public string Numero_Documento_Hasta { get { return _Numero_Documento_Hasta; } set { _Numero_Documento_Hasta = value; } }


    }
}
