using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlArtifacts
    {
        public void Insertartifacts(string sartifactID, string artifactName, string artifactData)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText = "INSERT INTO tb_artifacts(sArtifactID, artifactName, artifact_data)  values ( @sartifactID, @artifactName, @artifact_data);";

                    com.Parameters.Add("@sartifactID", MySqlDbType.VarChar).Value = sartifactID;
                    com.Parameters.Add("@artifactName", MySqlDbType.VarChar).Value = artifactName;
                    com.Parameters.Add("@artifact_data", MySqlDbType.VarChar).Value = artifactData;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}