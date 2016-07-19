using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UBlog.MVC.Startup))]
namespace UBlog.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
