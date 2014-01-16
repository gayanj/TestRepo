using System;
using System.Collections;
using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClJobs
    {
        public DataTable GetArchJobs(string empid)
        {
            var sl = new MlJobs();
            return sl.GetArchJobs(empid);
        }

        public DataTable GetActiveJobs(string empid)
        {
            var sl = new MlJobs();
            return sl.GetActiveJobs(empid);
        }

        public string Getrecjobassignment(string jobid)
        {
            var mlj = new MlJobs();
            return mlj.Getrecjobassignment(jobid);
        }

        //get postcode array
        public ArrayList Getpostcodesarr(string jobid)
        {
            var mlj = new MlJobs();
            return mlj.Getpostcodesarr(jobid);
        }

        public ArrayList Getjobidbyname(string jname)
        {
            var mlj = new MlJobs();
            return mlj.Getjobidbyname(jname);
        }

        public int Getacjobs(string recusername)
        {
            var slj = new MlJobs();
            return slj.Getacjobs(recusername);
        }

        public int Getarcjobs(string recusername)
        {
            var slj = new MlJobs();
            return slj.Getarcjobs(recusername);
        }

        public string Getnextjobid(string jobid)
        {
            var sjobs = new MlJobs();
            return sjobs.Getnextjobid(jobid);
        }

        public string Getprevjobid(string jobid)
        {
            var sjobs = new MlJobs();
            return sjobs.Getprevjobid(jobid);
        }

        //this is to populate the selections after the editjobs
        //form has loaded...
        public int[] Getmutitexts(string jobid)
        {
            var cjbs = new MlJobs();
            var tcount = cjbs.Getmutitexts(jobid).Count;
            var tarray = new int[tcount];

            for (int i = 0; i < tcount; i++)
            {
                tarray[i] = Convert.ToInt32(cjbs.Getmutitexts(jobid)[i]);
            }

            return tarray;
        }

        //get job trends
        //get data for browsing categories
        public DataTable Gettrendsbyindustry()
        {
            var cjbs = new MlJobs();
            return cjbs.Gettrendsbyindustry();
        }

        public string Getcurrencyjobform(string jobid)
        {
            var cjbs = new MlJobs();
            return cjbs.Getcurrencyjobform(jobid);
        }
    }
}