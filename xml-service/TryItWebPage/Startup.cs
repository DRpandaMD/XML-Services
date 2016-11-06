using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryItWebPage.Startup))]
namespace TryItWebPage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
