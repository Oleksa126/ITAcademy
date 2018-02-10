using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItAcademy.Startup))]
namespace ItAcademy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
