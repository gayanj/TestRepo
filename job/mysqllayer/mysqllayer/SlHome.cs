using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlHome
    {
        public DataTable Gethplocation()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT sdefinition,subcatid,ctotals from vw_brfilter where catid=1000 and liparent = 0;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_brfilter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Gethpindustry()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT sdefinition,subcatid,ctotals from vw_brfilter where catid=1001 and liparent =0;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_brfilter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Gethpsalary()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT sdefinition,subcatid,ctotals from vw_brfilter where catid=1005;",
                                             mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_brfilter");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }
    }
}