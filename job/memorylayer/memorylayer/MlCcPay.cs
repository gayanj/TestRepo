using Mysqllayer;

namespace Memorylayer
{
    public class MlCcPay
    {
        public void Insertcarddata(string empid, string ptransactionid, string pFirstname, string pLastname,
                                   string pAddress1, string pAddress2, string pAddress3, string pTown, string pCounty,
                                   string pPostcode, string pCountry, string pCardtype, int pservicecode)
        {
            var clc = new SlCcPay();
            clc.Insertcarddata(empid, ptransactionid, pFirstname, pLastname, pAddress1, pAddress2, pAddress3, pTown,
                               pCounty, pPostcode, pCountry, pCardtype, pservicecode);
        }
    }
}