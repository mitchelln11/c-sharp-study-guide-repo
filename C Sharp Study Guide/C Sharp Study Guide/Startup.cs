using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C_Sharp_Study_Guide.Startup))]
namespace C_Sharp_Study_Guide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
