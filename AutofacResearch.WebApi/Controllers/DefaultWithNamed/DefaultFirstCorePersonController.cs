using Autofac.Features.AttributeFilters;
using AutofacResearch.Core.Interfaces;

namespace AutofacResearch.WebApi.Controllers.DefaultWithNamed
{
    public class DefaultFirstCorePersonController : BaseController
    {
        public DefaultFirstCorePersonController([KeyFilter("Core")]IPersonService service) : base(service)
        {
        }

    }
}
