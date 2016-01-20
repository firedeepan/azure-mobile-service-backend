using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(deepancommobileappService.Startup))]

namespace deepancommobileappService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}