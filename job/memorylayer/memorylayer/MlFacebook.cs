using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mysqllayer;
using System.Data;

namespace Memorylayer
{
    public class MlFacebook
    {
        public DataTable GetJobs(string q, string title, string location, int low, int high)
        {
            SlFacebook s = new SlFacebook();
            return s.GetJobs(q, low, high);
        }

        public int GetJobsTotal(string q, string title, string location, int low, int high)
        {
            SlFacebook s = new SlFacebook();
            return s.GetJobsTotal(q, low, high);
        }

        public DataTable GetJobs(int low, int high)
        {
            SlFacebook s = new SlFacebook();
            return s.GetJobs(low, high);
        }

        public int GetJobsTotal(int low, int high)
        {
            SlFacebook s = new SlFacebook();
            return s.GetJobsTotal(low, high);
        }
    }
}
