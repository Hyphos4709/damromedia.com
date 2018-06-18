using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(damromedia.com_v1.Startup))]
namespace damromedia.com_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
