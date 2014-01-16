using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using minGuid;

namespace Mysqllayer
{
    public class SlPrivacy
    {
        public void Insertdefaultpriv(string idcandidate, int policyid)
        {
            var gui = new Minimumguid();

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO privacy(idprivacy, idCandidates, idpolicy) values (@idprivacy, @idcans, @polid );";

                    com.Parameters.Add("@idcans", MySqlDbType.VarChar).Value = idcandidate;
                    com.Parameters.Add("@polid", MySqlDbType.Int32).Value = policyid;
                    com.Parameters.Add("@idprivacy", MySqlDbType.VarChar).Value = gui.MinGuid();

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get policy array count from policy table
        public int Getdefaultcanpol()
        {
            var arrayrec = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("SELECT count(idprivacycandidates) from privacycandidates;", connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec = reader.GetInt32(0);
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        //get candidate id from username
        public string Getcandidattesid(string uname)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT ucandidateid from users where uusername = @param1 and uUserType=2 limit 1 ;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = uname;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec = reader.GetString(0);
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        //look up privacy table
        public int[] Getpollookuparray(string canid, int arraysz)
        {
            var arrayrec = new int[arraysz + 1];
            arrayrec.AsParallel();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var i = 1;

            using (connreader)
            {
                var command = new MySqlCommand("SELECT status from privacy where idcandidates = @param1 ;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = canid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[i] = reader.GetInt32(0);
                        i++;
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        //add privacy for recruiters
        public void Insertrecblock(string empid, string candidateid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_blockedrecruiters(empid, idcandidates) values ( @empid, @candidateid);";

                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;
                    com.Parameters.Add("@candidateid", MySqlDbType.VarChar).Value = candidateid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public bool Getcurrblockedrec(string empid, string candidateid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT * from tb_blockedrecruiters where empid = @param1 and idcandidates = @param2 ;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;
                command.Parameters.Add("@param2", MySqlDbType.VarChar).Value = candidateid;

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

        //get blocked recs
        public DataTable Getlistedrec(string idcandidates)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand("select empid, sRecruitername from vw_getblockedrec where idcandidates = @param1;",
                                 mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = idcandidates;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getblockedrec");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //add privacy for recruiters
        public void Deleterecblock(string empid, string candidateid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "delete from tb_blockedrecruiters where empid = @empid and idcandidates = @canid;";

                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;
                    com.Parameters.Add("@canid", MySqlDbType.VarChar).Value = candidateid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //update privacy settings for the candidate
        public void Updatecanpriv(int idpolicy, string candidateid, bool statuses)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Update privacy set status = @statuses where idcandidates =  @idcans and idpolicy = @polid ;";

                    com.Parameters.Add("@idcans", MySqlDbType.VarChar).Value = candidateid;
                    com.Parameters.Add("@polid", MySqlDbType.Int32).Value = idpolicy;
                    com.Parameters.Add("@statuses", MySqlDbType.Bit).Value = statuses;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public bool Getblockedrecruiter(string empid, string candidateid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select * from tb_blockedrecruiters where empid = @param1 and idcandidates = @param2 ;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;
                command.Parameters.Add("@param2", MySqlDbType.VarChar).Value = candidateid;

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
