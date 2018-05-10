using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EuropePeaceConvention.Startup))]
namespace EuropePeaceConvention
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
