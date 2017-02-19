using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TripTest.Web.Startup))]

namespace TripTest.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
