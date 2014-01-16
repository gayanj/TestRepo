using System;
using System.Configuration;
using Mysqllayer;

namespace Memorylayer
{
    public class MlMemload
    {
        //replace all the dat afor th e jobs with the memory array intead

        //of the regular system...
        //salary business logic
        private static readonly string SMemkey = ConfigurationManager.AppSettings["sitekey"];


        //hrs
        public object Mlgethrs()
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

            object msal = null;

            msal = clman.Getmemcobj(SMemkey + "mcgethrs1");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgethrs1", clma.Gethours());
                msal = clma.Gethours();
                return msal;
            }
        }

        //contract
        public object Mlgetcontract()
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

            object msal = null;

            msal = clman.Getmemcobj(SMemkey + "mcgetcontract1");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetcontract1", clma.Getcontracts());
                msal = clma.Getcontracts();
                return msal;
            }
        }

        public object Mlgetcareer()
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

            object msal = null;

            msal = clman.Getmemcobj(SMemkey + "mcgetcareer");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetcareer", clma.Getcareerlevel());
                msal = clma.Getcareerlevel();
                return msal;
            }
        }

        public object Mlgeteducation()
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

            object msal = null;

            msal = clman.Getmemcobj(SMemkey + "mcgeteducation");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgeteducation",
                                 clma.Geteducationlevel());
                msal = clma.Geteducationlevel();
                return msal;
            }
        }

        public object Mlgetsalary()
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

            object msal = null;

            msal = clman.Getmemcobj(SMemkey + "mcgetsalary");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetsalary", clma.GetSalary());
                msal = clma.GetSalary();
                return msal;
            }
        }

        //location business logic
        public object Mlgetloc()
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

            object msal = null;
            msal = clman.Getmemcobj(SMemkey + "mcgetloc");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetloc", clma.GetLocations());
                msal = clma.GetLocations();
                return msal;
            }

            //return null;
        }

        //location industry logic
        public object Mlgetind()
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

            object msal = null;
            msal = clman.Getmemcobj(SMemkey + "mcgetind");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetind", clma.GetIndustries());
                msal = clma.GetIndustries();
                return msal;
            }

            //return null;
        }

        //experience logic
        public object Mlgetexp()
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

            object msal = null;
            msal = clman.Getmemcobj(SMemkey + "mcgetexp");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetexp", clma.GetExperience());
                msal = clma.GetExperience();
                return msal;
            }

            //return null;
        }

        //sector logic
        public object Mlgetsect()
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

            object msal = null;
            msal = clman.Getmemcobj(SMemkey + "mcgetsect");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetsect", clma.Getsectors());
                msal = clma.Getsectors();
                return msal;
            }
        }

        //get postcodes
        public object Mlgetpostcode()
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

            object msal = null;
            msal = clman.Getmemcobj(SMemkey + "mcgetpostcode");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetpostcode", clma.Getpostcodes());
                msal = clma.Getpostcodes();
                return msal;
            }
        }

        //get top level categories
        public object MlgetLocationstop()
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

            object msal = null;
            msal = clman.Getmemcobj(SMemkey + "mcgetLocationstop");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetLocationstop",
                                 clma.GetLocationstop());
                msal = clma.GetLocationstop();
                return msal;
            }
        }

        //get top level locations
        public object MlgetIndustriestop()
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

            object msal = null;
            msal = clman.Getmemcobj(SMemkey + "mcgetIndustriesstop");

            if (msal != null)
            {
                return msal;
            }

            else
            {
                var clma = new SlMainPagePopulator();
                clman.Addmemcobj(SMemkey + "mcgetIndustriesstop",
                                 clma.GetIndustriestop());
                msal = clma.GetIndustriestop();
                return msal;
            }
        }
    }
}