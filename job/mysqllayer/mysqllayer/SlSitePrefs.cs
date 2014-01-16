using System.Text;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlSitePrefs
    {
        public string Getsitepref()
        {
            using (var conn = new MySqlConnection())
            {
                //conn.ConnectionString = ConfigurationManager.ConnectionStringBs["psearch"].ConnectionString;
                //Clconnect kenect = new Clconnect();
                conn.ConnectionString = SlConnectionString.Makeconn;

                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "select seo_description from tb_siteheader;";

                    cmd.Connection = conn;

                    var sb = new StringBuilder();

                    conn.Open();
                    using (var sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            sb.AppendLine(sdr["seo_description"].ToString());
                        }
                    }
                    conn.Close();

                    return sb.ToString();
                }
            }
        }
    }
}