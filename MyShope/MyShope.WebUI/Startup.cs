using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShope.WebUI.Startup))]
namespace MyShope.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
