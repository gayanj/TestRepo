using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsVideos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cclass = new ClCmsClass();
            GridView1.DataSource = cclass.Getcmsvideos();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var cclass = new ClCmsClass();
            GridView1.DataSource = cclass.Getcmsvideos();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}