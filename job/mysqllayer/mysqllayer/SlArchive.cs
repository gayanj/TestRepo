using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlArchive
    {
        //add to archive
        public void Insertarchives(string uusername, DateTime dtentered, int uusertype, string userdevice, string userip)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_userarchives(uusername, uusertype, logintime, logindate, userdevice, userip) values ( @uusername, @uusertype, @logintime, @logindate, @userdevice, @userip);";

                    com.Parameters.Add("@uusername", MySqlDbType.VarChar).Value = uusername;
                    com.Parameters.Add("@uusertype", MySqlDbType.Int32).Value = uusertype;
                    com.Parameters.Add("@logintime", MySqlDbType.Time).Value = dtentered.TimeOfDay;
                    com.Parameters.Add("@logindate", MySqlDbType.Date).Value = dtentered.Date;
                    com.Parameters.Add("@userdevice", MySqlDbType.VarChar).Value = userdevice;
                    com.Parameters.Add("@userip", MySqlDbType.VarChar).Value = userip;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable Getacsecuritycan(string uusername)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select * from vw_logcandidate where uusername = @param1 order by idtb_userarchives desc limit 5;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = uusername;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_logcandidate");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getacsecurityrec(string uusername)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select * from vw_logrecruiter where uusername = @param1 order by idtb_userarchives desc limit 5;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = uusername;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_logrecruiter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }
    }
}