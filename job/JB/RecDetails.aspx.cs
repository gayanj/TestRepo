using System;
using System.Globalization;
using System.Web.UI;
using Msftlayer;

namespace JB
{
    public partial class Recdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + "/Recdetails.aspx");
            }

            if (!IsPostBack && Request.QueryString["Empid"] != null)
            {
                //bind dataset here
                var rcls = new ClRecruiters();
                var alist = rcls.Getcurrrecwithempid(Server.HtmlEncode(Request.QueryString["empid"]));
                RecImage.ImageUrl = alist[0].ToString();
                CompanyName.Text = alist[1].ToString();
                CompanyIntro.Text = alist[2].ToString();
                CompanyBusinessDetail.Text = alist[3].ToString();
                CompanyWebsite.Text = alist[4].ToString();
                CompanyEmail.Text = "-";
            }
        }

        protected void ImageButton1Click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("/FraudFilters/FraudAction.aspx");
        }
    }
}