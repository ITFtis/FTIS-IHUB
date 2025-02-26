using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace iHub
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //log4net
            log4net.Config.XmlConfigurator.Configure(); // must have this line
            var logger = log4net.LogManager.GetLogger(typeof(MvcApplication));

            try
            {
                if (AppConfig.IsBkTask)
                {
                    logger.Info("BkTask�Ұ�(Application_Start):" + DateFormat.ToDate6(DateTime.Now));

                    var task = new BkTask();
                    task.Run();
                }
            }
            catch (Exception ex)
            {
                logger.Error("BkTask���~:" + ex.Message);
            }
        }
    }
}
