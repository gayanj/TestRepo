using System;
using System.Configuration;
using Mysqllayer;

namespace Memorylayer
{
    public class MlJobFeed
    {
        public string[,] Getrss()
        {
            var clman = new MLMemCached();
            try
            {
                clman.Fireservers();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            string[,] msal = null;
            msal = clman.Getmemcarray(ConfigurationManager.AppSettings["sitekey"] + "mcrss");

            if (msal != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp5"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return msal;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp5", DateTime.Now.Date);

                    //add to memory array
                    var slr = new SlJobFeed();
                    clman.Addmemcarray(ConfigurationManager.AppSettings["sitekey"] + "mcrss", slr.Getrss());
                    msal = slr.Getrss();
                    return msal;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp5", DateTime.Now.Date);

                //add to memory array
                var slr = new SlJobFeed();
                clman.Addmemcarray(ConfigurationManager.AppSettings["sitekey"] + "mcrss", slr.Getrss());
                msal = slr.Getrss();
                return msal;
            }
        }
    }
}