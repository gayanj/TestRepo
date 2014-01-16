using System;

namespace JB.Cms
{
    public partial class CmsBranding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["type"]!=null)
            {
               
                    switch (Request.QueryString["type"])
                    {
                        case "wap":
                            Labelheaddetail.Text = "WAP Logo Branding";
                            break;
                        case "login":
                            Labelheaddetail.Text = "Recruiter/Jobseeker Login Branding";
                            break;
                        case "cmslogin":
                            Labelheaddetail.Text = "CMS Login Logo Branding";
                            break;
                        case "cmshome":
                            Labelheaddetail.Text = "CMS Home Logo Branding";
                            break;
                        case "topbar":
                            Labelheaddetail.Text = "Recruiter/Jobseeker Header Branding";
                            break;
                        default:
                            Labelheaddetail.Text = "Email Logo Branding";
                            break;
                    }
                
            }
        }
    }
}