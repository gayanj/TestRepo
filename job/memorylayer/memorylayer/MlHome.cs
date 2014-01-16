using System;
using System.Configuration;
using Mysqllayer;

namespace Memorylayer
{
    public class MlHome
    {
        public object Gethplocation()
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

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgloc");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp2"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp2", DateTime.Now.Date);

                    //add to memory array
                    var shome = new SlHome();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgloc", shome.Gethplocation());
                    mrec = shome.Gethplocation();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp2", DateTime.Now.Date);

                //add to memory object
                var shome = new SlHome();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgloc", shome.Gethplocation());
                mrec = shome.Gethplocation();
                return mrec;
            }

            //SlHome clh = new SlHome();
            //return clh.mpgetlocation();
        }

        public object Gethpindustry()
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

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgind");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp3"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp3", DateTime.Now.Date);

                    //add to memory array
                    var shome = new SlHome();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgind", shome.Gethpindustry());
                    mrec = shome.Gethpindustry();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp3", DateTime.Now.Date);

                //add to memory object
                var shome = new SlHome();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgind", shome.Gethpindustry());
                mrec = shome.Gethpindustry();
                return mrec;
            }
        }

        public object Gethpsalary()
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

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgsal");

            if (mrec != null)
            {
                DateTime mcrsststamp =
                    Convert.ToDateTime(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp4"));
                if (mcrsststamp.Date == DateTime.Now.Date)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp4", DateTime.Now.Date);

                    //add to memory array
                    var shome = new SlHome();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgsal", shome.Gethpsalary());
                    mrec = shome.Gethpsalary();
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcdaytstamp4", DateTime.Now.Date);

                //add to memory object
                var shome = new SlHome();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgsal", shome.Gethpsalary());
                mrec = shome.Gethpsalary();
                return mrec;
            }
        }

        public void Reloadgethpsalary()
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

            var clh = new SlHome();
            //clman.revmemc("mchomepgsal");
            clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgsal", clh.Gethpsalary());
        }

        public void Reloadgethpindustry()
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

            var clh = new SlHome();
            //clman.revmemc("mchomepgind");
            clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgind", clh.Gethpindustry());
        }

        public void Reloadgethplocation()
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

            var clh = new SlHome();
            //clman.revmemc("mchomepgloc");
            clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchomepgloc", clh.Gethplocation());
        }
    }
}