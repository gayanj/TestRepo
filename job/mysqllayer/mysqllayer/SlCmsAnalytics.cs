using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Mysqllayer
{
    public class SlCmsAnalytics
    {
        public DataSet GetURLIn()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from vw_analyticurlin limit 10;",
                    mycon);


            mycon.Open();
            myda.Fill(ds, "vw_analyticurlin");
            mycon.Close();

            return ds;
        }

        public DataSet GetURLByCountry()
        {
            var ds = new DataSet();
            var myconstring = SlConnectionString.Makeconn;
            var mycon = new MySqlConnection { ConnectionString = myconstring };

            var myda =
                new MySqlDataAdapter(
                    "select * from vw_analyticurlbycountry limit 10;",
                    mycon);


            mycon.Open();
            myda.Fill(ds, "vw_analyticurlbycountry");
            mycon.Close();

            return ds;
        }

        public void InsertAnalytics(string vid, string vip, string vic, string vicy, string vurl)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO tb_analytictracker(visitorid, visitorip, visitorcity, visitorcountry, entryurl, dtentered) values (@vid, @vip, @vic, @vicy, @vurl, @dtentered);";

                    com.Parameters.Add("@vid", MySqlDbType.VarChar).Value = vid;
                    com.Parameters.Add("@vip", MySqlDbType.VarChar).Value = vip;
                    com.Parameters.Add("@vic", MySqlDbType.VarChar).Value = vic;
                    com.Parameters.Add("@vicy", MySqlDbType.VarChar).Value = vicy;
                    com.Parameters.Add("@vurl", MySqlDbType.VarChar).Value = vurl;
                    com.Parameters.Add("@dtentered", MySqlDbType.DateTime).Value = DateTime.Now;
                    
                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}
