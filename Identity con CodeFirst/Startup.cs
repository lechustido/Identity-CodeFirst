using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identity_con_CodeFirst.Startup))]
namespace Identity_con_CodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
