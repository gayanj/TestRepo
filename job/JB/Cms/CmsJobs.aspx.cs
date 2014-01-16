using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class CmsJobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cm = new ClCmsClass();

            if (Request.QueryString["m"] == "Active Jobs")
            {
                //active jobs
                Labelheaddetail.Text = "Active Jobs";
                GridView1.DataSource = cm.Getactivejobs();
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Archived Jobs")
            {
                //archived jobs
                Labelheaddetail.Text = "Archived Jobs";
                GridView1.DataSource = cm.Getarchivedjobs();
                GridView1.DataBind();
            }

            else
            {
                //all jobs
                Labelheaddetail.Text = "All Jobs";
                GridView1.DataSource = cm.Getalljobs();
                GridView1.DataBind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var cm = new ClCmsClass();

            if (Request.QueryString["m"] == "Active Jobs")
            {
                //active jobs
                Labelheaddetail.Text = "Active Jobs";
                GridView1.DataSource = cm.Getactivejobs();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else if (Request.QueryString["m"] == "Archived Jobs")
            {
                //archived jobs
                Labelheaddetail.Text = "Archived Jobs";
                GridView1.DataSource = cm.Getarchivedjobs();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }

            else
            {
                //all jobs
                Labelheaddetail.Text = "All Jobs";
                GridView1.DataSource = cm.Getalljobs();
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
            }
        }
    }
}