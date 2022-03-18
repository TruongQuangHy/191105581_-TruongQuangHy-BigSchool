using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_191105581_TruongQuangHy_BigSchool.Startup))]
namespace _191105581_TruongQuangHy_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
