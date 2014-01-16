using System;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Recruiteraudit : ClCookie
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //read and validate login
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

            Isuserloginvalid();

            // go for session

            if (Session["pusername"] != null)
            {
                var clarch = new ClArchive();
                GridView1.DataSource = clarch.Getacsecurityrec(Session["pusername"].ToString());
                GridView1.DataBind();
            }
        }
    }
}