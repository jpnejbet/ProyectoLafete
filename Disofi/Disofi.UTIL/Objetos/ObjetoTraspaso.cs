using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.UTIL.Objetos
{

    public class ObjetoTraspaso
    {

        private string _CpbAno;
        private string _CpbNum;
        private string _MovNum;
        private string _AreaCod;
        private string _PctCod;
        private string _CpbFec;
        private string _CpbMes;
        private string _CvCod;
        private string _VendCod;
        private string _UbicCod;
        private string _CajCod;
        private string _IfCod;
        private string _MovIfCant;
        private string _DgaCod;
        private string _MovDgCant;
        private string _CcCod;
        private string _TipDocCb;
        private string _NumDocCb;
        private string _CodAux;
        private string _TtdCod;
        private string _NumDoc;
        private string _MovFe;
        private string _MovFv;
        private string _MovTipDocRef;
        private string _MovNumDocRef;
        private string _MovDebe;
        private string _MovHaber;
        private string _MovGlosa;
        private string _MonCod;
        private string _MovEquiv;
        private string _MovDebeMa;
        private string _MovHaberMa;
        private string _MovNumCar;
        private string _MovTC;
        private string _MovNC;
        private string _MovIPr;
        private string _MovAEquiv;
        private string _FecPag;
        private string _CODCPAG;
        private string _CbaNumMov;
        private string _CbaAnoC;
        private string _GrabaDLib;
        private string _CpbOri;
        private string _CodBanco;
        private string _CodCtaCte;
        private string _MtoTotal;
        private string _Cuota;
        private string _CuotaRef;
        private string _Marca;
        private string _fecEmisionch;
        private string _paguesea;
        private string _Impreso;
        private string _dlicoint_aperturas;
        private string _nro_operacion;
        private string _FormadePag;
        private string _CpbNormaIFRS;
        private string _CpbNormaTrib;


        public string CpbAno { get { return _CpbAno; } set { _CpbAno = value; } }
        public string CpbNum { get { return _CpbNum; } set { _CpbNum = value; } }
        public string MovNum { get { return _MovNum; } set { _MovNum = value; } }
        public string AreaCod { get { return _AreaCod; } set { _AreaCod = value; } }
        public string PctCod { get { return _PctCod; } set { _PctCod = value; } }
        public string CpbFec { get { return _CpbFec; } set { _CpbFec = value; } }
        public string CpbMes { get { return _CpbMes; } set { _CpbMes = value; } }
        public string CvCod { get { return _CvCod; } set { _CvCod = value; } }
        public string VendCod { get { return _VendCod; } set { _VendCod = value; } }
        public string UbicCod { get { return _UbicCod; } set { _UbicCod = value; } }
        public string CajCod { get { return _CajCod; } set { _CajCod = value; } }
        public string IfCod { get { return _IfCod; } set { _IfCod = value; } }
        public string MovIfCant { get { return _MovIfCant; } set { _MovIfCant = value; } }
        public string DgaCod { get { return _DgaCod; } set { _DgaCod = value; } }
        public string MovDgCant { get { return _MovDgCant; } set { _MovDgCant = value; } }
        public string CcCod { get { return _CcCod; } set { _CcCod = value; } }
        public string TipDocCb { get { return _TipDocCb; } set { _TipDocCb = value; } }
        public string NumDocCb { get { return _NumDocCb; } set { _NumDocCb = value; } }
        public string CodAux { get { return _CodAux; } set { _CodAux = value; } }
        public string TtdCod { get { return _TtdCod; } set { _TtdCod = value; } }
        public string NumDoc { get { return _NumDoc; } set { _NumDoc = value; } }
        public string MovFe { get { return _MovFe; } set { _MovFe = value; } }
        public string MovFv { get { return _MovFv; } set { _MovFv = value; } }
        public string MovTipDocRef { get { return _MovTipDocRef; } set { _MovTipDocRef = value; } }
        public string MovNumDocRef { get { return _MovNumDocRef; } set { _MovNumDocRef = value; } }
        public string MovDebe { get { return _MovDebe; } set { _MovDebe = value; } }
        public string MovHaber { get { return _MovHaber; } set { _MovHaber = value; } }
        public string MovGlosa { get { return _MovGlosa; } set { _MovGlosa = value; } }
        public string MonCod { get { return _MonCod; } set { _MonCod = value; } }
        public string MovEquiv { get { return _MovEquiv; } set { _MovEquiv = value; } }
        public string MovDebeMa { get { return _MovDebeMa; } set { _MovDebeMa = value; } }
        public string MovHaberMa { get { return _MovHaberMa; } set { _MovHaberMa = value; } }
        public string MovNumCar { get { return _MovNumCar; } set { _MovNumCar = value; } }
        public string MovTC { get { return _MovTC; } set { _MovTC = value; } }
        public string MovNC { get { return _MovNC; } set { _MovNC = value; } }
        public string MovIPr { get { return _MovIPr; } set { _MovIPr = value; } }
        public string MovAEquiv { get { return _MovAEquiv; } set { _MovAEquiv = value; } }
        public string FecPag { get { return _FecPag; } set { _FecPag = value; } }
        public string CODCPAG { get { return _CODCPAG; } set { _CODCPAG = value; } }
        public string CbaNumMov { get { return _CbaNumMov; } set { _CbaNumMov = value; } }
        public string CbaAnoC { get { return _CbaAnoC; } set { _CbaAnoC = value; } }
        public string GrabaDLib { get { return _GrabaDLib; } set { _GrabaDLib = value; } }
        public string CpbOri { get { return _CpbOri; } set { _CpbOri = value; } }
        public string CodBanco { get { return _CodBanco; } set { _CodBanco = value; } }
        public string CodCtaCte { get { return _CodCtaCte; } set { _CodCtaCte = value; } }
        public string MtoTotal { get { return _MtoTotal; } set { _MtoTotal = value; } }
        public string Cuota { get { return _Cuota; } set { _Cuota = value; } }
        public string CuotaRef { get { return _CuotaRef; } set { _CuotaRef = value; } }
        public string Marca { get { return _Marca; } set { _Marca = value; } }
        public string fecEmisionch { get { return _fecEmisionch; } set { _fecEmisionch = value; } }
        public string paguesea { get { return _paguesea; } set { _paguesea = value; } }
        public string Impreso { get { return _Impreso; } set { _Impreso = value; } }
        public string dlicoint_aperturas { get { return _dlicoint_aperturas; } set { _dlicoint_aperturas = value; } }
        public string nro_operacion { get { return _nro_operacion; } set { _nro_operacion = value; } }
        public string FormadePag { get { return _FormadePag; } set { _FormadePag = value; } }
        public string CpbNormaIFRS { get { return _CpbNormaIFRS; } set { _CpbNormaIFRS = value; } }
        public string CpbNormaTrib { get { return _CpbNormaTrib; } set { _CpbNormaTrib = value; } }



    }
}
