using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlCustomizeOption1
    {
        public DataTable Getfooterlinks()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from tb_footerlinks;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_footerlinks");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Getmiddlelinks()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT * from tb_middlelinks;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_middlelinks");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }
    }
}