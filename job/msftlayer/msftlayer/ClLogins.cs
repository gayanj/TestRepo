using Memorylayer;

namespace Msftlayer
{
    public class ClLogins
    {
        //activate accounts for users and recruitersm
        public void UpdateactivateAcc(int uusertype, string uusername, string keytopass)
        {
            var mllog = new MlLogins();
            mllog.UpdateactivateAcc(uusertype, uusername, keytopass);
        }

        //get user orginal name for welcome //only for candidates
        public string Getuserwelcomename(string pusername, int uusertype)
        {
            var mllog = new MlLogins();
            return mllog.Getuserwelcomename(pusername, uusertype);
        }

        //get employee id ony for employees
        public string Getuserwelcomename(string pusername, int uusertype, string empid)
        {
            var mllog = new MlLogins();
            return mllog.Getuserwelcomename(pusername, uusertype, empid);
        }

        //check the password key against the database
        public string Getkeyuser(string keyids, int utype)
        {
            var mllog = new MlLogins();
            return mllog.Getkeyuser(keyids, utype);
        }

        //set seed key for user
        public void Updateuserkey(string uusername, string keys)
        {
            var mllog = new MlLogins();
            mllog.Updateuserkey(uusername, keys);
        }

        //set seed key for recruiters
        public void Updatereckey(string uusername, string keys)
        {
            var mllog = new MlLogins();
            mllog.Updatereckey(uusername, keys);
        }

        //this is admin user
        //1 is admin
        public string Getuser(string userns, string pwds)
        {
            var mllog = new MlLogins();
            var phash = new ClPwdHash();

            return mllog.Getuser(userns, pwds, phash.GetMd5Hash(pwds));
        }

        //0 this is cms
        public string Getusercms(string userns, string pwds)
        {
            var mllog = new MlLogins();
            var phash = new ClPwdHash();

            return mllog.Getusercms(userns, pwds, phash.GetMd5Hash(pwds));
        }

        //jobseeker user
        //2 is jobseeker
        public string Getjobuser(string usns, string pwds)
        {
            var mllog = new MlLogins();
            var phash = new ClPwdHash();
            return mllog.Getjobuser(usns, pwds, phash.GetMd5Hash(pwds));
        }

        //change passwords
        //rec password or admin 1
        public void Updaterecpwd(string uUserName, string pwds)
        {
            var mllog = new MlLogins();
            var phash = new ClPwdHash();
            mllog.Updaterecpwd(uUserName, pwds, phash.GetMd5Hash(pwds));
        }

        //jobseeker password or admin 2
        public void Updatejspwd(string uUserName, string pwds)
        {
            var mllog = new MlLogins();
            var clphsh = new ClPwdHash();
            mllog.Updatejspwd(uUserName, pwds, clphsh.GetMd5Hash(pwds));
        }

        //change passwords with keys.....
        //change passwords
        //rec password or admin 1
        public void Updatepwdrecwkey(string keyval, string pwds)
        {
            var mllog = new MlLogins();
            var clphsh = new ClPwdHash();
            mllog.Updatepwdrecwkey(keyval, pwds, clphsh.GetMd5Hash(pwds));
        }

        //jobseeker password or admin 2
        public void Updatepwdjswkey(string keyval, string pwds)
        {
            var mllog = new MlLogins();
            var chsh = new ClPwdHash();
            mllog.Updatepwdjswkey(keyval, pwds, chsh.GetMd5Hash(pwds));
        }

        //check if the recruiter exists in the database
        public string Getchkrecusern(string userns)
        {
            var mllog = new MlLogins();
            return mllog.Getchkrecusern(userns);
        }

        //check if the candidate exists in the database
        public string Getchkcanusern(string userns)
        {
            var mllog = new MlLogins();
            return mllog.Getchkcanusern(userns);
        }

        //check the usertype for the main windows like is it recruiter of single user
        public int Getchkusertype(string uusername, int uusertypes)
        {
            var mllog = new MlLogins();
            return mllog.Getchkusertype(uusername, uusertypes);
        }

        //get user forgot password
        public string Getseeuseremail(string passeduseremail)
        {
            var mllog = new MlLogins();
            return mllog.Getseeuseremail(passeduseremail);
        }

        //get recruiter forgot password
        public string Getseerecemail(string passeduseremail)
        {
            var mllog = new MlLogins();
            return mllog.Getseerecemail(passeduseremail);
        }

        //get userid for job seekers
        public string Getuserid(string pusername)
        {
            var mlog = new MlLogins();
            return mlog.Getuserid(pusername);
        }
    }
}