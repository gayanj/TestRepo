using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using Msftlayer;

namespace JB.Cms
{
    public partial class Cms : System.Web.UI.MasterPage
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

        //set themings via cookies
        private string GetThemeCookie()
        {
            //Grab the cookie
            HttpCookie cookie = Request.Cookies["fskin"];

            //Check to make sure the cookie exists
            if (null == cookie)
            {
                return null;
            }

            else
            {
                //Write the cookie value
                var strCookieValue = cookie.Value.ToString(CultureInfo.InvariantCulture);
                return strCookieValue;
            }
        }

        public void SetThemeCookie(string cookiehash)
        {
            //Create a new cookie, passing the name into the constructor
            HttpCookie cookie = new HttpCookie("fskin");

            //Set the cookies value
            cookie.Value = cookiehash;

            cookie.Expires = DateTime.Now.AddMonths(2);

            //Add the cookie
            Response.Cookies.Add(cookie);
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

        private string ReadJobCookie()
        {
            //Grab the cookie
            HttpCookie cookie = Request.Cookies["fashionquadrant.com"];

            //Check to make sure the cookie exists
            if (null == cookie)
            {
                return null;
            }

            else
            {
                //Write the cookie value
                var strCookieValue = cookie.Value.ToString(CultureInfo.InvariantCulture);
                return strCookieValue;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set page titles
            var clpref = new ClSiteprefs();
            var lite = new Literal { Text = clpref.Getsitepref().ToString(CultureInfo.InvariantCulture) };
            sitepref.Controls.Add(lite);

            //get theming
            var lit = new Literal();

            if (GetThemeCookie() != null)
            {
                if (GetThemeCookie() == "red")
                {
                    lit.Text = "<link href=\"/styles/CmsThemes/Red.css\" rel=\"stylesheet\" type=\"text/css\" />";
                }

                else if (GetThemeCookie() == "blue")
                {
                    lit.Text = "<link href=\"/styles/CmsThemes/Blue.css\" rel=\"stylesheet\" type=\"text/css\" />";
                }

                else if (GetThemeCookie() == "orange")
                {
                    lit.Text = "<link href=\"/styles/CmsThemes/Orange.css\" rel=\"stylesheet\" type=\"text/css\" />";
                }

                else if (GetThemeCookie() == "azure")
                {
                    lit.Text = "<link href=\"/styles/CmsThemes/Azure.css\" rel=\"stylesheet\" type=\"text/css\" />";
                }

                else if (GetThemeCookie() == "silver")
                {
                    lit.Text = "<link href=\"/styles/CmsThemes/Silver.css\" rel=\"stylesheet\" type=\"text/css\" />";
                }

                else
                {
                    lit.Text = "<link href=\"/styles/CmsThemes/Green.css\" rel=\"stylesheet\" type=\"text/css\" />";
                }
            }

            else
            {
                lit.Text = "<link href=\"/styles/CmsThemes/Blue.css\" rel=\"stylesheet\" type=\"text/css\" />";
            }

            ThemeHolder.Controls.Add(lit);

            //read and validate login
            if (Session["cuserval"] != null)
            {
                if (Session["cuserval"].ToString() == ReadJobCookie())
                {
                }
                else
                {
                    Response.Redirect("/cms/CmsLogin.aspx");
                }
            }

            else
            {
                Response.Redirect("/cms/CmsLogin.aspx");
            }

            //postback handle

            if (!IsPostBack)
            {
                if (Session["pwelcomename"] != null)
                {
                    Label1.Text = "Logged in as " + Session["pwelcomename"] + " on " + DateTime.Now.ToLongDateString() + " at " + DateTime.Now.ToShortTimeString();
                }

                if (Request.QueryString["m"] != null)
                {

                    foreach (TreeNode tn in CmsMenuTree.Nodes)
                    {
                        if (tn.Value == Request.QueryString["m"])
                        {
                            tn.Selected = true;
                            break;
                        }

                        for (var ia = 0; ia < tn.ChildNodes.Count; ia++)
                        {
                            if (tn.ChildNodes[ia].Value == Request.QueryString["m"])
                            {
                                tn.ChildNodes[ia].Selected = true;
                                tn.Expanded = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        protected void ThemeRed_Click(object sender, EventArgs e)
        {
            SetThemeCookie("red");
            Response.Redirect("/cms/CmsHome.aspx");
        }

        protected void ThemeBlue_Click(object sender, EventArgs e)
        {
            SetThemeCookie("blue");
            Response.Redirect("/cms/CmsHome.aspx");
        }

        protected void ThemeGreen_Click(object sender, EventArgs e)
        {
            SetThemeCookie("green");
            Response.Redirect("/cms/CmsHome.aspx");
        }

        protected void ThemeOrange_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            SetThemeCookie("orange");
            Response.Redirect("/cms/CmsHome.aspx");
        }

        protected void ThemeAzure_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            SetThemeCookie("azure");
            Response.Redirect("/cms/CmsHome.aspx");
        }

        protected void ThemeSilver_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            SetThemeCookie("silver");
            Response.Redirect("/cms/CmsHome.aspx");
        }
    }
}