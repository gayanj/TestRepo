using System;
using System.Web.UI;

namespace JB.wap
{
    public partial class Reccheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (Request.QueryString["q"] != null)
            {
                Response.Redirect("searched.aspx?q=" + Server.HtmlEncode(Request.QueryString["q"]));
            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}