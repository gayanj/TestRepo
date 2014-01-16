using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlHelpCenter
    {
        public DataTable Gethelpcategories()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_helpansgrouping;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_helpansgrouping");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Gethelpquestions()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("SELECT idtb_helpcenterqs, Question from tb_helpcenterqs limit 500;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_helpcenterqs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Gethelpquestions(string question)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT idtb_helpcenterqs, Question from tb_helpcenterqs where Question like @param1 limit 100;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.String).Value = "%" + question + "%";

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_helpcenterqs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public DataTable Gethelpquestions(int categoryid)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd =
                new MySqlCommand(
                    "SELECT idtb_helpcenterqs, Question from vw_helpansbycategory where hcatid = @param1 limit 500;",
                    mycon) { CommandType = CommandType.Text };

            selectcmd.Parameters.Add("@param1", MySqlDbType.Int32).Value = categoryid;

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_helpansbycategory");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        public string[] Gethelpanswer(int questionid)
        {
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var ct = new string[2];

            using (connreader)
            {
                var command =
                    new MySqlCommand("SELECT Question, answer from tb_helpcenterqs where idtb_helpcenterqs = @param1;",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.Int32).Value = questionid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ct[0] = reader.GetString(0);
                        ct[1] = reader.GetString(1);
                    }
                }
                reader.Close();
            }
            return ct;
        }
    }
}