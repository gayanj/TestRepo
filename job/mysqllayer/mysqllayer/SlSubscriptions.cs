using System.Data;
using MySql.Data.MySqlClient;
using System;

namespace Mysqllayer
{
    public class SlSubscriptions
    {
        public void Addsubscriptions(string emailaddr, int catid, int subcatid)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_subscriptions(emailaddress, catid, subcatid) values ( @emailaddr, @catid, @subcatid );";

                    com.Parameters.Add("@emailaddr", MySqlDbType.VarChar).Value = emailaddr;
                    com.Parameters.Add("@catid", MySqlDbType.Int32).Value = catid;
                    com.Parameters.Add("@subcatid", MySqlDbType.Int32).Value = subcatid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Addsubscriptionpref(string emailaddr, int stype, int sfreq)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_subscriptionpref ( `tb_subscriptionpref`.`eemailaddress`, `tb_subscriptionpref`.`eemailtype`, `tb_subscriptionpref`.`einterval`) values ( @emailaddr, @stype, @sfreq );";

                    com.Parameters.Add("@emailaddr", MySqlDbType.VarChar).Value = emailaddr;
                    com.Parameters.Add("@stype", MySqlDbType.Int32).Value = stype;
                    com.Parameters.Add("@sfreq", MySqlDbType.Int32).Value = sfreq;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
                
        public void Unsubscribe(string emailaddress)
        {
            //add to unsubscribe table
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = @"INSERT INTO tb_emailunsubscribe ( eemailaddress, dtentered) VALUES (@param1, @datestamp);";

                    com.Parameters.Add("@param1", MySqlDbType.String).Value = emailaddress;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public bool GetUnsubscriberId(string emailadress)
        {
            //store rec details
            //var val = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =  new MySqlCommand("select id_email from tb_emailunsubscribe where eemailaddress = @param1;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.String).Value = emailadress;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return true;
                    }
                }

                reader.Close();
            }

            return false;
        }
    }
}