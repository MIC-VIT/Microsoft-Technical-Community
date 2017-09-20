using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIC.Startup))]
namespace MIC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
