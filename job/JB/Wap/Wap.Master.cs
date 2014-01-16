using System;
using System.Globalization;
using System.Web.UI.WebControls;
using Msftlayer;
using System.Web;

namespace JB.wap
{
    public partial class Wap : ClHtmlWrap
    {
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (HiddenField1.Value != "6e97555a3158609611292")
            {
                Response.Redirect("/fraudfilters/fraudaction.aspx");
            }

            //set site pref
            var clpref = new ClSiteprefs();
            var lit = new Literal { Text = clpref.Getsitepref().ToString(CultureInfo.InvariantCulture) };
            sitepref.Controls.Add(lit);
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/wap/home");
        }
    }
}