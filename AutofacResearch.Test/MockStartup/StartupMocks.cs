using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using AutofacResearch.WebApi;
using AutofacResearch.WebApi.Modules;

namespace AutofacResearch.Test.MockStartup
{
    public class StandardModuleMock : Startup
    {
        protected override void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterModule(new StandardModule());
        }
    }

    public class NamedModuleMock : Startup
    {
        protected override void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterModule(new NamedModules());
        }
    }

    public class NamedWithDefaultsModuleMock : Startup
    {
        protected override void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterModule(new NamedWithDefaultsModule());
        }
    }
}
