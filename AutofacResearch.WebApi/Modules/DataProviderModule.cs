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
using Jump.DataProvider.Services;
using Leap.DataProvider.Services;
using Module = Autofac.Module;

namespace AutofacResearch.WebApi.Modules
{
    /// <summary>
    /// To be used 
    /// </summary>
    public class DataProviderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // normal default person binding
            builder.RegisterType<DefaultPersonService>().As<IPersonService>();

            //binding based on namespaces? 
            builder.RegisterType<JumpPersonService>().Keyed<IPersonService>("Jump");
            builder.RegisterType<LeapPersonService>().Keyed<IPersonService>("Leap");
            base.Load(builder);
        }
    }
}