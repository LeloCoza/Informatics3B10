using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FishLandApp.Startup))]
namespace FishLandApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
