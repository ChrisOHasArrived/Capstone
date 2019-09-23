using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollabFast.Startup))]
namespace CollabFast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
