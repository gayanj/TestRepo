using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web.UI;
using Msftlayer;
using minGuid;
using System.Configuration;

namespace JB.Recruiters
{
    public partial class Signup : System.Web.UI.Page
    {
        private bool performchecks()
        {
            var _sbr = new StringBuilder();
            var vpass = new ClPwdHash();

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

            else if (TextBox4.Text == "")
            {
                _sbr.Append("<b>Address1</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox5.Text == "")
            {
                _sbr.Clear();
                _sbr.Append("<b>Address2</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox6.Text == "")
            {
                _sbr.Append("<b>Address3</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox7.Text == "")
            {
                _sbr.Append("<b>Town</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox8.Text == "")
            {
                _sbr.Clear();
                _sbr.Append("<b>County</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox9.Text == "")
            {
                _sbr.Append("<b>Postcode</b> is required!<br/>");
                flag = true;
            }

            //company name
            else if (TextBox10.Text == "")
            {
                _sbr.Append("<b>Company Name</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox15.Text == "")
            {
                _sbr.Clear();
                _sbr.Append("<b>Company Website</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox16.Text == "")
            {
                _sbr.Append("<b>Company intro</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox14.Text == "")
            {
                _sbr.Append("<b>Company description</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox11.Text == "")
            {
                _sbr.Append("<b>Email Address</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox12.Text == "")
            {
                _sbr.Clear();
                _sbr.Append("<b>Password</b> is required!<br/>");
                flag = true;
            }

            else if (TextBox17.Text == "")
            {
                _sbr.Append("Confirm password!<br/>");
                flag = true;
            }

            else if (TextBox13.Text == "")
            {
                _sbr.Append("<b>Password hint</b> is required!<br/>");
                flag = true;
            }

            //passwords

            else if (TextBox12.Text != TextBox17.Text)
            {
                _sbr.Append("Passwords do not match!<br/>");
                flag = true;
            }

            else if (TextBox11.Text.Contains("@") == false && TextBox11.Text.Contains(".") == false)
            {
                _sbr.Append("Invalid Email Address!<br/>");
                flag = true;
            }

            else if (vpass.Validatepassword(TextBox12.Text) == true && vpass.Validatepassword(TextBox17.Text) == true)
            {
                _sbr.Append("Password should only use Alphanumeric characters and symbols like @,#,$,! !<br/>");
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
                //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["httpspaths"].ToString(CultureInfo.InvariantCulture) + "/recruiters/signup.aspx");
            }

            else
            {
                //set default inputs
                TextBox2.Focus();
                Page.Form.DefaultButton = Button2.UniqueID;

                if (Session["pusername"] != null)
                {
                    //CLMainpagepopulator mpage = new CLMainpagepopulator();

                    //int recsid = mpage.getrecname(Session["pusername"].ToString());

                    // featured recurites
                    //ClFeaturedrecruiters frs = new ClFeaturedrecruiters();

                    //get recruters image
                    //Image8.Visible = true;
                    //Image8.ImageUrl = frs.getrecformimage(recsid);
                    Session["reasons"] = "Please logout first!";
                    Response.Redirect("/recruiters/confirmation");
                }

            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            if (performchecks() == false)
            {

                //check if the current user exists in the database
                var lgeins = new ClLogins();

                if (CapText.Text == Session["capts"].ToString())
                {
                    //check if company exists
                    var clrec = new ClRecruiters();
                    if (clrec.Getrecid(TextBox10.Text) == string.Empty)
                    {
                        #region add rec

                        //add a recruiter
                        if (lgeins.Getchkrecusern(TextBox11.Text) != TextBox11.Text)
                        {
                            //insert
                            var mps = new ClMainPagePopulator();
                            var pwds = new ClPwdHash();
                            var arc = new ClArtifacts();

                            var mguid = new Minimumguid();

                            var getmaxrec = mguid.MinGuid();
                            var getmaxrecartifacts = mguid.MinGuid();
                            var getmaxrecuserid = mguid.MinGuid();

                            var shahsp = mguid.MinGuid();

                            //set email body
                            var emaps = new ClEmailProcessor();

                            string eresponse = "/ActivateAccount.aspx?activationid=" + shahsp + "&usertype=1&username=" + TextBox11.Text;

                            //recruiters
                            mps.Insertrecruiters(getmaxrec, TextBox10.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text,
                                                 TextBox7.Text, TextBox8.Text, "GB", TextBox9.Text, TextBox11.Text,
                                                 TextBox15.Text, TextBox16.Text, TextBox14.Text,
                                                 DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss"), 1, getmaxrecartifacts);

                            //get machine id
                            var servid = Environment.MachineName;

                            //users and pwds
                            var md5H = pwds.GetMd5Hash(TextBox12.Text);
                            mps.Insertusers(TextBox11.Text, TextBox2.Text, 1, TextBox3.Text, md5H, 1, getmaxrecuserid,
                                            "hint", "-1", shahsp, servid);

                            var holdlogo = string.Empty;

                            //employee logo
                            if (FileUpload1.HasFile)
                            {
                                holdlogo =
                                    Path.GetFileName(FileUpload1.PostedFile.FileName.ToString(CultureInfo.InvariantCulture));
                                arc.Insertartifacts(getmaxrecartifacts, holdlogo, "/artifacts/" + getmaxrecartifacts + holdlogo);

                                //real upload
                                FileUpload1.PostedFile.SaveAs(Server.MapPath("/artifacts/") + getmaxrecartifacts + holdlogo);

                            }

                            else
                            {
                                holdlogo = "nopic.gif";
                                //Path.GetFileName(FileUpload1.PostedFile.FileName.ToString(CultureInfo.InvariantCulture));
                                arc.Insertartifacts(getmaxrecartifacts, holdlogo, "/images/" + holdlogo);
                            }
                            //check paths
                            //string trailingPath = Path.GetFileName(System.Configuration.ConfigurationManager.AppSettings["filepth"].ToString() + getmaxrecartifacts + holdlogo);
                            //string fullPath = Path.Combine(Server.MapPath(" "), trailingPath);

                            //user recruiter assignments
                            mps.Insertrecusermapping(getmaxrecuserid, getmaxrec);

                            //finally send out the email
                            //emaps.Sendmailproc(TextBox11.Text, "Fashion Quadrant:Account Activation!", ebod1, 4);
                            emaps.Sendmailproc(TextBox11.Text, "Zone24x7: Account Activation!", "<div style=\"width:500px\"><div style=\"-moz-box-shadow: 3px 3px 4px #ccc; -webkit-box-shadow: 3px 3px 4px #ccc; box-shadow: 3px 3px 4px #ccc;-ms-filter: \"progid:DXImageTransform.Microsoft.Shadow(Strength=4, Direction=135, Color=\"#cccccc\")\";filter: progid:DXImageTransform.Microsoft.Shadow(Strength=4,Direction=135,Color=\"#cccccc\"); font-family: Helvetica, Verdana, sans-serif; margin: 10px 0px 0px 10px;\"><div style=\"background-color: #000; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 48px; background-color: #000; display: inline-block; vertical-align: middle;\"><img alt=\"fashion quadrant\" src=\"" + "j_gayan12@yahoo.com" + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 14px; min-height:300px;\"><span style=\"font-size:20px;\">Dear " + TextBox2.Text + " " + TextBox3.Text + ",</span><br/><br/><br/>Thank you for registering with us, please click the link below to activate your account: <br/><a style=\"color: #ccc; text-decoration: underline\" href=\"" + eresponse + "\">Activate Account" + "</a><br /><br/>Sincerely,<br/><br/><b>Fashion Quadrant</b> <br/><br/><br/><br/><br/> <span style=\"line-height:12px;font-size:11px;\"> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email.</span> </div><div style=\"color:#ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; line-height:12px; font-size: 11px;\">Copyrights 2013 Fashion Quadrant</b><br/>Please do not reply to this auto generated message. We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: none;\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>. If you need to contact us send us an email at: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div></div>", 2);

                            //logg it as the entry for email
                            //emaps.Insertappemaildb(TextBox11.Text, 2);

                            //redirect to check mail
                            Session["reasons"] =
                                "Thank you for registering, Please check your email to activate your account!!!";
                            Session["rx"] = 1;
                            Response.Redirect("/Confirm.aspx");
                        }

                        else
                        {
                            //recruiter user already exists
                            LabelNotify.Text = "User already exists!";
                        }

                        #endregion add rec
                    }
                    else
                    {
                        LabelNotify.Text = "Company already exists!";
                    }
                }

                else
                {
                    LabelNotify.Text = "please retype the Text as shown in Captcha!";
                }
            }
        }

        protected void Button3Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void ReloadcaptchsClick(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}