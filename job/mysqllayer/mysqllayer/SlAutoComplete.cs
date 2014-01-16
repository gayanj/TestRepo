using System.Collections;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlAutoComplete
    {
        public ArrayList Getsearchjobcp()
        {
            using (var conn = new MySqlConnection())
            {
                conn.ConnectionString = SlConnectionString.Makeconn;

                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "select distinct sTitle from jobs where sjobenddate>=curdate() order by sTitle;";

                    cmd.Connection = conn;
                    var arr1 = new ArrayList();

                    conn.Open();
                    using (var sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            arr1.Add(sdr["sTitle"].ToString());
                        }
                    }
                    conn.Close();

                    return arr1;
                }
            }
        }

        public ArrayList Getsearchreccp()
        {
            using (var conn = new MySqlConnection())
            {
                conn.ConnectionString = SlConnectionString.Makeconn;

                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText =
                        "select srecruitername from recruiters where sisactive=1 order by srecruitername ;";

                    cmd.Connection = conn;

                    var arr1 = new ArrayList();

                    conn.Open();
                    using (var sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            arr1.Add(sdr["srecruitername"].ToString());
                        }
                    }
                    conn.Close();

                    return arr1;
                }
            }
        }
    }
}