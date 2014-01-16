using System;
using System.Data;
using MySql.Data.MySqlClient;
using minGuid;

namespace Mysqllayer
{
    public class SlApps
    {
        //add recruiter views
        public void Insertrecview(string empid, string candidateid, string appid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "insert into tb_recappviews(empid, candidateid, applicationid, dtentered) values(@param1, @param2, @param3, @param4);";

                    com.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;
                    com.Parameters.Add("@param2", MySqlDbType.VarChar).Value = candidateid;
                    com.Parameters.Add("@param3", MySqlDbType.VarChar).Value = appid;
                    com.Parameters.Add("@param4", MySqlDbType.Date).Value = DateTime.Now.Date;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //default candidate documents
        //must add this proc.
        public void Insertmyresumes(string docname, string docurls, string idcan)
        {
            var gui = new Minimumguid();

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_myresumes(documentid, documentname, doc_url, idcandidates) values (@documentid, @docname , @docurl, @idcan );";

                    com.Parameters.Add("@docname", MySqlDbType.VarChar).Value = docname;
                    com.Parameters.Add("@docurl", MySqlDbType.VarChar).Value = docurls;
                    com.Parameters.Add("@idcan", MySqlDbType.VarChar).Value = idcan;
                    com.Parameters.Add("@documentid", MySqlDbType.VarChar).Value = gui.MinGuid();

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Updatemyresumes(string docname, string docurls, string idcan)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "update tb_myresumes set documentname=@docname , doc_url = @docurl where idcandidates = @idcan;";

                    com.Parameters.Add("@docname", MySqlDbType.VarChar).Value = docname;
                    com.Parameters.Add("@docurl", MySqlDbType.VarChar).Value = docurls;
                    com.Parameters.Add("@idcan", MySqlDbType.VarChar).Value = idcan;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public string[] Getmyresumes(string canid)
        {
            var tempst = new string[2];
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "Select documentname, doc_url from tb_myresumes where idcandidates = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = canid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst[0] = reader.GetString(0);
                        tempst[1] = reader.GetString(1);
                    }
                }

                else
                {
                    return null;
                }
                reader.Close();
            }

            return tempst;
        }

        //must add this proc.
        public void Insertapplication(string firstname, string lastname, string profilesummary, string mxdocid,
                                      string aAppEmail)
        {

            var gui = new Minimumguid();

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO Applications(idapplications, dtEntered, aFirstName, aLastName, aProfileSummary, documentID, aApplicationEmail) values (@idapp, @tdate, @firstname , @lastname , @profilesummary , @mxdocid , @aAppEmail);";

                    com.Parameters.Add("@tdate", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
                    com.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                    com.Parameters.Add("@profilesummary", MySqlDbType.LongText).Value = profilesummary;
                    com.Parameters.Add("@mxdocid", MySqlDbType.VarChar).Value = mxdocid;
                    com.Parameters.Add("@aAppEmail", MySqlDbType.VarChar).Value = aAppEmail;
                    com.Parameters.Add("@idapp", MySqlDbType.VarChar).Value = gui.MinGuid();

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Insertapplicationcan(string idapplications, string licandidateid, string firstname, string lastname, string profilesummary,
                                       string mxdocid, string aAppEmail)
        {

            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO Applications(idapplications, licandidateid, dtEntered, aFirstName, aLastName, aProfileSummary, documentID, aApplicationEmail) values (@idapp, @licandidateid, @tdate, @firstname , @lastname , @profilesummary , @mxdocid , @aAppEmail);";

                    com.Parameters.Add("@tdate", MySqlDbType.Date).Value = DateTime.Now.Date;
                    com.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
                    com.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                    com.Parameters.Add("@profilesummary", MySqlDbType.VarChar).Value = profilesummary;
                    com.Parameters.Add("@mxdocid", MySqlDbType.VarChar).Value = mxdocid;
                    com.Parameters.Add("@aAppEmail", MySqlDbType.VarChar).Value = aAppEmail;
                    com.Parameters.Add("@licandidateid", MySqlDbType.VarChar).Value = licandidateid;
                    com.Parameters.Add("@idapp", MySqlDbType.VarChar).Value = idapplications;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //must add this proc.
        public void Insertapplicationmapping(string jobid, string applicationid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_appjobmapper(idapplications, idjobs) values (@applicationid , @jobid );";

                    com.Parameters.Add("@applicationid", MySqlDbType.VarChar).Value = applicationid;
                    com.Parameters.Add("@jobid", MySqlDbType.VarChar).Value = jobid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //add document
        public void Insertdocuments(string documentname, string docUrl)
        {
            var gui = new Minimumguid();

            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO documents(documentid, documentname,doc_url) values (@documentid, @documentname, @doc_url);";

                    com.Parameters.Add("@documentname", MySqlDbType.VarChar).Value = documentname;
                    com.Parameters.Add("@doc_url", MySqlDbType.VarChar).Value = docUrl;
                    com.Parameters.Add("@documentid", MySqlDbType.VarChar).Value = gui.MinGuid();

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable Getapplication(string applicationname)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select idapplications, appstatus, idstatus, aFirstname, aLastname, stitle, dtentered, aprofilesummary, completeurl from vw_getapp where empid=@param1",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = applicationname;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getapp");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get application views from recuiters
        public string[] Getappviewsrec(string canid)
        {
            //store rec details
            var tempst = new string[3];

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT idapplications, licandidateid, empid FROM vw_getapp where licandidateid != '' and licandidateid = ;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst[0] = reader.GetString(0);
                    }
                }

                else
                {
                    reader.Close();
                    return null;
                }

                reader.Close();
            }

            connreader.Close();
            return tempst;
        }

        //total job applications made by candidate
        public string Getcanjobapptotal(string canid)
        {
            //store rec details
            var val = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT count(idapplications) as totalapps FROM vw_getapp where licandidateid != '' and licandidateid = @param1 group by licandidateid;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = canid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val = reader.GetString(0);
                    }
                }

                reader.Close();
            }
            return val;
        }

        //get get application details for JS
        public string[] Getapplicationdetails(string applyid)
        {
            //store rec details
            var tempst = new string[2];

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select idapplications, aprofilesummary, completeurl from vw_getapp where idapplications = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = applyid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst[0] = reader.GetString(1);
                        tempst[1] = reader.GetString(2);
                    }
                }

                else
                {
                    return null;
                }
                reader.Close();
            }

            return tempst;
        }

        //update app status
        public void UpdateAppStatuses(string idapp, int statusid)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "UPDATE applications SET aapplicationstatus = @param1 where idapplications = @param2;";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = statusid;
                    com.Parameters.Add("@param2", MySqlDbType.VarChar).Value = idapp;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

    }
}