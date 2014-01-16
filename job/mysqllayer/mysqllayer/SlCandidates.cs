using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlCandidates
    {
        public string Getcanidbyappid(string appid)
        {
            var val = string.Empty;

            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select licandidateid,idapplications from vw_getapp where idapplications = @param1", connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = appid;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        val = reader.GetString(0);
                    }
                }

                reader.Close();
            }
            return val;
        }

        public void Updatecandidatetable(string cfirstname, string clastname, string address1, string address2,
                                         string address3, string town, string county, string country, string postcode,
                                         string hometel, string worktel, string uusername)
        {
            using (var con = new MySqlConnection())
            {
                con.ConnectionString = SlConnectionString.Makeconn;
                con.Open();

                using (var com = con.CreateCommand())
                {
                    com.CommandType = CommandType.Text;
                    com.CommandText =
                        "update users usr, candidates can SET can.cCandidateName= @candidaten , can.cFirstName=@cfirstname, can.cLastName =@clastname, can.cAddress1=@cAddress1, can.cAddress2=@cAddress2, can.cAddress3=@cAddress3, can.cTown = @cTown, can.cCounty=@cCounty, can.cCountry=@cCountry, can.cPostcode=@cPostcode, can.cHomephone=@hometel ,can.cWorkphone=@worktel where can.idcandidates = usr.ucandidateid and usr.uusertype=2 and usr.uusername=@uusername ;";

                    com.Parameters.Add("@cfirstname", MySqlDbType.VarChar).Value = cfirstname;
                    com.Parameters.Add("@clastname", MySqlDbType.VarChar).Value = clastname;
                    com.Parameters.Add("@cAddress1", MySqlDbType.VarChar).Value = address1;
                    com.Parameters.Add("@cAddress2", MySqlDbType.VarChar).Value = address2;
                    com.Parameters.Add("@cAddress3", MySqlDbType.VarChar).Value = address3;
                    com.Parameters.Add("@cTown", MySqlDbType.VarChar).Value = town;
                    com.Parameters.Add("@cCounty", MySqlDbType.VarChar).Value = county;
                    com.Parameters.Add("@cCountry", MySqlDbType.VarChar).Value = country;
                    com.Parameters.Add("@cpostcode", MySqlDbType.VarChar).Value = postcode;
                    com.Parameters.Add("@hometel", MySqlDbType.VarChar).Value = hometel;
                    com.Parameters.Add("@worktel", MySqlDbType.VarChar).Value = worktel;
                    com.Parameters.Add("@uusername", MySqlDbType.VarChar).Value = uusername;
                    com.Parameters.Add("@candidaten", MySqlDbType.VarChar).Value = cfirstname + " " + clastname;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        //user to get direct applications for candidates who have registered as can.
        public string[] Getcandidatesindb(string uusername)
        {
            var arrayrec = new string[4];
            var connreader = new MySqlConnection { ConnectionString = SlConnectionString.Makeconn };

            using (connreader)
            {
                var command =
                    new MySqlCommand(
                        "select usr.uusername, can.cfirstname, can.clastname, can.idCandidates from candidates can, users usr where can.idcandidates = usr.ucandidateid and usr.uUserName = @param1 limit 1;",
                        connreader);
                command.Parameters.Add("@param1", MySqlDbType.VarChar).Value = uusername;
                connreader.Open();

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            arrayrec[0] = reader.GetString(0);
                            arrayrec[1] = reader.GetString(1);
                            arrayrec[2] = reader.GetString(2);
                            arrayrec[3] = reader.GetString(3);
                        }
                        catch
                        {
                            return null;
                        }
                    }
                }

                reader.Close();
            }
            return arrayrec;
        }
    }
}