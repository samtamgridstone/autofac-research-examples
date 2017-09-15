using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacResearch.Test.MockStartup;
using AutofacResearch.WebApi;
using Microsoft.Owin.Testing;
using Xunit;

namespace AutofacResearch.Test
{
    public abstract class TestBase<TSTartup>
        where TSTartup : new()
    {
        #region Private Variables

        private TestServer _testServer;
        private Uri hostUri = new Uri(@"https://localhost:61234");
        #endregion

        #region Protected Variables
        protected const string Core = "\"Core\"";
        protected const string SecondaryCore = "\"Secondary Core\"";
        protected const string DefaultPersonStringValue = "\"Default Person Service\"";
        #endregion

        public TestBase()
        {
            _testServer = TestServer.Create<TSTartup>();
            _testServer.BaseAddress = hostUri;
        }

        protected virtual async Task GetDataProviderTest(string controllerName, string expectedResult)
        {
            var result = await _testServer.HttpClient.GetAsync(new Uri(hostUri, $@"{controllerName}/getdataprovider"));
            Assert.NotNull(result);
            Assert.Equal(true, result.IsSuccessStatusCode);

            string resultValue = result.Content.ReadAsStringAsync().Result;

            Assert.Equal(expectedResult, resultValue);
        }
    }
}
