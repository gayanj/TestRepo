using System;
using System.Web;

namespace JB
{
    public partial class Logoff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            remove_cookie("fashionquadrant.com");
            Session.Abandon();

        }

        private void remove_cookie(string cookiename)
        {
            if (Request.Cookies[cookiename] != null)
            {
                var myCookie = new HttpCookie(cookiename) {Expires = DateTime.Now.AddDays(-1d)};
                Response.Cookies.Add(myCookie);
            }

        }
    }
}