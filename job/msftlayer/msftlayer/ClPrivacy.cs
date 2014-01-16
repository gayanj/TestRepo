using System.Data;
using Memorylayer;

namespace Msftlayer
{
    public class ClPrivacy
    {
        //deft privacy list
        public void Insertdefaultpriv(string idcandidate, int policyid)
        {
            var mlprivate = new MlPrivacy();
            mlprivate.Insertdefaultpriv(idcandidate, policyid);
        }

        //get policy array count from policy table
        public int Getdefaultcanpol()
        {
            var mlprivate = new MlPrivacy();
            return mlprivate.Getdefaultcanpol();
        }

        //get candidate id from username
        public string Getcandidattesid(string uname)
        {
            var mlprivate = new MlPrivacy();
            return mlprivate.Getcandidattesid(uname);
        }

        //look up privacy table
        public int[] Getpollookuparray(string canid, int arraysz)
        {
            var mlprivate = new MlPrivacy();
            return mlprivate.Getpollookuparray(canid, arraysz);
        }

        //add privacy for recruiters
        public void Insertrecblock(string empid, string candidateid)
        {
            var mlprivate = new MlPrivacy();
            mlprivate.Insertrecblock(empid, candidateid);
        }

        public bool Getcurrblockedrec(string empid, string candidateid)
        {
            var mlprivate = new MlPrivacy();
            return mlprivate.Getcurrblockedrec(empid, candidateid);
        }

        //get blocked recs
        public DataTable Getlistedrec(string idcandidates)
        {
            var mlprivate = new MlPrivacy();
            return mlprivate.Getlistedrec(idcandidates);
        }

        //add privacy for recruiters
        public void Deleterecblock(string empid, string candidateid)
        {
            var mlprivate = new MlPrivacy();
            mlprivate.Deleterecblock(empid, candidateid);
        }

        //update privacy settings for the candidate
        public void Updatecanpriv(int idpolicy, string candidateid, bool statuses)
        {
            var mlprivate = new MlPrivacy();
            mlprivate.Updatecanpriv(idpolicy, candidateid, statuses);
        }

        public bool Getblockedrecruiter(string empid, string candidateid)
        {
            var clprivate = new MlPrivacy();
            return clprivate.Getblockedrecruiter(empid, candidateid);
        }
    }
}