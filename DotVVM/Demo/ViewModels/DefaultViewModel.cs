using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;
using DotVVM.Framework.Controls;
using DotVVM.Framework.ViewModel;

namespace Demo.ViewModels
{
    public class DefaultViewModel : SiteViewModel
    {
        public override string Title => ".NET Frameworks";

        public GridViewDataSet<Framework> Data { get; } = new GridViewDataSet<Framework>();

        public override Task PreRender()
        {
            if (Data.IsRefreshRequired)
            {
                Data.LoadFromQueryable(GetFrameworks().AsQueryable());
            }
            return base.PreRender();
        }

        private static IEnumerable<Framework> GetFrameworks()
        {
            yield return new Framework("windows-forms", "1.0", "Windows Forms");
            yield return new Framework("web-forms", "1.0", "ASP.NET Web Forms");
            yield return new Framework("wpf", "3.0", "Windows Presentation Foundation");
        }
    }
}
