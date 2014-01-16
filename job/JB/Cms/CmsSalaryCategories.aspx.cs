using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class Cmssalarycategories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var clcms = new ClCmsClass();
            GridView1.DataSource = clcms.Getcmssalarycatgs();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var clcms = new ClCmsClass();
            GridView1.DataSource = clcms.Getcmssalarycatgs();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            var clcms = new ClCmsClass();
            GridView1.DataSource = clcms.Getcmssalarycatgs();
            GridView1.EditIndex = -1;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var clcms = new ClCmsClass();
            clcms.Deletecmssalarycatgs(Convert.ToInt32(e.Keys[0]));
            GridView1.DataSource = clcms.Getcmssalarycatgs();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            var clcms = new ClCmsClass();
            GridView1.DataSource = clcms.Getcmssalarycatgs();
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataBind();
        }
    }
}