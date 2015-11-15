using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFirstProject.Startup))]
namespace MVCFirstProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
