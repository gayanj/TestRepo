using System;
using Memorylayer;

namespace Msftlayer
{
    public class ClCredits
    {
        public void Insertcresessionkey(string empid, string appkey)
        {
            var slcre = new MlCredits();
            slcre.Insertcresessionkey(empid, appkey);
        }

        public string Getcresessionkey(string empid, string appkey)
        {
            var slcre = new MlCredits();
            return slcre.Getcresessionkey(empid, appkey);
        }

        public void Updatecreditjobposting(string empid, DateTime cstartdate, DateTime cenddate)
        {
            var slcre = new MlCredits();
            slcre.Updatecreditjobposting(empid, cstartdate, cenddate);
        }

        public int Getcrejobposting(string empid)
        {
            var mlcre = new MlCredits();
            return mlcre.Getcrejobposting(empid);
        }

        public void Insertcreditjobposting(string empid, int creditamount, DateTime cstartdate, DateTime cenddate)
        {
            var slcre = new MlCredits();
            slcre.Insertcreditjobposting(empid, creditamount, cstartdate, cenddate);
        }

        public int Getcreditjobposting(string empid)
        {
            var slcre = new MlCredits();
            return slcre.Getcreditjobposting(empid);
        }

        public string Getrccreditempid(string uusername)
        {
            var slcre = new MlCredits();
            return slcre.Getrccreditempid(uusername);
        }

        public int Getcredaysleft(string empid)
        {
            var slcre = new MlCredits();
            if (slcre.Getcredaysleft(empid) > 0)
            {
                return slcre.Getcredaysleft(empid);
            }

            else
            {
                return 0;
            }
        }

        public void Insertcreusermod(string idusers, int reqtype)
        {
            var slcre = new MlCredits();
            slcre.Insertcreusermod(idusers, reqtype);
        }
    }
}