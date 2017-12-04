using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Try_It_Transformation.Startup))]
namespace Try_It_Transformation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
