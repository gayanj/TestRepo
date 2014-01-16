using System;
using System.Web.UI;

namespace JB.wap
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultFocus = searchtext.UniqueID;
            Page.Form.DefaultButton = searchbutton.UniqueID;
        }

        protected void searchbutton_Click(object sender, EventArgs e)
        {
            if (searchtext.Text.Trim().Length > 1)
            {
                Response.Redirect("searched.aspx?q=" + searchtext.Text);
            }

            else
            {
                Response.Redirect("searched.aspx?q=ALL");
            }
        }

        protected void Browse1_Click(object sender, EventArgs e)
        {
            Response.Redirect("browse.aspx");
        }
    }
}