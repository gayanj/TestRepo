using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlLoadBalancer
    {
        private readonly PerformanceCounter _theMemCounter = new PerformanceCounter("Memory", "Available MBytes");

        public void Insertintolog(string sip, float uram, float ucpu, float unetworksend, float unetworkrec,
                                  string useragents)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_loadbalancer(ipaddress, ramusage, cpuusage, networksent, networkrec, dtentered, useragent) values(@sip, @uram, @ucpu, @unetworksent,@unetworkrec, @dtentered, @useragents) ;";

                    com.Parameters.Add("@sip", MySqlDbType.VarChar).Value = sip;
                    com.Parameters.Add("@uram", MySqlDbType.Float).Value = uram;
                    com.Parameters.Add("@ucpu", MySqlDbType.Float).Value = ucpu;
                    com.Parameters.Add("@unetworksent", MySqlDbType.Float).Value = unetworksend;
                    com.Parameters.Add("@unetworkrec", MySqlDbType.Float).Value = unetworkrec;
                    com.Parameters.Add("@dtentered", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@useragents", MySqlDbType.VarChar).Value = useragents;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
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
            var instance = performanceCounterCategory.GetInstanceNames()[0]; // 1st NIC !
            var performanceCounterSent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);

            return performanceCounterSent.NextValue();
        }

        public float Getnetworkrecv()
        {
            //checkcode
            var performanceCounterCategory = new PerformanceCounterCategory("Network Interface");
            var instance = performanceCounterCategory.GetInstanceNames()[0]; // 1st NIC !

            var performanceCounterReceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);

            return performanceCounterReceived.NextValue();
        }

        //delete
        public ArrayList Getmachinebl()
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var al = new ArrayList();

            using (connreader)
            {
                var command = new MySqlCommand("SELECT uUsername,uusertype, serverid from users; ", connreader);

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        al.Add(reader.GetString(0));
                        al.Add(reader.GetString(1));
                        al.Add(reader.GetString(2));
                    }
                }
                else
                {
                    return null;
                }
                reader.Close();
            }

            return al;
        }
    }
}