using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiTeamCity.Startup))]
namespace HiTeamCity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
