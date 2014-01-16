using System.Collections;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlSitemap
    {
        public ArrayList Getsitemapitems()
        {
            //store rec details
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select url, title, level from tb_sitemaps;", connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
                    }
                }

                else
                {
                    reader.Close();
                    return null;
                }

                reader.Close();
            }

            tempst.TrimToSize();

            connreader.Close();
            return tempst;
        }
    }
}