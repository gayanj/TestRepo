using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Myapplications : ClCookie
    {
        //read cookie

        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login

            Isuserloginvalid();

            //if (Session["cuserval"] != null)
            //{
            //    if (Session["cuserval"].ToString() == Readjobcookie())
            //    {
            //    }
            //    else
            //    {
            //        Response.Redirect("login.aspx");
            //    }
            //}

            //else
            //{
            //    Response.Redirect("login.aspx");
            //}
            ////////////////////////////////////

            //bind grid
            var cmpg = new ClMainPagePopulator();
            GridView1.DataSource = cmpg.Getmyapps(Session["pusername"].ToString());
            GridView1.DataBind();
        }

        protected void GridView1PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //rebind grid
            var clmp = new ClMainPagePopulator();
            GridView1.DataSource = clmp.Getmyapps(Session["pusername"].ToString());
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}