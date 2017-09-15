using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacResearch.Test.MockStartup;
using AutofacResearch.WebApi.Modules;
using Xunit;

namespace AutofacResearch.Test
{
    public class NamedWithDefaults :TestBase<NamedWithDefaultsModuleMock>
    {
        [Theory]
        [InlineData("DefaultSecondCore", SecondaryCore)]
        [InlineData("DefaultFirstCorePerson", Core)]
        [InlineData("DefaultCore", DefaultPersonStringValue)]
        protected override async Task GetDataProviderTest(string controllerName, string expectedResult)
        {
            await base.GetDataProviderTest(controllerName, expectedResult);
        }
    }
}
