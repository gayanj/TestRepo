using System;
using System.Configuration;
using Mysqllayer;

namespace Memorylayer
{
    public class MlSiteprefs
    {
        public string Getsitepref()
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

            string mrec = clman.Getmemcstr(ConfigurationManager.AppSettings["sitekey"] + "mcgetsitepref");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp12"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp12", DateTime.Now.Date);

                    //add to memory array
                    var slpref = new SlSitePrefs();
                    clman.Addmemcstr(ConfigurationManager.AppSettings["sitekey"] + "mcgetsitepref", slpref.Getsitepref());
                    mrec = slpref.Getsitepref();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp12", DateTime.Now.Date);

                //add to memory object
                var slpref = new SlSitePrefs();
                clman.Addmemcstr(ConfigurationManager.AppSettings["sitekey"] + "mcgetsitepref", slpref.Getsitepref());
                mrec = slpref.Getsitepref();
                return mrec;
            }

            //Slsitepreferences slpref = new Slsitepreferences();
            //return slpref.getsitepref();
        }
    }
}