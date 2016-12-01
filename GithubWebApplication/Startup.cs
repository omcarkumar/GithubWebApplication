using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubWebApplication.Startup))]
namespace GithubWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
