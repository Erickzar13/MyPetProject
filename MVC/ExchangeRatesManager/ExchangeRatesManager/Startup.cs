using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExchangeRatesManager.Startup))]
namespace ExchangeRatesManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
