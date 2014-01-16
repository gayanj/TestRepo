using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsShowArticles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ga = new ClCmsClass();
            GridArticles.DataSource = ga.Getcmsarticles();
            GridArticles.DataBind();
        }

        protected void GridArticles_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var ga = new ClCmsClass();
            GridArticles.DataSource = ga.Getcmsarticles();
            GridArticles.PageIndex = e.NewPageIndex;
            GridArticles.DataBind();
        }
    }
}