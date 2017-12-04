using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryIt_Verification.Startup))]
namespace TryIt_Verification
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
