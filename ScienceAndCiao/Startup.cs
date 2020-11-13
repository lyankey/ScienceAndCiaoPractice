using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScienceAndCiao.Startup))]
namespace ScienceAndCiao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
