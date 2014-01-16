using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlNotes
    {
        public void Insertanote(string idcan, string comment)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "INSERT INTO tb_notes(idCandidates,commentdescription) values ( @idcan, @comment);";

                    com.Parameters.Add("@idcan", MySqlDbType.VarChar).Value = idcan;
                    com.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Updatenote(string idcan, string comment)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "UPDATE tb_notes set commentdescription=@comment where idCandidates = @idcan;";

                    com.Parameters.Add("@idcan", MySqlDbType.VarChar).Value = idcan;
                    com.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public string Getnote(string idcan)
        {
            var arraynotes = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand("SELECT commentdescription from tb_notes where idCandidates = @param1 limit 1; ",
                                     connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = idcan;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arraynotes = reader.GetString(0);
                    }
                }

                else
                {
                    return null;
                }
                reader.Close();
            }
            return arraynotes;
        }
    }
}