using System;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Text;
using Memorylayer;

namespace Msftlayer
{
    public class ClEmailProcessor
    {
        //get recruiter details for jobemails subjects
        public string Getsubdirectapp(string jobid)
        {
            var mlemail = new MlEmailProcessor();
            return mlemail.Getsubdirectapp(jobid);
        }

        //this is for processing password change notifications.
        public StringBuilder Getemailpwdnotify(string passwordlink, string uusername)
        {
            //checklayer
            var mlemail = new MlEmailProcessor();
            return mlemail.Getemailpwdnotify(passwordlink, uusername);
        }

        //user activation email
        public StringBuilder Getemailactivateusr(string activationlink, string uusername)
        {
            var mlemail = new MlEmailProcessor();
            return mlemail.Getemailactivateusr(activationlink, uusername);
        }

        //register a new template
        public void Insertemailtemplate(string ebody, int etemplatechkid, string etemplatename, string ehead,
                                        string efoot)
        {
            var mlemail = new MlEmailProcessor();
            mlemail.Insertemailtemplate(ebody, etemplatechkid, etemplatename, ehead, efoot);
        }

        //this is for processing application notifications.
        public StringBuilder Getemaildirapps(int typeofemail, string username)
        {
            var mlemail = new MlEmailProcessor();
            return mlemail.Getemaildirapps(typeofemail, username);
        }

        //simple reuseable send mail proc
        public void Sendmailproc(string toaddr, string tosubject, string tobody, int typeofemail)
        {
            var message = new MailMessage();
            message.To.Add(toaddr);
            message.Subject = tosubject;
            message.From =
                new MailAddress(ConfigurationManager.AppSettings["emailfrom"].ToString(CultureInfo.InvariantCulture));
            message.IsBodyHtml = true;
            message.Body = tobody;
            var smtp =
                new SmtpClient(ConfigurationManager.AppSettings["emailserver"].ToString(CultureInfo.InvariantCulture),
                               Convert.ToInt16(ConfigurationManager.AppSettings["emailport"]))
                    {
                        Credentials = new NetworkCredential(
                            ConfigurationManager.AppSettings["emailuname"].ToString(CultureInfo.InvariantCulture),
                            ConfigurationManager.AppSettings["emailpwd"].ToString(CultureInfo.InvariantCulture))
                    };

            try
            {
                smtp.Send(message);
            }
            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i < ex.InnerExceptions.Length; i++)
                {
                    SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                    Insertappemaildb(toaddr, status.ToString(), ex.InnerException.ToString(), tosubject, tobody);
                }
            }

            catch (Exception unknown)
            {
                //add to db
                Insertappemaildb(toaddr, "0", unknown.InnerException.ToString(), tosubject, tobody);
            }
        }

        public void Sendmailproc(string fromaddr, string toaddr, string tosubject, string tobody, int typeofemail)
        {
            //checkcode
            var message = new MailMessage();
            message.To.Add(toaddr);
            message.Subject = tosubject;
            message.From = new MailAddress(fromaddr);
            message.IsBodyHtml = true;
            message.Body = tobody;
            var smtp =
                new SmtpClient(ConfigurationManager.AppSettings["emailserver"].ToString(CultureInfo.InvariantCulture),
                               Convert.ToInt16(ConfigurationManager.AppSettings["emailport"]))
                    {
                        Credentials = new NetworkCredential(
                            ConfigurationManager.AppSettings["emailuname"].ToString(CultureInfo.InvariantCulture),
                            ConfigurationManager.AppSettings["emailpwd"].ToString(CultureInfo.InvariantCulture))
                    };

            try
            {
                smtp.Send(message);
            }

            catch (SmtpFailedRecipientsException ex)
            {
                for (int i = 0; i < ex.InnerExceptions.Length; i++)
                {
                    SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                    Insertappemaildb(toaddr, status.ToString(), ex.InnerException.ToString(), tosubject, tobody);
                }
            }

            catch (Exception unknown)
            {
                //add to db
                Insertappemaildb(toaddr, unknown.Message.ToString(), unknown.InnerException.ToString(), tosubject, tobody);
            }
        }

        //on sucess of application email sent out

        public void Insertappemaildb(string _EAddress, string _ResponseCode, string _Desc, string subject, string body)
        {
            var mlemail = new MlEmailProcessor();
            mlemail.Insertappemaildb(_EAddress, _ResponseCode, _Desc, subject, body);
        }
    }
}