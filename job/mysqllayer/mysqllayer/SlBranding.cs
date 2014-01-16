using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlBranding
    {
        //global branding option get
        public string Getbrandoption(string kname)
        {
            var ekval = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select kpivalue from tb_branding where kpiname = @param1 ;", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = kname;
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