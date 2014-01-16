using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlVideo
    {
        public void Addvideo(string videotitle, string videourl, string idjobs)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_videos(idjobs, video_title,video_url, dtentered) values ( @sidjobs, @svideotitle, @svideourl, @vddate);";

                    com.Parameters.Add("@sidjobs", MySqlDbType.VarChar).Value = idjobs;
                    com.Parameters.Add("@svideotitle", MySqlDbType.VarChar).Value = videotitle;
                    com.Parameters.Add("@svideourl", MySqlDbType.VarChar).Value = videourl;
                    com.Parameters.Add("@vddate", MySqlDbType.DateTime).Value = DateTime.Now;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Enablevideo(string idjobs)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "update jobs set sisvideoenabled = true where idjobs = @sidjobs;";

                    com.Parameters.Add("@sidjobs", MySqlDbType.VarChar).Value = idjobs;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Disablevideo(string idjobs)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "update jobs set sisvideoenabled = false where idjobs = @sidjobs;";

                    com.Parameters.Add("@sidjobs", MySqlDbType.VarChar).Value = idjobs;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Updatevideo(string videotitle, string videourl, string idjobs)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "UPDATE tb_videos set video_title =@svideotitle ,video_url=@svideourl where idjobs = @sidjobs;";

                    com.Parameters.Add("@sidjobs", MySqlDbType.VarChar).Value = idjobs;
                    com.Parameters.Add("@svideotitle", MySqlDbType.VarChar).Value = videotitle;
                    com.Parameters.Add("@svideourl", MySqlDbType.VarChar).Value = videourl;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Removevideo(string idjobs)
        {
            //
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "UPDATE tb_videos set sdeleted =1 where idjobs = @sidjobs;";

                    com.Parameters.Add("@sidjobs", MySqlDbType.VarChar).Value = idjobs;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public string[] Getvideo(string idjobs)
        {
            //store rec details
            var arrayrec = new string[2];

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select video_title, video_url from tb_videos where sdeleted = 0 and idjobs = @param1",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = idjobs;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arrayrec[0] = reader.GetString(0);
                        arrayrec[1] = reader.GetString(1);
                    }
                }

                else
                {
                    return null;
                }

                reader.Close();
            }

            return arrayrec;
        }
    }
}