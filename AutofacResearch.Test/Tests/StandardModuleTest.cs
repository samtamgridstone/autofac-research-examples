using System.Threading.Tasks;
using AutofacResearch.Test.MockStartup;
using Xunit;

namespace AutofacResearch.Test.Tests
{
    public class StandardModuleTest : TestBase<StandardModuleMock>
    {
        [Theory]
        [InlineData("standardCoreperson", Core)]
        protected override async Task GetDataProviderTest(string controllerName, string expectedResult)
        {
            await base.GetDataProviderTest(controllerName, expectedResult);
        }
    }
}
