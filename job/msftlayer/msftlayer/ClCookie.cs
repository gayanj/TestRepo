using System.Globalization;
using System.Web;

namespace Msftlayer
{
    public class ClCookie : System.Web.UI.Page
    {
        //login validator
        //read and validate login
        public void Isuserloginvalid()
        {
            string __cook = null;

            if (Request.Cookies["zone24x7.com"] != null)
            {
                HttpCookie aCookie = Request.Cookies["zone24x7.com"];
                __cook = Server.HtmlEncode(aCookie.Value);
            }

            if (Session["cuserval"] != null)
            {
                if (Session["cuserval"].ToString() == __cook)
                {
                }
                else
                {
                    Response.Redirect("/recruiters/login.aspx");
                }
            }

            else
            {
                Response.Redirect("/recruiters/login.aspx");
            }
        }

        //read cookie
        /*public string Readjobcookie()
        {
            //Grab the cookie
            HttpCookie cookie = Request.Cookies["fashionquadrant.com"];

            //Check to make sure the cookie exists
            if (cookie == null)
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
         */
    }
}