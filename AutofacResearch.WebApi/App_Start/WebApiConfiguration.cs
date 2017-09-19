using System.Web.Http;
using AutofacResearch.WebApi.Controllers.DefaultWithNamed;

namespace AutofacResearch.WebApi
{
    public static class WebApiConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            // Attribute routing.
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "AllRoute",
                routeTemplate: "api/{controller}/{action}"
            );
        }
    }
}