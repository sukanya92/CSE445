using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItPageNewsHeadlines.Startup))]
namespace TryItPageNewsHeadlines
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
