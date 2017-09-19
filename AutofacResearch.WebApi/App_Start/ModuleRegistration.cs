using Autofac;
using AutofacResearch.WebApi.Modules;

namespace AutofacResearch.WebApi
{
    public class ModuleRegistration
    {
        public static void Register(ContainerBuilder builder)
        {
            //builder.RegisterModule(new StandardModule());
            //builder.RegisterModule(new NamedModules());
            //builder.RegisterModule(new NamedWithDefaultsModule());
            builder.RegisterModule(new DataProviderModule());
        }
    }
}