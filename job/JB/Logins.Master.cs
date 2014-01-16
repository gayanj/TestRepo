using System;
using System.Globalization;
using System.Web.UI.WebControls;
using JB.Properties;
using Msftlayer;
using System.Web;

namespace JB
{
    public partial class Logins1 : ClHtmlWrap
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

            //set debugger
            switch (System.Configuration.ConfigurationManager.AppSettings["debuggermode"].ToString(CultureInfo.InvariantCulture))
            {
                case "1":
                    DebugPanel.Visible = true;
                    break;
            }

            if (!IsPostBack)
            {
                //get microads
                var clads = new ClAdverts();
                var al = clads.Getmicrologinads();

                Label1.Text = al[0].ToString();
                Label2.Text = al[1].ToString();
                HyperLink1.Text = "Goto sponsor";
                HyperLink1.NavigateUrl = al[2].ToString();
                Label4.Text = al[3].ToString();
                Label5.Text = al[4].ToString();
                HyperLink2.Text = "Goto sponsor";
                HyperLink2.NavigateUrl = al[5].ToString();
                Label7.Text = al[6].ToString();
                Label8.Text = al[7].ToString();
                HyperLink3.Text = "Goto sponsor";
                HyperLink3.NavigateUrl = al[8].ToString();
                Label10.Text = al[9].ToString();
                Label11.Text = al[10].ToString();
                HyperLink4.Text = "Goto sponsor";
                HyperLink4.NavigateUrl = al[11].ToString();

                //set site pref
                var clpref = new ClSiteprefs();
                var lit = new Literal { Text = clpref.Getsitepref().ToString(CultureInfo.InvariantCulture) };
                sitepref.Controls.Add(lit);

                //generate a random number
                var rnd = new Random();
                var r1 = rnd.Next(1, 7);

                //get image path from db
                var backpath = clads.Getadvertstring(r1);

                //checkcode
                jbloginback.Attributes.CssStyle.Add("background-image", "url(.." + backpath + ")");
                jbloginback.Attributes.CssStyle.Add("background-color", "#333");
                jbloginback.Attributes.CssStyle.Add("background-repeat", "no-repeat");
                jbloginback.Attributes.CssStyle.Add("background-position", "center center");
                jbloginback.Attributes.CssStyle.Add("position", "fixed");
                jbloginback.Attributes.CssStyle.Add("width", "100%");
                jbloginback.Attributes.CssStyle.Add("height", "100%");
                jbloginback.Attributes.CssStyle.Add("min-width", "500px");
            }
        }
    }
}