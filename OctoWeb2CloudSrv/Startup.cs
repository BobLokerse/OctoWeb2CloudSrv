using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctoWeb2CloudSrv.Startup))]
namespace OctoWeb2CloudSrv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
