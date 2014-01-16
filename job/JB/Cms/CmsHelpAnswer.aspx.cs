using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsHelpAns : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var iclass = new ClCmsClass();
            GridView1.DataSource = iclass.Getcmshelpqs();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var iclass = new ClCmsClass();
            GridView1.DataSource = iclass.Getcmshelpqs();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}