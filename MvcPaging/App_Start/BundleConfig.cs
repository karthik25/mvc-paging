using System.Web;
using System.Web.Optimization;

namespace MvcPaging
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/paging").Include("~/Scripts/paging-base.js","~/Scripts/paging-view.js"));
            bundles.Add(new ScriptBundle("~/bundles/paging-mustache").Include("~/Scripts/mustache.js", "~/Scripts/paging-base.js", "~/Scripts/paging-mustache.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap/bootstrap.css"));
        }
    }
}