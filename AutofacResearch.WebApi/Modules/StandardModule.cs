using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;
using AutofacResearch.Core.Interfaces;
using Core.DataProvider.Services;
using Module = Autofac.Module;

namespace AutofacResearch.WebApi.Modules
{
    /// <summary>
    ///  Autofac modules  are created 
    /// </summary>
    public class StandardModule : Module
    {
        /// <summary>
        ///  Conditional logic can be used
        /// </summary>
        public bool _randomTestValue = true;

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); // will this work for External WebService ? 
            if (_randomTestValue)
            {
                builder.RegisterType<CorePersonService>().As<IPersonService>();
            }

            base.Load(builder);
        }
    }
}