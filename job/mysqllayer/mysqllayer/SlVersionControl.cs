using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlVersionControl
    {
        public string Getcurrentversion()
        {
            //store rec details
            var ekval = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select versionnumber from tb_version order by idversion desc limit 1;",
                                               connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ekval = reader.GetString(0);
                    }
                }

                reader.Close();
            }
            return ekval;
        }
    }
}