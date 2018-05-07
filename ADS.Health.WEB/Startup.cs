using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADS.Health.WEB.Startup))]
namespace ADS.Health.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
