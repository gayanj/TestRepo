using System;
using Msftlayer;

namespace JB.Helpcenter
{
    public partial class Answer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["qid"] != null)
                {
                    var chelp = new ClHelpCenter();
                    var tmparr = chelp.Gethelpanswer(Convert.ToInt32(Server.HtmlEncode(Request.QueryString["qid"])));

                    Labelqs.Text = tmparr[0];
                    Labelans.Text = tmparr[1];
                }
            }
        }

        protected void ButtonyesClick(object sender, EventArgs e)
        {
            Response.Redirect("~/default.aspx");
        }

        protected void Buttonh3Click(object sender, EventArgs e)
        {
            Response.Redirect("~/contact.aspx");
        }

        protected void Button4Click(object sender, EventArgs e)
        {
            Response.Redirect("main.aspx");
        }
    }
}