using System;
using Msftlayer;
using System.Web;
using Msftlayer.IpLookup;
using System.Configuration;
using minGuid;

namespace JB
{
    public class Global : System.Web.HttpApplication
    {
        private void HandleAnalytics()
        {
            string _hostname = ""; if (Request.UserHostName != null) { _hostname = Request.UserHostName; }
            string _hostaddr = ""; if (Request.UserHostAddress != null) { _hostaddr = Request.UserHostAddress; }
            string _hostagent = Request.UserAgent;
            string _EntryUrl = ""; if (Request.UrlReferrer != null) { _EntryUrl = Request.UrlReferrer.OriginalString; }
            string _VisitorIp = Request.ServerVariables["REMOTE_ADDR"].ToString();
            string _Country = "";
            string _City = "";

            if (ConfigurationManager.AppSettings["analytics"].ToString() == "1" && Request.UrlReferrer != null)
            {
                if (!Request.UrlReferrer.OriginalString.Contains("fashionquadrant"))
                {
                    try
                    {
                        var __ipfile = ConfigurationManager.AppSettings["geolocation"].ToString();
                        var ls = new LookupService(__ipfile, LookupService.GEOIP_STANDARD);
                        var l = ls.getLocation(_VisitorIp);

                        if (l.city != null)
                        {
                            _City = l.city;
                        }

                        if (l.countryCode != null)
                        {
                            _Country = l.countryCode;
                        }
                    }

                    catch (Exception Er)
                    {
                        //get page
                        var PageName = "";
                        ClExceptionHandler _c = new ClExceptionHandler();

                        if (Request.Url.PathAndQuery != null)
                        {
                            PageName = Request.Url.PathAndQuery;
                        }

                        _c.AddError(Er, PageName);
                    }

                    var _g = new Minimumguid();

                    var _m = new ClCmsAnalytics();
                    _m.InsertAnalytics(_g.MinGuid(), _VisitorIp, _City, _Country, _EntryUrl);
                }
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //handle analytics
            //HandleAnalytics();
        }

        //error logging
        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    // Get the exception object.
        //    Exception exc = Server.GetLastError();

        //    var PageName = "";

        //    if (Request.Url.PathAndQuery != null)
        //    {
        //        PageName = Request.Url.PathAndQuery;
        //    }

        //    // Clear the error from the server
        //    Server.ClearError();

        //    ClExceptionHandler _clh = new ClExceptionHandler();
        //    _clh.AddError(exc, PageName);

        //    //redirect
        //    Response.Redirect("/jberror.aspx");
        //}

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //user agent string
            var uagent = Request.UserAgent;

            if (uagent != null && (uagent.IndexOf("iPad", StringComparison.Ordinal) > -1 || uagent.IndexOf("iPhone", StringComparison.Ordinal) > -1 || uagent.IndexOf("Android", StringComparison.Ordinal) > -1 || uagent.IndexOf("BlackBerry", StringComparison.Ordinal) > -1 || uagent.IndexOf("Blazer", StringComparison.Ordinal) > -1 || uagent.IndexOf("BOLT", StringComparison.Ordinal) > -1 || uagent.IndexOf("MIDP", StringComparison.Ordinal) > -1 || uagent.IndexOf("IEMobile", StringComparison.Ordinal) > -1))
            {
                //Response.Redirect("fashionquadrant.com");
            }

            try
            {
                //fire memcache
                var icache = new ClCache();
                icache.firecache();
            }

            catch (Exception e1)
            {
                var PageName = "";

                if (Request.Url.PathAndQuery != null)
                {
                    PageName = Request.Url.PathAndQuery;
                }

                // Clear the error from the server
                Server.ClearError();

                ClExceptionHandler _clh = new ClExceptionHandler();
                _clh.AddError(e1, PageName);
            }


        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}