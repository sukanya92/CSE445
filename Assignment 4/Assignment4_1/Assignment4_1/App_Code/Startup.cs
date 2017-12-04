using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment4_1.Startup))]
namespace Assignment4_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
