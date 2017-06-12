using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureAppService.Startup))]
namespace AzureAppService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
