using Autofac.Features.AttributeFilters;
using AutofacResearch.Core.Interfaces;

namespace AutofacResearch.WebApi.Controllers.Named
{
    public class SecondCorePersonController : BaseController
    {
        public SecondCorePersonController([KeyFilter("Second")]IPersonService service) : base(service) { }

    }
}
