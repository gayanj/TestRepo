using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class Cmsallusers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cm = new ClCmsClass();

            if (Request.QueryString["m"] == "Jobseeker Users")
            {
                Labelheaddetail.Text = "Job Seeker";
                GridView1.DataSource = cm.Getcmsusers(2);
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Recruiter Users")
            {
                Labelheaddetail.Text = "Recruiters";
                GridView1.DataSource = cm.Getcmsusers(1);
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Admin Users")
            {
                Labelheaddetail.Text = "Admin Users";
                GridView1.DataSource = cm.Getcmsusers(0);
                GridView1.DataBind();
            }

            else
            {
                Labelheaddetail.Text = "All Users";
                GridView1.DataSource = cm.Getcmsusers();
                GridView1.DataBind();
            }

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var cm = new ClCmsClass();

            if (Request.QueryString["m"] == "Jobseeker Users")
            {
                Labelheaddetail.Text = "Job Seekers";
                GridView1.DataSource = cm.Getcmsusers(2);
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Recruiter Users")
            {
                Labelheaddetail.Text = "Recruiters";
                GridView1.DataSource = cm.Getcmsusers(1);
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Admin Users")
            {
                Labelheaddetail.Text = "Admin Users";
                GridView1.DataSource = cm.Getcmsusers(0);
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else
            {
                Labelheaddetail.Text = "All Users";
                GridView1.DataSource = cm.Getcmsusers();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }
        }
    }
}