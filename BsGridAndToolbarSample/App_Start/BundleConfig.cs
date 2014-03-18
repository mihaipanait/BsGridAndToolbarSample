using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MyGrid.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/BForms")
                //BForms CSS bundle
                .Include("~/Scripts/BForms/Bundles/css/*.css", new CssRewriteUrlTransform())
                .Include("~/Content/Stylesheets/*.css", new CssRewriteUrlTransform())
                );

            //ASP.NET MVC Bundling
            bundles.Add(new ScriptBundle("~/BFormsJS")
                .IncludeDirectory("~/Scripts/BForms/Bundles/js", "*.js"));
        }
    }
}

