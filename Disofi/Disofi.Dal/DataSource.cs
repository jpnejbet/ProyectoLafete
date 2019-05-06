using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disofi.DAL
{
    public class DataSource
    {
        public static string coneccionPrimaria;
        public static bool cache;

        public static void SetParametros(string conn1)
        {


            //Tamarugal
            //   coneccionPrimaria = "Initial Catalog=TamarugalPR;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";
            //Lafete
            // coneccionPrimaria = "Initial Catalog=Disofi;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";
            ////public static string coneccionPrimaria2 = "Initial Catalog=CHOCLAFETE;Data Source=172.16.150.100;User ID=appicking;password=abcdLAFETE331";


            //Lafete
            //  coneccionPrimaria = "Initial Catalog=Disofi;Data Source=172.16.150.100;User ID=sa;password=Softland390";
            // coneccionPrimaria = "Initial Catalog=CHOCLAFETE;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";
            //coneccionPrimaria = "Initial Catalog=DisofiLafte;Data Source=DESKTOP-DFAKB00;User ID=sa;password=abcd.1234";
            // JP
            coneccionPrimaria = "Data Source = DESKTOP - MKRSQRM; Initial Catalog = Disofi2; Persist Security Info = True; User ID = usr_lafete; Password = usr_lafete";
            


            //Tamarugal cliente
            //   coneccionPrimaria = "Initial Catalog=TamarugalPR;Data Source=192.168.1.28;User ID=sa;password=Softland470";
            //  coneccionPrimaria = "Initial Catalog=TamarugalPR;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";


            // coneccionPrimaria = "Initial Catalog=DisofiRaico;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";
            // coneccionPrimaria = "Initial Catalog=DisofiRaico;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";


            ///   SNac center
            //     coneccionPrimaria = @"Initial Catalog=SC_ATENCION;Data Source=ITC-0016V11\SOSQL2016;User ID=Disofi;password=dsq-k4521";
            //   coneccionPrimaria = @"Initial Catalog=SC_ATENCION;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";



        }

        public static void SetCache(bool hasCache)
        {
            cache = hasCache;
        }

        public string ConeccionPrimaria { get { return coneccionPrimaria; } }
    }
}
