using System;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlArticles
    {
        public void Insertarticles(string articlename, string articleurl, string articledata)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_articles( `tb_articles`.`Articlename`, `tb_articles`.`Articleurl`, `tb_articles`.`Articledata`, `tb_articles`.`dtEntered`) values ( @sarticlename, @sarticleurl, @sarticledata, @sdtentered);";

                    com.Parameters.Add("@sarticlename", MySqlDbType.VarChar).Value = articlename;
                    com.Parameters.Add("@sarticleurl", MySqlDbType.VarChar).Value = articleurl;
                    com.Parameters.Add("@sarticledata", MySqlDbType.VarChar).Value = articledata;
                    com.Parameters.Add("@sdtentered", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public DataTable Getallartlist()
        {
            var mycon = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            mycon.Open();

            var selectcmd =
                new MySqlCommand(
                    "select id_articles, articlename, articleurl from tb_articles order by id_articles desc;", mycon) { CommandType = CommandType.Text };

            var selectdataadp = new MySqlDataAdapter { SelectCommand = selectcmd };

            var dt = new DataTable("tb_articles");
            selectdataadp.Fill(dt);

            mycon.Clone();

            return dt;
        }

        public ArrayList Getallarticlebyid(string idart)
        {
            var tempst = new ArrayList();

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command = new MySqlCommand("select * from tb_articles where id_articles=@param1;", connreader) { CommandType = CommandType.Text };
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = idart;

                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tempst.Add(reader.GetString(0));
                        tempst.Add(reader.GetString(1));
                        tempst.Add(reader.GetString(2));
                        tempst.Add(reader.GetString(3));
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