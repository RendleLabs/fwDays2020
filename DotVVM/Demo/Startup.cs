using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Demo.Startup))]

namespace Demo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var applicationPath = HostingEnvironment.ApplicationPhysicalPath;

            app.UseDotVVM<DotvvmStartup>(applicationPath);
        }
    }
}