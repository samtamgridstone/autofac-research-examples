using Autofac.Features.AttributeFilters;
using AutofacResearch.Core.Interfaces;

namespace AutofacResearch.WebApi.Controllers.DefaultWithNamed
{
    public class DefaultSecondCoreController : BaseController
    {
        public DefaultSecondCoreController([KeyFilter("Second")]IPersonService service) : base(service) { }

    }
}
