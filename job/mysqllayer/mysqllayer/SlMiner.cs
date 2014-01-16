using System.Linq;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlMiner
    {
        public string[,] Getmarketbasket(string matchs)
        {
            using (var conn = new MySqlConnection())
            {
                conn.ConnectionString = SlConnectionString.Makeconn;

                var arr1 = new string[2, 4];
                arr1.AsParallel();

                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText =
                        "select idjobs, sTitle from jobs where sjobenddate>=curdate() and match(sfreetext) against (@param1 IN NATURAL LANGUAGE MODE) limit 4;";
                    cmd.Parameters.Add("@param1", MySqlDbType.VarChar).Value = matchs;
                    cmd.Connection = conn;

                    var i = 0;

                    conn.Open();
                    using (var sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            arr1[0, i] = sdr["idjobs"].ToString();
                            arr1[1, i] = sdr["sTitle"].ToString();
                            i++;
                        }
                    }
                    conn.Close();

                    return arr1;
                }
            }
        }
    }
}