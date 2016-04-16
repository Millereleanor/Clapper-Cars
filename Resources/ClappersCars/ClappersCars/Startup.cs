using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClappersCars.Startup))]
namespace ClappersCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
