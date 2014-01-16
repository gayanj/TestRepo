using System;

namespace JB.Jobseekers
{
    public partial class Canconfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            textreason.Text = Session["reasons"].ToString();
        }
    }
}