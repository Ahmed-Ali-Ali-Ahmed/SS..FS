using System.Web;
using System.Web.Optimization;

namespace S.S.F.S
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            /* bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/site.css"));*/

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                       "~/js/jquery-3.3.1.min.js",
                       "~/js/jquery-ui.js",
                       "~/js/popper.min.js",
                       "~/js/bootstrap.min.js",
                       "~/js/owl.carousel.min.js",
                       "~/js/jquery.magnific-popup.min.js",
                       "~/js/jquery.sticky.js",
                      "~/js/jquery.waypoints.min.js",
                      "~/js/jquery.animateNumber.min.js",
                      "~/js/aos.js",
                      "~/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css",
                     "~/fonts/icomoon/style.css",
                     "~/css/bootstrap.min.css",
                     "~/css/magnific-popup.css",
                     "~/css/jquery-ui.css",
                     "~/css/owl.carousel.min.css",
                     "~/css/owl.theme.default.min.css",
                     "~/css/bootstrap-datepicker.css",
                     "~/fonts/flaticon/font/flaticon.css",
                     "~/css/aos.css",
                     "~/css/style.css"));
        }
    }
}



