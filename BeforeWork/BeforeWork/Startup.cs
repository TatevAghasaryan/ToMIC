using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeforeWork.Startup))]
namespace BeforeWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
