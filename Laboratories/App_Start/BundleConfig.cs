using System.Web;
using System.Web.Optimization;

namespace Laboratories
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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //background
            bundles.Add(new StyleBundle("~/Content/Background/css").Include(
                   "~/Content/Background/background.css"));
            bundles.Add(new ScriptBundle("~/bundles/Background/background").Include(
                     "~/Scripts/Background/background.js"));
            //login
            bundles.Add(new StyleBundle("~/Content/Plugins/css").Include(
                 "~/Content/Plugins/login.css"));
            //form
            bundles.Add(new StyleBundle("~/Content/Plugins/form").Include(
                   "~/Content/Plugins/form.css"));
        }
    }
}
