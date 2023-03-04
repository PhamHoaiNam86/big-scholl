using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamHoaiNam_2011068871.Startup))]
namespace PhamHoaiNam_2011068871
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
