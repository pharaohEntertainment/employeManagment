using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeMangment.Startup))]
namespace EmployeMangment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
