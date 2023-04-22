using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnalistaQualidadeTeste.Startup))]
namespace AnalistaQualidadeTeste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
