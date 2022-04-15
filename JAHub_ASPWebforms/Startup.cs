using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JAHub_ASPWebforms.Startup))]
namespace JAHub_ASPWebforms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
