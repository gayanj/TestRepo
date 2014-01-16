using System;
using System.Globalization;
using System.Net;
using System.Web;
using Msftlayer;

namespace JB.Cms
{
    public partial class Login : System.Web.UI.Page
    {
        readonly string _npath = System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture);

        //add cookie for users
        public void Setjobcookie(string cookiehash)
        {
            var aCookie = new HttpCookie("fashionquadrant.com") { Value = cookiehash, Expires = DateTime.Now.AddDays(1) };
            Response.Cookies.Add(aCookie);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set default inputs
            TextBox2.Focus();
            Page.Form.DefaultButton = Button2.UniqueID;

            //set error
            if (Request.QueryString["attempt"] != null)
            {
                LabelMessage.Text = "Username / Password not valid";
                LabelMessage.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var lg = new ClLogins();
            var chash = new ClPwdHash();

            if (lg.Getusercms(TextBox2.Text, TextBox3.Text) == TextBox2.Text)
            {
                Session["pusername"] = TextBox2.Text;
                Session["pwelcomename"] = lg.Getuserwelcomename(TextBox2.Text, 0, "0");

                var randomid = Guid.NewGuid().ToString();
                var addhash2 = chash.GetMd5Hash(randomid);
                Session["cuserval"] = addhash2;
                Setjobcookie(addhash2);

                //monitor this account as cms user
                Session["iscms"] = true;

                //add to log
                //var userdevice = Dns.GetHostEntry(Request.ServerVariables["REMOTE_HOST"]).HostName;
                //var userip = Request.ServerVariables["REMOTE_ADDR"].ToString(CultureInfo.InvariantCulture);

                //var clarch = new ClArchive();
                //clarch.Insertarchives(TextBox2.Text, DateTime.Now, 0, userdevice, userip);

                //manage session here
                Response.Redirect("/cms/cmshome.aspx");
            }

            else
            {
                if (Request.QueryString["attempt"] != null)
                {
                    switch (Request.QueryString["attempt"])
                    {
                        case "6":
                            //block account for 24 hrs.
                            break;
                        default:
                            {
                                int tempatt =
                                    Convert.ToInt16(Request.QueryString["attempt"].ToString(CultureInfo.InvariantCulture));
                                tempatt = tempatt + 1;
                                Response.Redirect("/cms/CmsLogin.aspx?attempt=" + tempatt.ToString(CultureInfo.InvariantCulture));
                            }
                            break;
                    }
                }

                else
                {
                    Response.Redirect("/cms/CmsLogin.aspx?attempt=1");
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect(_npath + "/Default.aspx");
        }
    }
}