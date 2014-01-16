using System;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlHistory
    {
        //this is saved jobs
        public void Insertsavedjobs(string userid, string jobid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_savedjobs(idusers, idjobs, dtentered) values ( @idusers, @idjobs, @dtentered);";

                    com.Parameters.Add("@idusers", MySqlDbType.VarChar).Value = userid;
                    com.Parameters.Add("@idjobs", MySqlDbType.VarChar).Value = jobid;
                    com.Parameters.Add("@dtentered", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get saved jobs
        public DataTable Getsavedjobs(string idusers)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            mycon.Open();

            var selectcmd = new MySqlCommand("SELECT * from vw_getsavedjobs where uid = @param1;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = idusers;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_savedjobs");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }

        //this is users saved searches
        public void Insertsavedsearch(string userid, string search, string ipaddr, string searchname)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_savedsearches(userid, searchtext, userip, dtentered, sdefinition) values ( @userid, @searchtext, @ipaddr, @dtentered, @searchname);";

                    com.Parameters.Add("@userid", MySqlDbType.VarChar).Value = userid;
                    com.Parameters.Add("@searchtext", MySqlDbType.String).Value = search;
                    com.Parameters.Add("@ipaddr", MySqlDbType.VarChar).Value = ipaddr;
                    com.Parameters.Add("@dtentered", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@searchname", MySqlDbType.String).Value = searchname;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //this adds history from public search
        public void Inserthistorytext(string userip, string historytext)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO tb_searchhistory(userip, searchtext) values ( @uip, @stext);";

                    com.Parameters.Add("@uip", MySqlDbType.String).Value = userip;
                    com.Parameters.Add("@stext", MySqlDbType.VarChar).Value = historytext;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get saved search
        public DataTable Getsavedsearch(string idusers)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            mycon.Open();

            var selectcmd =
                new MySqlCommand(
                    "SELECT id_savedsearches as sid, searchtext, sdefinition, dtentered  from tb_savedsearches where userid = @param1 limit 500;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = idusers;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_savedsearches");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }

        //get search out
        public string Getsavedsearchout(int idsearch)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var tmphld = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand("SELECT search from tb_savedsearches where id_savedsearches= @param1 limit 1;",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = idsearch;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tmphld = reader.GetString(0);
                    }
                }
                else
                {
                    return null;
                }
                reader.Close();
            }

            return tmphld;
        }

        //get saved job to compare
        public ArrayList Getarraysavedjobs(string uid)
        {
            //store rec details
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select idjobs from vw_getsavedjobs where uid = @param1;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = uid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                    }
                }

                else
                {
                    reader.Close();
                    return null;
                }

                reader.Close();
            }

            tempst.TrimToSize();

            connreader.Close();
            return tempst;
        }
    }
}