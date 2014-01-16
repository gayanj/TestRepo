using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlFeaturedRecruiters
    {
        //get recruiters logo for profiles form
        public string Getrecformimage(string recsids)
        {
            string arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "SELECT artifact_data from recruiters,tb_artifacts where recruiters.sartifactID=tb_artifacts.sartifactID and recruiters.empid = @param1 limit 1; ",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = recsids;
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

        //get top 3 featured recruiters
        public DataTable GetFRecs()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_getfrecs order by rand() limit 3;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getfrecs");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }

        //get main page weekly featured recruiter
        public DataTable Getrecofweek()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            var selectcmd = new MySqlCommand("select * from vw_getrecofweek;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("vw_getrecofweek");
            selectdataadp.Fill(dt);

            mycon.Close();

            return dt;
        }
    }
}