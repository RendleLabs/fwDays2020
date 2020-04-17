using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Demo.Models;

namespace Demo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Framework> FrameworkGrid_GetData()
        {
            yield return new Framework("windows-forms", "1.0", "Windows Forms");
            yield return new Framework("web-forms", "1.0", "ASP.NET Web Forms");
        }
    }
}