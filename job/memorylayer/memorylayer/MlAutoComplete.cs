using System;
using System.Configuration;
using Mysqllayer;

namespace Memorylayer
{
    public class MlAutoComplete
    {
        public void Reloadgetsearchjobcp()
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

            clman.Revmemc("mcsearchjobcp");
        }

        public void Reloadgetsearchreccp()
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

            clman.Revmemc("mcsearchreccp");
        }

        public object Getsearchjobcp()
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

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcsearchjobcp");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp9"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp9", DateTime.Now.Date);

                    //add to memory array
                    var slat = new SlAutoComplete();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcsearchjobcp",
                                     slat.Getsearchjobcp());
                    mrec = slat.Getsearchjobcp();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp9", DateTime.Now.Date);

                //add to memory object
                var slat = new SlAutoComplete();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcsearchjobcp", slat.Getsearchjobcp());
                mrec = slat.Getsearchjobcp();
                return mrec;
            }

            //SLAutocomplete slat = new SLAutocomplete();
            //return slat.getsearchjobcp();
        }

        public object Getsearchreccp()
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

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcsearchreccp");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp11"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp11", DateTime.Now.Date);

                    //add to memory array
                    var slat = new SlAutoComplete();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcsearchreccp",
                                     slat.Getsearchreccp());
                    mrec = slat.Getsearchreccp();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp11", DateTime.Now.Date);

                //add to memory object
                var slat = new SlAutoComplete();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcsearchreccp", slat.Getsearchreccp());
                mrec = slat.Getsearchreccp();
                return mrec;
            }

            //SLAutocomplete slat = new SLAutocomplete();
            //return slat.getsearchreccp();
        }
    }
}