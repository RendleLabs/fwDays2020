using DotVVM.Framework.Configuration;

namespace Demo
{
    public class DotvvmStartup : IDotvvmStartup
    {
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            // config.RouteTable.Add("FrameworkInfo", "FrameworkInfo", "Views/FrameworkInfo.dothtml");
        }
    }
}