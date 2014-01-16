using System;
using System.Globalization;
using Msftlayer;
using System.Configuration;
using minGuid;

namespace JB
{
    public partial class Resetpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //set buttons and text defaults
                TextBox1.Focus();
                Page.Form.DefaultButton = Button1.UniqueID;
            }
        }

        protected void Button2Click(object sender, EventArgs e)
        {
            Response.Redirect("/home");
        }


        private int RequestCheck()
        {
            if (TextBox1.Text == "")
            {
                LabelNotify.Text = "Email address is required!";
                return 1;
            }

            else if (TextBox1.Text.Contains("@") == false && TextBox1.Text.Contains(".") == false)
            {
                LabelNotify.Text = "Email address is not valid!";
                return 1;
            }

            else
            {
                return 0;
            }

        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var flg1 = false;

            var rq = RequestCheck();

            if (rq == 0)
            {
                //insert into the usertable random key
                //recalc password hash
                var clpdh = new ClPwdHash();
                var rnd = new Random();
                var _newhash = new Minimumguid();

                var hashedpwd = _newhash.MinGuid();

                //one goes to email as hashvalue.
                var cemp = new ClEmailProcessor();

                var ebody = string.Empty;

                //second inserts into the db.
                var clog = new ClLogins();

                switch (CheckBox1.Checked)
                {
                    case true:
                        if (TextBox1.Text == clog.Getseerecemail(TextBox1.Text))
                        {
                            flg1 = true;
                            clog.Updatereckey(TextBox1.Text, hashedpwd);

                            ebody = ConfigurationManager.AppSettings["httppaths"].ToString() + "/passwordchanging?keyid=" + hashedpwd + "&utype=" + 1;

                            string _Enc = "<div style=\"font-family: Helvetica, Verdana, sans-serif; padding: 10px 0px 0px 10px;\"><div style=\"width: 500px; background-color: #fff; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 50px; background-color: #000; display: inline-block; width: 500px; vertical-align: middle;\"><img alt=\"fashionquadrant\" src=\"" + ConfigurationManager.AppSettings["httppaths"].ToString() + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 12px; min-height:300px;\"><br/>Dear User,<br/><br/><br/>Pease click the link below to Reset your password: <br/><a style=\"color: #ccc; text-decoration: underline\" href=\"" + ebody + "\">Reset Password" + "</a><br /><br/>Sincerely,<br/><br/><b>Fashion Quadrant</b> <br/><br/><br/><br/><br/> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email. </div><div style=\"color: #ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; font-size: 11px;\">Copyrights 2013 Fashion Quadrant</b><br/>Please do not reply to this auto generated message.We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: underline\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>.If you need to contact us send us an email at:<a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to:<a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div>";

                            cemp.Sendmailproc(TextBox1.Text, "FashionQuadrant: Account Activation!", Server.HtmlDecode(_Enc), 6);
                            //cemp.Sendmailproc(TextBox1.Text, "Fashion Quadrant" , ebody, 2);

                            //logg it as the entry for email
                            //cemp.Insertappemaildb(TextBox1.Text, 6);
                        }
                        break;
                    default:
                        if (TextBox1.Text == clog.Getseeuseremail(TextBox1.Text))
                        {
                            flg1 = true;
                            clog.Updateuserkey(TextBox1.Text, hashedpwd);

                            ebody = ConfigurationManager.AppSettings["httppaths"].ToString() + "/passwordchanging?keyid=" + hashedpwd + "&utype=" + 2;

                            string _Enc = "<div style=\"padding: 10px 0px 0px 10px;\"><div style=\"width: 500px; background-color: #fff; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 50px; background-color: #000; display: inline-block; width: 500px; vertical-align: middle;\"><img alt=\"fashionquadrant\" src=\"" + ConfigurationManager.AppSettings["httppaths"].ToString() + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 12px; min-height:300px;\"><br/>Dear User,<br/><br/><br/>Please click the link below to reset your password: <br/><a style=\"color: #ccc; text-decoration: underline\" href=\"" + ebody + "\">Reset Password" + "</a><br /><br/>Sincerely,<br/><br/><b>Fashion Quadrant</b> <br/><br/><br/><br/><br/> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email. </div><div style=\"color: #ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; font-size: 11px;\">Copyrights 2013 Fashion Quadrant</b><br/>Please do not reply to this auto generated message.We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: underline\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>.If you need to contact us send us an email at:<a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to:<a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div>";

                            //cemp.Sendmailproc(TextBox1.Text, "Fashion Quadrant" , ebody, 2);
                            cemp.Sendmailproc(TextBox1.Text, "FashionQuadrant: Account Activation!", Server.HtmlDecode(_Enc), 7);
                            //logg it as the entry for email
                            //cemp.Insertappemaildb(TextBox1.Text, 7);
                        }
                        break;
                }

                ////endif///

                switch (flg1)
                {
                    case true:
                        Session["reasons"] = "Password Reset! <br /> Please check your email to complete the process. <br /> ";
                        Response.Redirect("/confirm");
                        break;
                    default:
                        LabelNotify.Text = "This email doesnot exist in our system!";
                        break;
                }
            }
        }
    }
}