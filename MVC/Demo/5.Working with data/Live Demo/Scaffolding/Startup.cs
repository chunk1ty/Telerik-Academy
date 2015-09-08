using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scaffolding.Startup))]
namespace Scaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
