using AutofacResearch.Core.Interfaces;

namespace Jump.DataProvider.Services
{
    public class JumpPersonService: IPersonService
    {
        public string GetProviderName()
        {
            return "Jump";
        }
    }
}
