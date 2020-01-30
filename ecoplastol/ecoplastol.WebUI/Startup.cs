using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ecoplastol.WebUI.Startup))]
namespace ecoplastol.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
