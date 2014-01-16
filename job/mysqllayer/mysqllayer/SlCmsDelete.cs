using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlCmsDelete
    {
        public void DeleteCmsRecruiter(int uid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = uid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsJobseeker(int uid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = uid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsAdmin(int uid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = uid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsJobs(int jid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = jid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsApplications(int appid)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = appid;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsSiteHeaders(int id)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = id;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsTitles(int id)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = id;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsGlobalOptions(int id)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = id;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsSiteLinks(int id)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = id;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsSalaryCat(int id)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = id;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsEmailTempl(int id)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = id;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsArticles(int id)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = id;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void DeleteCmsSubsite(int id)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "";

                    com.Parameters.Add("@idmod", MySqlDbType.Int32).Value = id;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}