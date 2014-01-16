using System;
using System.Collections;
using System.Configuration;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlRecruiters
    {
        public DataTable Getallagentswithjobs()
        {
            var slrec = new SlRecruiters();
            return slrec.Getallagentswithjobs();
        }

        public DataTable Getalldirectrecwithjobs()
        {
            var slrec = new SlRecruiters();
            return slrec.Getalldirectrecwithjobs();
        }

        public DataTable Getallagentswithjobs(string qry)
        {
            var slrec = new SlRecruiters();
            return slrec.Getallagentswithjobs(qry);
        }

        public DataTable Getalldirectrecwithjobs(string qry)
        {
            var slrec = new SlRecruiters();
            return slrec.Getalldirectrecwithjobs(qry);
        }

        public string[] Getrecbyidstrarr(string recname)
        {
            var mlrec = new SlRecruiters();
            return mlrec.Getrecbyidstrarr(recname);
        }

        public DataTable Getrecwithjobs(string empid)
        {
            var mlrec = new SlRecruiters();
            return mlrec.Getrecwithjobs(empid);
        }

        public string Getcompanybyrec(string empid)
        {
            var srec = new SlRecruiters();
            return srec.Getcompanybyrec(empid);
        }

        //get recid for blocking
        public string Getrecid(string recname)
        {
            var rcl = new SlRecruiters();
            return rcl.Getrecid(recname);
        }

        public DataTable RecUsers(string userns)
        {
            var rcl = new SlRecruiters();
            return rcl.RecUsers(userns);
        }

        //push recruiters reload.
        public void Reloadallrecwithjobs()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            var srec = new SlRecruiters();
            clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetallrecwjb", srec.Getallrecwithjobs());
        }

        //get all recruiters w jobs
        public object Getallrecwithjobs()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetallrecwjb");

            if (mrec != null)
            {
                int mcrsststamp =
                    Convert.ToInt32(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp2"));
                if (mcrsststamp == DateTime.Now.Hour)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp2", DateTime.Now.Hour);

                    //add to memory array
                    var srec = new SlRecruiters();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetallrecwjb",
                                     srec.Getallrecwithjobs());
                    mrec = srec.Getallrecwithjobs();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp2", DateTime.Now.Hour);

                //add to memory object
                var srec = new SlRecruiters();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetallrecwjb",
                                 srec.Getallrecwithjobs());
                mrec = srec.Getallrecwithjobs();
                return mrec;
            }

            //SLRecruiterCl Rcl = new SLRecruiterCl();
            //return Rcl.getallrecwithjobs();
        }

        public DataTable Getallrecwithjobsfiltered(string criteria)
        {
            var rcl = new SlRecruiters();
            return rcl.Getallrecwithjobsfiltered(criteria);
        }

        //get one rec detail with recid
        public ArrayList Getcurrrecwithempid(string empid)
        {
            var rcl = new SlRecruiters();
            return rcl.Getcurrrecwithempid(empid);
        }

        //get contact person details page
        public string Contactperson(string jobid)
        {
            var rcl = new SlRecruiters();
            return rcl.Contactperson(jobid);
        }

        //update recuser with id = 1;
        public void Runrecuserupdate(string fname, string lname, string uusername)
        {
            var rcl = new SlRecruiters();
            rcl.Runrecuserupdate(fname, lname, uusername);
        }

        //logo update for recruiters with id = 1;
        public void Runreclogoupdate(string artifactData, string artifactname, string uusername)
        {
            var rcl = new SlRecruiters();
            rcl.Runreclogoupdate(artifactData, artifactname, uusername);
        }

        //update recruiter table information
        public void Runrectableupdate(string add1, string add2, string add3, string town, string county, string postcode,
                                      string compname, string compwebsite, string companyintro, string businessdetail,
                                      string uusername, bool businesstype)
        {
            var rcl = new SlRecruiters();
            rcl.Runrectableupdate(add1, add2, add3, town, county, postcode, compname, compwebsite, companyintro,
                                  businessdetail, uusername, businesstype);
        }

        //get artifact id to update the logo
        public string Getartifactids(string uusername)
        {
            var rcl = new SlRecruiters();
            return rcl.Getartifactids(uusername);
        }

        //move to cms
        public DataTable GetAllRecs()
        {
            var cl = new SlRecruiters();
            return cl.GetAllRecs();
        }

        public string GetRecbyUserName(string recname)
        {
            var _c = new SlRecruiters();
            return _c.GetRecbyUserName(recname);
        }
    }
}