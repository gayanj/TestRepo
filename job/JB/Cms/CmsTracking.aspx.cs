using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsTracking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["tr"] != null)
            {
                var iclass = new ClCmsClass();

                switch (Request.QueryString["tr"])
                {
                    case "google":
                        Labelheaddetail.Text = "Google Tracker";
                        TextBox1.Text = iclass.Getcmstracker(Request.QueryString["tr"]);
                        break;
                    default:
                        Labelheaddetail.Text = "Share This Tracker";
                        TextBox1.Text = iclass.Getcmstracker(Request.QueryString["tr"]);
                        break;
                }
            }
        }
    }
}