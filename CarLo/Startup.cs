using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarLo.Startup))]
namespace CarLo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
