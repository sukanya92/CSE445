using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSE_445_A5_Part1.Startup))]
namespace CSE_445_A5_Part1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
