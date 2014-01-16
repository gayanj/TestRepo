using System;

namespace JB
{
    public partial class Jbpromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            Response.Redirect("/jobseekers/signup?promocode=MX102PS");
        }
    }
}