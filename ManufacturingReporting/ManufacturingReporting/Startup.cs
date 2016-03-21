using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManufacturingReporting.Startup))]
namespace ManufacturingReporting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
