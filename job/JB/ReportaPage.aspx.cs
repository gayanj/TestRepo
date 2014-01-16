using System;
using System.Globalization;
using Msftlayer;

namespace JB
{
    public partial class Reportapage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/reportapage");
            }
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var spm = new ClSpamFilter();
            if (Request.UserAgent != null)
            {
                spm.Addspamrec(Convert.ToInt32(RadioButtonList1.SelectedItem.Value), spamreasons.Text,
                               Request.ServerVariables["REMOTE_ADDR"],
                               Request.UserAgent.ToString(CultureInfo.InvariantCulture),
                               Request.QueryString[0]);
                Session["reasons"] =
                    "Thank you for reporting this page, we cannot give individual feed back but we will look into this and may contact you if we require further information.";
                Response.Redirect("/confirm");
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            Response.Redirect("/home");
        }
    }
}