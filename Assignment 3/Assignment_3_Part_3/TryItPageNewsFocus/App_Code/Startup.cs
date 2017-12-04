using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItPageNewsFocus.Startup))]
namespace TryItPageNewsFocus
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
