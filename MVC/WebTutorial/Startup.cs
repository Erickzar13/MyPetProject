using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTutorial.Startup))]
namespace WebTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
