using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JB.Cms
{
    public partial class CmsEditHeaderItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // update here

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //redirect
            Response.Redirect("/cms/cmshome.aspx");
        }
    }
}