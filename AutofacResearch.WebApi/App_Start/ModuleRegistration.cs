using Autofac;
using AutofacResearch.WebApi.Modules;

namespace AutofacResearch.WebApi
{
    public class ModuleRegistration
    {
        public static void Register(ContainerBuilder builder)
        {
            //builder.RegisterModule(new CoreModule());
            //builder.RegisterModule(new NamedModules());
            builder.RegisterModule(new NamedWithDefaultsModule());
        }
    }
}