using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EASY.Isis.Presentacion.Web.Startup))]
namespace EASY.Isis.Presentacion.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
