using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Msftlayer;

namespace JB.SubsiteWrapper
{
    public partial class Subsite : System.Web.UI.MasterPage
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
               
        }
    }
}