using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlEmailProcessor
    {
        //get recruiter details for jobemails subjects
        public string Getsubdirectapp(string jobid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var sbr = new StringBuilder();

            using (connreader)
            {
                var command = new MySqlCommand("SELECT * from vw_getsubjectemailapps where idjobs = @param1 ; ",
                                               connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sbr.Append(reader.GetString(1));
                        sbr.Append(" / ");
                        sbr.Append(reader.GetString(2));
                    }
                }
                reader.Close();
            }
            return sbr.ToString();
        }

        //this is for processing password change notifications.
        public StringBuilder Getemailpwdnotify(string passwordlink, string uusername)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var sbr = new StringBuilder();

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT eheader, edescription , efooter from tb_emailtemplates where etemplatechkid = 2;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sbr.Append(reader.GetString(0));
                        sbr.Append(uusername);
                        sbr.Append(reader.GetString(1));
                        sbr.Append(passwordlink);
                        sbr.Append(reader.GetString(2));
                    }
                }
                reader.Close();
            }
            return sbr;
        }

        //user activation email
        public StringBuilder Getemailactivateusr(string activationlink, string uusername)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var sbr = new StringBuilder();

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT eheader, edescription , efooter from tb_emailtemplates where etemplatechkid = 3;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sbr.Append(reader.GetString(0));
                        sbr.Append(uusername);
                        sbr.Append(reader.GetString(1));
                        sbr.Append(activationlink);
                        sbr.Append(reader.GetString(2));
                    }
                }
                reader.Close();
            }
            return sbr;
        }

        //register a new template
        public void Insertemailtemplate(string ebody, int etemplatechkid, string etemplatename, string ehead,
                                        string efoot)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_emailtemplates(eTemplateName, edescription, eTemplatechkid, eHeader, eFooter) values (@templatename, @eb1, @eb2, @ehead, @efoot)";

                    com.Parameters.Add("@eb1", MySqlDbType.Text).Value = ebody;
                    com.Parameters.Add("@eb2", MySqlDbType.Int16).Value = etemplatechkid;
                    com.Parameters.Add("@templatename", MySqlDbType.VarChar).Value = etemplatename;
                    com.Parameters.Add("@ehead", MySqlDbType.Text).Value = ehead;
                    com.Parameters.Add("@efoot", MySqlDbType.Text).Value = efoot;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //this is for processing application notifications.
        public StringBuilder Getemaildirapps(int typeofemail, string username)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var sbr = new StringBuilder();

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT eheader, edescription , efooter from tb_emailtemplates where etemplatechkid= @typeofemail ;",
                        connreader);
                command.Parameters.Add("@typeofemail", MySqlDbType.Int32).Value = typeofemail;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sbr.Append(reader.GetString(0));
                        sbr.Append(username);
                        sbr.Append(reader.GetString(1));
                        sbr.Append(reader.GetString(2));
                    }
                }
                reader.Close();
            }
            return sbr;
        }

        //on sucess of application email sent out

        public void Insertappemaildb(string _EAddress, string _ResponseCode, string _Desc, string subject, string body)
        {
            var conn = new MySqlConnection();
            var cmd = new MySqlCommand();

            const string myquerystring = "INSERT INTO tb_emaillog(rEmailaddress, rResponsecode, rInnererror, rdtsent, rsubject, rbody) values (@param1, @param2 ,@param3 , @param4, @param5, @param6)";
            cmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = _EAddress;
            cmd.Parameters.Add("@param2", MySqlDbType.VarChar).Value = _ResponseCode;
            cmd.Parameters.Add("@param3", MySqlDbType.LongText).Value = _Desc;
            cmd.Parameters.Add("@param4", MySqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@param5", MySqlDbType.VarChar).Value = subject;
            cmd.Parameters.Add("@param6", MySqlDbType.LongText).Value = body;

            conn.ConnectionString = SlConnectionString.Makeconn;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = myquerystring;
            var executeNonQuery = cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}