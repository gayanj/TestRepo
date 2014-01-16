using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlSpamFilter
    {
        public void Addspamrec(int spamid, string spamreason, string remaddr, string usragnt, string jobid)
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
                        "INSERT INTO tb_spamreport(spamindex, spamreason, dtentered, ipuser, useragents, jobid) values ( @spamid, @spamreason, @spamdates, @ipusr, @useragents, @pageid);";

                    com.Parameters.Add("@spamid", MySqlDbType.Int32).Value = spamid;
                    com.Parameters.Add("@spamreason", MySqlDbType.VarChar).Value = spamreason;
                    com.Parameters.Add("@spamdates", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@ipusr", MySqlDbType.VarChar).Value = remaddr;
                    com.Parameters.Add("@useragents", MySqlDbType.VarChar).Value = usragnt;
                    com.Parameters.Add("@pageid", MySqlDbType.VarChar).Value = jobid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}