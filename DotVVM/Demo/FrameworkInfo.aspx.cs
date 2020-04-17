using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class FrameworkInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var slug = Request.QueryString["Slug"];

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
        }

        private void SetData(string name, string version, string year)
        {
            FrameworkNameLabel.Text = name;
            FrameworkVersionLabel.Text = version;
            FrameworkYearLabel.Text = year;
        }
    }
}