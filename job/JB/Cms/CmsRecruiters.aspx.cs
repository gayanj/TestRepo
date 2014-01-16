using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsAllrecruiters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cm = new ClCmsClass();

            if (Request.QueryString["m"] == "Archived Recruiters")
            {
                Labelheaddetail.Text = "Archived Recruiters";
                GridView1.DataSource = cm.Getarchivedrec();
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Active Recruiters")
            {
                Labelheaddetail.Text = "Active Recruiters";
                GridView1.DataSource = cm.Getactiverec();
                GridView1.DataBind();
            }

            else
            {
                Labelheaddetail.Text = "All Recruiters";
                GridView1.DataSource = cm.Getallrec();
                GridView1.DataBind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var cm = new ClCmsClass();

            if (Request.QueryString["m"] == "Archived Recruiters")
            {
                Labelheaddetail.Text = "Archived Recruiters";
                GridView1.DataSource = cm.Getarchivedrec();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Active Recruiters")
            {
                Labelheaddetail.Text = "Active Recruiters";
                GridView1.DataSource = cm.Getactiverec();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else
            {
                Labelheaddetail.Text = "All Recruiters";
                GridView1.DataSource = cm.Getallrec();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }
        }
    }
}