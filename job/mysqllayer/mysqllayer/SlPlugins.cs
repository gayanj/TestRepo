using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlPlugins
    {
        public string Getpluginsharethis()
        {
            var ekval = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select sdefinition from tb_pluginsharethis ;", connreader);

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