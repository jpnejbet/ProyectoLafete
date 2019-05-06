using System.Web;
using System.Web.Optimization;

namespace DisofiSC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
          
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                         "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Content/vendors/jquery/dist/jquery.min.js",
                        "~/Content/vendors/bootstrap/dist/js/bootstrap.min.js",
                        "~/Content/vendors/fastclick/lib/fastclick.js",
                        "~/Content/vendors/nprogress/nprogress.js",
                        "~/Content/vendors/Chart.js/dist/Chart.min.js",
                        "~/Content/vendors/gauge.js/dist/gauge.min.js",
                        "~/Content/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                        "~/Content/vendors/iCheck/icheck.min.js",
                        "~/Content/vendors/skycons/skycons.js",
                        "~/Content/vendors/raphael/raphael.min.js", 
                        "~/Content/vendors/Flot/jquery.flot.js",
                        "~/Content/vendors/Flot/jquery.flot.pie.js",
                        "~/Content/vendors/Flot/jquery.flot.time.js",
                        "~/Content/vendors/Flot/jquery.flot.stack.js",
                        "~/Content/vendors/Flot/jquery.flot.resize.js",
                        "~/Content/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                        "~/Content/vendors/flot-spline/js/jquery.flot.spline.min.js",
                        "~/Content/vendors/flot.curvedlines/curvedLines.js",
                        "~/Content/vendors/DateJS/build/date.js",
                        "~/Content/vendors/jqvmap/dist/jquery.vmap.js",
                        "~/Content/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                        "~/Content/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                        "~/Content/vendors/moment/min/moment.min.js",
                        "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.js",
                        "~/Content/vendors/alertifyjs/alertify.js",
                        "~/Content/vendors/datatables.net/js/jquery.dataTables.min.js",
                        "~/Content/vendors/datatables.net-buttons/js/dataTables.buttons.js",
                        "~/Content/vendors/datatables.net-bs/js/dataTables.bootstrap.min.js",
                        "~/Content/vendors/datatables.net-buttons/js/dataTables.buttons.min.js",
                        "~/Content/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
                        "~/Content/vendors/datatables.net-buttons/js/buttons.flash.min.js",
                        "~/Content/vendors/datatables.net-buttons/js/buttons.html5.min.js",
                        "~/Content/vendors/datatables.net-buttons/js/buttons.print.min.js",
                        "~/Content/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",
                        "~/Content/vendors/datatables.net-keytable/js/dataTables.keyTable.min.js",
                        "~/Content/vendors/datatables.net-responsive/js/dataTables.responsive.min.js",
                        "~/Content/vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js",
                        "~/Content/vendors/datatables.net-scroller/js/dataTables.scroller.min.js",
                        "~/Content/vendors/jszip/dist/jszip.min.js",
                        "~/Content/vendors/pdfmake/build/pdfmake.min.js",
                        "~/Content/vendors/pdfmake/build/vfs_fonts.js",
                         "~/Content/vendors/jQuery-Smart-Wizard/js/jquery.smartWizard.js",
                        "~/Scripts/custom.min.js"
                        ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/site.css",
                        "~/Content/vendors/bootstrap/dist/css/bootstrap.min.css",
                        "~/Content/vendors/font-awesome/css/font-awesome.min.css",
                        "~/Content/vendors/nprogress/nprogress.css",
                        "~/Content/vendors/iCheck/skins/flat/green.css",  
                        "~/Content/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                        "~/Content/vendors/jqvmap/dist/jqvmap.min.css",
                        "~/Content/vendors/bootstrap-daterangepicker/daterangepicker.css",
                        "~/Content/vendors/alertifyjs/css/alertify.css",
                        "~/Content/vendors/datatables.net-bs/css/dataTables.bootstrap.min.css",
                        "~/Content/vendors/datatables.net-buttons-bs/css/buttons.bootstrap.min.css",
                        "~/Content/vendors/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css",
                        "~/Content/vendors/datatables.net-responsive-bs/css/responsive.bootstrap.min.css",
                        "~/Content/vendors/datatables.net-scroller-bs/css/scroller.bootstrap.min.css",
                        "~/Content/css/custom.css"));


        }
    }
}

