using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disofi.ServicioSoftland.ObjetoWsdl
{
    public class NotaVenta
    {

        private int _NVNumero;
        private DateTime _nvFem;
        private string _nvEstado; //  varchar(1)
        private int _nvEstFact;
        private int _nvEstDesp;
        private int _nvEstRese;
        private int _nvEstConc;
        private int _CotNum;
        private string _NumOC; //  varchar(15)
        private DateTime _nvFeEnt;
        private string _CodAux; // varchar(10)
        private string _VenCod; //  varchar(4)
        private string _CodMon; //  varchar(2)
        private string _CodLista; //  varchar(3)
        private string _nvObser; //  varchar(4000)
        private string _nvCanalNV; //  varchar(3)
        private string _CveCod; //  varchar(3)
        private string _NomCon; //  varchar(30)
        private string _CodiCC; //  varchar(8)
        private string _CodBode; //  varchar(10)
        private float _nvSubTotal;
        private float _nvPorcDesc01;
        private float _nvDescto01;
        private float _nvPorcDesc02;
        private float _nvDescto02;
        private float _nvPorcDesc03;
        private float _nvDescto03;
        private float _nvPorcDesc04;
        private float _nvDescto04;
        private float _nvPorcDesc05;
        private float _nvDescto05;
        private float _nvMonto;
        private DateTime _nvFeAprob;
        private int _NumGuiaRes;
        private float _nvPorcFlete;
        private float _nvValflete;
        private float _nvPorcEmb;
        private float _nvValEmb;
        private float _nvEquiv;
        private float _nvNetoExento;
        private float _nvNetoAfecto; 
        private float _nvTotalDesc;
        private string _ConcAuto; //  varchar(1)
        private string _CodLugarDesp; //  varchar(30)
        private string _SolicitadoPor; //  varchar(30)
        private string _DespachadoPor; //  varchar(30)
        private string _Patente; //  varchar(9)
        private string _RetiradoPor; //  varchar(30)
        private string _CheckeoPorAlarmaVtas; //  varchar(1)
        private int _EnMantencion;
        private string _Usuario; // varchar(8)
        private string _UsuarioGeneraDocto; //  varchar(8)
        private DateTime _FechaHoraCreacion;
        private string _Sistema; //  varchar(2)
        private string _ConcManual; //  varchar(1)
        private string _RutSolicitante; //  varchar(20)
        private string _proceso; //  varchar(50)
        private float _TotalBoleta;
        private int _NumReq;
        private string _CodBodeWms; //  varchar(10)
        private string _CodLugarDocto; //  varchar(30)
        private string _RutTransportista; //  varchar(20)
        private string _Cod_Distrib; //  varchar(10)
        private string _Nom_Distrib; //  varchar(60)


        public int NVNumero
        {
            get { return _NVNumero; }
            set { _NVNumero = value; }
        }
        public DateTime nvFem
        {
            get { return _nvFem; }
            set { _nvFem = value; }
        }


        public string nvEstado
        {
            get { return _nvEstado; }
            set { _nvEstado = value; }
        }

        public int nvEstFact
        {
            get { return _nvEstFact; }
            set { _nvEstFact = value; }
        }


        public int nvEstDesp
        {
            get { return _nvEstDesp; }
            set { _nvEstDesp = value; }
        }

        public int nvEstRese
        {
            get { return _nvEstRese; }
            set { _nvEstRese = value; }
        }

        public int nvEstConc
        {
            get { return _nvEstConc; }
            set { _nvEstConc = value; }
        }

        public int CotNum
        {
            get { return _CotNum; }
            set { _CotNum = value; }
        }


        public string NumOC
        {
            get { return _NumOC; }
            set { _NumOC = value; }
        }


        public DateTime nvFeEnt
        {
            get { return _nvFeEnt; }
            set { _nvFeEnt = value; }
        }

        public string CodAux
        {
            get { return _CodAux; }
            set { _CodAux = value; }
        }

        public string VenCod
        {
            get { return _VenCod; }
            set { _VenCod = value; }
        }

        public string CodMon
        {
            get { return _CodMon; }
            set { _CodMon = value; }
        }

        public string CodLista
        {
            get { return _CodLista; }
            set { _CodLista = value; }
        }

        public string nvObser
        {
            get { return _nvObser; }
            set { _nvObser = value; }
        }


        public string nvCanalNV
        {
            get { return _nvCanalNV; }
            set { _nvCanalNV = value; }
        }

        public string CveCod
        {
            get { return _CveCod; }
            set { _CveCod = value; }
        }

        public string NomCon
        {
            get { return _NomCon; }
            set { _NomCon = value; }
        }


        public string CodiCC
        {
            get { return _CodiCC; }
            set { _CodiCC = value; }
        }
        public string CodBode
        {
            get { return _CodBode; }
            set { _CodBode = value; }
        }

        public float nvSubTotal
        {
            get { return _nvSubTotal; }
            set { _nvSubTotal = value; }
        }


        public float nvPorcDesc01
        {
            get { return _nvPorcDesc01; }
            set { _nvPorcDesc01 = value; }
        }

        public float nvDescto01
        {
            get { return _nvDescto01; }
            set { _nvDescto01 = value; }
        }

        public float nvPorcDesc02
        {
            get { return _nvPorcDesc02; }
            set { _nvPorcDesc02 = value; }
        }

        public float nvDescto02
        {
            get { return _nvDescto02; }
            set { _nvDescto02 = value; }
        }
        public float nvPorcDesc03
        {
            get { return _nvPorcDesc03; }
            set { _nvPorcDesc03 = value; }
        }
        public float nvDescto03
        {
            get { return _nvDescto03; }
            set { _nvDescto03 = value; }
        }

        public float nvPorcDesc04
        {
            get { return _nvPorcDesc04; }
            set { _nvPorcDesc04 = value; }
        }

        public float nvDescto04
        {
            get { return _nvDescto04; }
            set { _nvDescto04 = value; }
        }
        public float nvPorcDesc05
        {
            get { return _nvPorcDesc05; }
            set { _nvPorcDesc05 = value; }
        }

        public float nvDescto05
        {
            get { return _nvDescto05; }
            set { _nvDescto05 = value; }
        }

        public float nvMonto
        {
            get { return _nvMonto; }
            set { _nvMonto = value; }
        }

        public DateTime nvFeAprob
        {
            get { return _nvFeAprob; }
            set { _nvFeAprob = value; }
        }

        public int NumGuiaRes
        {
            get { return _NumGuiaRes; }
            set { _NumGuiaRes = value; }
        }

        public float nvPorcFlete
        {
            get { return _nvPorcFlete; }
            set { _nvPorcFlete = value; }
        }
        public float nvValflete
        {
            get { return _nvValflete; }
            set { _nvValflete = value; }
        }


        public float nvPorcEmb
        {
            get { return _nvPorcEmb; }
            set { _nvPorcEmb = value; }
        }

        public float nvValEmb
        {
            get { return _nvValEmb; }
            set { _nvValEmb = value; }
        }



        public float nvEquiv
        {
            get { return _nvEquiv; }
            set { _nvEquiv = value; }
        }

        public float nvNetoExento
        {
            get { return _nvNetoExento; }
            set { _nvNetoExento = value; }
        }



        public float nvNetoAfecto
        {
            get { return _nvNetoAfecto; }
            set { _nvNetoAfecto = value; }
        }
         
        public float nvTotalDesc
        {
            get { return _nvTotalDesc; }
            set { _nvTotalDesc = value; }
        }


        public string ConcAuto
        {
            get { return _ConcAuto; }
            set { _ConcAuto = value; }
        }


        public string CodLugarDesp
        {
            get { return _CodLugarDesp; }
            set { _CodLugarDesp = value; }
        }



        public string SolicitadoPor
        {
            get { return _SolicitadoPor; }
            set { _SolicitadoPor = value; }
        }




        public string DespachadoPor
        {
            get { return _DespachadoPor; }
            set { _DespachadoPor = value; }
        }




        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }



        public string RetiradoPor
        {
            get { return _RetiradoPor; }
            set { _RetiradoPor = value; }
        }


        public string CheckeoPorAlarmaVtas
        {
            get { return _CheckeoPorAlarmaVtas; }
            set { _CheckeoPorAlarmaVtas = value; }
        }


        public int EnMantencion
        {
            get { return _EnMantencion; }
            set { _EnMantencion = value; }
        }

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string UsuarioGeneraDocto
        {
            get { return _UsuarioGeneraDocto; }
            set { _UsuarioGeneraDocto = value; }
        }

        public DateTime FechaHoraCreacion
        {
            get { return _FechaHoraCreacion; }
            set { _FechaHoraCreacion = value; }
        }

        public string Sistema
        {
            get { return _Sistema; }
            set { _Sistema = value; }
        }

        public string ConcManual
        {
            get { return _ConcManual; }
            set { _ConcManual = value; }
        }

        public string RutSolicitante
        {
            get { return _RutSolicitante; }
            set { _RutSolicitante = value; }
        }


        public string proceso
        {
            get { return _proceso; }
            set { _proceso = value; }
        }


        public float TotalBoleta
        {
            get { return _TotalBoleta; }
            set { _TotalBoleta = value; }
        }



        public int NumReq
        {
            get { return _NumReq; }
            set { _NumReq = value; }
        }

        public string CodBodeWms
        {
            get { return _CodBodeWms; }
            set { _CodBodeWms = value; }
        }



        public string CodLugarDocto
        {
            get { return _CodLugarDocto; }
            set { _CodLugarDocto = value; }
        }




        public string RutTransportista
        {
            get { return _RutTransportista; }
            set { _RutTransportista = value; }
        }



        public string Cod_Distrib
        {
            get { return _Cod_Distrib; }
            set { _Cod_Distrib = value; }
        }



        public string Nom_Distrib
        {
            get { return _Nom_Distrib; }
            set { _Nom_Distrib = value; }

        }



    }
}