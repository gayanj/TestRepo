using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlMainPagePopulator
    {
        //get job count
        public int Getcountjobs()
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(
                    "SELECT count(idjobs) FROM jobs where sjobenddate>= curdate();",
                    connreader);
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

        //get total recs
        public int Getcountrecs()
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(
                    "SELECT count(empid) FROM recruiters;",
                    connreader);
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

        //get advertizing rec count
        public int Getcountrecswadvert()
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(
                    "SELECT count(empid) FROM vw_getallrec;",
                    connreader);
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

        //gets max jobs
        /*
        public string Getmaxjobid()
        {
            var mg = new minGuid.Minimumguid();

            return mg.MinGuid();
        }
         

        //gets min jobs
        public int Getminjobid()
        {
            var connreader = new MySqlConnection { ConnectionString = Slconnect.Makeconn };

            var ct = 0;

            using (connreader)
            {
                var command = new MySqlCommand(
                    "SELECT min(idjobs) FROM jobs where sjobenddate >=curdate();",
                    connreader);
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
        */

        //delete current categories
        public void Deletejobs(string jobid)
        {
            var conn = new MySqlConnection();
            var cmd = new MySqlCommand();

            var myquerystring = "delete from jobtable where idjobs = '" + jobid + "' and catid !=10000 and subcatid !=10000; ";

            conn.ConnectionString = SlConnectionString.Makeconn;

            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = myquerystring;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //add jobs
        public void Insertjobs(string idjobs, string sTitle, string sShortDescription, string sDescription,
                               string ssalarytext, int ssalarymin, int ssalarymax, string sref, string startdate,
                               string enddate, bool videoset, string postcode, string location, string recname, string strcurr)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO jobs(`jobs`.`idJobs`, `jobs`.`sTitle`, `jobs`.`sShortDescription`, `jobs`.`sDescription`, `jobs`.`dtEnteredDate`, `jobs`.`sSalaryText`, `jobs`.`sMinSal`, `jobs`.`sMaxSal`, `jobs`.`sRef`, `jobs`.`sFreeText`, `jobs`.`sJobstartdate`, `jobs`.`sJobenddate`, sisvideoenabled ,`jobs`.`spostcode`,slocation,sRecruiterName, scurrency) values (@idjobs ,@sTitle ,@sShortDescription ,@sDescription ,@dtentered ,@ssalarytext  ,@ssalarymin  ,@ssalarymax ,@sref ,@sTitle , @startdate , @enddate, @sisvideoenabled, @spostcode, @slocation, @sRecruiterName, @scurrency);";

                    com.Parameters.Add("@idjobs", MySqlDbType.VarChar).Value = idjobs;
                    com.Parameters.Add("@sTitle", MySqlDbType.VarChar).Value = sTitle;
                    com.Parameters.Add("@sShortDescription", MySqlDbType.VarChar).Value = sShortDescription;
                    com.Parameters.Add("@sDescription", MySqlDbType.Text).Value = sDescription;
                    com.Parameters.Add("@dtentered", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@ssalarytext", MySqlDbType.VarChar).Value = ssalarytext;
                    com.Parameters.Add("@ssalarymin", MySqlDbType.Int16).Value = ssalarymin;
                    com.Parameters.Add("@ssalarymax", MySqlDbType.Int16).Value = ssalarymax;
                    com.Parameters.Add("@sref", MySqlDbType.VarChar).Value = sref;
                    com.Parameters.Add("@startdate", MySqlDbType.Date).Value = startdate;
                    com.Parameters.Add("@enddate", MySqlDbType.Date).Value = enddate;
                    com.Parameters.Add("@sisvideoenabled", MySqlDbType.Bit).Value = videoset;
                    com.Parameters.Add("@spostcode", MySqlDbType.String).Value = postcode;
                    com.Parameters.Add("@slocation", MySqlDbType.String).Value = location;
                    com.Parameters.Add("@sRecruiterName", MySqlDbType.String).Value = recname;
                    com.Parameters.Add("@scurrency", MySqlDbType.String).Value = strcurr;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //add job rec assignments
        public void Insertjobmapping(string idjobs, int catid, int lisubcatid, string empid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO jobtable(idjobs,  catid, subcatid, empid) values (@idjobs ,@catid , @lisubcatid ,@empid );";

                    com.Parameters.Add("@idjobs", MySqlDbType.VarChar).Value = idjobs;
                    com.Parameters.Add("@catid", MySqlDbType.Int32).Value = catid;
                    com.Parameters.Add("@lisubcatid", MySqlDbType.Int32).Value = lisubcatid;
                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = empid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get jobdetails page
        public string Getcurrrec(string empid)
        {
            var arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT artifact_data from recruiters,tb_artifacts where recruiters.sartifactID=tb_artifacts.sartifactID and recruiters.EmpID = @param1 limit 1;",
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

                else
                {
                    return null;
                }
                reader.Close();
            }
            return arrayrec;
        }

        //get rec details page
        public string[] Getdetailspage(string jobid)
        {
            var arrayrec = new string[10];
            arrayrec.AsParallel();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select jobs.*, recruiters.sRecruiterName, recruiters.sEmailAddress, recruiters.sWebsite,recruiters.EmpID from jobs, jobtable, recruiters where jobs.idJobs=jobtable.idJobs and jobtable.EmpID=recruiters.EmpID and jobs.idJobs = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString("sTitle");
                        arrayrec[1] = reader.GetString("sRef");
                        arrayrec[2] = reader.GetString("sDescription");
                        arrayrec[3] = reader.GetString("sJobstartdate");
                        arrayrec[4] = reader.GetString("sRecruiterName");
                        arrayrec[5] = reader.GetString("sEmailAddress");
                        arrayrec[6] = reader.GetString("sWebsite");
                        arrayrec[7] = reader.GetString("EmpID");
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

        //get details page
        public string Getdetailspagecats(string jobid, int cats)
        {
            var sbr = new StringBuilder();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select sdefinition from vw_getdetailspages where idJobs= @param1 and catid = @param2 ;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                command.Parameters.Add("@param2", MySqlDbType.Int32).Value = cats;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sbr.Append(" &raquo; ");
                        sbr.Append(reader.GetString(0));
                    }
                }

                reader.Close();
            }

            return sbr.ToString();
        }

        //get details for salaries
        //get details page
        public string Getdetailspagecats(string jobid, int cats, int jobsal)
        {
            var sbr = new StringBuilder();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select minrange,maxrange from vw_getdetailspages where idJobs= @param1 and catid = @param2 order by minrange;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                command.Parameters.Add("@param2", MySqlDbType.Int32).Value = cats;
                connreader.Open();

                var reader = command.ExecuteReader();

                var i = 0;
                var j = string.Empty;
                var k = string.Empty;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (i == 0)
                        {
                            k = reader.GetString(0);
                        }

                        j = reader.GetString(1);
                        i++;
                    }
                }

                //check which value is greater

                sbr.Append(k);
                sbr.Append(" - ");
                sbr.Append(j);

                reader.Close();
            }

            return sbr.ToString();
        }

        //fill in jobs form
        public string[] Filljobform(string jobid)
        {
            var arrayrec = new string[8];
            arrayrec.AsParallel();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select j.sTitle, j.sshortdescription, j.sjobstartdate, j.sjobenddate, j.ssalarytext, j.sref , j.sdescription, j.sLocation from jobs j where j.idJobs = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jobid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString("sTitle");
                        arrayrec[1] = reader.GetString("sShortDescription");
                        arrayrec[2] = reader.GetString("sJobstartdate");
                        arrayrec[3] = reader.GetString("sJobenddate");
                        arrayrec[4] = reader.GetString("sSalaryText");
                        arrayrec[5] = reader.GetString("sRef");
                        arrayrec[6] = reader.GetString("sDescription");
                        arrayrec[7] = reader.GetString("sLocation");
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        public DataTable GetSalary()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT subcatid, sdefinition from subcats where subcatid >= 6000 and subcatid <7000 order by subcatid;",
                    mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("subcats");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public ArrayList Getpostcodes()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT subcatid, sdefinition from subcats where subcatid >= 11000 and subcatid <14000 order by subcatid;",
                        connreader);
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

        public ArrayList Getsectors()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT subcatid, sdefinition, liparent from subcats where subcatid >= 9000 and subcatid <10000 order by subcatid;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
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

        public ArrayList GetLocations()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT subcatid, sdefinition, liparent from subcats where subcatid > 4000 and subcatid <5000 order by subcatid;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
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

        public ArrayList GetIndustries()
        {
            //store rec details
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT subcatid, sdefinition, liparent from subcats where subcatid >= 5000 and subcatid <6000 order by subcatid;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
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

        public ArrayList GetLocationstop()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT subcatid, sdefinition, liparent from subcats where subcatid > 4000 and subcatid <5000 order by subcatid where liparent = 0;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
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

        public ArrayList GetIndustriestop()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT subcatid, sdefinition, liparent from subcats where subcatid >= 5000 and subcatid <6000 order by subcatid where liparent=0;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
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

        public DataTable GetExperience()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand("SELECT subcatid, sdefinition from subcats where subcatid >= 7000 and subcatid<8000;",
                                 mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("subcats");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getsalaries()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT subcatid, sdefinition from subcats where subcatid >= 6000 and subcatid < 7000 ;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("subcats");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Geteducationlevel()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT subcatid, sdefinition from subcats where subcatid >= 14000 and subcatid < 15000 ;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("subcats");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getcareerlevel()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT subcatid, sdefinition from subcats where subcatid >= 15000 and subcatid < 16000 order by subcatid;",
                    mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("subcats");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getcontracts()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT subcatid, sdefinition from subcats where subcatid = 3000 OR subcatid = 3001 OR subcatid = 3002 order by subcatid;",
                    mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("subcats");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Gethours()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT subcatid, sdefinition from subcats where subcatid = 3003 OR subcatid = 3004 order by subcatid;",
                    mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("subcats");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }



        public DataTable GetJobs()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from vw_getjobs;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getjobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable GetJobssingle()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from vw_aggregatedmpage;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_aggregatedmpage");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get recruiterid by name
        public string Getrecname(string usrname)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = string.Empty;

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select rec.EmpID from recruiters rec, tb_rec_user_link rmap, users usr where rec.EmpID  = rmap.EmpID and rmap.idUsers = usr.idUsers and usr.uUsername = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = usrname;
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

        //get recruiter inactive jobs
        public DataTable GetJobssingle(string sEmpID)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from vw_getjobssingle where EmployeeID =@param1;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = sEmpID;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getjobssingle");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get recruiter active jobs
        public DataTable GetJobssinglearchived(string sEmpID)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from vw_getjobsarch where EmployeeID = @param1;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = sEmpID;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getjobsarch");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //gets max recruiters
        public string GetRecHasRows()
        {
            var mg = new minGuid.Minimumguid();

            return mg.MinGuid();
        }

        //max user id
        public string Getmaxuserid()
        {
            var mg = new minGuid.Minimumguid();

            return mg.MinGuid();
        }

        //max candidate id
        public string Getmaxcandidateid()
        {
            var mg = new minGuid.Minimumguid();

            return mg.MinGuid();
        }

        //add candidates
        public void Insertcandidates(string maxcanid, string cCandidateName, string cFirstName, string cLastName,
                                     string cAddress1, string cAddress2, string cAddress3, string cTown, string cCounty,
                                     string cCountry, string cPostcode, string sWebsite, string hphone, string wphone,
                                     string cdtEntered)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO candidates values (@maxcanid ,@cCandidateName ,@cFirstName , @cLastName , @cAddress1 ,@cAddress2 ,@cAddress3 ,@cTown ,@cCounty ,@cPostcode ,@hphone ,@wphone , @cdtEntered ,@cCountry);";

                    com.Parameters.Add("@maxcanid", MySqlDbType.VarChar).Value = maxcanid;
                    com.Parameters.Add("@cCandidateName", MySqlDbType.VarChar).Value = cFirstName + " " + cLastName;
                    com.Parameters.Add("@cFirstName", MySqlDbType.VarChar).Value = cFirstName;
                    com.Parameters.Add("@cLastName", MySqlDbType.VarChar).Value = cLastName;
                    com.Parameters.Add("@cAddress1", MySqlDbType.VarChar).Value = cAddress1;
                    com.Parameters.Add("@cAddress2", MySqlDbType.VarChar).Value = cAddress2;
                    com.Parameters.Add("@cAddress3", MySqlDbType.VarChar).Value = cAddress3;
                    com.Parameters.Add("@cTown", MySqlDbType.VarChar).Value = cTown;
                    com.Parameters.Add("@cCounty", MySqlDbType.VarChar).Value = cCounty;
                    com.Parameters.Add("@cpostcode", MySqlDbType.VarChar).Value = cPostcode;
                    com.Parameters.Add("@hphone", MySqlDbType.VarChar).Value = hphone;
                    com.Parameters.Add("@wphone", MySqlDbType.VarChar).Value = wphone;
                    com.Parameters.Add("cdtEntered", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@cCountry", MySqlDbType.VarChar).Value = cCountry;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }



        //add recruiters
        public void Insertrecruiters(string maxrec, string sRecruiterName, string sAddress1, string sAddress2,
                                     string sAddress3, string sTown, string sCounty, string sCountry, string sPostcode,
                                     string sEmailAddress, string sWebsite, string sDescription, string sCompleteDesc,
                                     string sdtEntered, int sEnteredbyID, string sartifactId)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO recruiters(EmpID, sRecruiterName, sAddress1, sAddress2, sAddress3, sTown, sCounty, sCountry, sPostcode, sEmailAddress, sWebsite, sDescription, sCompleteDesc, sdtEntered, sEnteredbyID, sIsFeatured, sartifactId, sIsActive) values (@maxrec ,@sRecruiterName ,@sAddress1 ,@sAddress2 ,@sAddress3 ,@sTown ,@sCounty ,@sCountry ,@sPostcode ,@sEmailAddress ,@sWebsite ,@sDescription ,@sCompleteDesc ,@sdtEntered ,@sEnteredbyID , 1,@sartifactId ,1 );";

                    com.Parameters.Add("@maxrec", MySqlDbType.VarChar).Value = maxrec;
                    com.Parameters.Add("@sRecruiterName", MySqlDbType.VarChar).Value = sRecruiterName;
                    com.Parameters.Add("@sAddress1", MySqlDbType.VarChar).Value = sAddress1;
                    com.Parameters.Add("@sAddress2", MySqlDbType.VarChar).Value = sAddress2;
                    com.Parameters.Add("@sAddress3", MySqlDbType.VarChar).Value = sAddress3;
                    com.Parameters.Add("@sTown", MySqlDbType.VarChar).Value = sTown;
                    com.Parameters.Add("@sCounty", MySqlDbType.VarChar).Value = sCounty;
                    com.Parameters.Add("@spostcode", MySqlDbType.VarChar).Value = sPostcode;
                    com.Parameters.Add("@sCountry", MySqlDbType.VarChar).Value = sCountry;
                    com.Parameters.Add("@sEmailAddress", MySqlDbType.VarChar).Value = sEmailAddress;
                    com.Parameters.Add("@sWebsite", MySqlDbType.VarChar).Value = sWebsite;
                    com.Parameters.Add("@sDescription", MySqlDbType.VarChar).Value = sDescription;
                    com.Parameters.Add("@sCompleteDesc", MySqlDbType.Text).Value = sCompleteDesc;
                    com.Parameters.Add("@sdtEntered", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@sEnteredbyID", MySqlDbType.Int32).Value = sEnteredbyID;
                    com.Parameters.Add("@sartifactId", MySqlDbType.VarChar).Value = sartifactId;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //add users
        public void Insertusers(string rusername, string fname, int uisprimary, string lname, string rpassword,
                                int rtype, string idUsers, string pwdhint, string ucandidateid, string uhash, string servid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO users(idusers, uusertype, uusername, upassword, upasswordhint, uFirstName, uLastName, uIsPrimary, uCandidateID, uActivation, serverid) values (@idUsers ,@rtype ,@rusername ,@rpassword ,@pwdhint ,@fname ,@lname ,1 , @ucandidateid, @uhash, @servid);";

                    com.Parameters.Add("@idUsers", MySqlDbType.VarChar).Value = idUsers;
                    com.Parameters.Add("@rtype", MySqlDbType.Int16).Value = rtype;
                    com.Parameters.Add("@rusername", MySqlDbType.VarChar).Value = rusername;
                    com.Parameters.Add("@rpassword", MySqlDbType.VarChar).Value = rpassword;
                    com.Parameters.Add("@pwdhint", MySqlDbType.VarChar).Value = pwdhint;
                    com.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                    com.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                    com.Parameters.Add("@ucandidateid", MySqlDbType.VarChar).Value = ucandidateid;
                    com.Parameters.Add("@uhash", MySqlDbType.VarChar).Value = uhash;
                    com.Parameters.Add("@servid", MySqlDbType.VarChar).Value = servid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //add rec user mapping
        public void Insertrecusermapping(string empid, string userid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO tb_rec_user_link(EmpID, idUsers) values (@empid ,@userid );";

                    com.Parameters.Add("@empid", MySqlDbType.VarChar).Value = userid;
                    com.Parameters.Add("@userid", MySqlDbType.VarChar).Value = empid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //getrecruiterdetails
        public string[] GetRecDetails(string usrname)
        {
            var arrayrec = new string[17];
            arrayrec.AsParallel();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select rec.*,usr.* from recruiters rec, tb_rec_user_link rmap, users usr where rec.EmpID  = rmap.EmpID and rmap.idUsers = usr.idUsers and usr.uUsername = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = usrname;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString("uFirstName");
                        arrayrec[1] = reader.GetString("uLastName");
                        arrayrec[2] = reader.GetString("sRecruiterName");

                        arrayrec[3] = reader.GetString("sAddress1");
                        arrayrec[4] = reader.GetString("sAddress2");
                        arrayrec[5] = reader.GetString("sAddress3");
                        arrayrec[6] = reader.GetString("sTown");
                        arrayrec[7] = reader.GetString("sCounty");
                        arrayrec[8] = reader.GetString("sCountry");
                        arrayrec[9] = reader.GetString("sPostcode");

                        arrayrec[10] = "XXXXXXXXXX";
                        arrayrec[11] = reader.GetString("uPasswordHint");

                        arrayrec[12] = reader.GetString("sEmailAddress");
                        arrayrec[13] = reader.GetString("sWebsite");

                        arrayrec[14] = reader.GetString("sdescription");
                        arrayrec[15] = reader.GetString("scompletedesc");
                        arrayrec[16] = reader.GetString("sIsAgent");
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        //edit jobs
        public void Updatejobs(string idjobs, string sTitle, string sShortDescription, string sDescription,
                               string ssalarytext, int ssalarymin, int ssalarymax, string sref, string sdate,
                               string edate, string postcode, string location, string recname, string strcurr)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE jobs SET sTitle=@sTitle , sShortDescription = @sShortDescription ,sDescription = @sDescription , dtentereddate= @curdates , ssalarytext = @ssalarytext ,sminsal = @ssalarymin , smaxsal = @ssalarymax , sref = @sref , sfreetext= @sTitle , sjobstartdate = @sdate , spostcode=@postcode ,sjobenddate= @edate, slocation = @location, sRecruiterName=@sRecruiterName , scurrency= @scurrency where idjobs = @idjob;";

                    com.Parameters.Add("@sTitle", MySqlDbType.VarChar).Value = sTitle;
                    com.Parameters.Add("@sShortDescription", MySqlDbType.VarChar).Value = sShortDescription;
                    com.Parameters.Add("@sDescription", MySqlDbType.Text).Value = sDescription;
                    com.Parameters.Add("@curdates", MySqlDbType.DateTime).Value = DateTime.Now;
                    com.Parameters.Add("@ssalarytext", MySqlDbType.VarChar).Value = ssalarytext;
                    com.Parameters.Add("@ssalarymin", MySqlDbType.Int32).Value = ssalarymin;
                    com.Parameters.Add("@ssalarymax", MySqlDbType.Int32).Value = ssalarymax;
                    com.Parameters.Add("@sref", MySqlDbType.VarChar).Value = sref;
                    com.Parameters.Add("@sdate", MySqlDbType.Date).Value = sdate;
                    com.Parameters.Add("@edate", MySqlDbType.Date).Value = edate;
                    com.Parameters.Add("@idjob", MySqlDbType.VarChar).Value = idjobs;
                    com.Parameters.Add("@postcode", MySqlDbType.String).Value = postcode;
                    com.Parameters.Add("@location", MySqlDbType.String).Value = location;
                    com.Parameters.Add("@sRecruiterName", MySqlDbType.String).Value = recname;
                    com.Parameters.Add("@scurrency", MySqlDbType.String).Value = recname;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //get user my applications
        public DataTable Getmyapps(string uusername)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from vw_getmyapps where uusername= @param1;", mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = uusername;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getmyapps");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get candidate detail page
        public string[] Getcandidatedetails(string susername)
        {
            var arrayrec = new string[12];
            arrayrec.AsParallel();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT cfirstname, clastname, caddress1, caddress2, caddress3, ctown, ccounty, ccountry, cpostcode, chomephone, cworkphone , uusername FROM vw_getusercans where uusername = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = susername;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString("cfirstname");
                        arrayrec[1] = reader.GetString("clastname");
                        arrayrec[2] = reader.GetString("caddress1");
                        arrayrec[3] = reader.GetString("caddress2");
                        arrayrec[4] = reader.GetString("caddress3");
                        arrayrec[5] = reader.GetString("ctown");
                        arrayrec[6] = reader.GetString("ccounty");
                        arrayrec[7] = reader.GetString("ccountry");
                        arrayrec[8] = reader.GetString("cpostcode");
                        arrayrec[9] = reader.GetString("chomephone");
                        arrayrec[10] = reader.GetString("cworkphone");
                        //arrayrec[11] = reader.GetString("cdateofbirth");
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }

        //insert comments from users
        public void Insertsitecomment(string sEmailaddress, string sComment, string sIp)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_sitesuggestions(sEmailaddress, sComment, sIp) values (@sEmailaddress ,@sComment , @sIp );";

                    com.Parameters.Add("@sEmailaddress", MySqlDbType.VarChar).Value = sEmailaddress;
                    com.Parameters.Add("@sComment", MySqlDbType.VarChar).Value = sComment;
                    com.Parameters.Add("@sIp", MySqlDbType.VarChar).Value = sIp;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}