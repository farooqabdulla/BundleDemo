using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            ScriptBundle thirdPartyScripts = new ScriptBundle("~/Scripts/ThirdParty");
            thirdPartyScripts.Include("~/Scripts/jquery-2.2.0.min.js",
                                "~/Scripts/jquery-ui-1.11.4.min.js");

            bundles.Add(thirdPartyScripts);

            StyleBundle thirdPartyStyles = new StyleBundle("~/styles/ThirdParty");
            thirdPartyStyles.Include("~/Content/bootstrap.min.js");

            bundles.Add(thirdPartyStyles);
            BundleTable.EnableOptimizations = true;
        }
    }
}
