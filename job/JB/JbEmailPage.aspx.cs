using System;
using System.Globalization;
using Msftlayer;
using System.Configuration;

namespace JB
{
    public partial class Jbemailpage : System.Web.UI.Page
    {

        private int RequestCheck()
        {
            if (fromaddress.Text == "")
            {
                LabelNotify.Text = "Your email address is required!";
                return 1;
            }

            else if (fromaddress.Text.Contains("@") == false && fromaddress.Text.Contains(".") == false)
            {
                LabelNotify.Text = "Your email address is invalid!";
                return 1;
            }

            else if (toaddress.Text == "")
            {
                LabelNotify.Text = "Friends email address is required!";
                return 1;
            }

            else if (toaddress.Text.Contains("@") == false && toaddress.Text.Contains(".") == false)
            {
                LabelNotify.Text = "Friends email address is invalid!";
                return 1;
            }

            else if (toaddress.Text == fromaddress.Text)
            {
                LabelNotify.Text = "You cannot send email to your self due to our system restriction!";
                return 1;
            }

            else if (emailmsg.Text == "")
            {
                LabelNotify.Text = "Please enter something in Messege";
                return 1;
            }

            else
            {
                return 0;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1Click(object sender, EventArgs e)
        {
            var rq = RequestCheck();

            if (rq == 0)
            {
                if (Request.QueryString["jobid"] != null)
                {
                    var jobformater = "/jobdetails?jobid=" + Server.HtmlEncode(Request.QueryString["jobid"].ToString(CultureInfo.InvariantCulture)) + "&jobtitle=" + Server.HtmlEncode(Request.QueryString["jobtitle"]);
                    var clmail = new ClEmailProcessor();
                    clmail.Sendmailproc(fromaddress.Text, toaddress.Text, "Fashion Quadrant: Some one has forwarded a job to you!", "<div style=\"width:500px\"><div style=\"-moz-box-shadow: 3px 3px 4px #ccc; -webkit-box-shadow: 3px 3px 4px #ccc; box-shadow: 3px 3px 4px #ccc;-ms-filter: \"progid:DXImageTransform.Microsoft.Shadow(Strength=4, Direction=135, Color=\"#cccccc\")\";filter: progid:DXImageTransform.Microsoft.Shadow(Strength=4,Direction=135,Color=\"#cccccc\"); font-family: Helvetica, Verdana, sans-serif; margin: 10px 0px 0px 10px;\"><div style=\"background-color: #000; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 48px; background-color: #000; display: inline-block; vertical-align: middle;\"><img alt=\"fashion quadrant\" src=\"" + ConfigurationManager.AppSettings["httppaths"].ToString() + "/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 14px; min-height:300px;\"><span style=\"font-size:20px;\">Hello there,</span><br/><br/>Someone has forwarded a job for you from fashionquadrant, please apply using the link below.<br/><a style=\"color: #ccc; text-decoration: underline\" href=\"" + System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + jobformater + "\">" + System.Configuration.ConfigurationManager.AppSettings["httppaths"].ToString(CultureInfo.InvariantCulture) + Server.HtmlEncode(Request.QueryString["jobtitle"]) + "</a><br /><br />Message from sender:<br/>" + emailmsg.Text + "<br/><br/>Sincerely,<br/><br/><b>Fashion Quadrant</b><br/><br/><br/><br/><span style=\"line-height:12px;font-size:11px;\"> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email.</span> </div><div style=\"color:#ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; line-height:12px; font-size: 11px;\">Copyrights 2013 Fashion Quadrant</b><br/>Please do not reply to this auto generated message. We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: none;\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>. If you need to contact us send us an email at: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div></div>", 5);
                    Session["reasons"] = "You have sucessfully send out" + Server.HtmlEncode(Request.QueryString["jobtitle"]) + " a job to: " + toaddress.Text;
                    Response.Redirect("/confirm");
                }
            }
        }

        protected void Button2Click1(object sender, EventArgs e)
        {
            Response.Redirect("/home");
        }
    }
}