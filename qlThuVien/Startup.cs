using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(qlThuVien.Startup))]
namespace qlThuVien
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
