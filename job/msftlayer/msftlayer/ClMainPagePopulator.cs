using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClMainPagePopulator
    {
        //aggregate block
        /////////////////////////////////////////////
        //get job count
        public int Getcountjobs()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getcountjobs();
        }

        //get total recs
        public int Getcountrecs()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getcountrecs();
        }

        //get advertizing rec count
        public int Getcountrecswadvert()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getcountrecswadvert();
        }

        //gets max jobs
        /*public string Getmaxjobid()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getmaxjobid();
        }

        //get min jobs
        public int Getminjobid()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getminjobid();
        }
         */

        //delete current categories
        public void Deletejobs(string jobid)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Deletejobs(jobid);
        }

        //add jobs
        public void Insertjobs(string idjobs, string sTitle, string sShortDescription, string sDescription,
                               string ssalarytext, int ssalarymin, int ssalarymax, string sref, string startdate,
                               string enddate, bool videoset, string postcode, string location, string recname, string strcurr)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Insertjobs(idjobs, sTitle, sShortDescription, sDescription, ssalarytext, ssalarymin, ssalarymax,
                               sref, startdate, enddate, videoset, postcode, location, recname, strcurr);
        }

        //add job rec assignments
        public void Insertjobmapping(string idjobs, int catid, int lisubcatid, string empid)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Insertjobmapping(idjobs, catid, lisubcatid, empid);
        }

        //get jobdetails page
        public string Getcurrrec(string empid)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getcurrrec(empid);
        }

        //get rec details page
        public string[] Getdetailspage(string jobid)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getdetailspage(jobid);
        }

        //get details page
        public string Getdetailspagecats(string jobid, int cats)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getdetailspagecats(jobid, cats);
        }

        //get details for salaries
        //get details page
        public string Getdetailspagecats(string jobid, int cats, int jobsal)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getdetailspagecats(jobid, cats, jobsal);
        }

        //fill in jobs form
        public string[] Filljobform(string jobid)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Filljobform(jobid);
        }

        //public string[,] getSalary()
        //{
        //    //store rec details
        //    string[,] arrayrec= new string[2,7];

        //    MySqlConnection connreader = new MySqlConnection();
        //    //Clconnect kenect = new Clconnect();
        //    connreader.ConnectionString =  Clconnect.makeconn;

        //    using (connreader)
        //    {
        //    MySqlCommand command = new MySqlCommand("SELECT subcatid, sdefinition from subcats where subcatid >= 6000 and subcatid <7000 order by subcatid;", connreader);

        //    connreader.Open();

        //    MySqlDataReader reader = command.ExecuteReader();
        //    int i = 0;

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            //checkcode
        //            arrayrec[0,i] = reader.GetString(0);
        //            arrayrec[1, i] = reader.GetString(1);
        //        }
        //    }

        //    else
        //    {
        //        //Console.WriteLine("No rows found.");
        //    }
        //    reader.Close();
        //    }
        //    return arrayrec;
        //}

        //revert if issue with mem cached..
        public DataTable GetSalary()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetSalary();
        }

        public object GetIndustriestop()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetIndustriestop();
        }

        public object GetLocationtop()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetLocationstop();
        }

        public object GetLocations()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetLocations();
        }

        public object GetIndustries()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetIndustries();
        }

        public DataTable GetExperience()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetExperience();
        }

        public DataTable Getsalaries()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getsalaries();
        }

        public DataTable GetJobs()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetJobs();
        }

        public DataTable GetJobssingle()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetJobssingle();
        }

        //get recruiterid by name
        public string Getrecname(string usrname)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getrecname(usrname);
        }

        //get recruiter inactive jobs
        public DataTable GetJobssingle(string sEmpID)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetJobssingle(sEmpID);
        }

        //get recruiter active jobs
        public DataTable GetJobssinglearchived(string sEmpID)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetJobssinglearchived(sEmpID);
        }

        //gets max recruiters
        public string GetRecHasRows()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetRecHasRows();
        }

        //max user id
        public string Getmaxuserid()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getmaxuserid();
        }

        //max candidate id
        public string Getmaxcandidateid()
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getmaxcandidateid();
        }

        //add candidates
        public void Insertcandidates(string maxcanid, string cCandidateName, string cFirstName, string cLastName,
                                     string cAddress1, string cAddress2, string cAddress3, string cTown, string cCounty,
                                     string cCountry, string cPostcode, string sWebsite, string hphone, string wphone,
                                     string cdtEntered)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Insertcandidates(maxcanid, cCandidateName, cFirstName, cLastName, cAddress1, cAddress2, cAddress3,
                                     cTown, cCounty, cCountry, cPostcode, sWebsite, hphone, wphone, cdtEntered);
        }


        //add recruiters
        public void Insertrecruiters(string maxrec, string sRecruiterName, string sAddress1, string sAddress2,
                                     string sAddress3, string sTown, string sCounty, string sCountry, string sPostcode,
                                     string sEmailAddress, string sWebsite, string sDescription, string sCompleteDesc,
                                     string sdtEntered, int sEnteredbyID, string sartifactId)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Insertrecruiters(maxrec, sRecruiterName, sAddress1, sAddress2, sAddress3, sTown, sCounty, sCountry,
                                     sPostcode, sEmailAddress, sWebsite, sDescription, sCompleteDesc, sdtEntered,
                                     sEnteredbyID, sartifactId);
        }

        //add users
        public void Insertusers(string rusername, string fname, int uisprimary, string lname, string rpassword,
                                int rtype, string idUsers, string pwdhint, string ucandidateid, string uhash, string servid)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Insertusers(rusername, fname, uisprimary, lname, rpassword, rtype, idUsers, pwdhint, ucandidateid,
                                uhash, servid);
        }

        //add rec user mapping
        public void Insertrecusermapping(string empid, string userid)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Insertrecusermapping(empid, userid);
        }

        //getrecruiterdetails
        public string[] GetRecDetails(string usrname)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.GetRecDetails(usrname);
        }

        //edit jobs
        public void Updatejobs(string idjobs, string sTitle, string sShortDescription, string sDescription,
                               string ssalarytext, int ssalarymin, int ssalarymax, string sref, string sdate,
                               string edate, string postcode, string location, string recname, string strcurr)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Updatejobs(idjobs, sTitle, sShortDescription, sDescription, ssalarytext, ssalarymin, ssalarymax,
                               sref, sdate, edate, postcode, location, recname, strcurr);
        }

        //get user my applications
        public DataTable Getmyapps(string uusername)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getmyapps(uusername);
        }

        //get candidate detail page
        public string[] Getcandidatedetails(string susername)
        {
            var dlmains = new MlMainpagepopulator();
            return dlmains.Getcandidatedetails(susername);
        }

        public string Profilestrind(string uusername)
        {
            var mlmain = new MlMainpagepopulator();
            var tempprof = mlmain.Getcandidatedetails(uusername);

            var profilehelper = 0;
            var profilevalue = "Low";

            if (tempprof[0].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[1].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[2].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[3].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[4].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[5].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[6].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[7].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[8].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[9].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            if (tempprof[10].Trim().Length > 3)
            {
                profilehelper = profilehelper + 1;
            }

            //now get the real strength
            //if (_profilehelper > 0 && _profilehelper < 3)
            //{
            //    _profilevalue = "Low";
            //}

            if (profilehelper > 3 && profilehelper < 6)
            {
                profilevalue = "Medium";
            }

            if (profilehelper > 6)
            {
                profilevalue = "High";
            }

            return profilevalue;
        }

        //insert comments from users
        public void Insertsitecomment(string sEmailaddress, string sComment, string sIp)
        {
            var dlmains = new MlMainpagepopulator();
            dlmains.Insertsitecomment(sEmailaddress, sComment, sIp);
        }
    }
}