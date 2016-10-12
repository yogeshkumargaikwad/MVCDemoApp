using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCDemoApp.App_Start
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/angular").IncludeDirectory("~/vendor_js","*.js"));
			bundles.Add(new StyleBundle("~/Content/css").IncludeDirectory("~/vendor_css",".css"));
		}
	}	
}