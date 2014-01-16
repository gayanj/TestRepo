using System;
using System.Configuration;
using System.Data;
using Mysqllayer;

namespace Memorylayer
{
    public class MlSearchMain
    {
        public DataTable Getsitesearch(string qry)
        {
            var slc = new SlSearchMain();
            return slc.Getsitesearch(qry);
        }

        //reload
        public void Reloadmcjobstable()
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

            var slsrch = new SlSearchMain();
            clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp7", DateTime.Now.Date);
            clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcclsgetjobtable", slsrch.Mcjobtable());
        }

        public object Mcjobtable()
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

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcclsgetjobtable");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp7"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp7", DateTime.Now.Date);

                    //add to memory array
                    var slsrch = new SlSearchMain();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcclsgetjobtable",
                                     slsrch.Mcjobtable());
                    mrec = slsrch.Mcjobtable();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp7", DateTime.Now.Date);

                //add to memory object
                var slsrch = new SlSearchMain();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcclsgetjobtable", slsrch.Mcjobtable());
                mrec = slsrch.Mcjobtable();
                return mrec;
            }

            //Slsearchclass slsrch = new Slsearchclass();
            //return slsrch.mcjobtable();
        }
    }
}