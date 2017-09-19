using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Owin;

namespace AutofacResearch.WebApi
{
    public class Startup
    {
        public static IContainer Container;

        public void Configuration(IAppBuilder app)
        {
            // set up the autofac container
            var builder = new ContainerBuilder();

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfiguration.Register(config);
            RegisterModules(builder);

            var container = builder.Build();
            Container = container;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container); // instantiate the dependency resolver  

            // Register the Autofac middleware FIRST, then the Autofac Web API middleware,
            // and finally the standard Web API middleware.
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }

        protected virtual void RegisterModules(ContainerBuilder builder)
        {
            ModuleRegistration.Register(builder);
        }
    }
}