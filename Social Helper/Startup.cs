using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Social_Helper.Startup))]
namespace Social_Helper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
