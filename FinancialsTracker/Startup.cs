using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinancialsTracker.Startup))]
namespace FinancialsTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
