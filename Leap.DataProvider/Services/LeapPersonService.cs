using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacResearch.Core.Interfaces;

namespace Leap.DataProvider.Services
{
    public class LeapPersonService: IPersonService
    {
        public string GetProviderName()
        {
            return "Leap";
        }
    }
}
