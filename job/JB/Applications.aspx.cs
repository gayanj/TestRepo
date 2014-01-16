using System;

namespace JB
{
    public partial class Applications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["isrecruiter"] != null)
                {
                    if ((Boolean)Session["isrecruiter"] != true)
                    {
                    }

                    else
                    {
                        Session["reasons"] = "You cannot apply to a job as recruiter, please logout and then try applying!";
                        Response.Redirect("/confirm.aspx");
                    }
                }

                //set default inputs
                Page.Form.DefaultButton = Button3.UniqueID;
            }

            //check if candidate is logged in redirect to candidate applications
            if (Session["cuserval"] != null)
            {
                Response.Redirect("/jobseekers/candidateapplication?jobid=" + Request.QueryString["jobid"]);
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            Response.Redirect("/jobseekers/signup.aspx");
        }

        protected void Button3Click(object sender, EventArgs e)
        {
            if (Request.QueryString["jobid"] != null)
            {
                Response.Redirect("/jobseekers/cvupload?jobid=" + Request.QueryString["jobid"]);
            }
        }
    }
}