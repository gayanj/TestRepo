using System.Collections;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlJobs
    {
        public DataTable GetArchJobs(string empid)
        {
            var sl = new SlJobs();
            return sl.GetArchJobs(empid);
        }

        public DataTable GetActiveJobs(string empid)
        {
            var sl = new SlJobs();
            return sl.GetActiveJobs(empid);
        }

        public string Getrecjobassignment(string jobid)
        {
            var slj = new SlJobs();
            return slj.Getrecjobassignment(jobid);
        }

        //get postcode array
        public ArrayList Getpostcodesarr(string jobid)
        {
            var slj = new SlJobs();
            return slj.Getpostcodesarr(jobid);
        }

        public ArrayList Getjobidbyname(string jname)
        {
            var slj = new SlJobs();
            return slj.Getjobidbyname(jname);
        }

        public int Getacjobs(string recusername)
        {
            var slj = new SlJobs();
            return slj.Getacjobs(recusername);
        }

        public int Getarcjobs(string recusername)
        {
            var slj = new SlJobs();
            return slj.Getarcjobs(recusername);
        }

        public string Getnextjobid(string jobid)
        {
            var sjobs = new SlJobs();
            return sjobs.Getnextjobid(jobid);
        }

        public string Getprevjobid(string jobid)
        {
            var sjobs = new SlJobs();
            return sjobs.Getprevjobid(jobid);
        }

        public ArrayList Getmutitexts(string jobid)
        {
            var cjbs = new SlJobs();
            return cjbs.Getmutitexts(jobid);
        }

        //get job trends
        //get data for browsing categories
        public DataTable Gettrendsbyindustry()
        {
            var cjbs = new SlJobs();
            return cjbs.Gettrendsbyindustry();
        }

        public string Getcurrencyjobform(string jobid)
        {
            var cjbs = new SlJobs();
            return cjbs.Getcurrencyjobform(jobid);
        }

    }
}