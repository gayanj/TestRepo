using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace EmailProcessor
{
    class Tester
    {
        string _Subject = "Fashion Quadrant: Job Alert!";
        string _Bodya = "<div style=\"width:680px;font-family: Helvetica, Verdana, sans-serif;\"><div style=\"-moz-box-shadow: 3px 3px 4px #ccc; -webkit-box-shadow: 3px 3px 4px #ccc; box-shadow: 3px 3px 4px #ccc;-ms-filter: \"progid:DXImageTransform.Microsoft.Shadow(Strength=4, Direction=135, Color=\"#cccccc\")\";filter: progid:DXImageTransform.Microsoft.Shadow(Strength=4,Direction=135,Color=\"#cccccc\"); margin: 10px 0px 0px 10px;\"><div style=\"background-color: #000; border-width: 1px; border-collapse: collapse; border-style: solid;\"><div style=\"color: #FFFFFF; min-height: 48px; background-color: #000; display: inline-block; vertical-align: middle;\"><img alt=\"fashion quadrant\" src=\"http://fashionquadrant.com/brandimages/brand_mail.png\"/></div><div style=\"border-color: #999; border-bottom-style: solid; border-width: 2px; border-top-style: solid; background-color: #666; padding: 10px 10px 10px 10px; color: #E6E6E6; font-size: 14px; min-height:300px;\">";
        string _Bodyb = "<span style=\"font-size:20px;\">Hello there,</span><br/><br/>Here are some jobs you may be interested in.<br/><table style=\"border-collapse:collapse;width:660px;margin:0px auto;\"><thead style=\"line-height:16px;background-color:#a5a5a5;color:#000;padding:2px;font-weight:bold;\"><tr><td style=\"width:300px;\">Job Title</td><td style=\"width:150px;\">Location</td></td><td style=\"width:150px;\">Employer</td><td style=\"width:80px;\"></tr></thead>";
        string _Bodyb1 = "</table><table style=\"border-collapse:collapse;min-height:100px;width:660;background-color:#444;margin:0px auto;\"><tr><td style=\"width:300px;padding:10px;\">Upload your resume, it's Free! get head hunted by potential Recruiters.</td><td style=\"width:360px; padding:4px; color: #ccc\"><a href=\"http://fashionquadrant.com/jobseekers/cvupload\" style=\"text-decoration:none;\"> <div style=\"text-align:center;background-color:#000;height:80px;width:340px;margin:0px auto;font-size:48px;\">Upload</div></a></td></tr></table>";
        string _Bodyc = "<br /><br />Sincerely,<br/><br/><b>Fashion Quadrant</b><br/><br/><br/><br/>";
        string _Bodyd = "<span style=\"line-height:12px;font-size:11px;\"> NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information via Email.</span> </div><div style=\"color:#ccc; background-color: #333; padding: 2px 4px 2px 4px; border-color: GrayText; line-height:12px; font-size: 11px;\">Copyrights 2012 Fashion Quadrant</b><br/>Please do not reply to this auto generated message. We respect your privacy, to review our privacy policy visit <a style=\"color: #ccc; text-decoration: none;\" href=\"http://fashionquadrant.com/privacy\" >www.fashionquadrant.com/privacy</a>. If you need to contact us send us an email at: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a>.If you don&#39;t want to receive these emails from fashionquadrant in the future or have your email address re-used, you can unsubscribe by sending an email with subject unsubscribe to: <a href=\"mailto:info@fashionquadrant.com\" style=\"color: #ccc; text-decoration: underline\">info@fashionquadrant.com</a></div></div></div></div>";
        string _footer = "<br/><br/>NOTE: This mail is delivered by Securiva, if you have any concerns regarding the genuinity of this email message please get in touch with us at info@securiva.com. However, Securiva doesnot take any responsibility of client contents. If you think that you have been a target of spam emailing please contact the client directly.";

        public string SendEmail(string fromaddr, string toaddr, int i, string _server, string usn, string pass, int _port)
        {
            //checkcode
            var message = new MailMessage();
            message.To.Add(toaddr);

            message.Subject = _Subject;
            message.From = new MailAddress(fromaddr);
            message.IsBodyHtml = true;
            message.Body = _Bodya + _Bodyb + InnerJobs() + _Bodyb1 + _Bodyc + _Bodyd + _footer;
            var smtp = new SmtpClient(_server, _port);
            /*
            {
                Credentials = new NetworkCredential("noreply@fashionquadrant.com", "test1122")
            };*/

            try
            {
                smtp.Send(message);
                return "";
            }
            catch (Exception e)
            {
                return e.Message + "->" + i + Environment.NewLine;
            }
        }

        public string InnerJobs()
        {
            var sb = new StringBuilder();

            var connreader = new MySqlConnection { ConnectionString = "Server=localhost; UserId=Genre; Password=!1IamBackTo; Database=fashionquadrant;" };

            using (connreader)
            {
                var command = new MySqlCommand("select stitle, slocation, idjobs, replace(stitle, ' ','-') as newtitle, srecruitername, DATE_FORMAT(dtentered, '%d.%m.%Y') as dates from jobs order by stitle, dtentered desc limit 10;", connreader);

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sb.Append("<tr style=\"border-bottom:1px solid #888;\">");
                        sb.Append("<td>");
                        sb.Append(reader.GetString(0));
                        sb.Append("</td>");
                        sb.Append("<td>");
                        sb.Append(reader.GetString(1));
                        sb.Append("</td>");
                        sb.Append("<td>");
                        sb.Append(reader.GetString(4));
                        sb.Append("</td>");
                        sb.Append("<td>");
                        sb.Append("<a style=\"text-decoration:none;color:#000;font-weight:bold;\" href=\"http://fashionquadrant.com/jobdetails?jobid=" + reader.GetString(2) + "&jobtitle=\"" + reader.GetString(3) + "\">Apply</a>");
                        sb.Append("</td>");
                        sb.Append("</tr>");
                    }
                }

                reader.Close();
            }
            return sb.ToString();
        }

        public string emails(int next)
        {
            var sb = new StringBuilder();

            var connreader = new MySqlConnection { ConnectionString = "Server=localhost; UserId=Genre; Password=!1IamBackTo; Database=fashionquadrant;" };

            using (connreader)
            {
                var command = new MySqlCommand("select email from emaillist where id= '" + next + "';", connreader);

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }

                reader.Close();
            }
            return null;
        }
    }
}
