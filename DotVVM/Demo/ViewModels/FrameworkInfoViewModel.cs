using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace Demo.ViewModels
{
    public class FrameworkInfoViewModel : SiteViewModel
    {
        public override string Title => "Framework Info";

        public string FrameworkName { get; set; }
        public string FrameworkVersion { get; set; }
        public string FrameworkYear { get; set; }

        public override Task Load()
        {
            var slug = Context.Query["Slug"];

            switch (slug)
            {
                case "windows-forms":
                    SetData("Windows Forms", "1.0", "2001");
                    break;
                case "web-forms":
                    SetData("ASP.NET Web Forms", "1.0", "2001");
                    break;
                case "wpf":
                    SetData("Windows Presentation Foundation", "3.0", "2006");
                    break;
            }

            return base.Load();
        }

        private void SetData(string name, string version, string year)
        {
            FrameworkName = name;
            FrameworkVersion = version;
            FrameworkYear = year;
        }
    }
}
