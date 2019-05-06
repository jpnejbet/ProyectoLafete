using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disofi.ServicioSoftland
{
    public class DataSource
    {


        //public static string coneccionPrimaria = "Initial Catalog=CHOCLAFETE;Data Source=172.16.150.100;User ID=sa;password=Softland390";
        //public static string coneccionPrimaria2 = "Initial Catalog=Disofi;Data Source=172.16.150.100;User ID=sa;password=Softland390";

        //// Local
        public static string coneccionPrimaria = "Initial Catalog=CHOCLAFETE;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";
        public static string coneccionPrimaria2 = "Initial Catalog=DisofiLafte;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";


        /// <summary>
        /// Tamarugal
        /// </summary>
        //public static string coneccionPrimaria = "Initial Catalog=TAMARUGAL;Data Source=192.168.1.28;User ID=sa;password=Softland470";
        //public static string coneccionPrimaria2 = "Initial Catalog=TamarugalPR;Data Source=192.168.1.28;User ID=sa;password=Softland470";


        ///// Tamarugal local
        //public static string coneccionPrimaria = "Initial Catalog=TAMARUGAL;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";
        //public static string coneccionPrimaria2 = "Initial Catalog=Taller;Data Source=DESKTOP-LRG9NM8;User ID=sa;password=abcd.1234";



        //raico
        ///   public static string coneccionPrimaria = "Initial Catalog=Raio;Data Source=(Local);User ID=sa;password=conectiva";




        // coneccionPrimaria = "Initial Catalog=TamarugalPR;Data Source=192.168.1.28;User ID=sa;password=Softland470";




        public static bool cache;

        //DESKTOP-LRG9NM8

        public static void SetCache(bool hasCache)
        {
            cache = hasCache;
        }

        public string ConeccionPrimaria { get { return coneccionPrimaria; } }
        public string ConeccionPrimaria2 { get { return coneccionPrimaria2; } }

    }
}