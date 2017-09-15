using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Autofac.Features.AttributeFilters;
using Autofac.Integration.WebApi;
using AutofacResearch.Core.Interfaces;
using Core.DataProvider.Services;
using Module = Autofac.Module;

namespace AutofacResearch.WebApi.Modules
{
    public class NamedModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).WithAttributeFiltering(); // with attribute filtering has to be called

            builder.RegisterType<CorePersonService>().Keyed<IPersonService>("Core");
            builder.RegisterType<SecondCorePersonService>().Keyed<IPersonService>("Second");
            base.Load(builder);
        }
    }
}