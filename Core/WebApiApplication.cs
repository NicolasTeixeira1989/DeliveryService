using System.Data.Entity;
using System.Web;
using System.Web.Http;
using DeliveryService.Core;

namespace DeliveryService.Models
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Database.SetInitializer(new Initializer());
        }
    }
}