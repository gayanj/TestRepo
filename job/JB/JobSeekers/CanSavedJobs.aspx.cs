using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Cansavedjobs : ClCookie
    {
        public string Myjob(object job)
        {
            string tmpstr = job.ToString();
            if (tmpstr.Length > 30)
            {
                return tmpstr.Substring(0, 30) + "...";
            }

            else
            {
                return tmpstr;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ////read and validate login
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

            //get savedjobs
            var clh = new ClHistory();
            string tempiduser = Session["canloginid"].ToString();
            searchjoblist.DataSource = clh.Getsavedjobs(tempiduser);
            searchjoblist.DataBind();
        }

        protected void SearchjoblistPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (Session["canloginid"] != null)
            {
                //get savedjobs
                var clh = new ClHistory();
                string tempiduser = Session["canloginid"].ToString();
                searchjoblist.DataSource = clh.Getsavedjobs(tempiduser);
                searchjoblist.PageIndex = e.NewPageIndex;
                searchjoblist.DataBind();
            }
        }
    }
}