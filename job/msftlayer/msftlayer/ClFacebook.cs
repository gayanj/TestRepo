using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memorylayer;
using System.Data;

namespace Msftlayer
{
    public class ClFacebook
    {
        public DataView GetJobs(string title, string location, int low, int high)
        {
            string q = "";

            if (title == null)
            {
                q = " and location like '%" + location + "%' ";
            }

            else if (location == null)
            {
                q = " and match(sfreetext) against ('" + title + "')";
            }

            else
            {
                q = " and match(sfreetext) against ('" + title + "') and slocation like '%" + location + "%' ";
            }

            var f = new MlFacebook();
            var dview = new DataView { Table = (DataTable)f.GetJobs(q, title, location, low, high) };

            return dview;
        }

        public int GetJobsTotal(string title, string location, int low, int high)
        {
            string q = "";

            if (title == null)
            {
                q = " and location like '%" + location + "%' ";
            }

            else if (location == null)
            {
                q = " and match(sfreetext) against ('" + title + "')";
            }

            else
            {
                q = " and match(sfreetext) against ('" + title + "') and slocation like '%" + location + "%' ";
            }

            MlFacebook s = new MlFacebook();
            return s.GetJobsTotal(q, title, location, low, high);
        }

        public DataView GetJobs(int low, int high)
        {
            var f = new MlFacebook();
            var dview = new DataView { Table = (DataTable)f.GetJobs(low, high) };

            return dview;
        }

        public int GetJobsTotal(int low, int high)
        {
            MlFacebook s = new MlFacebook();
            return s.GetJobsTotal(low, high);
        }
    }
}
