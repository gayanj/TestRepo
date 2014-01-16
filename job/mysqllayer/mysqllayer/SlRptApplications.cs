using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlRptApplications
    {
        public DataTable VwRptAppsall()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appsall;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appsall");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable VwRptAppscurrmonth()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appscurrmonth;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appscurrmonth");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable VwRptAppslast3Months()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appslast3months;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appslast3months");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable VwRptAppslast6Month()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appslast6month;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appslast6month");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable VwRptAppslastmonth()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appslastmonth", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appslastmonth");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable VwRptAppslastyear()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appslastyear", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appslastyear");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable VwRptAppsthisyear()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appsthisyear", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appsthisyear");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable VwRptAppstoday()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appstoday;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appstoday");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable VwRptAppsyesterday()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_rpt_appsyesterday;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rpt_appsyesterday");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //this is the dashboard reports for cms
        public DataTable CmsGetjobviewdata()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "select count(empid) as jobviews, dtentered as dateviewed from jobviews group by empid, dtentered;",
                    mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("jobviews");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable CmsAuditcan()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_logcandidate;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_logcandidate");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable CmsAuditrec()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_logrecruiter;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_logrecruiter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable CmsAuditall()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from tb_userarchives;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_userarchives");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //site wide logs or server logs
        public DataTable Getsitelogs()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from tb_loadbalancer;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_loadbalancer");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //content spam report
        public DataTable CmsSpamreport()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from vw_rptspamjobs;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_rptspamjobs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }
    }
}