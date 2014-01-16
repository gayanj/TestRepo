using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlCmsApplications
    {
        //selected candidates, candidates for interview
        public DataTable Cmsselectedapps()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            mycon.Open();

            var selectcmd =
                new MySqlCommand(" select * from applications where aApplicationstatus = 1 or aApplicationstatus=2 ; ",
                                 mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("applications");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }

        //rejected applications
        public DataTable Cmsrejectedapps()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            mycon.Open();

            var selectcmd = new MySqlCommand(" select * from applications where aApplicationstatus = 4; ", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("applications");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }

        //apps under review
        public DataTable Cmsawaitingdapps()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            mycon.Open();

            var selectcmd = new MySqlCommand(" select * from applications where aApplicationstatus = 0; ",
                                                      mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("applications");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }

        //all applications
        public DataTable Cmsallapps()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            mycon.Open();

            var selectcmd = new MySqlCommand(" select * from applications; ", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("applications");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }
    }
}