using System;
using System.Configuration;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlSalaryCalc
    {
        public object Getsals()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e)
            //{
            //    Console.Write(e.Message);
            //}

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetsalscalc");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp13"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp13", DateTime.Now.Date);

                    //add to memory array
                    var clsal = new SlSalaryCalc();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetsalscalc", clsal.Getsals());
                    mrec = clsal.Getsals();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp13", DateTime.Now.Date);

                //add to memory object
                var clsal = new SlSalaryCalc();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetsalscalc", clsal.Getsals());
                mrec = clsal.Getsals();
                return mrec;
            }

            //SlSalaryCalc clsal = new SlSalaryCalc();
            //return clsal.getsals();
        }

        public void Refreshsalaries()
        {
            var mlmem = new MLMemCached();
            mlmem.Revmemc("mcgetsalscalc");
        }

        public DataTable GetSalarys()
        {
            var clsal = new SlSalaryCalc();
            return clsal.GetSalarys();
        }

        public void Addsal(string q1, int q2, double q3, int q4, string q5, string q6, string ips, string q7, string q8)
        {
            var clsal = new SlSalaryCalc();
            clsal.Addsal(q1, q2, q3, q4, q5, q6, ips, q7, q8);
        }
    }
}