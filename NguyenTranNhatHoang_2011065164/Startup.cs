using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTranNhatHoang_2011065164.Startup))]
namespace NguyenTranNhatHoang_2011065164
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
