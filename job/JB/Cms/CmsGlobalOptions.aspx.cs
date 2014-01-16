using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class Cmsglobaloptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var clcms = new ClCmsClass();
            GridView1.DataSource = clcms.Getcpaneloptions();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var clcms = new ClCmsClass();
            GridView1.DataSource = clcms.Getcpaneloptions();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}