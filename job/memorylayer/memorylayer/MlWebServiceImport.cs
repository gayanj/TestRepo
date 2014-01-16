using System;
using Mysqllayer;

namespace Memorylayer
{
    public class MlWebServiceImport
    {
        public void Insertwebrecruiter(string recruiterName, string address1, string address2, string address3,
                                       string town, string county, string country, string postcode, string emailAddress,
                                       string website, string description, string completeDesc, string pwds)
        {
            var sweb = new SlWebServiceImport();
            sweb.Insertwebrecruiter(recruiterName, address1, address2, address3, town, county, country, postcode,
                                    emailAddress, website, description, completeDesc, pwds);
        }

        public void Insertwebjobs(string title, string shortDescription, string description, string salaryText,
                                  string minSal, string maxSal, string Ref, string freeText, DateTime jobstartdate,
                                  DateTime jobenddate, string location, string recruitername)
        {
            var sweb = new SlWebServiceImport();
            sweb.Insertwebjobs(title, shortDescription, description, salaryText, minSal, maxSal, Ref, freeText,
                               jobstartdate, jobenddate, location, recruitername);
        }
    }
}