using System.Text;
using Mysqllayer;

namespace Memorylayer
{
    public class MlEmailProcessor
    {
        //get recruiter details for jobemails subjects
        public string Getsubdirectapp(string jobid)
        {
            var clemail = new SlEmailProcessor();
            return clemail.Getsubdirectapp(jobid);
        }

        //this is for processing password change notifications.
        public StringBuilder Getemailpwdnotify(string passwordlink, string uusername)
        {
            var clemail = new SlEmailProcessor();
            return clemail.Getemailpwdnotify(passwordlink, uusername);
        }

        //user activation email
        public StringBuilder Getemailactivateusr(string activationlink, string uusername)
        {
            var clemail = new SlEmailProcessor();
            return clemail.Getemailactivateusr(activationlink, uusername);
        }

        //register a new template
        public void Insertemailtemplate(string ebody, int etemplatechkid, string etemplatename, string ehead,
                                        string efoot)
        {
            var clemail = new SlEmailProcessor();
            clemail.Insertemailtemplate(ebody, etemplatechkid, etemplatename, ehead, efoot);
        }

        //this is for processing application notifications.
        public StringBuilder Getemaildirapps(int typeofemail, string username)
        {
            var clemail = new SlEmailProcessor();
            return clemail.Getemaildirapps(typeofemail, username);
        }

        //on sucess of application email sent out

        public void Insertappemaildb(string _EAddress, string _ResponseCode, string _Desc, string subject, string body)
        {
            var clemail = new SlEmailProcessor();
            clemail.Insertappemaildb(_EAddress, _ResponseCode, _Desc, subject, body);
        }
    }
}