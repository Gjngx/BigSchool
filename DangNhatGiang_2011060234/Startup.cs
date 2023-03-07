using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DangNhatGiang_2011060234.Startup))]
namespace DangNhatGiang_2011060234
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
