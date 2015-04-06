
using Owin;

namespace OwinAspNetHosting
{
    public class Startup
    {
        public void Configuration(Owin.IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}