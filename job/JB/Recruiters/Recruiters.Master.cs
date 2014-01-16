using System;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JB.Properties;
using Msftlayer;

namespace JB.Recruiters
{
    public partial class Recruiters : ClHtmlWrap
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
                if (System.Configuration.ConfigurationManager.AppSettings["debuggermode"].ToString(CultureInfo.InvariantCulture) == "1")
                {
                    DebugPanel.Visible = true;
                }

                //set site pref
                var clpref = new ClSiteprefs();
                var lit = new Literal { Text = clpref.Getsitepref().ToString(CultureInfo.InvariantCulture) };
                sitepref.Controls.Add(lit);

                /* if (Session["isrecruiter"] != null)
                 {
                     if ((Boolean)Session["isrecruiter"] == true)
                     {
                     }

                     else { Response.Redirect("Login"); }
                 }
                 else { Response.Redirect("Login"); }
                 */

                #region PageStart

                //set branding
                var clbr = new ClBranding();
                Page.Title = clbr.Getbrandoption("recpagetitle");

                if (Session["pwelcomename"] != null)
                {
                    var clver = new ClVersionControl();
                    //set user name
                    Label1.Text = "User logged in: " + Session["pwelcomename"] + "Jobboard Version: X2";  //+ clver.Getcurrentversion();
                }

                #endregion PageStart
            }
        }

        protected void LinkButton3Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/ChangeRecPwd.aspx");
        }

        protected void LinkButton4Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/RecHome.aspx");
        }

        protected void LinkButton5Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/RecApplicationDetail.aspx?Applyid=100");
        }

        protected void LinkButton6Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/EditJobs.aspx");
        }

        protected void LinkButton7Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/JobForm.aspx");
        }

        protected void LinkButton8Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/RecApplication.aspx");
        }

        protected void LinkButton44Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void LinkButton10Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/RecBulkImport.aspx");
        }

        protected void LinkButton1Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/RecruiterAudit.aspx");
        }

        protected void LinkButton2Click1(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/RecCredits.aspx");
        }

        protected void LinkButton11Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/RecCvSearch.aspx");
        }

        protected void LinkButton12Click(object sender, EventArgs e)
        {
            Response.Redirect("/Logoff.aspx");
        }

        protected void ImageHelperBtnClick(object sender, ImageClickEventArgs e)
        {
            var clc = new ClSearchMain();
            Response.Redirect(_cpath + "/sitesearch?track=2&q=" + Server.HtmlEncode(TextBox1.Text));
        }
    }
}