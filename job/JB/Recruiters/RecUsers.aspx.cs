using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class RecUsers : ClCookie
    {
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
            //        Response.Redirect("Login");
            //    }
            //}

            //else
            //{
            //    Response.Redirect("Login");
            //}
            ////////////////////////////////////

            var rcl = new ClRecruiters();
            GridView1.DataSource = rcl.RecUsers(Session["pusername"].ToString());
            GridView1.DataBind();
        }

        protected void GridView1RowEditing(object sender, GridViewEditEventArgs e)
        {
            var rcl2 = new ClRecruiters();
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = rcl2.RecUsers(Session["pusername"].ToString());
            GridView1.DataBind();
        }
    }
}