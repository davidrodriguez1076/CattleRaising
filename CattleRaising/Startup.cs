using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CattleRaising.Startup))]
namespace CattleRaising
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
