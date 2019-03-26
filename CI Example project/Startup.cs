using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CI_Example_project.Startup))]
namespace CI_Example_project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
