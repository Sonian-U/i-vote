using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EVotingSystems.Startup))]
namespace EVotingSystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
