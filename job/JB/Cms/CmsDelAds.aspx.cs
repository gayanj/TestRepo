using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JB.Cms
{
    public partial class CmsDelAds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //send del command


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //cancel
            Response.Redirect("/cms/cmshome.aspx");
        }
    }
}