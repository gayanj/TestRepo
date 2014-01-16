using System;
using System.Configuration;
using System.Globalization;
using Mysqllayer;

namespace Memorylayer
{
    public class MlVersionControl
    {
        public object Getcurrentversion()
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

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"].ToString(CultureInfo.InvariantCulture) +
                                           "mcgetcurrentversion");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(
                        clman.Getmemcobj(
                            ConfigurationManager.AppSettings["sitekey"].ToString(CultureInfo.InvariantCulture) +
                            "mcdaytstamp11"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(
                        ConfigurationManager.AppSettings["sitekey"].ToString(CultureInfo.InvariantCulture) +
                        "mcdaytstamp11", DateTime.Now.Date);

                    //add to memory array
                    var slver = new SlVersionControl();
                    clman.Addmemcobj(
                        ConfigurationManager.AppSettings["sitekey"].ToString(CultureInfo.InvariantCulture) +
                        "mcgetcurrentversion", slver.Getcurrentversion());
                    mrec =
                        slver.Getcurrentversion();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(
                    ConfigurationManager.AppSettings["sitekey"].ToString(CultureInfo.InvariantCulture) + "mcdaytstamp11",
                    DateTime.Now.Date);

                //add to memory object
                var slver = new SlVersionControl();
                clman.Addmemcobj(
                    ConfigurationManager.AppSettings["sitekey"].ToString(CultureInfo.InvariantCulture) +
                    "mcgetcurrentversion", slver.Getcurrentversion());
                mrec =
                    slver.Getcurrentversion();
                return mrec;
            }

            //Slversionctrl slver = new Slversionctrl();
            //return slver.getcurrentversion();
        }
    }
}