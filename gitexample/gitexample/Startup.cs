using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitexample.Startup))]
namespace gitexample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
