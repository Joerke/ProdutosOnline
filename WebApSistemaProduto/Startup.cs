using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApSistemaProduto.Startup))]
namespace WebApSistemaProduto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
