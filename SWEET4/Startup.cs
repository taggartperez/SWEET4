using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SWEET4.Startup))]
namespace SWEET4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
