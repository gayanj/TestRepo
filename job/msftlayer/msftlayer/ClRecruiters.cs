using System.Collections;
using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClRecruiters
    {
        public DataTable Getallbycriteria(int criteria)
        {
            var mlrec = new MlRecruiters();
            if (criteria == 1)
            {
                //will be a company
                return mlrec.Getalldirectrecwithjobs();
            }

            else
            {
                //will be an agent
                return mlrec.Getallagentswithjobs();
            }
        }

        public DataTable Getallbyqrycriteria(int criteria, string qry)
        {
            var mlrec = new MlRecruiters();
            if (criteria == 1)
            {
                //will be a company
                return mlrec.Getalldirectrecwithjobs(qry);
            }

            else
            {
                //will be an agent
                return mlrec.Getallagentswithjobs(qry);
            }
        }

        public string[] Getrecbyidstrarr(string recname)
        {
            var mlrec = new MlRecruiters();
            return mlrec.Getrecbyidstrarr(recname);
        }

        public DataTable Getrecwithjobs(string empid)
        {
            var mlrec = new MlRecruiters();
            return mlrec.Getrecwithjobs(empid);
        }

        //reload allrecruiters

        public void Reloadallrecwithjobs()
        {
            var mrec = new MlRecruiters();
            mrec.Reloadallrecwithjobs();
        }

        //get recid for blocking
        public string Getrecid(string recname)
        {
            var rcl = new MlRecruiters();
            return rcl.Getrecid(recname);
        }

        public DataTable RecUsers(string userns)
        {
            var rcl = new MlRecruiters();
            return rcl.RecUsers(userns);
        }

        //get all recruiters w jobs
        public object Getallrecwithjobs()
        {
            var rcl = new MlRecruiters();
            return rcl.Getallrecwithjobs();
        }

        public DataTable Getallrecwithjobsfiltered(string criteria)
        {
            var rcl = new MlRecruiters();
            return rcl.Getallrecwithjobsfiltered(criteria);
        }

        //get one rec detail with recid
        public ArrayList Getcurrrecwithempid(string empid)
        {
            var rcl = new MlRecruiters();
            return rcl.Getcurrrecwithempid(empid);
        }

        //get contact person details page
        public string Contactperson(string jobid)
        {
            var rcl = new MlRecruiters();
            return rcl.Contactperson(jobid);
        }

        //update recuser with id = 1;
        public void Runrecuserupdate(string fname, string lname, string uusername)
        {
            var rcl = new MlRecruiters();
            rcl.Runrecuserupdate(fname, lname, uusername);
        }

        //logo update for recruiters with id = 1;
        public void Runreclogoupdate(string artifactData, string artifactname, string uusername)
        {
            var rcl = new MlRecruiters();
            rcl.Runreclogoupdate(artifactData, artifactname, uusername);
        }

        //update recruiter table information
        public void Runrectableupdate(string add1, string add2, string add3, string town, string county, string postcode,
                                      string compname, string compwebsite, string companyintro, string businessdetail,
                                      string uusername, bool businesstype)
        {
            var rcl = new MlRecruiters();
            rcl.Runrectableupdate(add1, add2, add3, town, county, postcode, compname, compwebsite, companyintro,
                                  businessdetail, uusername, businesstype);
        }

        //get artifact id to update the logo
        public string Getartifactids(string uusername)
        {
            var rcl = new MlRecruiters();
            return rcl.Getartifactids(uusername);
        }

        public string Getcompanybyrec(string empid)
        {
            var srec = new MlRecruiters();
            return srec.Getcompanybyrec(empid);
        }
    
        //cms
        public DataTable GetAllRecs()
        {
            var cl = new MlRecruiters();
            return cl.GetAllRecs();
        }

        public string GetRecbyUserName(string recname)
        {
            var _c = new MlRecruiters();
            return _c.GetRecbyUserName(recname);
        }
    
    }

}