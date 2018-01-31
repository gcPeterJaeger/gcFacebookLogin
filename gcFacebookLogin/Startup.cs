using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gcFacebookLogin.Startup))]
namespace gcFacebookLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
