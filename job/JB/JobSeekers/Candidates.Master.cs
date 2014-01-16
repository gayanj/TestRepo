using System;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JB.Properties;
using Msftlayer;

namespace JB.Jobseekers
{
    public partial class Candidates : ClHtmlWrap
    {
        readonly string _cpath = System.Configuration.ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture);

        //protected void Page_Error(object sender, EventArgs e)
        //{
        //    // Get the exception object.
        //    Exception exc = Server.GetLastError();

        //    var PageName = "";

        //    if (Request.Url.PathAndQuery != null)
        //    {
        //        PageName = Request.Url.PathAndQuery;
        //    }

        //    ClExceptionHandler _clh = new ClExceptionHandler();
        //    _clh.AddError(exc, PageName);

        //    // Clear the error from the server
        //    Server.ClearError();

        //    //redirect
        //    Server.Transfer("/jberror.aspx");
        //}

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture));
            }

            else
            {
                //set debugger
                switch (System.Configuration.ConfigurationManager.AppSettings["debuggermode"].ToString(CultureInfo.InvariantCulture))
                {
                    case "1":
                        DebugPanel.Visible = true;
                        break;
                }

                //set site pref
                var clpref = new ClSiteprefs();
                var lit = new Literal { Text = clpref.Getsitepref().ToString(CultureInfo.InvariantCulture) };
                sitepref.Controls.Add(lit);

                //if (Session["isjobseeker"] != null)
                //{
                //    switch ((Boolean)Session["isjobseeker"])
                //    {
                //        case true:
                //            break;
                //        default:
                //            Response.Redirect("/Login");
                //            break;
                //    }
                //}

                //else { Response.Redirect("/Login"); }

                //set branding
                var clbr = new ClBranding();
                Page.Title = clbr.Getbrandoption("jobseekertitle");

                //set the welcoming label for the candidates
                if (Session["cuserval"] != null)
                {
                    var cver = new ClVersionControl();
                    Label1.Text = "UserName:" + Session["cuserval"] + "Jobboard Version: X2"; //cver.Getcurrentversion();
                }

            }
        }

        protected void LinkButton1Click(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/userdetails");
        }

        protected void LinkButton2Click(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/changepassword");
        }

        protected void LinkButton3Click(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/myapplications");
        }

        protected void LinkButton4Click(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/home");
        }

        protected void LinkButton44Click(object sender, EventArgs e)
        {
            Response.Redirect("/home");
        }

        protected void LinkButton45Click(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/privacy");
        }

        protected void LinkButton4Click1(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/notes");
        }

        protected void LinkButton46Click(object sender, EventArgs e)
        {
            Response.Redirect("/logoff");
        }

        protected void LinkButton6Click(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/audit");
        }

        protected void LinkButton7Click1(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/savedsearches");
        }

        protected void LinkButton8Click1(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/savedjobs");
        }

        protected void ImageHelperBtnClick(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(_cpath + "/sitesearch?track=2&q=" + Server.HtmlEncode(TextBox1.Text));
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/jobseekers/ResumeBuilder/default.aspx");
        }
    }
}