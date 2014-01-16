using System;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Web;
using System.Web.UI;
using Msftlayer;
using minGuid;

namespace JB.Recruiters
{
    public partial class Login : Page
    {
        readonly string _cpath = ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture);
        readonly string _npath = ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture);

        //add cookie for users
        private void Setjobcookie(string ahash2)
        {
            var aCookie = new HttpCookie("zone24x7.com") { Value = ahash2, Expires = DateTime.Now.AddDays(1) };
            Response.Cookies.Add(aCookie);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //set default inputs
                TextBox2.Focus();
                Page.Form.DefaultButton = Button2.UniqueID;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
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

            else if (lg.Getuser(TextBox2.Text, TextBox3.Text) == TextBox2.Text)
            {
                //payments module
                var enablepayee = ConfigurationManager.AppSettings["enablepayments"];

                switch (enablepayee)
                {
                    case "1":
                        {
                            //check credits
                            var clcre = new ClCredits();
                            string creempid = clcre.Getrccreditempid(TextBox2.Text);
                            int crestatus = clcre.Getcreditjobposting(creempid);

                            switch (crestatus)
                            {
                                case 0:
                                    //enable for live payments.
                                    //Session["xactkey"] = Guid.NewGuid().ToString();
                                    //Response.Redirect("/payments/paymentstart?empid=" + creempid);
                                    break;
                            }
                        }
                        break;
                }

                Session["pusername"] = TextBox2.Text;
                Session["pwelcomename"] = lg.Getuserwelcomename(TextBox2.Text, 1, "0");

                var gui = new Minimumguid();
                var randomid = gui.MinGuid();

                //monitor this account as recruiter
                Session["isrecruiter"] = true;

                //add to log
                var userdevice = string.Empty;
                var userip = string.Empty;

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
                clarch.Insertarchives(TextBox2.Text, DateTime.Now, 1, userdevice, userip);

                Session["cuserval"] = randomid;
                Setjobcookie(randomid);

                //manage session here
                Response.Redirect("/Recruiters/RecHome.aspx");
            }

            else
            {
                LabelNotify.Text = "Invalid Email/Username or password!";
                //Label1.Visible = true;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(" /Default.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ResetPassword.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Recruiters/SignUp.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}