using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlSearchMain
    {
        public ArrayList Mcjobtable()
        {
            using (var conn = new MySqlConnection())
            {
                conn.ConnectionString = SlConnectionString.Makeconn;

                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "select jt.idJobs as idjobs, jt.subcatid as subcatid,  jt.empid as empid from (`jobtable` `jt` join `jobs` `j`) where ((`jt`.`idJobs` = `j`.`idJobs`) and (`j`.`sJobenddate` >= curdate()));";

                    cmd.Connection = conn;

                    var arr1 = new ArrayList();

                    conn.Open();
                    using (var sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            arr1.Add(sdr[0].ToString());
                            arr1.Add(sdr[1].ToString());
                            arr1.Add(sdr[2].ToString());
                        }
                    }
                    conn.Close();

                    return arr1;
                }
            }
        }

        public DataTable Getsitesearch(string qry)
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };
            mycon.Open();

            var selectcmd =
                new MySqlCommand(
                    "select titles, description, url, match (titles, description, url) against ('" + qry +
                    "' IN BOOLEAN MODE) as score from tb_sitesearch where match (titles, description, url) against ('" +
                    qry + "' IN BOOLEAN MODE) > 0 order by score desc; ", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_sitesearch");
            selectdataadp.Fill(dt);
            mycon.Clone();

            return dt;
        }
    }
}