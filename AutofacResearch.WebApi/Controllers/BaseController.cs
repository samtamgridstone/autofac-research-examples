using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutofacResearch.Core.Interfaces;

namespace AutofacResearch.WebApi.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected readonly IPersonService Service;

        protected BaseController(IPersonService personService) => Service = personService;

        [HttpGet]
        public string GetDataProvider()
        {
            return Service.GetProviderName();
        }
    }
}
