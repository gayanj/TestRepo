using System;
using System.Collections;
using System.Configuration;
using Mysqllayer;

namespace Memorylayer
{
    public class MlAdverts
    {
        //get all adverts realing to string litral

        public ArrayList Getmasterpagesiteads()
        {
            var sladv = new SlAdverts();
            return sladv.Getmasterpagesiteads();
        }

        public ArrayList Getmicrologinads()
        {
            var sladv = new SlAdverts();
            return sladv.Getmicrologinads();
        }

        public ArrayList Getstockbarads()
        {
            var sladv = new SlAdverts();
            return sladv.Getstockbarads();
        }

        public object Getadvertstring()
        {
            var clman = new MLMemCached();
            //try
            //{
            //    clman.Fireservers();
            //}
            //catch (Exception e1)
            //{
            //    Console.Write(e1.Message);
            //}

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetadvertstring");

            if (mrec != null)
            {
                var mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp10"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }

                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp10", DateTime.Now.Date);

                    //add to memory array
                    var mladvert = new SlAdverts();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetadvertstring",
                                     mladvert.Getadvertstring());
                    mrec = mladvert.Getadvertstring();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp10", DateTime.Now.Date);

                //add to memory object
                var mladvert = new SlAdverts();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetadvertstring",
                                 mladvert.Getadvertstring());
                //mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetadvertstring");
                mrec = mladvert.Getadvertstring();
                return mrec;
            }

            //return Mladvert.getadvertstring();

            //return tempst;
        }

        public ArrayList Getjobtextadverts()
        {
            var sladv = new SlAdverts();
            return sladv.Getjobtextadverts();
        }

        public string[] Getdesktoptadstr()
        {
            var sladv = new SlAdverts();
            return sladv.Getdesktoptadstr();
        }
    }
}