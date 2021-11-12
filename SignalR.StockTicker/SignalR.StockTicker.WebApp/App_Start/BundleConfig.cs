using System.Web;
using System.Web.Optimization;

namespace SignalR.StockTicker.WebApp
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
            
            bundles.Add(new ScriptBundle("~/bundles/jquerycolor").Include(
                        "~/Scripts/jquery.color-2.2.0.min.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/jquerysignalR").Include(
                        "~/Scripts/jquery.signalR-2.4.2.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/popper.js",
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            
            bundles.Add(new StyleBundle("~/Content/stockTicker").Include(
                      "~/Content/StockTicker.css"));

            bundles.Add(new ScriptBundle("~/Script/stockTicker").Include(
                      "~/Scripts/SignalR.StockTicker.js"));
        }
    }
}
