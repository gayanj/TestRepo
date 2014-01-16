using System.Data;
using MySql.Data.MySqlClient;

namespace Mysqllayer
{
    public class SlWidgetLog
    {
        public void Insertcompwbj(string companyname, string companydescription, string firstname, string lastname,
                                  string telephone, string website)
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
                        "insert into tb_widgetlog(companyname, companydescription, firstname, lastname, telephone, website) values(@param1,@param2,@param3,@param4,@param5,@param5)";

                    com.Parameters.Add("@param1", MySqlDbType.String).Value = companyname;
                    com.Parameters.Add("@param2", MySqlDbType.String).Value = companydescription;
                    com.Parameters.Add("@param3", MySqlDbType.String).Value = firstname;
                    com.Parameters.Add("@param4", MySqlDbType.String).Value = lastname;
                    com.Parameters.Add("@param5", MySqlDbType.String).Value = telephone;
                    com.Parameters.Add("@param6", MySqlDbType.String).Value = website;

                    var reslt = com.ExecuteNonQuery();
                }

                con.Close();
            }
        }
    }
}