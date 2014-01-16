using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class RecApplication : ClCookie
    {
        protected string GetUrl(object idapp)
        {
            return "RecApplicationdetail.aspx?applyid=" + idapp;
        }

        protected string GetStatus(object statustext, object statusid, object appid)
        {
            return "JobApplicationActions.aspx?status=" + statustext + "&sid=" + statusid + "&appid=" + appid;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login

            Isuserloginvalid();

            if (Session["pusername"] != null)
            {
                //get employer id
                var mpg = new ClMainPagePopulator();
                var emid = mpg.Getrecname(Session["pusername"].ToString());

                var app = new ClApps();

                //bind to grid
                GridView1.DataSource = app.Getapplication(emid);
                GridView1.DataBind();
            }
        }

        protected void GridView1PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //get employer id
            var mpg = new ClMainPagePopulator();
            var emid = mpg.Getrecname(Session["pusername"].ToString());

            var apps = new ClApps();
            GridView1.DataSource = apps.Getapplication(emid);
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}