using Mysqllayer;

namespace Memorylayer
{
    public class MlLogins
    {
        //activate accounts for users and recruitersm
        public void UpdateactivateAcc(int uusertype, string uusername, string keytopass)
        {
            var cllog = new SlLogins();
            cllog.UpdateactivateAcc(uusertype, uusername, keytopass);
        }

        //get user orginal name for welcome //only for candidates
        public string Getuserwelcomename(string pusername, int uusertype)
        {
            var cllog = new SlLogins();
            return cllog.Getuserwelcomename(pusername, uusertype);
        }

        //get employee id ony for employees
        public string Getuserwelcomename(string pusername, int uusertype, string empid)
        {
            var cllog = new SlLogins();
            return cllog.Getuserwelcomename(pusername, uusertype, empid);
        }

        //check the password key against the database
        public string Getkeyuser(string keyids, int utype)
        {
            var cllog = new SlLogins();
            return cllog.Getkeyuser(keyids, utype);
        }

        //set seed key for user
        public void Updateuserkey(string uusername, string keys)
        {
            var cllog = new SlLogins();
            cllog.Updateuserkey(uusername, keys);
        }

        //set seed key for recruiters
        public void Updatereckey(string uusername, string keys)
        {
            var cllog = new SlLogins();
            cllog.Updatereckey(uusername, keys);
        }

        //this is admin user
        //1 is admin
        public string Getuser(string userns, string pwds, string pwdhash)
        {
            var cllog = new SlLogins();
            return cllog.Getuser(userns, pwds, pwdhash);
        }

        //0 this is cms
        public string Getusercms(string userns, string pwds, string pwdhash)
        {
            var cllog = new SlLogins();
            return cllog.Getusercms(userns, pwds, pwdhash);
        }

        //jobseeker user
        //2 is jobseeker
        public string Getjobuser(string usns, string pwds, string pwdhash)
        {
            var cllog = new SlLogins();
            return cllog.Getjobuser(usns, pwds, pwdhash);
        }

        //change passwords
        //rec password or admin 1
        public void Updaterecpwd(string uUserName, string pwds, string pwdhash)
        {
            var cllog = new SlLogins();
            cllog.Updaterecpwd(uUserName, pwds, pwdhash);
        }

        //jobseeker password or admin 2
        public void Updatejspwd(string uUserName, string pwds, string pwdhash)
        {
            var cllog = new SlLogins();
            cllog.Updatejspwd(uUserName, pwds, pwdhash);
        }

        //change passwords with keys.....
        //change passwords
        //rec password or admin 1
        public void Updatepwdrecwkey(string keyval, string pwds, string pwdhash)
        {
            var cllog = new SlLogins();
            cllog.Updatepwdrecwkey(keyval, pwds, pwdhash);
        }

        //jobseeker password or admin 2
        public void Updatepwdjswkey(string keyval, string pwds, string pwdhash)
        {
            var cllog = new SlLogins();
            cllog.Updatepwdjswkey(keyval, pwds, pwdhash);
        }

        //check if the recruiter exists in the database
        public string Getchkrecusern(string userns)
        {
            var cllog = new SlLogins();
            return cllog.Getchkrecusern(userns);
        }

        //check if the candidate exists in the database
        public string Getchkcanusern(string userns)
        {
            var cllog = new SlLogins();
            return cllog.Getchkcanusern(userns);
        }

        //check the usertype for the main windows like is it recruiter of single user
        public int Getchkusertype(string uusername, int uusertypes)
        {
            var cllog = new SlLogins();
            return cllog.Getchkusertype(uusername, uusertypes);
        }

        //get user forgot password
        public string Getseeuseremail(string passeduseremail)
        {
            var cllog = new SlLogins();
            return cllog.Getseeuseremail(passeduseremail);
        }

        //get recruiter forgot password
        public string Getseerecemail(string passeduseremail)
        {
            var cllog = new SlLogins();
            return cllog.Getseerecemail(passeduseremail);
        }

        public string Getuserid(string pusername)
        {
            var slog = new SlLogins();
            return slog.Getuserid(pusername);
        }
    }
}