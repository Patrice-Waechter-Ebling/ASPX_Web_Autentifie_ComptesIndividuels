using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPX_Web_Autentifie_ComptesIndividuels.Startup))]
namespace ASPX_Web_Autentifie_ComptesIndividuels
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
