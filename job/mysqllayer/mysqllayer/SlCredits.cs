using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlCredits
    {
        public void Insertcreditjobposting(string empid, int creditamount, DateTime cstartdate, DateTime cenddate)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_creditjobposting(empid, creditamount, cstartdate, cenddate) values ( @empid, @creditamount, @cstartdate, @cenddate);";

                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;
                    com.Parameters.Add("@creditamount", MySqlDbType.Int32).Value = creditamount;
                    com.Parameters.Add("@cstartdate", MySqlDbType.DateTime).Value = cstartdate;
                    com.Parameters.Add("@cenddate", MySqlDbType.DateTime).Value = cenddate;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get job posting dates
        public int Getcreditjobposting(string empid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select empid from tb_creditjobposting where empid = @employeeid and cenddate >= curdate();",
                        connreader);
                command.Parameters.Add("@employeeid", MySqlDbType.VarChar).Value = empid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }

                reader.Close();
            }

            return ct;
        }

        //update payments
        public void Updatecreditjobposting(string empid, DateTime cstartdate, DateTime cenddate)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_creditjobposting set cstartdate=@cstartdate ,cenddate=@cenddate where empid = @empid;";

                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;
                    com.Parameters.Add("@cstartdate", MySqlDbType.DateTime).Value = cstartdate;
                    com.Parameters.Add("@cenddate", MySqlDbType.DateTime).Value = cenddate;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get empid
        public string Getrccreditempid(string uusername)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select rmap.empid from tb_rec_user_link rmap, users u where rmap.idusers = u.idusers and u.uusername = @username ;",
                        connreader);
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = uusername;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetString(0);
                    }
                }

                reader.Close();
            }

            return ct;
        }

        //check existing recruiter in payment list
        public int Getcrejobposting(string empid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand("select empid from tb_creditjobposting where empid = @empid;", connreader);
                command.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }

                reader.Close();
            }

            return ct;
        }

        //set session for credits
        public void Insertcresessionkey(string empid, string appkey)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_creditsession(empid, appkey, sdtentered) values ( @empid, @appkey, @sdtentered);";

                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;
                    com.Parameters.Add("@appkey", MySqlDbType.VarChar).Value = appkey;
                    com.Parameters.Add("@sdtentered", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get session key for credits
        public string Getcresessionkey(string empid, string appkey)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            string ct = null;

            using (connreader)
            {
                var command =
                    new MySqlCommand("select appkey from tb_creditsession where empid = @empid and appkey = @appkey;",
                                     connreader);
                command.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;
                command.Parameters.Add("@appkey", MySqlDbType.String).Value = appkey;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetString(0);
                    }
                }

                reader.Close();
            }

            return ct;
        }

        public int Getcredaysleft(string empid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "Select DATEDIFF(cenddate,curdate()) from tb_creditjobposting where empid = @empid;", connreader);
                command.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct = reader.GetInt32(0);
                    }
                }

                reader.Close();
            }

            return ct;
        }

        public void Insertcreusermod(string idusers, int reqtype)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_usermoderation(idusers,dtrequested, requesttype) VALUES (@idusers,@dtrequested,@requesttype);";

                    com.Parameters.Add("@idusers", MySqlDbType.VarChar).Value = idusers;
                    com.Parameters.Add("@dtrequested", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@requesttype", MySqlDbType.Int16).Value = reqtype;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}