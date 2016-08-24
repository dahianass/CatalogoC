using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Catalogo.Startup))]
namespace Catalogo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
