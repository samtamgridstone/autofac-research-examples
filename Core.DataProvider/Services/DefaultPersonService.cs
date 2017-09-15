using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacResearch.Core.Interfaces;

namespace Core.DataProvider.Services
{
    public class DefaultPersonService : IPersonService
    {
        public string GetProviderName()
        {
            return "Default Person Service";
        }
    }
}
