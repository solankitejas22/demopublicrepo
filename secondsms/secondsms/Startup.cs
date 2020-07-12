using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(secondsms.Startup))]
namespace secondsms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
