using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RudyCon_Site.Startup))]
namespace RudyCon_Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
