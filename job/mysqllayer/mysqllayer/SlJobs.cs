using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlJobs
    {
        //get postcode array
        public ArrayList Getpostcodesarr(string jobid)
        {
            var arrayrec = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("SELECT spostcode FROM jobs WHERE idjobs = @param1; ", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                connreader.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec.Add(reader.GetString(0));
                    }
                }

                else
                {
                    return null;
                }
                reader.Close();
            }

            return arrayrec;
        }

        //next button
        public string Getnextjobid(string jobid)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT idjobs FROM jobs WHERE jobno > @param1 and sjobenddate >= curdate() order by dtentered LIMIT 1; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec = reader.GetString("idjobs");
                    }
                }

                reader.Close();
            }

            return arrayrec;
        }

        //back button
        public string Getprevjobid(string jobid)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT idjobs FROM jobs WHERE jobno < @param1 and sjobenddate >= curdate() order by dtentered desc LIMIT 1; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec = reader.GetString("idjobs");
                    }
                }

                reader.Close();
            }

            return arrayrec;
        }

        //get active jobs by rec
        public int Getacjobs(string empid)
        {
            var arrayrec = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand(@"select count(*) as total from jobs j, recruiters r, jobtable jt
                                            where j.idjobs = jt.idjobs and jt.empid = r.empid and jt.catid = 10000 and j.sactive = 1 and r.empid=@param1 ;",
                                               connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec = reader.GetInt32("total");
                    }
                }

                else
                {
                    return 0;
                }
                reader.Close();
            }

            return arrayrec;
        }

        public DataTable GetArchJobs(string empid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand(@"select j.idjobs, j.stitle, j.dtentereddate, j.ssalarytext, j.sShortDescription from jobs j, recruiters r, jobtable jt
                                                where j.idjobs = jt.idjobs and jt.empid = r.empid and  jt.catid = 10000 and  j.sactive = 0 and r.empid = @param1 ; ", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable GetActiveJobs(string empid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand(@"select j.idjobs, j.stitle, j.dtentereddate, j.ssalarytext, j.sShortDescription from jobs j, recruiters r, jobtable jt
                                                where j.idjobs = jt.idjobs and jt.empid = r.empid and  jt.catid = 10000 and  j.sactive = 1 and r.empid = @param1 ; ", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get archived jobs by rec
        public int Getarcjobs(string empid)
        {
            var arrayrec = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand(@"select count(*) as total from jobs j, recruiters r, jobtable jt
                                            where j.idjobs = jt.idjobs and jt.empid = r.empid and jt.catid = 10000 and j.sactive = 0 and r.empid=@param1 ;",
                                               connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = empid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec = reader.GetInt32("total");
                    }
                }

                else
                {
                    return 0;
                }
                reader.Close();
            }

            return arrayrec;
        }

        //this is to populate the selections after the editjobs
        //form has loaded...

        public ArrayList Getmutitexts(string jobid)
        {
            var arrayrec = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select subcatid from jobtable where idJobs = @param1 ; ", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec.Add(reader.GetInt16("subcatid"));
                    }
                }

                else
                {
                    return null;
                }
                reader.Close();
            }

            return arrayrec;
        }

        //get job trends
        //get data for browsing categories
        public DataTable Gettrendsbyindustry()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_jobtrendsectors;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_jobtrendsectors");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public ArrayList Getjobidbyname(string jname)
        {
            //store rec details
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select * from vw_jobsuggest where sfreetext like @jname limit 5; ",
                                               connreader);
                command.Parameters.Add("@jname", MySqlDbType.VarChar).Value = '%' + jname + '%';
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

        public string Getrecjobassignment(string jobid)
        {
            string val = null;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select uusername from vw_recjobassignments where idjobs=@param1;",
                                               connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
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

        //get currencies for jobform
        public string Getcurrencyjobform(string jobid)
        {
            string val = null;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select scurrency from jobs where idjobs = @param1;",
                                               connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
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
    }
}