using System;
using System.Configuration;
using System.Diagnostics;
using Mysqllayer;

namespace Memorylayer
{
    public class MlLoadBalancer
    {
        private readonly PerformanceCounter _theMemCounter = new PerformanceCounter("Memory", "Available MBytes");

        //add to memory sessions
        public void Addsessions(int sessionkey)
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

            msal = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcaddsessions");

            if (msal != null)
            {
                // add 1 to memory;
                int tempint = Convert.ToInt32(msal) + 1;
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcaddsessions", tempint);
            }

            else
            {
                msal = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcaddsessions");
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcaddsessions", 1);
            }
        }

        public int Getsessions()
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

            msal = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcaddsessions");

            return Convert.ToInt32(msal);
        }

        public void Removesesions()
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

            msal = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcaddsessions");

            if (msal != null)
            {
                // add 1 to memory;
                int tempint = Convert.ToInt32(msal) - 1;
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcaddsessions", tempint);
            }

            else
            {
                //msal = clman.getmemcobj(System.Configuration.ConfigurationManager.AppSettings["sitekey"].ToString() + "mcaddsessions");
                //clman.addmemcobj(System.Configuration.ConfigurationManager.AppSettings["sitekey"].ToString() + "mcaddsessions", tempint);
            }
        }

        //insert into mysql
        public void Insertintolog(string sip, float uram, float ucpu, float unetworksend, float unetworkrec,
                                  string useragents)
        {
            var cloads = new SlLoadBalancer();
            cloads.Insertintolog(sip, uram, ucpu, unetworksend, unetworkrec, useragents);
        }

        //get cpu
        public float Getcpus()
        {
            var myCounter = new PerformanceCounter { CategoryName = "Processor", CounterName = "% Processor Time", InstanceName = "_Total" };
            return myCounter.RawValue;
        }

        //get ram
        public float Getrams()
        {
            return Convert.ToInt32(_theMemCounter.NextValue());
        }

        //get network use
        public float Getnetworksent()
        {
            //checkcode
            var performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            string instance = performanceCounterCategory.GetInstanceNames()[0]; // 1st NIC !
            var performanceCounterSent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);

            return performanceCounterSent.NextValue();
        }

        public float Getnetworkrecv()
        {
            //checkcode
            var performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            string instance = performanceCounterCategory.GetInstanceNames()[0]; // 1st NIC !

            var performanceCounterReceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);

            return performanceCounterReceived.NextValue();
        }

        public object Getmachinebl()
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

            object mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetmachinebl");

            if (mrec != null)
            {
                int mcrsststamp =
                    Convert.ToInt32(clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp4"));
                if (mcrsststamp == DateTime.Now.Hour)
                {
                    return mrec;
                }
                else
                {
                    //add a time stamp for refreshing memory
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp4", DateTime.Now.Hour);

                    //add to memory array
                    var slbal = new SlLoadBalancer();
                    clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetmachinebl",
                                     slbal.Getmachinebl());
                    mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetmachinebl");
                    return mrec;
                }
            }

            else
            {
                //add a time stamp for refreshing memory
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mchrtstamp4", DateTime.Now.Hour);

                //add to memory object
                var slbal = new SlLoadBalancer();
                clman.Addmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetmachinebl", slbal.Getmachinebl());
                mrec = clman.Getmemcobj(ConfigurationManager.AppSettings["sitekey"] + "mcgetmachinebl");
                return mrec;
            }

            //Slloadbalancer slbal = new Slloadbalancer();
            //return slbal.getmachinebl();
        }
    }
}