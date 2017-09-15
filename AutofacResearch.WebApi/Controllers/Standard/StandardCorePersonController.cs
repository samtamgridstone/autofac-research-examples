using Autofac.Features.AttributeFilters;
using AutofacResearch.Core.Interfaces;

namespace AutofacResearch.WebApi.Controllers.Standard
{
    public class StandardCorePersonController : BaseController
    {
        public StandardCorePersonController(IPersonService service) : base(service)
        {
        }

    }
}
