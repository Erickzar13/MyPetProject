using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Web.Http;
using MySimpleWebApp.Models;
using SimpleInjector.Integration.Web.Mvc;

namespace MySimpleWebApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Container container = new Container();
            RegisterDependecies(container);

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
        private void RegisterDependecies(Container container)
        {
            container.RegisterSingleton<ILog>(LogManager.GetLogger("RollingFileAppender"));
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
    }
}
