using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Semana7.Startup))]
namespace Semana7
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
