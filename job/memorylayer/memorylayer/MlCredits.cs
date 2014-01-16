using System;
using Mysqllayer;

namespace Memorylayer
{
    public class MlCredits
    {
        public void Insertcresessionkey(string empid, string appkey)
        {
            var slcre = new SlCredits();
            slcre.Insertcresessionkey(empid, appkey);
        }

        public string Getcresessionkey(string empid, string appkey)
        {
            var slcre = new SlCredits();
            return slcre.Getcresessionkey(empid, appkey);
        }

        public void Updatecreditjobposting(string empid, DateTime cstartdate, DateTime cenddate)
        {
            var slcre = new SlCredits();
            slcre.Updatecreditjobposting(empid, cstartdate, cenddate);
        }

        public int Getcrejobposting(string empid)
        {
            var slcre = new SlCredits();
            return slcre.Getcrejobposting(empid);
        }

        public void Insertcreditjobposting(string empid, int creditamount, DateTime cstartdate, DateTime cenddate)
        {
            var slcre = new SlCredits();
            slcre.Insertcreditjobposting(empid, creditamount, cstartdate, cenddate);
        }

        public int Getcreditjobposting(string empid)
        {
            var slcre = new SlCredits();
            return slcre.Getcreditjobposting(empid);
        }

        public string Getrccreditempid(string uusername)
        {
            var slcre = new SlCredits();
            return slcre.Getrccreditempid(uusername);
        }

        public int Getcredaysleft(string empid)
        {
            var slcre = new SlCredits();
            return slcre.Getcredaysleft(empid);
        }

        public void Insertcreusermod(string idusers, int reqtype)
        {
            var slcre = new SlCredits();
            slcre.Insertcreusermod(idusers, reqtype);
        }
    }
}