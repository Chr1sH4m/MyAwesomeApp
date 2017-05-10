using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAwesomeApp.Startup))]
namespace MyAwesomeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
