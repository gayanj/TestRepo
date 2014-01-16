using System;
using System.Collections;
using System.Diagnostics;
using Memorylayer;

namespace Msftlayer
{
    public class ClLoadBalancer
    {
        //session manipulation to manage temp load
        public void Addsessions(int sessionkey)
        {
            var mloads = new MlLoadBalancer();
            mloads.Addsessions(sessionkey);
        }

        public int Getsessions()
        {
            var mloads = new MlLoadBalancer();
            return mloads.Getsessions();
        }

        public void Removesesions()
        {
            var mloads = new MlLoadBalancer();
            mloads.Removesesions();
        }

        //insert into mysql
        public void Insertintolog(string sip, float uram, float ucpu, float unetworksend, float unetworkrec,
                                  string useragents)
        {
            var mloads = new MlLoadBalancer();
            mloads.Insertintolog(sip, uram, ucpu, unetworksend, unetworkrec, useragents);
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
            var theMemCounter = new PerformanceCounter("Memory", "Available MBytes");
            return Convert.ToInt32(theMemCounter.NextValue());
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

        public string Getmachinebl(string username)
        {
            var cload = new MlLoadBalancer();
            var al = (ArrayList)cload.Getmachinebl();

            int indx = al.BinarySearch(username);

            if (indx > 0)
            {
                return al[indx - 3].ToString();
            }

            else
            {
                return null;
            }
        }
    }
}