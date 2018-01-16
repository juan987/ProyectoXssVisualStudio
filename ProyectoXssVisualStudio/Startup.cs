using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoXssVisualStudio.Startup))]
namespace ProyectoXssVisualStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
