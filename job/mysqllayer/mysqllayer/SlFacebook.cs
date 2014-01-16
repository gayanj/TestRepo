using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Mysqllayer
{
    public class SlFacebook
    {
        public DataTable GetJobs(string q, int low, int high)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand(@"select j.idjobs, j.stitle, concat(date(j.sjobstartdate),' | ', j.ssalarytext, ' | ', j.srecruitername) as collect, j.ssalarytext, j.sShortDescription, j.srecruitername from jobs j, recruiters r, jobtable jt where j.idjobs = jt.idjobs and jt.empid = r.empid and  jt.catid = 10000 and  j.sactive = 1 order by dtentereddate desc " + q + " limit " + low + " , " + high + " ; ", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int GetJobsTotal(string q, int low, int high)
        {
            var arrayrec = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand(@"select count(j.idjobs) as total from jobs j, recruiters r, jobtable jt where j.idjobs = jt.idjobs and jt.empid = r.empid and  jt.catid = 10000 and  j.sactive = 1 " + q + " limit " + low + " , " + high + " ; ", connreader);

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec = reader.GetInt32("total");
                    }
                }

                reader.Close();
            }

            return arrayrec;
        }

        public DataTable GetJobs(int low, int high)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand(@"select j.idjobs, j.stitle, concat(date(j.sjobstartdate),' | ', j.ssalarytext, ' | ', j.srecruitername) as collect, j.dtentereddate, j.ssalarytext, j.sShortDescription, j.srecruitername from jobs j, recruiters r, jobtable jt
                                                where j.idjobs = jt.idjobs and jt.empid = r.empid and  jt.catid = 10000 and  j.sactive = 1 order by dtentereddate desc limit " + low + " , " + high + "; ", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public int GetJobsTotal(int low, int high)
        {
            var arrayrec = 0;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand(@"select count(j.idjobs) as total from jobs j, recruiters r, jobtable jt
                                                where j.idjobs = jt.idjobs and jt.empid = r.empid and  jt.catid = 10000 and  j.sactive = 1 limit " + low + " , " + high + "; ",
                                               connreader);

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
    }
}
