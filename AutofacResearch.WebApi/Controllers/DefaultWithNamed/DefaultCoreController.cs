using AutofacResearch.Core.Interfaces;

namespace AutofacResearch.WebApi.Controllers.DefaultWithNamed
{
    public class DefaultCoreController : BaseController
    {
        public DefaultCoreController(IPersonService personService) : base(personService) { }
    }
}
