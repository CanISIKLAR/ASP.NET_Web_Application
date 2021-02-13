using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projecta.Startup))]
namespace Projecta
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
