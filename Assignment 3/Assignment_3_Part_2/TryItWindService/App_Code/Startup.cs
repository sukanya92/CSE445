using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItWindService.Startup))]
namespace TryItWindService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
