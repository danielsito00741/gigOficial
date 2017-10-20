using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigOficial.Startup))]
namespace GigOficial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
