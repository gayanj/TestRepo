using System;
using System.Globalization;
using System.Text;
using System.Web.UI;
using Msftlayer;
using System.Configuration;
using minGuid;

namespace JB.Jobseekers
{
    public partial class Signup : System.Web.UI.Page
    {
        private bool performchecks()
        {
            StringBuilder _sbr = new StringBuilder();

            bool flag = false;

            if (TextBox2.Text == "")
            {
                _sbr.Append("<b>First Name</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox3.Text == "")
            {
                _sbr.Append("<b>Last Name</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox11.Text == "")
            {
                _sbr.Append("<b>Email/Username</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox12.Text == "")
            {
                _sbr.Append("<b>Password</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox18.Text == "")
            {
                _sbr.Append("<b>Confirm Password!</b><br/>");
                flag = true;
            }

            else if (TextBox13.Text == "")
            {
                _sbr.Append("<b>Password hint</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox12.Text != TextBox18.Text)
            {
                _sbr.Append("Passwords do not match!<br/>");
                flag = true;
            }

            else if (TextBox11.Text.Contains("@") == false && TextBox11.Text.Contains(".") == false)
            {
                _sbr.Append("Invalid Email Address!<br/>");
                flag = true;
            }

            else { }

            var _outstring = _sbr.ToString().TrimEnd('<', 'b', 'r', '/', '>');

            LabelNotify.Text = _outstring;

            return flag;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsSecureConnection)
            {
                //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture) + "/Jobseekers/signup.aspx");
            }

            else
            {
                //set default inputs
                TextBox2.Focus();
                Page.Form.DefaultButton = Button2.UniqueID;
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            if (performchecks() == false)
            {
                if (CapText.Text == Session["capts"].ToString())
                {
                    var clog = new ClLogins();

                    if (clog.Getchkcanusern(TextBox11.Text) != TextBox11.Text)
                    {
                        //add users
                        var mpg = new ClMainPagePopulator();
                        var phash = new ClPwdHash();
                        var _newhash = new Minimumguid();

                        string mxuserid = mpg.Getmaxuserid();
                        string mxcandidateid = mpg.Getmaxcandidateid();

                        string hashpwd = phash.GetMd5Hash(TextBox12.Text);

                        //add activation id and send it in email
                        var rands1 = new Random();

                        //email hash
                        string makehashp = _newhash.MinGuid();

                        //get machine id
                        string servid = Environment.MachineName;

                        //add users
                        mpg.Insertusers(TextBox11.Text, TextBox2.Text, 1, TextBox3.Text, hashpwd, 2, mxuserid,
                                        TextBox13.Text, mxcandidateid, makehashp, servid);

                        //add candidates
                        mpg.Insertcandidates(mxcandidateid, TextBox2.Text + " " + TextBox3.Text, TextBox2.Text,
                                             TextBox3.Text, "", "", "", "", "", "", "", "", "", "",
                                             DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss"));

                        //send email.
                        var emproc = new ClEmailProcessor();

                        string eresponse = ConfigurationManager.AppSettings["httpspaths"].ToString() + "/ActivateAccount.aspx?activationid=" + makehashp +
                                           "&usertype=2&username=" + TextBox11.Text;

                        //make email body
                        string emailbod = emproc.Getemailactivateusr(eresponse, TextBox11.Text).ToString();

                        //finally send out the email
                        emproc.Sendmailproc(TextBox11.Text, "FashionQuadrant: Account Activation!", "<div style=\"width:500px\"><div style=\"-moz-box-shadow: 3px 3px 4px #ccc; -webkit-box-shadow: 3px 3px 4px #ccc; box-shadow: 3px 3px 4px #ccc;-ms-filter: \"progid:DXImageTransform.Microsoft.Shadow(Strength=4, Direction=135, Color=\"#cccccc\")\";filter: progid:DXImageTransform.Microsoft.Shadow(Strength=4,Direction=135,Color=\"#cccccc\"); font-family: Helvetica, Verdana, sans-serif; margin: 10px 0px 0px 10px;\"><div style=\"background-color: #000; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 48px; background-color: #000; display: inline-block; vertical-align: middle;\"><img alt=\"fashion quadrant\" src=\"" + ConfigurationManager.AppSettings["httppaths"].ToString() + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 14px; min-height:300px;\"><span style=\"font-size:20px;\">Dear " + TextBox2.Text + " " + TextBox3.Text + ",</span><br/><br/><br/>Thank you for registering with us, please click the link below to activate your account: <br/><a style=\"color: #ccc; text-decoration: underline\" href=\"" + eresponse + "\">Activate Account" + "</a><br /><br/>Sincerely,<br/><br/><b>Fashion Quadrant</b> <br/><br/><br/><br/><br/> <span style=\"line-height:12px;font-size:11px;\"> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email.</span> </div><div style=\"color:#ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; line-height:12px; font-size: 11px;\">Copyrights 2013 Fashion Quadrant</b><br/>Please do not reply to this auto generated message. We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: none;\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>. If you need to contact us send us an email at: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div></div>", 1);

                        //logg it as the entry for email
                        //emproc.Insertappemaildb(TextBox11.Text, 2);

                        //add default privacy controls
                        var cpvc = new ClPrivacy();
                        int polcount = cpvc.Getdefaultcanpol();

                        //add to privacy table
                        for (int apc = 1; apc <= polcount; apc++)
                        {
                            cpvc.Insertdefaultpriv(mxcandidateid, apc);
                        }

                        //autoactivate account
                        //activate the account

                        //const int usertype = 2;
                        string username = TextBox11.Text;
                        string activation = makehashp;

                        var cllog = new ClLogins();
                        //cllog.UpdateactivateAcc(usertype, username, activation);

                        //add note default value
                        var clns = new ClNotes();
                        clns.Insertanote(mxcandidateid, "");

                        //add default cv
                        var clapplication = new ClApps();
                        clapplication.Insertmyresumes("default", "default", mxcandidateid);

                        //push session
                        Session["reasons"] =
                            "Thank your for signing up, you are awsome! <br /> Please check your email to activate your account. <br /> ";

                        //redirect to confirmation page
                        Response.Redirect("/confirm.aspx");
                    }

                    else
                    {
                        LabelNotify.Text += "Username/Email already exists in our system!";
                    }
                }

                else
                {
                    LabelNotify.Text += "Enter Captcha as shown below!";
                }
            }
        }

        protected void Button3Click(object sender, EventArgs e)
        {
            Response.Redirect("/home");
        }

        protected void ReloadcaptchsClick(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/jobseeker/signup");
        }
    }
}