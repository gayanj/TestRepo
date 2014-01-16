using System;

namespace JB.Cms
{
    public partial class CmsConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ir"] != null)
            {
                LabelReason.Text = Session["ir"].ToString();
            }
        }
    }
}