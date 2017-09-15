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
    public class NamedModuleTest : TestBase<NamedModuleMock>
    {
        [Theory]
        [InlineData("secondCoreperson", SecondaryCore)]
        [InlineData("FirstCorePerson", Core)]
        protected override async Task GetDataProviderTest(string controllerName, string expectedResult)
        {
            await base.GetDataProviderTest(controllerName, expectedResult);
        }
    }
}
