using Autofac.Features.AttributeFilters;
using AutofacResearch.Core.Interfaces;

namespace AutofacResearch.WebApi.Controllers.Named
{
    public class FirstCorePersonController : BaseController
    {
        public FirstCorePersonController([KeyFilter("Core")]IPersonService service) : base(service)
        {
        }

    }
}
