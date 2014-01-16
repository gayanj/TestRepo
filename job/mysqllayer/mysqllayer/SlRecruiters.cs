using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlRecruiters
    {
        public string[] Getrecbyidstrarr(string recname)
        {
            var arrayrec = new string[5];

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select r.srecruitername, r.sdescription, r.swebsite, r.scountry,a.artifact_data from recruiters r, tb_artifacts a where r.sartifactid = a.sartifactid and r.empid = @param1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = recname;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString(0);
                        arrayrec[1] = reader.GetString(1);
                        arrayrec[2] = reader.GetString(2);
                        arrayrec[3] = reader.GetString(3);
                        arrayrec[4] = reader.GetString(4);
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        public DataTable Getrecwithjobs(string empid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select `vw_jobbyrec`.`idjobs`, `vw_jobbyrec`.`empid`,`vw_jobbyrec`.`ssalarytext`, `vw_jobbyrec`.`stitle`, `vw_jobbyrec`.`sshortdescription`, `vw_jobbyrec`.`dtentereddate`, `vw_jobbyrec`.`srecruitername`,slocation from vw_jobbyrec where  `vw_jobbyrec`.`empid` = @param1;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_jobbyrec");
            selectdataadp.Fill(dt);
            mycon.Close();

            return dt;
        }

        //get recruiter company
        public string Getcompanybyrec(string empid)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("SELECT sRecruiterName from recruiters where Empid = @param1 limit 1;",
                                               connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;
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

        //get recid for blocking
        public string Getrecid(string recname)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("SELECT empid from recruiters where sRecruiterName = @param1 limit 1;",
                                               connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = recname;
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

        public string GetRecbyUserName(string recname)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand(@"select r.empid from users u, recruiters r, tb_rec_user_link ul
                                                    where u.idusers = ul.idusers and ul.empid = r.empid and  u.uusertype = 1 and  u.uusername = @param1; ", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = recname;
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

        public DataTable RecUsers(string userns)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select usr.uUsername,usr.uFirstName, usr.uLastName,usr.uIsPrimary,usr.idUsers from recruiters rec, tb_rec_user_link rmap, users usr where rec.EmpID  = rmap.EmpID and rmap.idUsers = usr.idUsers and usr.uUsername = @param1 limit 1;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = userns;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("users");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get all recruiters w jobs
        public DataTable Getallrecwithjobs()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_getallrec order by srecruitername;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getallrec");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getallagentswithjobs()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_getallrec  where sisagent=1 order by srecruitername;",
                                             mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getallrec");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getalldirectrecwithjobs()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_getallrec where sisagent=0 order by srecruitername ;",
                                             mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getallrec");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getallagentswithjobs(string qry)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select * from vw_getallrec where sisagent=1 and sRecruiterName like @param1 order by srecruitername;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.String).Value = "%" + qry + "%";

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getallrec");
            selectdataadp.Fill(dt);
            mycon.Close();

            return dt;
        }

        public DataTable Getalldirectrecwithjobs(string qry)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select * from vw_getallrec where sisagent=0 and sRecruiterName like @param1 order by srecruitername;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.String).Value = "%" + qry + "%";

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getallrec");
            selectdataadp.Fill(dt);
            mycon.Close();

            return dt;
        }

        public DataTable Getallrecwithjobsfiltered(string criteria)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select * from vw_getallrec where sRecruiterName like @param1 order by srecruitername;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.String).Value = "%" + criteria + "%";

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getallrec");
            selectdataadp.Fill(dt);
            mycon.Close();

            return dt;
        }

        //get one rec detail with recid
        public ArrayList Getcurrrecwithempid(string empid)
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select artifact_data, srecruitername ,sdescription, sCompleteDesc, sWebsite, sEmailAddress from vw_getallrec where empid = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
                        tempst.Add(reader.GetString(3));
                        tempst.Add(reader.GetString(4));
                        tempst.Add(reader.GetString(5));
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

        //get contact person details page
        public string Contactperson(string jobid)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT concat_ws(' ',uFirstname,' ',uLastName) from vw_recusers where idjobs = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
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

        //update recuser with id = 1;
        public void Runrecuserupdate(string fname, string lname, string uusername)
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
                        "Update users set uFirstName = @fname , uLastName = @lname where uUserName = @uusername and uUserType=1;";

                    com.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                    com.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                    com.Parameters.Add("@uusername", MySqlDbType.VarChar).Value = uusername;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //logo update for recruiters with id = 1;
        public void Runreclogoupdate(string artifactData, string artifactname, string uusername)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_artifacts arc, recruiters rec, tb_rec_user_link rmap, users usr SET arc.artifact_data = @artifact_data, arc.artifactname=@artifactname where arc.sartifactid = rec.sartifactid and rmap.empid = rec.empid and rmap.idusers = usr.idusers and usr.uusername = @uusername and usr.uUserType = 1;";

                    com.Parameters.Add("@artifact_data", MySqlDbType.VarChar).Value = artifactData;
                    com.Parameters.Add("@artifactname", MySqlDbType.VarChar).Value = artifactname;
                    com.Parameters.Add("@uusername", MySqlDbType.VarChar).Value = uusername;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //update recruiter table information
        public void Runrectableupdate(string add1, string add2, string add3, string town, string county, string postcode,
                                      string compname, string compwebsite, string companyintro, string businessdetail,
                                      string uusername, bool businesstype)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "update recruiters rec, users usr, tb_rec_user_link rmap set rec.sRecruiterName =@compname , rec.sAddress1= @add1 , rec.sAddress2= @add2 , rec.sAddress3= @add3 , rec.sTown= @town , rec.sCounty= @county , rec.sPostcode= @postcode  ,rec.sWebsite= @compwebsite ,rec.sDescription= @companyintro ,rec.sCompletedesc= @businessdetail, rec.sIsAgent=@businesstype where  rec.empid = rmap.empid and rmap.idusers = usr.idusers and usr.uusername = @uusername and usr.uUserType = 1;";

                    com.Parameters.Add("@compname", MySqlDbType.VarChar).Value = compname;
                    com.Parameters.Add("@add1", MySqlDbType.VarChar).Value = add1;
                    com.Parameters.Add("@add2", MySqlDbType.VarChar).Value = add2;
                    com.Parameters.Add("@add3", MySqlDbType.VarChar).Value = add3;
                    com.Parameters.Add("@businesstype", MySqlDbType.Bit).Value = businesstype;
                    com.Parameters.Add("@town", MySqlDbType.VarChar).Value = town;
                    com.Parameters.Add("@county", MySqlDbType.VarChar).Value = county;
                    com.Parameters.Add("@postcode", MySqlDbType.VarChar).Value = postcode;
                    com.Parameters.Add("@compwebsite", MySqlDbType.VarChar).Value = compwebsite;
                    com.Parameters.Add("@companyintro", MySqlDbType.VarChar).Value = companyintro;
                    com.Parameters.Add("@businessdetail", MySqlDbType.VarChar).Value = businessdetail;
                    com.Parameters.Add("@uusername", MySqlDbType.VarChar).Value = uusername;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get artifact id to update the logo
        public string Getartifactids(string uusername)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT sartifactid from recruiters rec, tb_rec_user_link rmap, users usr where rec.empid = rmap.empid and rmap.idusers = usr.idusers and usr.uusername = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = uusername;

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

        //move to cms
        public DataTable GetAllRecs()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select empid, srecruitername from recruiters;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("recruiters");
            selectdataadp.Fill(dt);
            mycon.Close();

            return dt;
        }

    }
}