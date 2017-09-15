using System.Web.Http;

namespace AutofacResearch.WebApi
{
    public static class WebApiConfiguration
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "AllRoute",
                routeTemplate: "{controller}/{action}"
            );
        }
    }
}