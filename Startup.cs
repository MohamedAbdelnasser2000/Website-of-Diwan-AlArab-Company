using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GovEgy_2.Startup))]
namespace GovEgy_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
