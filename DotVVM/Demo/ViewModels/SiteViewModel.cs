using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace Demo.ViewModels
{
    public abstract class SiteViewModel : DotvvmViewModelBase
    {
        public abstract string Title { get; }

        public int Year { get; } = DateTime.Now.Year;
    }
}
