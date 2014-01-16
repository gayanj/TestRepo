using System;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Jobsearches : ClCookie
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
            //        Response.Redirect("login.aspx");
            //    }
            //}

            //else
            //{
            //    Response.Redirect("login.aspx");
            //}

            ////////////////////////////////////
            //get candidate searches
            ////////////////////////////////////

            var clh = new ClHistory();
            if (Session["canloginid"] != null)
            {
                string tempuid = Session["canloginid"].ToString();
                searchlist.DataSource = clh.Getsavedsearch(tempuid);
                searchlist.DataBind();
            }
        }

        protected string LoadSearch(object sid, object qry)
        {
            Session["ssr"] = qry;
            return "/searched.aspx?csc=" + sid;
        }

        protected void SearchlistPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var clh = new ClHistory();
            if (Session["canloginid"] != null)
            {
                string tempuid = Session["canloginid"].ToString();
                searchlist.DataSource = clh.Getsavedsearch(tempuid);
                searchlist.PageIndex = e.NewPageIndex;
                searchlist.DataBind();
            }
        }
    }
}