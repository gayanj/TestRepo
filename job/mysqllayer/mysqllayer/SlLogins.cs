using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlLogins
    {
        //activate accounts for users and recruitersm
        public void UpdateactivateAcc(int uusertype, string uusername, string keytopass)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE USERS SET uActivation = null where uUsername = @username and uusertype = @usertype and uactivation = @keytopas";

                    com.Parameters.Add("@usertype", MySqlDbType.Int16).Value = uusertype;
                    com.Parameters.Add("@username", MySqlDbType.VarChar).Value = uusername;
                    com.Parameters.Add("@keytopas", MySqlDbType.VarChar).Value = keytopass;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get user orginal name for welcome //only for candidates
        public string Getuserwelcomename(string pusername, int uusertype)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var tmphld = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT concat(can.cfirstname,' ',can.clastname)as names FROM candidates can, users usr where can.idcandidates = usr.ucandidateid and usr.uusername = @param1 and usr.uusertype = @param2; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = pusername;
                command.Parameters.Add("@param2", MySqlDbType.Int32).Value = uusertype;

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

        //get employee id ony for employees
        public string Getuserwelcomename(string pusername, int uusertype, string empid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var tmphld = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT concat(ufirstname,' ',ulastname)as names FROM users where uusername = @param1 and uusertype = @param2; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = pusername;
                command.Parameters.Add("@param2", MySqlDbType.Int32).Value = uusertype;

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

        //check the password key against the database
        public string Getkeyuser(string keyids, int utype)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var tmphld = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT upasswordresetcode FROM users where upasswordresetcode = @param1 and uusertype = @param2 ; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = keyids;
                command.Parameters.Add("@param2", MySqlDbType.Int32).Value = utype;

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

        //set seed key for user
        public void Updateuserkey(string uusername, string keys)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE users set uPasswordresetcode = @keys where uUserName= @uusername and uUserType = 2; ";

                    com.Parameters.Add("@keys", MySqlDbType.VarChar).Value = keys;
                    com.Parameters.Add("@uusername", MySqlDbType.VarChar).Value = uusername;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //set seed key for recruiters
        public void Updatereckey(string uusername, string keys)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE users set uPasswordresetcode = @keys where uUserName= @uusername and uUserType = 1; ";

                    com.Parameters.Add("@keys", MySqlDbType.VarChar).Value = keys;
                    com.Parameters.Add("@uusername", MySqlDbType.VarChar).Value = uusername;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //this is admin user
        //1 is admin
        public string Getuser(string userns, string pwds, string md5Hash)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var tmphld = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT uUsername FROM users where upassword = @param2 and uusername= @param1 and uusertype = 1 and uActivation is null; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = userns;
                command.Parameters.Add("@param2", MySqlDbType.VarChar).Value = md5Hash;

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

        //0 this is cms user
        public string Getusercms(string userns, string pwds, string md5Hash)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var tmphld = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT uUsername FROM users where upassword = @param2 and uusername= @param1 and uusertype = 0 and uActivation is null; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = userns;
                command.Parameters.Add("@param2", MySqlDbType.VarChar).Value = md5Hash;

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

        //jobseeker user
        //2 is jobseeker
        public string Getjobuser(string usns, string pwds, string md5Hash)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var pdhash = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT uUsername FROM users where upassword = @param1 and uusername= @param2 and uusertype=2 and uActivation is null; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = md5Hash;
                command.Parameters.Add("@param2", MySqlDbType.VarChar).Value = usns;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pdhash = reader.GetString(0);
                    }
                }
                else
                {
                    return null;
                }
                reader.Close();
            }

            return pdhash;
        }

        //change passwords
        //rec password or admin 1
        public void Updaterecpwd(string uUserName, string pwds, string pwdhsh)
        {
            var hashedpwd = pwdhsh;

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE users set uPassword = @hashedpwd where uUserName= @uUserName and uUserType = 1;";

                    com.Parameters.Add("@uUserName", MySqlDbType.VarChar).Value = uUserName;
                    com.Parameters.Add("@hashedpwd", MySqlDbType.VarChar).Value = hashedpwd;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //jobseeker password or admin 2
        public void Updatejspwd(string uUserName, string pwds, string pwdhsh)
        {
            var hashedpwd = pwdhsh;

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE users set uPassword = @hashedpwd where uUserName= @uUserName and uUserType = 2;";

                    com.Parameters.Add("@uUserName", MySqlDbType.VarChar).Value = uUserName;
                    com.Parameters.Add("@hashedpwd", MySqlDbType.VarChar).Value = hashedpwd;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //change passwords with keys.....
        //change passwords
        //rec password or admin 1
        public void Updatepwdrecwkey(string keyval, string pwds, string phash)
        {
            var hashedpwd = phash;

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE users set uPassword = @hashedpwd where upasswordresetcode= @keyval and uUserType = 1;";

                    com.Parameters.Add("@keyval", MySqlDbType.VarChar).Value = keyval;
                    com.Parameters.Add("@hashedpwd", MySqlDbType.VarChar).Value = hashedpwd;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //jobseeker password or admin 2
        public void Updatepwdjswkey(string keyval, string pwds, string pwdhsh)
        {
            var hashedpwd = pwdhsh;

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE users set uPassword = @hashedpwd where uPasswordresetcode = @keyval and uUserType = 2; ";

                    com.Parameters.Add("@keyval", MySqlDbType.VarChar).Value = keyval;
                    com.Parameters.Add("@hashedpwd", MySqlDbType.VarChar).Value = hashedpwd;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //check if the recruiter exists in the database
        public string Getchkrecusern(string userns)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var plhash = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand("SELECT uUsername FROM users where uusername= @param1 and uusertype = 1; ",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = userns;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        plhash = reader.GetString(0);
                    }
                }
                else
                {
                    return null;
                }
                reader.Close();
            }

            return plhash;
        }

        //check if the candidate exists in the database
        public string Getchkcanusern(string userns)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var plhash = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand("SELECT uUsername FROM users where uusername= @param1 and uusertype = 2; ",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = userns;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        plhash = reader.GetString(0);
                    }
                }
                else
                {
                    return null;
                }
                reader.Close();
            }

            return plhash;
        }

        //check the usertype for the main windows like is it recruiter of single user
        public int Getchkusertype(string uusername, int uusertypes)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var plhash = 0;

            using (connreader)
            {
                var command =
                    new MySqlCommand("SELECT uusertype from users where uusername = @param1 and uusertype= @param2 ; ",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = uusername;
                command.Parameters.Add("@param2", MySqlDbType.Int32).Value = uusertypes;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        plhash = reader.GetInt16(0);
                    }
                }
                reader.Close();
            }

            return plhash;
        }

        //get recruiter forgot password
        public string Getseerecemail(string passeduseremail)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var plhash = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand("select uusername from users where uusertype = 1 and uusername= @param1 ; ",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = passeduseremail;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        plhash = reader.GetString(0);
                    }
                }
                reader.Close();
            }

            return plhash;
        }

        //get user forgot password
        public string Getseeuseremail(string passeduseremail)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var plhash = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand("select uusername from users where uusertype = 2 and uusername= @param1 ; ",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = passeduseremail;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        plhash = reader.GetString(0);
                    }
                }
                reader.Close();
            }

            return plhash;
        }

        //get user id
        public string Getuserid(string pusername)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var plhash = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand("select idusers from users where uusertype = 2 and uusername= @param1 limit 1; ",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = pusername;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        plhash = reader.GetString(0);
                    }
                }
                reader.Close();
            }

            return plhash;
        }
    }
}