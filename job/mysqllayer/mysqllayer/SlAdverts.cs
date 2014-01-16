using System.Collections;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlAdverts
    {
        //get whole site master page top banner
        public ArrayList Getmasterpagesiteads()
        {
            //store rec details
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select adtitle, adpath, adurl from tb_advertdetail where adkey = 5 and astatus = 1 order by rand() limit 1;",
                        connreader);
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

        //get login micro adverts
        public ArrayList Getmicrologinads()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select adtitle, adtext, adurl from tb_advertdetail where adkey = 3 and astatus = 1 order by rand() limit 4;",
                        connreader);
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

        public ArrayList Getstockbarads()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select adtitle, adtext, adurl from tb_advertdetail where adkey = 4 and astatus = 1 order by rand() limit 5;",
                        connreader);
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

        public ArrayList Getadvertstring()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select adpath, adsection, adkey from vw_adgen where adkey=1;",
                                               connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
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

        //searched page ads
        public ArrayList Getjobtextadverts()
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select idjobs, stitle, sshortdescription from vw_textads order by rand() limit 1;", connreader);
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
                    return null;
                }
                reader.Close();
            }

            tempst.TrimToSize();

            return tempst;
        }

        //desktop ads
        public string[] Getdesktoptadstr()
        {
            var tempst = new string[3];

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select adtitle, adtext, adurl from tb_advertdetail where adkey=2 order by rand() limit 1;",
                        connreader);
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst[0] = reader.GetString(0);
                        tempst[1] = reader.GetString(1);
                        tempst[2] = reader.GetString(2);
                    }
                }

                else
                {
                    reader.Close();
                    return null;
                }

                reader.Close();
            }

            connreader.Close();
            return tempst;
        }
    }
}