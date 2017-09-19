using System.Web.Http;
using Autofac;
using AutofacResearch.Core.Interfaces;

namespace AutofacResearch.WebApi.Controllers.Sourced
{
    /// <inheritdoc />
    /// <summary>
    ///  to mock the source controllers
    /// </summary>
    [RoutePrefix("api/{dataProvider}/dataprovider")]
    public class DataSourceController : BaseController
    {
        public DataSourceController()
        {
            IPersonService personService = Startup.Container.Resolve<IPersonService>();
        }

        [Route("GetDataProviderWithSource")]
        [HttpGet]
        public void GetDataProviderWithSource(string dataProvider)
        {
            // Note: the dataprovider is case senstive so LEAP is different from Leap.
            IPersonService personService = Startup.Container.ResolveKeyed<IPersonService>(dataProvider);
        }

        [Route("GetData")]
        [HttpGet]
        public void GetData()
        {

        }
    }
}
