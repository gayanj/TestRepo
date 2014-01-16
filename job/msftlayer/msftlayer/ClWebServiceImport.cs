using System;
using System.IO;
using System.Linq;
using Memorylayer;

namespace Msftlayer
{
    public class ClWebServiceImport
    {
        private void Insertwebrecruiter(string recruiterName, string address1, string address2, string address3,
                                        string town, string county, string country, string postcode, string emailAddress,
                                        string website, string description, string completeDesc, string pwds)
        {
            var sweb = new MlWebServiceImport();
            sweb.Insertwebrecruiter(recruiterName, address1, address2, address3, town, county, country, postcode,
                                    emailAddress, website, description, completeDesc, pwds);
        }

        private void Insertwebjobs(string title, string shortDescription, string description, string salaryText,
                                   string minSal, string maxSal, string Ref, string freeText, DateTime jobstartdate,
                                   DateTime jobenddate, string location, string recruitername)
        {
            var sweb = new MlWebServiceImport();
            sweb.Insertwebjobs(title, shortDescription, description, salaryText, minSal, maxSal, Ref, freeText,
                               jobstartdate, jobenddate, location, recruitername);
        }

        public bool ProcessRecruiterfile(Stream filepath)
        {
            string[] splitedfile = fileprocessor(filepath);

            long calctotal = splitedfile.LongCount();

            double calcremainder = calctotal % 13;

            if (calcremainder == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool ProcessJobsfile(Stream filepath)
        {
            string[] splitedfile = fileprocessor(filepath);

            float calctotal = 0;

            foreach (string str in splitedfile)
            {
                calctotal++;
            }

            double calcremainder = calctotal % 10;

            if (calcremainder == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private string[] fileprocessor(Stream filepath)
        {
            var sreader = new StreamReader(filepath);

            string filebyte = sreader.ReadToEnd();
            char[] characterseparate = { ',' };
            string[] splittedarr = filebyte.Split(characterseparate, StringSplitOptions.None);

            return splittedarr;
        }
    }
}