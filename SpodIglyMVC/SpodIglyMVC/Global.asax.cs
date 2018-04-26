using SpodIglyMVC.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SpodIglyMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Database.SetInitializer<StoreContext>(new StoreInitializer());
            BundleMobileConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
