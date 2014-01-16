using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlPrivacy
    {
        //deft privacy list
        public void Insertdefaultpriv(string idcandidate, int policyid)
        {
            var clprivate = new SlPrivacy();
            clprivate.Insertdefaultpriv(idcandidate, policyid);
        }

        //get policy array count from policy table
        public int Getdefaultcanpol()
        {
            var clprivate = new SlPrivacy();
            return clprivate.Getdefaultcanpol();
        }

        //get candidate id from username
        public string Getcandidattesid(string uname)
        {
            var clprivate = new SlPrivacy();
            return clprivate.Getcandidattesid(uname);
        }

        //look up privacy table
        public int[] Getpollookuparray(string canid, int arraysz)
        {
            var clprivate = new SlPrivacy();
            return clprivate.Getpollookuparray(canid, arraysz);
        }

        //add privacy for recruiters
        public void Insertrecblock(string empid, string candidateid)
        {
            var clprivate = new SlPrivacy();
            clprivate.Insertrecblock(empid, candidateid);
        }

        public bool Getcurrblockedrec(string empid, string candidateid)
        {
            var clprivate = new SlPrivacy();
            return clprivate.Getcurrblockedrec(empid, candidateid);
        }

        //get blocked recs
        public DataTable Getlistedrec(string idcandidates)
        {
            var clprivate = new SlPrivacy();
            return clprivate.Getlistedrec(idcandidates);
        }

        //add privacy for recruiters
        public void Deleterecblock(string empid, string candidateid)
        {
            var clprivate = new SlPrivacy();
            clprivate.Deleterecblock(empid, candidateid);
        }

        //update privacy settings for the candidate
        public void Updatecanpriv(int idpolicy, string candidateid, bool statuses)
        {
            var clprivate = new SlPrivacy();
            clprivate.Updatecanpriv(idpolicy, candidateid, statuses);
        }

        public bool Getblockedrecruiter(string empid, string candidateid)
        {
            var clprivate = new SlPrivacy();
            return clprivate.Getblockedrecruiter(empid, candidateid);
        }
    }
}