using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace Mysqllayer
{
    public class SlResumeBuilder
    {
        //educational details
        public void InsertEducation(string licandidateid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_res_education( licandidateid, rschoolname, rqualification, rstartdate, renddate, rdescription, dtentered) VALUES (@licandidateid, @schoolname, @degree, @startdate, @enddate, @description, @datestamp);";

                    com.Parameters.Add("@licandidateid", MySqlDbType.VarChar).Value = licandidateid;
                    com.Parameters.Add("@schoolname", MySqlDbType.String).Value = school_name;
                    com.Parameters.Add("@degree", MySqlDbType.String).Value = degree_earned;
                    com.Parameters.Add("@startdate", MySqlDbType.Date).Value = start_date;
                    com.Parameters.Add("@enddate", MySqlDbType.Date).Value = end_date;
                    com.Parameters.Add("@description", MySqlDbType.String).Value = description;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void UpdateEducation(int educationid, string school_name, string degree_earned, string start_date, string end_date, string description)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_res_education set rschoolname= @schoolname, rqualification = @degree, rstartdate = @startdate, renddate = @enddate, rdescription = @description, dtupdated = @datestamp where id_res_education = @param1; ";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = educationid;
                    com.Parameters.Add("@schoolname", MySqlDbType.String).Value = school_name;
                    com.Parameters.Add("@degree", MySqlDbType.String).Value = degree_earned;
                    com.Parameters.Add("@startdate", MySqlDbType.Date).Value = start_date;
                    com.Parameters.Add("@enddate", MySqlDbType.Date).Value = end_date;
                    com.Parameters.Add("@description", MySqlDbType.String).Value = description;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable GetEducation(string licandidateid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var selectcmd = new MySqlCommand("select id_res_education, rschoolname, rqualification, rstartdate, renddate from tb_res_education where licandidateid = @param1;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };
            var dt = new DataTable("tb_res_education");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public string[] GetEducationbyId(int educationid)
        {
            var arrayrec = new string[6];
            arrayrec.AsParallel();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select id_res_education, rschoolname, rqualification, rstartdate, renddate, rdescription from tb_res_education where id_res_education = @param1;",
                        connreader);

                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = educationid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString("id_res_education");
                        arrayrec[1] = reader.GetString("rschoolname");
                        arrayrec[2] = reader.GetString("rqualification");
                        arrayrec[3] = reader.GetString("rstartdate");
                        arrayrec[4] = reader.GetString("renddate");
                        arrayrec[5] = reader.GetString("rdescription");
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        public void DeleteEducation(string licandidateid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Delete from tb_res_education where id_res_education = @param1; ";

                    com.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //experience details
        public void InsertExperience(string licandidateid, string companyname, string jobtitle, string start_date, string end_date, string description)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_res_experience( licandidateid, rcompany, rjobtitle, rstartdate, renddate, rdescription, dtentered) VALUES (@licandidateid, @companyname, @jobtitle, @startdate, @enddate, @description, @datestamp);";

                    com.Parameters.Add("@licandidateid", MySqlDbType.VarChar).Value = licandidateid;
                    com.Parameters.Add("@companyname", MySqlDbType.String).Value = companyname;
                    com.Parameters.Add("@jobtitle", MySqlDbType.String).Value = jobtitle;
                    com.Parameters.Add("@startdate", MySqlDbType.Date).Value = start_date;
                    com.Parameters.Add("@enddate", MySqlDbType.Date).Value = end_date;
                    com.Parameters.Add("@description", MySqlDbType.String).Value = description;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void UpdateExperience(int experienceid, string company_name, string jobtitle, string start_date, string end_date, string description)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_res_experience set rcompany= @company, rjobtitle = @jobtitle, rstartdate = @startdate, renddate = @enddate, rdescription = @description, dtupdated = @datestamp where id_res_experience = @param1; ";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = experienceid;
                    com.Parameters.Add("@company", MySqlDbType.String).Value = company_name;
                    com.Parameters.Add("@jobtitle", MySqlDbType.String).Value = jobtitle;
                    com.Parameters.Add("@startdate", MySqlDbType.Date).Value = start_date;
                    com.Parameters.Add("@enddate", MySqlDbType.Date).Value = end_date;
                    com.Parameters.Add("@description", MySqlDbType.String).Value = description;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable GetExperience(string licandidateid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var selectcmd = new MySqlCommand("select id_res_experience, rcompany, rjobtitle, rstartdate, renddate from tb_res_experience where licandidateid = @param1;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };
            var dt = new DataTable("tb_res_experience");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public string[] GetExperiencebyId(int experienceid)
        {
            var arrayrec = new string[6];
            arrayrec.AsParallel();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select id_res_experience, rcompany, rjobtitle, rstartdate, renddate, rdescription from tb_res_experience where id_res_experience = @param1;",
                        connreader);

                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = experienceid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString("id_res_experience");
                        arrayrec[1] = reader.GetString("rcompany");
                        arrayrec[2] = reader.GetString("rjobtitle");
                        arrayrec[3] = reader.GetString("rstartdate");
                        arrayrec[4] = reader.GetString("renddate");
                        arrayrec[5] = reader.GetString("rdescription");
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        public void DeleteExperience(string licandidateid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Delete from tb_res_experience where id_res_experience = @param1; ";

                    com.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //count home page edits
        public int GetSections(string licandidateid, string qry)
        {
            //get profile details
            var stringval = 0;
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand(qry + " @param1; ", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        stringval = reader.GetInt32(0);
                    }
                }

                reader.Close();
            }

            return stringval;

        }

        //profile details
        public string GetProfile(string licandidateid)
        {
            //get profile details
            var stringval = string.Empty;
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT robjective from tb_res_profile where licandidateid = @param1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        stringval = reader.GetString(0);
                    }
                }

                reader.Close();
            }

            return stringval;

        }

        public void InsertProfile(string profile, string licandidateid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_res_profile(robjective, licandidateid, dtentered) VALUES(@robjective, @licandidateid, @datestamp);";

                    com.Parameters.Add("@robjective", MySqlDbType.String).Value = profile;
                    com.Parameters.Add("@licandidateid", MySqlDbType.VarChar).Value = licandidateid;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void UpdateProfile(string profile, string licandidateid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_res_profile set robjective= @profilestr, dtupdated=@datestamp where licandidateid = @param1; ";

                    com.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@profilestr", MySqlDbType.String).Value = profile;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //handle skills
        public void InsertSkills(string skillname, int level, string licandidateid)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (MySqlCommand com = con.CreateCommand())
                {
                    com.CommandType = System.Data.CommandType.Text;
                    com.CommandText = "insert into tb_res_skills (rskillname, rlevel, licandidateid, dtentered) VALUE (@skillname, @level, @licandidateid, @datestamp );";

                    com.Parameters.Add("@licandidateid", MySqlDbType.VarChar).Value = licandidateid;
                    com.Parameters.Add("@skillname", MySqlDbType.String).Value = skillname;
                    com.Parameters.Add("@level", MySqlDbType.Int32).Value = level;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;

                    int reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public ArrayList GetSkills(string licandidateid)
        {
            var tempst = new ArrayList();
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select id_res_skill, rskillname from tb_res_skills where licandidateid = @param1 ;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
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

        public void DeleteSkills(string skillname, int skillid, string licandidateid)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (MySqlCommand com = con.CreateCommand())
                {
                    com.CommandType = System.Data.CommandType.Text;
                    com.CommandText = "delete from tb_res_skills where rskillname = @skillname and id_res_skill=@skillid and licandidateid = @licandidateid ;";

                    com.Parameters.Add("@licandidateid", MySqlDbType.VarChar).Value = licandidateid;
                    com.Parameters.Add("@skillname", MySqlDbType.String).Value = skillname;
                    com.Parameters.Add("@skillid", MySqlDbType.Int32).Value = skillid;

                    int reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public bool SearchSkills(string skillname, string licandidateid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select rskillname from tb_res_skills where rskillname = @param1 and licandidateid = @param2;",
                        connreader);

                command.Parameters.Add("@param1", MySqlDbType.String).Value = skillname;
                command.Parameters.Add("@param2", MySqlDbType.VarChar).Value = licandidateid;

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

        //reference details
        public void InsertReference(string licandidateid, string Firstname, string LastName, int referencetype, string email, string localphone, string mobile, string address)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_res_references( rFirstName, rLastName, rReferenceType, liCandidateid, dtentered, rEmail, rLocalPhone, rMobilePhone, rAddress) VALUES ( @rFirstName, @rLastName, @rReferenceType, @liCandidateid, @datestamp, @rEmail, @rLocalPhone, @rMobilePhone, @rAddress);";

                    com.Parameters.Add("@rFirstName", MySqlDbType.String).Value = Firstname;
                    com.Parameters.Add("@rLastName", MySqlDbType.String).Value = LastName;
                    com.Parameters.Add("@rReferenceType", MySqlDbType.Int16).Value = referencetype;
                    com.Parameters.Add("@liCandidateid", MySqlDbType.VarChar).Value = licandidateid;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@rEmail", MySqlDbType.String).Value = email;
                    com.Parameters.Add("@rLocalPhone", MySqlDbType.String).Value = localphone;
                    com.Parameters.Add("@rMobilePhone", MySqlDbType.String).Value = mobile;
                    com.Parameters.Add("@rAddress", MySqlDbType.String).Value = address;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void UpdateReference(int referenceid, string Firstname, string LastName, int referencetype, string email, string localphone, string mobile, string address)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_res_references set rfirstname = @rFirstName, rlastname = @rLastName, rReferenceType = @rReferenceType, dtupdated = @datestamp, remail = @rEmail, rlocalphone = @rLocalPhone, rmobilephone = @rMobilePhone, rAddress = @rAddress  where id_res_reference = @param1; ";

                    com.Parameters.Add("@param1", MySqlDbType.Int32).Value = referenceid;
                    com.Parameters.Add("@rFirstName", MySqlDbType.String).Value = Firstname;
                    com.Parameters.Add("@rLastName", MySqlDbType.String).Value = LastName;
                    com.Parameters.Add("@rReferenceType", MySqlDbType.Int16).Value = referencetype;
                    com.Parameters.Add("@datestamp", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@rEmail", MySqlDbType.String).Value = email;
                    com.Parameters.Add("@rLocalPhone", MySqlDbType.String).Value = localphone;
                    com.Parameters.Add("@rMobilePhone", MySqlDbType.String).Value = mobile;
                    com.Parameters.Add("@rAddress", MySqlDbType.String).Value = address;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable GetReference(string licandidateid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var selectcmd = new MySqlCommand("select id_res_reference, rFirstName, rlastname from tb_res_references where licandidateid = @param1;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };
            var dt = new DataTable("tb_res_references");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public string[] GetReferencebyId(int referenceid)
        {
            var arrayrec = new string[8];
            arrayrec.AsParallel();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select id_res_reference, rFirstName, rLastName, rReferenceType, rEmail, rLocalPhone, rMobilePhone, rAddress from tb_res_references where id_res_reference = @param1;",
                        connreader);

                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = referenceid;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString("id_res_reference");
                        arrayrec[1] = reader.GetString("rfirstname");
                        arrayrec[2] = reader.GetString("rlastname");
                        arrayrec[3] = reader.GetString("rReferenceType");
                        arrayrec[4] = reader.GetString("rEmail");
                        arrayrec[5] = reader.GetString("rLocalPhone");
                        arrayrec[6] = reader.GetString("rMobilePhone");
                        arrayrec[7] = reader.GetString("rAddress");
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        public void DeleteReference(string licandidateid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "Delete from tb_res_references where id_res_reference = @param1; ";

                    com.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get review data for resume reports

        public DataTable GetResumeData(string licandidateid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            var selectcmd = new MySqlCommand("select id_res_reference, rFirstName, rlastname from tb_res_references where licandidateid = @param1;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = licandidateid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };
            var dt = new DataTable("tb_res_references");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

    }
}
