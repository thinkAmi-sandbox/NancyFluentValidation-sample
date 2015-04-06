using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nancy;
using Nancy.Extensions;
using Owin;

namespace OwinSelfHosting
{
    public class Startup
    {
        public void Configuration(Owin.IAppBuilder app)
        {
            app.UseNancy();     // Owin名前空間のusingが必要
        }
    }
}
