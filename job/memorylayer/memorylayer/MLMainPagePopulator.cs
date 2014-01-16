using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlMainpagepopulator
    {
        //aggregate block
        /////////////////////////////////////////////
        //get job count
        public int Getcountjobs()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getcountjobs();
        }

        //get total recs
        public int Getcountrecs()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getcountrecs();
        }

        //get advertizing rec count
        public int Getcountrecswadvert()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getcountrecswadvert();
        }

        //gets max jobs
        /*
        public string Getmaxjobid()
        {
            var clmains = new SlMainpagepopulator();
            return clmains.Getmaxjobid();
        }

        //get min jobs
        public int Getminjobid()
        {
            var clmains = new SlMainpagepopulator();
            return clmains.Getminjobid();
        }
         * 
         */

        //delete current categories
        public void Deletejobs(string jobid)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Deletejobs(jobid);
        }

        //add jobs
        public void Insertjobs(string idjobs, string sTitle, string sShortDescription, string sDescription,
                               string ssalarytext, int ssalarymin, int ssalarymax, string sref, string startdate,
                               string enddate, bool videoset, string postcode, string location, string recname, string strcurr)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Insertjobs(idjobs, sTitle, sShortDescription, sDescription, ssalarytext, ssalarymin, ssalarymax,
                               sref, startdate, enddate, videoset, postcode, location, recname, strcurr);
        }

        //add job rec assignments
        public void Insertjobmapping(string idjobs, int catid, int lisubcatid, string empid)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Insertjobmapping(idjobs, catid, lisubcatid, empid);
        }

        //get jobdetails page
        public string Getcurrrec(string empid)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getcurrrec(empid);
        }

        //get rec details page
        public string[] Getdetailspage(string jobid)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getdetailspage(jobid);
        }

        //get details page
        public string Getdetailspagecats(string jobid, int cats)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getdetailspagecats(jobid, cats);
        }

        //get details for salaries
        //get details page
        public string Getdetailspagecats(string jobid, int cats, int jobsal)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getdetailspagecats(jobid, cats, jobsal);
        }

        //fill in jobs form
        public string[] Filljobform(string jobid)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Filljobform(jobid);
        }

        //revert if issue with mem cached..
        public DataTable GetSalary()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetSalary();
        }

        public object GetLocations()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetLocations();
        }

        public object GetIndustries()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetIndustries();
        }

        public object GetLocationstop()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetLocationstop();
        }

        public object GetIndustriestop()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetIndustriestop();
        }

        public DataTable GetExperience()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetExperience();
        }

        public DataTable Getsalaries()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getsalaries();
        }

        public DataTable GetJobs()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetJobs();
        }

        public DataTable GetJobssingle()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetJobssingle();
        }

        //get recruiterid by name
        public string Getrecname(string usrname)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getrecname(usrname);
        }

        //get recruiter inactive jobs
        public DataTable GetJobssingle(string sEmpID)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetJobssingle(sEmpID);
        }

        //get recruiter active jobs
        public DataTable GetJobssinglearchived(string sEmpID)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetJobssinglearchived(sEmpID);
        }

        //gets max recruiters
        public string GetRecHasRows()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetRecHasRows();
        }

        //max user id
        public string Getmaxuserid()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getmaxuserid();
        }

        //max candidate id
        public string Getmaxcandidateid()
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getmaxcandidateid();
        }

        //add candidates
        public void Insertcandidates(string maxcanid, string cCandidateName, string cFirstName, string clastName,
                                     string cAddress1, string cAddress2, string cAddress3, string cTown, string cCounty,
                                     string cCountry, string cPostcode, string sWebsite, string hphone, string wphone,
                                     string cdtEntered)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Insertcandidates(maxcanid, cCandidateName, cFirstName, clastName, cAddress1, cAddress2, cAddress3,
                                     cTown, cCounty, cCountry, cPostcode, sWebsite, hphone, wphone, cdtEntered);
        }



        //add recruiters
        public void Insertrecruiters(string maxrec, string sRecruiterName, string sAddress1, string sAddress2,
                                     string sAddress3, string sTown, string sCounty, string sCountry, string sPostcode,
                                     string sEmailAddress, string sWebsite, string sDescription, string sCompleteDesc,
                                     string sdtEntered, int sEnteredbyID, string sartifactId)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Insertrecruiters(maxrec, sRecruiterName, sAddress1, sAddress2, sAddress3, sTown, sCounty, sCountry,
                                     sPostcode, sEmailAddress, sWebsite, sDescription, sCompleteDesc, sdtEntered,
                                     sEnteredbyID, sartifactId);
        }

        //add users
        public void Insertusers(string rusername, string fname, int uisprimary, string lname, string rpassword,
                                int rtype, string idUsers, string pwdhint, string ucandidateid, string uhash, string servid)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Insertusers(rusername, fname, uisprimary, lname, rpassword, rtype, idUsers, pwdhint, ucandidateid,
                                uhash, servid);
        }

        //add rec user mapping
        public void Insertrecusermapping(string empid, string userid)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Insertrecusermapping(empid, userid);
        }

        //getrecruiterdetails
        public string[] GetRecDetails(string usrname)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.GetRecDetails(usrname);
        }

        //edit jobs
        public void Updatejobs(string idjobs, string sTitle, string sShortDescription, string sDescription,
                               string ssalarytext, int ssalarymin, int ssalarymax, string sref, string sdate,
                               string edate, string postcode, string location, string recname, string strcurr)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Updatejobs(idjobs, sTitle, sShortDescription, sDescription, ssalarytext, ssalarymin, ssalarymax,
                               sref, sdate, edate, postcode, location, recname, strcurr);
        }

        //get user my applications
        public DataTable Getmyapps(string uusername)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getmyapps(uusername);
        }

        //get candidate detail page
        public string[] Getcandidatedetails(string susername)
        {
            var clmains = new SlMainPagePopulator();
            return clmains.Getcandidatedetails(susername);
        }

        //insert comments from users
        public void Insertsitecomment(string sEmailaddress, string sComment, string sIp)
        {
            var clmains = new SlMainPagePopulator();
            clmains.Insertsitecomment(sEmailaddress, sComment, sIp);
        }
    }
}