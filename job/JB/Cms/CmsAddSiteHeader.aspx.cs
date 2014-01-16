using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JB.Cms
{
    public partial class CmsSiteHeaderAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //add header item here

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //cancel header item
            Response.Redirect("/cms/cmshome.aspx");

        }
    }
}