using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadShoppers.Startup))]
namespace MadShoppers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
