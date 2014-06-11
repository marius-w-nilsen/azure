using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(azureTest.Startup))]
namespace azureTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
