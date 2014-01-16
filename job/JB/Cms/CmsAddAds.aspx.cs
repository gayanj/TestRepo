using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JB.Cms
{
    public partial class CmsAddAds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //enable disable image for ad types
                if (DropDownAddList.SelectedValue == "1" || DropDownAddList.SelectedValue == "2")
                {
                    PanelImg.Visible = true;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // save ads

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //cancel
            Response.Redirect("/cms/cmshome.aspx");
        }
    }
}