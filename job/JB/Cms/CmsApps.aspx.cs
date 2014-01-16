using System;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsAllApps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var capps = new ClCmsApplications();

            if (Request.QueryString["m"] == "Awaiting Interview")
            {
                Labelheaddetail.Text = "Awaiting Interview";
                GridView1.DataSource = capps.Cmsawaitingdapps();
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Selected Applications")
            {
                Labelheaddetail.Text = "Selected Applications";
                GridView1.DataSource = capps.Cmsselectedapps();
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Rejected Applications")
            {
                Labelheaddetail.Text = "Rejected Applications";
                GridView1.DataSource = capps.Cmsrejectedapps();
                GridView1.DataBind();
            }

            else
            {
                Labelheaddetail.Text = "All Applications";
                GridView1.DataSource = capps.Cmsallapps();
                GridView1.DataBind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            var capps = new ClCmsApplications();

            if (Request.QueryString["m"] == "Awaiting Interview")
            {
                Labelheaddetail.Text = "Awaiting Interview";
                GridView1.DataSource = capps.Cmsawaitingdapps();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Selected Applications")
            {
                Labelheaddetail.Text = "Selected Applications";
                GridView1.DataSource = capps.Cmsselectedapps();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Rejected Applications")
            {
                Labelheaddetail.Text = "Rejected Applications";
                GridView1.DataSource = capps.Cmsrejectedapps();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else
            {
                Labelheaddetail.Text = "All Applications";
                GridView1.DataSource = capps.Cmsallapps();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }
        }
    }
}