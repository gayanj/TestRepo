using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlJobCart
    {
        public string Getjobscart(string jid)
        {
            string arrayrec = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("Select sTitle from jobs where idjobs=@param1 and sjobenddate>= curdate();",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = jid;
                connreader.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec = reader.GetString("sTitle");
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
    }
}