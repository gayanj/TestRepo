using Mysqllayer;

namespace Memorylayer
{
    public class MlCandidates
    {
        public string Getcanidbyappid(string appid)
        {
            var slc = new SlCandidates();
            return slc.Getcanidbyappid(appid);
        }

        public void Updatecandidatetable(string cfirstname, string clastname, string address1, string address2,
                                         string address3, string town, string county, string country, string postcode,
                                         string hometel, string worktel, string uusername)
        {
            var clcan = new SlCandidates();
            clcan.Updatecandidatetable(cfirstname, clastname, address1, address2, address3, town, county, country,
                                       postcode, hometel, worktel, uusername);
        }

        //user to get direct applications for candidates who have registered as can.
        public string[] Getcandidatesindb(string uusername)
        {
            var clcan = new SlCandidates();
            return clcan.Getcandidatesindb(uusername);
        }
    }
}