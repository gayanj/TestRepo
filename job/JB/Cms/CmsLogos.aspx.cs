using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JB.Cms
{
    public partial class CmsLogos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * 1- Cms home Logo
             * 2- Cms login Logo
             * 3- WAP Logo
             * 4- General login logo
             * 5- Email Logo
             * 6- Cpanel Logo
            */

            if (Request.QueryString["type"] == "1")
            {
                Labelheaddetail.Text = "Cms Home Logo";
                CurrLogoImage.ImageUrl = "/brandimages/brand_cmslogo.png";
            }

            else if (Request.QueryString["type"] == "2")
            {
                Labelheaddetail.Text = "Cms Login Logo";
                CurrLogoImage.ImageUrl = "/brandimages/brand_cmslogin.png";
            }

            else if (Request.QueryString["type"] == "3")
            {
                Labelheaddetail.Text = "WAP Logo";
                CurrLogoImage.ImageUrl = "/brandimages/brand_wap.png";
            }

            else if (Request.QueryString["type"] == "4")
            {
                Labelheaddetail.Text = "General Login Logo";
                CurrLogoImage.ImageUrl = "/brandimages/brand_login.png";
            }

            else if (Request.QueryString["type"] == "5")
            {
                Labelheaddetail.Text = "Email Logo";
                CurrLogoImage.ImageUrl = "/brandimages/brand_mail.png";
            }

            else
            {
                Labelheaddetail.Text = "Control Panel Logo";
                CurrLogoImage.ImageUrl = "/brandimages/brand_cpaneltop.png";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //cancel

            Response.Redirect("/cms/cmshome.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //update
        }
    }
}