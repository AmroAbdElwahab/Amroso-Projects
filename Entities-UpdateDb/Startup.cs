using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entities_UpdateDb.Startup))]
namespace Entities_UpdateDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
