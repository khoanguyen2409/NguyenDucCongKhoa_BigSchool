using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenDucCongKhoa_BigSchool.Startup))]
namespace NguyenDucCongKhoa_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
