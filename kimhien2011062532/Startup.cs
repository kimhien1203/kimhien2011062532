using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kimhien2011062532.Startup))]
namespace kimhien2011062532
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
