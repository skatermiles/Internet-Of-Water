using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(waterSystem.Startup))]
namespace waterSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
