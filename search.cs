#sample code

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoBikeProj.Startup))]
namespace demoBikeProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
