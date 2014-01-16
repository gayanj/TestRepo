using System;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsSitemaps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var iclass = new ClCmsClass();
            GridView1.DataSource = iclass.Getcmssitemaps();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            var iclass = new ClCmsClass();
            GridView1.DataSource = iclass.Getcmssitemaps();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}