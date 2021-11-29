using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(project_crud_pim.Startup))]
namespace project_crud_pim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
