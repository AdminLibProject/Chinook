using System.Web.Http;
using Chinook;

namespace Chinook {
    public class WebApiApplication : System.Web.HttpApplication {

        protected void Application_Start() {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
