using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BllodSugarTester.Startup))]
namespace BllodSugarTester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
