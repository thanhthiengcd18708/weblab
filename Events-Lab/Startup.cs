using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Events_Lab.Startup))]
namespace Events_Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
