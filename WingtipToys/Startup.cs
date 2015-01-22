using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Microsoft.Owin.Security;

[assembly: OwinStartupAttribute(typeof(WingtipToys.Startup))]
namespace WingtipToys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigAuth(app);
        }
        public void ConfigAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login")
            });
        }
    }
}
