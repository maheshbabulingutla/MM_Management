using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MM_Management.Startup))]
namespace MM_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
