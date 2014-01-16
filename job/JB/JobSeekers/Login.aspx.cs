using System;
using System.Globalization;
using System.Net;
using System.Web;
using System.Web.UI;
using Msftlayer;
using minGuid;

namespace JB.Jobseekers
{
    public partial class Login : Page
    {
        readonly string _cpath = System.Configuration.ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture);
        readonly string _npath = System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture);

        //add cookie for users
        //add cookie for users
        private void Setjobcookie(string ahash2)
        {
            var aCookie = new HttpCookie("fashionquadrant.com") { Value = ahash2, Expires = DateTime.Now.AddDays(1) };
            Response.Cookies.Add(aCookie);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //set default inputs
            Page.Form.DefaultFocus = TextBox2.UniqueID;
            Page.Form.DefaultButton = Button2.UniqueID;
        }

        protected void ImageButton1Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(_npath + "/Default.aspx");
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            var lg = new ClLogins();
            var chash = new ClPwdHash();

            if (TextBox2.Text == "")
            {
                LabelNotify.Text = "Email Address is required";
            }

            else if (TextBox3.Text == "")
            {
                LabelNotify.Text = "Password is required";
            }

            else if (TextBox2.Text.Contains("@") == false && TextBox2.Text.Contains(".") == false)
            {
                LabelNotify.Text = "Not a valid Email!";
            }

            else if (lg.Getjobuser(Server.HtmlEncode(TextBox2.Text), Server.HtmlEncode(TextBox3.Text)) == Server.HtmlEncode(TextBox2.Text))
            {
                Session["pusername"] = Server.HtmlEncode(TextBox2.Text);
                Session["pwelcomename"] = lg.Getuserwelcomename(Server.HtmlEncode(TextBox2.Text), 2);

                var gui = new Minimumguid();

                var randomid = gui.MinGuid();

                //make sure this is a candidate
                Session["isjobseeker"] = true;
                Session["canloginid"] = lg.Getuserid(Server.HtmlEncode(TextBox2.Text));

                //add to log
                var userdevice = "";
                var userip = "";

                ClExceptionHandler _c = new ClExceptionHandler();

                try
                {
                    userdevice = Request.UserHostName; //Dns.GetHostEntry(Request.ServerVariables["REMOTE_HOST"]).HostName;
                }
                catch (Exception exc1)
                {
                    //get page
                    var PageName = "";

                    if (Request.Url.PathAndQuery != null)
                    {
                        PageName = Request.Url.PathAndQuery;
                    }

                    _c.AddError(exc1, PageName);
                }

                try
                {
                    userip = Request.ServerVariables["REMOTE_ADDR"].ToString();
                }
                catch (Exception exc2)
                {
                    //handle it.
                    var PageName = "";

                    if (Request.Url.PathAndQuery != null)
                    {
                        PageName = Request.Url.PathAndQuery;
                    }

                    _c.AddError(exc2, PageName);
                }

                var clarch = new ClArchive();
                clarch.Insertarchives(Server.HtmlEncode(TextBox2.Text), DateTime.Now, 2, userdevice, userip);

                Session["cuserval"] = randomid;
                Setjobcookie(randomid);

                Response.Redirect("/jobseekers/home");
            }

            else
            {
                LabelNotify.Text = "Invalid Email/Username or password!";
                //Label1.Visible = true;
            }
        }

        protected void LinkButton1Click(object sender, EventArgs e)
        {
            Response.Redirect(_npath + "/resetpassword");
        }

        protected void LinkButton2Click(object sender, EventArgs e)
        {
            Response.Redirect(_cpath + "/Jobseekers/signup.aspx");
        }

        protected void Button3Click(object sender, EventArgs e)
        {
            Response.Redirect(_npath + "/Default.aspx");
        }
    }
}