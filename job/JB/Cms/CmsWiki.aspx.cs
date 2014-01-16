using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsWiki : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //load wiki
            var _caller = new ClCmsWiki();
            GridView1.DataSource = _caller.GetWiki();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var _caller = new ClCmsWiki();
            GridView1.DataSource = _caller.GetWiki();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}