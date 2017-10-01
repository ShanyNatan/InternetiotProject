using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternetiotProject.Startup))]
namespace InternetiotProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
